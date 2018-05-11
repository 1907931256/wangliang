using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //需要添加的命名空间 

namespace BZGUI
{
    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            InitChart();  
		}


        System.Windows.Forms.Timer chartTimer = new System.Windows.Forms.Timer();

        private void InitChart()
            {
            DateTime time = DateTime.Now;
            chartTimer.Interval = 1;
            chartTimer.Tick += chartTimer_Tick;
            chartDemo.DoubleClick += chartDemo_DoubleClick;

            Series series = chartDemo.Series[0];
            series.ChartType = SeriesChartType.Spline;

            //chartDemo.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chartDemo.ChartAreas[0].AxisX.ScaleView.Size = 50;
            chartDemo.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            //chartDemo.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            chartTimer.Start();

            }

        void chartDemo_DoubleClick(object sender, EventArgs e)
            {
            chartDemo.ChartAreas[0].AxisX.ScaleView.Size = 5;
            chartDemo.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chartDemo.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            //throw new NotImplementedException();  
            }

        private int n;
        void chartTimer_Tick(object sender, EventArgs e)
            {
            n++;
            Random ra = new Random();
            Series series = chartDemo.Series[0];
            chartDemo.ChartAreas[0].AxisX.Maximum = 600;
            chartDemo.ChartAreas[0].AxisX.Minimum = 0;
            series.Points.AddXY(n, ra.Next(1, 10));
            chartDemo.ChartAreas[0].AxisX.ScaleView.Position = series.Points.Count - 50;
            //throw new NotImplementedException();  
            }

        private void chartDemo_Click(object sender, EventArgs e)
            {

            }


	}
}
