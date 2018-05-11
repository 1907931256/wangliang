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

namespace BZGUI
{
    public partial class Chart30Day : UserControl
    {

        private Series[] series = new Series[1];
        private Color[] seriescolor = new Color[7] { Mycolor.Blue, Mycolor.Green, Mycolor.Yellow, Mycolor.LightGreen, Mycolor.LightRed, Mycolor.Red, Mycolor.BackGroud };
        System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();

        public double[] data = new double[30];
        public double[] DataShow
        {
            get { return data; }
            set
            {
                data = value;

                UpdateChartDatas();
            }
        }

        string title = "";
        public string LengedTitle
        {
            get { return title; }
            set { title = value; }
        }
        private int max = 0;
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public Chart30Day()
        {
            InitializeComponent();


            title1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);

            this.chart1.Titles.Add(title1);

            if (Max == 0)
            {
                chart1.ChartAreas["Default"].AxisY.Interval = 20;
                chart1.ChartAreas["Default"].AxisY.Maximum = 100;
            }
            else
            {
                chart1.ChartAreas["Default"].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount; ;
            }

            chart1.ChartAreas["Default"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            // chart1.ChartAreas["Default"].AxisX.IsMarginVisible = false;     

            int i = 0;
            series[i] = new Series();
            series[i].BorderColor = Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series[i].BorderWidth = 3;

            series[i].ChartType = SeriesChartType.Line;
            series[i].Color = seriescolor[i];

            series[i].MarkerSize = 8;
            series[i].MarkerStyle = MarkerStyle.Circle;
            series[i].Name = "Series" + i;
            series[i].ShadowColor = Color.Black;
            series[i].ShadowOffset = 2;
            series[i].XValueType = ChartValueType.Double;
            series[i].YValueType = ChartValueType.Double;
            this.chart1.Series.Add(series[i]);
            chart1.Series[series[i].Name].ChartType = SeriesChartType.Spline;
            chart1.Series[series[i].Name].IsValueShownAsLabel = true;
            chart1.Series[series[i].Name]["LabelStyle"] = "Top";

            chart1.Series[0].IsVisibleInLegend = false;

        }



        private void UpdateChartDatas()
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new Action(() =>
            {

                var val = trackBar1.Value;
                chart1.Series[0].Points.Clear();
                for (int pointIndex = 0; pointIndex < val; pointIndex++)
                {
                    var date = (DateTime.Now.AddDays(-pointIndex)).Date.ToString("MM-dd");
                    chart1.Series[0].Points.AddXY(date, DataShow[pointIndex]);
                }
            }));
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (trackBar1.Value > 1 && trackBar1.Value < 31)
            {
                trackBar1.Value = trackBar1.Value - 1;
                chart1.Series[0].Points.Clear();
                var val = trackBar1.Value;


                for (int pointIndex = 0; pointIndex < val; pointIndex++)
                {
                    var date = (DateTime.Now.AddDays(-pointIndex)).Date.ToString("MM-dd");
                    chart1.Series[0].Points.AddXY(date, DataShow[pointIndex]);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0 && trackBar1.Value < 30)
            {
                trackBar1.Value = trackBar1.Value + 1;
                chart1.Series[0].Points.Clear();
                var val = trackBar1.Value;
                for (int pointIndex = 0; pointIndex < val; pointIndex++)
                {
                    //chart1.Series[0].Points.AddY(data[pointIndex]);
                    var date = (DateTime.Now.AddDays(-pointIndex)).Date.ToString("MM-dd");
                    chart1.Series[0].Points.AddXY(date, DataShow[pointIndex]);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0 && trackBar1.Value < 30)
            {
                trackBar1.Value = trackBar1.Value + 1;
                chart1.Series[0].Points.Clear();
                var val = trackBar1.Value;
                for (int pointIndex = 0; pointIndex < val; pointIndex++)
                {
                    //chart1.Series[0].Points.AddY(data[pointIndex]);
                    var date = (DateTime.Now.AddDays(-pointIndex)).Date.ToString("MM-dd");
                    chart1.Series[0].Points.AddXY(date, DataShow[pointIndex]);
                }
            }
        }

        private void Chart30Day_Load(object sender, EventArgs e)
        {
            title1.Text = LengedTitle;
            // UpdateChartDatas();
        }

    }
}
