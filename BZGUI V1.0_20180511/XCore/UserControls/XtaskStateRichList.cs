using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BZappdll;

namespace XCore
{
    public partial class XtaskStateRichList : UserControl
    {
        private int taskId = 1;
        private string taskName;
        CsvHelper csv = new CsvHelper();

        public XtaskStateRichList()
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
                taskName = XTaskManager.Instance.FindTaskById(taskId).Name;
                this.label1.Text = taskName + ":";
                XTaskManager.Instance.FindTaskById(taskId).OnStep += new Action<string, Color>(BeginShow);
                XTaskManager.Instance.FindTaskById(taskId).OnStepNum += new Action<int>(BeginNumShow);
                XTaskManager.Instance.Tasks[taskId].OnStaShowCT += new Action<double>(BeginChangeText);
            }
        }

        public void BeginShow(string step, Color color)
        {
            try
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action<string, Color>(Show), new object[] { step, color });
                }
            }
            catch
            {

            }
        }

        private void Show(string step, Color color)
        {
            string str = DateTime.Now.ToString("◆[HH:mm:ss]") + ":" + step;
            if (step.ToUpper() == "CLEAR")
            {
                this.xListBox1.Clear() ;
            }
            else if (step.ToUpper() == "SAVE")
            {
                //save log
                string path = XTaskManager.Instance.FindTaskById(taskId).LogPath + "_" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
                string strlist ="";
                for (int i = 0; i < xListBox1.Items.Count; i++)
                {
                    strlist += xListBox1.Items[i] + "\r\n";   
                }
                csv.WriteStringToCsv(path, strlist);
                //this.xListBox1.Clear();
            }
            else
            {
                Color MyNone = Color.FromArgb(0xEA, 0xEA, 0xEB);
                if (color == MyNone) color = Color.Black;//在界面上显示颜色不对
                this.xListBox1.AddLog(str, color);
            }

        }

        public void BeginNumShow(int stepNum)
        {
            try
            {
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action<int>(ShowNum), new object[] { stepNum });
                }
            }
            catch
            {

            }
        }

        private void ShowNum(int Stepnum)
        {
            this.label2.Text = Stepnum.ToString();
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
            this.CT.Text = (CT / 1000).ToString("f1") + "S";
        }
    }
}
