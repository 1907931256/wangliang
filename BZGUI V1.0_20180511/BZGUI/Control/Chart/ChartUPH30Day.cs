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
    public partial class ChartUPH30Day : UserControl
    {

        private Series[] series = new Series[1];
        private Color[] seriescolor = new Color[7] { Mycolor.Blue, Mycolor.Green, Mycolor.Yellow, Mycolor.LightGreen, Mycolor.LightRed, Mycolor.Red, Mycolor.BackGroud };
        System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();

        public int[] data = new int[24];
        string[] dateTimeArray = new string[] { "00-01", "01-02", "02-03", "03-04", "04-05", "05-06", "06-07", "07-08",
                                                "08-09", "09-10", "10-11", "11-12", "12-13", "13-14", "14-15", "15-16",
                                                "16-17", "17-18", "18-19", "19-20", "20-21", "21-22", "22-23", "23-00"};


        public int[] DataShow
        {
            get { return data; }
            set
            {
                data = value;
                UpdateChartDatas();   //只有datashow的值改变，就会调用Updata
            }
        }

        string title = "UPH ";
        public string LengedTitle
        {
            get { return title; }
            //set { title = value; }
        }
        private int max = 0;
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public ChartUPH30Day()
        {
            InitializeComponent();


            title1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);

            this.chart1.Titles.Add(title1);


            chart1.ChartAreas["Default"].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount; ;


            chart1.ChartAreas["Default"].AxisX.Interval = 2;
            chart1.ChartAreas["Default"].AxisX.IsLabelAutoFit = false;
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

        private void ChartUPH30Day_Load(object sender, EventArgs e)
        {
            title1.Text = LengedTitle;
            UpdateChartDatas();
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

                var date1 = (DateTime.Now.AddDays(-val + 1)).ToString("yyyyMMdd");

                chart1.Series[0].Points.Clear();

                for (int pointIndex = 0; pointIndex < 24; pointIndex++)
                {
                    chart1.Series[0].Points.AddXY(dateTimeArray[pointIndex], DataShow[pointIndex]);
                }

                title1.Text = LengedTitle + ", Date:" + (DateTime.Now.AddDays(-val + 1)).ToString("MM-dd") + " ,Total:" + DataShow.Sum();
            }));
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (trackBar1.Value > 1 && trackBar1.Value < 31)
            {
                trackBar1.Value = trackBar1.Value - 1;
                var val = trackBar1.Value;
                var date = (DateTime.Now.AddDays(-val + 1)).ToString("yyyyMMdd");
                //DataShow = DataManager.Instance.chartData.GetUPHByDay(Globals.Dir_Record_Report, date);
                DataManager.Instance.uphManger.Load();
                DataShow = DataManager.Instance.uphManger.UphMap[date].UPHDay;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0 && trackBar1.Value < 30)
            {
                trackBar1.Value = trackBar1.Value + 1;
                var val = trackBar1.Value;
                var date = (DateTime.Now.AddDays(-val + 1)).ToString("yyyyMMdd");
                //DataShow = DataManager.Instance.chartData.GetUPHByDay(Globals.Dir_Record_Report ,date);
                DataManager.Instance.uphManger.Load();
                DataShow = DataManager.Instance.uphManger.UphMap[date].UPHDay;

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0 && trackBar1.Value < 30)
            {
                trackBar1.Value = trackBar1.Value + 1;
                var val = trackBar1.Value;
                var date = (DateTime.Now.AddDays(-val + 1)).ToString("yyyyMMdd");
                //DataShow = DataManager.Instance.chartData.GetUPHByDay(Globals.Dir_Record_Report, date);
                DataManager.Instance.uphManger.Load();
                DataShow = DataManager.Instance.uphManger.UphMap[date].UPHDay;
            }
        }



    }
}
