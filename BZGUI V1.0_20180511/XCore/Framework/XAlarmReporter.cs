using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;         //for File dir
using System.Diagnostics;//process

namespace XCore
{
    public sealed class XAlarmReporter
    {
        private XAlarmEventArgs currentAlarm = new XAlarmEventArgs();
        private readonly static XAlarmReporter instance = new XAlarmReporter();
        private bool IsAlarming = false;

        XAlarmReporter()
        {

        }

        public static XAlarmReporter Instance
        {
            get { return instance; }
        }

        public event Action<XAlarmEventArgs> OnSaveAlarmReport;
        public event Action<XAlarmEventArgs> OnAlarmCleared;

        public int PostAlarm(int taskId, XAlarmLevel alarmlevel, int Code, string category, string append)
        {
            try
            {
                if (alarmlevel != XAlarmLevel.RST)
                {
                    this.currentAlarm.TaskId = taskId;
                    this.currentAlarm.StartTime = DateTime.Now;
                    this.currentAlarm.AlarmLevel = alarmlevel;
                    this.currentAlarm.Code = Code;
                    this.currentAlarm.Category = category;
                    this.currentAlarm.Description = append;
                    if (OnSaveAlarmReport != null)OnSaveAlarmReport(this.currentAlarm);
                    IsAlarming = true;
                }
                else
                {
                    ClearAlarm();//clear alarm
                }
                return 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex, "");
                return -1;
            }
        }

        public XAlarmEventArgs CurrentAlarm
        {
            get { return currentAlarm; }
        }

        private  void ClearAlarm()
        {
            if (IsAlarming)
            {
                currentAlarm.Code = 2;//给复位用
                if (OnAlarmCleared != null)OnAlarmCleared(this.currentAlarm);
                IsAlarming = false;
            }
        }

    }
}