using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using AxMSScriptControl;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using BZ.UI;
using CalNormDistLabrary;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.ComponentModel;
using System.Text;

namespace BZGUI
{
    public partial class Frm_Production
    {
        public static Frm_Production fProduction = null;
        private static object LockDraw = new object();

        internal System.Timers.Timer Chart_Time = new System.Timers.Timer() { AutoReset = true, Interval = 100, Enabled = false };
        public Frm_Production()
        {
            InitializeComponent();
            fProduction = this;
        }

        #region Cpk相关变量
        private double[] defaultData = new double[32];
        double[] gaussiData_X = new double[] { };
        double[] gaussiData_Y = new double[] { };
        double[] densityData_X = new double[] { };
        double[] densityData_Y = new double[] { };

        #endregion

        private void Frm_Production_FormClosed(object sender, FormClosedEventArgs e)
        {
            PVar.IsOpenFrmProduction = false;
        }

        private void Frm_Production_Load(object sender, EventArgs e)
        {
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.fMain.Main_Color;
            this.AlarmStatus.BZ_ShowMode = true;
            this.AlarmStatus.ForeColor = Color.Black;
            this.AlarmStatus.BZ_Color = PVar.BZColor_SelectedBtn;
            this.AlarmStatus.Text = "No Alarm";
            this.AlarmTime.ForeColor = Color.Black;
            this.AlarmTime.BZ_Color = PVar.BZColor_SelectedBtn;
            this.AlarmTime.BZ_SmallText = "Alarm Time";
            this.AlarmTime.BZ_BigText = "00:16:58";
            this.UPH.ForeColor = Color.Black;
            this.UPH.BZ_Color = Color.FromArgb(253, 253, 191);
            this.UPH.BZ_SmallText = "UPH";
            this.UPH.BZ_BigText = "230";
            this.MaterialLevel.ForeColor = Color.Black;
            this.MaterialLevel.BZ_Color = PVar.BZColor_SelectedBtn;
            this.MaterialLevel.BZ_SmallText = "Material";
            this.MaterialLevel.BZ_BigText = "High";

            Lbl_StartTime.Text = System.Convert.ToString(DateAndTime.DateAdd("d", 0, DateTime.Now).ToString("MM/dd/yy"));
            Lbl_EndTime.Text = System.Convert.ToString(DateAndTime.DateAdd("d", -29, DateTime.Now).ToString("MM/dd/yy"));
            int SelectNum;
            if (FileRw.IniGetNValue(PVar.UIChartCurveName, "CurveData", "TotalNum", 0) == 49)
            {
                SelectNum = 49;
            }
            else
            {
                SelectNum = (int)(FileRw.IniGetNValue(PVar.UIChartCurveName, "CurveData", "CurrentNum", 0));
            }

            Force_S3.BZ_BackColor = PVar.BZColor_SelectedBtn;
            Force_S2.BZ_BackColor = Color.LightGray;

            BTN_X.BZ_BackColor = PVar.BZColor_SelectedBtn;
            BTN_Y.BZ_BackColor = Color.LightGray;
            BTN_CC.BZ_BackColor = Color.LightGray;
            BTN_A.BZ_BackColor = Color.LightGray;
            Cpk_X.BZ_BackColor = PVar.BZColor_SelectedBtn;
            Cpk_Y.BZ_BackColor = Color.LightGray;
            Cpk_CC.BZ_BackColor = Color.LightGray;
            Cpk_A.BZ_BackColor = Color.LightGray;
            Btn_Yield_Click(sender, e); //显示Retest和NG率

            UPH.BZ_BigText = System.Convert.ToString(CalculateUPH());

            BTN_X_Click(BTN_X, e);
            Cpk_X_Click(Cpk_X, e);
            LoadYield();
            Frm_Engineering.fEngineering.SetChart(chartForce);
            this.Chart_Time.Elapsed += new System.Timers.ElapsedEventHandler(this.Chart_Time_Elapsed);
            Chart_Time.Enabled = true;
        }
        private void Chart_Time_Elapsed(object sender, EventArgs e)
        {
            lock (LockDraw)
                try
                {
                    this.BeginInvoke(new Action(() => { Frm_Engineering.fEngineering.Update_DataChart(); }));
                }
                catch (Exception)
                {

                }
        }
        #region 加载CPK数据
        public static void ReadCPKFile(string Filename, PVar.CPKData ReadData)
        {
            PVar.tmpCpkData.X = new double[101];
            PVar.tmpCpkData.Y = new double[101];
            PVar.tmpCpkData.A = new double[101];
            PVar.tmpCpkData.CC = new double[101];
            PVar.tmpCpkData.ProTime = new DateTime[501];
            PVar.Press = new double[150];
            for (int i = 0; i < 150; i++)
            {
                PVar.Press[i] = 0;
            }
            try
            {
                if (System.IO.File.Exists(Filename) == false)
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        PVar.tmpCpkData.X[i] = 0;
                        PVar.tmpCpkData.Y[i] = 0;
                        PVar.tmpCpkData.A[i] = 0;
                        PVar.tmpCpkData.CC[i] = 0;
                    }
                    for (int i = 0; i <= 500; i++)
                    {
                        PVar.tmpCpkData.ProTime[i] = DateAndTime.DateAdd("h", -1, DateTime.Now);
                    }
                    WriteCpkData(Filename, PVar.tmpCpkData);
                }
                ReadCpkData(Filename, PVar.tmpCpkData);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("CPK文件读取失败：" + ex.Message, (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误"); //写入完成关闭当前打开的文件
            }
        }

        private static void ReadCpkData(string FileName, System.ValueType ReadData)
        {
            int Filenumber = 0;
            try
            {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                //long lens = FileSystem.LOF(Filenumber);
                FileSystem.FileGet(Filenumber, ref ReadData);
                PVar.tmpCpkData = (PVar.CPKData)ReadData;
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
            catch (Exception)
            {
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
        }

        private static void WriteCpkData(string FileName, System.ValueType WriteData)
        {
            int Filenumber = 0;
            try
            {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                //long lens = FileSystem.LOF(Filenumber);
                FileSystem.FilePut(Filenumber, WriteData);
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
            catch
            {
                FileSystem.FileClose(Filenumber); //写入出错关闭当前打开的文件
            }
        }

        /// <summary>
        /// 数据交换
        /// </summary>
        /// <remarks></remarks>
        public static void ExchangeCpkData()
        {
            for (var i = 100; i >= 1; i--)
            {
                PVar.tmpCpkData.X[i] = PVar.tmpCpkData.X[i - 1];
                PVar.tmpCpkData.Y[i] = PVar.tmpCpkData.Y[i - 1];
                PVar.tmpCpkData.A[i] = PVar.tmpCpkData.A[i - 1];
                PVar.tmpCpkData.CC[i] = PVar.tmpCpkData.CC[i - 1];
            }

            for (var i = 500; i >= 1; i--)
            {
                PVar.tmpCpkData.ProTime[i] = PVar.tmpCpkData.ProTime[i - 1];
            }
        }

        public static void ExchangePressData()
        {
            for (var i = 150; i >= 1; i--)
            {
                PVar.Press[i] = PVar.Press[i - 1];
            }
        }
        #endregion

        #region 计算UPH

        public int CalculateUPH()
        {
            DateTime ProductDate = default(DateTime);
            DateTime DateBeforeOneHour = default(DateTime);
            int UphCounts = 0;
            DateBeforeOneHour = DateAndTime.DateAdd("h", -1, DateTime.Now);
            for (int i = 0; i <= 500; i++)
            {
                ProductDate = PVar.tmpCpkData.ProTime[i];
                if (DateTime.Compare(ProductDate, DateBeforeOneHour) == 1)
                {
                    UphCounts++;
                }
            }
            if (UphCounts < 100)
            {
                this.UPH.BZ_Color = Color.FromArgb(253, 253, 191);
            }
            else
            {
                this.UPH.BZ_Color = PVar.BZColor_SelectedBtn;
            }

            return UphCounts;
        }

        #endregion

        #region 计算良率
        public void LoadYield()
        {
            PVar.NgCountOfDay = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "NgCountOfDay", System.Convert.ToString(0), PVar.BZ_YieldDataFileName)); //当天NG数量
            PVar.NgCountOfMonth = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "NgCountOfMonth", System.Convert.ToString(0), PVar.BZ_YieldDataFileName)); //当月NG数量
            PVar.ProductCountOfDay = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "ProductCountOfDay", System.Convert.ToString(0), PVar.BZ_YieldDataFileName)); //当天总数量
            PVar.ProductCountOfMonth = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "ProductCountOfMonth", System.Convert.ToString(0), PVar.BZ_YieldDataFileName)); //当月总数量
            PVar.RecordTimeOfDate = BVar.FileRorW.ReadINI("ProductTime", "RecordTimeOfDate", System.Convert.ToString(DateAndTime.DateAdd("d", -30, DateTime.Now).ToString("yyyyMMdd")), PVar.BZ_YieldDataFileName); //系统现在时间
            PVar.RecordTimeOfMonth = BVar.FileRorW.ReadINI("ProductTime", "RecordTimeOfMonth", DateTime.Now.ToString("yyyyMMdd"), PVar.BZ_YieldDataFileName); //系统开始记录日期

            PVar.DayYieldOfNg = System.Convert.ToDouble(PVar.ProductCountOfDay == 0 ? 0 : (((double)PVar.NgCountOfDay / PVar.ProductCountOfDay) * 100));
            this.DRB_YieldRetest.BZ_NgRateDay = (int)PVar.DayYieldOfNg; //日Ng率
            PVar.MonthYieldOfNg = System.Convert.ToDouble(PVar.ProductCountOfMonth == 0 ? 0 : (((double)PVar.NgCountOfMonth / PVar.ProductCountOfMonth) * 100));
            this.DRB_YieldRetest.BZ_NgRateMonth = (int)PVar.MonthYieldOfNg; //月Ng率
            this.Lbl_StartTime.Text = System.Convert.ToString(DateAndTime.DateAdd("d", -30, DateTime.Now).ToString("MM/dd/yy")); //开始日期为当前往前30天
            this.Lbl_EndTime.Text = DateTime.Now.ToString("MM/dd/yy"); //结束日期为当前日期
        }

        /// <summary>
        /// 更新生产数据
        /// </summary>
        /// <remarks></remarks>
        public void CalculateYield()
        {
            string TimeNowDate = "";
            string TimeBeforeMonth = "";
            TimeNowDate = DateTime.Now.ToString("yyyyMMdd");
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            TimeBeforeMonth = System.Convert.ToString(dt.AddDays(-30).ToString("yyyyMMdd"));
            PVar.NgCountOfDay = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "NgCountOfDay", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
            PVar.NgCountOfMonth = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "NgCountOfMonth", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
            PVar.ProductCountOfDay = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "ProductCountOfDay", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
            PVar.ProductCountOfMonth = int.Parse(BVar.FileRorW.ReadINI("ProductCount", "ProductCountOfMonth", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
            PVar.RecordTimeOfDate = BVar.FileRorW.ReadINI("ProductTime", "RecordTimeOfDate", TimeBeforeMonth, PVar.BZ_YieldDataFileName);
            PVar.RecordTimeOfMonth = BVar.FileRorW.ReadINI("ProductTime", "RecordTimeOfMonth", TimeNowDate, PVar.BZ_YieldDataFileName);

            FileRw.ReadYieldFile(PVar.BZ_YieldMonthDataFileName, PVar.YieldOfMonth);

            //**************************************记录当天日良率********************************************************
            if (double.Parse(TimeNowDate) - double.Parse(PVar.RecordTimeOfDate) == 0) //当前日期与记录日期相同
            {
                PVar.ProductCountOfDay++;
                PVar.NgCountOfDay = (BVar.ProData[4, 28] == "OK") ? PVar.NgCountOfDay : PVar.NgCountOfDay + 1;
                PVar.YieldOfMonth.NgCount[0] = PVar.NgCountOfDay; //更新最新一天的产量
                PVar.YieldOfMonth.ProductCount[0] = PVar.ProductCountOfDay;
                PVar.YieldOfMonth.RecordTime[0] = DateTime.Now;
            }
            else
            {
                PVar.ProductCountOfDay = 1;
                PVar.NgCountOfDay = (BVar.ProData[4, 28] == "OK") ? 0 : 1;
                ExchangeYieldData(); //30天产量统计数据交换，ExchangeYieldData(0)为最新一天的产量，ExchangeYieldData(29)为30天前的产量
                PVar.YieldOfMonth.NgCount[0] = PVar.NgCountOfDay; //更新最新一天的产量
                PVar.YieldOfMonth.ProductCount[0] = PVar.ProductCountOfDay;
                PVar.YieldOfMonth.RecordTime[0] = DateTime.Now;
            }

            FileRw.WriteYieldFile(PVar.BZ_YieldMonthDataFileName, PVar.YieldOfMonth);
            BVar.FileRorW.WriteINI("ProductCount", "ProductCountOfDay", System.Convert.ToString(PVar.ProductCountOfDay), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("ProductCount", "NgCountOfDay", System.Convert.ToString(PVar.NgCountOfDay), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("ProductTime", "RecordTimeOfDate", TimeBeforeMonth, PVar.BZ_YieldDataFileName); //更新以当前向后推30天的日期
            PVar.DayYieldOfNg = Math.Round(System.Convert.ToDouble(((double)PVar.NgCountOfDay / PVar.ProductCountOfDay) * 100), 1);
            this.DRB_YieldRetest.BZ_NgRateDay = (int)PVar.DayYieldOfNg; //日Ng率

            //**************************************记录当月良率********************************************************
            if (double.Parse(TimeBeforeMonth) - double.Parse(PVar.RecordTimeOfMonth) <= 0) //当前时间减30天小于记录的一个月后时间
            {
                PVar.ProductCountOfMonth++;
                PVar.NgCountOfMonth = (BVar.ProData[4, 28] == "OK") ? PVar.NgCountOfMonth : PVar.NgCountOfMonth + 1;
                this.Lbl_StartTime.Text = System.Convert.ToString(dt.AddDays(-30).ToString("MM/dd/yy"));
                this.Lbl_EndTime.Text = DateTime.Now.ToString("MM/dd/yy"); //结束日期为当前日期
            }
            else
            {
                PVar.ProductCountOfMonth = PVar.ProductCountOfMonth - PVar.YieldOfMonth.ProductCount[29] + 1; //更新月产量，总数减去30天前的产量
                PVar.NgCountOfMonth = (BVar.ProData[4, 28] == "OK") ? (PVar.NgCountOfMonth - PVar.YieldOfMonth.NgCount[29]) : (PVar.NgCountOfMonth - PVar.YieldOfMonth.NgCount[29] + 1); //更新月NG数量，总数减去30天前的产量
                BVar.FileRorW.WriteINI("ProductTime", "RecordTimeOfMonth", DateTime.Now.ToString("yyyyMMdd"), PVar.BZ_YieldDataFileName); //更新月良率记录时间
                //Frm_Production.Lbl_StartTime.Text = YieldOfMonth.RecordTime(29).ToString("yyyyMMdd")   '开始日期为当前往前30天
                this.Lbl_StartTime.Text = System.Convert.ToString(dt.AddDays(-30).ToString("MM/dd/yy")); //开始日期为当前往前30天
                this.Lbl_EndTime.Text = DateTime.Now.ToString("MM/dd/yy"); //结束日期为当前日期
            }

            BVar.FileRorW.WriteINI("ProductCount", "ProductCountOfMonth", System.Convert.ToString(PVar.ProductCountOfMonth), PVar.BZ_YieldDataFileName);
            BVar.FileRorW.WriteINI("ProductCount", "NgCountOfMonth", System.Convert.ToString(PVar.NgCountOfMonth), PVar.BZ_YieldDataFileName);

            PVar.MonthYieldOfNg = Math.Round(System.Convert.ToDouble(((double)PVar.NgCountOfMonth / PVar.ProductCountOfMonth) * 100), 1);
            this.DRB_YieldRetest.BZ_NgRateMonth = (int)PVar.MonthYieldOfNg; //月Ng率

        }

        public static void ExchangeYieldData()
        {
            for (var i = 29; i >= 1; i--)
            {
                PVar.YieldOfMonth.NgCount[(int)i] = PVar.YieldOfMonth.NgCount[i - 1];
                PVar.YieldOfMonth.ProductCount[(int)i] = PVar.YieldOfMonth.ProductCount[i - 1];
                PVar.YieldOfMonth.RecordTime[(int)i] = PVar.YieldOfMonth.RecordTime[i - 1];
            }
        }
        #endregion

        #region 功能:良率重测率显示
        private void Btn_Yield_Click(object sender, EventArgs e)
        {
            LoadYield();
            PVar.strUserSelYieldOrRetest = "Yield";
            this.Btn_Yield.BZ_BackColor = PVar.BZColor_SelectedBtn;
            this.Btn_Retest.BZ_BackColor = Color.LightGray;
        }
        private void Btn_Retest_Click(object sender, EventArgs e)
        {
            DRB_YieldRetest.BZ_NgRateDay = 0; //日Ng率
            DRB_YieldRetest.BZ_NgRateMonth = 0;
            DRB_YieldRetest.BZ_ResultText = "OK";
            this.Btn_Yield.BZ_BackColor = Color.LightGray;
            this.Btn_Retest.BZ_BackColor = PVar.BZColor_SelectedBtn;
        }
        #endregion

        #region 绘制CPK图表

        private bool drawLineChart(Chart chartName, string chartTitle, double[] normDistdataX, double[] normDistdataY, double[] densitydataX, double[] densitydataY, string seriesName1, string seriesName2, double USL = 0, double LSL = 0,
            double Target = 0)
        {
            try
            {
                //初始化图表显示
                Chart with_1 = chartName;
                with_1.Titles.Clear();
                with_1.Series.Clear();
                with_1.ChartAreas.Clear();
                with_1.ChartAreas.Add("CPK");

                System.Windows.Forms.DataVisualization.Charting.ChartArea with_2 = chartName.ChartAreas["CPK"];
                //作图区的显示属性设置
                with_2.AxisX.IsMarginVisible = false;
                with_2.Area3DStyle.Enable3D = false;
                with_2.AxisX.LineColor = Color.LightGray;
                with_2.AxisY.LineColor = Color.LightGray;
                with_2.AxisX.LineWidth = 2;
                with_2.AxisY.LineWidth = 2;
                with_2.AxisX.Title = "";
                with_2.AxisY.Title = "";
                with_2.AxisX.MajorGrid.LineColor = Color.LightGray;
                with_2.AxisY.MajorGrid.LineColor = Color.LightGray;
                with_2.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                with_2.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                with_2.AxisX.MajorGrid.Interval = USL / 2;
                with_2.AxisY.MajorGrid.Interval = 0.04;
                //.AxisY.IsLabelAutoFit = True
                //.AxisY.IsStartedFromZero = False
                with_2.AxisX.MajorTickMark.Interval = 0.5;
                with_2.AxisX.IsLabelAutoFit = false;
                with_2.AxisX.Interval = USL;
                with_2.AxisY.Maximum = 1;
                with_2.AxisY.Minimum = 0;
                //.AxisX.Maximum = USL + 0.1
                //.AxisX.Minimum = LSL - 0.1
                with_2.AxisX.Maximum = USL * 2;
                with_2.AxisX.Minimum = LSL * 2;

                chartName.Series.Add("Shadow");
                System.Windows.Forms.DataVisualization.Charting.Series with_3 = chartName.Series["Shadow"];
                with_3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                with_3.CustomProperties += "PointWidth=2";
                with_3.Color = Color.FromArgb(229, 242, 249);
                with_3.IsVisibleInLegend = false;
                with_3.IsValueShownAsLabel = false;
                for (int i = 0; i <= densitydataX.Length - 1; i++)
                {
                    chartName.Series["Shadow"].Points.AddXY(densitydataX[i], densitydataY[i]);
                }

                chartName.Series.Add(seriesName2);
                System.Windows.Forms.DataVisualization.Charting.Series with_4 = chartName.Series[seriesName2];
                with_4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                with_4.Color = Color.Green; //Color.FromArgb(192, 250, 192) 'Color.FromArgb(229, 242, 249)
                with_4.BorderWidth = (int)1.2;
                with_4.IsVisibleInLegend = false;
                with_4.IsValueShownAsLabel = false;
                for (int i = 0; i <= densitydataX.Length - 1; i++)
                {
                    chartName.Series[seriesName2].Points.AddXY(densitydataX[i], densitydataY[i]);
                }

                chartName.Series.Add(seriesName1);
                System.Windows.Forms.DataVisualization.Charting.Series with_5 = chartName.Series[seriesName1];
                with_5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                with_5.Color = Color.Blue;
                with_5.BorderWidth = (int)1.1;
                with_5.IsVisibleInLegend = false;
                with_5.IsValueShownAsLabel = false;
                for (int i = 0; i <= normDistdataX.Length - 1; i++)
                {
                    chartName.Series[seriesName1].Points.AddXY(normDistdataX[i], normDistdataY[i]);
                }

                drawStripLines(chartName, "USL", USL, 2, Color.Blue);
                drawStripLines(chartName, "Target", Target, 2, Color.Black);
                drawStripLines(chartName, "LSL", LSL, 2, Color.BlueViolet);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void drawStripLines(Chart chartName, string stripLineName, double stripLineValue, double maxY, Color colors)
        {
            double[] X = new double[] { };
            double[] Y = new double[] { };
            chartName.Series.Add(stripLineName);
            System.Windows.Forms.DataVisualization.Charting.Series with_1 = chartName.Series[stripLineName];
            with_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            if (colors == null)
            {
                colors = Color.Blue;
            }
            with_1.Color = colors;
            with_1.BorderWidth = (int)1.4;
            with_1.IsVisibleInLegend = false; //是否显示数据说明
            with_1.IsValueShownAsLabel = false; //线条上是否显示数据
            X = new double[3];
            Y = new double[3];
            for (int i = 0; i <= 2; i++)
            {
                X[i] = stripLineValue;
                Y[i] = i;
                chartName.Series[stripLineName].Points.AddXY(X[i], Y[i]);
            }
        }

        ///******CPK结构体********
        public struct nCPK
        {

            public double Ca;
            public double Cpu;
            public double Cpl;
            public double Cp;
            public double Cpk;
        }
        public nCPK CPKdata;
        public double stdDev = 0;
        public double powSum = 0;

        #region SIGMA：标准偏差，用来对过程变异进行测量
        public void CalculateSigma(double[] sampleData)
        {
            int sampleCount = sampleData.Count();
            powSum = 0;
            if (sampleCount <= 2) //样本个数大于2
            {
                stdDev = 0;
                return;
            }
            foreach (double value in sampleData)
            {
                powSum = powSum + Math.Pow(value - sampleData.Average(), 2); //样本值减去均值2次幂相加。
            }
            stdDev = Math.Sqrt(powSum / (sampleCount - 1));
        }
        #endregion


        public void Cpk_X_Click(object sender, EventArgs e) //public void Cpk_X_Click(dynamic sender, EventArgs e)
        {
            BoTech.Button btn = sender as BoTech.Button;
            double GetLimitDi_Z = 0;
            double GetLimitDi_F = 0;
            try
            {
                if (btn.Name == "Cpk_X")
                {
                    GetLimitDi_Z = 0.15;
                    GetLimitDi_F = -0.15;
                    Cpk_X.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    Cpk_Y.BZ_BackColor = Color.LightGray;
                    Cpk_CC.BZ_BackColor = Color.LightGray;
                    Cpk_A.BZ_BackColor = Color.LightGray;
                    for (int i = 0; i <= 31; i++)
                    {
                        defaultData[i] = PVar.tmpCpkData.X[i];
                    }
                }
                else if (btn.Name == "Cpk_Y")
                {
                    GetLimitDi_Z = 0.15;
                    GetLimitDi_F = -0.15;
                    Cpk_X.BZ_BackColor = Color.LightGray;
                    Cpk_Y.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    Cpk_CC.BZ_BackColor = Color.LightGray;
                    Cpk_A.BZ_BackColor = Color.LightGray;
                    for (int i = 0; i <= 31; i++)
                    {
                        defaultData[i] = PVar.tmpCpkData.Y[i];
                    }
                }
                else if (btn.Name == "Cpk_CC")
                {
                    GetLimitDi_Z = 0.2;
                    GetLimitDi_F = 0;
                    Cpk_X.BZ_BackColor = Color.LightGray;
                    Cpk_Y.BZ_BackColor = Color.LightGray;
                    Cpk_CC.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    Cpk_A.BZ_BackColor = Color.LightGray;
                    for (int i = 0; i <= 31; i++)
                    {
                        defaultData[i] = PVar.tmpCpkData.CC[i];
                    }
                }
                else if (btn.Name == "Cpk_A")
                {
                    GetLimitDi_Z = 2;
                    GetLimitDi_F = -2;
                    Cpk_X.BZ_BackColor = Color.LightGray;
                    Cpk_Y.BZ_BackColor = Color.LightGray;
                    Cpk_CC.BZ_BackColor = Color.LightGray;
                    Cpk_A.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    for (int i = 0; i <= 31; i++)
                    {
                        defaultData[i] = PVar.tmpCpkData.A[i];
                    }
                }

                CalNormDistClass cal = new CalNormDistClass(defaultData, GetLimitDi_Z, GetLimitDi_F);
                if (cal.CalGaussianDist(ref gaussiData_X, ref gaussiData_Y) == false)
                {
                    MessageBox.Show("高斯分布值计算出错！");
                }
                if (cal.CalDensityDist(ref densityData_X, ref densityData_Y) == false)
                {
                    MessageBox.Show("密度分布值计算出错！");
                }
                if (drawLineChart(Chart1, System.Convert.ToString(btn.Name), gaussiData_X, gaussiData_Y, densityData_X, densityData_Y, "Normal Dist", "Density", GetLimitDi_Z, GetLimitDi_F) == false)
                {
                    MessageBox.Show("CPK曲线显示出错！");
                }

                CalculateSigma(defaultData);//标准偏差

                CPKdata.Ca = Math.Abs((defaultData.Average() - ((GetLimitDi_Z + GetLimitDi_F) / 2)) / (GetLimitDi_Z - GetLimitDi_F) * 2);
                CPKdata.Cpu = double.Parse(Strings.Format((GetLimitDi_Z - defaultData.Average()) / (3 * stdDev), "0.000"));
                CPKdata.Cpl = (defaultData.Average() - GetLimitDi_F) / (3 * stdDev);
                CPKdata.Cp = (GetLimitDi_Z - GetLimitDi_F) / (6 * stdDev);
                CPKdata.Cpk = double.Parse(Strings.Format((1 - CPKdata.Ca) * CPKdata.Cp, "0.000"));

                if (btn.Name == "Cpk_X")
                {
                    Label_CPK.BZ_BigText = "Cpk: " + System.Convert.ToString(CPKdata.Cpk);
                }
                else if (btn.Name == "Cpk_Y")
                {
                    Label_CPK.BZ_BigText = "Cpk: " + System.Convert.ToString(CPKdata.Cpk);
                }
                else if (btn.Name == "Cpk_CC")
                {
                    Label_CPK.BZ_BigText = "Cpu: " + System.Convert.ToString(CPKdata.Cpu);
                }
                else if (btn.Name == "Cpk_A")
                {
                    Label_CPK.BZ_BigText = "Cpk: " + System.Convert.ToString(CPKdata.Cpk);
                }
                Label_CPK.BZ_SmallText = "Count: " + System.Convert.ToString(defaultData.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ">>:CPK值计算出错！");
            }
        }
        #endregion

        #region 绘制复检数据图表
        public void BTN_X_Click(object sender, EventArgs e)
        {
            BoTech.Button btn = sender as BoTech.Button;
            double target = 0;
            double IntercalY = 0;
            double IntercalStartY = 0;
            double IntercalEndY = 0;
            double[] DataSoures = new double[50];
            try
            {
                if (btn.Name == "BTN_X")
                {
                    BTN_X.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    BTN_Y.BZ_BackColor = Color.LightGray;
                    BTN_CC.BZ_BackColor = Color.LightGray;
                    BTN_A.BZ_BackColor = Color.LightGray;
                    DataSoures = PVar.tmpCpkData.X;
                    IntercalY = 0.05;
                    IntercalStartY = -0.15;
                    IntercalEndY = 0.15;
                }
                else if (btn.Name == "BTN_Y")
                {
                    BTN_X.BZ_BackColor = Color.LightGray;
                    BTN_Y.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    BTN_CC.BZ_BackColor = Color.LightGray;
                    BTN_A.BZ_BackColor = Color.LightGray;
                    DataSoures = PVar.tmpCpkData.Y;
                    IntercalY = 0.05;
                    IntercalStartY = -0.15;
                    IntercalEndY = 0.15;
                }
                else if (btn.Name == "BTN_CC")
                {
                    BTN_X.BZ_BackColor = Color.LightGray;
                    BTN_Y.BZ_BackColor = Color.LightGray;
                    BTN_CC.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    BTN_A.BZ_BackColor = Color.LightGray;
                    DataSoures = PVar.tmpCpkData.CC;
                    IntercalY = 0.05;
                    IntercalStartY = -0.2;
                    IntercalEndY = 0.2;
                }
                else if (btn.Name == "BTN_A")
                {
                    BTN_X.BZ_BackColor = Color.LightGray;
                    BTN_Y.BZ_BackColor = Color.LightGray;
                    BTN_CC.BZ_BackColor = Color.LightGray;
                    BTN_A.BZ_BackColor = PVar.BZColor_SelectedBtn;
                    DataSoures = PVar.tmpCpkData.A;
                    IntercalY = 0.5;
                    IntercalStartY = -2;
                    IntercalEndY = 2;
                }
                target = 0;
                Update_DataChart(btn, target, IntercalY, IntercalStartY, IntercalEndY, DataSoures);
            }
            catch (Exception)
            {
                MessageBox.Show("计算出错！");
            }
        }

        public void Update_DataChart(BoTech.Button sender, double Target, double IntercalY, double SelectionStartY, double SelectionEndY, double[] DataSoures)
        {
            //初始化图表显示
            Chart_CheckData.Titles.Clear();
            Chart_CheckData.Series.Clear();
            Chart_CheckData.ChartAreas.Clear();
            Chart_CheckData.ChartAreas.Add("CheckData");

            System.Windows.Forms.DataVisualization.Charting.ChartArea with_2 = Chart_CheckData.ChartAreas["CheckData"];
            //作图区的显示属性设置
            with_2.BackColor = Color.White;
            with_2.AxisX.IsMarginVisible = false;
            with_2.Area3DStyle.Enable3D = false;
            with_2.AxisX.LineColor = Color.Black;
            with_2.AxisY.LineColor = Color.Black;
            with_2.AxisX.LineWidth = 1;
            with_2.AxisY.LineWidth = 1;
            with_2.AxisX.Title = "";
            with_2.AxisY.Title = "";
            with_2.AxisX.MajorGrid.LineColor = Color.LightGray;
            with_2.AxisY.MajorGrid.LineColor = Color.LightGray;
            with_2.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            with_2.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            with_2.AxisX.MajorTickMark.Interval = 5;
            with_2.AxisX.IsLabelAutoFit = false;
            with_2.AxisX.Interval = 5;
            with_2.AxisX.MajorGrid.Interval = 1;
            with_2.AxisY.Interval = IntercalY;
            with_2.AxisY.MajorGrid.Interval = IntercalY;
            with_2.AxisY.Maximum = SelectionEndY;
            with_2.AxisY.Minimum = SelectionStartY;
            with_2.AxisX.Maximum = 50; //USL + 0.1
            with_2.AxisX.Minimum = 0; //    LSL - 0.1

            Chart_CheckData.Series.Add("Data_" + sender.Text);

            System.Windows.Forms.DataVisualization.Charting.Series with_3 = Chart_CheckData.Series["Data_" + sender.Text];
            //点颜色
            with_3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            with_3.Color = Color.Blue;
            with_3.IsVisibleInLegend = false;
            with_3.IsValueShownAsLabel = false;

            for (int i = 0; i <= 50; i++)
            {
                with_3.Points.AddXY(i, DataSoures[50 - i]);
                with_3.Points[i].MarkerStyle = MarkerStyle.Diamond;
                with_3.Points[i].MarkerColor = Color.Gold;
            }

            Chart_CheckData.Series.Add("Target");
            System.Windows.Forms.DataVisualization.Charting.Series with_4 = Chart_CheckData.Series["Target"];
            with_4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            with_4.Color = Color.Red;
            with_4.IsVisibleInLegend = false;
            with_4.IsValueShownAsLabel = false;

            for (int i = 0; i <= 50; i++)
            {
                with_4.Points.AddXY(i, Target);
            }

            //Chart_CheckData.Update();

        }

        #endregion

        #region 鼠标点击，通过环号显示游标，并缩放到响应位置
        /// <summary>
        /// 鼠标点击，通过环号显示游标，并缩放到响应位置函数
        /// </summary>
        /// <param name="ringNum">环号</param>
        /// <param name="chart">Chart控件</param>
        public static void ShowCurByClick(int ringNum, Chart chart)
        {
            //设置游标位置
            chart.ChartAreas[0].CursorX.Position = ringNum;
            //设置视图缩放
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(ringNum - 1, ringNum + 2);
            //改变曲线线宽
            chart.Series[0].BorderWidth = 3;
            //改变X轴刻度间隔
            chart.ChartAreas[0].AxisX.Interval = 1;
        }
        #endregion

        private void Force_S2_Click(object sender, EventArgs e)
        {
            PVar.ChangeF = true;
            Force_S2.BZ_BackColor = PVar.BZColor_SelectedBtn;
            Force_S3.BZ_BackColor = Color.LightGray;
            for (int i = PVar.Press.Count() - 1; i >= 0; i--)
            {
                PVar.Press[i] = 0;
            }
        }

        private void Force_S3_Click(object sender, EventArgs e)
        {
            Force_S3.BZ_BackColor = PVar.BZColor_SelectedBtn;
            Force_S2.BZ_BackColor = Color.LightGray;
            PVar.ChangeF = false;
            for (int i = PVar.Press.Count() - 1; i >= 0; i--)
            {
                PVar.Press[i] = 0;
            }
        }

    }
}
