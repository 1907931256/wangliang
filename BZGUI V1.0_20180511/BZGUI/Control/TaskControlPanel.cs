using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore;

namespace BZGUI
{
    public partial class TaskControlPanel : UserControl
    {
        private int taskId = 1;
        public TaskControlPanel()
        {
            InitializeComponent();
            //this.MaximumSize = this.Size;
            //this.MinimumSize = this.Size;
        }

        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            PVar.MacHold = false;
            if (XTaskManager.Instance.FindTaskById(taskId).xState == XTaskState.PAUSE)
            { XTaskManager.Instance.FindTaskById(taskId).SetState(XTaskState.RUNNING); }
            else
            { XTaskManager.Instance.FindTaskById(TaskId).AutoRunstep = 10; } 

            if (Globals.settingFunc.启用空跑模式)
            { XTaskManager.Instance.FindTaskById(TaskId).TaskStart(StationRunMode.空跑);}
            else
            {XTaskManager.Instance.FindTaskById(TaskId).TaskStart(StationRunMode.自动运行);}    
        }

        private void button_Pause_Click(object sender, EventArgs e)
        {
            PVar.MacHold = true;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            XTaskManager.Instance.FindTaskById(TaskId).TaskReset();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            XTaskManager.Instance.FindTaskById(TaskId).TaskStop();
        }

        private void TaskControlPanel_Resize(object sender, EventArgs e)
        {
            //this.MaximumSize = this.Size;
            //this.MinimumSize = this.Size;
        }
    }
}
