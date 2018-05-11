using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalNormDistLabrary;
using System.Windows.Forms.DataVisualization.Charting;
using XCore;

namespace BZGUI
{
    public partial class ChartCPK : UserControl
    {
        double[] defaultData = new double[] { };
        double[] gaussiData_X = new double[] { };
        double[] gaussiData_Y = new double[] { };
        double[] densityData_X = new double[] { };
        double[] densityData_Y = new double[] { };

        //private string[] _testitems =new string[]{ "X","Y","A","CC"};
        //private double[] _USL = new double[] {0.08,0.08,1,0.15 };
        //private double[] _LSL = new double[] { -0.08, -0.08, -1, 0 };
        private string[] _testitems ;
        private double[] _USL ;
        private double[] _LSL ;

        private bool locked = false;
        public int LastSelected = 0;//鼠标选中的列
        public string[] TestrawData;

        //public string[] TestItem//控件可以设置
        //{ 
        //    get { return this._testitems; }
        //    set { this._testitems = value; }
        //}

        //public double[] USLSetup//控件可以设置
        //{
        //    get { return this._USL; }
        //    set { this._USL = value; }
        //}

        //public double[] LSLSetup//控件可以设置
        //{
        //    get { return this._LSL; }
        //    set { this._LSL = value; }
        //}

        public bool Locked
        {
            get { return this.locked; }
            set { this.locked = value; }
        }

        #region windows

        public ChartCPK()
        {
            InitializeComponent();
            PageProduction.OnFlashToCPKchart += OnupdateCPK;//将最近的100个数据的最近32个取数组
        }

        private void ChartCPK_Load(object sender, EventArgs e)
        {
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            {
                _testitems = new string[] { "X", "Y", "Z", "A" };
                _LSL = new double[] { -0.08, -0.08, -1, -0.2 };
                _USL = new double[] { 0.08, 0.08, 1, 0.2 };
            }
            else
            {
                _testitems = new string[] { "IPD_Left", "IPD_Right" };
                _LSL = new double[] { -0.08, -0.08 };
                _USL = new double[] { 0.08, 0.08};
            }
            InitialDgv();
            UpdateData(LastSelected);
        }

        #endregion

        #region datagridview
        private void InitialDgv()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < _testitems.Length; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[i].HeaderText = _testitems[i];
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; //设定每一列的排序类型为不排序
            }
            //dataGridView1.ColumnHeadersHeight = this.dataGridView1.Height;//让整个表格只有列首
            DataGridViewRow dr = new DataGridViewRow();
            for (int i = 0; i < _testitems.Length; i++)
            {
                dr.Cells.Add(new DataGridViewTextBoxCell());
                dr.Cells[i].Value = _testitems[i];
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.Rows.Add(dr);
            dataGridView1.Rows[0].Height = this.dataGridView1.Height;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LastSelected = e.ColumnIndex;
            UpdateData(LastSelected); 
        }   
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LastSelected = e.ColumnIndex;
            UpdateData(LastSelected); 
        }

        private void Change_dgv_Size()//尺寸变化的时候随着变,用dll对此个不管用
        {
            //the first time to run this,it will be some error happened,ignore it
            try
            {

                for (int i = 0; i < _testitems.Length; i++)
                {
                    dataGridView1.Columns[i].Width = Convert.ToInt16(dataGridView1.Width / _testitems.Length);
                    dataGridView1.Rows[0].Height = this.dataGridView1.Height;
                }
            }
            catch { }
        }

        #endregion

        #region chart function

        private bool drawLineChart(Chart chartName, string chartTitle, double[] normDistdataX, double[] normDistdataY, double[] densitydataX, double[] densitydataY,
                          string seriesName1, string seriesName2, double USL = 0, double LSL = 0, double Target = 0)
        {
            try
            {
                #region 初始化图表显示
                chartName.Titles.Clear();
                chartName.Series.Clear();
                chartName.ChartAreas.Clear();
                chartName.ChartAreas.Add("CPK");
                //作图区的显示属性设置
                chartName.ChartAreas["CPK"].AxisX.IsMarginVisible = false;
                chartName.ChartAreas["CPK"].Area3DStyle.Enable3D = false;
                chartName.ChartAreas["CPK"].AxisX.LineColor = Color.LightGray;
                chartName.ChartAreas["CPK"].AxisY.LineColor = Color.LightGray;
                chartName.ChartAreas["CPK"].AxisX.LineWidth = 2;
                chartName.ChartAreas["CPK"].AxisY.LineWidth = 2;
                chartName.ChartAreas["CPK"].AxisX.Title = "";
                chartName.ChartAreas["CPK"].AxisY.Title = "";
                chartName.ChartAreas["CPK"].AxisX.MajorGrid.LineColor = Color.LightGray;
                chartName.ChartAreas["CPK"].AxisY.MajorGrid.LineColor = Color.LightGray;
                chartName.ChartAreas["CPK"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                chartName.ChartAreas["CPK"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
                chartName.ChartAreas["CPK"].AxisX.MajorGrid.Interval = 0.02;
                chartName.ChartAreas["CPK"].AxisY.MajorGrid.Interval = 0.02;
                chartName.ChartAreas["CPK"].AxisY.IsLabelAutoFit = true;
                chartName.ChartAreas["CPK"].AxisY.IsStartedFromZero = false;
                chartName.ChartAreas["CPK"].AxisX.MajorTickMark.Interval = 0.1;
                chartName.ChartAreas["CPK"].AxisX.IsLabelAutoFit = false;

                //double Lineinterval = (LastSelected == 3) ? 0.2 : 0.1;//=3 is angle
                double Lineinterval = ( Math.Abs(USL)>0.5) ? 0.2 : 0.1;//=3 is angle
                chartName.ChartAreas["CPK"].AxisX.Interval = Lineinterval;
                chartName.ChartAreas["CPK"].AxisY.Maximum = 1;
                chartName.ChartAreas["CPK"].AxisY.Minimum = 0;
                chartName.ChartAreas["CPK"].AxisY.Maximum = 1;
                chartName.ChartAreas["CPK"].AxisY.Minimum = 0;
                chartName.ChartAreas["CPK"].AxisX.Maximum = USL + 0.1;
                chartName.ChartAreas["CPK"].AxisX.Minimum = LSL - 0.1;
                chartName.ChartAreas["CPK"].AxisX.ScaleView.Zoomable = true;
                chartName.ChartAreas["CPK"].CursorX.Interval = 0;
                chartName.ChartAreas["CPK"].CursorX.IntervalOffset = 0;
                chartName.ChartAreas["CPK"].CursorX.IntervalOffsetType = DateTimeIntervalType.Milliseconds;
                chartName.ChartAreas["CPK"].AxisY.ScaleView.Zoomable = true;
                chartName.ChartAreas["CPK"].CursorX.IsUserEnabled = true;
                chartName.ChartAreas["CPK"].CursorX.IsUserSelectionEnabled = true;
                chartName.ChartAreas["CPK"].CursorY.IsUserEnabled = true;
                chartName.ChartAreas["CPK"].CursorY.IsUserSelectionEnabled = true;
                chartName.Series.Add("Shadow");
                chartName.Series["Shadow"].ChartType = SeriesChartType.Column;
                chartName.Series["Shadow"].CustomProperties += "PointWidth=2";
                chartName.Series["Shadow"].Color = Color.FromArgb(229, 242, 249);
                chartName.Series["Shadow"].IsVisibleInLegend = false;
                chartName.Series["Shadow"].IsValueShownAsLabel = false;

                for (int i = 0; i < densitydataX.Length; i++)
                {
                    chartName.Series["Shadow"].Points.AddXY(densitydataX[i], densitydataY[i]);
                }

                chartName.Series.Add(seriesName2);
                chartName.Series[seriesName2].ChartType = SeriesChartType.Spline;
                chartName.Series[seriesName2].Color = Color.Green; //Color.FromArgb(192, 250, 192);
                chartName.Series[seriesName2].BorderWidth = 2;
                chartName.Series[seriesName2].IsVisibleInLegend = false;
                chartName.Series[seriesName2].IsValueShownAsLabel = false;

                for (int i = 0; i < densitydataX.Length; i++)
                {
                    chartName.Series[seriesName2].Points.AddXY(densitydataX[i], densitydataY[i]);
                }

                chartName.Series.Add(seriesName1);
                chartName.Series[seriesName1].ChartType = SeriesChartType.Spline;

                chartName.Series[seriesName1].Color = Color.Blue;
                chartName.Series[seriesName1].BorderWidth = 1;
                chartName.Series[seriesName1].IsVisibleInLegend = false;
                chartName.Series[seriesName1].IsValueShownAsLabel = false;

                for (int i = 0; i < normDistdataX.Length; i++)
                {
                    chartName.Series[seriesName1].Points.AddXY(normDistdataX[i], normDistdataY[i]);
                }
                #endregion

                drawStripLines(chartName, "USL", USL, 2, Color.Blue);
                drawStripLines(chartName, "Target", Target, 2, Color.Black);
                drawStripLines(chartName, "LSL", LSL, 2, Color.BlueViolet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }


        private void drawStripLines(Chart chartName, string stripLineName, double stripLineValue, double maxY, Color colors)
        {
            double[] X = new double[] { };
            double[] Y = new double[] { };
            chartName.Series.Add(stripLineName);
            chartName.Series[stripLineName].ChartType = SeriesChartType.Line;
            chartName.Series[stripLineName].Color = colors;
            chartName.Series[stripLineName].BorderWidth = 1;
            chartName.Series[stripLineName].IsVisibleInLegend = false;//是否显示数据说明
            chartName.Series[stripLineName].IsValueShownAsLabel = false;//线条上是否显示数据
            X = new double[3];
            Y = new double[3];
            for (int i = 0; i <= 2; i++)
            {
                X[i] = stripLineValue;
                Y[i] = i;
                chartName.Series[stripLineName].Points.AddXY(X[i], Y[i]);
            }
        }

        private void chart1_SizeChanged(object sender, EventArgs e)
        {
            Change_dgv_Size();
        }

        #endregion

        //transfer from pageproduction
        private void OnupdateCPK()
        {
            UpdateData(LastSelected);  
        }

        private void UpdateData(int indexCPK)
        {
            double USL = 0.05;
            double LSL = -0.05;
            double Stander = 0.0;
            double cpk值 = 0;
            List<double[]> listtemp = new List<double[]>();
            if (!this.IsHandleCreated)
                return;
            this.BeginInvoke(new Action(() =>
            {
                #region ChartUpate
                try
                {
                    listtemp.Clear();
                    DataManager.Instance.chartData.GetData(out TestrawData);

                    //transfer testrawdata to 2D array
                    for (int i = 0; i < TestrawData.Length; i++)
                    {
                        string[] CPKRowdata = TestrawData[i].Split(',');
                        double[] cpkdoubledata = Array.ConvertAll(CPKRowdata, v1 => double.Parse(v1));//将字符串数组变成双精度的数组
                        listtemp.Add(cpkdoubledata);
                    }
                    double[] Dn = new double[TestrawData.Length];//取出对应列的数据
                    for (int i = 0; i < TestrawData.Length; i++)
                    {
                        Dn[i] = listtemp[i][indexCPK];
                    }

                    if (TestrawData.Length >= 10)
                    {
                        #region >=32 CPK部分

                        USL = _USL[indexCPK];
                        LSL = _LSL[indexCPK];
                        Stander = (USL + LSL) / 2.0;

                        #region cal CPK

                        //double[] defaultData = new double[32];
                        try
                        {
                            //for (int i = 0; i <32; i++)
                            //{
                            //    defaultData[i] = Dn[Dn.Length - i - 1];//取最后32，反着取
                            //}
                            CalNormDistLabrary.CalNormDistClass cal = new CalNormDistLabrary.CalNormDistClass(Dn, USL, LSL);
                            if (cal.CalGaussianDist(ref gaussiData_X, ref gaussiData_Y) == false)
                            {
                                MessageBox.Show("高斯分布值计算出错！");
                            }
                            if (cal.CalDensityDist(ref densityData_X, ref densityData_Y) == false)
                            {
                                MessageBox.Show("密度分布值计算出错！");
                            }
                            if (drawLineChart(chart1, "CPK", gaussiData_X, gaussiData_Y, densityData_X, densityData_Y, "Normal Dist", "Density", USL, LSL, Stander) == false)
                            {
                                MessageBox.Show("CPK曲线显示出错！");
                            }
                            cpk值 = cal.CPK;
                        }
                        catch
                        { }

                        #endregion

                        if (Globals.MachineMode == MachineModeType.CPKGRR)
                        {
                            //this.Label_CPK.Text = this.Label_CPK.Text + "32/32 CPK/GRR Mode";
                            this.Label_CPK.BZ_SmallText = "CPK:" + cpk值;
                            this.Label_CPK.BZ_BigText =Dn.Length+"/32 CPK/GRR Mode";
                        }
                        else
                        {
                            //this.Label_CPK.Text = this.Label_CPK.Text + "32/32 Production Mode";
                            this.Label_CPK.BZ_SmallText = "CPK:" + cpk值;
                            this.Label_CPK.BZ_BigText = Dn.Length + "/32 Production Mode";
                        }
                        #endregion
                    }
                    //else
                    //{
                    //    #region <32CPK部分
                    //    if (Globals.MachineMode == MachineModeType.CPKGRR)
                    //    {
                    //        //this.Label_CPK.Text = "CPK:XXXX\r\n" + TestrawData.Length + "/32 CPK/GRR Mode";
                    //        this.Label_CPK.BZ_SmallText = "CPK:XXXX";
                    //        this.Label_CPK.BZ_BigText = TestrawData.Length + "/32 CPK/GRR Mode";
                    //    }
                    //    else
                    //    {
                    //        //this.Label_CPK.Text = "CPK:XXXX\r\n" + TestrawData.Length + "/32 Production Mode";
                    //        this.Label_CPK.BZ_SmallText = "CPK:XXXX";
                    //        this.Label_CPK.BZ_BigText = TestrawData.Length + "/32 Production Mode";
                    //    }
                    //    #endregion
                    //}
                }
                catch (Exception)
                { }
                #endregion
            }));
        }


    }
}
