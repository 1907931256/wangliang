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
    public partial class PageVision : UserControl
    {
        private AutoSizeFormClass asc = new AutoSizeFormClass();  
        private FrmLaser frmlaser;
        private bool IsExeOpen = false;                //判断EXE有没有打开
        private string m_EXEname = "TCP/UDP Socket 调试工具 V2.2";
        private string m_EXEprocessname = "SocketTool";
        private string m_EXEpath="D:\\SocketTool.exe";

        public PageVision()
        {
            InitializeComponent();
            #region 加载界面根据机种
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            {
                frmlaser = new FrmLaser();
                frmlaser.TopLevel = false;//重要的一步，否则会报无法顶级控件添加到控件
                this.panel1.Controls.Add(frmlaser);
                frmlaser.Show();
            }
            else
            {
                //Loadexe();
            }
            #endregion
            PageLogin.OnChangeLanguage += Instance_LanguageChange; 
        }

        private void PageVision_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageVision));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageVision));
        }

        private void PageVision_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageVision)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageVision)); }
        }

        private void label_ShowSetting_Click()
        {
            this.xSettingGrid1.Visible = !(this.xSettingGrid1.Visible);
        }

        //加载EXE
        private void Loadexe()
        {
            try
            {
                System.Diagnostics.Process[] MyProcesess = System.Diagnostics.Process.GetProcesses();
                for (int i = 1; i <= MyProcesess.Length - 1; i++)
                {
                    if (MyProcesess[i].ProcessName == m_EXEprocessname.Split('.')[0])                //"SocketTool"
                    {
                        //MyProcesess[i].Kill();
                        IsExeOpen = true;
                        break;
                    }
                    else
                    {
                        IsExeOpen = false;
                    }
                }

                if (!IsExeOpen)//如果EXE没有打开，就打开
                {
                    string strPath = m_EXEpath;                                  //Environment.CurrentDirectory + @"\Tools\APIfinder\EliteSpy.exe";
                    System.Diagnostics.Process.Start(strPath);
                    Thread.Sleep(2000);
                }
                this.panel1.Controls.Clear();                                               //   清除pannel
                IntPtr h = BZappdll.WinAPI.FindWindow(null, m_EXEname);                  //"TCP/UDP Socket 调试工具 V2.2"
                //关键在这里           
                var frm = (Control)Form.FromHandle(h);
                BZappdll.WinAPI.SetParent(h, this.panel1.Handle);                                       //嵌套到panel_CCD内              
                BZappdll.WinAPI.SendMessage(h.ToInt32(), BZappdll.WinAPI.WM_SYSCOMMAND, BZappdll.WinAPI.SC_MAXIMIZE, 0);
                BZappdll.WinAPI.ShowWindow(h.ToInt32(), BZappdll.WinAPI.SW_SHOW);
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
