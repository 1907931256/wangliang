using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocketHelper;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace BZGUI
{
    class TcpIPHelper
    {
        SocketHelper.TCP.ITcpClient tcpClient=new SocketHelper.TCP.ITcpClient();
        private object LockConect = new object();
        private string m_ReceiveStr;

        public string ReceiveStr
        {
            get { return m_ReceiveStr; }
            set { m_ReceiveStr = value; }
        }
        public string IP//设置远程IP
        { set { tcpClient.ServerIp = value; } }

        public int Port//设置远程port
        { set { tcpClient.ServerPort = value; } }

        public bool IsReconnection //设置是否自动重连，true自动重连，反之不重连
        { 
            set 
            { tcpClient.IsReconnection = value;}  
        }
        public int ReConnectTime
        { set { tcpClient.ReConnectionTime = value; } }

        public bool IsOn//读状态
        { get { return tcpClient.IsStart; } }

        public TcpIPHelper()
        {
            tcpClient.OnStateInfo += new System.EventHandler<SocketHelper.ICommond.TcpClientStateEventArgs>(OnStateInfo);
            tcpClient.OnRecevice += new System.EventHandler<SocketHelper.ICommond.TcpClientReceviceEventArgs>(OnRecevice);
            tcpClient.OnErrorMsg += new System.EventHandler<SocketHelper.ICommond.TcpClientErrorEventArgs>(OnError);
        }

        public void OnStateInfo(object sender, SocketHelper.ICommond.TcpClientStateEventArgs iState)
        {
            tcpClient.IsStart = ((int)iState.State == 1) ? true : false;
        }

        public void OnRecevice(object sender, SocketHelper.ICommond.TcpClientReceviceEventArgs e)
        {
            m_ReceiveStr = "";
            //m_ReceiveStr = Encoding.UTF8.GetString(e.Data); 
            m_ReceiveStr = System.Text.Encoding.GetEncoding("GB2312").GetString(e.Data);//可以识别中文
        }

        public void OnError(object sender, SocketHelper.ICommond.TcpClientErrorEventArgs e)
        {
            //do sth
            tcpClient.IsStart = false; 
        }

        /// <summary>
        /// 网络发送，已经含有回车符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Sendmsg(string str)
        {
            m_ReceiveStr = "";
            int returnValue = 0;
            if (tcpClient.IsStart == false) //判断CCD1连接是否成功
            {
                returnValue = 2; //网络连接失败，返回2
                return returnValue;
            }
            try
            {
                //tcpClient.SendData(Encoding.UTF8.GetBytes(str + "\n"));
                tcpClient.SendData(System.Text.Encoding.GetEncoding("GB2312").GetBytes(str + "\r\n"));
                returnValue = 1; //命令发送成功，返回1
            }
            catch (Exception)
            {
                returnValue = 3; //命令发送失败，返回3
            }
            return returnValue;
        }
        public bool Start()
        {
            try
            {
                if (tcpClient != null)
                {
                    tcpClient.StartConnect();
                }
            }
            catch
            { return false; }
            return true;
        
        }
        //关闭
        public bool Close()
        {
            try
            {
                if (tcpClient != null)
                {
                    tcpClient.StopConnect();
                }
            }
            catch
            { return false; }
            return true;
        }

        public bool SendAndGetReply(string cmd, out string result, int timeout_ms=-1)
        {
            result = "";
            m_ReceiveStr = string.Empty;
            Sendmsg(cmd);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (timeout_ms == -1) timeout_ms = 60000;
            while (true)
            {
                Application.DoEvents();
                if (sw.ElapsedMilliseconds > timeout_ms)
                {
                    return false;
                }
                if (m_ReceiveStr == string.Empty)
                {
                    System.Threading.Thread.Sleep(10);
                    continue;
                }
                else
                {
                    break;
                }
            }
            result = m_ReceiveStr;
            return true;
        }

        public bool SendAndGetReply(string cmd, out string[] result, int timeout_ms = -1)
        {
            result = new string[10];
            m_ReceiveStr = string.Empty;
            Sendmsg(cmd);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (timeout_ms == -1) timeout_ms = 60000;
            while (true)
            {
                Application.DoEvents();
                if (sw.ElapsedMilliseconds > timeout_ms)
                {
                    return false;
                }
                if (m_ReceiveStr == string.Empty)
                {
                    System.Threading.Thread.Sleep(10);
                    continue;
                }
                else
                {
                    break;
                }
            }
            result = m_ReceiveStr.Split(',');
            return true;
        }

        public bool GetReply(out string result, int timeout_ms=-1)
        {
            result = "";
            if (timeout_ms == -1) timeout_ms = 60000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                Application.DoEvents();
                if (sw.ElapsedMilliseconds > timeout_ms)
                {
                    return false;
                }
                if (m_ReceiveStr == string.Empty)
                {
                    System.Threading.Thread.Sleep(10);
                    continue;
                }
                else
                {
                    break;
                }
            }
            result = m_ReceiveStr;
            return true;
        }

        //网络链接状态
        ///// <summary>
        ///// 正在连接服务端
        ///// </summary>
        //Connecting = 0,

        ///// <summary>
        ///// 已连接服务端
        ///// </summary>
        //Connected = 1,

        ///// <summary>
        ///// 重新连接服务端
        ///// </summary>
        //Reconnection = 2,

        ///// <summary>
        ///// 断开服务端连接
        ///// </summary>
        //Disconnect = 3,

    }
}
