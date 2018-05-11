using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using BZ.UI;
using BZappdll;

namespace BZGUI
{
    public partial class PageMachineInfo : UserControl
    {
        //1.声明自适应类实例  
        AutoSizeFormClass asc = new AutoSizeFormClass();  

        public PageMachineInfo()
        {
            InitializeComponent();
            PageLogin.OnChangeLanguage += Instance_LanguageChange;
        }

        private void PageMachineInfo_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this); 
            //MeshineSW版本号在申明修改即可
            Label_SoftwareVersion.Text = "SV: " + System.Convert.ToString(Conversion.Val(Strings.Left(PVar.MeshineSW.Substring(1), 1))) + "." + System.Convert.ToString(Conversion.Val(Strings.Left(PVar.MeshineSW.Substring(3), 1))) + "." + System.Convert.ToString(Conversion.Val(Strings.Left(PVar.MeshineSW.Substring(4), 1)));
            Globals.Invoker.SetCtltxt(Label_TotalLifeCycle, DataManager.Instance.currentyield.TotalLifeCycles + " PCS");
            Globals.Invoker.SetCtltxt(Label_TotalLifeRejects, DataManager.Instance.currentyield.TotalLifeRejects + " PCS");
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageMachineInfo));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageMachineInfo));
        }

        private void PageMachineInfo_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            if (PVar.ParList.CheckSts[3]) //左右机切换
            {
                Label34.Text = "OUTPUT";
                Label28.Text = "INPUT";
                Label58.Visible = false;
                Label61.Visible = false;
                Label53.Visible = true;
                Label54.Visible = true;
            }
            else
            {
                Label34.Text = "OUTPUT";
                Label28.Text = "INPUT";
                Label58.Visible = true;
                Label61.Visible = true;
                Label53.Visible = false;
                Label54.Visible = false;
                Label34.Location = new Point(13, 154);
                Label28.Location = new Point(319, 154);
                Label33.Location = new Point(319, 186);
                Label6.Location = new Point(13, 186);
            }

            //PVar.TotalLifeCycles = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeCycles", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
            //PVar.TotalLifeRejects = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeRejects", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
            //Label_TotalLifeCycle.Text = PVar.TotalLifeCycles + " PCS";
            //Label_TotalLifeRejects.Text = PVar.TotalLifeRejects + " PCS";
            Globals.Invoker.SetCtltxt(Label_TotalLifeCycle, DataManager.Instance.currentyield.TotalLifeCycles + " PCS");
            Globals.Invoker.SetCtltxt(Label_TotalLifeRejects, DataManager.Instance.currentyield.TotalLifeRejects + " PCS");
        }


        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageMachineInfo)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageMachineInfo)); }
        }


    }
}
