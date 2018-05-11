using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using XCore;

namespace BZGUI.Module.Setting
{
    public enum LeftRingMachine
    { 
        左机,
        右机,
    }

    public class SettingFunc : XSetting
    {
        XmlHelper xml = new XmlHelper();
        public SettingFunc()
        {
            xml.SetPathAndRoot(Globals.Dir_SettingFunc, "Setting");
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

        [Category("空跑模式")]
        public bool 启用空跑模式
        {
            get { return bool.Parse(ReadValuByMapKeyName("IsEmptyRun", "False")); }
            set { settingMap["IsEmptyRun"] = value.ToString(); }
        }
        [Category("打开安全门")]
        public bool 打开安全门
        {
            get { return bool.Parse(ReadValuByMapKeyName("打开安全门", "False")); }
            set { settingMap["打开安全门"] = value.ToString(); }
        }
        [Category("打开SSH通信")]
        public bool 打开SSH通信
        {
            get { return bool.Parse(ReadValuByMapKeyName("打开SSH通信", "False")); }
            set { settingMap["打开SSH通信"] = value.ToString(); }
        }
        [Category("启用CPK模式")]
        public bool 启用CPK模式
        {
            get { return bool.Parse(ReadValuByMapKeyName("启用CPK模式", "False")); }
            set { settingMap["启用CPK模式"] = value.ToString(); }
        }

        [Category("PDCA")]
        public bool PDCA是否上传
        {
            get { return bool.Parse(ReadValuByMapKeyName("PDCA是否上传", "False")); }
            set { settingMap["PDCA是否上传"] = value.ToString(); }
        }

        [Category("ErrorCode上传")]
        public bool ErrorCode是否上传
        {
            get { return bool.Parse(ReadValuByMapKeyName("ErrorCode是否上传", "False")); }
            set { settingMap["ErrorCode是否上传"] = value.ToString(); }
        }
        [Category("TimeMode"), ReadOnly(true)]
        public bool TimeMode
        {
            get { return bool.Parse(ReadValuByMapKeyName("TimeMode", "True")); }//正常为1，TRUE
            set { settingMap["TimeMode"] = value.ToString(); }
        }
    }
}
