using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BZGUI
{
    //保压工站
    sealed class Sta3Run
    {
        private static int TimeOut = 0;
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        public static void AutoRun(ref PVar.WorkType StaWork)
        {
            try
            {
                switch (StaWork.Step)
                {
                    case 10:
                        if (PVar.Stop_Flag == false)
                        {
                            StaWork.State = false;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        //本站工作状态，工站使能，本站是否有产品，转盘工作状态
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (StaWork.State == false && StaWork.Enable && StaWork.Result && StaWork.IsHaveHSG && PVar.Sta_Work[1].State == false)
                            {
                                StaWork.State = true;
                                StaWork.Result = false;
                                //清空缓存的压力值
                                for (int i = PVar.Press.Count() - 1; i > 0; i--)
                                {
                                    PVar.Press[i] = 0;
                                }
                                Command.Com2_Send(Command.压力控制打开);
                                Gg.SetExDo(0, 0, Gg.OutPut2.保压升降气缸, 1);
                                AddList("复检开始开始！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                StaWork.Step = 10;
                            }
                        }
                        else
                        {
                            if (StaWork.State == false && StaWork.Enable && StaWork.IsHaveHSG && PVar.Sta_Work[1].State == false)
                            {
                                StaWork.State = true;
                                StaWork.Result = false;
                                //清空缓存的压力值
                                for (int i = PVar.Press.Count() - 1; i > 0; i--)
                                {
                                    PVar.Press[i] = 0;
                                }
                                Command.Com2_Send(Command.压力控制打开);
                                Gg.SetExDo(0, 0, Gg.OutPut2.保压升降气缸, 1);
                                AddList("复检开始开始！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                        }
                        break;

                    case 30:
                        if (Gg.GetExDi(0, Gg.InPut2.保压升降气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut2.保压升降气缸伸出) == 1)
                        {
                            //AddList("保压升降气缸复位OK！");
                            Frm_Production.fProduction.Chart_Time.Enabled = true;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 40;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("保压升降气缸伸出信号异常！");
                                ShowList("保压升降气缸伸出信号异常！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                            }
                        }
                        break;

                    case 40:
                        if (API.GetTickCount() - TimeOut > 100)
                        {
                            Gg.AbsMotion(0, 8, mFunction.Pos.TeachAxis1[1, 1], PVar.ParAxis.Speed[BVar.S3_Z]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                        }
                        break;

                    case 50:
                        if (Gg.ZSPD(0, BVar.S3_Z))
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut2.保压升降气缸, 0);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 60;
                        }
                        break;

                    case 60:
                        if (PVar.IsCOM2_Working)
                        {
                            //**保压位置+偏移值=终点最大行程
                            Gg.AbsMotion(0, 8, mFunction.Pos.TeachAxis1[1, 1] + PVar.ParList.Data[22], PVar.ParList.Data[23]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 70;
                        }
                        else
                        {
                            AddList("保压站压力传感器异常！");
                            ShowList("保压站压力传感器异常！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                        }
                        break;

                    case 70:
                        if (Gg.ZSPD(0, BVar.S3_Z))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 80;
                        }
                        break;

                    case 80:
                        if (API.GetTickCount() - TimeOut > PVar.ParList.Data[41] * 1000)
                        {
                            Gg.AbsMotion(0, 8, mFunction.Pos.TeachAxis1[1, 0], PVar.ParAxis.Speed[BVar.S3_Z]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 90;
                        }
                        break;

                    case 90:
                        if (Gg.ZSPD(0, BVar.S3_Z))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 800;
                        }
                        break;

                    case 800:
                        Frm_Production.fProduction.Chart_Time.Enabled = false;
                        StaWork.Enable = false;
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    //严重错误，急停处理
                    case 10000:
                        Frm_Engineering.fEngineering.MacStop();
                        break;
                }

            }
            catch (Exception exc)
            {
                string Error_Str = "";
                string Error_Str1 = "";
                Frm_Engineering.fEngineering.MacStop();
                MessageBox.Show(exc.Message);
                Error_Str = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_代码异常记录" + ".txt";
                Error_Str1 = "\r\n" + "※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※" + "\r\n" +
                    "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "\r\n" + exc.ToString();
                FileRw.WriteDattxt(Error_Str, Error_Str1);
            }
        }


    }
}
