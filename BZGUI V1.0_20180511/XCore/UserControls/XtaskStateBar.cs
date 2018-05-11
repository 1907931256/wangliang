using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCore
{
    public partial class XtaskStateBar : UserControl
    {
        private Color Red = Color.FromArgb(0xC8, 0x25, 0x06);
        private Color Green = Color.FromArgb(0xAE, 0xDA, 0x97);
        private int taskId = 1;

        public XtaskStateBar()
        {
            InitializeComponent();
        }

        public int TaskId
        {
            get { return taskId; }
            set
            {
                taskId = value;
                if (XTaskManager.Instance.FindTaskById(taskId) == null)
                {
                    return;
                }
                XTaskManager.Instance.Tasks[taskId].OnStationStateChanged += new Action<XTaskState>(BeginChangeText);
                XTaskManager.Instance.Tasks[taskId].OnStaShowCT += new Action<double>(BeginChangeText);
            }
        }

        private void BeginChangeText(XTaskState sts)
        {
            try
            {
                if (this.IsHandleCreated && (!this.IsDisposed))
                {
                    this.BeginInvoke(new Action<XTaskState>(ChangeText), new object[] { sts });
                }
            }
            catch
            {

            }
        }

        private void BeginChangeText(double CT)
        {
            try
            {
                if (this.IsHandleCreated && (!this.IsDisposed))
                {
                    this.BeginInvoke(new Action<double>(ChangeCT), new object[] { CT });
                }
            }
            catch
            {

            }
        }
        private void ChangeCT(double CT)
        {
            this.button2.Text = (CT/1000).ToString("f1")+"S";
        }

        private void ChangeText(XTaskState sts)
        {
            switch (sts)
            {
                case XTaskState.ESTOP:
                    button1.Text = "急停按下>>>等待复位";
                    this.button1.BackColor = Red;
                    break;
                case XTaskState.ALARM:
                    button1.Text = "发现报警>>>等待复位";
                    this.button1.BackColor = Red;
                    break;
                case XTaskState.PAUSE:
                    button1.Text = "暂停中>>>等待运行";
                    this.button1.BackColor = Green;
                    break;
                case XTaskState.RESETING:
                    button1.Text = "复位中>>>";
                    this.button1.BackColor = Color.Orange;
                    break;
                case XTaskState.RUNNING:
                    button1.Text = "运行中>>>";
                    this.button1.BackColor = Color.Orange;
                    break;
                case XTaskState.STOP:
                    button1.Text = XTaskManager.Instance.Tasks[taskId].HomeOK ? "正常停止>>>等待运行" : "异常停止>>>等待复位";
                    //button1.Text = "停止>>>等待复位";//停止不一定需要复位
                    this.button1.BackColor = XTaskManager.Instance.Tasks[taskId].HomeOK ?Green:Red;
                    break;
                case XTaskState.WAITRESET:
                    button1.Text = ">>>等待复位";
                    this.button1.BackColor = Red;
                    break;
                case XTaskState.WAITRUN:
                    button1.Text = ">>>等待运行";
                    this.button1.BackColor = Green;
                    break;
            }
        }

    }
}
