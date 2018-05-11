using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Diagnostics;

namespace XCore
{    
    public sealed class XSettingManager
    {
        private static readonly XSettingManager instance = new XSettingManager();
        XSettingManager()
        {

        }
        public static XSettingManager Instance
        {
            get { return instance; }
        }

        private Dictionary<int, XSetting> settingMap = new Dictionary<int, XSetting>();

        public void BindSetting(int setId, XSetting setting, string name)
        {
            if (settingMap.ContainsKey(setId) == false)
            {
                setting.Name = name;
                settingMap.Add(setId, setting);
            }
        }

        public XSetting FindSettingById(int setId)
        {
            if (settingMap.ContainsKey(setId) == false)
            {
                return null;
            }
            return settingMap[setId];
        }

        public Dictionary<int, XSetting> SettingMap
        {
            get { return this.settingMap; }
        }

        public void LoadSettings()
        {
            foreach (XSetting setting in settingMap.Values)
            {
                setting.LoadSetting();
            }
        }
    }

    public class XSetting
    {
        protected ConcurrentDictionary<string, string> settingMap = new ConcurrentDictionary<string, string>();
        protected string path = "";
        protected string root = "";

        public void SetPathAndRoot(string path, string root)
        {
            this.path = path;
            this.root = root;
        }

        public string Name;

        public int LoadSetting()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode parent = doc.SelectSingleNode(root);
                if (parent == null)
                {
                    return 1;
                }
                XmlNodeList children = parent.ChildNodes;
                foreach (XmlElement child in children)
                {
                    settingMap.TryAdd(child.Name, child.InnerText);
                }
                return 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex, this.GetType().ToString());
                return -1;
            }
        }

        public int SaveSetting()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode parent = doc.SelectSingleNode(root);
                XmlNodeList children = parent.ChildNodes;
                foreach (XmlElement xe in children)
                {
                    foreach (KeyValuePair<string, string> kvp in settingMap)
                    {
                        if (xe.Name == kvp.Key)
                        {
                            xe.InnerText = kvp.Value;
                        }
                    }
                }
                doc.Save(path);
                return 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex, this.GetType().ToString());
                return -1;
            }
        }

    }

}
