using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using XCore;

namespace BZGUI
{
    public class ToosingManager
    {
        private readonly static ToosingManager instance = new ToosingManager();
        public ToosingManager()
        {}
        public static ToosingManager Instance
        {
            get { return instance; }
        }

        public Dictionary<string, Toosing> ToosingMap = new Dictionary<string, Toosing>();

        public Dictionary<string, Toosing> Load()
        {
            ToosingMap.Clear();
            var names = Directory.GetFiles(Globals.Dir_Record_Tossing);
            if (names.Count() > 0)
            {
                for (int j = 0; j < names.Count(); j++)
                {
                    names[j] = names[j].Replace(Globals.Dir_Record_Tossing, "");
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
                    if (ToosingMap.ContainsKey(name) == false)
                    {
                        Toosing toosing = new Toosing();
                        toosing.Xml = Globals.Dir_Record_Tossing + name + ".xml"; ;
                        ToosingMap.Add(name, toosing.Load());
                    }
                }
                else
                {
                    if (ToosingMap.ContainsKey(name) == false)
                    {
                        Toosing toosing = new Toosing();
                        ToosingMap.Add(name, toosing);
                    }
                }

            }
            return ToosingMap;
        }

    }

    [Serializable]
    public class Toosing
    {
        public event Action OnToosing;
        private object obj = new object();
        private string xml = Globals.Dir_Record_Tossing + DateTime.Now.ToString("yyyyMMdd") + ".xml";
        public string Xml
        {
            get 
            {
                string path = Globals.Dir_Record_Tossing;
                Globals.comf.ExistFloder(path);
                return xml;
            }
            set { xml = value; }
        }
        private int val=0;
        public int Pick_Total { get { return val; } set { val = value; } }
        public int Pick_Capture_Fail { get; set; }
        public int Pick_Capture_OK { get; set; }
        public int Pick_Vaccum_Fail { get; set; }
        public int Pick_OK { get; set; }
        public int Assemble_Fail { get; set; }
        public int SN_Fail { get; set; }
        public int T3_1_Fail { get; set; }
        public int Align_Angle_Fail { get; set; }
        public int Align_XY_Fail { get; set; }
        public int T2_2_Fail { get; set; }

        public double Toosing_PickCapture
        {
            get
            {
                if (Pick_Total != 0)
                {
                    return double.Parse((100.00 * Pick_Capture_Fail / Pick_Total).ToString("f2"));
                }
                else
                {
                    return 0;
                }
            }
        }

        public double Toosing_PickVaccum
        {
            get
            {
                if (Pick_Capture_OK != 0)
                {
                    return double.Parse((100.00 * Pick_Vaccum_Fail / Pick_Capture_OK).ToString("f2"));
                }
                else
                {
                    return 0;
                }
            }
        }

        public double Toosing_Assemble
        {
            get
            {
                if (Pick_OK != 0)
                {
                    return double.Parse((100.00 * Assemble_Fail / Pick_OK).ToString("f2"));
                }
                else
                {
                    return 0;
                }
            }
        }

        public void UpdateToosing()
        {
            if (OnToosing != null)
            {
                OnToosing();
            }
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
                    XmlSerializer xs = new XmlSerializer(typeof(Toosing));
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

        public Toosing Load()
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
                    XmlSerializer xs = new XmlSerializer(typeof(Toosing));
                    Stream stream = new FileStream(Xml, FileMode.Open, FileAccess.Read, FileShare.Read);
                    return xs.Deserialize(stream) as Toosing;
                }
            }
            catch
            {
                return null;
            }
        }

        public bool Reset()
        {
            this.Pick_Total = 0;
            this.Pick_Capture_Fail = 0;
            this.Pick_Capture_OK = 0;
            this.Pick_Vaccum_Fail = 0;
            this.Pick_OK = 0;
            this.Assemble_Fail = 0;
            //......
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Toosing));
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
                xml = Globals.Dir_Record_Tossing + DateTime.Now.ToString("yyyyMMdd") + ".xml";
                if (File.Exists(Xml) == false)
                {
                    if (Reset() == false)
                    {
                        return false;
                    }

                } return true;
            }

        }


    }
}
