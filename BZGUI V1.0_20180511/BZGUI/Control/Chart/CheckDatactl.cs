using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using XCore;
using BZappdll;

namespace BZGUI
{
    public partial class CheckDatactl : UserControl
    {
        //private string[] _testitems = new string[] { "X", "Y", "A", "CC" };
        //private double[] _USL = new double[] { 0.08, 0.08, 1, 0.15 };
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

        public CheckDatactl()
        {
            InitializeComponent();
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
                _USL = new double[] { 0.08, 0.08 };
            }
            InitialDgv();
        }

        private void CheckDatactl_Load(object sender, EventArgs e)
        {
            UpdateData(LastSelected);
            PageProduction.OnFlashToCPKchart += Onupdate;
        }

        //transfer from pageproduction
        private void Onupdate()
        {
            UpdateData(LastSelected);
        }

        private void UpdateData(int index)
        {
            double USL = 0.05;
            double LSL = -0.05;
            double Stander = 0.0;
            double IntercalY = 0;
            double IntercalStartY = 0;
            double IntercalEndY = 0;

            List<double[]> listtemp = new List<double[]>();
            if (!this.IsHandleCreated)
                return;
            this.BeginInvoke(new Action(() =>
            {
                #region ChartUpate
                try
                {
                    #region 获取数据部分
                    listtemp.Clear();
                    DataManager.Instance.chartData.GetData(out TestrawData);

                    //transfer testrawdata to 2D array
                    for (int i = 0; i < TestrawData.Length; i++)
                    {
                        string[] CPKRowdata = TestrawData[i].Split(',');
                        double[] cpkdoubledata = Array.ConvertAll(CPKRowdata, v1 => double.Parse(v1));//将字符串数组变成双精度的数组
                        listtemp.Add(cpkdoubledata);
                    }
                    double[] Dn;
                    if (TestrawData.Length == 0)
                    { Dn=new double[_testitems.Length];}
                    else
                    {Dn = new double[TestrawData.Length];} //取出对应列的数据
                    for (int i = 0; i < TestrawData.Length; i++)
                    {
                        Dn[i] = listtemp[i][index];
                    }

                    USL = _USL[index];
                    LSL = _LSL[index];
                    Stander = (USL + LSL) / 2.0;
                    IntercalY = USL*0.4;
                    IntercalStartY = LSL - USL * 0.2;
                    IntercalEndY = USL + USL*0.2;

                    #endregion
                    //cahrt
                    Update_DataChart(index, Stander, IntercalY, IntercalStartY, IntercalEndY, Dn);

                }
                catch (Exception)
                { }
                #endregion
            }));

        }

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

        #region Chart 

        public void Update_DataChart(int ClickIndex, double Target, double IntercalY, double SelectionStartY, double SelectionEndY, double[] DataSoures)
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

            Chart_CheckData.Series.Add("Data_" + _testitems[ClickIndex]);

            System.Windows.Forms.DataVisualization.Charting.Series with_3 = Chart_CheckData.Series["Data_" + _testitems[ClickIndex]];
            //点颜色
            with_3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            with_3.Color = Color.Blue;
            with_3.IsVisibleInLegend = false;
            with_3.IsValueShownAsLabel = false;

            for (int i = 0; i < DataSoures.Length; i++)
            {
                with_3.Points.AddXY(i, DataSoures[i]);
                with_3.Points[i].MarkerStyle = MarkerStyle.Diamond;
                with_3.Points[i].MarkerColor = Color.Gold;
            }

            Chart_CheckData.Series.Add("Target");
            System.Windows.Forms.DataVisualization.Charting.Series with_4 = Chart_CheckData.Series["Target"];
            with_4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            with_4.Color = Color.Red;
            with_4.IsVisibleInLegend = false;
            with_4.IsValueShownAsLabel = false;

            for (int i = 0; i < DataSoures.Length; i++)
            {
                with_4.Points.AddXY(i, Target);
            }

            //Chart_CheckData.Update();

        }

        private void Chart_CheckData_SizeChanged(object sender, EventArgs e)
        {
            Change_dgv_Size();
        }


        #endregion



    }
}
