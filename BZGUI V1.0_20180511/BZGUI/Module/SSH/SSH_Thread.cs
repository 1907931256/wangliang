using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BZGUI
{
    /// <summary>
    /// 实时采集SSH 的数据，弄别的地方会卡
    /// </summary>
    public  class SSH_Thread
    {
        private static readonly SSH_Thread instance = new SSH_Thread();
        SSH_Thread()
        { }
        public static SSH_Thread Instance
        {
            get { return instance; }
        }

        public  event Action<string> OnSSHInf;
        private Thread _thread;
        public void Start()
        {
            Stop();
            _thread = new Thread(new ThreadStart(ReadSSHstring));
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Stop()
        {
            if (this._thread != null)
            {
                this._thread.Abort();
            }
        }

        private void ReadSSHstring()   //机器主循环
        {
            while (true)
            {
                if (Globals.SSHconnSt)
                {
                    Globals.SSHconnSt = SSH.Instance.isConnect();
                    if (OnSSHInf != null)
                    {
                        OnSSHInf(SSH.Instance.readReader());
                    }
                }
                Thread.Sleep(500);
                Application.DoEvents();
            }
        }

    }
}
