using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZedGraph;
using BZappdll;
using XCore;


namespace BZGUI
{
    /// <summary>
    /// 实时采集laser Analog signal
    /// </summary>
    class DAQ
    {
        #region 变量定义
        public event Action<string> ShowList;    // this.Dialog_OnAdd(s)
        ComSub comf = new ComSub();
        public PointPairList[] listArray;
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
        ushort Channel = 4;
        private double[] _LaserHight = new double[5];//取每次采集出来的额数据的最后5个数据，也是最新的数据
        public double[] LaserHight
        {
            get { return _LaserHight; }
            set { _LaserHight = value; }
        }

        private bool _Flag_start = false;
        public bool Flag_StartAnalog
        {
            get { return _Flag_start; }
            set { _Flag_start=value;}
        }

        private static readonly DAQ instance = new DAQ();
        DAQ()
        {
            listArray = new PointPairList[Channel + 1];

            //int[] count = new int[_mutilChannel];
            for (int i = 0; i < listArray.Length; i++)
            {
                listArray[i] = new PointPairList();
            }
        }
        public static DAQ Instance
        {
            get { return instance; }
        }

        private double[] _meanAvg=new double[5];
        public double[] MeanAvg
        {
            get { return _meanAvg; }
            set { _meanAvg = value; }
        }

        #endregion

        #region 线程相关
        //回调函数
        private Thread _thread;
        public void Start()
        {
            Stop();
            _thread = new Thread(new ThreadStart(PCI922Init));
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Stop()
        {
            //try
            //{
            //    PCI9222Close();
            //}
            //catch { }
            if (this._thread != null)
            {
                this._thread.Abort();
            }
        }
        #endregion

        #region PCI9222

        public void PCI922Init()
        {
            short ret = DASK.Register_Card(DASK.PCI_9222, 0);
            if (ret >= 0)
            {
                cardRegNumber = (ushort)ret;//Register_Card的时候，把卡号给cardRegNumber
                Globals.addList("9222卡初始化成功！",Mycolor.None);
                #region PCI9222设置
                //ushort ConfigCtrl = DASK.P922x_AI_SingEnded | DASK.P922x_AI_CONVSRC_INT;//?差分在哪区分
                //ushort TrigCtrl = DASK.P922x_AI_TRGMOD_POST | DASK.P922x_AI_TRGSRC_SOFT;//?
                ushort ConfigCtrl = DASK.P922x_AI_Differential;//?差分在哪区分
                ushort TrigCtrl = DASK.P922x_AI_TRGMOD_POST;//?
                uint ReTriggerCount = 0; /*Ignore in Non-Retrigger*/


                bufindex = 0;//是用来两个交替读吗？
                //Channel = 4; /*AI Channel Number to be read*/
                //uint SampIntrv = 8000; /*Sampling Rate: P922X_TIMEBASE/320 = 250K Hz*/  //这个设置，如果要快一点，怎么设置，变小？
                //AI_ReadCount设置为500，
                //建议每秒钟采集10次-50次，这样不会丢数据。如果采集20次，怎么设置了？
                //目标：1S1000个数据，1ms一个  intrv=80000000/5000=16000;5000为每秒5000个数据，每个通道1000个数据/s  SampIntrv = 16000，
                //AI_ReadCount=5000，则1S采集一次，如果设置成500,则0.1S采集一次，一次100个数据每通道、如果设置成250，则0.05采集一次，1次50个数据
                uint SampIntrv = 16000; /*Sampling Rate: P922X_TIMEBASE/320 = 250K Hz*/
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
                    Globals.addList("9222卡config失败！", Mycolor.ErrorRed);
                }

                /*Set Scan and Sampling Rate*/
                err = DASK.AI_9222_CounterInterval(cardRegNumber, ScanIntrv, SampIntrv);
                if (err < 0)
                {
                    Globals.addList("9222卡AI_9222_CounterInterval设置失败！", Mycolor.ErrorRed);
                }

                /*Enable Double Buffer Mode*/
                err = DASK.AI_AsyncDblBufferMode(cardRegNumber, true);
                if (err < 0)
                {
                    Globals.addList("9222卡AI_AsyncDblBufferMode设置失败！", Mycolor.ErrorRed);
                }

                /*Setup Buffer for AI DMA Transfer*/
                err = DASK.AI_ContBufferSetup(cardRegNumber, _ptr[0], AI_ReadCount, out _bufferId[0]);
                if (err < 0)
                {
                    Globals.addList("9222卡AI_ContBufferSetup设置失败！", Mycolor.ErrorRed);
                }
                err = DASK.AI_ContBufferSetup(cardRegNumber, _ptr[1], AI_ReadCount, out _bufferId[1]);
                if (err < 0)
                {
                    Globals.addList("9222卡AI_ContBufferSetup设置失败！", Mycolor.ErrorRed);
                }

                err = DASK.AI_EventCallBack(cardRegNumber, 1/*add*/, DASK.DBEvent/*EventType*/, ai_buf_ready_cbdel);//????????????????????
                if (err < 0)
                {
                    Globals.addList("9222卡AI_EventCallBack设置失败！", Mycolor.ErrorRed);
                }

                err = DASK.AI_ContScanChannels(cardRegNumber, Channel, AdRange, _bufferId, AI_ReadCount, 0/*Ignore*/, DASK.ASYNCH_OP);////??????????
                if (err < 0)
                {
                    Globals.addList("9222卡AI_ContScanChannels设置失败！", Mycolor.ErrorRed);
                }
                #endregion
            }
            else
            {
                Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.凌华PCI9222板卡异常, AlarmCategory.SYSTEM.ToString(), "凌华PCI9222板卡异常");
                if (ShowList!=null) ShowList("9222卡初始化失败！");
            }
        }

        private uint pck0;//记录点开始的时间，收集开始
        private uint pck1;
        //回调
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
            Calculatedata(VBuffer[0]);
            //DisplayTrend displaytrendInvoke = new DisplayTrend(Displayaidata);
            //BeginInvoke(displaytrendInvoke, new object[] { VBuffer[0] });
        }

        //计算高度
        private void Calculatedata(IntPtr writedata)
        {
            uint ch0index = 0, ch1index = 0, ch2index = 0, ch3index = 0, ch4index = 0;
            double[] voltage = new double[AI_ReadCount];
            double[] ch0 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch1 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch2 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch3 = new double[AI_ReadCount / (Channel + 1)];
            double[] ch4 = new double[AI_ReadCount / (Channel + 1)];

            //gts.GT_GetClockHighPrecision(0, out pck1);
            //listtime.Add((uint)(pck1 * 0.125));
            Marshal.Copy(writedata, voltage, 0, (int)AI_ReadCount);//
            //for (int i = 0; i < 5; i++)
            //{
            //    _LaserHight[4 - i] = voltage[voltage.Length - i - 1];
            //}
            _LaserHight[0] = voltage[(voltage.Length - 1) - 4] - Globals.settingLaser.Laser_p0;
            _LaserHight[1] = voltage[(voltage.Length - 1) - 3] - Globals.settingLaser.Laser_p1;
            _LaserHight[2] = voltage[(voltage.Length - 1) - 2] - Globals.settingLaser.Laser_p2;
            _LaserHight[3] = voltage[(voltage.Length - 1) - 1] - Globals.settingLaser.Laser_p3;
            _LaserHight[4] = voltage[(voltage.Length - 1) - 0] - Globals.settingLaser.Laser_p4;

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
                    ch0[ch0index] = voltage[j];
                    ch0index++;
                    if (_Flag_start) listArray[0].Add((listArray[0].Count + 1) / 1000.00, voltage[j] - Globals.settingLaser.Laser_p0);//1ms一个数据，所以有多少个数据就是多少个ms
                }
                else if ((j % (Channel + 1)) == 1)
                {
                    ch1[ch1index] = voltage[j];
                    ch1index++;
                    if (_Flag_start) listArray[1].Add((listArray[1].Count + 1) / 1000.00, voltage[j] - Globals.settingLaser.Laser_p1);//ms-->s
                }
                else if ((j % (Channel + 1)) == 2)
                {
                    ch2[ch2index] = voltage[j];
                    ch2index++;
                    if (_Flag_start) listArray[2].Add((listArray[2].Count + 1) / 1000.00, voltage[j] - Globals.settingLaser.Laser_p2);//减去laser的校正值
                }
                else if ((j % (Channel + 1)) == 3)
                {
                    ch3[ch3index] = voltage[j];
                    ch3index++;
                    if (_Flag_start) listArray[3].Add((listArray[3].Count + 1) / 1000.00, voltage[j] - Globals.settingLaser.Laser_p3);
                }
                else
                {
                    ch4[ch4index] = voltage[j];
                    ch4index++;
                    if (_Flag_start) listArray[4].Add((listArray[4].Count + 1) / 1000.00, voltage[j] - Globals.settingLaser.Laser_p4);
                }
            _meanAvg[0] = comf.Mean(ref ch0);//平均值，静态的时候，值for calibrition laser
            _meanAvg[1] = comf.Mean(ref ch1);
            _meanAvg[2] = comf.Mean(ref ch2);
            _meanAvg[3] = comf.Mean(ref ch3);
            _meanAvg[4] = comf.Mean(ref ch4);

            }

        }

        private bool PCI9222Close()
        {
            try
            {
                _Flag_start = false;
                listArray[0].Clear();
                listArray[1].Clear();
                listArray[2].Clear();
                listArray[3].Clear();
                listArray[4].Clear();
                err = DASK.AI_AsyncClear(cardRegNumber, out accesscnt);
                if (err < 0)
                {
                    Globals.addList("9222卡AI_AsyncClear失败！", Mycolor.ErrorRed);
                    return false;
                }
                err = DASK.Release_Card(cardRegNumber);
                if (err < 0)
                {
                    Globals.addList("9222卡Release_Card失败！", Mycolor.ErrorRed);
                    return false;
                }
                return true;
            }
            catch { return false; }            
        }
        /// <summary>
        /// 开始收集
        /// </summary>
        public void PCI9222StartCollect()
        {
            listArray[0].Clear();
            listArray[1].Clear();
            listArray[2].Clear();
            listArray[3].Clear();
            listArray[4].Clear();
            gts.GT_GetClockHighPrecision(0, out pck0);
            _Flag_start = true;
        }
        /// <summary>
        /// 停止收集
        /// </summary>
        public void PCI9222StopCollect()
        {
            _Flag_start = false;
        }
        /// <summary>
        /// 清除
        /// </summary>
        public void PCI9222Clear()
        {
            listArray[0].Clear();
            listArray[1].Clear();
            listArray[2].Clear();
            listArray[3].Clear();
            listArray[4].Clear();
            gts.GT_GetClockHighPrecision(0, out pck0);
            _Flag_start = false;
        }
        #endregion

    }
}
