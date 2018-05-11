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
    public partial class PageChart : UserControl
    {
        //1.声明自适应类实例  
        private AutoSizeFormClass asc = new AutoSizeFormClass(); 

        public PageChart()
        {
            InitializeComponent();
            PageLogin.OnChangeLanguage += Instance_LanguageChange;
        }

        private void PageChart_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageChart));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageChart));
        }

        private void PageChart_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void chartUPH30Day1_Load(object sender, EventArgs e)
        {
            this.chartUPH30Day1.DataShow = DataManager.Instance.uph.UPHDay;//show current day 's UPH
            this.timer1.Enabled = true;
            RefreshUi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Visible) RefreshUi();
        }

        private void RefreshUi()
        {
            DataManager.Instance.yieldManger.Load();
            DataManager.Instance.toosingManger.Load();
            DataManager.Instance.uphManger.Load();
            int index = 0;
            var data = new double[30];
            foreach (var item in DataManager.Instance.yieldManger.YieldMap)
            {
                var dat = DataManager.Instance.yieldManger.YieldMap.Values.ToArray();
                data[index] = item.Value.YieldRate;

                index++;
            }
            chart30Day1.DataShow = data;

            index = 0;
            data = new double[30];
            foreach (var item in DataManager.Instance.toosingManger.ToosingMap)
            {
                var dat = DataManager.Instance.toosingManger.ToosingMap.Values.ToArray();
                data[index] = item.Value.Toosing_Assemble;
                index++;
            }
            chart30Day2.DataShow = data;
        }

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageChart)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageChart)); }
        }

    }
}
