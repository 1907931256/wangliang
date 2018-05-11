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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Xml;

namespace BZGUI
{
	
	public partial class Frm_AlarmInfo
	{
        public static Frm_AlarmInfo fAlarmInfo = null;     
		private List<AlarmStatistics> m_AlarmHistoryDataList = new List<AlarmStatistics>(); 
		private List<CategoryStatistics> m_AlarmCategoryDataList = new List<CategoryStatistics>();

        public Frm_AlarmInfo()
            {
            InitializeComponent();
            fAlarmInfo = this;
            }


        private void Frm_AlarmInfo_Load(object sender, EventArgs e)
            {
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.fMain.Main_Color;

            AlarmDataViewInit();

            DateTime LastDay = default(DateTime);
            DateTime FirstDay = default(DateTime);
            LastDay = DateAndTime.DateAdd("d", -0, DateTime.Now.Date);
            FirstDay = DateAndTime.DateAdd("d", -30, DateTime.Now.Date);
            LoadAlarmHistoryData(FirstDay, LastDay);
            LoadAlarmHistoryToDataGrid();
            LoadAlarmHistoryToPieChart();
            }
		
		public struct DataViewInfo1
		{
			public string ColumnName;
			public string HeaderText;
			public int Width;
			public DataViewInfo1(string HeaderName, string Header, int HeaderWidth)
			{
				ColumnName = HeaderName;
				HeaderText = Header;
				Width = HeaderWidth;
			}
		}
		
		public DataViewInfo1[] AlarmViewInfo = new DataViewInfo1[] {
				new DataViewInfo1("C0", "Num", 40),
				new DataViewInfo1("C1", "Data", 100),
				new DataViewInfo1("C2", "Time", 100),
				new DataViewInfo1("C3", "Code", 200),
				new DataViewInfo1("C4", "Category", 122),
				new DataViewInfo1("C5", "Duration", 90)};
			
			
			public void AlarmDataViewInit()
			{
				DataGridView_ErrorCode.AllowUserToAddRows = false;
				DataGridView_ErrorCode.RowTemplate.Height = 23; //行高度设置
				DataGridView_ErrorCode.RowHeadersWidth = 14; //行头的宽度设置
				DataGridView_ErrorCode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				DataGridView_ErrorCode.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 13);
				DataGridView_ErrorCode.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				DataGridView_ErrorCode.RowsDefaultCellStyle.Font = new Font("宋体", 13);
				
				for (int i = 0; i <= AlarmViewInfo.Length - 1; i++)
				{
                DataGridView_ErrorCode.Columns.Add(System.Convert.ToString(AlarmViewInfo[i].ColumnName), System.Convert.ToString(AlarmViewInfo[i].HeaderText));
                    DataGridView_ErrorCode.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    DataGridView_ErrorCode.Columns[i].Width = AlarmViewInfo[i].Width;
                    DataGridView_ErrorCode.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
				}
			}
			
			
			public struct CategoryStatistics ////报警统计信息
			{
				public string Category;
				public double Rate;
			}
			public struct AlarmStatistics ////报警统计信息
			{
				public DateTime dDate;
				public string strBeginTime;
				public string strEndTime;
				public string strErrcode;
				public string strCategory;
			}
			public AlarmStatistics NowAlarmStatistics;
			
			
			
			public void LoadAlarmHistoryData(DateTime FirstDay, DateTime LastDay)
			{
				AlarmStatistics tmpSt = new AlarmStatistics();
				string tmpDate = "";
				string tmpString = "";
				int tmpNum = 0;
				m_AlarmHistoryDataList.Clear();
				for (int i = 0; i <= (LastDay - FirstDay).TotalDays; i++)
				{
                tmpDate = System.Convert.ToString(DateAndTime.DateAdd("d", System.Convert.ToDouble(-i), LastDay).ToString("yyyyMMdd"));
					tmpNum = int.Parse(BVar.FileRorW.ReadINI(tmpDate, "TotalAlarmNum", "0", "D:\\BZ-Parameter\\BAM\\AlarmHistoryData.ini"));
					if (tmpNum <= 0)
					{
						continue;
					}
					for (int j = tmpNum; j >= 1; j--)
					{
						tmpString = BVar.FileRorW.ReadINI(tmpDate, "Alarm" + (j).ToString(), "00:00:00,00:00:00,F0000,Not Known", "D:\\BZ-Parameter\\BAM\\AlarmHistoryData.ini");
						FormatAlarmHistoryString(tmpSt, tmpString);
						tmpSt.dDate = DateAndTime.DateAdd("d", System.Convert.ToDouble(- i), LastDay);
						m_AlarmHistoryDataList.Add(tmpSt);
					}
				}
				AlarmDataGridView_CellContentClick(null, null);
				
				for (var i = 30; i <= 50; i++)
				{
                BVar.FileRorW.DelIniSec(System.Convert.ToString(DateAndTime.DateAdd("d", System.Convert.ToDouble(-i), DateTime.Now.Date).ToString("yyyyMMdd")), "D:\\BZ-Parameter\\BAM\\AlarmHistoryData.ini");
				}
				
			}
			
#region 功能：格式化数据到结构体
			
			private void FormatAlarmHistoryString(AlarmStatistics tmpSt, string strTemp)
			{
				string[] strTmp = null;
				strTmp = strTemp.Split(',');
				if (strTmp.Length < 4)
				{
					strTmp = new string[4];
					strTmp[0] = "00:00:00";
					strTmp[1] = "00:00:00";
					strTmp[2] = "F0000";
					strTmp[3] = "Not Known";
				}
				tmpSt.strBeginTime = strTmp[0];
				tmpSt.strEndTime = strTmp[1];
				tmpSt.strErrcode = strTmp[2];
				tmpSt.strCategory = strTmp[3];
			}
			
#endregion
			
#region 功能：得到Err发生到解决的持续时间
			
			public string GetDuration(AlarmStatistics tmpSt)
			{
				//Return ""
				DateTime BeginTime = default(DateTime);
				DateTime EndTime = default(DateTime);
				BeginTime = DateAndTime.TimeValue(tmpSt.strBeginTime);
				if (tmpSt.strEndTime == "NotEnd")
				{
					return "Ongoing";
				}
				else
				{
					EndTime = DateAndTime.TimeValue(tmpSt.strEndTime);
					if ((EndTime - BeginTime).Hours < 0)
					{
						return ((EndTime - BeginTime).Hours + 23).ToString("00") + ":" + ((EndTime - BeginTime).Minutes + 59).ToString("00") + ":" + ((EndTime - BeginTime).Seconds + 59).ToString("00");
					}
					else
					{
						return ((EndTime - BeginTime).Hours).ToString("00") + ":" + (EndTime - BeginTime).Minutes.ToString("00") + ":" + (EndTime - BeginTime).Seconds.ToString("00");
					}
				}
			}
			
#endregion
			
#region 功能：得到Err的类别
			public string GetCategory(string strErrorCode)
			{
				if (strErrorCode.Substring(0, 9) == "ERR-Servo")
				{
					return "Servo"; //"电机驱动类异常"
				}
				else if (strErrorCode.Substring(0, 11) == "ERR-FXA01-3" || strErrorCode.Substring(0, 7) == "ERR-FXB")
				{
					return "Sensor"; //"Sensor类异常" '
				}
				else if (strErrorCode.Substring(0, 7) == "ERR-SSW" || strErrorCode.Substring(0, 7) == "ERR-CCD" || strErrorCode.Substring(0, 7) == "ERR-BSC" || strErrorCode.Substring(0, 15) == "ERR-FXA01-20001")
				{
					return "Communication"; //"通信类异常"
				}
				else if (strErrorCode.Substring(0, 7) == "WRN-PFC" || strErrorCode.Substring(0, 7) == "ALM-PFC" || strErrorCode.Substring(0, 7) == "TOS-PFC" || strErrorCode.Substring(0, 7) == "NPK-PFC")
				{
					return "Other"; //"其它类异常"
				}
				else
				{
					return "Unknown"; //"未知异常"
				}
			}
#endregion
			
#region 功能：得到Err在DataGrid里显示的背景色
			public Color GetBackColor(AlarmStatistics tmpdSt)
			{
				
				string str = GetDuration(tmpdSt);
                if (System.Convert.ToInt16(str.Substring(0, 2)) > 0)
				{
					return Color.Red;
				}
                else if (System.Convert.ToInt16(Strings.Left(str.Substring(3), 2)) > 15 && System.Convert.ToInt16(str.Substring(0, 2)) <= 0)
				{
					return Color.Yellow;
				}
				else
				{
					return Color.White;
				}
				
			}
#endregion
			
#region 功能：数据添加到DataGrid
			public void LoadAlarmHistoryToDataGrid()
			{
				try
				{
					DataGridView_ErrorCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					DataGridView_ErrorCode.Rows.Clear();
					for (int i = 0; i <= m_AlarmHistoryDataList.Count - 1; i++)
					{
						DataGridView_ErrorCode.Rows.Add();
						int tempNewRow = DataGridView_ErrorCode.RowCount - 1;
						DataGridView_ErrorCode[0, tempNewRow].Value = DataGridView_ErrorCode.RowCount;
						DataGridView_ErrorCode[1, tempNewRow].Value = m_AlarmHistoryDataList[i].dDate.ToString("MM/dd/yy");
						DataGridView_ErrorCode[2, tempNewRow].Value = m_AlarmHistoryDataList[i].strBeginTime;
						DataGridView_ErrorCode[3, tempNewRow].Value = m_AlarmHistoryDataList[i].strErrcode;
						DataGridView_ErrorCode[4, tempNewRow].Value = GetCategory(System.Convert.ToString(m_AlarmHistoryDataList[i].strErrcode)); //m_BBS1AlarmHistoryData(i).strCategory
						DataGridView_ErrorCode[5, tempNewRow].Value = GetDuration(m_AlarmHistoryDataList[i]);
						//DataGridView__ErrorCode(5, tempNewRow).Style.BackColor = Color.Yellow
						DataGridView_ErrorCode.Rows[i].DefaultCellStyle.BackColor = GetBackColor(m_AlarmHistoryDataList[i]);
						DataGridView_ErrorCode.Rows[tempNewRow].Selected = false;
					}
					if (m_AlarmHistoryDataList.Count == 0)
					{
						for (int J = 0; J <= 10; J++)
						{
							DataGridView_ErrorCode.Rows.Add();
						}
					}
				}
				catch (Exception)
				{
					
				}
			}
#endregion
			
			public void LoadAlarmHistoryToPieChart()
			{
				try
				{
					DataRow dr = default(DataRow);
					DataTable dt = new DataTable();
					
					dt.Columns.Add("X轴");
					dt.Columns.Add("Y轴");
					
					int tmpTotalAlarmNum = 0;
					CalCategory(ref tmpTotalAlarmNum);
					
					if (m_AlarmCategoryDataList.Count == 0)
					{
						dr = dt.NewRow();
						dr[0] = "NO ERROR";
						if (CheckBox1.Checked)
						{
							dr[1] = "-1";
						}
						else
						{
							dr[1] = Conversion.Int(-1);
						}
						dt.Rows.Add(dr);
					}
					
					for (int i = 0; i <= m_AlarmCategoryDataList.Count - 1; i++)
					{
						dr = dt.NewRow();
						dr[0] = m_AlarmCategoryDataList[i].Category;
						if (CheckBox1.Checked)
						{
							dr[1] = Conversion.Val((m_AlarmCategoryDataList[i].Rate / tmpTotalAlarmNum * 100).ToString("f2"));
						}
						else
						{
							dr[1] = m_AlarmCategoryDataList[i].Rate;
						}
						dt.Rows.Add(dr);
					}
					dr = null;
					this.Chart_ErrorCode.Cursor = Cursors.Default;
					this.Chart_ErrorCode.DataSource = dt;
					this.Chart_ErrorCode.Series.Clear();
					this.Chart_ErrorCode.Legends.Clear();
					this.Chart_ErrorCode.ChartAreas.Clear();
					this.Chart_ErrorCode.ChartAreas.Add("Y轴");
					this.Chart_ErrorCode.Legends.Add("Y轴");
					this.Chart_ErrorCode.Series.Add("Y轴");
					this.Chart_ErrorCode.Series["Y轴"].LegendToolTip = "ALARM_INFO";
					this.Chart_ErrorCode.Series["Y轴"].IsValueShownAsLabel = true; //标签显示数据值
					this.Chart_ErrorCode.Legends["Y轴"].DockedToChartArea = "Y轴"; //指定Legend所属ChartArea
					this.Chart_ErrorCode.ChartAreas["Y轴"].Area3DStyle.Enable3D = false; //启用3D样式
                    this.Chart_ErrorCode.Legends["Y轴"].Enabled = true;
                    this.Chart_ErrorCode.Legends["Y轴"].Alignment = StringAlignment.Center;
                    this.Chart_ErrorCode.Legends["Y轴"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
                    this.Chart_ErrorCode.Legends["Y轴"].IsDockedInsideChartArea = false;
					this.Chart_ErrorCode.Legends[0].BackColor = Color.FromArgb(238, 238, 238);
					this.Chart_ErrorCode.ChartAreas[0].BackColor = Color.FromArgb(238, 238, 238);
					this.Chart_ErrorCode.BackColor = Color.FromArgb(238, 238, 238);

                    Chart_ErrorCode.Series[0].YValueMembers = "Y轴";
                    Chart_ErrorCode.Series[0].XValueMember = "X轴";
                    Chart_ErrorCode.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    Chart_ErrorCode.Series[0].Label = "#VALX:#VAL";
                    Chart_ErrorCode.Series[0].SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Underlined;
                    Chart_ErrorCode.Series[0].SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
                    Chart_ErrorCode.Series[0].SmartLabelStyle.Enabled = true;
					this.Chart_ErrorCode.DataBind(); //绑定数据源
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
			
			private void AlarmDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
			{
				string DisplayCode = "";
				string DisplayCategory = "";
				if (this.DataGridView_ErrorCode.RowCount - 1 > 0)
				{
					DisplayCode = System.Convert.ToString(DataGridView_ErrorCode["C3", DataGridView_ErrorCode.CurrentCell.RowIndex].Value);
					DisplayCategory = System.Convert.ToString(DataGridView_ErrorCode["C4", DataGridView_ErrorCode.CurrentCell.RowIndex].Value);
					LB_CodeDescription.Items.Clear();
					LB_CodeDescription.Items.Add("● Code:" + DisplayCode);
					LB_CodeDescription.Items.Add("● Description:" + DisplayCategory);
				}
			}
			
			public void CalCategory(ref int iTotalAlarmNum)
			{
				CategoryStatistics tmp = new CategoryStatistics();
				int j = 0;
				int[] rate = new int[PVar.ERROR_CODE.Length - 1 + 1];
				iTotalAlarmNum = 0;
				for (int i = 0; i <= m_AlarmHistoryDataList.Count - 1; i++)
				{
					for (j = 0; j <= PVar.ERROR_CODE.Length - 1; j++)
					{
                    if (m_AlarmHistoryDataList[i].strErrcode == PVar.ERROR_CODE[j].ErrorCode)
						{
							rate[j] = rate[j] + 1;
							iTotalAlarmNum++;
						}
					}
				}
				////加载数据到CateGory列表
				m_AlarmCategoryDataList.Clear();
				for (int K = 0; K <= PVar.ERROR_CODE.Length - 1; K++)
				{
					if (rate[K] != 0)
					{
                    tmp.Category = System.Convert.ToString(PVar.ERROR_CODE[K].ErrorCode);
						tmp.Rate = rate[K];
						m_AlarmCategoryDataList.Add(tmp);
					}
				}
			}
			
			private void Frm_AlarmHistoryInfo_Paint(object sender, PaintEventArgs e)
			{
				DateTime LastDay = default(DateTime);
				DateTime FirstDay = default(DateTime);
				LastDay = DateAndTime.DateAdd("d", -0, DateTime.Now.Date);
				FirstDay = DateAndTime.DateAdd("d", -30, DateTime.Now.Date);
				LoadAlarmHistoryData(FirstDay, LastDay);
				LoadAlarmHistoryToDataGrid();
				LoadAlarmHistoryToPieChart();
			}


			
		}
	}
