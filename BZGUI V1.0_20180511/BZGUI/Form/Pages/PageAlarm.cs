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
    public partial class PageAlarm : UserControl
    {
        //1.声明自适应类实例  
        private AutoSizeFormClass asc = new AutoSizeFormClass();  
        private string[] columnHeads = new string[] { "Date", "Time", "Code", "Category", "Duration", "Description" };
        DataTable dt = new DataTable();
        BZappdll.ComSub com = new ComSub();
        private string path;

        public PageAlarm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            InitDataGridView();
            InitErrcodeGridView();
            XAlarmReporter.Instance.OnSaveAlarmReport += Instance_OnAlarming;
            XAlarmReporter.Instance.OnAlarmCleared += Instance_OnAlarmCleared;
            PageLogin.OnChangeLanguage += Instance_LanguageChange;
            this.alarmChart1.DataShowCode = DataManager.Instance.alarmRecord.AlarmCodeArr;//Pi图显示

        }
        private void PageAlarm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            if (Globals.settingMachineInfo.语言 == Language.English)
                BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageAlarm));
            else
                BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageAlarm));
        }

        private void PageAlarm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void InitDataGridView()
        {
            try
            {
                path = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_异常日志" + ".csv";
                if (System.IO.File.Exists(path) == false)//写表头
                {
                    string strtemp = "";
                    for (int i = 0; i < columnHeads.Length; i++)
                    {
                        strtemp = strtemp + columnHeads[i] + ",";
                    }
                    strtemp = strtemp.Substring(0, strtemp.Length - 1);//去掉最后一个","
                    Globals.comf.IsDirExist(path);//建立对应的文件夹
                    Globals.csv.WriteStringToCsv(path, strtemp);
                }
                dt = Globals.csv.OpenCSV(path);
                this.dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToOrderColumns = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            { }
        }

        private void InitErrcodeGridView()
        {
            try
            {
                this.dataGridView2.DataSource = Globals.dt_ErrCode;
                this.dataGridView2.RowHeadersVisible = false;      //隐藏行头
                this.dataGridView2.ColumnHeadersVisible = false;
                this.dataGridView2.AllowUserToResizeColumns = false;//禁止resize列宽
                this.dataGridView2.AllowUserToResizeRows = false;
                this.dataGridView2.AutoResizeColumnHeadersHeight();
                this.dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;      //对齐方式
                this.dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                   //对齐方式 
            }
            catch (Exception)
            { }
        }

        private void Instance_OnAlarming(XAlarmEventArgs e)
        {
            try
            {
                this.BeginInvoke(new Action(() =>
                {
                    string[] cellValues = new string[]{
                    e.StartTime.ToString("yyyy/MM/dd"),
                    e.StartTime.ToString("HH:mm:ss"),
                    e.Code.ToString(),
                    e.Category,
                    e.Duration.ToString(),
                    e.Description
                };
                    DataRow dr1 = dt.NewRow();
                    for (int i = 0; i < 6; i++)
                    {
                        dr1[i] = cellValues[i];
                    }
                    //dt.Rows.Add(dr1);
                    dt.Rows.InsertAt(dr1, 0);
                    this.LB_CodeDescription.Items.Clear();
                    this.LB_CodeDescription.Items.Add("ErrorCode :" + e.Code + "  Category:" + e.Category);
                    this.LB_CodeDescription.Items.Add("Description :" + e.Description);
                    SavecsvLog();

                    //for alarm statistics
                    DataManager.Instance.alarmRecord.AlarmCodeArr[Math.Abs(e.Code)] += 1;
                    DataManager.Instance.alarmRecord.Save();
                }));
            }
            catch { }
        }

        private void Instance_OnAlarmCleared(XAlarmEventArgs args)
        {
            try
            {
                this.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        TimeSpan duration = DateTime.Now - args.StartTime;
                        dataGridView1.Rows[0].Cells[4].Value = duration.Hours.ToString("00") + ":" + duration.Minutes.ToString("00") + ":" + duration.Seconds.ToString("00");
                        SavecsvLog();
                    }
                    catch
                    {

                    }
                }));
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.LB_CodeDescription.Items.Clear();
                this.LB_CodeDescription.Items.Add("ErrorCode :" + dataGridView1[2, e.RowIndex].Value/*code*/ + "  Category:" + dataGridView1[3, e.RowIndex].Value/*category*/);
                this.LB_CodeDescription.Items.Add("Description :" + dataGridView1[5, e.RowIndex].Value/*Description*/);
            }
            catch (Exception)
            { }
        }

        private void SavecsvLog()
        {
            try
            {
                path = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_异常日志" + ".csv";
                if (System.IO.File.Exists(path) == false)//写表头
                {
                    string strtemp = "";
                    for (int i = 0; i < columnHeads.Length; i++)
                    {
                        strtemp = strtemp + columnHeads[i] + ",";
                    }
                    strtemp = strtemp.Substring(0, strtemp.Length - 1);//去掉最后一个","
                    Globals.comf.IsDirExist(path);//建立对应的文件夹
                    Globals.csv.WriteStringToCsv(path, strtemp);
                    dt = Globals.csv.OpenCSV(path);
                }
                Globals.csv.SaveCSV(dt, path);
            }
            catch (Exception)
            { }
        }

        private void Instance_LanguageChange()
        {
            if (Globals.settingMachineInfo.语言 == Language.中文)
            { BZappdll.LanguageHelper.SetLang("zh-CN", this, typeof(PageAlarm)); }
            else
            { BZappdll.LanguageHelper.SetLang("en-US", this, typeof(PageAlarm)); }
        }


    }
}
