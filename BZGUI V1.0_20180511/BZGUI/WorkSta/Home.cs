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

namespace BZGUI
{
    public sealed class GoHome
    {
        public PVar.sFlag3 Reset;
        public PVar.HomeType[,] AxisHome = new PVar.HomeType[2, 9];
        public PVar.sFlag3 AxisGoHome;
        public int StepHome = 0;
        private static int InitTimeOut = 0;
        public event Action<string> ShowList;
        public event Action<string> AddList;

        private readonly static GoHome instance = new GoHome();

        /// <summary>
        /// 构造函数
        /// </summary>
        public GoHome()
        { }

        public static GoHome Instance
        {
            get { return instance; }
        }


        public void HomeSub()
        {
            switch (StepHome)
            {
                case 10:
                    Reset.State = true;
                    AddList("设备初始化开始，请等待！");
                    Gg.SetDo(0, Gg.OutPut0.载具真空吸1, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具真空吸2, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具真空吸3, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具真空吸4, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具破真空1, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具破真空2, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具破真空3, 0);
                    Gg.SetDo(0, Gg.OutPut0.载具破真空4, 0);

                    Gg.SetDo(0, Gg.OutPut0.保压站刹车继电器, 0);
                    Gg.SetDo(0, Gg.OutPut0.警示蜂鸣器, 0);
                    Gg.SetDo(0, Gg.OutPut0.装配站刹车继电器, 0);

                    Gg.SetDo(0, Gg.OutPut1.取料吸嘴破真空, 0);
                    Gg.SetDo(0, Gg.OutPut1.取料吸嘴真空吸, 0);

                    Gg.SetExDo(0, 0, Gg.OutPut2.NG蜂鸣器, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.NG指示灯, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.OK指示灯, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.保压升降气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.除底摸平移气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.除底膜吸嘴气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.复检气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.拉料无杆干气缸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.片料夹紧气缸右, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.片料夹紧气缸左, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.取底膜破真空, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.取底膜真空吸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.取片料破真空, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.取片料真空吸, 0);
                    Gg.SetExDo(0, 0, Gg.OutPut2.撕摸升降气缸, 0);

                    ////界面
                    Frm_Main.fMain.Btn_Stop.Enabled = false;
                    Frm_Main.fMain.Btn_Pause.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_ProgressBar.IsShowProgresBar(true);
                    InitTimeOut = API.GetTickCount();
                    StepHome = 20;
                    break;

                case 20:
                    Frm_ProgressBar.SetValueProgressBar(10);     //初始化进度条的进度更新显示
                    if (Gg.GetDi(0, Gg.InPut0.载具真空检测1) == 0 && Gg.GetDi(0, Gg.InPut0.载具真空检测2) == 0
                        && Gg.GetDi(0, Gg.InPut0.载具真空检测3) == 0 && Gg.GetDi(0, Gg.InPut0.载具真空检测4) == 0
                        && Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 0
                        //&& Gg.GetExDi(0, Gg.InPut2.复检气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.复检气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut2.保压升降气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.保压升降气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut2.除底摸平移气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.除底摸平移气缸伸出) == 0
                        && Gg.GetExDi(0, Gg.InPut2.除底膜吸嘴气缸缩回) == 1 && Gg.GetExDi(0, Gg.InPut2.除底膜吸嘴气缸伸出) == 0)
                    {
                        InitTimeOut = API.GetTickCount();
                        StepHome = 30;
                    }

                    if (API.GetTickCount() - InitTimeOut > 2000)
                    {
                        if (Gg.GetDi(0, Gg.InPut0.载具真空检测1) == 1)
                        {
                            AddList("1#载具真空检测1异常，请检查！");
                            ShowList("1#载具真空检测1异常，请检查！");
                        }
                        if (Gg.GetDi(0, Gg.InPut0.载具真空检测2) == 1)
                        {
                            AddList("2#载具真空检测2异常，请检查！");
                            ShowList("2#载具真空检测2异常，请检查！");
                        }
                        if (Gg.GetDi(0, Gg.InPut0.载具真空检测3) == 1)
                        {
                            AddList("3#载具真空检测3异常，请检查！");
                            ShowList("3#载具真空检测3异常，请检查！");
                        }
                        if (Gg.GetDi(0, Gg.InPut0.载具真空检测4) == 1)
                        {
                            AddList("4#载具真空检测3异常，请检查！");
                            ShowList("4#载具真空检测3异常，请检查！");
                        }
                        if (Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut2.撕摸升降气缸伸出) == 1)
                        {
                            AddList("撕摸升降气缸缩回信号异常，请检查！");
                            ShowList("撕摸升降气缸缩回信号异常，请检查！");
                        }

                        //if (Gg.GetExDi(0, Gg.InPut2.复检气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut2.复检气缸伸出) == 1)
                        //    {
                        //    AddList("复检气缸缩回信号异常，请检查！");
                        //    ShowList("复检气缸缩回信号异常，请检查！");
                        //    }

                        if (Gg.GetExDi(0, Gg.InPut2.保压升降气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut2.保压升降气缸伸出) == 1)
                        {
                            AddList("保压升降气缸缩回信号异常，请检查！");
                            ShowList("保压升降气缸缩回信号异常，请检查！");
                        }

                        if (Gg.GetExDi(0, Gg.InPut2.除底摸平移气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut2.除底摸平移气缸伸出) == 1)
                        {
                            AddList("除底摸平移气缸缩回信号异常，请检查！");
                            ShowList("除底摸平移气缸缩回信号异常，请检查！");
                        }

                        if (Gg.GetExDi(0, Gg.InPut2.除底膜吸嘴气缸缩回) == 0 || Gg.GetExDi(0, Gg.InPut2.除底膜吸嘴气缸伸出) == 1)
                        {
                            AddList("除底膜吸嘴气缸缩回信号异常，请检查！");
                            ShowList("除底膜吸嘴气缸缩回信号异常，请检查！");
                        }

                        StepHome = 1000;
                    }
                    break;

                case 30:
                    AddList("组装Z轴开始回原点…");
                    AddList("保压Z轴开始回原点…");
                    GoHome.Instance.AxisHome[0, 3].Result = false;
                    GoHome.Instance.AxisHome[0, 8].Result = false;
                    GoHome.Instance.AxisHome[0, 3].Enable = true;
                    GoHome.Instance.AxisHome[0, 8].Enable = true;
                    GoHome.Instance.AxisHome[0, 3].Step = 10;
                    GoHome.Instance.AxisHome[0, 8].Step = 10;
                    InitTimeOut = API.GetTickCount();
                    Frm_ProgressBar.SetValueProgressBar(30);
                    StepHome = 40;
                    break;

                case 40:
                    GotoHome(0, 3, 20, -1000, 10, 1, 10);
                    GotoHome(0, 8, 20, -1000, 10, 1, 10);
                    if (GoHome.Instance.AxisHome[0, 3].Step == 0 && GoHome.Instance.AxisHome[0, 3].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 3].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 3].Result)
                        {
                            AddList("组装Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("组装Z轴回原点失败！");
                            ShowList("组装Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 8].Step == 0 && GoHome.Instance.AxisHome[0, 8].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 8].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 8].Result)
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

                    if (GoHome.Instance.AxisHome[0, 3].Result && GoHome.Instance.AxisHome[0, 8].Result)
                    {
                        Frm_ProgressBar.SetValueProgressBar(50);
                        InitTimeOut = API.GetTickCount();
                        StepHome = 50;
                    }
                    break;

                case 50:
                    AddList("组装X轴开始回原点…");
                    AddList("组装Y轴开始回原点…");
                    AddList("组装R轴开始回原点…");
                    GoHome.Instance.AxisHome[0, 1].Result = false;
                    GoHome.Instance.AxisHome[0, 2].Result = false;
                    GoHome.Instance.AxisHome[0, 4].Result = false;
                    GoHome.Instance.AxisHome[0, 1].Enable = true;
                    GoHome.Instance.AxisHome[0, 2].Enable = true;
                    GoHome.Instance.AxisHome[0, 4].Enable = true;
                    GoHome.Instance.AxisHome[0, 1].Step = 10;
                    GoHome.Instance.AxisHome[0, 2].Step = 10;
                    GoHome.Instance.AxisHome[0, 4].Step = 10;
                    InitTimeOut = API.GetTickCount();
                    StepHome = 60;
                    break;

                case 60:
                    GotoHome(0, 1, 20, -1000, 10, 1, 10);
                    GotoHome(0, 2, 20, -1000, 10, 1, 10);
                    GotoHome(0, 4, 20, -1000, 10, 1, 10);

                    if (GoHome.Instance.AxisHome[0, 1].Step == 0 && GoHome.Instance.AxisHome[0, 1].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 1].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 1].Result)
                        {
                            AddList("组装X轴回原点成功！");
                        }
                        else
                        {
                            AddList("组装X轴回原点失败！");
                            ShowList("组装X轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 2].Step == 0 && GoHome.Instance.AxisHome[0, 2].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 2].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 2].Result)
                        {
                            AddList("组装Y轴回原点成功！");
                        }
                        else
                        {
                            AddList("组装Y轴回原点失败！");
                            ShowList("组装Y轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 4].Step == 0 && GoHome.Instance.AxisHome[0, 4].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 4].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 4].Result)
                        {
                            AddList("组装R轴回原点成功！");
                        }
                        else
                        {
                            AddList("组装R轴回原点失败！");
                            ShowList("组装R轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 1].Result && GoHome.Instance.AxisHome[0, 2].Result && GoHome.Instance.AxisHome[0, 4].Result)
                    {
                        Frm_ProgressBar.SetValueProgressBar(70);
                        InitTimeOut = API.GetTickCount();
                        StepHome = 70;
                    }
                    break;

                case 70:
                    AddList("上料Z轴开始回原点…");
                    AddList("平移Y轴开始回原点…");
                    AddList("拉料Z轴开始回原点…");
                    GoHome.Instance.AxisHome[0, 5].Result = false;
                    GoHome.Instance.AxisHome[0, 6].Result = false;
                    GoHome.Instance.AxisHome[0, 7].Result = false;
                    GoHome.Instance.AxisHome[0, 5].Enable = true;
                    GoHome.Instance.AxisHome[0, 6].Enable = true;
                    GoHome.Instance.AxisHome[0, 7].Enable = true;
                    GoHome.Instance.AxisHome[0, 5].Step = 10;
                    GoHome.Instance.AxisHome[0, 6].Step = 10;
                    GoHome.Instance.AxisHome[0, 7].Step = 10;
                    InitTimeOut = API.GetTickCount();
                    StepHome = 80;
                    break;

                case 80:
                    GotoHome(0, 5, 20, -1000, 10, 1, 10);
                    GotoHome(0, 6, 20, -1000, 10, 1, 30);
                    GotoHome(0, 7, 20, -1000, 10, 1, 10);

                    if (GoHome.Instance.AxisHome[0, 5].Step == 0 && GoHome.Instance.AxisHome[0, 5].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 5].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 5].Result)
                        {
                            AddList("上料Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("上料Z轴回原点失败！");
                            ShowList("上料Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 6].Step == 0 && GoHome.Instance.AxisHome[0, 6].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 6].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 6].Result)
                        {
                            AddList("平移Y轴回原点成功！");
                        }
                        else
                        {
                            AddList("平移Y轴回原点失败！");
                            ShowList("平移Y轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 7].Step == 0 && GoHome.Instance.AxisHome[0, 7].Enable)
                    {
                        GoHome.Instance.AxisHome[0, 7].Enable = false;
                        if (GoHome.Instance.AxisHome[0, 7].Result)
                        {
                            AddList("拉料Z轴回原点成功！");
                        }
                        else
                        {
                            AddList("拉料Z轴回原点失败！");
                            ShowList("拉料Z轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[0, 5].Result && GoHome.Instance.AxisHome[0, 6].Result && GoHome.Instance.AxisHome[0, 7].Result)
                    {
                        Frm_ProgressBar.SetValueProgressBar(80);
                        InitTimeOut = API.GetTickCount();
                        StepHome = 90;
                    }
                    break;

                case 90:
                    AddList("转盘R轴开始回原点…");
                    GoHome.Instance.AxisHome[1, 2].Result = false;
                    GoHome.Instance.AxisHome[1, 1].Enable = true;
                    GoHome.Instance.AxisHome[1, 1].Step = 10;
                    InitTimeOut = API.GetTickCount();
                    StepHome = 100;
                    break;

                case 100:
                    GotoHome(1, 1, 30, -360, 5, mFunction.Pos.TeachAxis1[2, 0], 30);

                    if (GoHome.Instance.AxisHome[1, 1].Step == 0 && GoHome.Instance.AxisHome[1, 1].Enable)
                    {
                        GoHome.Instance.AxisHome[1, 1].Enable = false;
                        if (GoHome.Instance.AxisHome[1, 1].Result)
                        {
                            AddList("转盘R轴回原点成功！");
                        }
                        else
                        {
                            AddList("转盘R轴回原点失败！");
                            ShowList("转盘R轴回原点失败！");
                            StepHome = 1000;
                        }
                    }

                    if (GoHome.Instance.AxisHome[1, 1].Result)
                    {
                        Frm_ProgressBar.SetValueProgressBar(90);
                        InitTimeOut = API.GetTickCount();
                        StepHome = 150;
                    }
                    break;

                case 150:
                    AddList("各轴开始回待机位置…");
                    //组装站
                    Gg.AbsMotion(0, 1, mFunction.Pos.TeachAxis1[0, 0], 20);
                    Gg.AbsMotion(0, 2, mFunction.Pos.TeachAxis2[0, 0], 20);
                    Gg.AbsMotion(0, 3, mFunction.Pos.TeachAxis3[0, 0], 20);
                    Gg.AbsMotion(0, 4, mFunction.Pos.TeachAxis4[0, 0], 20);

                    //保压站
                    Gg.AbsMotion(0, 8, mFunction.Pos.TeachAxis1[1, 0], 20);//保压初始位置
                    Tools.AxisTmplPos[1, 1] = 0;

                    //供料
                    Gg.AbsMotion(0, 5, mFunction.Pos.TeachAxis2[3, 4], 50);//供料起始位置
                    Gg.AbsMotion(0, 6, mFunction.Pos.TeachAxis1[3, 6], 100);//避让位置
                    Gg.AbsMotion(0, 7, mFunction.Pos.TeachAxis3[3, 7], 50);//换料位置

                    InitTimeOut = API.GetTickCount();
                    StepHome = 160;
                    break;

                case 160:
                    if (Gg.ZSPD(0, 1) && Gg.ZSPD(0, 2) && Gg.ZSPD(0, 3) && Gg.ZSPD(0, 4) && Gg.ZSPD(0, 5) && Gg.ZSPD(0, 6) && Gg.ZSPD(0, 7) && Gg.ZSPD(0, 8) && Gg.ZSPD(1, 1))
                    {
                        AddList("各轴回待机位置完成！");
                        InitTimeOut = API.GetTickCount();
                        StepHome = 170;
                    }
                    else
                    {
                        if ((API.GetTickCount() - InitTimeOut) > 10000)
                        {
                            if (Gg.ZSPD(0, 1) == false)
                            {
                                AddList("组装X轴回待机位置失败！");
                                ShowList("组装X轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 2) == false)
                            {
                                AddList("组装Y轴回待机位置失败！");
                                ShowList("组装Y轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 3) == false)
                            {
                                AddList("组装Z轴回待机位置失败！");
                                ShowList("组装Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 4) == false)
                            {
                                AddList("组装R轴回待机位置失败！");
                                ShowList("组装R轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 5) == false)
                            {
                                AddList("上料Z轴回待机位置失败！");
                                ShowList("上料Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 6) == false)
                            {
                                AddList("平移Y轴回待机位置失败！");
                                ShowList("平移Y轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 7) == false)
                            {
                                AddList("拉料Z轴回待机位置失败！");
                                ShowList("拉料Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(0, 8) == false)
                            {
                                AddList("保压Z轴回待机位置失败！");
                                ShowList("保压Z轴回待机位置失败！");
                            }
                            if (Gg.ZSPD(1, 1) == false)
                            {
                                AddList("转盘R轴回待机位置失败！");
                                ShowList("转盘R轴回待机位置失败！");
                            }

                            StepHome = 1000;
                        }
                    }
                    break;

                case 170:
                    if (API.GetTickCount() - InitTimeOut > 500)
                    {
                        //gts.GT_SetPrfPos(1, 1, 0); //规划器置零
                        //gts.GT_SetEncPos(1, 1, 0); //编码器置零                     
                        //gts.GT_SynchAxisPos(1, 1 << 0); //将当前轴进行位置同步
                        InitTimeOut = API.GetTickCount();
                        StepHome = 800;
                    }
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
                    Frm_Engineering.fEngineering.Btn_SelectMaterial.Enabled = true;

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
                    for (int i = 0; i <= 4; i++)
                    {
                        PVar.Sta_Work[i].State = false;
                        PVar.Sta_Work[i].Result = false;
                        PVar.Sta_Work[i].IsHaveHSG = false;
                        PVar.Sta_Work[i].Step = 0;
                    }
                    Mod_ErrorCode.CheckSystemTimeStep = 0;
                    GoHome.Instance.Reset.State = false;
                    GoHome.Instance.Reset.Result = true;
                    StepHome = 0;
                    break;

                case 1000:
                    PVar.LampStatus = 10;
                    PVar.MacHold = false;
                    PVar.Stop_Flag = true;
                    Frm_Engineering.fEngineering.Btn_SelectMaterial.Enabled = false;
                    //按钮初始化
                    Frm_Main.fMain.Btn_Start.Enabled = true;
                    Frm_Main.fMain.Btn_Pause.Enabled = false;
                    Frm_Main.fMain.Btn_Stop.Enabled = false;
                    Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;   //主页面初始化和自动运行按钮
                    Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                    Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_SelectedEndBtn;

                    Frm_Engineering.fEngineering.Home_Timer.Enabled = false;
                    Frm_ProgressBar.IsShowProgresBar(false);     //初始化进度条显示
                    GoHome.Instance.Reset.Result = false;
                    GoHome.Instance.Reset.State = false;
                    StepHome = 0;
                    break;
            }
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
            if (GoHome.Instance.AxisHome[CardNum, Axis].Step != 0)
            {
                GoHome.Instance.AxisHome[CardNum, Axis].State = true;
                switch (GoHome.Instance.AxisHome[CardNum, Axis].Step)
                {
                    case 10:
                        gts.GT_ClrSts(CardNum, Axis, (short)1); //清除报警
                        gts.GT_SetPrfPos(CardNum, Axis, 0); //规划器置零
                        gts.GT_SetEncPos(CardNum, Axis, 0); //编码器置零                     
                        gts.GT_SynchAxisPos(CardNum, 1 << (Axis - 1)); //将当前轴进行位置同步
                        GoHome.Instance.AxisHome[CardNum, Axis].Counter = 0; //回原点计数
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 20;
                        break;

                    case 20:
                        GoHome.Instance.AxisHome[CardNum, Axis].Capture = 0;
                        if (Gg.GetHomeDi(CardNum, Axis) == 0) //判断是否在原点上
                        {
                            if (GoHome.Instance.AxisHome[CardNum, Axis].Counter > 1)
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 140;
                            }
                            else
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].Counter = GoHome.Instance.AxisHome[CardNum, Axis].Counter + 1;
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 30; //开始搜索原点
                            }
                        }
                        else
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 200; //偏离原点，方向与搜索原点方向相反
                        }
                        break;

                    case 30:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第一次原点搜索
                        GoHome.Instance.AxisHome[CardNum, Axis].TempPos = 0;
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + searchHomeDist), vel); //启动运动，开始搜索原点
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 40;
                        break;

                    case 40:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        gts.GT_GetCaptureStatus(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].Capture, out GoHome.Instance.AxisHome[CardNum, Axis].TempPos, (short)1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
                        if (GoHome.Instance.AxisHome[CardNum, Axis].Capture == 1) //判断当前轴是否原点捕获触发
                        {
                            Gg.AxisStop(CardNum, Axis); //当前轴停止
                            GoHome.Instance.AxisHome[CardNum, Axis].Capture = 0;
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 50;
                        }
                        else if (Gg.GetLimitDi_Z(CardNum, Axis) == 1) //判断当前轴是否触发正极限
                        {
                            Gg.AxisStop(CardNum, Axis); //当前轴停止
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 170;
                        }
                        else if (Gg.GetLimitDi_F(CardNum, Axis) == 1) //判断当前轴是否触发负极限
                        {
                            Gg.AxisStop(CardNum, Axis); //当前轴停止
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 150;
                        }
                        else if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false) //判断当前轴规划器是否运动停止（原点搜索距离太小）
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 140;
                        }
                        break;

                    case 50:
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(GoHome.Instance.AxisHome[CardNum, Axis].TempPos / Gg.PlusPerUnit(CardNum, Axis)) / Tools.GeerRate[CardNum, Axis] + 1, 2);
                        //Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + offsetPos), 10); //启动运动，原点反向运动
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 60;
                        break;

                    case 60:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock); //获取当前轴的状态
                        if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false) //判断当前轴是否运动停止
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 70;
                        }
                        break;

                    case 70:
                        gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第二次原点搜索
                        //hRtn = gts.GT_SetCaptureMode(CardNum, Axis,gts. CAPTURE_INDEX);    //启动当前轴的Z相脉冲捕获
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) - offsetPos * 2), 1); //以1mm/s速度找原点
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 80; //跳转到下一步
                        break;

                    case 80:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock); //获取当前轴的状态
                        gts.GT_GetCaptureStatus(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].Capture, out GoHome.Instance.AxisHome[CardNum, Axis].TempPos, (short)1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
                        if (GoHome.Instance.AxisHome[CardNum, Axis].Capture == 1) //判断当前轴是否Z相脉冲捕获触发
                        {
                            Gg.AxisStop(CardNum, Axis); //当前轴停止
                            GoHome.Instance.AxisHome[CardNum, Axis].Capture = 0; //捕获触发标志清零
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 90;
                        }
                        else if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 140; //跳转到第110步（或脉冲未捕获，回原点结束，回原点失败）
                        }
                        break;

                    case 90:
                        if (homeoffset < 5)
                        {
                            Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(GoHome.Instance.AxisHome[CardNum, Axis].TempPos / Gg.PlusPerUnit(CardNum, Axis) / Tools.GeerRate[CardNum, Axis]) + homeoffset, 2);
                        }
                        else
                        {
                            Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(GoHome.Instance.AxisHome[CardNum, Axis].TempPos / Gg.PlusPerUnit(CardNum, Axis) / Tools.GeerRate[CardNum, Axis]) + homeoffset, 30);
                        }
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 100;
                        break;

                    case 100:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false) //判断当前轴是否运动停止
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].oldtime = API.GetTickCount();
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 110;
                        }
                        break;

                    case 110:
                        if (API.GetTickCount() - GoHome.Instance.AxisHome[CardNum, Axis].oldtime > 200)
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 120;
                        }
                        break;

                    case 120:
                        gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
                        gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
                        gts.GT_SynchAxisPos(CardNum, 1 << (Axis - 1)); //将当前轴进行位置同步
                        GoHome.Instance.AxisHome[CardNum, Axis].oldtime = API.GetTickCount();
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 130;
                        break;

                    case 130:
                        if (API.GetTickCount() - GoHome.Instance.AxisHome[CardNum, Axis].oldtime > 50)
                        {
                            if (Gg.GetEncPos(CardNum, Axis) == 0 && Gg.GetPrfPos(CardNum, Axis) == 0)
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].Result = true;
                                GoHome.Instance.AxisHome[CardNum, Axis].State = false;
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 0;
                            }
                            else
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].oldtime = API.GetTickCount();
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 110;
                            }
                        }
                        break;

                    case 140:
                        GoHome.Instance.AxisHome[CardNum, Axis].Result = false;
                        GoHome.Instance.AxisHome[CardNum, Axis].State = false;
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 0;
                        break;

                    //*********************************************************************************************************************
                    case 150: //负极限和原点之间距离
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + homeToLimitFDist), vel * 0.5);
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 160;
                        break;

                    case 160:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 20; //重新搜索原点
                        }
                        break;

                    //*********************************************************************************************************************
                    case 170: //offsetPos大于感应片的宽度
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) - offsetPos), vel);
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 180;
                        break;

                    case 180:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 20; //重新搜索原点
                        }
                        break;

                    //*********************************************************************************************************************
                    case 200: //offsetPos大于感应片的宽度
                        Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + offsetPos), vel);
                        GoHome.Instance.AxisHome[CardNum, Axis].Step = 201;
                        break;

                    case 201:
                        if (Gg.GetHomeDi(CardNum, Axis) == 0) //判断是否在原点上
                        {
                            Gg.AbsMotion(CardNum, Axis, System.Convert.ToDouble(Gg.GetPrfPosmm(CardNum, Axis) + 1), vel);
                            GoHome.Instance.AxisHome[CardNum, Axis].oldtime = API.GetTickCount();
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 210;
                        }
                        else
                        {
                            gts.GT_ClrSts(CardNum, Axis, (short)1);
                            gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                            if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false)
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].oldtime = API.GetTickCount();
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 140;
                            }
                        }
                        break;

                    case 210:
                        gts.GT_ClrSts(CardNum, Axis, (short)1);
                        gts.GT_GetSts(CardNum, Axis, out GoHome.Instance.AxisHome[CardNum, Axis].status, (short)1, out temp_pClock);
                        if (System.Convert.ToBoolean(GoHome.Instance.AxisHome[CardNum, Axis].status & 0x400) == false)
                        {
                            GoHome.Instance.AxisHome[CardNum, Axis].oldtime = API.GetTickCount();
                            GoHome.Instance.AxisHome[CardNum, Axis].Step = 220;
                        }
                        break;

                    case (short)220:
                        if (API.GetTickCount() - GoHome.Instance.AxisHome[CardNum, Axis].oldtime > 200)
                        {
                            if (Gg.GetHomeDi(CardNum, Axis) == 1)
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 140;
                            }
                            else
                            {
                                GoHome.Instance.AxisHome[CardNum, Axis].Step = 20;
                            }
                        }
                        break;
                }
            }
        }



    }

}
