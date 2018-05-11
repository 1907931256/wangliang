using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace XCore
{
    /// <summary>
    /// XMLhelper--simple
    /// </summary>
    public sealed class XmlHelper
    {
        private string filePath = null;//XML文件的完整的路径和名称
        private string rootstr = null;         //用来捕捉APP的名字作为XML的跟目录名称
        private readonly static XmlHelper instance = new XmlHelper();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="path"></param>
        public XmlHelper()
        {
        }

        public static XmlHelper Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// 设置路径和根目录
        /// </summary>
        /// <param name="path">XML的全路径</param>
        /// <param name="root">XML参数的根目录</param>
        public void SetPathAndRoot(string path, string root)
        {
            this.filePath = path;
            this.rootstr = root;
            string[] Split = path.Split('\\');
            string filePath = string.Empty;
            try
            {
                if (!System.IO.File.Exists(filePath))
                {
                    for (int i = 0; i < Split.Length - 1; i++)
                    {
                        if (Split[i] != string.Empty)
                            filePath += Split[i] + "\\";
                    }
                    DirectoryInfo dir = new DirectoryInfo(filePath);
                    dir.Create();                  //创建文件夹
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 读XML
        /// </summary>
        /// <param name="XmlNode_1">第1个节点</param>
        /// <param name="XmlNode_2">第2个节点</param>
        /// <param name="sXmlElement">Key值</param>
        /// <param name="DefaultStr">写入默认值</param>
        /// <returns></returns>
        public string XML_Read(String XmlNode_1, String XmlNode_2, String sXmlElement, String DefaultStr)
        {
            try
            {
                return XML_ReadWriteRead(XmlNode_1, XmlNode_2, sXmlElement, DefaultStr);
            }
            catch
            {
                return DefaultStr;
            }
        }

        public string XML_Read(String sXmlElement, String DefaultStr)
        {
            try
            {
                return XML_ReadWriteRead(sXmlElement, DefaultStr);
            }
            catch
            {
                return DefaultStr;
            }
        }

        public string XML_Read(String XmlNode_1, String sXmlElement, String DefaultStr)
        {
            try
            {
                return XML_ReadWriteRead(XmlNode_1, sXmlElement, DefaultStr);
            }
            catch
            {
                return DefaultStr;
            }
        }

        /// <summary>
        /// 写XML
        /// </summary>
        /// <param name="XmlNode_1"></param>
        /// <param name="XmlNode_2"></param>
        /// <param name="sXmlElement"></param>
        /// <param name="DefaultStr"></param>
        /// <returns></returns>
        public bool XML_Write(String XmlNode_1, String XmlNode_2, String sXmlElement, String Value)
        {
            try
            {
                XML_ReadWriteWrite(XmlNode_1, XmlNode_2, sXmlElement, Value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XML_Write(String XmlNode_1, String sXmlElement, String Value)
        {
            try
            {
                XML_ReadWriteWrite(XmlNode_1, sXmlElement, Value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XML_Write(String sXmlElement, String Value)
        {
            try
            {
                XML_ReadWriteWrite(sXmlElement, Value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 自动创建XML文件
        /// </summary>
        /// <returns></returns>
        private bool XML_Creat()
        {
            try
            {
                XmlTextWriter xmlWriter = new XmlTextWriter(filePath, Encoding.Default);//创建一个xml文档
                xmlWriter.Formatting = Formatting.Indented;                             //自动缩进
                xmlWriter.WriteStartDocument(true);                                     //开始一个文档 自动编写版本并具有独立属性的XML声明
                xmlWriter.WriteStartElement(rootstr);                                   //开始根元素
                xmlWriter.WriteEndElement();                                            //关闭根元素
                xmlWriter.WriteEndDocument();                                           //'文档结束
                xmlWriter.Flush();
                xmlWriter.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// XML读1级的值，没有的话，自动写入默认值
        /// </summary>
        /// <param name="sXmlElement">具体参数的Key值</param>
        /// <param name="DefaultStr">写入的默认值</param>
        /// <returns></returns>
        private string XML_ReadWriteRead(String sXmlElement, String DefaultStr)
        {
            string rtnstring = "";
            try
            {
                if (System.IO.File.Exists(filePath) == false)// 'XML文件不存在就创建
                {
                    if (XML_Creat() == false)
                    { return "Error Create XML"; }
                }
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode New_Root = xmlDoc.SelectSingleNode(rootstr);
                XmlElement New_XmlElement = null;

                if (New_Root == null)//[父节点1]不存在 创建一个从[父节点1]开始的完整的节点
                {
                    New_Root = xmlDoc.CreateElement(rootstr);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_Root.AppendChild(New_Root);
                    rtnstring = DefaultStr;
                }

                XmlNode ElementPath = xmlDoc.SelectSingleNode(rootstr + "/" + sXmlElement);
                if (ElementPath == null)//'[子节点]不存在 创建[子节点]
                {
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_Root.AppendChild(New_XmlElement);
                    rtnstring = DefaultStr;
                }
                else       // '[子节点]存在 判断是读取还是写入
                {
                    rtnstring = New_Root.SelectSingleNode(sXmlElement).InnerText;
                }
                xmlDoc.Save(filePath);
                return rtnstring;
            }
            catch
            {
                return "Error";
            }

        }

        //XML读2级 重载
        private string XML_ReadWriteRead(String XmlNode_1, String sXmlElement, String DefaultStr)
        {
            string rtnstring = "";
            try
            {
                if (System.IO.File.Exists(filePath) == false)// 'XML文件不存在就创建
                {
                    if (XML_Creat() == false)
                    { return "Error Create XML"; }
                }
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode New_Root = xmlDoc.SelectSingleNode(rootstr);
                XmlElement New_XmlNode_1 = null;
                XmlElement New_XmlElement = null;

                XmlNode NodePath_1 = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1);

                if (NodePath_1 == null)//[父节点1]不存在 创建一个从[父节点1]开始的完整的节点
                {
                    New_XmlNode_1 = xmlDoc.CreateElement(XmlNode_1);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_Root.AppendChild(New_XmlNode_1);
                    rtnstring = DefaultStr;
                }

                XmlNode ElementPath = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1 + "/" + sXmlElement);
                if (ElementPath == null)//'[子节点]不存在 创建[子节点]
                {
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_Root.SelectSingleNode(XmlNode_1).AppendChild(New_XmlElement);
                    rtnstring = DefaultStr;
                }
                else       // '[子节点]存在 判断是读取还是写入
                {
                    rtnstring = New_Root.SelectSingleNode(XmlNode_1).SelectSingleNode(sXmlElement).InnerText;
                }
                xmlDoc.Save(filePath);
                return rtnstring;
            }
            catch
            {
                return "Error";
            }

        }

        //XML读3级 重载
        private string XML_ReadWriteRead(String XmlNode_1, String XmlNode_2, String sXmlElement, String DefaultStr)
        {
            string rtnstring = "";
            try
            {
                if (System.IO.File.Exists(filePath) == false)// 'XML文件不存在就创建
                {
                    if (XML_Creat() == false)
                    { return "Error Create XML"; }
                }
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode New_Root = xmlDoc.SelectSingleNode(rootstr);
                XmlElement New_XmlNode_1 = null;
                XmlElement New_XmlNode_2 = null;
                XmlElement New_XmlElement = null;

                XmlNode NodePath_1 = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1);

                if (NodePath_1 == null)//[父节点1]不存在 创建一个从[父节点1]开始的完整的节点
                {
                    New_XmlNode_1 = xmlDoc.CreateElement(XmlNode_1);
                    New_XmlNode_2 = xmlDoc.CreateElement(XmlNode_2);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_XmlNode_2.AppendChild(New_XmlElement);
                    New_XmlNode_1.AppendChild(New_XmlNode_2);
                    New_Root.AppendChild(New_XmlNode_1);
                    rtnstring = DefaultStr;
                }

                XmlNode NodePath_2 = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1 + "/" + XmlNode_2);
                if (NodePath_2 == null)//[父节点2]不存在 创建一个从[父节点2]开始的完整的节点
                {
                    New_XmlNode_2 = xmlDoc.CreateElement(XmlNode_2);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_XmlNode_2.AppendChild(New_XmlElement);
                    New_Root.SelectSingleNode(XmlNode_1).AppendChild(New_XmlNode_2);
                    rtnstring = DefaultStr;
                }

                XmlNode ElementPath = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1 + "/" + XmlNode_2 + "/" + sXmlElement);
                if (ElementPath == null)//'[子节点]不存在 创建[子节点]
                {
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = DefaultStr;
                    New_Root.SelectSingleNode(XmlNode_1).SelectSingleNode(XmlNode_2).AppendChild(New_XmlElement);
                    rtnstring = DefaultStr;
                }
                else       // '[子节点]存在 判断是读取还是写入
                {
                    rtnstring = New_Root.SelectSingleNode(XmlNode_1).SelectSingleNode(XmlNode_2).SelectSingleNode(sXmlElement).InnerText;
                }
                xmlDoc.Save(filePath);
                return rtnstring;
            }
            catch
            {
                return "Error";
            }

        }

        //重载1级写入
        private bool XML_ReadWriteWrite(String sXmlElement, String Value)
        {
            try
            {
                if (System.IO.File.Exists(filePath) == false)// 'XML文件不存在就创建
                {
                    if (XML_Creat() == false)
                        return false;
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode New_Root = xmlDoc.SelectSingleNode(rootstr);
                XmlElement New_XmlElement = null;

                if (New_Root == null)//[父节点1]不存在 创建一个从[父节点1]开始的完整的节点
                {
                    New_Root = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                }

                XmlNode ElementPath = xmlDoc.SelectSingleNode(rootstr + "/" + sXmlElement);
                if (ElementPath == null)//'[子节点]不存在 创建[子节点]
                {
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                    New_Root.AppendChild(New_XmlElement);
                }
                New_Root.SelectSingleNode(sXmlElement).InnerText = Value;//写入值
                xmlDoc.Save(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //重载2级写入
        private bool XML_ReadWriteWrite(String XmlNode_1, String sXmlElement, String Value)
        {
            try
            {
                if (System.IO.File.Exists(filePath) == false)// 'XML文件不存在就创建
                {
                    if (XML_Creat() == false)
                        return false;
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode New_Root = xmlDoc.SelectSingleNode(rootstr);
                XmlElement New_XmlNode_1 = null;
                XmlElement New_XmlElement = null;
                XmlNode NodePath_1 = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1);

                if (NodePath_1 == null)//[父节点1]不存在 创建一个从[父节点1]开始的完整的节点
                {
                    New_XmlNode_1 = xmlDoc.CreateElement(XmlNode_1);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                    New_Root.AppendChild(New_XmlNode_1);
                }

                XmlNode ElementPath = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1 + "/" + sXmlElement);
                if (ElementPath == null)//'[子节点]不存在 创建[子节点]
                {
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                    New_Root.SelectSingleNode(XmlNode_1).AppendChild(New_XmlElement);
                }
                New_Root.SelectSingleNode(XmlNode_1).SelectSingleNode(sXmlElement).InnerText = Value;//写入值
                xmlDoc.Save(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //重载3级写入
        private bool XML_ReadWriteWrite(String XmlNode_1, String XmlNode_2, String sXmlElement, String Value)
        {
            try
            {
                //    Call IsDirExits()
                if (System.IO.File.Exists(filePath) == false)// 'XML文件不存在就创建
                {
                    if (XML_Creat() == false)
                        return false;
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNode New_Root = xmlDoc.SelectSingleNode(rootstr);
                XmlElement New_XmlNode_1 = null;
                XmlElement New_XmlNode_2 = null;
                XmlElement New_XmlElement = null;
                XmlNode NodePath_1 = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1);

                if (NodePath_1 == null)//[父节点1]不存在 创建一个从[父节点1]开始的完整的节点
                {
                    New_XmlNode_1 = xmlDoc.CreateElement(XmlNode_1);
                    New_XmlNode_2 = xmlDoc.CreateElement(XmlNode_2);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                    New_XmlNode_2.AppendChild(New_XmlElement);
                    New_XmlNode_1.AppendChild(New_XmlNode_2);
                    New_Root.AppendChild(New_XmlNode_1);
                }

                XmlNode NodePath_2 = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1 + "/" + XmlNode_2);
                if (NodePath_2 == null)//[父节点2]不存在 创建一个从[父节点2]开始的完整的节点
                {
                    New_XmlNode_2 = xmlDoc.CreateElement(XmlNode_2);
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                    New_XmlNode_2.AppendChild(New_XmlElement);
                    New_Root.SelectSingleNode(XmlNode_1).AppendChild(New_XmlNode_2);
                }

                XmlNode ElementPath = xmlDoc.SelectSingleNode(rootstr + "/" + XmlNode_1 + "/" + XmlNode_2 + "/" + sXmlElement);
                if (ElementPath == null)//'[子节点]不存在 创建[子节点]
                {
                    New_XmlElement = xmlDoc.CreateElement(sXmlElement);
                    New_XmlElement.InnerText = Value;
                    New_Root.SelectSingleNode(XmlNode_1).SelectSingleNode(XmlNode_2).AppendChild(New_XmlElement);
                }
                New_Root.SelectSingleNode(XmlNode_1).SelectSingleNode(XmlNode_2).SelectSingleNode(sXmlElement).InnerText = Value;//写入值
                xmlDoc.Save(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

}
