using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Utilities;
using XCore;

namespace BZGUI
{
    public partial class AlarmChart : UserControl
    {
        private DataPoint[] dataPoints;

        private int[] Pts;

        public AlarmChart()
        {
            InitializeComponent();
        }

        public int[] DataShowCode
        {
            set
            {
                Pts = value;
                UpdateChartDatas();
            }
        }

        private void UpdateChartDatas()
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new Action(() =>
            {
                try
                {
                    var i = 0;
                    dataPoints = new DataPoint[Pts.Length];
                    chart1.Series[0].Points.Clear();
                    foreach (var item in Pts)
                    {

                        if (item > 0)
                        {
                            dataPoints[i] = new DataPoint(0, (double)item);
                            dataPoints[i].LegendText = ((AlarmCode)i).ToString();

                            dataPoints[i].MarkerStyle = MarkerStyle.Circle;
                            chart1.Series[0].Points.Add(dataPoints[i]);
                        }

                        i++;
                    }
                }
                catch (Exception)
                {
                }

            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定需要清除历史记录？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataManager.Instance.alarmRecord.Reset();
                DataShowCode = DataManager.Instance.alarmRecord.AlarmCodeArr;//Pi图显示
            }
        }

        private void btn_load_Click(object sender, System.EventArgs e)
        {
            DataShowCode = DataManager.Instance.alarmRecord.AlarmCodeArr;//Pi图显示
        }

        private void AlarmChart_Load(object sender, System.EventArgs e)
        {
            DataShowCode = DataManager.Instance.alarmRecord.AlarmCodeArr;//Pi图显示
        }

        private void chart1_VisibleChanged(object sender, System.EventArgs e)
        {
            if(Visible)
                DataShowCode = DataManager.Instance.alarmRecord.AlarmCodeArr;//Pi图显示
        }
    }
}
