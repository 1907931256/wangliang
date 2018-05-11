using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//for the API

namespace XCore
{
    public enum FunctionStatus //返回函数的状态
    {
        Working,
        Finish,
        Error
    }

    public  class XFunc
    {
        public delegate FunctionStatus FuncDelegateWorkStatus();
        private FuncDelegateWorkStatus _func;
        private Thread thFunc;

        public XFunc(FuncDelegateWorkStatus Func)
        {
            _func = Func;
        }
        public void StartFunc(int TimeInterval=1)//启动方法执行
        {
            try
            {
                if (thFunc != null)
                {
                    thFunc.Abort();
                    thFunc = null;
                }
                if (_func != null)
                {
                    thFunc = new Thread(() => runFunc(_func, TimeInterval));//开启线程
                }
                thFunc.IsBackground = true;
                thFunc.Start();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }


        public void StopFunc()
        {
            try
            {
                if (thFunc != null)
                {
                    thFunc.Abort();
                    thFunc = null;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void runFunc(FuncDelegateWorkStatus _func,int TimeInterval)//线程开始调用方法
        {
            bool _isBreak = false;
            while (true)
            {
                switch (_func.Invoke())
                {
                    case FunctionStatus.Error:
                        _isBreak = true;
                        break;
                    case FunctionStatus.Finish:
                        _isBreak = true;
                        break;
                }
                if (_isBreak == true)
                {
                    break;
                }
                if (TimeInterval != 0)
                { Thread.Sleep(TimeInterval); }
            }
        }

    }

    public class Delay
    {
        [DllImport("kernel32.dll", EntryPoint = "GetTickCount")]
        public static extern int GetTickCount();
        int _startTime = 0;
        public Delay()
        {
            _startTime = GetTickCount();
        }
        public void InitialTime()
        {
            _startTime = GetTickCount();
        }

        public bool TimeIsUp(int delayTime)
        {
            if (GetTickCount() - _startTime > delayTime)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
