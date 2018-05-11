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
    public class YieldManager
    {

        private readonly static YieldManager instance = new YieldManager();
        public YieldManager()
        {
            // Load();
        }
        public static YieldManager Instance
        {
            get { return instance; }
        }

        public Dictionary<string, Yield> YieldMap = new Dictionary<string, Yield>();

        public Dictionary<string, Yield> Load()
        {
            YieldMap.Clear();
            var names = Directory.GetFiles(Globals.Dir_Record_Yield);
            if (names.Count() > 0)
            {
                for (int j = 0; j < names.Count(); j++)
                {
                    names[j] = names[j].Replace(Globals.Dir_Record_Yield, "");
                    names[j] = names[j].Replace(".xml", "");
                    if (names[j].Length != 8)
                    {
                        names[j] = "";
                    }
                }
            }
            for (int i = 0; i < 30; i++)
            {
                var name = DateTime.Now.AddDays(-i).ToString("yyyyMMdd");               
             
                if (names.Contains (name))
                {
                    if (YieldMap.ContainsKey(name) == false)
                    {
                        Yield yield = new Yield();
                        yield.Xml = Globals.Dir_Record_Yield + name + ".xml";
                        YieldMap.Add(name, yield.Load());
                    }
                }
                else
                {
                    if (YieldMap.ContainsKey(name) == false)
                    {
                        Yield yield = new Yield();
                        YieldMap.Add(name, yield);
                    }
                }

            }
            return YieldMap;
        }

    }
    [Serializable]
    public class Yield
    {
        private string xml = Globals.Dir_Record_Yield + DateTime.Now.ToString("yyyyMMdd") + ".xml";
        private object obj = new object();
        public string Xml
        {
            get 
            {
                string path = Globals.Dir_Record_Yield;
                Globals.comf.ExistFloder(path);
                return xml; 
            }
            set { xml = value; }
        }

        public int Total { get; set; }

        public int AssembledOK { get; set; }

        public int CheckedOK { get; set; }

        public double YieldRate
        {
            get
            {
                if (Total > 0)
                {
                    return double.Parse((100.00 * CheckedOK / Total).ToString("f2"));
                }
                else
                {
                    return 0;
                }
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

                    XmlSerializer xs = new XmlSerializer(typeof(Yield));
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

        public Yield Load()
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
                    XmlSerializer xs = new XmlSerializer(typeof(Yield));
                    Stream stream = new FileStream(Xml, FileMode.Open, FileAccess.Read, FileShare.Read);
                    return xs.Deserialize(stream) as Yield;
                }
            }
            catch
            {
                return null;
            }
        }

        public bool Reset()
        {
            this.Total = 0;
            this.AssembledOK = 0;
            this.CheckedOK = 0;

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Yield));
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
                xml = Globals.Dir_Record_Yield + DateTime.Now.ToString("yyyyMMdd") + ".xml";
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

    [Serializable]
    public class CurrentYield
    {
        public string CurrentYieldXml
        {
            get 
            {
                string path = Globals.Dir_TempPara;
                Globals.comf.ExistFloder(path);
                return path + "CurrentYield.xml"; 
            }
        }
        public int CurrentTotal { get; set; }
        public int CurrentAssembledCheckOK { get; set; }
        public int MonthTotal { get; set; }
        public int MonthAssembledOK { get; set; }
        public int TotalLifeCycles { get; set; }//不清零的
        public int TotalLifeRejects { get; set; }
        
            

        public double CurrentYieldRate
        {
            get
            {
                if (CurrentTotal > 0)
                {
                    return double.Parse((100.00 * CurrentAssembledCheckOK / CurrentTotal).ToString("f2"));
                }
                else
                {
                    return 100;
                }
            }
        }

        public double MonthYieldRate
        {
            get
            {
                if (MonthTotal > 0)
                {
                    return double.Parse((100.00 * MonthAssembledOK / MonthTotal).ToString("f2"));
                }
                else
                {
                    return 100;
                }
            }
        }

        public bool SaveCurrentYield()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(CurrentYield));
                Stream stream = new FileStream(CurrentYieldXml, FileMode.Create, FileAccess.Write, FileShare.Read);
                xs.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public CurrentYield LoadCurrentYield()
        {
            try
            {
                if (File.Exists(CurrentYieldXml) == false)
                {
                    if (ResetCurrent(true, true) == false)
                    {
                        return null;
                    }
                }
                XmlSerializer xs = new XmlSerializer(typeof(CurrentYield));
                Stream stream = new FileStream(CurrentYieldXml, FileMode.Open, FileAccess.Read, FileShare.Read);
                return xs.Deserialize(stream) as CurrentYield;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 重置良率
        /// </summary>
        /// <param name="ResetToday">重置当天良率</param>
        /// <param name="ResetMonth">重置历史良率</param>
        /// <returns></returns>
        public bool ResetCurrent(bool ResetToday = true, bool ResetMonth = false)
        {
            if (ResetToday)
            {
                this.CurrentTotal = 0;
                this.CurrentAssembledCheckOK = 0;
            }
            if (ResetMonth)
            {
                this.MonthTotal = 0;
                this.MonthAssembledOK = 0;
            }

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(CurrentYield));
                Stream stream = new FileStream(CurrentYieldXml, FileMode.Create, FileAccess.Write, FileShare.Read);
                xs.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 生产一个后将PASS or FAIL 结果传进来，更新统计计数
        /// </summary>
        /// <param name="PASS">PASS为true  FAIL为false</param>
        public void AddOneResult(bool PASS)
        {
            if (PASS)
            {
                CurrentAssembledCheckOK++;
                MonthAssembledOK++;
                DataManager.Instance.yield.CheckedOK++;
            }
            else { TotalLifeRejects++; }//
            CurrentTotal++;
            MonthTotal++;
            TotalLifeCycles++;//
            SaveCurrentYield();
            DataManager.Instance.yield.Total++;
            DataManager.Instance.yield.Save();
        }

        /// <summary>
        /// rtn the ProduceNum,0is OK,1 is total
        /// </summary>
        /// <returns></returns>
        public int[] GetCurrentProduceNum()
        {
            int[] rtn=new int[2];
            rtn[0] = CurrentAssembledCheckOK;
            rtn[1] = CurrentTotal;
            return rtn;
        }
    }
}
