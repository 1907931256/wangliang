using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using Microsoft.VisualBasic.PowerPacks;
using System.IO;
using System.IO.Ports;
using System.Text;


namespace BZGUI
{
    class ParaAxisFile
    {
        private readonly static ParaAxisFile instance = new ParaAxisFile();

        /// <summary>
        /// 构造函数
        /// </summary>
        public ParaAxisFile()
        { }

        public static ParaAxisFile Instance
        {
            get { return instance; }
        }

         /// <summary>
        /// 把1维参数转换成2维的机械参数
        /// </summary>
        /// <remarks></remarks>
        public void FresshMachinePar()
        {
            for (int i = 1; i <= Tools.Card1OfAxis; i++)
            {
                Tools.LeadLength[0, i] = PVar.ParAxis.Lead[i];
                Tools.GeerRate[0, i] = PVar.ParAxis.Ratio[i];
                Tools.PlusPerR[0, i] = PVar.ParAxis.pulse[i];
                Tools.AxisSpeed[0, i] = PVar.ParAxis.Speed[i];
            }

            for (int i = (Tools.Card1OfAxis + 1); i <= 12; i++)
            {
                Tools.LeadLength[1, i - Tools.Card1OfAxis] = PVar.ParAxis.Lead[i];
                Tools.GeerRate[1, i - Tools.Card1OfAxis] = PVar.ParAxis.Ratio[i];
                Tools.PlusPerR[1, i - Tools.Card1OfAxis] = PVar.ParAxis.pulse[i];
                Tools.AxisSpeed[1, i - Tools.Card1OfAxis] = PVar.ParAxis.Speed[i];
            }
        }


        //写DAT二进制文件
        //参数1：文件名(包含文件路径)
        //参数2：需要写入的数据
        public void WriteParAxis(string FileName, PVar.pAxis WriteData)
        {
            int Filenumber = 0;
            try
            {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FilePut(Filenumber, WriteData);
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
            catch
            {
                FileSystem.FileClose(Filenumber); //写入出错关闭当前打开的文件
            }
        }

        //读DAT二进制文件
        //参数1：文件名(包含文件路径)
        //参数2：读取的数据存储地址
        public void ReadParAxis(string FileName, System.ValueType ReadData)
        {
            int Filenumber = 0;
            try
            {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FileGet(Filenumber, ref ReadData);
                PVar.ParAxis = (PVar.pAxis)ReadData;
                FileSystem.FileClose(Filenumber); //读取完成关闭当前打开的文件
                PVar.IsReadParData = true;
            }
            catch
            {
                FileSystem.FileClose(Filenumber); //读取出错关闭当前打开的文件
            }
        }


    }
}
