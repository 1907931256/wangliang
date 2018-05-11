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
    class CCDTest
        {
        private static Tool.Delay InitTime = new Tool.Delay();
        private static int sRtn;
        private static string CCD_CMD;
        private static string Path; 
        public static event Action<string> AddList2;
        public static event Action<string> ShowList;
        public static event Action<string> ClearList2;

        private static int TestCount;
        private int sss;
        public static bool TestStop = false;

        public static void AutoRunTA(ref PVar.WorkType StaWork, String Name)
            {
             
            try 
                {
                switch (StaWork.Step)
                    {
                    case 10:
                        StaWork.Result = false;
                        StaWork.State = true;
                        ClearList2("");//清空list
                        TestCount = 1;
                        string fileFinalData = "E:\\BZ-Data\\DAB\\TestData\\" + DateTime.Now.ToString("yyyyMM") + "\\" + Name + DateTime.Now.ToString("yyyyMM") + ".csv";
                        Path = fileFinalData;
                        InitTime.InitialTime();
                        StaWork.Step = 20;
                        break;

                    case 20:
                        if (Name=="相机1静态") CCD_CMD = "Send: T11," + DateTime.Now.ToString("yyyyMMdd") + "0,0,0"; 
                        if (Name=="相机2静态") CCD_CMD = "Send: T21," + DateTime.Now.ToString("yyyyMMdd") + "0,0,0";
                        if (Name=="相机3静态") CCD_CMD = "Send: T31," + DateTime.Now.ToString("yyyyMMdd") + "0,0,0"; 
                        if (Name=="相机4静态") CCD_CMD = "Send: T41," + DateTime.Now.ToString("yyyyMMdd") + "0,0,0";
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("CCD命令  ->> " + CCD_CMD);
                        AddList2("静态测试拍照第" + TestCount + "次");
                        TestCount += 1;
                        InitTime.InitialTime();
                        StaWork.Step = 30;
                        //if (sRtn == 1) //命令发送成功
                        //    {
                        //    InitTime.InitialTime();
                        //    StaWork.Step = 30;
                        //    }
                        //else
                        //    {
                        //    AddList2("命令发送失败！");
                        //    ShowList("命令发送失败！");
                        //    InitTime.InitialTime();
                        //    StaWork.Step = 1000;
                        //    }
                        break;

                    case 30:
                        if (Command.CCD_Resule==false )
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            //时间，CCD判断值，X,Y,R
                            string TestData = Convert.ToString(DateAndTime.TimeOfDay.TimeOfDay) + "," + PVar.CCD_Data[1] + "," + PVar.CCD_Data[2] + "," + PVar.CCD_Data[3] + "," + PVar.CCD_Data[4];
                            BVar.FileRorW.WriteTestDataCsv(TestData, Path);
                            InitTime.InitialTime();
                            StaWork.Step = 35;
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

                    case 35:
                        if (InitTime.TimeIsUp(1000) )
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 40;
                            }
                        break;

                    case 40:
                        if (TestCount <= Convert.ToInt16(Frm_Engineering.fEngineering.TextBox_Num.Text))
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 20;
                            }
                        else
                            {
                            AddList2("测试完成！");
                            ShowList("测试完成！");
                            InitTime.InitialTime();
                            StaWork.Step = 800;
                            }
                        break;

                    case 800:
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 0;
                        break;

                    case 1000:
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

        public static void AutoRunTB(ref PVar.WorkType StaWork, String Name, String testpos)
            {  
            try
                {
                switch (StaWork.Step)
                    {
                    case 10:
                        StaWork.Result = false;
                        StaWork.State = true;
                        ClearList2("");//清空list
                        TestCount = 1;
                        string fileFinalData = "E:\\BZ-Data\\DAB\\TestData\\" + DateTime.Now.ToString("yyyyMM") + "\\" +Name + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                        Path = fileFinalData;
                        Gg.SetExDo(0, 0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                        InitTime.InitialTime();
                        StaWork.Step = 20;
                        break;

                    case 20:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                            {
                            Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴吸料位置], 20);
                            InitTime.InitialTime();
                            StaWork.Step = 30;
                            }                     
                        break;

                    case 30:
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", RobotPosName.待机位置, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 30;
                        break;

                    case 40:
                        if (EpsonRobot.sRobot_Status == "Step" + RobotPosName.待机位置)
                            {
                            AddList2("机械手回待机位置OK！");
                            InitTime.InitialTime();
                            StaWork.Step = 50;
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

                    case 50:
                        if (Frm_Engineering.fEngineering.Rbt_SendCmd("Step", testpos, "20", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "20") == false)
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        InitTime.InitialTime();
                        StaWork.Step = 60;
                        break;

                    case 60:
                        if (EpsonRobot.sRobot_Status == "Step" + testpos)
                            {
                            AddList2("机械手位置OK！");
                            InitTime.InitialTime();
                            StaWork.Step = 70;
                            }
                        else if (InitTime.TimeIsUp(6000))
                            {
                            AddList2("机械手运动超时！");
                            ShowList("机械手运动超时！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            return;
                            }
                        break;

                    case 70:
                        if (InitTime.TimeIsUp(500))//等待机械手停稳
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 80;
                            }
                        break;

                    case 80:
                        if (Name == "相机1动态") CCD_CMD = "Send: T11," + DateTime.Now.ToString("yyyyMMdd") + "0,0,0";
                        if (Name == "相机2动态") CCD_CMD = "Send: T21," + DateTime.Now.ToString("yyyyMMdd") + "0,0,0";
                        sRtn = Command.TCP_CCD_Send(CCD_CMD);
                        AddList2("CCD命令  ->> " + CCD_CMD);
                        AddList2("动态测试拍照第" + TestCount + "次");
                        TestCount += 1;
                        if (sRtn == 1) //命令发送成功
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 90;
                            }
                        else
                            {
                            AddList2("命令发送失败！");
                            ShowList("命令发送失败！");
                            InitTime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        break;

                    case 90:
                        if (Command.CCD_Resule)
                            {
                            AddList2("<<- Recevied:" + PVar.CCD_StrData);
                            //时间，CCD判断值，X,Y,R
                            string TestData = Convert.ToString(DateAndTime.TimeOfDay.TimeOfDay) + "," + PVar.CCD_Data[1] + "," + PVar.CCD_Data[2] + "," + PVar.CCD_Data[3] + "," + PVar.CCD_Data[4];
                            BVar.FileRorW.WriteTestDataCsv(TestData, Path);
                            InitTime.InitialTime();
                            StaWork.Step = 100; 
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

                    case 100:
                        if (TestCount <= Convert.ToInt16(Frm_Engineering.fEngineering.TextBox_Num.Text))
                            {
                            InitTime.InitialTime();
                            StaWork.Step = 30;
                            }
                        else
                            {
                            AddList2("测试完成！");
                            ShowList("测试完成！");
                            InitTime.InitialTime();
                            StaWork.Step = 800;
                            }
                        break;
                 
                    case 800:
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 0;
                        break;

                    case 1000:
                        AddList2("测试失败！");
                        ShowList("测试失败！");
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
