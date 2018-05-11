using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAB
    {
    static class Program
        {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
            {
            bool isCanStart;
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "AA", out   isCanStart);
            if (isCanStart)
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_LoadProcess());
            }
            else
                {
                MessageBox.Show(" 程序已运行! ", "【提示】", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
