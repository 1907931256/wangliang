using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using XCore;


namespace BZGUI.Module.Setting
{
    public class SettingLaser:XSetting 
    {
        XmlHelper xml = new XmlHelper();
        public SettingLaser()
        {
            xml.SetPathAndRoot(Globals.Dir_SettingLaser, "Setting");
        }

        /// <summary>
        /// 读Map里面具体参数
        /// </summary>
        /// <param name="MapKeyName">参数关键字</param>
        /// <param name="DefaultValue">没有时写入返回默认值</param>
        /// <returns>返回的参数值</returns>
        private string ReadValuByMapKeyName(string MapKeyName, string DefaultValue)
        {
            try { return settingMap[MapKeyName]; }
            catch { return xml.XML_Read(MapKeyName, DefaultValue); };
        }

        [Category("Laser校正"), ReadOnly(true)]
        public double Laser_p0
        {
            get { return double.Parse(ReadValuByMapKeyName("Laser_p0", "0")); }
            set { settingMap["Laser_p0"] = value.ToString(); }
        }
        [Category("Laser校正"), ReadOnly(true)]
        public double Laser_p1
        {
            get { return double.Parse(ReadValuByMapKeyName("Laser_p1", "0")); }
            set { settingMap["Laser_p1"] = value.ToString(); }
        }
        [Category("Laser校正"), ReadOnly(true)]
        public double Laser_p2
        {
            get { return double.Parse(ReadValuByMapKeyName("Laser_p2", "0")); }
            set { settingMap["Laser_p2"] = value.ToString(); }
        }
        [Category("Laser校正"), ReadOnly(true)]
        public double Laser_p3
        {
            get { return double.Parse(ReadValuByMapKeyName("Laser_p3", "0")); }
            set { settingMap["Laser_p3"] = value.ToString(); }
        }
        [Category("Laser校正"), ReadOnly(true)]
        public double Laser_p4
        {
            get { return double.Parse(ReadValuByMapKeyName("Laser_p4", "0")); }
            set { settingMap["Laser_p4"] = value.ToString(); }
        }

    }
}
