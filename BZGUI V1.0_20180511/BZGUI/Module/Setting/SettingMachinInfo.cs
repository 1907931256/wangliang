using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using XCore;

namespace BZGUI
{
    public enum WhichMachine
    {
        MMS,
        IPDM,
    }
    public enum Language
    {
        中文,
        English,
    }
    public class SettingMachineInfo:XSetting 
    {
        XmlHelper xml = new XmlHelper();
        public SettingMachineInfo()
        {
            xml.SetPathAndRoot(Globals.Dir_SettingMachineInfo, "Setting");
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

        [Category("设备信息")]
        public string 机器编号
        {
            //get { return settingMap["MachineID"]; }
            get { return ReadValuByMapKeyName("MachineID", "001"); }
            set { settingMap["MachineID"] = value; }
        }
        [Category("设备信息")]
        public WhichMachine 什么机器
        {
            get { return (WhichMachine)Int32.Parse(ReadValuByMapKeyName("什么机器", "0")); }
            set { settingMap["什么机器"] = ((int)value).ToString(); }
        }
        [Category("设备信息"),ReadOnly(true)]
        public Language 语言
        {
            get { return (Language)Int32.Parse(ReadValuByMapKeyName("语言", "1")); }
            set { settingMap["语言"] = ((int)value).ToString(); }
        }
        #region 设备设置
        [Category("设备设置")]
        public string Project
        {
            get { return ReadValuByMapKeyName("Project", "Mcloren"); }
            set { settingMap["Project"] = value; }
        }
        [Category("设备设置")]
        public string Vendor
        {
            get { return ReadValuByMapKeyName("Vendor", "BZ"); }
            set { settingMap["Vendor"] = value; }
        }
        [Category("设备设置")]
        public string BU
        {
            get { return ReadValuByMapKeyName("BU", "Foxconn"); }
            set { settingMap["BU"] = value; }
        }
        [Category("设备设置")]
        public string Floor
        {
            get { return ReadValuByMapKeyName("Floor", "C04-4F"); }
            set { settingMap["Floor"] = value; }
        }
        [Category("设备设置")]
        public string Line
        {
            get { return ReadValuByMapKeyName("Line", "Post"); }
            set { settingMap["Line"] = value; }
        }
        [Category("设备设置")]
        public string AEID
        {
            get { return ReadValuByMapKeyName("AEID", "OQC"); }
            set { settingMap["AEID"] = value; }
        }
        [Category("设备设置")]
        public string AESUB_ID
        {
            get { return ReadValuByMapKeyName("AESUB_ID", "IT-CG"); }
            set { settingMap["AESUB_ID"] = value; }
        }
        [Category("设备设置")]
        public string HardwareREV
        {
            get { return ReadValuByMapKeyName("HardwareREV", "BZ001"); }
            set { settingMap["HardwareREV"] = value; }
        }
        [Category("设备设置")]
        public string MachineSN
        {
            get { return ReadValuByMapKeyName("MachineSN", "BZ001"); }
            set { settingMap["MachineSN"] = value; }
        }
        [Category("设备设置")]
        public string ProductType
        {
            get { return ReadValuByMapKeyName("ProductType", "D21"); }
            set { settingMap["ProductType"] = value; }
        }
        #endregion

    }
}
