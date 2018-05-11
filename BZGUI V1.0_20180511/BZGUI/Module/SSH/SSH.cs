using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LabSSH;
using System.Windows.Forms;
using System.Diagnostics;
using XCore;

namespace BZGUI
{
    enum ConnectionType
    {
        Password,
        Privat_Key,
    }

    class SSH
    {
        public event Action<string> ShowList;    // this.Dialog_OnAdd(s)

        LabSSH.LabSSH ssh = new LabSSH.LabSSH();
        private readonly static SSH instance = new SSH();
        public SSH()
        { }
        public static SSH Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// using password to conn
        /// </summary>
        /// <param name="remote"></param>
        /// <param name="port"></param>
        /// <param name="UserName"></param>
        /// <param name="password"></param>
        /// <param name="isConn"></param>
        /// <returns></returns>
        public string Connect(string remote, int port,string UserName,string password,out bool isConn)
        {
            isConn = false;
            try
            {
                ssh.port = port;
                ssh.remote = remote;
                ssh.user = UserName;
                string rtn= ssh.connect(password);
                isConn = ssh.isSshConnected();
                KeepAliveInterval(50);
                return rtn;
            }
            catch(Exception ex)
            {
                return(ex.Message.ToString());
            }
        }
        /// <summary>
        /// use the key to conn
        /// </summary>
        /// <param name="remote"></param>
        /// <param name="port"></param>
        /// <param name="UserName"></param>
        /// <param name="isConn"></param>
        /// <returns></returns>
        public string Connect(string remote, int port, string UserName, out bool isConn)
        {
            isConn = false;
            try
            {
                ssh.port = port;
                ssh.remote = remote;
                ssh.user = UserName;
                string rtn = ssh.connect(PVar.BZ_ParameterPath + "PrivateKey\\id_rsa", "123456");
                isConn = ssh.isSshConnected();
                KeepAliveInterval(50);
                return rtn;
            }
            catch (Exception ex)
            {
                isConn = false;
                if (ShowList != null) ShowList("SSH connect error!pls check it!");
                Globals.PostAlarmMachine(XAlarmLevel.STOP, (int)AlarmCode.SSH通讯异常, AlarmCategory.SYSTEM.ToString(), "SSH通讯异常");
                return (ex.Message.ToString());
            }
        }
        /// <summary>
        /// 保持激活间隔的时间
        /// </summary>
        /// <param name="time_ms"></param>
        public void KeepAliveInterval(int time_ms=50)
        {
            ssh.setKeepAliveInterval(time_ms);
        }
        /// <summary>
        /// check the connect status
        /// </summary>
        /// <returns></returns>
        public bool isConnect()
        {
            try
            {
               return ssh.isSshConnected();
            }
            catch
            { return false; }
        }
        /// <summary>
        /// dis connnect
        /// </summary>
        /// <param name="isConn"></param>
        /// <returns></returns>
        public string disConnect(out bool isConn)
        {
            try
            {
               string rtn= ssh.disconnect();
               isConn = ssh.isSshConnected();
               return rtn;
            }
            catch (Exception ex)
            {
                isConn = false;
                return (ex.Message.ToString());
            }
        }
        /// <summary>
        /// send msg
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        public bool ExecuteCommand(string Command)
        {
            try
            {
                ssh.writer.WriteLine(Command);
                ssh.writer.AutoFlush = true;
                return true;
            }
            catch 
            {
                return false;
            }
        }
        /// <summary>
        /// reader the string from ssh 
        /// </summary>
        /// <returns></returns>
        public string readReader()
        {
            try
            {
                return ssh.reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                return (ex.Message.ToString());
            }
        }

        /// <summary>
        /// send and wait reply
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="result"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool SendAndGetReply(string cmd, out string result, int timeout)
        {
            ssh.writer.WriteLine(cmd);
            ssh.writer.AutoFlush = true;

            result = "";
            string m_ReceiveStr = string.Empty;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                Application.DoEvents();
                if (sw.ElapsedMilliseconds > timeout)
                {
                    m_ReceiveStr = "";
                    return false;
                }
                if (m_ReceiveStr == string.Empty)
                {
                    m_ReceiveStr = ssh.reader.ReadToEnd();
                    System.Threading.Thread.Sleep(50);
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

    }


}
