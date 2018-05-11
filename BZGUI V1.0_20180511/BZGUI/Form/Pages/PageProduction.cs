using System;
using System.IO;
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
    public partial class PageProduction : UserControl
    {
        #region 变量定义
        private AutoSizeFormClass asc = new AutoSizeFormClass();
        public static Action OnFlashToCPKchart;
        public static event Action On_Errorbtn;
        #endregion

        #region 窗体操作
        public PageProduction()
        {
            InitializeComponent();
            PageLogin.OnChangeLanguage += Instance_LanguageChange;
        }

        private void PageProduction_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this); 

            #region 按钮设置
            this.AlarmStatus.BZ_ShowMode = true;
            this.AlarmStatus.ForeColor = Color.Black;
            this.AlarmStatus.BZ_Color = PVar.BZColor_SelectedBtn;
            this.AlarmStatus.Text = "No Alarm";
            this.AlarmTime.ForeColor = Color.Black;
            this.AlarmTime.BZ_Color = PVar.BZColor_SelectedBtn;
            this.AlarmTime.BZ_SmallText = "Alarm Time";
            this.AlarmTime.BZ_BigText = "00:00:00";
            this.UPH.ForeColor = Color.Black;
            this.UPH.BZ_Color = Color.FromArgb(253, 253, 191);
            this.UPH.BZ_SmallText = "UPH";
            this.UPH.BZ_BigText = "230";
            this.MaterialLevel.ForeColor = Color.Black;
            this.MaterialLevel.BZ_Color = PVar.BZColor_SelectedBtn;
            this.MaterialLevel.BZ_SmallText = "Material";
            this.MaterialLevel.BZ_BigText = "High";
            #endregion

            Task1_测试.EventShowResult += new Action<EnumShowResult>(OnshowResult);
            Task1_测试.OnFlashDataPage += Instance_ShowCPK;//读取一次数据，事件发生的时候   
            Task1_MMS测试.EventShowResult += new Action<EnumShowResult>(OnshowResult);
            Task1_MMS测试.OnFlashDataPage += Instance_ShowCPK;//读取一次数据，事件发生的时候  

            XAlarmReporter.Instance.OnSaveAlarmReport += Instance_OnAlarmReportSave;
            XAlarmReporter.Instance.OnAlarmCleared += Instance_OnAlarmReportSave;
            this.timer1.Enabled = true;
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageProduction));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageProduction));
        }

        private void PageProduction_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void PageProduction_VisibleChanged(object sender, EventArgs e)
        {
            this.timer1.Enabled = (this.Visible == true) ? true : false;
        }

        #endregion

        #region 按钮操作

        private void Btn_Yield_Click(object sender, EventArgs e)
        {
            //一次性良率
        }

        private void Btn_Retest_Click(object sender, EventArgs e)
        {
            //这个其实是复测良率
            DialogResult rt = MessageBox.Show("点击\r\n“是”清除总良率和当前良率\r\n“否”清除当前良率与当前产量\r\n ", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (rt == DialogResult.Yes)
            {
                DataManager.Instance.currentyield.ResetCurrent(true, true);
            }
            else if (rt == DialogResult.No)
            {
                DataManager.Instance.currentyield.ResetCurrent();
            }
            this.chartYield1.Clear();
        }
        /// <summary>
        /// 清除当前产量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("“是否”清除当前良率与当前产量\r\n ", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                DataManager.Instance.currentyield.ResetCurrent();
            }
        }

        #endregion

        #region timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.chartYield1.SetDayOkRate = DataManager.Instance.currentyield.CurrentYieldRate;
            this.chartYield1.SetMonthOkRate = DataManager.Instance.currentyield.MonthYieldRate;
            this.UPH.BZ_BigText = DataManager.Instance.uph.UPHcurrentHour().ToString();
            this.Text_OKCounts.Text = DataManager.Instance.currentyield.GetCurrentProduceNum()[0].ToString();
            this.Text_NGCounts.Text = (DataManager.Instance.currentyield.GetCurrentProduceNum()[1] - DataManager.Instance.currentyield.GetCurrentProduceNum()[0]).ToString();
            this.txtCount.Text = DataManager.Instance.currentyield.CurrentTotal.ToString();
            this.txt_Yield.Text = DataManager.Instance.currentyield.CurrentYieldRate.ToString();
        }

        #endregion

        #region Private Surport
        /// <summary>
        /// 显示结果
        /// </summary>
        /// <param name="ESR"></param>
        private void OnshowResult(EnumShowResult ESR)
        {
            switch (ESR)
            {
                case EnumShowResult.Empty:
                    this.chartYield1.setOK_NG("--");
                    break;
                case EnumShowResult.NG:
                    this.chartYield1.setOK_NG("NG");
                    break;
                case EnumShowResult.OK:
                    this.chartYield1.setOK_NG("OK");
                    break;
            }

        }

        //from task
        private void Instance_ShowCPK()
        {
            //从近100个数据中取
            double[,] CPKdata = new double[3, 32];
            if (OnFlashToCPKchart != null) OnFlashToCPKchart();
        }

        private void Instance_OnAlarmReportSave(XAlarmEventArgs e)
        {
            //FileLog.WriteErrLog(e.Category+"_"+e.Description);//报警文档都保存到本地
            #region data处理
            string[] cellValues = new string[]{
                    e.StartTime.ToString("yyyy-MM-dd"),
                    e.StartTime.ToString("HH:mm:ss"),
                    e.Code.ToString(),
                    e.Category,
                    e.Duration.ToString(),
                    e.Description
                };
            cellValues[2] = Globals.dt_ErrCode.Rows[e.Code][1].ToString();// 把e.code变成ERR-ESB01-10001,第2行固定为RESET
            cellValues[3] = Globals.dt_ErrCode.Rows[e.Code][2].ToString();// English discribtion
            string Locationpath = Globals.Dir_Record_Alarm + "\\" + cellValues[0] + "\\" + cellValues[0] + "_LocationErrorCode.csv";
            string Updatepath = Globals.Dir_Record_Alarm + "\\" + cellValues[0] + "\\" + cellValues[0] + "_UpdateErrorCode.csv";
            Globals.comf.IsDirExist(Locationpath);//建立对应的文件夹
            Globals.comf.IsDirExist(Updatepath);
            string strHeader = "Time,Project,Vendor,BU,Floor,Line,AEID,AESUB_ID,Time Mode,ErrorCode,Description,Color,Notes";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Clear();
            stringBuilder.Append(cellValues[0] + " " + cellValues[1]);
            stringBuilder.Append("," + Globals.settingMachineInfo.Project);
            stringBuilder.Append("," + Globals.settingMachineInfo.Vendor);
            stringBuilder.Append("," + Globals.settingMachineInfo.BU);
            stringBuilder.Append("," + Globals.settingMachineInfo.Floor);
            stringBuilder.Append("," + Globals.settingMachineInfo.Line);
            stringBuilder.Append("," + Globals.settingMachineInfo.AEID);
            stringBuilder.Append("," + Globals.settingMachineInfo.AESUB_ID);
            #endregion
            #region TimeMode处理
            string timemode = (e.Code == 2) ? "1" : "0";
            stringBuilder.Append("," + timemode);//timemode
            stringBuilder.Append("," + cellValues[2]);//ErrorCode
            stringBuilder.Append("," + cellValues[3]);//English Description
            bool needsave_csv = false;
            if (e.Code == 2)//2 is RST-------//color//Timemode=true 1 为正常，FALSE 0 位异常
            {
                PVar.LampStatus = 30;
                stringBuilder.Append(",Green");
                if (!Globals.settingFunc.TimeMode)
                {
                    Globals.settingFunc.TimeMode = true;
                    needsave_csv = true;
                }
                this.AlarmStatus.BZ_Color = PVar.BZColor_SelectedBtn;
                this.AlarmStatus.Text = "Alarm";
                this.AlarmTime.BZ_Color = PVar.BZColor_SelectedBtn;
                this.AlarmTime.BZ_BigText = "00:00:00";
            }
            else 
            {
                PVar.LampStatus = 10;
                stringBuilder.Append(",Red");
                if (Globals.settingFunc.TimeMode)
                {
                    Globals.settingFunc.TimeMode = false;
                    needsave_csv = true;
                }
                PVar.Ring_EN = true;//buzzer
                if(On_Errorbtn!=null)On_Errorbtn();
                this.AlarmStatus.BZ_Color = PVar.BZColor_ErrorRed;
                this.AlarmStatus.Text = "Alarm";
                this.AlarmTime.BZ_Color = PVar.BZColor_ErrorRed;
                this.AlarmTime.BZ_BigText = e.StartTime.ToString("HH:mm:ss");
            }              
            //cellValues[5] = Globals.dt_ErrCode.Rows[2][3].ToString();//  中文说明
            stringBuilder.Append("," + cellValues[5]);
            if (needsave_csv)
            {
                if (File.Exists(Locationpath) == false) CsvServer.Instance.WriteLine(Locationpath, strHeader);
                if (File.Exists(Updatepath) == false && Globals.settingFunc.ErrorCode是否上传) CsvServer.Instance.WriteLine(Updatepath, strHeader);
                if (Globals.settingFunc.ErrorCode是否上传) CsvServer.Instance.WriteLine(Updatepath, stringBuilder.ToString());
                CsvServer.Instance.WriteLine(Locationpath, stringBuilder.ToString());
            }
            #endregion
            stringBuilder.Clear();
        }

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageProduction)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageProduction)); }
        }

        #endregion

    }
}
