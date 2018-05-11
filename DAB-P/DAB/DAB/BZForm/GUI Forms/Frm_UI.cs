
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using AxMSScriptControl;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using BZ.UI;

namespace DAB
{
	
	public partial class Frm_UI
	{
		public Frm_UI()
		{
			InitializeComponent();
		}
        //private string ConfirmOrCancel;
		private void Frm_UI_FormClosed(object sender, FormClosedEventArgs e)
		{
			
            //If ConfirmOrCancel = "Confirm" Then
            //    If PhotoFlag = "0" Then PhotoFlag = "1"
            //    If S2HoldFlag Then S2HoldFlag = False
            //Else
            //    If PhotoFlag = "0" Then PhotoFlag = "2"
            //    If S2HoldFlag Then S2HoldFlag = False
            //End If
            //bIsUIShow_PDCAMode = False
		}
		
		private void Frm_UI_Load(object sender, EventArgs e)
		{
			Frm_UI with_1 = this;
			with_1.Location = PVar.ChildFrmOffsetPoint;
			with_1.Size = new Size(600, 300);
			with_1.TopMost = true;
			//If bIsUIShow_PDCAMode Then
			//    .Label1.Visible = True
			//    .Txt_UIPassword.Visible = True
			//End If
		}
		
		private void Timer1_Tick(object sender, EventArgs e)
		{		
			if (List_Sts.Items.Count > 0)
			{
				this.Show();
				this.Timer.Enabled = false;
			}
		}
		
		
		private void Btn_Confirm_Click(object sender, EventArgs e)
		{
            //ConfirmOrCancel = "Confirm";
			//If bIsUIShow_PDCAMode Then
			//    sPDCAStatus = "Yes"
			//End If
			this.Close();
			this.Dispose();
		}
		
		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
            //ConfirmOrCancel = "Cancel";
			//If bIsUIShow_PDCAMode Then
			//    If Trim(Me.Txt_UIPassword.Text) = Login.PDCACancel_ID Or Trim(Me.Txt_UIPassword.Text) = Login.Administrator_ID Then
			//        sPDCAStatus = "No"
			//    Else
			//        MsgBox("PDCA取消密码不正确，请重新输入正确的密码！" & vbCrLf & "输入密码必须是《PDCACancel_ID》对应的密码!", MsgBoxStyle.OkOnly)
			//        Me.Txt_UIPassword.Text = ""
			//        Exit Sub
			//    End If
			//End If
			this.Close();
			this.Dispose();
		}
	}
}
