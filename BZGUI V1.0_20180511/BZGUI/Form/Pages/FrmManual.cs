using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore;
using BZappdll;

namespace BZGUI
{
    public partial class FrmManual : Form
    {
        #region 变量定义
        private SSHTestGUI sshGUI;
        private SSH_IDPM_GUI sshIDPM;
        private FrmMMSManual MMSmanual;
        private FrmIPDMManual IPDMmanual;
        //1.声明自适应类实例  
        private BZappdll.AutoSizeFormClass asc = new AutoSizeFormClass();  
        #endregion

        #region 窗体操作
        public FrmManual()
        {
            InitializeComponent();  
            #region 加载界面根据机种
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            {
                sshGUI = new SSHTestGUI();
                sshGUI.TopLevel = false;//重要的一步，否则会报无法顶级控件添加到控件
                this.panel_SSH.Controls.Add(sshGUI);
                sshGUI.Show();

                MMSmanual = new FrmMMSManual();
                MMSmanual.TopLevel = false;
                this.panel_Manual.Controls.Add(MMSmanual);
                MMSmanual.Show();
            }
            else
            {
                sshIDPM = new SSH_IDPM_GUI();
                sshIDPM.TopLevel = false;//重要的一步，否则会报无法顶级控件添加到控件
                this.panel_SSH.Controls.Add(sshIDPM);
                sshIDPM.Show();

                IPDMmanual = new FrmIPDMManual();
                IPDMmanual.TopLevel = false;
                this.panel_Manual.Controls.Add(IPDMmanual);
                IPDMmanual.Show();
            }
            #endregion
            if (PageLogin.loginTp != loginType.Admin)
            {
                this.tabControl1.TabPages[3].Parent = null;    //4已经不显示，所以这个还是4
            }
            //2. 为窗体添加Load事件，并在其方法Form1_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小  
            asc.controllInitializeSize(this);
            PageLogin.OnChangeLanguage += Instance_LanguageChange;
        
        }

        private void FrmManual_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.inputClass1.Timer.Enabled = true;
            this.outputClass1.Timer.Enabled = true;
            this.motorStatus1.Timer.Enabled = true;
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(FrmManual));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(FrmManual));
        }

        private void FrmManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出手动调试？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try { }
                catch
                { MessageBox.Show("退出的时候出错！"); }
                this.Dispose();
                this.Close(); 
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.inputClass1.Timer.Enabled = false;
            this.outputClass1.Timer.Enabled = false;
            this.motorStatus1.Timer.Enabled = false;
        }

        //3.为窗体添加SizeChanged事件，并在其方法Form1_SizeChanged中，调用类的自适应方法，完成自适应  
        private void FrmManual_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);  
        }

        #endregion

        #region 按钮操作

        #endregion

        #region Private support

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(FrmManual)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(FrmManual)); }
        }

        #endregion

    }
}
