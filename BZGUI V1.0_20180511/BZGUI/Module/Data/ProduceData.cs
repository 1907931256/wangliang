using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace BZGUI
{

    public class ProduceData
    {
        private Queue TestData = new Queue();
        private int DATACount;

        /// <summary>
        /// 初始化数据
        /// </summary>
        public ProduceData()
        {
            TestData.Clear();
            DATACount = 50;
        }

        public void Adddata(string _testdata)//插入like  12,12.02,13.444,3.01,取出来的时候再变成数组
        {
            TestData.Enqueue(_testdata);
            if (TestData.Count > DATACount)
                TestData.Dequeue();
        }

        public void GetData(out string[] outdata)
        {
            string[] OutPutData = new string[TestData.Count];
            TestData.CopyTo(OutPutData, 0);
            outdata= OutPutData;
        }

        public void CleanData()
        {
            TestData.Clear();
        }


    }



}
