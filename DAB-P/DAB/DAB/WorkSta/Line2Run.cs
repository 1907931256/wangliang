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

namespace DAB
{
    //组装工站
    sealed class Line2Run
        {
        private static Tool.Delay Line2Time = new Tool.Delay();
        private static string CCD_CMD;
        private static int sRtn;
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
                            StaWork.Result = false;
                            Line2Time.InitialTime();
                            StaWork.Step = 20;
                            }
                        break;

                    case 20:
                        if (PVar.空跑)
                        {
                            if (StaWork.State == false && StaWork.Enable && StaWork.IsHaveFix)
                            {
                                AddList("组装开始！");
                                StaWork.State = true;
                                StaWork.Enable = false;

                                BVar.ProData[2, 1] = BVar.ProData[1, 1];//Bezel条码
                                BVar.ProData[2, 3] = BVar.ProData[1, 3];//载具条码
                                Frm_Engineering.fEngineering.Lab_Station2.Text = BVar.ProData[2, 1];

                                Gg.SetExDo(0, 0, Gg.OutPut1.载具夹紧气缸, 1);
                                Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品真空吸, 1);
                                Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 0);
                                Line2Time.InitialTime();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                if (Line2Time.TimeIsUp(20))
                                {
                                    Line2Time.InitialTime();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        else//********************************************
                        {
                            if (StaWork.State == false && StaWork.Enable && StaWork.IsHaveFix)
                            {
                                AddList("组装开始！");
                                StaWork.State = true;
                                StaWork.Enable = false;

                                BVar.ProData[2, 1] = BVar.ProData[1, 1];//Bezel条码
                                BVar.ProData[2, 3] = BVar.ProData[1, 3];//载具条码
                                Frm_Engineering.fEngineering.Lab_Station2.Text = BVar.ProData[2, 1];

                                Gg.SetExDo(0, 0, Gg.OutPut1.载具夹紧气缸, 1);
                                Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品真空吸, 1);
                                Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 0);
                                Line2Time.InitialTime();
                                StaWork.Step = 30;
                            }
                            else if (StaWork.State == false && StaWork.Enable == false && StaWork.IsHaveFix)
                            {
                                AddList("没有条码，跳过组装！");
                                StaWork.Result = false;
                                Line2Time.InitialTime();
                                StaWork.Step = 5000; //等待放行
                            }
                            else
                            {
                                StaWork.Step = 10;
                            }
                        }
                        break;

                    case 30:
                        AddList("保压Z轴回初始位置！");
                        Gg.AbsMotion(0, Axis.保压Z轴, mFunction.Pos.TeachAxis1[Axis.tTag.保压, Axis.Point保压.初始位置], PVar.ParAxis.Speed[Axis.保压Z轴]);
                        Line2Time.InitialTime();
                        StaWork.Step = 40;
                        break;

                    case 40:
                        //保压轴和气缸复位
                        if (Gg.ZSPD(0, Axis.保压Z轴) && Gg.GetHomeDi(0, Axis.保压Z轴) == 1)
                            {
                            //保压站无杆气缸双头电磁阀向右
                            AddList("保压Z轴OK！");
                            Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸左, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸右, 1);
                            Line2Time.InitialTime();
                            StaWork.Step = 50;
                            }
                        else if (Line2Time.TimeIsUp(8000))
                            {
                            AddList("保压Z轴运动到初始位置超时！");
                            ShowList("保压Z轴运动到初始位置超时！");
                            StaWork.Result = false;
                            Line2Time.InitialTime();
                            StaWork.Step = 10000;  
                            }
                        break;

                    case 50:
                        if (Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 0 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 1)
                            {
                            if (EpsonRobot.RobotLivePos.Y > -150)//判断机械手是否在流水线外
                                {
                                Gg.SetExDo(0, 0, Gg.OutPut1.光源旋转气缸, 1);
                                }
                            Line2Time.InitialTime();
                            StaWork.Step = 60;
                            }
                        else if (Line2Time.TimeIsUp(5000))
                            {
                            AddList("保压无杆气缸右信号感应异常！");
                            ShowList("保压无杆气缸右信号感应异常！");
                            StaWork.Result = false;
                            Line2Time.InitialTime();
                            StaWork.Step = 5000;  //等待放行
                            }
                        break;

                    case 60:
                        if (Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸伸出) == 1)
                            {
                            AddList("载具夹紧气缸伸出信号OK！");
                            AddList("等待光源旋转气缸伸出信号感应！");
                            Line2Time.InitialTime();
                            StaWork.Step = 70;
                            }
                        else if (Line2Time.TimeIsUp(2000) && Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸缩回) == 0)
                            {
                            AddList("保载具夹紧气缸伸出信号感应异常！");
                            Line2Time.InitialTime();
                            StaWork.Step = 70;//小异常忽略
                            }
                        break;

                    case 70:
                        if (Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 1)
                            {
                            AddList("光源旋转气缸伸出信号感应OK！");
                            Line2Time.InitialTime();
                            StaWork.Step = 200;
                            }
                        else
                            {
                            if (EpsonRobot.RobotLivePos.Y > -200)//判断机械手是否在流水线外
                                {
                                Gg.SetExDo(0, 0, Gg.OutPut1.光源旋转气缸, 1);
                                }
                            }
                        break;

                    //相机拍照
                    case 200:
                        CCD_CMD = "T31" + "," + BVar.ProData[2, 1] + "," +
                            EpsonRobot.RobotLivePos.X + "," + EpsonRobot.RobotLivePos.Y + "," + EpsonRobot.RobotLivePos.U;
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList("Bezel定位拍照");
                        if (PVar.空跑)
                        {
                            Line2Time.InitialTime();
                            StaWork.Step = 210;
                        }
                        else
                        {
                            if (sRtn == 1) //命令发送成功
                            {

                                Line2Time.InitialTime();
                                StaWork.Step = 210;
                            }
                            else
                            {
                                AddList("T31命令发送失败！");
                                ShowList("T31命令发送失败！");
                                Line2Time.InitialTime();
                                StaWork.Step = 1000;
                            }
                        }
                        break;

                    case 210:
                        if (PVar.空跑)
                        {
                            if (Line2Time.TimeIsUp(2000))
                            {
                                AddList("<<- Recevied:" + PVar.CCD_StrData);
                                Gg.SetExDo(0, 0, Gg.OutPut1.光源旋转气缸, 0);
                                Line2Time.InitialTime();
                                StaWork.Step = 220;
                            }
                        }
                        else//****************************************************
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == "T31")
                            {
                                AddList("<<- Recevied:" + PVar.CCD_StrData);
                                Gg.SetExDo(0, 0, Gg.OutPut1.光源旋转气缸, 0);
                                Line2Time.InitialTime();
                                StaWork.Step = 220;
                            }
                            else
                            {
                                if (Line2Time.TimeIsUp(5000))
                                {
                                    AddList("等待CCD T31数据超时！");
                                    ShowList("等待CCD T31数据超时！");
                                    Line2Time.InitialTime();
                                    StaWork.Step = 1000;
                                }
                            }
                        }
                        break;

                    case 220:
                        if (PVar.空跑)
                        {
                            AddList("拍照OK,开始等待机械手开始工作结束");
                            Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品真空吸, 0);
                            PVar.Sta_Work[(int)BVar.工位.机械手].Enable = true;//允许机械手开始工作，目前不考虑CT，后续提前并行
                            Line2Time.InitialTime();
                            StaWork.Step = 230;
                        }
                        else
                        {
                            if (PVar.CCD_Data[1] == "1")
                            {
                                AddList("拍照OK,开始等待机械手开始工作结束");

                                PVar.Sta_Work[(int)BVar.工位.机械手].Enable = true;//允许机械手开始工作，目前不考虑CT，后续提前并行
                                Line2Time.InitialTime();
                                StaWork.Step = 230;
                            }
                            else
                            {
                                AddList("Bezel拍照NG,异常直接流出");
                                StaWork.Result = false;
                                Line2Time.InitialTime();
                                StaWork.Step = 5000;
                            }
                        }
                        break;

                    case 230:
                        if (Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 0)
                            {
                            AddList("光源旋转气缸缩回信号感应OK！");
                            StaWork.IsReady = true;//所有准备就绪，等待机械手完成
                            Line2Time.InitialTime();
                            StaWork.Step = 300;
                            }
                        else if (Line2Time.TimeIsUp(5000))
                            {
                            AddList("光源旋转气缸缩回超时！");
                            ShowList("光源旋转气缸缩回超时！");
                            Line2Time.InitialTime();
                            StaWork.Step = 5000;
                            }
                        break;





                    //************************************************************************************************
                    //等待机械手装配完成
                    case 300:
                        if (StaWork.IsReady == false)
                            {
                            AddList("装配完成，开始复检！");
                            Line2Time.InitialTime();
                            StaWork.Step = 310;
                            }
                        break;

                    case 310:
                        if (Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 0 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 1)
                            {
                            AddList("光源旋转气缸伸出信号感应OK！");
                            Line2Time.InitialTime();
                            StaWork.Step = 320;
                            }
                        else
                            {
                            if (EpsonRobot.RobotLivePos.Y > -150)//判断机械手是否在流水线外
                                {
                                Gg.SetExDo(0, 0, Gg.OutPut1.光源旋转气缸, 1);
                                }
                            }
                        break;

                    case 320:
                        CCD_CMD = "T33" + "," + BVar.ProData[2, 1] + "," +
                            EpsonRobot.RobotLivePos.X + "," + EpsonRobot.RobotLivePos.Y + "," + EpsonRobot.RobotLivePos.U;
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList("Bezel下相机复检拍照");
                        if (PVar.空跑)
                        {
                            Line2Time.InitialTime();
                            StaWork.Step = 330;
                        }
                        else
                        {
                            if (sRtn == 1) //命令发送成功
                            {

                                Line2Time.InitialTime();
                                StaWork.Step = 330;
                            }
                            else
                            {
                                AddList("T33命令发送失败！");
                                ShowList("T33命令发送失败！");
                                Line2Time.InitialTime();
                                StaWork.Step = 1000;
                            }
                        }
                        break;

                    case 330:
                        if (PVar.空跑)
                        {
                            if (Line2Time.TimeIsUp(1000))
                            {
                                AddList("<<- Recevied:" + PVar.CCD_StrData);
                                Line2Time.InitialTime();
                                StaWork.Step = 340;
                            }
                        }
                        else
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == "T33")
                            {
                                AddList("<<- Recevied:" + PVar.CCD_StrData);
                                Line2Time.InitialTime();
                                StaWork.Step = 340;
                            }
                            else
                            {
                                if (Line2Time.TimeIsUp(5000))
                                {
                                    AddList("等待CCD T33数据超时！");
                                    ShowList("等待CCD T33数据超时！");
                                    Line2Time.InitialTime();
                                    StaWork.Step = 1000;
                                }
                            }
                        }
                        break;

                    case 340:
                        if (PVar.空跑)
                        {
                            AddList("拍照OK");
                            Line2Time.InitialTime();
                            StaWork.Step = 350;
                        }
                        else
                        {
                            if (PVar.CCD_Data[1] == "1")
                            {
                                AddList("拍照OK");
                                Line2Time.InitialTime();
                                StaWork.Step = 350;
                            }
                            else
                            {
                                AddList("Bezel拍照NG,异常直接流出");
                                StaWork.Result = false;
                                Line2Time.InitialTime();
                                StaWork.Step = 5000;
                            }
                        }
                        break;

                    case 350:
                        CCD_CMD = "T41" + "," + BVar.ProData[2, 1] + "," +
                            EpsonRobot.RobotLivePos.X + "," + EpsonRobot.RobotLivePos.Y + "," + EpsonRobot.RobotLivePos.U;
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList("Bezel上相机复检拍照");
                        if (PVar.空跑)
                        {
                            Line2Time.InitialTime();
                            StaWork.Step = 360;
                        }
                        else
                        {
                            if (sRtn == 1) //命令发送成功
                            {

                                Line2Time.InitialTime();
                                StaWork.Step = 360;
                            }
                            else
                            {
                                AddList("T41命令发送失败！");
                                ShowList("T41命令发送失败！");
                                Line2Time.InitialTime();
                                StaWork.Step = 1000;
                            }
                        }
                        break;

                    case 360:
                        if (PVar.空跑)
                        {
                            if (Line2Time.TimeIsUp(1000))
                            {
                                AddList("<<- Recevied:" + PVar.CCD_StrData);
                                Line2Time.InitialTime();
                                StaWork.Step = 370;
                            }
                        }
                        else
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == "T41")
                            {
                                AddList("<<- Recevied:" + PVar.CCD_StrData);
                                Line2Time.InitialTime();
                                StaWork.Step = 370;
                            }
                            else
                            {
                                if (Line2Time.TimeIsUp(5000))
                                {
                                    AddList("等待CCD T41数据超时！");
                                    ShowList("等待CCD T41数据超时！");
                                    Line2Time.InitialTime();
                                    StaWork.Step = 1000;
                                }
                            }
                        }
                        break;

                    case 370:
                        if (PVar.空跑)
                        {
                            AddList("拍照OK,开始上传PDCA");
                            Line2Time.InitialTime();
                            StaWork.Step = 380;
                        }
                        else
                        {
                            if (PVar.CCD_Data[1] == "1")
                            {
                                AddList("拍照OK,开始上传PDCA");
                                Line2Time.InitialTime();
                                StaWork.Step = 380;
                            }
                            else
                            {
                                AddList("Bezel拍照NG,异常直接流出");
                                StaWork.Result = false;
                                Line2Time.InitialTime();
                                StaWork.Step = 5000;
                            }
                        }
                        break;

                    case 380:

                        Line2Time.InitialTime();
                        StaWork.Step = 505;
                        break;

                    //复检检测输出值
                    //***********************************************

                    case 505:
                        Gg.SetDo(0, Gg.OutPut0.阻挡气缸3, 0);
                        Gg.SetExDo(0, 0, Gg.OutPut1.载具夹紧气缸, 0);
                        Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品真空吸, 0);
                        Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 1);
                        Line2Time.InitialTime();
                        StaWork.Step = 510;
                        break;

                    case 510:
                        if (Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸伸出) == 0)
                            {
                            AddList("装配完成，等待放行！");
                            Line2Time.InitialTime();
                            StaWork.Step = 600;
                            }
                        else if (Line2Time.TimeIsUp(3000))
                            {
                            AddList("保载具夹紧气缸伸出信号感应异常！");
                            Line2Time.InitialTime();
                            StaWork.Step = 400;
                            }
                        break;

                    case 600:
                        if (PVar.空跑)
                        {
                            if (PVar.Stop_Flag == false && Linechange.LineOut() == 0 && PVar.Sta_Work[(int)BVar.工位.流水线3].State == false)
                            {
                                AddList("载具开始放行，等待流水线3接收!");
                                Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 0);
                                Frm_Engineering.fEngineering.Txt_BarCode.Text = "";
                                Linechange.SetMotor2(true, PVar.ParList.Data[43]);
                                Linechange.SetMotor3(true, PVar.ParList.Data[43]);
                                Line2Time.InitialTime();
                                StaWork.Step = 610;
                            }
                            else
                            {
                                if (PVar.Stop_Flag)
                                {
                                    StaWork.State = false;
                                    Line2Time.InitialTime();
                                    StaWork.Step = 10;
                                }
                            }
                        }
                        else//******************************************************
                        {
                            //等待放行*****************************
                            if (PVar.Stop_Flag == false && Linechange.LineOut() == 0 && PVar.Sta_Work[(int)BVar.工位.流水线3].State == false)
                            {
                                AddList("载具开始放行，等待流水线3接收!");
                                Frm_Engineering.fEngineering.Txt_BarCode.Text = "";
                                Linechange.SetMotor2(true, PVar.ParList.Data[43]);
                                Linechange.SetMotor3(true, PVar.ParList.Data[43]);
                                Line2Time.InitialTime();
                                StaWork.Step = 610;
                            }
                        }
                        break;

                    case 610:
                        if (PVar.空跑)
                        {
                            if (Line2Time.TimeIsUp(1000))
                            {
                                AddList("载具开始放行！");
                                Line2Time.InitialTime();
                                StaWork.Step = 620;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应4) == 0)
                            {
                                AddList("载具开始放行！");
                                Line2Time.InitialTime();
                                StaWork.Step = 620;
                            }
                            else if (Line2Time.TimeIsUp(5000))
                            {
                                AddList("流水线2放行载具超时！");
                                ShowList("流水线2放行载具超时！");
                                Line2Time.InitialTime();
                                StaWork.Step = 620;
                            }
                        }
                        break;

                    case 620:
                        if (PVar.空跑)
                        {
                            if (Line2Time.TimeIsUp(1000))
                            {
                                AddList("流水线2载具开始放行完成！");
                                //*********************************************************应该可以开始接受上站载具
                                PVar.Sta_Work[(int)BVar.工位.流水线3].IsHaveFix = true;
                               
                                Line2Time.InitialTime();
                                StaWork.Step = 630;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.流水线对射感应5) == 0)
                            {
                                AddList("流水线2载具开始放行完成！");
                                //*********************************************************应该可以开始接受上站载具
                                PVar.Sta_Work[(int)BVar.工位.流水线3].IsHaveFix = true;
                                Gg.SetDo(0, Gg.OutPut0.阻挡气缸3, 1);
                                Line2Time.InitialTime();
                                StaWork.Step = 630;
                            }
                            else if (Line2Time.TimeIsUp(5000))
                            {
                                AddList("流水线2放行载具超时！");
                                ShowList("流水线2放行载具超时！");
                                Line2Time.InitialTime();
                                StaWork.Step = 630;
                            }
                        }
                        break;

                    case 630:
                        if (Line2Time.TimeIsUp(500))
                        {
                            AddList("流水线2载具放行完成！");
                            Gg.SetDo(0, Gg.OutPut0.阻挡气缸3, 1);
                            PVar.Sta_Work[(int)BVar.工位.流水线2].IsHaveFix = false;
                            PVar.Sta_Work[(int)BVar.工位.流水线3].IsHaveFix = true;
                            Linechange.SetMotor2(false, PVar.ParList.Data[43]);
                            Line2Time.InitialTime();
                            StaWork.Step = 650;
                        }
                        break;

                    case 650:
                        if (Line2Time.TimeIsUp(200))
                        {
                            Line2Time.InitialTime();
                            StaWork.Step = 800;
                        }
                        break;

                    case 800:
                        StaWork.Enable = false;
                        StaWork.Result = true;
                        StaWork.State = false;
                        Manual.AutoMotionFlag[2] = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        Manual.AutoMotionFlag[2] = false;
                        StaWork.Step = 10;
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
