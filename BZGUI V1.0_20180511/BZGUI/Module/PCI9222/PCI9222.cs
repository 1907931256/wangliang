using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZedGraph;
using BZappdll;

namespace BZGUI
{
    public partial class PCI9222 : Form
    {
        private ushort cardRegNumber;
        private IntPtr[] _ptr = new IntPtr[2];
        private ushort[] _bufferId = new ushort[2];
        IntPtr[] VBuffer = new IntPtr[1];
        uint AI_ReadCount = 500; /*AI Read Count*/
        PointPairList userCursorsList = new PointPairList();
        LineItem userCursorsCurve = new LineItem("userCursorsCurve");
        CallbackDelegate ai_buf_ready_cbdel;//回调
        public delegate void DisplayInvoke();
        public delegate void DisplayTrend(IntPtr data);
        int err;
        int bufindex;
        uint accesscnt;
        ushort Channel=4;
        ComSub comf = new ComSub();
        double[] mean1=new double[5];
        PointPairList[] listArray;
        GraphPane myPane;
        private bool Flag_start=false;
        private double[] LaserHight=new double[5];//取每次采集出来的额数据的最后5个数据，也是最新的数据

        public PCI9222()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            listArray = new PointPairList[Channel+1];

            //int[] count = new int[_mutilChannel];
            for (int i = 0; i < listArray.Length; i++)
            {
                listArray[i] = new PointPairList();
            }


            myPane = zedGraphControl1.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "波形图";
            myPane.XAxis.Title.Text = "time";
            myPane.YAxis.Title.Text = "distance";
            //myPane.YAxis.Scale.Max = 0.02;
            //myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.MaxAuto = true;
            myPane.XAxis.Scale.MagAuto = true;
            LineItem[] tmp_ai_wave_raw_curve = new LineItem[5];
            tmp_ai_wave_raw_curve[0] = myPane.AddCurve("laer_p0", listArray[0], Color.SaddleBrown, SymbolType.None);
            tmp_ai_wave_raw_curve[1] = myPane.AddCurve("laer_p1", listArray[1], Color.YellowGreen, SymbolType.None);
            tmp_ai_wave_raw_curve[2] = myPane.AddCurve("laer_p2", listArray[2], Color.MediumSeaGreen, SymbolType.None);
            tmp_ai_wave_raw_curve[3] = myPane.AddCurve("laer_p3", listArray[3], Color.Blue, SymbolType.None);
            tmp_ai_wave_raw_curve[4] = myPane.AddCurve("laer_p4", listArray[4], Color.MediumPurple, SymbolType.None);
            tmp_ai_wave_raw_curve[0].Line.Width = 2.0F;//设置线宽
            tmp_ai_wave_raw_curve[1].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[2].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[3].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[4].Line.Width = 2.0F;
        }

        private void PCI9222_Load(object sender, EventArgs e)
        {
            short ret = DASK.Register_Card(DASK.PCI_9222, 0);
            if (ret >= 0)
            {
                cardRegNumber = (ushort)ret;//Register_Card的时候，把卡号给cardRegNumber
            }
            else
            {
                MessageBox.Show("9222卡初始化失败！");
            }


            //ushort ConfigCtrl = DASK.P922x_AI_SingEnded | DASK.P922x_AI_CONVSRC_INT;//?差分在哪区分
            //ushort TrigCtrl = DASK.P922x_AI_TRGMOD_POST | DASK.P922x_AI_TRGSRC_SOFT;//?
            ushort ConfigCtrl = DASK.P922x_AI_Differential | DASK.P922x_AI_CONVSRC_INT; ;//?差分在哪区分
            ushort TrigCtrl = DASK.P922x_AI_TRGMOD_POST|DASK.P922x_AI_TRGSRC_SOFT; ;//?
            uint ReTriggerCount = 0; /*Ignore in Non-Retrigger*/


            bufindex = 0;//是用来两个交替读吗？
            //Channel = 4; /*AI Channel Number to be read*/
            //uint SampIntrv = 8000; /*Sampling Rate: P922X_TIMEBASE/320 = 250K Hz*/  //这个设置，如果要快一点，怎么设置，变小？
            //P922X_TIMEBASE  时钟，80000000，  intrv=80000000/5000=16000;5000为每秒5000个数据，每个通道1000个数据/s  
            uint SampIntrv = 16000; /*Sampling Rate: P922X_TIMEBASE/320 = 250K Hz*/   //采样率=80 000000/500=160000，每个通道100个数据，有5个通道
            //AI_ReadCount设置为500，
            //建议每秒钟采集10次-50次，这样不会丢数据。如果采集20次，怎么设置了？
            //目标：1S1000个数据，1ms一个  intrv=80000000/5000=16000;5000为每秒5000个数据，每个通道1000个数据/s  SampIntrv = 16000，
            //AI_ReadCount=5000，则1S采集一次，如果设置成500,则0.1S采集一次，一次100个数据每通道、如果设置成250，则0.05采集一次，1次50个数据
            uint ScanIntrv = (uint)(SampIntrv * (Channel + 1)); /*Scan Rate: P922X_TIMEBASE/320 = 250K Hz*/

            ushort AdRange = DASK.AD_B_10_V; /*AI range*/

            ai_buf_ready_cbdel = new CallbackDelegate(ai_buf_ready_cbfunc);
            _ptr[0] = Marshal.AllocHGlobal((sizeof(ushort) * ((Int32)AI_ReadCount)));//5000
            _ptr[1] = Marshal.AllocHGlobal((sizeof(ushort) * ((Int32)AI_ReadCount)));
            VBuffer[0] = Marshal.AllocHGlobal((sizeof(double) * ((Int32)AI_ReadCount)));
            /*Configure AI*/


            err = DASK.AI_9222_Config(cardRegNumber, ConfigCtrl, TrigCtrl, ReTriggerCount, true);
            if (err < 0)
            {
                MessageBox.Show("config");
            }

            /*Set Scan and Sampling Rate*/
            err = DASK.AI_9222_CounterInterval(cardRegNumber, ScanIntrv, SampIntrv);
            if (err < 0)
            {
                MessageBox.Show("AI_9222_CounterInterval");
            }

            /*Enable Double Buffer Mode*/
            err = DASK.AI_AsyncDblBufferMode(cardRegNumber, true);
            if (err < 0)
            {
                MessageBox.Show("AI_AsyncDblBufferMode");
            }

            /*Setup Buffer for AI DMA Transfer*/
            err = DASK.AI_ContBufferSetup(cardRegNumber, _ptr[0], AI_ReadCount, out _bufferId[0]);
            if (err < 0)
            {
                MessageBox.Show("AI_ContBufferSetup");
            }
            err = DASK.AI_ContBufferSetup(cardRegNumber, _ptr[1], AI_ReadCount, out _bufferId[1]);
            if (err < 0)
            {
                MessageBox.Show("AI_ContBufferSetup");
            }

            err = DASK.AI_EventCallBack(cardRegNumber, 1/*add*/, DASK.DBEvent/*EventType*/, ai_buf_ready_cbdel);//????????????????????
            if (err < 0)
            {
                MessageBox.Show("AI_EventCallBack");

            }

            err = DASK.AI_ContScanChannels(cardRegNumber, Channel, AdRange, _bufferId, AI_ReadCount, 0/*Ignore*/, DASK.ASYNCH_OP);////??????????
            if (err < 0)
            {
                MessageBox.Show("AI_ContScanChannels");
            }
            this.timer1.Enabled = true;
        }

        private uint pck0;//记录点开始的时间，收集开始
        private uint pck1;
        List<uint> listtime = new List<uint>();
        private void ai_buf_ready_cbfunc()//是两个交替读吗？callback
        {
            if (bufindex == 0)
            {
                DASK.AI_ContVScale(cardRegNumber, DASK.AD_B_10_V, _ptr[0], VBuffer[0], (int)AI_ReadCount);//??
                bufindex = 1;
            }
            else
            {
                DASK.AI_ContVScale(cardRegNumber, DASK.AD_B_10_V, _ptr[1], VBuffer[0], (int)AI_ReadCount);//?
                bufindex = 0;
            }
            DisplayTrend displaytrendInvoke = new DisplayTrend(Displayaidata);
            BeginInvoke(displaytrendInvoke, new object[] { VBuffer[0] });
        }

        private void Displayaidata(IntPtr writedata)
        {
            double[] dtx = new double[AI_ReadCount];
            double[] voltage = new double[AI_ReadCount];
            double[] ch0 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch1 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch2 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch3 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch4 = new double[AI_ReadCount / (Channel + 1)];

            //gts.GT_GetClockHighPrecision(0, out pck1);
            //listtime.Add((uint)(pck1 * 0.125));
            Marshal.Copy(writedata, voltage, 0, (int)AI_ReadCount);//
            for (int i=0; i < 5;i++ )
            {
                LaserHight[4-i] = voltage[voltage.Length-i-1];
            }
            if (Flag_start)
            {
                if (listArray[0].Count > 10000)//1ms1个数据，10S
                {
                    listArray[0].Clear();
                    listArray[1].Clear();
                    listArray[2].Clear();
                    listArray[3].Clear();
                    listArray[4].Clear();
                    gts.GT_GetClockHighPrecision(0, out pck0);
                }
                gts.GT_GetClockHighPrecision(0, out pck1);
                double timeinterval = (pck1 - pck0) * 0.125 / 1000.00;//this is 100ms interval
                for (int j = 0; j < AI_ReadCount; j++)
                {
                    if ((j % (Channel + 1)) == 0)
                    {
                        listArray[0].Add((listArray[0].Count + 1) / 1000.00, voltage[j]);//1ms一个数据，所以有多少个数据就是多少个ms
                    }
                    else if ((j % (Channel + 1)) == 1)
                    {
                        listArray[1].Add((listArray[1].Count + 1) / 1000.00, voltage[j]);//ms-->s
                    }
                    else if ((j % (Channel + 1)) == 2)
                    {
                        listArray[2].Add((listArray[2].Count + 1) / 1000.00, voltage[j]);
                    }
                    else if ((j % (Channel + 1)) == 3)
                    {
                        listArray[3].Add((listArray[3].Count + 1) / 1000.00, voltage[j]);
                    }
                    else
                    {
                        listArray[4].Add((listArray[4].Count + 1) / 1000.00, voltage[j]);
                    }
                }

            }
        }
        
        private void PCI9222_FormClosed(object sender, FormClosedEventArgs e)
        {
            err = DASK.AI_AsyncClear(cardRegNumber, out accesscnt);
            if (err < 0)
            {
                MessageBox.Show("AI_AsyncClear");
            }
            err = DASK.Release_Card(cardRegNumber);
            if (err < 0)
            {
                MessageBox.Show("Release_Card");
            }
            this.timer1.Enabled=false;
            listArray[0].Clear();
            listArray[1].Clear();
            listArray[2].Clear();
            listArray[3].Clear();
            listArray[4].Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Globals.Invoker.SetCtltxt(this.textBox1, LaserHight[0].ToString());
            Globals.Invoker.SetCtltxt(this.textBox2, LaserHight[1].ToString());
            Globals.Invoker.SetCtltxt(this.textBox3, LaserHight[2].ToString());
            Globals.Invoker.SetCtltxt(this.textBox4, LaserHight[3].ToString());
            Globals.Invoker.SetCtltxt(this.textBox5, LaserHight[4].ToString());            
            this.textBox6.Text = listArray[0].Count.ToString();
            // Calculate the Axis Scale Ranges
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            listArray[0].Clear();
            listArray[1].Clear();
            listArray[2].Clear();
            listArray[3].Clear();
            listArray[4].Clear();
            gts.GT_GetClockHighPrecision(0, out pck0);
            Flag_start = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Flag_start = false;
        }

        private void Save_csv_Click(object sender, EventArgs e)
        {
            ls.Clear();
            string[] stringheader = new string[] { "Time", "laer_p0", "laer_p1", "laer_p2", "laer_p3", "laer_p4" };
            ls.Add(stringheader);
            for (int i = 0; i < listArray[0].Count; i++)
            {
                string[] strarr=new string[6];
                strarr[0] = listArray[0][i].X.ToString();//time
                strarr[1] = listArray[0][i].Y.ToString();//0-Y
                strarr[2] = listArray[1][i].Y.ToString();
                strarr[3] = listArray[2][i].Y.ToString();
                strarr[4] = listArray[3][i].Y.ToString();
                strarr[5] = listArray[4][i].Y.ToString();//5-Y
                ls.Add(strarr);
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "E:\\";
            sfd.Filter = "csv files(*.csv)|*.csv";
            sfd.FilterIndex=1;
            sfd.RestoreDirectory = true;
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string str = sfd.FileName;
                string[] pathstr = str.Split('.');
                Globals.csv.WriteCSV(pathstr[0] + ".csv", ls);
            }
        }
        List<string[]> ls = new List<string[]>();
        private void btn_DataBack_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = "E:\\";
            this.openFileDialog1.Filter = "csv files(*.csv)|*.csv";
            this.openFileDialog1.FilterIndex = 1;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                ls = Globals.csv.ReadCSV(path);
                listArray[0].Clear();
                listArray[1].Clear();
                listArray[2].Clear();
                listArray[3].Clear();
                listArray[4].Clear();
                for (int i = 0; i < ls.Count-1; i++)//表头不显示
                {
                    listArray[0].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][1]));
                    listArray[1].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][2]));
                    listArray[2].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][3]));
                    listArray[3].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][4]));
                    listArray[4].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][5]));
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listArray[0].Clear();
            listArray[1].Clear();
            listArray[2].Clear();
            listArray[3].Clear();
            listArray[4].Clear();
            gts.GT_GetClockHighPrecision(0, out pck0);
            Flag_start = false;
        }



    }
}
