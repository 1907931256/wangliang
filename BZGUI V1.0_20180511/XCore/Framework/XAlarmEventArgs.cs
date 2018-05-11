using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCore
{
    public class XAlarmEventArgs : EventArgs
    {
        private int code;
        private string category;
        private string description;
        public XAlarmEventArgs()
        {

        }

        public int Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public int TaskId { get; set; }

        public DateTime StartTime { get; set; }

        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public TimeSpan Duration { get; set; }
        public XAlarmLevel AlarmLevel { get; set; }
        public string dt_Errorcode { get; set; }

    }
}
