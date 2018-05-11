using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BZGUI
{
    //供料工站
    sealed class Sta0Run
    {
        private static int BufferStep = 0;
        private static bool Once = false;
        private static int TimeOut = 0;
        public static bool BlogoIsReady = false;
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
                            if (Once == false)
                            {
                                if (BVar.FileRorW.ReadINI("Material_index", "是否片料", "有", PVar.PublicParPath) == "有")
                                {
                                    StaWork.IsHavePianliao = true;
                                }
                                else
                                {
                                    StaWork.IsHavePianliao = false;
                                }
                            }
                            StaWork.State = false;
                            TimeOut = API.GetTickCount();
                            //StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        if (StaWork.State == false && StaWork.Enable)
                        {
                            StaWork.State = true;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 30;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 500)
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 10;
                            }
                        }
                        break;

                    case 30:
                        Once = true;
                        if (StaWork.IsHavePianliao)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 10;
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 40;
                        }
                        break;

                    case 40:
                        //判断料仓有无物料
                        if (Gg.GetDi(0, Gg.InPut0.片料到位检测) == 1)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 60;
                        }
                        else
                        {

                        }
                        break;

                    case 60:
                        Gg.SetExDo(0, 0, Gg.OutPut2.夹上摸气缸, 1);
                        Gg.SetExDo(0, 0, Gg.OutPut2.撕摸升降气缸, 0);
                        Gg.SetExDo(0, 0, Gg.OutPut2.片料夹紧气缸左, 1);
                        Gg.SetExDo(0, 0, Gg.OutPut2.片料夹紧气缸右, 1);
                        Gg.SetExDo(0, 0, Gg.OutPut2.拉料无杆干气缸, 0);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 70;
                        break;

                    case 70:
                        if (Gg.GetExDi(0, Gg.InPut2.夹上摸气缸伸出) == 1 && Gg.GetExDi(0, Gg.InPut2.夹上摸气缸缩回) == 0 &&
                            Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 0 &&
                            Gg.GetExDi(0, Gg.InPut2.片料夹紧气缸左伸出) == 1 && Gg.GetExDi(0, Gg.InPut2.片料夹紧气缸右伸出) == 1 &&
                            Gg.GetExDi(0, Gg.InPut2.拉料无杆干气缸左) == 1 && Gg.GetExDi(0, Gg.InPut2.拉料无杆干气缸右) == 0)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 80;
                        }
                        if (API.GetTickCount() - TimeOut > 2000)
                        {
                            if (Gg.GetExDi(0, Gg.InPut2.夹上摸气缸伸出) == 0 || Gg.GetExDi(0, Gg.InPut2.夹上摸气缸缩回) == 1)
                            {
                                AddList("夹上摸气缸伸出信号异常，请检查！");
                                ShowList("夹上摸气缸伸出信号异常，请检查！");
                            }
                            if (Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 1)
                            {
                                AddList("撕摸升降气缸缩回信号异常，请检查！");
                                ShowList("撕摸升降气缸缩回信号异常，请检查！");
                            }
                            if (Gg.GetExDi(0, Gg.InPut2.片料夹紧气缸左伸出) == 0)
                            {
                                AddList("片料夹紧气缸左伸出信号异常，请检查！");
                                ShowList("片料夹紧气缸左伸出信号异常，请检查！");
                            }
                            if (Gg.GetExDi(0, Gg.InPut2.片料夹紧气缸右伸出) == 0)
                            {
                                AddList("片料夹紧气缸右伸出信号异常，请检查！");
                                ShowList("片料夹紧气缸右伸出信号异常，请检查！");
                            }
                            if (Gg.GetExDi(0, Gg.InPut2.拉料无杆干气缸左) == 0 || Gg.GetExDi(0, Gg.InPut2.拉料无杆干气缸右) == 1)
                            {
                                AddList("拉料无杆干气缸左信号异常，请检查！");
                                ShowList("拉料无杆干气缸左信号异常，请检查！");
                            }
                            TimeOut = API.GetTickCount();
                            BufferStep = 70;
                            StaWork.Step = 8000;
                        }
                        break;

                    case 80:
                        //取片料马达和拉料马达回到初始位置
                        Gg.AbsMotion(0, BVar.S2G_Y, mFunction.Pos.TeachAxis1[3, 0], PVar.ParAxis.Speed[BVar.S2G_Y]);
                        Gg.AbsMotion(0, BVar.S2L_Z, mFunction.Pos.TeachAxis3[3, 3], PVar.ParAxis.Speed[BVar.S2L_Z]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 90;
                        break;

                    case 90:
                        if (Gg.ZSPD(0, BVar.S2G_Y) && Gg.ZSPD(0, BVar.S2L_Z))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 100;
                        }
                        break;

                    case 100:
                        Gg.SetExDo(0, 0, Gg.OutPut2.撕摸升降气缸, 1);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 110;
                        break;

                    case 110:
                        if (Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 1)
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut2.取底膜破真空, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut2.取片料真空吸, 1);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 120;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("撕摸升降气缸伸出信号异常，请检查！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 110;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 120:
                        if (Gg.GetDi(0, Gg.InPut0.取片料真空检测) == 1)
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut2.夹上摸气缸, 0);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 130;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("取片料真空检测信号异常，请检查！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 120;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 130:
                        if (Gg.GetExDi(0, Gg.InPut2.夹上摸气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.夹上摸气缸伸出) == 0)
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut2.撕摸升降气缸, 0);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 140;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("夹上摸气缸缩回测信号异常，请检查！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 130;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 140:
                        if (Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 0)
                        {
                            Gg.AbsMotion(0, BVar.S2G_Y, mFunction.Pos.TeachAxis1[3, 1], PVar.ParAxis.Speed[BVar.S2G_Y]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 150;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("撕摸升降气缸缩回信号异常，请检查！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 140;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 150:
                        if (Gg.ZSPD(0, BVar.S2G_Y))
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut2.撕摸升降气缸, 1);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 160;
                        }
                        break;

                    case 160:
                        if (Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 1)
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut2.取底膜破真空, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut2.取片料真空吸, 1);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 120;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("撕摸升降气缸伸出信号异常，请检查！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 110;
                                StaWork.Step = 8000;
                            }
                        }
                        break;


                    case 23320:
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 100;
                        break;

                    case 800:
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    //遇到异常，设备先暂停，确定后处理************************
                    case 8000:
                        PVar.IsSystemOnPauseMode = true;
                        PVar.MacHold = true;
                        PVar.Stop_Flag = false;
                        Frm_Main.fMain.Btn_Start.Enabled = false;
                        Frm_Main.fMain.Btn_Pause.Enabled = true;
                        Frm_Main.fMain.Btn_Stop.Enabled = false;
                        Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                        Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;
                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
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
