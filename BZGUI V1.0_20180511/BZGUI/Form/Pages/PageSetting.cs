using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BZappdll;

namespace BZGUI
{
    public partial class PageSetting : UserControl
    {
        //1.声明自适应类实例  
        AutoSizeFormClass asc = new AutoSizeFormClass();  

        public PageSetting()
        {
            InitializeComponent();
            PageLogin.OnChangeLanguage += Instance_LanguageChange; 
        }
        //2. 为窗体添加Load事件，并在其方法Form1_Load中，调用类的初始化方法，记录窗体和其控件的初始位置和大小 
        private void PageSetting_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageSetting));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageSetting));
        }
        //3.为窗体添加SizeChanged事件，并在其方法Form1_SizeChanged中，调用类的自适应方法，完成自适应 
        private void PageSetting_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageSetting)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageSetting)); }
        }


    }
}
