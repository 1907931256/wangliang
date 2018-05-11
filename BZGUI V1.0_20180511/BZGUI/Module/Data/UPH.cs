using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using XCore;

namespace BZGUI
{
    public class UPHManager
    {
        private readonly static UPHManager instance = new UPHManager();
        public UPHManager()
        { }
        public static UPHManager Instance
        {
            get { return instance; }
        }

        public Dictionary<string, UPH> UphMap = new Dictionary<string, UPH>();

        public Dictionary<string, UPH> Load()
        {
            UphMap.Clear();
            var names = Directory.GetFiles(Globals.Dir_Record_UPH);
            if (names.Count() > 0)
            {
                for (int j = 0; j < names.Count(); j++)
                {
                    names[j] = names[j].Replace(Globals.Dir_Record_UPH, "");
                    names[j] = names[j].Replace(".xml", "");//just remain like"20180122"
                    if (names[j].Length != 8)
                    {
                        names[j] = "";
                    }
                }
            }
            for (int i = 0; i < 30; i++)
            {
                var name = DateTime.Now.AddDays(-i).ToString("yyyyMMdd");//just read the last 30days toosing data
                if (names.Contains(name))
                {
                    if (UphMap.ContainsKey(name) == false)
                    {
                        UPH uph = new UPH();
                        uph.Xml = Globals.Dir_Record_UPH + name + ".xml"; ;
                        UphMap.Add(name, uph.Load());
                    }
                }
                else
                {
                    if (UphMap.ContainsKey(name) == false)
                    {
                        UPH uph = new UPH(); ;
                        UphMap.Add(name, uph);
                    }
                }

            }
            return UphMap;
        }

    }

    [Serializable]
    public class UPH
    {
        private object obj = new object();
        private string xml = Globals.Dir_Record_UPH + DateTime.Now.ToString("yyyyMMdd") + ".xml";
        public string Xml
        {
            get 
            {
                string path = Globals.Dir_Record_UPH;
                Globals.comf.ExistFloder(path);
                return xml; 
            }
            set { xml = value; }
        }

        private int[] m_UPH = new int[24];
        public int[] UPHDay
        {
            get { return m_UPH; }
            set { m_UPH = value; }
        }

        public int UPHtotalDay()
        {
            int m_tal = 0;
            for (int i = 0; i < m_UPH.Length; i++)
            {
                m_tal=m_tal+ m_UPH[i];
            }
            return m_tal;
        }

        private DateTime m_datT = new DateTime();
        public DateTime DatTime//no usefull，just for fun
        {
            get { return m_datT; }
            set { m_datT = value; }
        }

        public bool Save()
        {
            try
            {
                lock (obj)
                {

                    if (File.Exists(Xml) == false)
                    {
                        if (Reset() == false)
                        {
                            return false;
                        }
                        return true;
                    }
                    XmlSerializer xs = new XmlSerializer(typeof(UPH));
                    Stream stream = new FileStream(Xml, FileMode.Create, FileAccess.Write, FileShare.Read);
                    xs.Serialize(stream, this);
                    stream.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public UPH Load()
        {
            try
            {
                lock (obj)
                {
                    if (File.Exists(Xml) == false)
                    {
                        if (Reset() == false)
                        {
                            return null;
                        }
                    }
                    XmlSerializer xs = new XmlSerializer(typeof(UPH));
                    Stream stream = new FileStream(Xml, FileMode.Open, FileAccess.Read, FileShare.Read);
                    return xs.Deserialize(stream) as UPH;
                }
            }
            catch
            {
                return null;
            }
        }

        public bool Reset()//每次保存前判读一下，决定是否存到新的文件中取
        {
            m_datT = DateTime.Now;
            for (int i = 0; i < m_UPH.Length; i++)
            {
                m_UPH[i] = 0;
            }

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(UPH));
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

        public bool IsNeedReset()
        {
            lock (obj)
            {
                xml = Globals.Dir_Record_UPH + DateTime.Now.ToString("yyyyMMdd") + ".xml";
                if (File.Exists(Xml) == false)
                {
                    if (Reset() == false)
                    {
                        return false;
                    }

                } return true;
            }

        }

        /// <summary>
        /// update UPH:   UPHDay[i]++,i is the dayHour
        /// </summary>
        /// <returns></returns>
        public bool UPHupdate()  
        {
            int m_hour = DateTime.Now.Hour;
            m_UPH[m_hour]++;
            if (IsNeedReset())//判断一下是不是隔天了
            {
                Save();//没生产一个产品，更新保存一次
                return true;
            }
            else
            { return false; }
        }

        /// <summary>
        /// 当前小时的UPH
        /// </summary>
        /// <returns></returns>
        public int UPHcurrentHour()
        {
            int m_hour = DateTime.Now.Hour;
            return m_UPH[m_hour];
        }
    }
}
