
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
	
	public partial class Frm_MachineInfo
	{
        public static Frm_MachineInfo fMachineInfo = new Frm_MachineInfo();   
		public Frm_MachineInfo()
		{
			InitializeComponent();
            fMachineInfo = this;
		}
		
		private void Frm_MachineInfo_Load(object sender, EventArgs e)
		{
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.fMain.Main_Color;
			
			PVar.TotalLifeCycles = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeCycles", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
			PVar.TotalLifeRejects = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeRejects", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
			
			//MeshineSW版本号在申明修改即可
			Label_SoftwareVersion.Text = "SV: " + System.Convert.ToString(Conversion.Val(Strings.Left(PVar.MeshineSW.Substring(1), 1))) +"." + System.Convert.ToString(Conversion.Val(Strings.Left(PVar.MeshineSW.Substring(3), 1))) +"." + System.Convert.ToString(Conversion.Val(Strings.Left(PVar.MeshineSW.Substring(4), 1)));
			//Label_SoftwareVersion.Text = "SV: " & My.Application.Info.Version.ToString.Substring(0, 5)
			Label_TotalLifeCycle.Text = PVar.TotalLifeCycles + " PCS";
			Label_TotalLifeRejects.Text = PVar.TotalLifeRejects + " PCS";
		}
		
		
		private void Frm_MachineInfo_Paint(object sender, PaintEventArgs e)
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
			
			PVar.TotalLifeCycles = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeCycles", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
			PVar.TotalLifeRejects = long.Parse(BVar.FileRorW.ReadINI("Product", "TotalLifeRejects", System.Convert.ToString(0), PVar.BZ_YieldDataFileName));
			Label_TotalLifeCycle.Text = PVar.TotalLifeCycles + " PCS";
			Label_TotalLifeRejects.Text = PVar.TotalLifeRejects + " PCS";
			
		}
		
	}
}
