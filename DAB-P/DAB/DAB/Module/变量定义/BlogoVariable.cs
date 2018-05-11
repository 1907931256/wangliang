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
    sealed class BVar
        {
        #region DLL引用定义
        public const int EM_SETCUEBANNER = 0x1501;
        public static UMA_dll.FileRw FileRorW = new UMA_dll.FileRw();
        public static UMA_dll.LDPF SafeStart = new UMA_dll.LDPF();
        public static UMA_dll.LDPF InPutAir = new UMA_dll.LDPF();

        //定义轴报警 
        public static UMA_dll.LDPF EMC_Stop = new UMA_dll.LDPF(); //定义一个数组
        public static UMA_dll.LDPF RobotAlarm = new UMA_dll.LDPF(); //定义一个数组
        public static UMA_dll.LDPF EMC_Stop01 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF EMC_Stop02 = new UMA_dll.LDPF();
         
        public static UMA_dll.LDPF[] AxisAlarm; //定义一个数组
        public static UMA_dll.LDPF AxisAlarm00 = new UMA_dll.LDPF(); //定义一个没有实例化的变量
        public static UMA_dll.LDPF AxisAlarm01 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm02 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm03 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm04 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm05 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm06 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm07 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm08 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm09 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm10 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm11 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm12 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm13 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm14 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm15 = new UMA_dll.LDPF();
        public static UMA_dll.LDPF AxisAlarm16 = new UMA_dll.LDPF();

        #endregion

        //定义物料的行间距和列间距
        public const double DisRow = 31.5;//单位mm
        public const double DisCell = 31.5; 

        #region 工位数据传递变量
        public static bool ProductTakeOut = false;
        public static int OpenedVacumeNo = -1;
        public static int[] FixtureNum ={0,1,2,3,4};
        public static string[,] ProData = new string[10, 50];
        public static int[] TmpStep = new int[7];

        #endregion 

        public struct sBarCode 
            {
            public string sData; //条码枪数据  
            public bool GetCodeOK; //条码枪数据OK 
            }
        public static sBarCode BarCodeData; //条码枪结构体

        #region 数据初始化
        public static bool InitProData()
            {
            for (int i = 0; i <= 6; i++)
                {
                for (int j = 0; j <= 30; j++)
                    {
                    BVar.ProData[i, j] = "";
                    }
                }
            return true;
            }
        #endregion

        public enum 工位
            {
            机械手 = 1,
            料盘左供料 = 2,
            料盘右供料 = 3,
            PSA供料 = 4,
            保压 = 5,
            校正压力 = 6,
            流水线0 = 0,
            流水线1 = 7,
            流水线2 = 8,
            流水线3 = 9
            }

        public enum 测试
            { 
            相机1静态 = 1,
            相机1动态 = 2,
            相机2静态 = 3,
            相机2动态 = 4,
            相机3静态 = 5,
            相机3动态 = 6,
            相机4静态 = 7,
            相机4动态 = 8,
            取料标定 = 9,
            联合标定 = 10
            }
      
        public struct 料仓
            { 
            //public bool 是否换料; 
            //public int 左料盘数量;
            //public bool 料盘是否搬运;  
            }
         
        #region 运动轴重新命名
        /// <summary>
        /// 2站X轴
        /// </summary>
        /// <remarks></remarks>
        public const short S2_X = 1;
        /// <summary>
        /// 2站Y轴
        /// </summary>
        /// <remarks></remarks>
        public const short S2_Y = 2;
        /// <summary>
        /// 2站Z轴
        /// </summary>
        /// <remarks></remarks>
        public const short S2_Z = 3;
        /// <summary>
        /// 2站R轴
        /// </summary>
        /// <remarks></remarks>
        public const short S2_R = 4;
        /// <summary>
        /// 供料Z轴
        /// </summary>
        /// <remarks></remarks>
        public const short S2G_Z = 5;
        /// <summary>
        /// 供料Y轴
        /// </summary>
        /// <remarks></remarks>
        public const short S2G_Y = 6;
        /// <summary>
        /// 拉料Z
        /// </summary>
        /// <remarks></remarks>
        public const short S2L_Z = 7;
        /// <summary>
        /// 3站Z轴
        /// </summary>
        /// <remarks></remarks>
        public const short S3_Z = 8;
        /// <summary>
        /// 转盘R
        /// </summary>
        /// <remarks></remarks>
        public const short S0_R = 1;

        public static string[] Axisname = new string[] { "流水线1", "流水线2", "流水线3", "保压Z轴", "料仓左Z轴", "料仓右Z轴", "PSA Z轴", "PSA搬运Y轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴", "预留轴" };
        #endregion

        #region 异常统计
        /// <summary>
        /// 异常统计
        /// </summary>
        /// <param name="ErrInfo"></param>
        /// <remarks></remarks>
        public static void RecordErrInfo(string ErrInfo)
            {

            int ErrCounts = 0;

            switch (ErrInfo)
                {

                case "MEMErrCounts":
                    PVar.MEMErrCounts = int.Parse(BVar.FileRorW.ReadINI("ErrStatistics", ErrInfo, System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath));
                    PVar.MEMErrCounts++;
                    ErrCounts = PVar.MEMErrCounts;
                    BVar.FileRorW.WriteINI("ErrStatistics", ErrInfo, System.Convert.ToString(PVar.MEMErrCounts), PVar.BZ_ErrStatisticsPath);
                    if (FileRw.IsNotShow("Frm_Par"))
                        {
                        Frm_Par.fPar.txt_ErrCount3.Text = System.Convert.ToString(PVar.MEMErrCounts);
                        }
                    break;

                case "PickCCDErr":
                    PVar.PickCCDErrCounts = int.Parse(BVar.FileRorW.ReadINI("ErrStatistics", ErrInfo, System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath));
                    PVar.PickCCDErrCounts++;
                    ErrCounts = PVar.PickCCDErrCounts;
                    BVar.FileRorW.WriteINI("ErrStatistics", ErrInfo, System.Convert.ToString(PVar.PickCCDErrCounts), PVar.BZ_ErrStatisticsPath);
                    if (FileRw.IsNotShow("Frm_Par"))
                        {
                        Frm_Par.fPar.txt_ErrCount1.Text = System.Convert.ToString(PVar.PickCCDErrCounts);
                        }
                    break;
                case "PickErr":
                    PVar.PickErrCounts = int.Parse(BVar.FileRorW.ReadINI("ErrStatistics", ErrInfo, System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath));
                    PVar.PickErrCounts++;
                    ErrCounts = PVar.PickErrCounts;
                    BVar.FileRorW.WriteINI("ErrStatistics", "PickErr", System.Convert.ToString(PVar.PickErrCounts), PVar.BZ_ErrStatisticsPath);
                    if (FileRw.IsNotShow("Frm_Par"))
                        {
                        Frm_Par.fPar.txt_ErrCount2.Text = System.Convert.ToString(PVar.PickErrCounts);
                        }
                    break;
                case "HsgSnErr":
                    PVar.HsgSnErrCounts = int.Parse(BVar.FileRorW.ReadINI("ErrStatistics", ErrInfo, System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath));
                    PVar.HsgSnErrCounts++;
                    ErrCounts = PVar.HsgSnErrCounts;
                    BVar.FileRorW.WriteINI("ErrStatistics", ErrInfo, System.Convert.ToString(PVar.HsgSnErrCounts), PVar.BZ_ErrStatisticsPath);
                    if (FileRw.IsNotShow("Frm_Par"))
                        {
                        Frm_Par.fPar.txt_ErrCount9.Text = System.Convert.ToString(PVar.HsgSnErrCounts);
                        }
                    break;
                case "HsgErr":
                    PVar.HsgErrCounts = int.Parse(BVar.FileRorW.ReadINI("ErrStatistics", ErrInfo, System.Convert.ToString(0), PVar.BZ_ErrStatisticsPath));
                    PVar.HsgErrCounts++;
                    ErrCounts = PVar.HsgErrCounts;
                    BVar.FileRorW.WriteINI("ErrStatistics", ErrInfo, System.Convert.ToString(PVar.HsgErrCounts), PVar.BZ_ErrStatisticsPath);
                    if (FileRw.IsNotShow("Frm_Par"))
                        {
                        Frm_Par.fPar.txt_ErrCount9.Text = System.Convert.ToString(PVar.HsgErrCounts);
                        }
                    break;
                }

            BVar.FileRorW.WriteINI("ErrStatistics", ErrInfo, System.Convert.ToString(ErrCounts), PVar.BZ_ErrStatisticsPath);

            }

        #endregion

        }

    }
