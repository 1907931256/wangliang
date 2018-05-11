using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.IO;
using System.Diagnostics;

namespace BZGUI
{
    public class CsvServer
    {
        private Thread _thread;
        private ConcurrentQueue<CsvInfo> queue = new ConcurrentQueue<CsvInfo>();
        private readonly static CsvServer instance = new CsvServer();
        public object obj = new object();
        CsvServer() { }
        public static CsvServer Instance
        {
            get { return instance; }
        }

        public void Start()
        {
            Stop();
            _thread = new Thread(new ThreadStart(ProcessEventQueue));
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
        private void Kill()//20170327 XSF
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
            {
                if (p.ProcessName.ToUpper() == "ET")
                {
                    p.CloseMainWindow();
                    p.WaitForExit();
                }
            }
        }
        private void ProcessEventQueue()
        {
            while (true)
            {
                if (queue.Count > 0)
                {
                    CsvInfo csvInfo;
                    queue.TryDequeue(out csvInfo);
                    try
                    {
                        lock (obj)
                        {
                            Kill();//20170327 XSF
                            //StreamWriter sw = File.AppendText(csvInfo.Path);//中文为乱码
                            //sw.WriteLine(csvInfo.Line);
                            //sw.Dispose();
                            FileStream fs = null;
                            StreamWriter sw = null;
                            fs = new FileStream(csvInfo.Path, System.IO.FileMode.Append, System.IO.FileAccess.Write);
                            sw = new StreamWriter(fs, System.Text.Encoding.Default);
                            sw.WriteLine(csvInfo.Line);
                            sw.Close();
                            fs.Close();
                        }
                    }
                    catch
                    {

                    }
                }
                Thread.Sleep(20);
            }
        }

        public void WriteLine(string path, string line)
        {
            FunctionSub.Close_Excel_Process();//加载参数前，判断有没有打开Excel，打开的话关掉
            CsvInfo csvInfo = new CsvInfo();
            PathHelper(path);                 //if the path is not exit? creat it by auto
            csvInfo.Path = path;
            csvInfo.Line = line;
            queue.Enqueue(csvInfo);

        }

        private void PathHelper(string path)
        {
            string[] Split = path.Split('\\');
            string pathtemp = string.Empty;
            try
            {

                if (!System.IO.File.Exists(path))
                {
                    for (int i = 0; i < Split.Length - 1; i++)
                    {
                        if (Split[i] != string.Empty)
                            pathtemp += Split[i] + "\\";
                    }
                    DirectoryInfo dir = new DirectoryInfo(pathtemp);
                    dir.Create();                  //创建文件夹
                }
            }
            catch
            {
                throw;
            }
        }

    }

    public class CsvInfo
    {
        public string Path { get; set; }
        public string Line { get; set; }
    }
}
