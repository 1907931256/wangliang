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
using System;
using System.Text;

namespace DAB
    {
    class Calibration
        {
        private static int sRtn;
        private static Tool.Delay InitTime = new Tool.Delay();
        private static string CCD_CMD;
        public static event Action<string> AddList2;
        public static event Action<string> ShowList;
        public static event Action<string> ClearList2;

        private static double CalibOffsetX;
        private static double CalibOffsetY;
        private static double CalibOffsetR;
        private static int CalibCount;

        public static void cAutoRun(ref PVar.WorkType StaWork)
            {
            try
                {
                switch (StaWork.Step)
                    {
                    case 10:
                        StaWork.Result = false;
                        StaWork.State = true;
                        ClearList2("");//清空list
                        CalibCount = 0;

                        CCD_CMD = "SC,1,11"; //标定开始命令
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("取料CCD开始标定  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 20;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 20:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "SC")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            StaWork.Step = 30;
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 30:
                        AddList2("机械手回带位置开始！");
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 40;
                        break;

                    case 40:
                        if (EpsonRobot.sRobot_Status == "Step" + RobotPosName.待机位置)
                            {
                            AddList2("机械手回待机位置OK！");
                            InitTime.InitialTime();
                            StaWork.Step = 45;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手回待机位置超时！");
                            ShowList("机械手回待机位置超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;

                    case 45:
                        if (InitTime.TimeIsUp(500))//等待机械手停稳
                            {
                            CalibCount += 1;
                            InitTime.InitialTime();
                            StaWork.Step = 50;
                            }
                        break;

                    case 50:
                        AddList2("标定第" + CalibCount + "拍照");
                        CCD_CMD = "C1" + "," + EpsonRobot.RobotLivePos.X + "," + EpsonRobot.RobotLivePos.Y + "," + EpsonRobot.RobotLivePos.U;;//第一个点
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("标定命令  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 60;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 60:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "C1")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            if (CalibCount < 12)
                                {
                                InitTime.InitialTime();
                                StaWork.Step = 70; //11点标定继续
                                }
                            else
                                {
                                InitTime.InitialTime();
                                StaWork.Step = 100;//11点标定结束
                                }

                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 70:
                        switch (CalibCount)
                            {
                            case 2:
                            case 3:
                                CalibOffsetX = -2;
                                CalibOffsetY = 0;
                                CalibOffsetR = 0;
                                break;
                            case 4:
                            case 5:
                                CalibOffsetX = 0;
                                CalibOffsetY = 2;
                                CalibOffsetR = 0;
                                break;
                            case 6:
                            case 7:
                                CalibOffsetX = 2;
                                CalibOffsetY = 0;
                                CalibOffsetR = 0;
                                break;
                            case 8:
                                CalibOffsetX = 0;
                                CalibOffsetY = -2;
                                CalibOffsetR = 0;
                                break;
                            case 9:
                                CalibOffsetX = -2;
                                CalibOffsetY = 0;
                                CalibOffsetR = 0;
                                break;
                            case 10:
                                CalibOffsetX = 0;
                                CalibOffsetY = 0;
                                CalibOffsetR = -5;
                                break;
                            case 11:
                                CalibOffsetX = 0;
                                CalibOffsetY = 0;
                                CalibOffsetR = 10;
                                break;
                            }

                        AddList2("->>机械手 X:" + CalibOffsetX + ", Y:" + CalibOffsetY + ", R:" + CalibOffsetR);
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Move", "0", "5", CalibOffsetX.ToString(), CalibOffsetY.ToString(), "0", CalibOffsetR.ToString(), "0", "X", "0", "0", "0", "0", "5") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 80;
                        break;

                    case 80:
                        if (EpsonRobot.sRobot_Status == "Move")
                            {
                            AddList2("<<-机械手" + EpsonRobot.Robot_StrData);
                            InitTime.InitialTime();
                            StaWork.Step = 45;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手回待机位置超时！");
                            ShowList("机械手回待机位置超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;



                    case 100:
                        CCD_CMD = "EC";//第一个点
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("标定命令  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 110;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 110:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "EC")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            InitTime.InitialTime();
                            StaWork.Step = 800;
                            AddList2("标定结束！");
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 800:
                        AddList2("标定成功！");
                        ShowList("标定成功！");
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 0;
                        break;

                    case 1000:
                        AddList2("标定失败！");
                        ShowList("标定失败！");
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 0;
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

        public static void aAutoRun(ref PVar.WorkType StaWork)
            {
            try
                {
                switch (StaWork.Step)
                    {
                    case 10:
                        StaWork.Result = false;
                        StaWork.State = true;
                        ClearList2("");//清空list
                        CalibCount = 0;

                        CCD_CMD = "SC,2,11,3,1,4,1"; //标定开始命令
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("联合开始标定  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 20;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 20:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "SC")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            StaWork.Step = 30;
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 30:
                        AddList2("机械手回待机位置开始！");
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 32;
                        break;

                    case 32:
                        if (EpsonRobot.sRobot_Status == "Step" + RobotPosName.待机位置)
                            {
                            AddList2("机械手回待机位置OK！");
                            InitTime.InitialTime();
                            StaWork.Step = 34;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手回待机位置超时！");
                            ShowList("机械手回待机位置超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;

                    case 34:
                        AddList2("机械手回PSA定位拍照位置开始！");
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.PSA定位拍照位置, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 36;
                        break;

                    case 36:
                        if (EpsonRobot.sRobot_Status == "Step" + RobotPosName.PSA定位拍照位置)
                            {
                            AddList2("机械手回待机位置OK！");
                            InitTime.InitialTime();
                            StaWork.Step = 45;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手PSA定位拍照位置超时！");
                            ShowList("机械手PSA定位拍照位置超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;

                    case 45:
                        if (InitTime.TimeIsUp(500))//等待机械手停稳
                            {
                            CalibCount += 1;
                            InitTime.InitialTime();
                            StaWork.Step = 50;
                            }
                        break;

                    case 50:
                        AddList2("标定第" + CalibCount + "拍照");
                        CCD_CMD = "C2" + "," + EpsonRobot.RobotLivePos.X + "," + EpsonRobot.RobotLivePos.Y + "," + EpsonRobot.RobotLivePos.U;;//第一个点
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("标定命令  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 60;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 60:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "C2")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            if (CalibCount < 12)
                                {
                                InitTime.InitialTime();
                                StaWork.Step = 70; //11点标定继续
                                }
                            else
                                {
                                InitTime.InitialTime();
                                StaWork.Step = 100;//11点标定结束
                                }
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 70:
                        switch (CalibCount)
                            {
                            case 2:
                            case 3:
                                CalibOffsetX = -2;
                                CalibOffsetY = 0;
                                CalibOffsetR = 0;
                                break;
                            case 4:
                            case 5:
                                CalibOffsetX = 0;
                                CalibOffsetY = 2;
                                CalibOffsetR = 0;
                                break;
                            case 6:
                            case 7:
                                CalibOffsetX = 2;
                                CalibOffsetY = 0;
                                CalibOffsetR = 0;
                                break;
                            case 8:
                                CalibOffsetX = 0;
                                CalibOffsetY = -2;
                                CalibOffsetR = 0;
                                break;
                            case 9:
                                CalibOffsetX = -2;
                                CalibOffsetY = 0;
                                CalibOffsetR = 0;
                                break;
                            case 10:
                                CalibOffsetX = 0;
                                CalibOffsetY = 0;
                                CalibOffsetR = -5;
                                break;
                            case 11:
                                CalibOffsetX = 0;
                                CalibOffsetY = 0;
                                CalibOffsetR = 10;
                                break;
                            }

                        AddList2("->>机械手 X:" + CalibOffsetX + ", Y:" + CalibOffsetY + ", R:" + CalibOffsetR);
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Move", "0", "5", CalibOffsetX.ToString(), CalibOffsetY.ToString(), "0", CalibOffsetR.ToString(), "0", "X", "0", "0", "0", "0", "5") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 80;
                        break;

                    case 80:
                        if (EpsonRobot.sRobot_Status == "Move")
                            {
                            AddList2("<<-机械手" + EpsonRobot.Robot_StrData);
                            InitTime.InitialTime();
                            StaWork.Step = 45;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手回待机位置超时！");
                            ShowList("机械手回待机位置超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;

                    case 100:
                        AddList2("机械手回预贴PSA位置开始！");
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.预贴PSA位置, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 110;
                        break;

                    case 110:
                        if (EpsonRobot.sRobot_Status == "Step" + RobotPosName.预贴PSA位置)
                            {
                            AddList2("机械手回预贴PSA位置OK！");
                            InitTime.InitialTime();
                            StaWork.Step = 120;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手PSA定位拍照位置超时！");
                            ShowList("机械手PSA定位拍照位置超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;

                    case 120:
                        if (InitTime.TimeIsUp(500))//等待机械手停稳
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 130;
                            }
                        break;

                    case 130:
                        CCD_CMD = "C3" + "," + EpsonRobot.RobotLivePos.X + "," + EpsonRobot.RobotLivePos.Y + "," + EpsonRobot.RobotLivePos.U;;//第一个点
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("标定命令  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 140;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 140:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "C3")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            InitTime.InitialTime();
                            StaWork.Step = 170;
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 170:
                        CCD_CMD = "C4" + "," + EpsonRobot.Robot_Fcs[2] + "," + EpsonRobot.Robot_Fcs[3] + "," + EpsonRobot.Robot_Fcs[5];//第一个点
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("标定命令  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 180;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 180:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "C4")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            InitTime.InitialTime();
                            StaWork.Step = 200;
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 200:
                        CCD_CMD = "EC";//第一个点
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("标定命令  ->> " + CCD_CMD);

                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 210;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 210:
                        if (Command.CCD_Resule && PVar.CCD_Data[0] == "EC")
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            InitTime.InitialTime();
                            InitTime.InitialTime();
                            StaWork.Step = 800;
                            AddList2("标定结束！");
                            }
                        else
                            {
                            if (InitTime.TimeIsUp(5000))
                                {
                                AddList2("等待CCD数据超时！");
                                ShowList("等待CCD数据超时！");
                                InitTime.InitialTime();
                                StaWork.Step = 1000;
                                }
                            }
                        break;

                    case 800:
                        AddList2("标定成功！");
                        ShowList("标定成功！");
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 0;
                        break;

                    case 1000:
                        AddList2("标定失败！");
                        ShowList("标定失败！");
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 0;
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
                AddList2("标定失败！");
                ShowList("标定失败！");
                StaWork.Result = false;
                StaWork.State = false;
                StaWork.Step = 0;
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
