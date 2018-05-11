using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using XCore;
using BZappdll;

namespace BZGUI
{
    [Serializable]
    public class LoginCtr
    {
        public string Xml
        {
            get { return PVar.BZ_ParameterPath + "\\Setting\\Login.xml"; }
        }

        public string AdminUser { get; set; }
        public string AdminPwd { get; set; }


        public string TecUser { get; set; }
        public string TecPwd { get; set; }

        public string opUser { get; set; }
        public string opPwd { get; set; }

        public string BuildDate { get; set; }
        public string HWVision { get; set; }
        public string SWUpdate { get; set; }

        public bool Save()
        {
            try
            {
                if (!File.Exists(DataManager.Instance.Login.Xml))
                {
                    Globals.comf.IsDirExist(DataManager.Instance.Login.Xml);//自动创建文件夹
                    AdminUser = "软件工程师";
                    AdminPwd = "BZMMS";

                    TecUser = "BOTECH";
                    TecPwd = "1";

                    opUser = "OP";
                    opPwd = " ";


                    HWVision = "VJ1.0.1";
                    BuildDate = "2018.04.21";
                    SWUpdate = "2018.04.21";

                }
                XmlSerializer xs = new XmlSerializer(typeof(LoginCtr));
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

        public LoginCtr Load()
        {
            try
            {
                if (File.Exists(Xml) == false)
                {
                    Save();
                }
                XmlSerializer xs = new XmlSerializer(typeof(LoginCtr));
                Stream stream = new FileStream(Xml, FileMode.Open, FileAccess.Read, FileShare.Read);
                var ret = xs.Deserialize(stream) as LoginCtr;
                stream.Close();

                return ret;
            }
            catch
            {
                return this;
            }
        }


    }
}
