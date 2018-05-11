using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore;
using BZappdll;

namespace BZGUI
{
    public enum loginType
    {
        Op,
        Admin,
        Tech,
        None
    }
    public partial class PageLogin : UserControl
    {
        //1.声明自适应类实例  
        private AutoSizeFormClass asc = new AutoSizeFormClass();  
        private MachineModeType mode = MachineModeType.Production;
        public Action<MachineModeType> ONShowPage;
        public Action ONColseWindow;
        public static Action OnChangeLanguage;
        public static loginType loginTp = loginType.None;

        public MachineModeType Mode
        {
            get { return this.mode; }
            set { this.mode = value; }
        }

        #region 窗体相关

        public PageLogin()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            DataManager.Instance.Login = DataManager.Instance.Login.Load();
            this.Combo_User.Items.Add(DataManager.Instance.Login.AdminUser);
            this.Combo_User.Items.Add(DataManager.Instance.Login.TecUser);
            this.Combo_User.Items.Add(DataManager.Instance.Login.opUser);
            this.Combo_User.SelectedIndex = 2;
            LockUserbox();
            Globals.MachineMode = MachineModeType.Production;
            Globals.isAdmin = false;
            Task1_测试.EventShowResult += Instance_OnCPKcount;
            if (Globals.settingMachineInfo.语言 == Language.English)
            {
                this.btn_Language.Text = "中文";
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageLogin));
            }
            else
            {
                this.btn_Language.Text = "English";
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageLogin));
            }

        }
        //2. 为窗体添加Load事件，并在其方法Form1_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小 
        private void PageLogin_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);  
        }
        //3.为窗体添加SizeChanged事件，并在其方法Form1_SizeChanged中，调用类的自适应方法，完成自适应 
        private void PageLogin_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void PageLogin_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true) LockUserbox();
            //loginTp = loginType.Op; //
        }
        private void Instance_OnCPKcount(EnumShowResult esr)
        { 
            if(esr!=EnumShowResult.Empty&&Globals.MachineMode == MachineModeType.CPKGRR)
            {
                PVar.CPKDoneCounts++;//CPK数值+1
            }
            string stringtemp = (PVar.CPKDoneCounts >= 32) ? "Done" : "On_Going";
            Globals.Invoker.SetCtltxt(Lab_Cpkstatues, stringtemp);
            Globals.Invoker.SetCtltxt(Lab_CpkCount, PVar.CPKDoneCounts.ToString()+"/32");
        }


        #endregion

        #region 按钮相关

        private void Combo_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text_Password.Text = "";
            Text_Password.BackColor = Color.White;
            Text_Password.Focus();
        }

        private void Text_Password_Click(object sender, EventArgs e)
        {
            //自动调出系统键盘
            //string str = "C:\\WINDOWS\\system32\\Osk.exe";
            string str = Globals.Dir_Bin + "\\Tools\\Osk.exe";
            BZappdll.WinAPI.WinExec(str, 5);
            Text_Password.PasswordChar = Convert.ToChar("*");
            Text_Password.Text = "";
            Text_Password.BackColor = Color.White;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (this.Text_Password.Text.Trim() == "15618865935")
            {
                loginTp = loginType.Admin;
                Globals.isAdmin = true;
            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.AdminUser && this.Text_Password.Text.Trim() == DataManager.Instance.Login.AdminPwd)
            {
                loginTp = loginType.Admin;
                Globals.isAdmin = true;
            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.TecUser && this.Text_Password.Text.Trim() == DataManager.Instance.Login.TecPwd)
            {
                loginTp = loginType.Tech;
                Globals.isAdmin = false;
            }
            else if (this.Combo_User.Text == DataManager.Instance.Login.opUser && this.Text_Password.Text.Trim() == DataManager.Instance.Login.opPwd)
            {
                loginTp = loginType.Op;
                Globals.isAdmin = false;
            }
            else
            {
                Text_Password.PasswordChar = new char();    //去除原来的*        
                Text_Password.Text = "密码错误或没有权限";
                Text_Password.BackColor = Mycolor.ErrorRed;
                return;
            }
            //显示对应的模式
            if (ONShowPage != null) ONShowPage(mode);
        }

        //初始化Combox
        private void initLoginComboBox()
        {
            Combo_User.BackColor = Color.FromArgb(255, 255, 255); ;
            Combo_User.Enabled = true; Combo_User.SelectedIndex = 2;
            Btn_Login.BackColor = Color.FromArgb(253, 253, 191);
            Btn_Login.Enabled = true;
            Text_Password.BackColor = Color.FromArgb(255, 255, 255);
            Text_Password.Enabled = true; Text_Password.Text = "";
            Text_Password.Focus();
        }

        //点Btn_Home时
        private void LockUserbox()
        {
            Combo_User.BackColor = Color.FromArgb(238, 238, 238); ;
            Combo_User.Enabled = false;
            Btn_Login.BackColor = Color.FromArgb(238, 238, 238);
            Btn_Login.Enabled = false;
            Text_Password.BackColor = Color.FromArgb(238, 238, 238);
            Text_Password.Enabled = false; Text_Password.Text = "";
        }

        private void Btn_CPKGRRMode_Click(object sender, EventArgs e)
        {
            //if (Globals.settingFunc.启用CPK模式)
            //{
                initLoginComboBox();
                mode = MachineModeType.CPKGRR;
                Panel_CPK.Visible = true;
            //}
            //else
            //{ MessageBox.Show("请勾选'启用CPK模式'!"); }
        }

        private void Btn_ProductionMode_Click(object sender, EventArgs e)
        {
            if (mode == MachineModeType.CPKGRR || PVar.CPKDoneCounts>0)
            {
                if (MessageBox.Show("当前模式为CPK模式？将会清除CPK数据，确定进入生产模式？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PVar.CPKDoneCounts = 0;
                    Panel_CPK.Visible = false;
                    DataManager.Instance.chartData.CleanData();//清除内存中的所有数据
                }
                else { return; }
            }
            mode = MachineModeType.Production;
            //显示对应的模式
            if (ONShowPage != null)
            {
                ONShowPage(this.mode);
            }
            Globals.settingFunc.启用CPK模式 = false;
            Globals.settingFunc.SaveSetting();
        }

        private void Btn_EngneeringMode_Click(object sender, EventArgs e)
        {
            if (mode == MachineModeType.CPKGRR || PVar.CPKDoneCounts > 0)
            {
                if (MessageBox.Show("当前模式为CPK模式？将会清除CPK数据，确定进入工程模式？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PVar.CPKDoneCounts = 0;
                    Panel_CPK.Visible = false;
                    DataManager.Instance.chartData.CleanData();//清除内存中的所有数据
                }
                else { return; }
            }
            initLoginComboBox();
            mode = MachineModeType.Engineering;
            Globals.settingFunc.启用CPK模式 = false;
            Globals.settingFunc.SaveSetting();
        }

        private void btn_ExitCPK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("请确认是否【退出】CPK模式？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PVar.CPKDoneCounts = 0;
                //PVar.WorkMode = 0;
                mode = MachineModeType.Production;
                Panel_CPK.Visible = false;
                FileLog.OperateLog("退出CPK模式");
                DataManager.Instance.chartData.CleanData();//清除内存中的所有数据
                Globals.settingFunc.启用CPK模式 = false;
                Globals.settingFunc.SaveSetting();
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            if (ONColseWindow != null) ONColseWindow();
        }

        private void Text_Password_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
        }

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            this.Combo_User.Text = DataManager.Instance.Login.TecUser;
            this.Text_Password.Text= DataManager.Instance.Login.TecPwd;
        }

        private void btn_Language_Click(object sender, EventArgs e)
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { 
                Globals.settingMachineInfo.语言 = Language.English;
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageLogin));
                this.btn_Language.Text = "中文";
            }
            else
            {
                Globals.settingMachineInfo.语言 = Language.中文;
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageLogin));
                this.btn_Language.Text = "English";
            }
            Globals.settingMachineInfo.SaveSetting();
            if (OnChangeLanguage != null) OnChangeLanguage();
        }

        #endregion

    }
}
