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
    //EPSON机械手
    sealed class EpsonRobot
    {
        public struct sRobot_Pos
            { 
            public double X; //机械手当前X坐标
            public double Y; //机械手当前Y坐标
            public double Z; //机械手当前Z坐标
            public double U; //机械手当前U坐标
            public double V; //机械手当前V坐标
            public double W; //机械手当前W坐标 
            public string OffsetX;
            public string OffsetY;
            public string OffsetT;
            public string OffsetZ;
            }
        public static sRobot_Pos RobotPos; //机械手结构体

        //把机械手点位存放在内存中，用于和CCD比较，防止CCD给的值过大
        public static sRobot_Pos 取PSA位置; //机械手结构体 
        public static sRobot_Pos PSA贴合位置; //机械手结构体 
        public static sRobot_Pos 取Display位置; //机械手结构体 
        public static sRobot_Pos Display贴合位置; //机械手结构体 

        //记忆机械手位置
        public static sRobot_Pos 放回Display位置; //机械手结构体  

        public static sRobot_Pos RobotLivePos; //机械手结构体
        public static string[] Robot_Data = new string[10];
        public static string[] Robot_Fcs = new string[10];
        public static string Robot_StrData;
         
        public static string sRobot_Status; //机械手返回值有值代表响应成功
        public static string sRobot_FcsStatus; //机械手返回值有值代表响应成功
        public static double Pressure; //机械手压力
        public static bool RobotIsWork = false; 
        public static bool IsRobotAlarm = false; 
        public static int RobotCMDSendTime;
         
        private static int ERR_Dis_Count = 0;
        private static int ERR_PSA_Count = 0;
        private static int ERR_Count = 0; 
        private static int BufferStep = 0;

        private static PVar.CCDDataType[] CCD_Vale = new PVar.CCDDataType[10];
        private static int sRtn;
        private static Tool.Delay RobotTime = new Tool.Delay(); 
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        public static void AutoRun(ref PVar.WorkType StaWork)
        {
            try
            {
                switch (StaWork.Step)
                {
                    case 10:
                        if (PVar.Stop_Flag == false )
                        {
                            StaWork.State = false;
                            RobotTime.InitialTime();
                            StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        if (PVar.空跑)
                        {
                            if (StaWork.State == false && StaWork.Enable)
                            {
                                StaWork.State = true;
                                StaWork.Enable = false;
                                ERR_Dis_Count = 0;
                                ERR_PSA_Count = 0;
                                ERR_Count = 0;
                                AddList("机械是开始工作！");

                                //Gg.SetExDo(0, 0, Gg.OutPut1.机械手滑台气缸, 0);
                                //Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜升降气缸, 0);
                                //Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜针型气缸, 0);
                                //Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);

                                //Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴破真空, 0);
                                //Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                                //Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜破真空, 0);
                                //Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜真空吸, 0);
                                //Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 0);
                                //Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线真空吸, 0);
                                RobotTime.InitialTime();
                                StaWork.Step = 100;
                            }
                            else if (RobotTime.TimeIsUp(20))
                            {
                                StaWork.Step = 10;
                            }
                        }
                        else
                        {
                        if (StaWork.State == false && StaWork.Enable)
                            {
                            StaWork.State = true;
                            StaWork.Enable = false;
                            ERR_Dis_Count = 0;
                            ERR_PSA_Count = 0;
                            ERR_Count = 0;
                            AddList("机械是开始工作！");
                            
                            Gg.SetExDo(0, 0, Gg.OutPut1.机械手滑台气缸, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜升降气缸, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜针型气缸, 0);
                            Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);

                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴破真空, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜破真空, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线真空吸, 0);
                            RobotTime.InitialTime();
                            StaWork.Step = 100;
                            }
                        else if (RobotTime.TimeIsUp(20))
                            {
                            StaWork.Step = 10;
                            }
                        }

                        break;

                    case 100:
                        if (PVar.Sta_Work[(int)BVar.工位.PSA供料].IsHavePSA)
                            {
                            AddList("载台上有PSA！");
                            RobotTime.InitialTime();
                            StaWork.Step = 110;
                            }
                        else
                            {
                            AddList("等待PSA供料…");
                            RobotTime.InitialTime();
                            StaWork.Step = 105;
                            }
                        break;

                    case 105:
                        if (PVar.Sta_Work[(int)BVar.工位.PSA供料].IsHavePSA)
                            {
                            AddList("载台上有PSA！");
                            RobotTime.InitialTime();
                            StaWork.Step = 110;
                            }
                        else
                            {
                            //等料中如果停止则退出
                           if (PVar.Stop_Flag)
                                {
                                StaWork.Step = 10;
                                }                         
                            }
                        break;

                    case 110:
                        if (Gg.ZSPD(0, Axis.PSA搬运Y轴))
                            {
                            RobotTime.InitialTime();
                            StaWork.Step = 120;
                            }
                        break;

                        //***判断PSA供料Y轴编码器位置是否在保存的初始位置
                    case 120:
                        if (Math.Abs(Gg.GetEncPosmm(0, Axis.PSA搬运Y轴) - mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴吸料位置]) < 1)
                            {
                            RobotTime.InitialTime();
                            StaWork.Step = 150;
                            }
                        else
                            {
                            AddList("PSA搬运Y轴位置异常！");
                            ShowList("PSA搬运Y轴位置异常！");
                            RobotTime.InitialTime();
                            StaWork.Step = 10000;
                            }
                        break;


                    case 150:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.PSA载台拍照位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到PSA载台拍照位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 160;
                        break;


                    case 160:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.PSA载台拍照位置))
                            {
                            AddList("机械手运动到PSA载台拍照位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 170;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 170:
                        if (RobotTime.TimeIsUp(200))
                            {
                            ERR_PSA_Count = 0;
                            RobotTime.InitialTime();
                            StaWork.Step = 180;
                            }
                        break;

                    case 180:
                        ERR_PSA_Count += 1;
                        sRtn = Command.TCP_CCD_Send(Command.取料PSA拍照, BVar.ProData[2, 1]);
                        if (PVar.空跑)
                        {
                            RobotTime.InitialTime();
                            StaWork.Step = 190;
                        }
                        else
                        {
                        if (sRtn == 1) //命令发送成功
                            {
                            RobotTime.InitialTime();
                            StaWork.Step = 190;
                            }
                        else
                            {
                            AddList("网络命令发送失败！");
                            ShowList("网络命令发送失败！");
                            RobotTime.InitialTime();
                            BufferStep = 180;
                            StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 190:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                AddList("取料PSA拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 210;
                            }
                        }
                        else
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == Command.取料PSA拍照)
                            {
                                AddList("取料PSA拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 200;
                            }
                            else
                            {
                                if (RobotTime.TimeIsUp(3000))
                                {
                                    AddList("等待取料PSA拍照数据超时！");
                                    RobotTime.InitialTime();
                                    BufferStep = 180;
                                    StaWork.Step = 8000;
                                }
                            }
                        }
                        break;

                    case 200:
                        if (CCD_Vale[1].Judge == 1)
                            {
                            if (Math.Abs(CCD_Vale[1].X - 取PSA位置.X) < 3 && Math.Abs(CCD_Vale[1].Y - 取PSA位置.Y) < 3 && Math.Abs(CCD_Vale[1].T - 取PSA位置.U) < 5)
                                {
                                ERR_PSA_Count = 0;
                                RobotTime.InitialTime();
                                StaWork.Step = 210;                             
                                }
                            else
                                {
                                RobotTime.InitialTime();
                                if (ERR_PSA_Count < 3)    //*****进入下一个物料拍照
                                    {
                                    AddList(Command.取料PSA拍照 + ":拍照数据偏大，请检查！");
                                    ShowList(Command.取料PSA拍照 + ":拍照数据偏大，请检查！");
                                    BufferStep = 180;
                                    StaWork.Step = 8000;
                                    }
                                else    //*****连续三次拍照异常则放会处理
                                    {
                                    ERR_PSA_Count = 0;//重新计数
                                    StaWork.Step = 5000;    //把物料当废料取走并丢掉
                                    }
                                }
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            if (ERR_PSA_Count < 2)    //*****进入下一个物料拍照
                                {
                                AddList("取料PSA拍照失败！");
                                ShowList("取料PSA拍照失败！");
                                BufferStep = 180;
                                StaWork.Step = 8000;
                                }
                            else    //*****连续三次拍照异常则放会处理
                                {
                                ERR_PSA_Count = 0;//重新计数
                                StaWork.Step = 5000;    //把物料当废料取走并丢掉
                                }
                            }
                        break;

                    case 210:
                        if (PVar.空跑)
                        {
                            Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.取PSA位置, PVar.ParList.Data[54].ToString(),
                                RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                    "0", "0", "0", "0",
                                    "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到取PSA位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 220;
                        }
                        else//**************************************************************
                        {
                            RobotPos.OffsetX = (CCD_Vale[1].X + PVar.ParList.Data[4]).ToString();
                            RobotPos.OffsetY = (CCD_Vale[1].Y + PVar.ParList.Data[5]).ToString();
                            RobotPos.OffsetZ = (0 + PVar.ParList.Data[6]).ToString();
                            RobotPos.OffsetT = (CCD_Vale[1].T + PVar.ParList.Data[7]).ToString();
                            Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.CCD引导取PSA位置, PVar.ParList.Data[54].ToString(),
                                  RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                  "0", "0", "0", "0",
                            "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到取PSA位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 220;
                        }
                        break;

                    case 220:
                        if (PVar.空跑)
                        {
                            if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.取PSA位置))
                            {
                                AddList("机械手运动到取PSA位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 230;
                            }
                        }
                        else
                        {
                            if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.CCD引导取PSA位置))
                            {
                                AddList("机械手运动到取PSA位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 230;
                            }
                            else
                            {
                                RobotTime.InitialTime();

                            }
                        }
                        break;

                    case 230:
                        AddList("打开机械手吸嘴真空吸！");
                        Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 1);
                        RobotTime.InitialTime();
                        StaWork.Step = 240;
                        break;

                    case 240:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);
                                RobotTime.InitialTime();
                                StaWork.Step = 250;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.机械手吸嘴真空吸检测信号) == 1)
                            {
                                Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);
                                RobotTime.InitialTime();
                                StaWork.Step = 250;
                            }
                            else if (RobotTime.TimeIsUp(1500))
                            {
                                RobotTime.InitialTime();
                                BufferStep = 240;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 250:
                        if (RobotTime.TimeIsUp(200))
                            {
                            AddList("机械手吸嘴真空吸检测信号OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 251;
                            }
                        break;

                    case 251:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.撕PSA下模位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到撕PSA下模位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 252;
                        break;

                    case 252:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.撕PSA下模位置))
                            {
                            AddList("机械手运动到撕PSA下模位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 253;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 253:
                        if (RobotTime.TimeIsUp(200))
                            {
                            Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 1);
                            RobotTime.InitialTime();
                            StaWork.Step = 254;
                            }
                        break;

                    case 254:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 255;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(0, Gg.InPut1.撕膜夹爪气缸闭合) == 1 && Gg.GetExDi(0, Gg.InPut1.撕膜夹爪气缸张开) == 0)
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 255;
                            }
                            else if (RobotTime.TimeIsUp(2000))
                            {
                                AddList("PSA撕膜夹爪气缸闭合信号感应异常！");
                                ShowList("PSA撕膜夹爪气缸闭合信号感应异常！");
                                RobotTime.InitialTime();
                                BufferStep = 180;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 255:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.PSA撕下摸动作, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手PSA撕摸开始！");
                        RobotTime.InitialTime();
                        StaWork.Step = 256;
                        break;

                    case 256:
                        if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.PSA撕下摸动作))
                            {
                            AddList("机械手PSA撕摸结束！");
                            RobotTime.InitialTime();
                            StaWork.Step = 260;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;


                    case 260:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.PSA定位拍照位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到PSA载台拍照位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 270;
                        break;

                    case 270:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.PSA定位拍照位置))
                            {
                            AddList("机械手运动到PSA定位拍照位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 275;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 275:
                        if (RobotTime.TimeIsUp(200))
                            {
                            RobotTime.InitialTime();
                            StaWork.Step = 280;
                            }
                        break;

                    case 280:
                        sRtn = Command.TCP_CCD_Send(Command.PSA定位拍照, BVar.ProData[2, 1]);
                        if (PVar.空跑)
                        {
                            RobotTime.InitialTime();
                            StaWork.Step = 290;
                        }
                        else
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 290;
                            }
                            else
                            {
                                AddList("网络命令发送失败！");
                                ShowList("网络命令发送失败！");
                                RobotTime.InitialTime();
                                BufferStep = 280;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 290:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                AddList("PSA定位拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 310;
                            }
                        }
                        else
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == Command.PSA定位拍照)
                            {
                                AddList("PSA定位拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 300;
                            }
                            else
                            {
                                if (RobotTime.TimeIsUp(3000))
                                {
                                    AddList("等待PSA定位拍照数据超时！");
                                    RobotTime.InitialTime();
                                    BufferStep = 280;
                                    StaWork.Step = 8000;
                                }
                            }
                        }
                        break;

                    case 300:
                        if (CCD_Vale[1].Judge == 1)
                            {
                            if (Math.Abs(CCD_Vale[1].X - PSA贴合位置.X) < 3 || Math.Abs(CCD_Vale[1].Y - PSA贴合位置.Y) < 3 || Math.Abs(CCD_Vale[1].T - PSA贴合位置.U) < 5)
                                {
                                RobotTime.InitialTime();
                                StaWork.Step = 310;                           
                                }
                            else
                                {
                                AddList(Command.PSA定位拍照 + ":拍照数据偏大，请检查！");
                                ShowList(Command.PSA定位拍照 + ":拍照数据偏大，请检查！");
                                RobotTime.InitialTime();
                                BufferStep = 280;
                                StaWork.Step = 8000;
                                }
                            }
                        else
                            {
                            AddList("PSA定位拍照失败！");
                            ShowList("PSA定位拍照失败！");
                            RobotTime.InitialTime();
                            if (PVar.ParList.CheckSts[24])
                                {
                                BufferStep = 280;
                                StaWork.Step = 8000;
                                }
                            else
                                {
                                RobotTime.InitialTime();
                                StaWork.Step = 6000;
                                }
                            }
                        break;

                    case 310:
                        if (Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 0
                            && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 0 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 1)
                        {
                            RobotTime.InitialTime();
                            StaWork.Step = 305;
                        }
                        break;

                    case 305:
                        if (PVar.空跑)
                        {
                            Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.预贴PSA位置, PVar.ParList.Data[54].ToString(),
                                RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                "0", "0", "0", "0",
                                "0", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到装PSA位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 320;
                        }
                        else//**********************************************************
                        {
                            RobotPos.OffsetX = (CCD_Vale[1].X + PVar.ParList.Data[1]).ToString();
                            RobotPos.OffsetY = (CCD_Vale[1].Y + PVar.ParList.Data[2]).ToString();
                            RobotPos.OffsetZ = (0 + PVar.ParList.Data[3]).ToString();
                            RobotPos.OffsetT = (CCD_Vale[1].T).ToString();
                            Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.CCD引导装PSA位置, PVar.ParList.Data[54].ToString(),
                                  RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                  "0", "0", "0", "0",
                            "0", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到装PSA位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 320;
                        }
                        break;

                    case 320:
                        if (PVar.空跑)
                        {
                            if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.预贴PSA位置))
                            {
                                Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜升降气缸, 1);
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                                AddList("机械手运动到装PSA位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 400;
                            }
                        }
                        else
                        {
                            if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.CCD引导装PSA位置))
                            {
                                Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜升降气缸, 1);
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                                AddList("机械手运动到装PSA位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 400;
                            }
                            else
                            {
                                RobotTime.InitialTime();

                            }
                        }
                        break;

                    case 400:
                        if (RobotTime.TimeIsUp((int)PVar.ParList.Data[10] * 1000))//保压延时
                            {
                            
                            RobotTime.InitialTime();
                            StaWork.Step = 500;
                            }
                        break;

                    case 500:
                        if (PVar.空跑)
                        {
                            //Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜真空吸, 1);
                            //Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜针型气缸, 1);
                            RobotTime.InitialTime();
                            StaWork.Step = 510;
                        }
                        else//**************************************************************
                        {
                            if (Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸伸出) == 1 && Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸缩回) == 0)
                            {
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜真空吸, 1);
                                Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜针型气缸, 1);
                                RobotTime.InitialTime();
                                StaWork.Step = 510;
                            }
                            else if (RobotTime.TimeIsUp(5000))
                            {
                                AddList("机械手撕膜升降气缸伸出信号感应异常！");
                                ShowList("机械手撕膜升降气缸伸出信号感应异常！");
                                StaWork.Result = false;
                                RobotTime.InitialTime();
                                BufferStep = 500;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 510:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.PSA撕上摸动作, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "0", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手PSA撕摸开始！");
                        RobotTime.InitialTime();
                        StaWork.Step = 520;
                        break;

                    case 520:
                        if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.PSA撕上摸动作))
                            {
                            AddList("机械手PSA撕摸结束！");
                            RobotTime.InitialTime();
                            StaWork.Step = 550;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            //StaWork.Step = 280;
                            }
                        break;

                    case 550:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.PSA抛料位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "0", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手PSA撕摸开始！");
                        RobotTime.InitialTime();
                        StaWork.Step = 560;
                        break;

                    case 560:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.PSA抛料位置))
                            {
                            Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜升降气缸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜破真空, 1);
                            Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜针型气缸, 0);
                            AddList("机械手PSA撕摸结束！");
                            RobotTime.InitialTime();
                            StaWork.Step = 570;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            //StaWork.Step = 280;
                            }
                        break;

                    case 570:
                        if (RobotTime.TimeIsUp(1000))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜破真空, 0);
                            RobotTime.InitialTime();
                            StaWork.Step = 580;
                            }
                        break;

                    case 580:
                        if (Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸伸出) == 0 && Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸缩回) == 1)
                        {
                            
                            RobotTime.InitialTime();
                            StaWork.Step = 1000;
                        }
                        else if (RobotTime.TimeIsUp(5000))
                        {
                            AddList("机械手撕膜升降气缸缩回信号感应异常！");
                            ShowList("机械手撕膜升降气缸缩回信号感应异常！");
                            StaWork.Result = false;
                            RobotTime.InitialTime();
                            BufferStep = 1000;
                            StaWork.Step = 8000;
                        }
                        break;


                        //**********显示屏装配
                    case 1000:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.料盘上拍照位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("运动到料盘上拍照位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 1010;
                        break;

                    case 1010:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.料盘上拍照位置))
                            {
                            AddList("运动到料盘上拍照位置OK！");
                            PVar.Sta_Work[(int)BVar.工位.PSA供料].IsHavePSA = false;
                            RobotTime.InitialTime();
                            StaWork.Step = 1020;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 1020:
                        if (RobotTime.TimeIsUp(200))
                            {
                            RobotTime.InitialTime();
                            StaWork.Step = 1030;
                            }
                        break;

                    case 1030:
                        sRtn = Command.TCP_CCD_Send(Command.取Display拍照, BVar.ProData[2, 1]);
                        if (PVar.空跑)
                        {
                            RobotTime.InitialTime();
                            StaWork.Step = 1040;
                        }
                        else
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                ERR_Dis_Count += 1;
                                RobotTime.InitialTime();
                                StaWork.Step = 1040;
                            }
                            else
                            {
                                //这种网络错误或异常必须处理才继续，正常下几率很小
                                AddList("网络命令发送失败！");
                                ShowList("网络命令发送失败！");
                                RobotTime.InitialTime();
                                BufferStep = 1030;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 1040:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                AddList("取Display拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 1060;
                            }
                        }
                        else
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == Command.取Display拍照)
                            {
                                AddList("取Display拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 1050;
                            }
                            else
                            {
                                if (RobotTime.TimeIsUp(3000))
                                {
                                    //这种网络错误或异常必须处理才继续，正常下几率很小
                                    AddList("等待取料PSA拍照数据超时，机器暂停！");
                                    ShowList("等待取料PSA拍照数据超时，继续则重新拍照！");
                                    RobotTime.InitialTime();
                                    BufferStep = 1030;
                                    StaWork.Step = 8000;
                                }
                            }
                        }
                        break;

                    case 1050:
                        if (CCD_Vale[1].Judge == 1)
                            {
                            if (Math.Abs(CCD_Vale[1].X - 取Display位置.X) < 3 && Math.Abs(CCD_Vale[1].Y - 取Display位置.Y) < 3 && Math.Abs(CCD_Vale[1].T - 取Display位置.U) < 5)
                                {
                                AddList(Command.取Display拍照 + "X:" + CCD_Vale[1].X + " Y:" + CCD_Vale[1].Y + " T:" + CCD_Vale[1].T);
                                ERR_Dis_Count = 0;
                                RobotTime.InitialTime();
                                StaWork.Step = 1060;
                                }
                            else
                                {
                                AddList(Command.取Display拍照 + "X:" + CCD_Vale[1].X + " Y:" + CCD_Vale[1].Y + " T:" + CCD_Vale[1].T);
                                AddList(Command.取Display拍照 + ":拍照数据偏大，请检查！");
                                ShowList(Command.取Display拍照 + ":拍照数据偏大，请检查！");

                                if (ERR_Dis_Count < 2)    //*****同一个物料给两次机会
                                    {
                                    RobotTime.InitialTime();
                                    StaWork.Step = 1030;
                                    }
                                else    //*****两次都超出范围则去下一个物料拍照
                                    {
                                    ERR_Count += 1;
                                    UpdataMaterialCnt();    //******更新料盘数据
                                    if (ERR_Count < 4)
                                        {
                                        RobotTime.InitialTime();
                                        StaWork.Step = 1000;
                                        }
                                    else
                                        {
                                        ERR_Count = 0;
                                        BufferStep = 1000;
                                        StaWork.Step = 8000;
                                        }                                  
                                    }
                                }
                            }
                        else
                            {
                            //没有物料，则去取下一个
                            AddList("取Display拍照结果NG！");
                            ShowList("取Display拍照结果NG！");
                            RobotTime.InitialTime();

                            if (ERR_Dis_Count < 4)    //*****进入下一个物料拍照
                                {
                                UpdataMaterialCnt();    //******更新料盘数据
                                RobotTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            else    //*****连续三次没产品暂停处理
                                {
                                UpdataMaterialCnt();    //******更新料盘数据
                                ERR_Dis_Count = 0;//重新计数
                                BufferStep = 1000;
                                StaWork.Step = 8000;
                                }
                            }
                        break;

                    case 1060:
                        if (PVar.空跑)
                        {
                            Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.料盘上取料位置, PVar.ParList.Data[54].ToString(),
                                RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                "0", "0", "0", "0",
                                "2", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到取Display位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1070;
                        }
                        else//******************************************************
                        {
                            RobotPos.OffsetX = (CCD_Vale[1].X + PVar.ParList.Data[25]).ToString();
                            RobotPos.OffsetY = (CCD_Vale[1].Y + PVar.ParList.Data[26]).ToString();
                            RobotPos.OffsetZ = (0 + PVar.ParList.Data[27]).ToString();
                            RobotPos.OffsetT = (CCD_Vale[1].T).ToString();

                            放回Display位置.OffsetX = RobotPos.OffsetX;
                            放回Display位置.OffsetY = RobotPos.OffsetY;
                            放回Display位置.OffsetZ = RobotPos.OffsetZ;
                            放回Display位置.OffsetT = RobotPos.OffsetT;

                            Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.CCD引导取Display位置, PVar.ParList.Data[54].ToString(),
                                  RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                  "0", "0", "0", "0",
                            "2", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到取Display位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1070;
                        }
                        break;

                    case 1070:
                        if (PVar.空跑)
                        {
                            if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.料盘上取料位置))
                            {
                                AddList("机械手运动到取Display位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 1080;
                            }
                        }
                        else
                        {
                            if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.CCD引导取Display位置))
                            {
                                AddList("机械手运动到取Display位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 1080;
                            }
                            else
                            {
                                RobotTime.InitialTime();

                            }
                        }

                        break;

                    case 1080:
                        AddList("打开机械手吸嘴真空吸！");
                        Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 1);
                        RobotTime.InitialTime();
                        StaWork.Step = 1090;
                        break;

                    case 1090:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 1100;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.机械手吸嘴真空吸检测信号) == 1)
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 1100;
                            }
                            else if (RobotTime.TimeIsUp(1500))
                            {
                                ShowList("机械手吸嘴真空吸检测信号异常！");
                                RobotTime.InitialTime();
                                BufferStep = 1090;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 1100:
                        if (RobotTime.TimeIsUp(200))
                            {
                            AddList("机械手吸嘴真空吸检测信号OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1110;
                            }
                        break;

                    case 1110:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Move", "0", "10", "0", "0", "0", "0", "0", "Z", "5", "+", "0", "0", "10");
                        AddList("机械手向上抬升5mm！");
                        RobotTime.InitialTime();
                        StaWork.Step = 1120;
                        break;

                    case 1120:
                        if (EpsonRobot.sRobot_Status == "Move")
                            {
                            AddList("机械手向上抬升OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1130;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 1130:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(500))
                            {
                                Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);
                                RobotTime.InitialTime();
                                StaWork.Step = 1150;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.机械手吸嘴真空吸检测信号) == 1)
                            {
                                Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);
                                RobotTime.InitialTime();
                                StaWork.Step = 1150;
                            }
                            else if (RobotTime.TimeIsUp(500))
                            {
                                ShowList("机械手吸嘴真空吸检测信号异常！");
                                RobotTime.InitialTime();
                                BufferStep = 1130;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 1150:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.显示屏撕模位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到显示屏撕模位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 1160;
                        break;

                    case 1160:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.显示屏撕模位置))
                            {
                            AddList("机械手运动到显示屏撕模位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1170;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 1170:
                        if (RobotTime.TimeIsUp(200))
                            {
                            Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 1);
                            RobotTime.InitialTime();
                            StaWork.Step = 1180;
                            }
                        break;

                    case 1180:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 1190;
                            }
                        }
                        else
                        {
                            if (Gg.GetExDi(0, Gg.InPut1.撕膜夹爪气缸闭合) == 1 && Gg.GetExDi(0, Gg.InPut1.撕膜夹爪气缸张开) == 0)
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 1190;
                            }
                            else if (RobotTime.TimeIsUp(2000))
                            {
                                AddList("PSA撕膜夹爪气缸闭合信号感应异常！");
                                ShowList("PSA撕膜夹爪气缸闭合信号感应异常！");
                                RobotTime.InitialTime();
                                BufferStep = 1180;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 1190:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.Display撕下摸动作, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手Display撕下摸动作开始！");
                        RobotTime.InitialTime();
                        StaWork.Step = 1200;
                        break;

                    case 1200:
                        if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.Display撕下摸动作))
                            {
                            AddList("机械手Display撕下摸动作结束！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1210;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 1210:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.显示屏定位拍照位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到显示屏定位拍照位置！");
                        ERR_Dis_Count = 0;
                        RobotTime.InitialTime();
                        StaWork.Step = 1220;
                        break;

                    case 1220:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.显示屏定位拍照位置))
                            {
                            Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);
                            AddList("机械手运动到显示屏定位拍照位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1230;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;

                    case 1230:
                        if (RobotTime.TimeIsUp(200))
                            {
                            RobotTime.InitialTime();
                            StaWork.Step = 1240;
                            }
                        break;

                    case 1240:
                        sRtn = Command.TCP_CCD_Send(Command.Display定位拍照, BVar.ProData[2, 1]);
                        if (PVar.空跑)
                        {
                            RobotTime.InitialTime();
                            StaWork.Step = 1250;
                        }
                        else
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                RobotTime.InitialTime();
                                StaWork.Step = 1250;
                            }
                            else
                            {
                                AddList("网络命令发送失败！");
                                ShowList("网络命令发送失败！");
                                RobotTime.InitialTime();
                                BufferStep = 1240;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 1250:
                        if (PVar.空跑)
                        {
                            if (RobotTime.TimeIsUp(1000))
                            {
                                AddList("Display定位拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 1270;
                            }
                        }
                        else
                        {
                            if (Command.CCD_Resule && PVar.CCD_Data[0] == Command.Display定位拍照)
                            {
                                AddList("Display定位拍照数据收到！");
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD2_Data[4]);
                                RobotTime.InitialTime();
                                StaWork.Step = 1260;
                            }
                            else
                            {
                                if (RobotTime.TimeIsUp(3000))
                                {
                                    AddList("等待PSA定位拍照数据超时！");
                                    RobotTime.InitialTime();
                                    BufferStep = 1240;
                                    StaWork.Step = 8000;
                                }
                            }
                        }
                        break;

                    case 1260:
                        if (CCD_Vale[1].Judge == 1)
                            {
                            if (Math.Abs(CCD_Vale[1].X - Display贴合位置.X) < 3 && Math.Abs(CCD_Vale[1].Y - Display贴合位置.Y) < 3 && Math.Abs(CCD_Vale[1].T - Display贴合位置.U) < 5)
                                {
                                RobotTime.InitialTime();
                                StaWork.Step = 1270;                            
                                }
                            else
                                {
                                AddList(Command.Display定位拍照 + ":拍照数据偏大，请检查！");
                                ShowList(Command.Display定位拍照 + ":拍照数据偏大，请检查！");
                                if (ERR_Dis_Count < 2)    //*****目前先暂停人为确认后再继续，量产自动再拍一次
                                    {
                                    BufferStep = 1240;
                                    StaWork.Step = 8000;
                                    }
                                else    //*****连续二次拍照超限
                                    {
                                    ERR_Dis_Count = 0;//重新计数
                                    RobotTime.InitialTime();
                                    StaWork.Step = 6000;    //跳转到放回原来的穴位
                                    }
                                }
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            if (ERR_Dis_Count < 3)    //*****进入下一个物料拍照
                                {
                                AddList("Display定位拍照失败！");
                                ShowList("Display定位拍照失败！");
                                BufferStep = 1240;
                                StaWork.Step = 8000;
                                }
                            else    //*****连续三次拍照异常则放会处理
                                {
                                ERR_Dis_Count = 0;//重新计数
                                RobotTime.InitialTime();
                                StaWork.Step = 6000;    //跳转到放回原来的穴位
                                }
                            }
                        break;

                    case 1270:
                        if (Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 0
                            && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 0 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 1)
                        {
                            RobotTime.InitialTime();
                            StaWork.Step = 1265;
                        }
                        break;

                    case 1265:
                        if (PVar.空跑)
                        {
                            Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.预贴显示屏位置, PVar.ParList.Data[54].ToString(),
                                RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                "0", "0", "0", "0",
                                "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到装Display位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1280;
                        }
                        else
                        {
                            RobotPos.OffsetX = (CCD_Vale[1].X + PVar.ParList.Data[22]).ToString();
                            RobotPos.OffsetY = (CCD_Vale[1].Y + PVar.ParList.Data[23]).ToString();
                            RobotPos.OffsetZ = (0 + PVar.ParList.Data[24]).ToString();
                            RobotPos.OffsetT = (CCD_Vale[1].T).ToString();
                            Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.CCD引导装Display位置, PVar.ParList.Data[54].ToString(),
                                  RobotPos.OffsetX, RobotPos.OffsetY, RobotPos.OffsetZ, RobotPos.OffsetT,
                                  "0", "0", "0", "0",
                            "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                            AddList("机械手运动到装Display位置！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1280;
                        }
                        break;

                    case 1280:
                        if (PVar.空跑)
                        {
                            if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.预贴显示屏位置))
                            {
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线真空吸, 0);
                                AddList("机械手运动到装Display位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 1290;
                            }
                        }
                        else
                        {
                            if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.CCD引导装Display位置))
                            {
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                                Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线真空吸, 0);
                                AddList("机械手运动到装Display位置OK！");
                                RobotTime.InitialTime();
                                StaWork.Step = 1290;
                            }
                            else
                            {
                                RobotTime.InitialTime();

                            }
                        }
                        break;

                    case 1290:
                        if (RobotTime.TimeIsUp((int)PVar.ParList.Data[31]*1000))
                            {
                            AddList("机械手装Display初保压时间到！");
                            RobotTime.InitialTime();
                            StaWork.Step = 1500;
                            }
                        break;

                    case 1500:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到待机位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 1510;
                        break;

                    case 1510:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.待机位置))
                            {
                            AddList("机械手运动到待机位置OK！");
                            UpdataMaterialCnt();
                            PVar.Sta_Work[(int)BVar.工位.保压].Enable = true;   //保压使能开启
                            RobotTime.InitialTime();
                            StaWork.Step = 8500;
                            }
                        else
                            {
                            RobotTime.InitialTime();
                            
                            }
                        break;


                        //***结果OK运行结束
                    case 8500:
                        StaWork.Enable = false;
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    //***结果NG运行结束
                    case 9000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;


                    //*****机械手把载台上的异常物料取走并丢到废料盒处
                    case 5000:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.取PSA位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到取PSA位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 5010;
                        break;

                    case 5010:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.取PSA位置))
                            {
                            AddList("机械手运动到取PSA位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 5020;
                            }
                        else
                            {
                            RobotTime.InitialTime();

                            }
                        break;

                    case 5020:
                        if (RobotTime.TimeIsUp(200))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 1);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 1);
                            RobotTime.InitialTime();
                            StaWork.Step = 5030;
                            }
                        break;

                    case 5030:
                        if (RobotTime.TimeIsUp(1000))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 0);
                            RobotTime.InitialTime();
                            StaWork.Step = 5040;
                            }
                        break;

                    case 5040:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.PSA抛料位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到PSA抛料位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 5050;
                        break;

                    case 5050:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.PSA抛料位置))
                            {
                            AddList("机械手运动到PSA抛料位置OK！");
                            RobotTime.InitialTime();
                            StaWork.Step = 5060;
                            }
                        else
                            {
                            RobotTime.InitialTime();

                            }
                        break;

                    case 5060:
                        if (RobotTime.TimeIsUp(200))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 1);
                            RobotTime.InitialTime();
                            StaWork.Step = 5070;
                            }
                        break;

                    case 5070:
                        if (RobotTime.TimeIsUp(500))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 0);
                            RobotTime.InitialTime();
                            StaWork.Step = 5080;
                            }
                        break;

                    case 5080:
                        Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, PVar.ParList.Data[54].ToString(), "0", "0", "0", "0", "0", "0", "0", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到待机位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 5090;
                        break;

                    case 5090:
                        if ((EpsonRobot.sRobot_Status == "Step" + RobotPosName.待机位置))
                            {
                            AddList("机械手运动到待机位置OK！");
                            RobotTime.InitialTime();
                            StaWork.IsHavePSA = false;  //把供料站有物料清除
                            StaWork.Step = 100;     //抛料后返回等待取料
                            }
                        else
                            {
                            RobotTime.InitialTime();

                            }
                        break;


                        //*****机械手装显示屏异常处理
                    case 6000:
                        //放回的高度稍微高点
                        放回Display位置.OffsetZ = System.Convert.ToString(System.Convert.ToDouble(放回Display位置.OffsetZ) - 5);

                        Frm_Engineering.fEngineering.Rbt_SendCmd("CCDStep", RobotPosName.CCD引导取Display位置, PVar.ParList.Data[54].ToString(),
                              放回Display位置.OffsetX, 放回Display位置.OffsetY, 放回Display位置.OffsetZ, 放回Display位置.OffsetT,
                              "0", "0", "0", "0",
                        "0", PVar.Tray.MaterialCnt.ToString(), PVar.ParList.Data[55].ToString());
                        AddList("机械手运动到之前取Display位置！");
                        RobotTime.InitialTime();
                        StaWork.Step = 6010;
                        break;

                    case 6010:
                        if ((EpsonRobot.sRobot_Status == "CCDStep" + RobotPosName.CCD引导取Display位置))
                            {
                            AddList("机械手运动到之前取Display位置OK！");
                            
                            RobotTime.InitialTime();
                            StaWork.Step = 6020;
                            }
                        else
                            {
                            RobotTime.InitialTime();

                            }
                        break;

                    case 6020:
                        if (RobotTime.TimeIsUp(500))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线真空吸, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴破真空, 1);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 1);
                            RobotTime.InitialTime();
                            StaWork.Step = 6030;
                            }                    
                        break;

                    case 6030:
                        if (RobotTime.TimeIsUp(500))
                            {
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴破真空, 0);
                            Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 0);
                            UpdataMaterialCnt();    //******更新料盘数据
                            RobotTime.InitialTime();
                            StaWork.Step = 1000;    //运到下一个物料拍照位置
                            }
                        break;


                    //遇到异常，设备先暂停，确定后处理************************
                    case 8000:
                        PVar.IsSystemOnPauseMode = true;
                        PVar.MacHold = true;
                        StaWork.StaHold = true;
                        PVar.Stop_Flag = false;
                        Frm_Main.fMain.Btn_Start.Enabled = false;
                        Frm_Main.fMain.Btn_Pause.Enabled = true;
                        Frm_Main.fMain.Btn_Stop.Enabled = false;
                        Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                        Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        //Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;

                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
                        break;

                    //严重错误，急停处理
                    case 10000:
                        Frm_Engineering.fEngineering.MacStop();
                        break;
                }
            }
            catch (Exception ex)
            {
                string Error_Str = "";
                string Error_Str1 = "";
                Frm_Engineering.fEngineering.MacStop();
                MessageBox.Show(ex.Message);
                Error_Str = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_代码异常记录" + ".txt";
                Error_Str1 = "\r\n" + "※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※" + "\r\n" +
                    "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "\r\n" + ex.ToString();
                FileRw.WriteDattxt(Error_Str, Error_Str1);
            }
        }

        //******更新料盘数据
        /// <summary>
        /// ******更新料盘数据
        /// </summary>
        public static void UpdataMaterialCnt()
            {
            if (PVar.Tray.MaterialCnt < 10)
                {
                PVar.Tray.MaterialCnt += 1;
                }
            else
                {
                //需要更换物料
                //ShowList("物料已经用完，请更换物料！");
                PVar.Tray.MaterialCnt = 1;
                }
            //******更新数据
            Frm_Engineering.fEngineering.Txt_PalletNum.Text = PVar.Tray.MaterialCnt.ToString();
            Frm_Engineering.fEngineering.Txt_PalletSelectNum.Text = Frm_Engineering.fEngineering.Txt_PalletNum.Text;
            BVar.FileRorW.WriteINI("Material_index", "Display", PVar.Tray.MaterialCnt.ToString(), PVar.PublicParPath);
            }

        public static void ManualRun(string ActiveStep, int Speed) 
            {
            string Speeds;
            Speeds = Convert.ToString(Speed * 1);

            switch (ActiveStep)
                {
                case "6":
                    Frm_Engineering.fEngineering.Rbt_SendCmd("Step", ActiveStep, Speed.ToString(), "0", "0", "0", "0", "0", "0", "", "0",
                        "1", PVar.Tray.MaterialCnt.ToString(), Speeds);
                    break;
                case "7":
                    Frm_Engineering.fEngineering.Rbt_SendCmd("Step", ActiveStep, Speed.ToString(), "0", "0", "0", "0", "0", "0", "", "0",
                        "2", PVar.Tray.MaterialCnt.ToString(), Speeds);
                    break;
                default:
                    Frm_Engineering.fEngineering.Rbt_SendCmd("Step", ActiveStep, Speed.ToString(), "0", "0", "0", "0", "0", "0", "", "0", "0", "0", Speeds);
                    break;
                }
         
            int iTime = System.Convert.ToInt32(API.GetTickCount());
            do
                {
                Thread.Sleep(10);
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 10000 & Gg.GetDi(0, 2) == 0 & Gg.GetDi(0, 3) == 0)
                    {
                    break;//运行完成退出
                    }
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 10000 & (Gg.GetDi(0, 3) == 1))
                    {
                    break;//暂停超出5秒后退出
                    }
                if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 10000 & (Gg.GetDi(0, 4) == 1 || Gg.GetDi(0, 1) == 0))
                    {
                    break;
                    }
                Application.DoEvents();
                } while (EpsonRobot.sRobot_Status != "Step" + ActiveStep);

            EpsonRobot.RobotIsWork = false;
            Frm_Engineering.fEngineering.Text_Robot_X.Text = EpsonRobot.RobotPos.X.ToString("f3");
            Frm_Engineering.fEngineering.Text_Robot_Y.Text = EpsonRobot.RobotPos.Y.ToString("f3");
            Frm_Engineering.fEngineering.Text_Robot_Z.Text = EpsonRobot.RobotPos.Z.ToString("f3");
            Frm_Engineering.fEngineering.Text_Robot_U.Text = EpsonRobot.RobotPos.U.ToString("f3");
            Frm_Engineering.fEngineering.Text_Robot_V.Text = EpsonRobot.RobotPos.V.ToString("f3");
            Frm_Engineering.fEngineering.Text_Robot_W.Text = EpsonRobot.RobotPos.W.ToString("f3");
            }
        
    }
}
