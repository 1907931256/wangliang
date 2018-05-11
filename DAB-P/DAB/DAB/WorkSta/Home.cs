using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace DAB
{
    sealed class GoHome
    {
        public static PVar.sFlag3 Reset;
        public static PVar.HomeType[,] AxisHome = new PVar.HomeType[2, 9];
        public static PVar.sFlag3 AxisGoHome;
        public static int StepHome = 0;
        private static Tool.Delay InitTime = new Tool.Delay();
        private static Tool.Delay[] InitTime1 = new Tool.Delay[9];
        private static Tool.Delay[,] InitTimeH = new Tool.Delay[4, 9];
        private static int RobotHomeNum = 0;
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        public static void HomeSub()
        {

            switch (StepHome)
            {
                case 10:
                    GoHome.Reset.State = true;
                    AddList("设备初始化开始，请等待！");

                    //停止流水线
                    Linechange.SetMotor1(false, 0);//
                    Linechange.SetMotor2(false, 0);
                    Linechange.SetMotor3(false, 0);
                    AddList("关闭传送带电机");
                    if (EpsonRobot.IsRobotAlarm)
                    {
                        AddList("机械手报警，初始化失败，请检查！");
                        ShowList("机械手报警，初始化失败，请检查！");
                        StepHome = 1000;
                        return;
                    }
                    Gg.SetDo(0, Gg.OutPut0.启动按钮指示灯, 0);
                    Gg.SetDo(0, Gg.OutPut0.日光灯继电器, 0);
                    Gg.SetDo(0, Gg.OutPut0.步进电机使能, 0);
                    Gg.SetDo(0, Gg.OutPut0.阻挡气缸1, 1);
                    Gg.SetDo(0, Gg.OutPut0.阻挡气缸2, 1);
                    Gg.SetDo(0, Gg.OutPut0.阻挡气缸3, 1);

                    Gg.SetExDo(0, 0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.光源旋转气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.撕膜夹爪气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.机械手滑台气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜升降气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.机械手撕膜针型气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.载具夹紧气缸, 0);

                    Gg.SetExDo(0, 1, Gg.OutPut2.NG指示灯, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.OK指示灯, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.PSA载台破真空, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.PSA载台真空吸, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.搬运PSA破真空, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.搬运PSA真空吸, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴破真空, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.机械手吸嘴真空吸, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜破真空, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.机械手夹爪吸膜真空吸, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线破真空, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.机械手排线真空吸, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.右料盘吸电磁铁, 1);
                    Gg.SetExDo(0, 1, Gg.OutPut2.左料盘吸电磁铁, 1);
                    Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品破真空, 0);
                    Gg.SetExDo(0, 1, Gg.OutPut2.载具上产品真空吸, 0);

                    Gg.SetExDo(0, 2, Gg.OutPut3.离子风扇, 0);

                    RobotHomeNum = 0;
                    ////界面
                    Frm_Main.fMain.Btn_Stop.Enabled = false;
                    Frm_Main.fMain.Btn_Pause.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_ProgressBar.IsShowProgresBar(true);
                    InitTime.InitialTime();
                    StepHome = 20;
                    break;

                //机械手回初始位置
                case 20:
                    RobotHomeNum += 1;
                    AddList("机械手停止！");
                    Gg.SetDo(0, Gg.OutPut0.机械手停止, 1);
                    WinAPI.Wait(200);
                    Gg.SetDo(0, Gg.OutPut0.机械手停止, 0);
                    WinAPI.Wait(100);
                    InitTime.InitialTime();
                    StepHome = 22;
                    break;

                case 22:
                    AddList("机械手复位！");
                    Gg.SetDo(0, Gg.OutPut0.机械手复位, 1);
                    WinAPI.Wait(200);
                    Gg.SetDo(0, Gg.OutPut0.机械手复位, 0);
                    WinAPI.Wait(100);
                    InitTime.InitialTime();
                    StepHome = 24;
                    break;

                case 24:
                    AddList("机械手启动！");
                    Gg.SetDo(0, Gg.OutPut0.机械手启动, 1);
                    WinAPI.Wait(200);
                    Gg.SetDo(0, Gg.OutPut0.机械手启动, 0);
                    WinAPI.Wait(100);
                    InitTime.InitialTime();
                    StepHome = 30;
                    break;

                case 30:
                    if (Gg.GetDi(0, Gg.InPut0.机械手运动中) == 1)
                    {
                        AddList("机械手启动成功！");
                        InitTime.InitialTime();
                        StepHome = 40;
                    }
                    else if (InitTime.TimeIsUp(2000))
                    {
                        if (RobotHomeNum < 3)
                        {
                            InitTime.InitialTime();
                            StepHome = 20;
                        }
                        else
                        {
                            AddList("机械手启动失败！");
                            ShowList("机械手启动失败！");
                            StepHome = 1000;
                            return;
                        }
                    }
                    break;

                case 40:
                    if (Frm_Engineering.fEngineering.Tcp_Robot.IsStart)
                    {
                        AddList("机械手网络链接OK！");
                        InitTime.InitialTime();
                        StepHome = 50;
                    }
                    else if (InitTime.TimeIsUp(5000))
                    {
                        if (RobotHomeNum < 3)
                        {
                            InitTime.InitialTime();
                            StepHome = 20;
                        }
                        else
                        {
                            AddList("机械手网络链接失败！");
                            ShowList("机械手网络链接失败！");
                            StepHome = 1000;
                            return;
                        }
                    }
                    break;

                case 50:
                    AddList("获取机械手程序版本！");
                    if (Frm_Engineering.fEngineering.Rbt_SendCmd("GetVersion", "0", "0", "0", "0", "0", "0", "0",
                        "DAB-SV(1.0.0)_20180505", "0", "0", "0", "0", "0") == false)
                    {
                        StepHome = 1000;
                        return;
                    }
                    InitTime.InitialTime();
                    StepHome = 60;
                    break;

                case 60:
                    if (EpsonRobot.sRobot_Status == "GetVersionOK")
                    {
                        AddList("机械手程序版本匹配OK！");
                        InitTime.InitialTime();
                        StepHome = 100;
                    }
                    else if (EpsonRobot.sRobot_Status == "GetVersionNG")
                    {
                        AddList("机械手版本不匹配！");
                        ShowList("机械手版本不匹配！");
                        StepHome = 1000;
                        return;
                    }
                    else if (InitTime.TimeIsUp(3000))
                    {
                        AddList("获取机械手程序版本超时！");
                        ShowList("获取机械手程序版本超时！");
                        StepHome = 1000;
                        return;
                    }
                    break;

                case 100:
                    AddList("机械手回初始位置开始！");
                    if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                    {
                        StepHome = 1000;
                        return;
                    }
                    InitTime.InitialTime();
                    StepHome = 110;
                    break;

                case 110:
                    if (EpsonRobot.sRobot_Status == "Step" + RobotPosName.待机位置)
                    {
                        AddList("机械手回待机位置OK！");
                        InitTime.InitialTime();
                        StepHome = 200;
                    }
                    else if (InitTime.TimeIsUp(10000))
                    {
                        AddList("机械手回待机位置超时！");
                        ShowList("机械手回待机位置超时！");
                        StepHome = 1000;
                        return;
                    }
                    break;

                case 200:
                    Frm_ProgressBar.SetValueProgressBar(30);     //初始化进度条的进度更新显示
                    if (Gg.GetDi(0, Gg.InPut0.阻挡气缸1伸出) == 1 && Gg.GetDi(0, Gg.InPut0.阻挡气缸2伸出) == 1 && Gg.GetDi(0, Gg.InPut0.阻挡气缸3伸出) == 1
                        && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut1.机械手滑台气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut1.机械手滑台气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                    {
                        InitTime.InitialTime();
                        StepHome = 210;
                    }

                    if (InitTime.TimeIsUp(6000))
                    {
                        if (Gg.GetDi(0, Gg.InPut0.阻挡气缸1伸出) == 0)
                        {
                            AddList("阻挡气缸1伸出信号异常，请检查！");
                            ShowList("阻挡气缸1伸出信号异常，请检查！");
                        }

                        if (Gg.GetDi(0, Gg.InPut0.阻挡气缸2伸出) == 0)
                        {
                            AddList("阻挡气缸2伸出信号异常，请检查！");
                            ShowList("阻挡气缸2伸出信号异常，请检查！");
                        }
                        if (Gg.GetDi(0, Gg.InPut0.阻挡气缸3伸出) == 0)
                        {
                            AddList("阻挡气缸3伸出信号异常，请检查！");
                            ShowList("阻挡气缸3伸出信号异常，请检查！");
                        }

                        if (Gg.GetExDi(0, Gg.InPut1.光源旋转气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut1.光源旋转气缸伸出) == 1)
                        {
                            AddList("光源旋转气缸缩回信号异常，请检查！");
                            ShowList("光源旋转气缸缩回回信号异常，请检查！");
                        }

                        if (Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut1.载具夹紧气缸伸出) == 1)
                        {
                            AddList("载具夹紧气缸缩回信号异常，请检查！");
                            ShowList("载具夹紧气缸缩回信号异常，请检查！");
                        }

                        if (Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut1.机械手撕膜升降气缸伸出) == 1)
                        {
                            AddList("机械手撕膜升降气缸缩回信号异常，请检查！");
                            ShowList("机械手撕膜升降气缸缩回信号异常，请检查！");
                        }

                        if (Gg.GetExDi(0, Gg.InPut1.机械手滑台气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut1.机械手滑台气缸伸出) == 1)
                        {
                            AddList("机械手滑台气缸缩回信号异常，请检查！");
                            ShowList("机械手滑台气缸缩回信号异常，请检查！");
                        }
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 1)
                        {
                            AddList("PSA吸嘴升降气缸上信号异常，请检查！");
                            ShowList("PSA吸嘴升降气缸上信号异常，请检查！");
                        }
                        StepHome = 1000;
                    }
                    break;

                case 210:
                    AddList("料仓左Z轴开始回原点…");
                    AddList("料仓右Z轴开始回原点…");
                    AddList("PSA供料Z轴开始回原点…");
                    AddList("保压Z轴开始回原点…");
                    AddList("PSA搬运Y轴开始回原点…");
                    GoHome.AxisHome[0, Axis.料仓左Z轴].Result = false;
                    GoHome.AxisHome[0, Axis.料仓右Z轴].Result = false;
                    GoHome.AxisHome[0, Axis.PSA供料Z轴].Result = false;
                    GoHome.AxisHome[0, Axis.保压Z轴].Result = false;
                    GoHome.AxisHome[0, Axis.PSA搬运Y轴].Result = false;

                    GoHome.AxisHome[0, Axis.料仓左Z轴].Enable = true;
                    GoHome.AxisHome[0, Axis.料仓右Z轴].Enable = true;
                    GoHome.AxisHome[0, Axis.PSA供料Z轴].Enable = true;
                    GoHome.AxisHome[0, Axis.保压Z轴].Enable = true;
                    GoHome.AxisHome[0, Axis.PSA搬运Y轴].Enable = true;

                    GoHome.AxisHome[0, Axis.料仓左Z轴].Step = 10;
                    GoHome.AxisHome[0, Axis.料仓右Z轴].Step = 10;
                    GoHome.AxisHome[0, Axis.PSA供料Z轴].Step = 10;
                    GoHome.AxisHome[0, Axis.保压Z轴].Step = 10;
                    GoHome.AxisHome[0, Axis.PSA搬运Y轴].Step = 10;
                    InitTime.InitialTime();
                    Frm_ProgressBar.SetValueProgressBar(30);
                    StepHome = 220;
                    break;

                case 220:
                    GotoHome(0, Axis.料仓左Z轴, 30, -1000, 10, 1, 5);
                    GotoHome(0, Axis.料仓右Z轴, 30, -1000, 10, 1, 5);
                    GotoHome(0, Axis.PSA供料Z轴, 30, -1000, 10, 1, 5);
                    GotoHome(0, Axis.保压Z轴, 30, -90, 20, -3, 5);
                    GotoHome(0, Axis.PSA搬运Y轴, 30, -1000, 10, 1, 10);

                    if (GoHome.AxisHome[0, Axis.PSA搬运Y轴].Step != 0 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0)
                    {
                        AddList("PSA吸嘴升降气缸上信号异常！");
                        ShowList("PSA吸嘴升降气缸上信号异常！");
                        StepHome = 1000;
                    }

                    if (GoHome.AxisHome[0, Axis.料仓左Z轴].Step == 0 && GoHome.AxisHome[0, Axis.料仓左Z轴].Enable)
                    {
                        GoHome.AxisHome[0, Axis.料仓左Z轴].Enable = false;
                        if (GoHome.AxisHome[0, Axis.料仓左Z轴].Result)
                        {
                            AddList("料仓左Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("料仓左Z轴回原点失败！");
                            ShowList("料仓左Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.AxisHome[0, Axis.料仓右Z轴].Step == 0 && GoHome.AxisHome[0, Axis.料仓右Z轴].Enable)
                    {
                        GoHome.AxisHome[0, Axis.料仓右Z轴].Enable = false;
                        if (GoHome.AxisHome[0, Axis.料仓右Z轴].Result)
                        {
                            AddList("料仓右Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("料仓右Z轴回原点失败！");
                            ShowList("料仓右Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.AxisHome[0, Axis.PSA供料Z轴].Step == 0 && GoHome.AxisHome[0, Axis.PSA供料Z轴].Enable)
                    {
                        GoHome.AxisHome[0, Axis.PSA供料Z轴].Enable = false;
                        if (GoHome.AxisHome[0, Axis.PSA供料Z轴].Result)
                        {
                            AddList("PSA供料Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("PSA供料Z轴回原点失败！");
                            ShowList("PSA供料Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.AxisHome[0, Axis.保压Z轴].Step == 0 && GoHome.AxisHome[0, Axis.保压Z轴].Enable)
                    {
                        GoHome.AxisHome[0, Axis.保压Z轴].Enable = false;
                        if (GoHome.AxisHome[0, Axis.保压Z轴].Result)
                        {
                            AddList("保压Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("保压Z轴回原点失败！");
                            ShowList("保压Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.AxisHome[0, Axis.PSA搬运Y轴].Step == 0 && GoHome.AxisHome[0, Axis.PSA搬运Y轴].Enable)
                    {
                        GoHome.AxisHome[0, Axis.PSA搬运Y轴].Enable = false;
                        if (GoHome.AxisHome[0, Axis.PSA搬运Y轴].Result)
                        {
                            AddList("PSA搬运Y轴回原点成功！");
                        }
                        else
                        {
                            AddList("PSA搬运Y轴回原点失败！");
                            ShowList("PSA搬运Y轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.AxisHome[0, Axis.料仓左Z轴].Result && GoHome.AxisHome[0, Axis.料仓右Z轴].Result &&
                        GoHome.AxisHome[0, Axis.PSA供料Z轴].Result && GoHome.AxisHome[0, Axis.保压Z轴].Result &&
                        GoHome.AxisHome[0, Axis.PSA搬运Y轴].Result)
                    {
                        Frm_ProgressBar.SetValueProgressBar(50);
                        InitTime.InitialTime();
                        StepHome = 300;
                    }
                    break;

                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                case 300:
                    AddList("各轴开始回待机位置…");
                    //料仓
                    Gg.AbsMotion(0, Axis.料仓左Z轴, mFunction.Pos.TeachAxis1[Axis.tTag.左料仓, Axis.Point左料仓.初始位置], 20);
                    Gg.AbsMotion(0, Axis.料仓右Z轴, mFunction.Pos.TeachAxis1[Axis.tTag.右料仓, Axis.Point右料仓.初始位置], 20);

                    //PSA供料
                    Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴初始位置], 20);
                    Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴吸料位置], 20);

                    //保压站
                    Gg.AbsMotion(0, Axis.保压Z轴, mFunction.Pos.TeachAxis1[Axis.tTag.保压, Axis.Point保压.初始位置], 20);

                    InitTime.InitialTime();
                    StepHome = 310;
                    break;

                case 310:
                    if (Gg.ZSPD(0, Axis.PSA搬运Y轴) == false && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0)
                    {
                        AddList("PSA吸嘴升降气缸上信号异常！");
                        ShowList("PSA吸嘴升降气缸上信号异常！");
                        StepHome = 1000;
                    }

                    if (Gg.ZSPD(0, Axis.料仓左Z轴) && Gg.ZSPD(0, Axis.料仓右Z轴) &&
                        Gg.ZSPD(0, Axis.PSA供料Z轴) && Gg.ZSPD(0, Axis.PSA搬运Y轴) &&
                        Gg.ZSPD(0, Axis.保压Z轴))
                    {
                        AddList("整机回待机位置完成！");
                        InitTime.InitialTime();
                        StepHome = 350;
                    }
                    else
                    {
                        if (InitTime.TimeIsUp(10000))
                        {
                            if (Gg.ZSPD(0, Axis.料仓左Z轴) == false)
                            {
                                AddList("料仓左Z轴回待机位置失败！");
                                ShowList("料仓左Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, Axis.料仓右Z轴) == false)
                            {
                                AddList("料仓右Z轴回待机位置失败！");
                                ShowList("料仓右Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, Axis.PSA供料Z轴) == false)
                            {
                                AddList("PSA供料Z轴回待机位置失败！");
                                ShowList("PSA供料Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, Axis.PSA搬运Y轴) == false)
                            {
                                AddList("PSA搬运Y轴回待机位置失败！");
                                ShowList("PSA搬运Y轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, Axis.保压Z轴) == false)
                            {
                                AddList("保压Z轴回待机位置失败！");
                                ShowList("保压Z轴回待机位置失败！");
                            }
                            StepHome = 1000;
                        }
                    }
                    break;

                case 350:
                    //平移气缸回到左边
                    Gg.SetExDo(0, 2, Gg.OutPut3.料盘平移无杆气缸左, 1);
                    Gg.SetExDo(0, 2, Gg.OutPut3.料盘平移无杆气缸右, 0);

                    //保压无杆气缸向右复位
                    Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸左, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut1.保压无杆气缸右, 1);
                    AddList("料盘平移无杆气缸向左复位！");
                    InitTime.InitialTime();
                    StepHome = 360;
                    break;

                case 360:
                    if (Gg.GetExDi(2, Gg.InPut3.料盘平移无杆气缸左) == 1 && Gg.GetExDi(2, Gg.InPut3.料盘平移无杆气缸右) == 0 &&
                        Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 1 && Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 0)
                    {
                        AddList("料盘平移无杆气缸向左复位OK！");
                        InitTime.InitialTime();
                        StepHome = 370;
                    }
                    else
                    {
                        if (InitTime.TimeIsUp(6000))
                            if (Gg.GetExDi(2, Gg.InPut3.料盘平移无杆气缸左) == 0 || Gg.GetExDi(2, Gg.InPut3.料盘平移无杆气缸右) == 1)
                            {
                                AddList("料盘平移无杆气缸左信号异常！");
                                InitTime.InitialTime();
                                StepHome = 1000;
                            }
                        if (Gg.GetExDi(0, Gg.InPut1.保压无杆气缸左) == 1 || Gg.GetExDi(0, Gg.InPut1.保压无杆气缸右) == 0)
                        {
                            AddList("保压无杆气缸右信号异常！");
                            InitTime.InitialTime();
                            StepHome = 1000;
                        }
                    }
                    break;

                case 370:
                    InitTime.InitialTime();
                    StepHome = 800;
                    break;

                case 800:
                    AddList("初始化完成");
                    ShowList("初始化完成");
                    PVar.LampStatus = 20;
                    PVar.Stop_Flag = true;
                    PVar.AutoRunFlag = false;
                    PVar.MacHold = false;
                    PVar.CPKDoneCounts = 0;
                    PVar.WorkMode = 0;

                    Frm_Main.fMain.Panel_CPK.Visible = false;

                    //按钮初始化
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    Frm_Main.fMain.Btn_Pause.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.Enabled = true;
                    Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_SelectedBtn;   //'主页面初始化和自动运行按钮
                    Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;

                    Frm_Engineering.fEngineering.TabPage3.Parent = Frm_Engineering.fEngineering.TabControl1;
                    Frm_Engineering.fEngineering.TabPage4.Parent = Frm_Engineering.fEngineering.TabControl1;

                    Frm_ProgressBar.IsShowProgresBar(false);     //'初始化进度条显示
                    Frm_Engineering.fEngineering.Home_Timer.Enabled = false;
                    for (int i = 0; i <= 10; i++)
                    {
                        PVar.Sta_Work[i].State = false;
                        PVar.Sta_Work[i].Result = false;
                        PVar.Sta_Work[i].IsHaveHSG = false;
                        PVar.Sta_Work[i].Step = 0;
                    }
                    Mod_ErrorCode.CheckSystemTimeStep = 0;
                    GoHome.Reset.State = false;
                    GoHome.Reset.Result = true;
                    StepHome = 0;
                    break;

                case 1000:
                    PVar.LampStatus = 10;
                    PVar.MacHold = false;
                    PVar.Stop_Flag = true;
                    //按钮初始化
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    Frm_Main.fMain.Btn_Pause.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.Enabled = false;
                    Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;   //主页面初始化和自动运行按钮
                    Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_SelectedEndBtn;

                    PVar.Rtn = gts.GT_Stop(0, 255, 255); //紧急停止0号卡所有轴
                    Frm_Engineering.fEngineering.Home_Timer.Enabled = false;
                    Frm_ProgressBar.IsShowProgresBar(false);     //初始化进度条显示
                    GoHome.Reset.Result = false;
                    GoHome.Reset.State = false;
                    StepHome = 0;
                    break;
            }

            //string tempStr = "";
            //if (Gg.GetDi(0, Gg.InPut0.安全门) == 0)
            //    {
            //    tempStr = "安全门";
            //    }

            //if (!string.IsNullOrEmpty(tempStr))
            //    {
            //    AddList("请关闭" + tempStr + "再初始化");
            //    ShowList("请关闭" + tempStr + "再初始化");
            //    StepHome = 1000;
            //    return;
            //    }
        }




        /// <summary>
        /// GotoHome(short CardNum[卡号], short Axis[轴号], double homeToLimitFDist[极限到原点距离], double searchHomeDist[原点搜索距离], double offsetPos[感应宽度], double homeoffset[原点偏移距离], double vel[搜索原点速度])
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <param name="homeToLimitFDist"></param>
        /// <param name="searchHomeDist"></param>
        /// <param name="offsetPos"></param>
        /// <param name="homeoffset"></param>
        /// <param name="vel"></param>
        public static void GotoHome(short CardNum, short Axis, double homeToLimitFDist, double searchHomeDist, double offsetPos, double homeoffset, double vel)
        {
            uint temp_pClock = 0;
            if (GoHome.AxisHome[CardNum, Axis].Step != 0)
            {
                Frm_Engineering.fEngineering.textBox3.Text = GoHome.AxisHome[CardNum, Axis].Step.ToString();
                GoHome.AxisHome[CardNum, Axis].State = true;
                switch (GoHome.AxisHome[CardNum, Axis].Step)
                {
                    case 10:
                        InitTimeH[CardNum, Axis] = new Tool.Delay();
                        gts.GT_ClrSts(CardNum, Axis, (short)1); //清除报警
                        gts.GT_SetPrfPos(CardNum, Axis, 0); //规划器置零
                        gts.GT_SetEncPos(CardNum, Axis, 0); //编码器置零                     
                        gts.GT_SynchAxisPos(CardNum, 1 << (Axis - 1)); //将当前轴进行位置同步
                        GoHome.AxisHome[CardNum, Axis].Counter = 0; //回原点计数
                        GoHome.AxisHome[CardNum, Axis].Step = 20;
                        break;

                    case 20:
                        GoHome.AxisHome[CardNum, Axis].Capture = 0;
                        if (Gg.GetHomeDi(CardNum, Axis) == 0) //判断是否在原点上
                        {
                            if (GoHome.AxisHome[CardNum, Axis].Counter > 1)
                            {
                                GoHome.AxisHome[CardNum, Axis].Step = 140;
                            }
                            else
                            {
                                GoHome.AxisHome[CardNum, Axis].Counter = GoHome.AxisHome[CardNum, Axis].Counter + 1;
                                GoHome.AxisHome[CardNum, Axis].Step = 30; //开始搜索原点
                            }
                        }
                        else
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 200; //偏离原点，方向与搜索原点方向相反
                        }
                        break;

                    case 30:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第一次原点搜索
                        GoHome.AxisHome[CardNum, Axis].TempPos = 0;
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + searchHomeDist), vel); //启动运动，开始搜索原点
                        GoHome.AxisHome[CardNum, Axis].Step = 40;
                        break;

                    case 40:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        gts.GT_GetCaptureStatus(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].Capture, out GoHome.AxisHome[CardNum, Axis].TempPos, (short)1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
                        if (GoHome.AxisHome[CardNum, Axis].Capture == 1) //判断当前轴是否原点捕获触发
                        {
                            //Gg.AxisStop(CardNum, Axis); //当前轴停止
                            gts.GT_Stop(CardNum, 1 << (Axis - 1), 1 << (Axis - 1));
                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Capture = 0;
                            GoHome.AxisHome[CardNum, Axis].Step = 50;
                        }
                        else if (Gg.GetLimitDi_Z(CardNum, Axis) == 1) //判断当前轴是否触发正极限
                        {
                            //Gg.AxisStop(CardNum, Axis); //当前轴停止
                            gts.GT_Stop(CardNum, 1 << (Axis - 1), 1 << (Axis - 1));
                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Step = 170;
                        }
                        else if (Gg.GetLimitDi_F(CardNum, Axis) == 1) //判断当前轴是否触发负极限
                        {
                            //Gg.AxisStop(CardNum, Axis); //当前轴停止
                            gts.GT_Stop(CardNum, 1 << (Axis - 1), 1 << (Axis - 1));
                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Step = 150;
                        }
                        else if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false) //判断当前轴规划器是否运动停止（原点搜索距离太小）
                        {
                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Step = 140;
                        }
                        break;

                    case 50:
                        if (InitTimeH[CardNum, Axis].TimeIsUp(500))
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 52;
                        }
                        break;

                    case 52:
                        //Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(GoHome.AxisHome[CardNum, Axis].TempPos / Gg.PlusPerUnit(CardNum, Axis)) / Tools.GeerRate[CardNum, Axis] + 1, 2);
                        //Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + offsetPos), 10); //启动运动，原点反向运动
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + 2), 5); //启动运动，原点反向运动
                        GoHome.AxisHome[CardNum, Axis].Step = 60;
                        break;

                    case 60:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock); //获取当前轴的状态
                        if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false) //判断当前轴是否运动停止
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 70;
                        }
                        break;

                    case 70:
                        if (InitTimeH[CardNum, Axis].TimeIsUp(500))
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 72;
                        }
                        break;

                    case 72:
                        gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第二次原点搜索
                        //hRtn = gts.GT_SetCaptureMode(CardNum, Axis,gts. CAPTURE_INDEX);    //启动当前轴的Z相脉冲捕获
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) - offsetPos * 2), 1); //以1mm/s速度找原点
                        GoHome.AxisHome[CardNum, Axis].Step = 80; //跳转到下一步
                        break;

                    case 80:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock); //获取当前轴的状态
                        gts.GT_GetCaptureStatus(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].Capture, out GoHome.AxisHome[CardNum, Axis].TempPos, (short)1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
                        if (GoHome.AxisHome[CardNum, Axis].Capture == 1) //判断当前轴是否Z相脉冲捕获触发
                        {
                            //Gg.AxisStop(CardNum, Axis); //当前轴停止
                            gts.GT_Stop(CardNum, 1 << (Axis - 1), 1 << (Axis - 1));
                            GoHome.AxisHome[CardNum, Axis].Capture = 0; //捕获触发标志清零
                            GoHome.AxisHome[CardNum, Axis].Step = 90;
                        }
                        else if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 140; //跳转到第110步（或脉冲未捕获，回原点结束，回原点失败）
                        }
                        break;

                    case 90:
                        if (InitTimeH[CardNum, Axis].TimeIsUp(500))
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 92;
                        }
                        break;

                    case 92:
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + homeoffset), 2);
                        //if (homeoffset < 3)
                        //    {
                        //    Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(GoHome.AxisHome[CardNum, Axis].TempPos / Gg.PlusPerUnit(CardNum, Axis) / Tools.GeerRate[CardNum, Axis]) + homeoffset, 2);
                        //    }
                        //else
                        //    {
                        //    Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(GoHome.AxisHome[CardNum, Axis].TempPos / Gg.PlusPerUnit(CardNum, Axis) / Tools.GeerRate[CardNum, Axis]) + homeoffset, 5);
                        //    }
                        GoHome.AxisHome[CardNum, Axis].Step = 100;
                        break;

                    case 100:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false) //判断当前轴是否运动停止
                        {
                            InitTime.InitialTime();
                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Step = 110;
                        }
                        break;

                    case 110:
                        if (InitTimeH[CardNum, Axis].TimeIsUp(200))
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 120;
                        }
                        break;

                    case 120:
                        gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
                        gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
                        gts.GT_SynchAxisPos(CardNum, 1 << (Axis - 1)); //将当前轴进行位置同步
                        InitTimeH[CardNum, Axis].InitialTime();
                        GoHome.AxisHome[CardNum, Axis].Step = 130;
                        break;

                    case 130:
                        if (InitTimeH[CardNum, Axis].TimeIsUp(50))
                        {
                            if (Gg.GetEncPos(CardNum, Axis) == 0 && Gg.GetPrfPos(CardNum, Axis) == 0)
                            {
                                GoHome.AxisHome[CardNum, Axis].Result = true;
                                GoHome.AxisHome[CardNum, Axis].State = false;
                                GoHome.AxisHome[CardNum, Axis].Step = 0;
                            }
                            else
                            {
                                InitTimeH[CardNum, Axis].InitialTime();
                                GoHome.AxisHome[CardNum, Axis].Step = 110;
                            }
                        }
                        break;

                    case 140:
                        GoHome.AxisHome[CardNum, Axis].Result = false;
                        GoHome.AxisHome[CardNum, Axis].State = false;
                        GoHome.AxisHome[CardNum, Axis].Step = 0;
                        break;

                    //*********************************************************************************************************************
                    case 150: //负极限和原点之间距离
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + homeToLimitFDist), vel);
                        GoHome.AxisHome[CardNum, Axis].Step = 160;
                        break;

                    case 160:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 20; //重新搜索原点
                        }
                        break;

                    //*********************************************************************************************************************
                    case 170: //offsetPos大于感应片的宽度
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) - offsetPos), vel);
                        GoHome.AxisHome[CardNum, Axis].Step = 180;
                        break;

                    case 180:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.AxisHome[CardNum, Axis].Step = 20; //重新搜索原点
                        }
                        break;

                    //*********************************************************************************************************************
                    case 200: //offsetPos大于感应片的宽度
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + offsetPos), vel);
                        GoHome.AxisHome[CardNum, Axis].Step = 201;
                        break;

                    case 201:
                        if (Gg.GetHomeDi(CardNum, Axis) == 0) //判断是否在原点上
                        {
                            Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + 1), vel);

                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Step = 210;
                        }
                        else
                        {
                            gts.GT_ClrSts(CardNum, Axis, (short)1);
                            gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                            if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false)
                            {
                                InitTimeH[CardNum, Axis].InitialTime();
                                GoHome.AxisHome[CardNum, Axis].Step = 140;
                            }
                        }
                        break;

                    case 210:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            InitTimeH[CardNum, Axis].InitialTime();
                            GoHome.AxisHome[CardNum, Axis].Step = 220;
                        }
                        break;

                    case (short)220:
                        if (InitTimeH[CardNum, Axis].TimeIsUp(200))
                        {
                            if (Gg.GetHomeDi(CardNum, Axis) == 1)
                            {
                                GoHome.AxisHome[CardNum, Axis].Step = 140;
                            }
                            else
                            {
                                GoHome.AxisHome[CardNum, Axis].Step = 20;
                            }
                        }
                        break;
                }
            }
        }



    }

}
