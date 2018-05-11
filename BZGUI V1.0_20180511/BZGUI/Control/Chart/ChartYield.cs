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
using BZappdll;

namespace BZGUI
{
    public partial class ChartYield : UserControl
    {
        Legend legend1 = new Legend();
        Series series1 = new Series();
        DataPoint dataPoint1 = new DataPoint(0D, 100D);
        DataPoint dataPoint2 = new DataPoint(0D, 60D);
        DataPoint dataPoint3 = new DataPoint(0D, 40D);
        Series series2 = new Series();
        DataPoint dataPoint4 = new DataPoint(0D, 50D);
        DataPoint dataPoint5 = new DataPoint(0D, 50D);
        Series series3 = new Series();
        DataPoint dataPoint6 = new DataPoint(0D, 9D);

        public ChartYield()
        {
            InitializeComponent();
            #region Yield setup
            this.Chart1.BackGradientStyle = GradientStyle.TopBottom;
            this.Chart1.BorderlineDashStyle = ChartDashStyle.Dash;
            this.Chart1.BorderlineWidth = 0;
            this.Chart1.IsSoftShadows = false;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(7, 3);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = ChartColorPalette.None;


            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.ChartType = SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Default";
            series1.Name = "Series1";
            dataPoint1.BorderWidth = 0;
            dataPoint1.Color = System.Drawing.Color.White;
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint2.Color = System.Drawing.Color.LimeGreen;
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint3.Color = System.Drawing.Color.Red;
            dataPoint3.IsValueShownAsLabel = false;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.ShadowOffset = 2;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series2.ChartType = SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Enabled = false;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Default";
            series2.Name = "Series2";
            dataPoint4.Color = System.Drawing.Color.LimeGreen;
            dataPoint4.IsValueShownAsLabel = false;
            dataPoint5.Color = System.Drawing.Color.Red;
            dataPoint5.IsValueShownAsLabel = false;
            series2.Points.Add(dataPoint1);
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.ShadowOffset = 2;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series3.ChartType = SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series3.Enabled = false;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Default";
            series3.Name = "Series3";

            dataPoint6.BorderColor = System.Drawing.Color.Red;
            dataPoint6.Color = System.Drawing.Color.Red;
            dataPoint6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint6.IsValueShownAsLabel = false;
            dataPoint6.LabelForeColor = System.Drawing.Color.White;
            dataPoint6.Label = "";
            series3.Points.Add(dataPoint6);
            series3.ShadowOffset = 2;
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(378, 278);
            this.Chart1.TabIndex = 1;


            this.Controls.Add(this.Chart1);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);



            CreateChartArea(0, "Area1", false);
            Chart1.Series["Series1"].ChartArea = "Area1";
            Chart1.Series["Series1"]["DoughnutRadius"] = "28";
            Chart1.Series["Series2"].IsValueShownAsLabel = false;
            Chart1.Series["Series2"].Label = "#PERCENT{P0}";
            Chart1.Series["Series3"].IsValueShownAsLabel = false;
            Chart1.Series["Series3"].Label = "#PERCENT{P0}";

            CreateChartArea(1, "Area2", false);
            CreateChartArea(2, "Area3", false);

            Chart1.ChartAreas["Area1"].Area3DStyle.Rotation = 0;
            Chart1.ChartAreas["Area2"].Area3DStyle.Rotation = 0;

            Chart1.Series["Series1"].BorderWidth = 0;
            Chart1.Series["Series1"].ChartArea = "Area1";
            Chart1.Series["Series2"].BorderWidth = 0;
            Chart1.Series["Series3"].BorderWidth = 0;
            Chart1.Series["Series2"].ChartArea = "Area2";
            Chart1.Series["Series3"].ChartArea = "Area3";

            Chart1.Series["Series2"]["DoughnutRadius"] = "40";

            Chart1.Series["Series2"].Enabled = true;

            Chart1.Series["Series3"].Enabled = true;
            Chart1.Series["Series3"]["DoughnutRadius"] = "40";
            Chart1.Series["Series3"].ChartType = SeriesChartType.Pie;

            Clear();
            #endregion
        }

        public void setOK_NG(string result)
        {
            if (result=="OK")
            {
                dataPoint6.Color = System.Drawing.Color.LimeGreen;
                this.label2.BackColor = System.Drawing.Color.LimeGreen;
                this.label2.Text = "OK";
            }
            else if(result=="NG")
            {
                dataPoint6.Color = System.Drawing.Color.Red;
                this.label2.BackColor = System.Drawing.Color.Red;
                this.label2.Text = "NG";
            }
            else
            {
                dataPoint6.Color = System.Drawing.Color.DeepSkyBlue;
                this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
                this.label2.Text = "----";
            }
            this.Lbl_StartTime.Text = DateTime.Now.AddDays(0).ToString("yyyyMMdd");
            this.Lbl_EndTime.Text = DateTime.Now.AddDays(-30).ToString("yyyyMMdd");
        }

        public double SetMonthOkRate
        {
            set
            {
                UpdateChartMonthOkRate(value);
            }
        }

        public double SetDayOkRate
        {
            set
            {
                var val = value;
                if (val >= 0 && val <= 100)
                {

                    UpdateChartDayOkRate(val);

                }
            }
        }

        public void Clear()
        {
            setOK_NG("OK");
            var val = 100;
            if (val >= 0 && val <= 100)
            {
                series2.Points.Clear();
                dataPoint1.Label = "";
                dataPoint1.YValues = new double[] { 100 };
                dataPoint4.YValues = new double[] { val };
                dataPoint5.YValues = new double[] { 100 - val };
                dataPoint5.Label = 1 * (100 - val) + "%";
                dataPoint4.Label = "";
                series2.Points.Add(dataPoint1);
                series2.Points.Add(dataPoint5);
                series2.Points.Add(dataPoint4);
            }

            if (val >= 0 && val <= 100)
            {
                series1.Points.Clear();
                dataPoint1.Label = "";
                dataPoint1.YValues = new double[] { 100 };
                dataPoint3.YValues = new double[] { 100 - val };
                dataPoint2.YValues = new double[] { val };
                dataPoint3.Label = 1 * (100 - val) + "%";
                series1.Points.Add(dataPoint1);
                series1.Points.Add(dataPoint3);
                series1.Points.Add(dataPoint2);
            };
        }

        private void UpdateChartDayOkRate(double val)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new Action(() =>
            {
                series2.Points.Clear();
                dataPoint1.Label = "";
                dataPoint1.YValues = new double[] { 100 };
                dataPoint4.YValues = new double[] { val };
                dataPoint5.YValues = new double[] { 100 - val };
                dataPoint5.Label = Math.Round(1 * (100 - val), 2) + "%";

                dataPoint4.Label = "";
                series2.Points.Add(dataPoint1);
                series2.Points.Add(dataPoint5);
                series2.Points.Add(dataPoint4);
            }));
        }

        private void UpdateChartMonthOkRate(double val)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new Action(() =>
            {

                if (val >= 0 && val <= 100)
                {
                    series1.Points.Clear();
                    dataPoint1.Label = "";
                    dataPoint1.YValues = new double[] { 100 };
                    dataPoint3.YValues = new double[] { 100 - val };
                    dataPoint2.YValues = new double[] { val };
                    dataPoint3.Label = Math.Round(1 * (100 - val), 2) + "%";
                    series1.Points.Add(dataPoint1);
                    series1.Points.Add(dataPoint3);
                    series1.Points.Add(dataPoint2);
                }

            }));
        }

        public void ClearChart()
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new Action(() =>
            { Clear(); }));
        }

        /// <summary>
        /// This method will create a ChartArea with a given name at a certain level
        /// </summary>
        private void CreateChartArea(int level, string AreaName, bool ShowBorder)
        {
            Chart1.ChartAreas.Add(AreaName);
            Chart1.ChartAreas[AreaName].BackColor = Color.Transparent;

            if (ShowBorder)
                Chart1.ChartAreas[AreaName].BorderWidth = 1;
            else
                Chart1.ChartAreas[AreaName].BorderWidth = 0;

            Chart1.ChartAreas[AreaName].InnerPlotPosition.Auto = false;
            Chart1.ChartAreas[AreaName].InnerPlotPosition.Height = 98;
            Chart1.ChartAreas[AreaName].InnerPlotPosition.Width = 98;
            Chart1.ChartAreas[AreaName].InnerPlotPosition.X = 1;
            Chart1.ChartAreas[AreaName].InnerPlotPosition.Y = 1;

            Chart1.ChartAreas[AreaName].Position.X = 2 + level * 14;
            Chart1.ChartAreas[AreaName].Position.Y = 2 + level * 14;
            Chart1.ChartAreas[AreaName].Position.Height = 90 - level * 28;
            Chart1.ChartAreas[AreaName].Position.Width = 90 - level * 28;

            Chart1.ChartAreas[AreaName].Area3DStyle.Enable3D = true;
            Chart1.ChartAreas[AreaName].Area3DStyle.Inclination = 0;


        }


    }
}
