using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using XCore;

namespace BZGUI.Module.Setting
{
    public class SettingPara : XSetting
    {
        XmlHelper xml = new XmlHelper();
        public SettingPara()
        {
            xml.SetPathAndRoot(Globals.Dir_SettingPara, "Setting");
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
        #region about_SSH
        [Category("SSH相关")]
        public string SSH远程IP地址
        {
            get { return ReadValuByMapKeyName("SSH远程IP地址", "169.254.1.66"); }
            set { settingMap["SSH远程IP地址"] = value.ToString(); }     
        }
        [Category("SSH相关")]
        public string SSH用户名
        {
            get { return ReadValuByMapKeyName("SSH用户名", "gdlocal"); }
            set { settingMap["SSH用户名"] = value.ToString(); }
        }
        [Category("SSH相关")]
        public string SSH密码
        {
            get { return ReadValuByMapKeyName("SSSH密码", "gdlocal"); }
            set { settingMap["SSH密码"] = value.ToString(); }
        }
        [Category("SSH相关")]
        public string SSH脚本名字
        {
            get { return ReadValuByMapKeyName("SSH脚本名字", "RunningMotorLEFT.txt"); }
            set { settingMap["SSH脚本名字"] = value.ToString(); }
        }
        [Category("SSH相关"), ReadOnly(true)]
        public bool Routine1状态
        {
            get { return bool.Parse(ReadValuByMapKeyName("Routine1状态", "True")); }
            set { settingMap["Routine1状态"] = value.ToString(); }
        }
        [Category("SSH相关"), ReadOnly(true)]
        public bool Routine2状态
        {
            get { return bool.Parse(ReadValuByMapKeyName("Routine2状态", "False")); }
            set { settingMap["Routine2状态"] = value.ToString(); }
        }
        [Category("SSH相关"), ReadOnly(true)]
        public bool Routine3状态
        {
            get { return bool.Parse(ReadValuByMapKeyName("Routine3状态", "False")); }
            set { settingMap["Routine3状态"] = value.ToString(); }
        }
        [Category("SSH相关")]
        public string Routine1_path
        {
            get { return ReadValuByMapKeyName("Routine1_path", "/Users/gdlocal/Desktop/MMS/Routine1"); }
            set { settingMap["Routine1_path"] = value.ToString(); }
        }
        [Category("SSH相关")]
        public string Routine2_path
        {
            get { return ReadValuByMapKeyName("Routine2_path", "/Users/gdlocal/Desktop/MMS/Routine2"); }
            set { settingMap["Routine2_path"] = value.ToString(); }
        }
        [Category("SSH相关")]
        public string Routine3_path
        {
            get { return ReadValuByMapKeyName("Routine3_path", "/Users/gdlocal/Desktop/MMS/Routine3"); }
            set { settingMap["Routine3_path"] = value.ToString(); }
        }
        #endregion

        [Category("扫描抢")]
        public string Scanner_IP
        {
            get { return ReadValuByMapKeyName("扫描抢_IP", "192.168.1.1"); }
            set { settingMap["扫描抢_IP"] = value; }
        }
        [Category("超时")]
        public double 测试超时
        {
            get { return double.Parse(ReadValuByMapKeyName("测试超时", "10")); }
            set { settingMap["测试超时"] = value.ToString(); }
        }

        [Category("条码相关")]
        public string 学习条码长度
        {
            get { return ReadValuByMapKeyName("学习条码长度", "AD581070042HP0MA8"); }
            set { settingMap["学习条码长度"] = value; }
        }

    }
}
