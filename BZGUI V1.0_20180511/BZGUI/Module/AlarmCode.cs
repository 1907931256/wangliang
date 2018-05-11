using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using XCore;

namespace BZGUI
{
    public enum AlarmCategory
    {
        VISION,
        LASER,
        SYSTEM,
        RESET,
        MOTION,
        IO,
    }

    public enum AlarmCode
    {
        急停 = 1,
        复位 = 2,
        正气压信号异常 =3,
        X伺服电机驱动器报警=4,
        Y伺服电机驱动器报警 = 5,
        条码阅读器通讯异常=6,
        载具进出气缸伸出信号异常=7,
        载具进出气缸缩回信号异常=8,
        PDCA通讯异常=9,
        运动板卡异常=10,
        凌华PCI9222板卡异常=11,
        相机通讯异常=12,
        SSH通讯异常=13,

    }
    [Serializable]
    public class AlarmRecord
    {
        public event Action OnAlarmRecord;

        private string xml = Globals.Dir_Record_Alarm + "\\AlarmRecord.xml";

        public string Xml
        {
            get{return xml;}         
            set { xml = value; }
        }

        public AlarmRecord()
        {
            AlarmCodeArr = new int[50];//50种报警
            Globals.comf.IsDirExist(Xml);//建立对应的文件夹
        }

        public int[] AlarmCodeArr { get; set; }

        public void UpdateAlarmRecord()
        {
            if (OnAlarmRecord != null)
            {
                OnAlarmRecord();
            }
        }

        public bool Save()
        {
            try
            {

                if (File.Exists(Xml) == false)
                {
                    if (Reset() == false)
                    {
                        return false;
                    }
                    return true;
                }
                XmlSerializer xs = new XmlSerializer(typeof(AlarmRecord));
                Stream stream = new FileStream(Xml, FileMode.Create, FileAccess.Write, FileShare.Read);
                xs.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public AlarmRecord Load()
        {
            try
            {
                if (File.Exists(Xml) == false)
                {
                    if (Reset() == false)
                    {
                        return null;
                    }
                }
                XmlSerializer xs = new XmlSerializer(typeof(AlarmRecord));
                Stream stream = new FileStream(Xml, FileMode.Open, FileAccess.Read, FileShare.Read);
                var ret = xs.Deserialize(stream) as AlarmRecord;
                stream.Close();
                return ret;
            }
            catch
            {
                return null;
            }
        }

        public bool Reset()
        {
            try
            {
                AlarmCodeArr = new int[50];//clear or rebuld data
                XmlSerializer xs = new XmlSerializer(typeof(AlarmRecord));
                Stream stream = new FileStream(Xml, FileMode.Create, FileAccess.Write, FileShare.Read);
                xs.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }


}
