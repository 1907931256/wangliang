using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using BZappdll;

namespace XCore
{
    public abstract class XTask
    {
        #region 定义

        public event Action<string, Color> OnStep;
        public event Action<int> OnStepNum;
        public event Action<XTaskState> OnStationStateChanged;
        public event Action<double> OnStaShowCT;

        private object m_RunMode;
        private Stopwatch m_StopWatch = new Stopwatch();
        private Thread _thread;
        private string logpath;
        private bool m_homeOK;
        private XTaskState m_State;

        public struct Point
        {
            public double X;
            public double Y;
            public double Z;
            public double R;
        }

        /// <summary>
        /// for press the btn_stop button
        /// </summary>
        private bool _staStop = false;
        public bool StaStop
        {
            get { return _staStop; }
            set { _staStop = value; }
        }

        /// <summary>
        /// Task is working flag?
        /// </summary>
        private bool _TaskIsWorking = false;
        public bool TaskIsWorking
        {
            get { return _TaskIsWorking; }
            set { _TaskIsWorking = value; }
        }

        /// <summary>
        /// Task is working flag?
        /// </summary>
        private bool _TaskEnable = true;
        public bool Flag_TaskdisEnable
        {
            get { return _TaskEnable; }
            set { _TaskEnable = value; }
        }

        /// <summary>
        /// 单站复位标志，初始值为FALSE
        /// </summary>
        public bool HomeOK
        {
            get { return m_homeOK; }
            set { m_homeOK = value; }
        }
        /// <summary>
        /// 单站自动运行Step
        /// </summary>
        public int AutoRunstep { get; set; }
        public int AutoRunstepLast { get; set; }//上一步step
        /// <summary>
        /// 用于每站的超时用
        /// </summary>
        public int TimeOut { get; set; }
        /// <summary>
        /// 单站复位运行Step
        /// </summary>
        public int InitHomingStep { get; set; }
        /// <summary>
        ///   //单站点停止，完成本次循环，点击Stop时置TRUE，循环运行完后置FALSE
        /// </summary>

        /// <summary>
        /// Station上的Shape_Sensor显示
        /// </summary>
        private bool[] m_SensorShow = new bool[4];
        public bool[] XStationShape_SensorShow
        {
            get { return m_SensorShow; }
            set { m_SensorShow = value; }
        }
        //PDCA_Step
        public int PDCA_Step { get; set; }
        public XTask()
        { }
        
        public XTask(string logpath)
            : this()
        {
            this.logpath = logpath;
        }

        public string LogPath
        {
            get { return logpath; }
            set { logpath = value; }
        }

        public XTaskState xState
        {
            get { return m_State; }
            set { m_State = value; }
        }

        public int TaskId { get; set; }

        public string Name { get; set; }


        public void SetStep(string step, Color color)
        {
            if (OnStep != null)
            {
                OnStep(step, color);
            }
        }

        public void SetStepNum(int stepNum)
        {
            if (OnStepNum != null)
            {
                OnStepNum(stepNum);
            }
        }

        /// <summary>
        /// show station CT
        /// </summary>
        /// <param name="CT"></param>
        public void SetCT(double CT)
        {
            if (OnStaShowCT != null)
            {
                OnStaShowCT(CT);
            }
        }

        public void SetState(XTaskState sts)
        {

            lock (this)
            {
                m_State = sts;
            }
            if (OnStationStateChanged != null)
            {
                OnStationStateChanged(m_State);
            }
            switch (sts)
            {
                case XTaskState.ESTOP:
                    StopWatch_Stop();
                    break;
                case XTaskState.ALARM:
                    StopWatch_Stop();
                    break;
                case XTaskState.RESETING:
                    StopWatch_Reset();
                    break;
                case XTaskState.RUNNING:
                    break;
                case XTaskState.PAUSE:
                    StopWatch_Stop();
                    break;
                case XTaskState.STOP:
                    break;
                case XTaskState.WAITRESET:
                    StopWatch_Stop();
                    break;
                case XTaskState.WAITRUN:
                    StopWatch_Stop();
                    break;
            }
        }

        #endregion

        #region 线程

        /// <summary>
        /// 启动，调用Running
        /// </summary>
        public void Start(object runMode)
        {
            if (_thread != null)
            {
                _thread.Abort();
            }
            _thread = new Thread(new ParameterizedThreadStart(Running));
            _thread.IsBackground = true;
            _thread.Start(runMode);
        }
        /// <summary>
        /// 复位，调用Homing
        /// </summary>
        public void Reset()
        {
            HomeOK = false;
            if (_thread != null)
            {
                _thread.Abort();
            }
            _thread = new Thread(new ThreadStart(Homing));
            _thread.IsBackground = true;
            _thread.Start();
        }
        /// <summary>
        /// 任务线程取消
        /// </summary>
        public void Cancel()
        {
            if (_thread != null)
            {
                _thread.Abort();
            }
        }

        /// <summary>
        /// 任务初始化
        /// </summary>
        public virtual void Initialize()
        {

        }

        /// <summary>
        /// 任务退出
        /// </summary>
        public virtual void Exit()
        {
            Cancel();
        }
        /// <summary>
        /// 任务运行，需用户重写
        /// </summary>
        protected virtual void Running(object runMode) { }
        /// <summary>
        /// 任务复位，需用户重写
        /// </summary>
        protected virtual void Homing() { }

        #endregion

        #region StopWatch

        public void StopWatch_Start()
        {
            this.m_StopWatch.Start();
        }

        public void StopWatch_Reset()
        {
            this.m_StopWatch.Reset();
        }

        public void StopWatch_ReStart()
        {
            this.m_StopWatch.Restart();
        }

        public void StopWatch_Stop()
        {
            this.m_StopWatch.Stop();
        }

        public double ElapsedMilliseconds
        {
            get { return this.m_StopWatch.ElapsedMilliseconds; }
        }

        /// <summary>
        /// 获取秒表开始后的毫秒数
        /// </summary>
        /// <returns></returns>
        protected double Task_StopWatchElapsedMilliseconds()
        {
            SetCT(ElapsedMilliseconds);
            return ElapsedMilliseconds;
        }

        #endregion

        #region Task操作

        /// <summary>
        /// 工站开始，工站绑定的所有任务开始，运行Task.Running()指示开启线程，真正开始是TaskGo，AutoRunstep = 10&stopwathc_start,CT start
        /// </summary>
        public void TaskStart(object runMode)
        {
            m_RunMode = runMode;
            switch (m_State)
            {
                //case XTaskState.WAITRUN:
                //case XTaskState.STOP:
                //case XTaskState.RUNNING:
                //    if (m_homeOK)
                //    {
                //        SetState(XTaskState.RUNNING);
                //        Start(m_RunMode);
                //    }
                //    else
                //    { SetStep("请先回零！！",Mycolor.ErrorRed);}
                //    break;
                case XTaskState.PAUSE:
                    TaskContinue();
                    StopWatch_Start();
                    break;
                default:
                    if (m_homeOK)
                    {
                        SetState(XTaskState.RUNNING);
                        Start(m_RunMode);
                    }
                    else
                    { SetStep("请先回零！！",Mycolor.ErrorRed);}
                    break;
            }

        }
        /// <summary>
        /// 真正开始是TaskGo，AutoRunstep = 10&stopwathc_start,CT start
        /// </summary>
        public void TaskGo()
        {
            AutoRunstep = 10;
            _TaskIsWorking = true;
            StopWatch_Reset();
            StopWatch_Start();
        }
        /// <summary>
        /// 工站暂停，工站绑定的所有任务暂停
        /// </summary>
        public void TaskPause()
        {
            if (m_State == XTaskState.RUNNING|| _TaskIsWorking)
                SetState(XTaskState.PAUSE);
        }
        /// <summary>
        /// 工站继续，工站绑定的所有任务继续
        /// </summary>
        public void TaskContinue()
        {
            if (m_State == XTaskState.PAUSE)
                SetState(XTaskState.RUNNING);
        }
        /// <summary>
        /// 工站复位，工站绑定的所有任务复位，运行Task.Homing()
        /// </summary>
        public void TaskReset()
        {
            SetState(XTaskState.RESETING);
            HomeOK = false;
            InitHomingStep = 0;
            _TaskIsWorking = false;
            AutoRunstep = 0;
            Reset();
        }
        /// <summary>
        /// 工站停止，工站绑定的所有任务停止
        /// </summary>
        public void TaskStop()
        {
            if (m_State != XTaskState.ESTOP && m_State != XTaskState.ALARM)
            {
                SetState(XTaskState.STOP);
                _staStop = true;
            }
        }
        /// <summary>
        /// 急停
        /// </summary>
        public void TaskEStop()
        {
            SetState(XTaskState.ESTOP);
            HomeOK = false;
            InitHomingStep = 0;
            AutoRunstep = 0;
            _TaskIsWorking = false;
        }
        /// <summary>
        /// 单站报警
        /// </summary>
        public void PostTaskAlarm(XAlarmLevel level, int Code, string category, string append = "")
        {
            switch (level)
            {
                case XAlarmLevel.STOP:
                    if (m_State != XTaskState.ESTOP)
                    {
                        SetState(XTaskState.ALARM);
                        HomeOK = false;
                        InitHomingStep = 0;
                        AutoRunstep = 0;
                        _TaskIsWorking = false;
                    }
                    break;
                case XAlarmLevel.PAUSE:
                    SetState(XTaskState.PAUSE);
                    break;
                case XAlarmLevel.RST:
                    SetState(XTaskState.WAITRUN);
                    break;
            }
            XAlarmReporter.Instance.PostAlarm(TaskId, level, Code, category, append);
            SetStep(Code.ToString() + ":" + category + "_" + append,(level==XAlarmLevel.RST)?Mycolor.Green:Mycolor.ErrorRed);
        }

        #endregion

    }

    public sealed class XTaskManager
    {
        private Dictionary<int, XTask> tasks = new Dictionary<int, XTask>();
        private readonly static XTaskManager instance = new XTaskManager();
        XTaskManager()
        {

        }
        public static XTaskManager Instance
        {
            get { return instance; }
        }

        public Dictionary<int, XTask> Tasks
        {
            get { return tasks; }
        }

        public void BindTask(int taskId, XTask task, string name)
        {
            if (tasks.ContainsKey(taskId) == false)
            {
                task.TaskId = taskId;
                task.Name = name;
                tasks.Add(taskId, task);
            }
        }

        public XTask FindTaskById(int taskId)
        {
            if (tasks.ContainsKey(taskId) == false)
            {
                return null;
            }
            return tasks[taskId];
        }


    }

    public enum XTaskState
    {
        NONE,
        ESTOP,
        ALARM,
        STOP,
        WAITRESET,
        RESETING,
        WAITRUN,
        RUNNING,
        PAUSE,
    }

    public enum XAlarmLevel
    {
        PAUSE,
        STOP,
        ONLYLOG,
        RST,
    }

    public class Mycolor
    {
        public static Color Green = Color.FromArgb(0xAE, 0xDA, 0x97);
        public static Color None = Color.FromArgb(0xEA, 0xEA, 0xEB);
        public static Color Blue = Color.FromArgb(0xB3, 0xCA, 0xFF);
        public static Color LightGreen = Color.FromArgb(0xCB, 0xFF, 0xF3);
        public static Color Red = Color.FromArgb(0xC8, 0x25, 0x06);
        public static Color LightRed = Color.FromArgb(0xFC, 0xDF, 0xDE);
        public static Color BackGroud = Color.FromArgb(0xFC, 0xDF, 0xDE);
        public static Color Yellow = Color.FromArgb(253, 253, 191);
        public static Color White = Color.White;
        public static Color SelectedBtn = Color.FromArgb(175, 218, 150);
        public static Color UnselectedBtn = Color.FromArgb(238, 238, 238);
        public static Color SelectedPauseBtn = Color.FromArgb(132, 193, 251);
        public static Color SelectedEndBtn = Color.FromArgb(228, 146, 138);
        public static Color ErrorRed = Color.FromArgb(236, 93, 87);
        public static Color myBlue = Color.FromArgb(128, 128, 255);
        public static Color LimeGreen = Color.LimeGreen;
    }

}
