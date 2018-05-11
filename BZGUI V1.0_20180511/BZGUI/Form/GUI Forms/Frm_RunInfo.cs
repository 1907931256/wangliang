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

namespace BZGUI
{

    public partial class Frm_RunInfo
	{
        public static Frm_RunInfo fRunInfo = null;    
		public Frm_RunInfo()
		{
			InitializeComponent();
            fRunInfo = this;
		}

		private void Frm_RunInfo_Load(object sender, EventArgs e)
		{
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.fMain.BackColor;
			TrackBar_yeild_Scroll(null, null);
			TrackBar_tossing_Scroll(null, null);
			TrackBar_uph_Scroll(null, null);
		}
		
        #region 功能：Yeild Tossing UPH

		private void TrackBar_yeild_Scroll(object sender, EventArgs e)
		{
			string XDate;
			int SelectData = 0;
			//Call CalculateYieldRetestRate()
			FileRw.ReadYieldFile(PVar.BZ_YieldMonthDataFileName, PVar.YieldOfMonth);
			SelectData = TrackBar_yeild.Value;
			for (var i = 0; i <= SelectData - 1; i++)
			{
                XDate = System.Convert.ToString(PVar.YieldOfMonth.RecordTime[i].ToString("yyyyMMdd"));
                PVar.StorXData[(int)i] = System.Convert.ToString(PVar.YieldOfMonth.RecordTime[i].ToString("MM/dd"));
				PVar.StorYieldOverView[(int) i] = System.Convert.ToDouble((PVar.YieldOfMonth.ProductCount[(int) i] == 0) ? 0 : (Math.Round((1 - (double) PVar.YieldOfMonth.NgCount[(int) i] / PVar.YieldOfMonth.ProductCount[(int) i]) * 100, 1))); //当天良率
			}
			FileRw.Chart_Curve(Chart_YieldOverview, "Yield Rate(Unit:%)", "", "", "Yield", PVar.StorXData, PVar.StorYieldOverView, 0, 0, 0, false);
		}
		
		private void TrackBar_tossing_Scroll(object sender, EventArgs e)
		{
			string XDate = "";
			int SelectData = 0;
			SelectData = TrackBar_tossing.Value;
			for (var i = 0; i <= SelectData - 1; i++)
			{
                XDate = System.Convert.ToString(DateAndTime.DateAdd("d", System.Convert.ToDouble(-i), DateTime.Now.Date).ToString("yyyyMMdd"));
                PVar.StorXData[(int)i] = System.Convert.ToString(DateAndTime.DateAdd("d", System.Convert.ToDouble(-i), DateTime.Now.Date).ToString("MM/dd"));
				PVar.StorTossing[(int) i] = double.Parse(FileRw.IniGetStringValue(PVar.UIChartYieldOverViewName, XDate, "Tossing", "0")); //当天抛料率
			}
			FileRw.Chart_Curve(Chart_Tossing, "Tossing(Unit:%)", "", "", "Tossing", PVar.StorXData, PVar.StorTossing, 0, 0, 0, false);
		}

		private void TrackBar_uph_Scroll(object sender, EventArgs e)
		{
			string XDate = "";
			string[] YData = new string[31];
			string[] Temp = new string[25];
			int SelectData = 0;
			SelectData = TrackBar_uph.Value;
			for (var i = 0; i <= SelectData - 1; i++)
			{
                XDate = System.Convert.ToString(DateAndTime.DateAdd("d", System.Convert.ToDouble(-i), DateTime.Now.Date).ToString("yyyyMMdd"));
                PVar.StorXData[(int)i] = System.Convert.ToString(DateAndTime.DateAdd("d", System.Convert.ToDouble(-i), DateTime.Now.Date).ToString("MM/dd"));
				PVar.StorUPH[(int) i] = double.Parse(FileRw.IniGetStringValue(PVar.UIChartYieldOverViewName, XDate, "OneTodayUPH", "0"));
			}
			FileRw.Chart_Curve(Chart_UPH, "UPH(Unit：PCS)", "", "", "UPH", PVar.StorXData, PVar.StorUPH, 0, 0, 0, false);
		}

        #endregion
		
		private void Button_YeildDay_Jian_MouseDown(dynamic sender, EventArgs e)
		{
			if ((int) sender.Tabindex == 1)
			{
				if (TrackBar_yeild.Value >= 2)
				{
					TrackBar_yeild.Value--;
					TrackBar_yeild_Scroll(null, null);
				}
			}
			else if ((int) sender.Tabindex == 2)
			{
				if (TrackBar_tossing.Value >= 2)
				{
					TrackBar_tossing.Value--;
					TrackBar_tossing_Scroll(null, null);
				}
			}
			else if ((int) sender.Tabindex == 3)
			{
				if (TrackBar_uph.Value >= 2)
				{
					TrackBar_uph.Value--;
					TrackBar_uph_Scroll(null, null);
				}
			}
		}
		
		private void Button_YeildDay_Jia_MouseDown(dynamic sender, EventArgs e)
		{
			if ((int) sender.Tabindex == 1)
			{
				if (TrackBar_yeild.Value < TrackBar_yeild.Maximum)
				{
					TrackBar_yeild.Value++;
					TrackBar_yeild_Scroll(null, null);
				}
			}
			else if ((int) sender.Tabindex == 2)
			{
				if (TrackBar_tossing.Value < TrackBar_tossing.Maximum)
				{
					TrackBar_tossing.Value++;
					TrackBar_tossing_Scroll(null, null);
				}
			}
			else if ((int) sender.Tabindex == 3)
			{
				if (TrackBar_uph.Value < TrackBar_uph.Maximum)
				{
					TrackBar_uph.Value++;
					TrackBar_uph_Scroll(null, null);
				}
			}
		}

	}
}
