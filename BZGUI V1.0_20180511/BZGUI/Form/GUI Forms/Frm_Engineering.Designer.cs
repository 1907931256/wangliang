
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

namespace BZGUI
{
	
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_Engineering : System.Windows.Forms.Form
	{
			
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Windows 窗体设计器所必需的
        //private System.ComponentModel.IContainer components = null;
        private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Engineering));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.TabControl4 = new System.Windows.Forms.TabControl();
            this.TabPage_Review = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox_mL = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_mA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_mT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_mY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_mX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_mT = new System.Windows.Forms.Label();
            this.label_mY = new System.Windows.Forms.Label();
            this.label_mX = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.TabControl6 = new System.Windows.Forms.TabControl();
            this.TabPage9 = new System.Windows.Forms.TabPage();
            this.CheckBox_NeedCCD = new System.Windows.Forms.CheckBox();
            this.BtnM_B_logo = new System.Windows.Forms.Button();
            this.TextM_BlogoNo = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.Teach1 = new BZGUI.Teach();
            this.TextBox_CCD1 = new System.Windows.Forms.TextBox();
            this.Panel_S2 = new System.Windows.Forms.Panel();
            this.CCD_Screen_S2 = new System.Windows.Forms.Button();
            this.CCD_Trigger_S2 = new System.Windows.Forms.Button();
            this.ComboBox_Cam1 = new System.Windows.Forms.ComboBox();
            this.GroupBox_S2 = new System.Windows.Forms.GroupBox();
            this.CommandAutoS2 = new System.Windows.Forms.Button();
            this.CmdStopS2 = new System.Windows.Forms.Button();
            this.CmdHoldS2 = new System.Windows.Forms.Button();
            this.GroupBox14 = new System.Windows.Forms.GroupBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Text_ForceS2 = new System.Windows.Forms.TextBox();
            this.Btn_OpenSerialS2 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button_S2_3 = new System.Windows.Forms.Button();
            this.Button_S2_2 = new System.Windows.Forms.Button();
            this.Button_S2_1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel_S2g = new System.Windows.Forms.Panel();
            this.Button_S2g_7 = new System.Windows.Forms.Button();
            this.Button_S2g_11 = new System.Windows.Forms.Button();
            this.Button_S2g_10 = new System.Windows.Forms.Button();
            this.Button_S2g_9 = new System.Windows.Forms.Button();
            this.Button_S2g_1 = new System.Windows.Forms.Button();
            this.Button_S2g_4 = new System.Windows.Forms.Button();
            this.Button_S2g_2 = new System.Windows.Forms.Button();
            this.Button_S2g_3 = new System.Windows.Forms.Button();
            this.Button_S2g_8 = new System.Windows.Forms.Button();
            this.Button_S2g_6 = new System.Windows.Forms.Button();
            this.Button_S2g_5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Teach3 = new BZGUI.Teach();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Text_ForceS3 = new System.Windows.Forms.TextBox();
            this.Btn_OpenSerialS3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Button_S3_2 = new System.Windows.Forms.Button();
            this.Button_S3_1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.Teach2 = new BZGUI.Teach();
            this.TabPage13 = new System.Windows.Forms.TabPage();
            this.TextBox_CCD2 = new System.Windows.Forms.TextBox();
            this.TabControl5 = new System.Windows.Forms.TabControl();
            this.TabPage14 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.CCD_Trigger_S4 = new System.Windows.Forms.Button();
            this.ComboBox_Cam2 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Button_S4_8 = new System.Windows.Forms.Button();
            this.Button_S4_7 = new System.Windows.Forms.Button();
            this.Button_S4_6 = new System.Windows.Forms.Button();
            this.Button_S4_5 = new System.Windows.Forms.Button();
            this.Button_S4_4 = new System.Windows.Forms.Button();
            this.Button_S4_3 = new System.Windows.Forms.Button();
            this.Button_S4_9 = new System.Windows.Forms.Button();
            this.Button_S4_2 = new System.Windows.Forms.Button();
            this.Button_S4_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Teach4 = new BZGUI.Teach();
            this.TabPage_LightControl = new System.Windows.Forms.TabPage();
            this.LightControl1 = new BZGUI.LightControl();
            this.TabPage15 = new System.Windows.Forms.TabPage();
            this.Panel_Calibration = new System.Windows.Forms.Panel();
            this.infoList2 = new BZGUI.InfoList();
            this.TextBox_Laser = new System.Windows.Forms.TextBox();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Button_Laser = new System.Windows.Forms.Button();
            this.Panel16 = new System.Windows.Forms.Panel();
            this.Label55 = new System.Windows.Forms.Label();
            this.ComboBox_TL = new System.Windows.Forms.ComboBox();
            this.Button_GetTL = new System.Windows.Forms.Button();
            this.TextBox_TLX = new System.Windows.Forms.TextBox();
            this.TextBox_TLY = new System.Windows.Forms.TextBox();
            this.TextBox_TLZ = new System.Windows.Forms.TextBox();
            this.TextBox_TLA = new System.Windows.Forms.TextBox();
            this.TextBox_TLB = new System.Windows.Forms.TextBox();
            this.TextBox_TLC = new System.Windows.Forms.TextBox();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.Panel15 = new System.Windows.Forms.Panel();
            this.Robot_Biaoding = new System.Windows.Forms.Button();
            this.ComboBox_Robot = new System.Windows.Forms.ComboBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Panel_Test = new System.Windows.Forms.Panel();
            this.Label42 = new System.Windows.Forms.Label();
            this.TextBox_Num = new System.Windows.Forms.TextBox();
            this.Button_Test = new System.Windows.Forms.Button();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.PanelCalibration = new System.Windows.Forms.Panel();
            this.Btn_CalibrationList = new System.Windows.Forms.Button();
            this.ComboBox_CCD = new System.Windows.Forms.ComboBox();
            this.List_Info = new System.Windows.Forms.ListBox();
            this.Panel19 = new System.Windows.Forms.Panel();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label_PDCA_Step = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label26 = new System.Windows.Forms.Label();
            this.Txt_MLBBarcode = new System.Windows.Forms.TextBox();
            this.Btn_PDCATest = new System.Windows.Forms.Button();
            this.Panel_Vup = new System.Windows.Forms.Panel();
            this.Btn_Vup_Check = new System.Windows.Forms.Button();
            this.TB_Vup_Angel = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.TB_Vup_Center_Y = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.TB_Vup_Center_X = new System.Windows.Forms.TextBox();
            this.Btn_Vup_Calibration = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Txt_StandardPressure = new System.Windows.Forms.TextBox();
            this.Btn_AutoLoadcell = new System.Windows.Forms.Button();
            this.Txt_InstallPressure = new System.Windows.Forms.TextBox();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.Panel17 = new System.Windows.Forms.Panel();
            this.Btn_CaliSave = new System.Windows.Forms.Button();
            this.Btn_Ckeck = new System.Windows.Forms.Button();
            this.Text_CkcekAngle = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Text_CaliY = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Text_CaliX = new System.Windows.Forms.TextBox();
            this.Btn_StartCorrection = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_SaveCamDist = new System.Windows.Forms.Button();
            this.Txt_CamDistY = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Txt_CamDistX = new System.Windows.Forms.TextBox();
            this.TabPage_Super = new System.Windows.Forms.TabPage();
            this.Button62 = new System.Windows.Forms.Button();
            this.Button61 = new System.Windows.Forms.Button();
            this.DataGridView_par = new System.Windows.Forms.DataGridView();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserManagement = new System.Windows.Forms.Button();
            this.Btn_ParLogin = new System.Windows.Forms.Button();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.OutputClass3 = new BZGUI.OutputClass();
            this.OutputClass2 = new BZGUI.OutputClass();
            this.OutputClass1 = new BZGUI.OutputClass();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.InputClass3 = new BZGUI.InputClass();
            this.InputClass2 = new BZGUI.InputClass();
            this.InputClass1 = new BZGUI.InputClass();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.MotorStatus3 = new BZGUI.MotorStatus();
            this.MotorStatus2 = new BZGUI.MotorStatus();
            this.MotorStatus1 = new BZGUI.MotorStatus();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.Label_StepL5 = new System.Windows.Forms.Label();
            this.Label_CPK = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Lab_Home = new System.Windows.Forms.Label();
            this.Label_WorkMode = new System.Windows.Forms.Label();
            this.SplitList_LB = new System.Windows.Forms.Panel();
            this.infoList1 = new BZGUI.InfoList();
            this.PictureBox25 = new System.Windows.Forms.PictureBox();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Lab_LightContor_Sts = new System.Windows.Forms.Label();
            this.Lab_SafeLight_Sts = new System.Windows.Forms.Label();
            this.Lab_Safe_Sts = new System.Windows.Forms.Label();
            this.Lab_EMG_Sts = new System.Windows.Forms.Label();
            this.Lab_CCD1_Sts = new System.Windows.Forms.Label();
            this.Lab_LC2_Sts = new System.Windows.Forms.Label();
            this.Lab_LC1_Sts = new System.Windows.Forms.Label();
            this.Lab_Air_Sts = new System.Windows.Forms.Label();
            this.Lab_CCD2_Sts = new System.Windows.Forms.Label();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Btn_SelectMaterial = new System.Windows.Forms.Button();
            this.Text_BlogoNo = new System.Windows.Forms.TextBox();
            this.Label_NG_OK = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.PressS2_Text = new System.Windows.Forms.Label();
            this.PressS3_Text = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Press_Display0 = new System.Windows.Forms.Label();
            this.Chk_StaRound = new System.Windows.Forms.CheckBox();
            this.Label_Sta2 = new System.Windows.Forms.Label();
            this.Label_Sta3 = new System.Windows.Forms.Label();
            this.Label_Sta4 = new System.Windows.Forms.Label();
            this.Label_Sta1 = new System.Windows.Forms.Label();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Product_Num = new System.Windows.Forms.TextBox();
            this.Label134 = new System.Windows.Forms.Label();
            this.Cycle = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.OvalShape_Sta4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_Sta2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_Sta1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.OvalShape_Sta3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.OvalShape_Sta0 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.DataGrid_CheckData = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProSta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCam1CCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCam1CCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage4.SuspendLayout();
            this.TabControl4.SuspendLayout();
            this.TabPage_Review.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.TabControl6.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.Panel_S2.SuspendLayout();
            this.GroupBox_S2.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_S2g.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.TabPage13.SuspendLayout();
            this.TabControl5.SuspendLayout();
            this.TabPage14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TabPage_LightControl.SuspendLayout();
            this.TabPage15.SuspendLayout();
            this.Panel_Calibration.SuspendLayout();
            this.Panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox11.SuspendLayout();
            this.Panel15.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.Panel_Test.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.PanelCalibration.SuspendLayout();
            this.Panel19.SuspendLayout();
            this.Panel_Vup.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage_Super.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_par)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.TabControl3.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SplitList_LB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox25)).BeginInit();
            this.Panel9.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CheckData)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage4.Controls.Add(this.TabControl4);
            this.TabPage4.Location = new System.Drawing.Point(4, 39);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(1008, 608);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "  Manual Page ";
            // 
            // TabControl4
            // 
            this.TabControl4.Controls.Add(this.TabPage_Review);
            this.TabControl4.Controls.Add(this.tabPage8);
            this.TabControl4.Controls.Add(this.tabPage12);
            this.TabControl4.Controls.Add(this.TabPage13);
            this.TabControl4.Controls.Add(this.TabPage_Super);
            this.TabControl4.Enabled = false;
            this.TabControl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl4.Location = new System.Drawing.Point(1, 2);
            this.TabControl4.Name = "TabControl4";
            this.TabControl4.SelectedIndex = 0;
            this.TabControl4.Size = new System.Drawing.Size(1007, 600);
            this.TabControl4.TabIndex = 1;
            this.TabControl4.Tag = "3";
            // 
            // TabPage_Review
            // 
            this.TabPage_Review.BackColor = System.Drawing.Color.White;
            this.TabPage_Review.Controls.Add(this.groupBox12);
            this.TabPage_Review.Controls.Add(this.TabControl6);
            this.TabPage_Review.Controls.Add(this.Teach1);
            this.TabPage_Review.Controls.Add(this.TextBox_CCD1);
            this.TabPage_Review.Controls.Add(this.Panel_S2);
            this.TabPage_Review.Controls.Add(this.GroupBox_S2);
            this.TabPage_Review.Controls.Add(this.GroupBox14);
            this.TabPage_Review.Controls.Add(this.Panel1);
            this.TabPage_Review.Location = new System.Drawing.Point(4, 29);
            this.TabPage_Review.Name = "TabPage_Review";
            this.TabPage_Review.Size = new System.Drawing.Size(999, 567);
            this.TabPage_Review.TabIndex = 4;
            this.TabPage_Review.Text = " 2 工位 ";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox_mL);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Controls.Add(this.textBox_mA);
            this.groupBox12.Controls.Add(this.label13);
            this.groupBox12.Controls.Add(this.textBox_mT);
            this.groupBox12.Controls.Add(this.label14);
            this.groupBox12.Controls.Add(this.textBox_mY);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.textBox_mX);
            this.groupBox12.Controls.Add(this.label11);
            this.groupBox12.Controls.Add(this.label_mT);
            this.groupBox12.Controls.Add(this.label_mY);
            this.groupBox12.Controls.Add(this.label_mX);
            this.groupBox12.Controls.Add(this.button7);
            this.groupBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox12.Location = new System.Drawing.Point(689, 123);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(239, 288);
            this.groupBox12.TabIndex = 69;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "单站调试";
            // 
            // textBox_mL
            // 
            this.textBox_mL.Location = new System.Drawing.Point(27, 103);
            this.textBox_mL.Name = "textBox_mL";
            this.textBox_mL.Size = new System.Drawing.Size(66, 23);
            this.textBox_mL.TabIndex = 123;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 14);
            this.label17.TabIndex = 124;
            this.label17.Text = "L:";
            // 
            // textBox_mA
            // 
            this.textBox_mA.Location = new System.Drawing.Point(150, 68);
            this.textBox_mA.Name = "textBox_mA";
            this.textBox_mA.Size = new System.Drawing.Size(72, 23);
            this.textBox_mA.TabIndex = 121;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 14);
            this.label13.TabIndex = 122;
            this.label13.Text = "A:";
            // 
            // textBox_mT
            // 
            this.textBox_mT.Location = new System.Drawing.Point(27, 68);
            this.textBox_mT.Name = "textBox_mT";
            this.textBox_mT.Size = new System.Drawing.Size(66, 23);
            this.textBox_mT.TabIndex = 119;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 14);
            this.label14.TabIndex = 120;
            this.label14.Text = "T:";
            // 
            // textBox_mY
            // 
            this.textBox_mY.Location = new System.Drawing.Point(150, 30);
            this.textBox_mY.Name = "textBox_mY";
            this.textBox_mY.Size = new System.Drawing.Size(72, 23);
            this.textBox_mY.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 118;
            this.label12.Text = "Y:";
            // 
            // textBox_mX
            // 
            this.textBox_mX.Location = new System.Drawing.Point(27, 30);
            this.textBox_mX.Name = "textBox_mX";
            this.textBox_mX.Size = new System.Drawing.Size(66, 23);
            this.textBox_mX.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 116;
            this.label11.Text = "X:";
            // 
            // label_mT
            // 
            this.label_mT.AutoSize = true;
            this.label_mT.Location = new System.Drawing.Point(8, 198);
            this.label_mT.Name = "label_mT";
            this.label_mT.Size = new System.Drawing.Size(56, 14);
            this.label_mT.TabIndex = 113;
            this.label_mT.Text = "T:0.000";
            // 
            // label_mY
            // 
            this.label_mY.AutoSize = true;
            this.label_mY.Location = new System.Drawing.Point(8, 168);
            this.label_mY.Name = "label_mY";
            this.label_mY.Size = new System.Drawing.Size(56, 14);
            this.label_mY.TabIndex = 112;
            this.label_mY.Text = "Y:0.000";
            // 
            // label_mX
            // 
            this.label_mX.AutoSize = true;
            this.label_mX.Location = new System.Drawing.Point(8, 141);
            this.label_mX.Name = "label_mX";
            this.label_mX.Size = new System.Drawing.Size(56, 14);
            this.label_mX.TabIndex = 111;
            this.label_mX.Text = "X:0.000";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Tomato;
            this.button7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(57, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 30);
            this.button7.TabIndex = 110;
            this.button7.Text = "计算";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // TabControl6
            // 
            this.TabControl6.Controls.Add(this.TabPage9);
            this.TabControl6.ItemSize = new System.Drawing.Size(68, 20);
            this.TabControl6.Location = new System.Drawing.Point(513, 42);
            this.TabControl6.Name = "TabControl6";
            this.TabControl6.SelectedIndex = 0;
            this.TabControl6.Size = new System.Drawing.Size(255, 79);
            this.TabControl6.TabIndex = 68;
            // 
            // TabPage9
            // 
            this.TabPage9.BackColor = System.Drawing.Color.White;
            this.TabPage9.Controls.Add(this.CheckBox_NeedCCD);
            this.TabPage9.Controls.Add(this.BtnM_B_logo);
            this.TabPage9.Controls.Add(this.TextM_BlogoNo);
            this.TabPage9.Controls.Add(this.Label33);
            this.TabPage9.Location = new System.Drawing.Point(4, 24);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage9.Size = new System.Drawing.Size(247, 51);
            this.TabPage9.TabIndex = 0;
            this.TabPage9.Text = "物料选择";
            // 
            // CheckBox_NeedCCD
            // 
            this.CheckBox_NeedCCD.AutoSize = true;
            this.CheckBox_NeedCCD.Location = new System.Drawing.Point(179, 4);
            this.CheckBox_NeedCCD.Name = "CheckBox_NeedCCD";
            this.CheckBox_NeedCCD.Size = new System.Drawing.Size(62, 24);
            this.CheckBox_NeedCCD.TabIndex = 26;
            this.CheckBox_NeedCCD.Text = "CCD";
            this.CheckBox_NeedCCD.UseVisualStyleBackColor = true;
            // 
            // BtnM_B_logo
            // 
            this.BtnM_B_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnM_B_logo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnM_B_logo.Location = new System.Drawing.Point(127, 3);
            this.BtnM_B_logo.Name = "BtnM_B_logo";
            this.BtnM_B_logo.Size = new System.Drawing.Size(43, 26);
            this.BtnM_B_logo.TabIndex = 19;
            this.BtnM_B_logo.Text = ". . .";
            this.BtnM_B_logo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnM_B_logo.UseVisualStyleBackColor = true;
            this.BtnM_B_logo.Click += new System.EventHandler(this.BtnM_B_logo_Click);
            // 
            // TextM_BlogoNo
            // 
            this.TextM_BlogoNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextM_BlogoNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextM_BlogoNo.ForeColor = System.Drawing.Color.Blue;
            this.TextM_BlogoNo.Location = new System.Drawing.Point(70, 4);
            this.TextM_BlogoNo.Name = "TextM_BlogoNo";
            this.TextM_BlogoNo.ReadOnly = true;
            this.TextM_BlogoNo.Size = new System.Drawing.Size(47, 26);
            this.TextM_BlogoNo.TabIndex = 18;
            this.TextM_BlogoNo.Text = "1";
            this.TextM_BlogoNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label33
            // 
            this.Label33.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label33.ForeColor = System.Drawing.Color.Black;
            this.Label33.Location = new System.Drawing.Point(10, 9);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(65, 17);
            this.Label33.TabIndex = 17;
            this.Label33.Text = "B-logo：";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Teach1
            // 
            this.Teach1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach1.Location = new System.Drawing.Point(3, 3);
            this.Teach1.Name = "Teach1";
            this.Teach1.Size = new System.Drawing.Size(486, 332);
            this.Teach1.TabIndex = 67;
            this.Teach1.Tag = "0";
            // 
            // TextBox_CCD1
            // 
            this.TextBox_CCD1.Location = new System.Drawing.Point(8, 538);
            this.TextBox_CCD1.Name = "TextBox_CCD1";
            this.TextBox_CCD1.Size = new System.Drawing.Size(983, 26);
            this.TextBox_CCD1.TabIndex = 66;
            // 
            // Panel_S2
            // 
            this.Panel_S2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_S2.Controls.Add(this.CCD_Screen_S2);
            this.Panel_S2.Controls.Add(this.CCD_Trigger_S2);
            this.Panel_S2.Controls.Add(this.ComboBox_Cam1);
            this.Panel_S2.Location = new System.Drawing.Point(527, 417);
            this.Panel_S2.Name = "Panel_S2";
            this.Panel_S2.Size = new System.Drawing.Size(219, 106);
            this.Panel_S2.TabIndex = 47;
            // 
            // CCD_Screen_S2
            // 
            this.CCD_Screen_S2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CCD_Screen_S2.Location = new System.Drawing.Point(6, 58);
            this.CCD_Screen_S2.Name = "CCD_Screen_S2";
            this.CCD_Screen_S2.Size = new System.Drawing.Size(92, 40);
            this.CCD_Screen_S2.TabIndex = 2;
            this.CCD_Screen_S2.Tag = "2";
            this.CCD_Screen_S2.Text = "截图";
            this.CCD_Screen_S2.UseVisualStyleBackColor = true;
            // 
            // CCD_Trigger_S2
            // 
            this.CCD_Trigger_S2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CCD_Trigger_S2.Image = ((System.Drawing.Image)(resources.GetObject("CCD_Trigger_S2.Image")));
            this.CCD_Trigger_S2.Location = new System.Drawing.Point(120, 58);
            this.CCD_Trigger_S2.Name = "CCD_Trigger_S2";
            this.CCD_Trigger_S2.Size = new System.Drawing.Size(92, 40);
            this.CCD_Trigger_S2.TabIndex = 2;
            this.CCD_Trigger_S2.Tag = "2";
            this.CCD_Trigger_S2.Text = "CCD拍 照";
            this.CCD_Trigger_S2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CCD_Trigger_S2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CCD_Trigger_S2.UseVisualStyleBackColor = true;
            this.CCD_Trigger_S2.Click += new System.EventHandler(this.CCD_Trigger_S2_Click);
            // 
            // ComboBox_Cam1
            // 
            this.ComboBox_Cam1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBox_Cam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Cam1.FormattingEnabled = true;
            this.ComboBox_Cam1.Items.AddRange(new object[] {
            "取料拍照",
            "HSG角度拍照",
            "装配HSG圆拍照",
            "装配Blogo拍照",
            "装配拍照"});
            this.ComboBox_Cam1.Location = new System.Drawing.Point(3, 15);
            this.ComboBox_Cam1.Name = "ComboBox_Cam1";
            this.ComboBox_Cam1.Size = new System.Drawing.Size(211, 33);
            this.ComboBox_Cam1.TabIndex = 1;
            this.ComboBox_Cam1.Text = "取料拍照";
            // 
            // GroupBox_S2
            // 
            this.GroupBox_S2.Controls.Add(this.CommandAutoS2);
            this.GroupBox_S2.Controls.Add(this.CmdStopS2);
            this.GroupBox_S2.Controls.Add(this.CmdHoldS2);
            this.GroupBox_S2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox_S2.Location = new System.Drawing.Point(513, 191);
            this.GroupBox_S2.Name = "GroupBox_S2";
            this.GroupBox_S2.Size = new System.Drawing.Size(157, 144);
            this.GroupBox_S2.TabIndex = 46;
            this.GroupBox_S2.TabStop = false;
            this.GroupBox_S2.Text = "单站调试";
            // 
            // CommandAutoS2
            // 
            this.CommandAutoS2.BackColor = System.Drawing.Color.Tomato;
            this.CommandAutoS2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandAutoS2.Location = new System.Drawing.Point(14, 100);
            this.CommandAutoS2.Name = "CommandAutoS2";
            this.CommandAutoS2.Size = new System.Drawing.Size(126, 30);
            this.CommandAutoS2.TabIndex = 110;
            this.CommandAutoS2.Text = "单站运行";
            this.CommandAutoS2.UseVisualStyleBackColor = false;
            // 
            // CmdStopS2
            // 
            this.CmdStopS2.Location = new System.Drawing.Point(81, 36);
            this.CmdStopS2.Name = "CmdStopS2";
            this.CmdStopS2.Size = new System.Drawing.Size(59, 29);
            this.CmdStopS2.TabIndex = 1;
            this.CmdStopS2.TabStop = false;
            this.CmdStopS2.Text = "停止";
            this.CmdStopS2.UseVisualStyleBackColor = true;
            this.CmdStopS2.Click += new System.EventHandler(this.CmdStopS2_Click);
            // 
            // CmdHoldS2
            // 
            this.CmdHoldS2.BackColor = System.Drawing.Color.BurlyWood;
            this.CmdHoldS2.Location = new System.Drawing.Point(13, 35);
            this.CmdHoldS2.Name = "CmdHoldS2";
            this.CmdHoldS2.Size = new System.Drawing.Size(59, 29);
            this.CmdHoldS2.TabIndex = 0;
            this.CmdHoldS2.Text = "暂停";
            this.CmdHoldS2.UseVisualStyleBackColor = false;
            this.CmdHoldS2.Click += new System.EventHandler(this.CmdHoldS2_Click);
            // 
            // GroupBox14
            // 
            this.GroupBox14.Controls.Add(this.Label18);
            this.GroupBox14.Controls.Add(this.Label19);
            this.GroupBox14.Controls.Add(this.Text_ForceS2);
            this.GroupBox14.Controls.Add(this.Btn_OpenSerialS2);
            this.GroupBox14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox14.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox14.Location = new System.Drawing.Point(783, 433);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new System.Drawing.Size(151, 90);
            this.GroupBox14.TabIndex = 45;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "组装";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(117, 28);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(28, 14);
            this.Label18.TabIndex = 8;
            this.Label18.Text = "kgf";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label19.ForeColor = System.Drawing.Color.Black;
            this.Label19.Location = new System.Drawing.Point(5, 28);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(49, 14);
            this.Label19.TabIndex = 7;
            this.Label19.Text = "Value:";
            // 
            // Text_ForceS2
            // 
            this.Text_ForceS2.BackColor = System.Drawing.Color.Black;
            this.Text_ForceS2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_ForceS2.ForeColor = System.Drawing.Color.Lime;
            this.Text_ForceS2.Location = new System.Drawing.Point(55, 22);
            this.Text_ForceS2.Name = "Text_ForceS2";
            this.Text_ForceS2.ReadOnly = true;
            this.Text_ForceS2.Size = new System.Drawing.Size(60, 26);
            this.Text_ForceS2.TabIndex = 6;
            this.Text_ForceS2.Text = "0.00";
            this.Text_ForceS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_OpenSerialS2
            // 
            this.Btn_OpenSerialS2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenSerialS2.ForeColor = System.Drawing.Color.Black;
            this.Btn_OpenSerialS2.Location = new System.Drawing.Point(56, 54);
            this.Btn_OpenSerialS2.Name = "Btn_OpenSerialS2";
            this.Btn_OpenSerialS2.Size = new System.Drawing.Size(59, 32);
            this.Btn_OpenSerialS2.TabIndex = 3;
            this.Btn_OpenSerialS2.Text = "Open";
            this.Btn_OpenSerialS2.UseVisualStyleBackColor = true;
            this.Btn_OpenSerialS2.Click += new System.EventHandler(this.Btn_OpenSerialS2_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Button_S2_3);
            this.Panel1.Controls.Add(this.Button_S2_2);
            this.Panel1.Controls.Add(this.Button_S2_1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.TextBox7);
            this.Panel1.Location = new System.Drawing.Point(10, 350);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(479, 182);
            this.Panel1.TabIndex = 9;
            // 
            // Button_S2_3
            // 
            this.Button_S2_3.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S2_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2_3.Location = new System.Drawing.Point(18, 104);
            this.Button_S2_3.Name = "Button_S2_3";
            this.Button_S2_3.Size = new System.Drawing.Size(109, 30);
            this.Button_S2_3.TabIndex = 0;
            this.Button_S2_3.Tag = "(1,0,1)";
            this.Button_S2_3.Text = "取料吸嘴破真空";
            this.Button_S2_3.UseVisualStyleBackColor = false;
            this.Button_S2_3.Click += new System.EventHandler(this.Button_S2_3_Click);
            // 
            // Button_S2_2
            // 
            this.Button_S2_2.BackColor = System.Drawing.Color.Khaki;
            this.Button_S2_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2_2.Location = new System.Drawing.Point(18, 57);
            this.Button_S2_2.Name = "Button_S2_2";
            this.Button_S2_2.Size = new System.Drawing.Size(109, 30);
            this.Button_S2_2.TabIndex = 0;
            this.Button_S2_2.Tag = "(1,0,0)";
            this.Button_S2_2.Text = "取料吸嘴真空吸";
            this.Button_S2_2.UseVisualStyleBackColor = false;
            this.Button_S2_2.Click += new System.EventHandler(this.Button_S2_2_Click);
            // 
            // Button_S2_1
            // 
            this.Button_S2_1.BackColor = System.Drawing.Color.Gold;
            this.Button_S2_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2_1.Location = new System.Drawing.Point(18, 7);
            this.Button_S2_1.Name = "Button_S2_1";
            this.Button_S2_1.Size = new System.Drawing.Size(109, 30);
            this.Button_S2_1.TabIndex = 0;
            this.Button_S2_1.Tag = "(0,0,4)";
            this.Button_S2_1.Text = "Z轴刹车继电器";
            this.Button_S2_1.UseVisualStyleBackColor = false;
            this.Button_S2_1.Click += new System.EventHandler(this.Button_S2_1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.Location = new System.Drawing.Point(845, 191);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 17);
            this.Label3.TabIndex = 43;
            this.Label3.Text = "Kgf";
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.Color.LightGreen;
            this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox7.Location = new System.Drawing.Point(753, 188);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(80, 23);
            this.TextBox7.TabIndex = 42;
            this.TextBox7.Text = "0.00";
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Controls.Add(this.panel_S2g);
            this.tabPage8.Controls.Add(this.Teach3);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(999, 567);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Tag = "3";
            this.tabPage8.Text = "   供料   ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(524, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 144);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "单站调试";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Tomato;
            this.button9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(14, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 30);
            this.button9.TabIndex = 110;
            this.button9.Text = "单站运行";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(81, 36);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 29);
            this.button10.TabIndex = 1;
            this.button10.TabStop = false;
            this.button10.Text = "停止";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.BurlyWood;
            this.button11.Location = new System.Drawing.Point(14, 36);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 29);
            this.button11.TabIndex = 0;
            this.button11.TabStop = false;
            this.button11.Text = "暂停";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // panel_S2g
            // 
            this.panel_S2g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_S2g.Controls.Add(this.Button_S2g_7);
            this.panel_S2g.Controls.Add(this.Button_S2g_11);
            this.panel_S2g.Controls.Add(this.Button_S2g_10);
            this.panel_S2g.Controls.Add(this.Button_S2g_9);
            this.panel_S2g.Controls.Add(this.Button_S2g_1);
            this.panel_S2g.Controls.Add(this.Button_S2g_4);
            this.panel_S2g.Controls.Add(this.Button_S2g_2);
            this.panel_S2g.Controls.Add(this.Button_S2g_3);
            this.panel_S2g.Controls.Add(this.Button_S2g_8);
            this.panel_S2g.Controls.Add(this.Button_S2g_6);
            this.panel_S2g.Controls.Add(this.Button_S2g_5);
            this.panel_S2g.Controls.Add(this.label2);
            this.panel_S2g.Controls.Add(this.textBox1);
            this.panel_S2g.Location = new System.Drawing.Point(3, 341);
            this.panel_S2g.Name = "panel_S2g";
            this.panel_S2g.Size = new System.Drawing.Size(486, 192);
            this.panel_S2g.TabIndex = 69;
            // 
            // Button_S2g_7
            // 
            this.Button_S2g_7.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_7.Location = new System.Drawing.Point(6, 145);
            this.Button_S2g_7.Name = "Button_S2g_7";
            this.Button_S2g_7.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_7.TabIndex = 1;
            this.Button_S2g_7.Tag = "(0,0,4)";
            this.Button_S2g_7.Text = "拉料无杆干气缸";
            this.Button_S2g_7.UseVisualStyleBackColor = false;
            this.Button_S2g_7.Visible = false;
            this.Button_S2g_7.Click += new System.EventHandler(this.Button_S2g_7_Click);
            // 
            // Button_S2g_11
            // 
            this.Button_S2g_11.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_11.Location = new System.Drawing.Point(242, 109);
            this.Button_S2g_11.Name = "Button_S2g_11";
            this.Button_S2g_11.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_11.TabIndex = 1;
            this.Button_S2g_11.Tag = "(0,0,8)";
            this.Button_S2g_11.Text = "除底膜吸嘴气缸";
            this.Button_S2g_11.UseVisualStyleBackColor = false;
            this.Button_S2g_11.Click += new System.EventHandler(this.Button_S2g_11_Click);
            // 
            // Button_S2g_10
            // 
            this.Button_S2g_10.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_10.Location = new System.Drawing.Point(242, 73);
            this.Button_S2g_10.Name = "Button_S2g_10";
            this.Button_S2g_10.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_10.TabIndex = 1;
            this.Button_S2g_10.Tag = "(0,0,3)";
            this.Button_S2g_10.Text = "片料夹紧气缸右";
            this.Button_S2g_10.UseVisualStyleBackColor = false;
            this.Button_S2g_10.Click += new System.EventHandler(this.Button_S2g_10_Click);
            // 
            // Button_S2g_9
            // 
            this.Button_S2g_9.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_9.Location = new System.Drawing.Point(124, 109);
            this.Button_S2g_9.Name = "Button_S2g_9";
            this.Button_S2g_9.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_9.TabIndex = 1;
            this.Button_S2g_9.Tag = "(0,0,7)";
            this.Button_S2g_9.Text = "除底摸平移气缸";
            this.Button_S2g_9.UseVisualStyleBackColor = false;
            this.Button_S2g_9.Click += new System.EventHandler(this.Button_S2g_9_Click);
            // 
            // Button_S2g_1
            // 
            this.Button_S2g_1.BackColor = System.Drawing.Color.Khaki;
            this.Button_S2g_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_1.Location = new System.Drawing.Point(6, 1);
            this.Button_S2g_1.Name = "Button_S2g_1";
            this.Button_S2g_1.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_1.TabIndex = 1;
            this.Button_S2g_1.Tag = "(0,0,9)";
            this.Button_S2g_1.Text = "取片料真空吸";
            this.Button_S2g_1.UseVisualStyleBackColor = false;
            this.Button_S2g_1.Click += new System.EventHandler(this.Button_S2g_1_Click);
            // 
            // Button_S2g_4
            // 
            this.Button_S2g_4.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S2g_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_4.Location = new System.Drawing.Point(121, 37);
            this.Button_S2g_4.Name = "Button_S2g_4";
            this.Button_S2g_4.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_4.TabIndex = 1;
            this.Button_S2g_4.Tag = "(0,0,12)";
            this.Button_S2g_4.Text = "取底膜破真空";
            this.Button_S2g_4.UseVisualStyleBackColor = false;
            this.Button_S2g_4.Click += new System.EventHandler(this.Button_S2g_4_Click);
            // 
            // Button_S2g_2
            // 
            this.Button_S2g_2.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S2g_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_2.Location = new System.Drawing.Point(6, 37);
            this.Button_S2g_2.Name = "Button_S2g_2";
            this.Button_S2g_2.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_2.TabIndex = 1;
            this.Button_S2g_2.Tag = "(0,0,10)";
            this.Button_S2g_2.Text = "取片料破真空";
            this.Button_S2g_2.UseVisualStyleBackColor = false;
            this.Button_S2g_2.Click += new System.EventHandler(this.Button_S2g_2_Click);
            // 
            // Button_S2g_3
            // 
            this.Button_S2g_3.BackColor = System.Drawing.Color.Khaki;
            this.Button_S2g_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_3.Location = new System.Drawing.Point(121, 1);
            this.Button_S2g_3.Name = "Button_S2g_3";
            this.Button_S2g_3.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_3.TabIndex = 1;
            this.Button_S2g_3.Tag = "(0,0,11)";
            this.Button_S2g_3.Text = "取底膜真空吸";
            this.Button_S2g_3.UseVisualStyleBackColor = false;
            this.Button_S2g_3.Click += new System.EventHandler(this.Button_S2g_3_Click);
            // 
            // Button_S2g_8
            // 
            this.Button_S2g_8.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_8.Location = new System.Drawing.Point(124, 73);
            this.Button_S2g_8.Name = "Button_S2g_8";
            this.Button_S2g_8.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_8.TabIndex = 1;
            this.Button_S2g_8.Tag = "(0,0,2)";
            this.Button_S2g_8.Text = "片料夹紧气缸左";
            this.Button_S2g_8.UseVisualStyleBackColor = false;
            this.Button_S2g_8.Click += new System.EventHandler(this.Button_S2g_8_Click);
            // 
            // Button_S2g_6
            // 
            this.Button_S2g_6.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_6.Location = new System.Drawing.Point(6, 109);
            this.Button_S2g_6.Name = "Button_S2g_6";
            this.Button_S2g_6.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_6.TabIndex = 1;
            this.Button_S2g_6.Tag = "(0,0,1)";
            this.Button_S2g_6.Text = "撕摸升降气缸";
            this.Button_S2g_6.UseVisualStyleBackColor = false;
            this.Button_S2g_6.Click += new System.EventHandler(this.Button_S2g_6_Click);
            // 
            // Button_S2g_5
            // 
            this.Button_S2g_5.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S2g_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S2g_5.Location = new System.Drawing.Point(6, 73);
            this.Button_S2g_5.Name = "Button_S2g_5";
            this.Button_S2g_5.Size = new System.Drawing.Size(109, 30);
            this.Button_S2g_5.TabIndex = 1;
            this.Button_S2g_5.Tag = "(0,0,0)";
            this.Button_S2g_5.Text = "夹上摸气缸";
            this.Button_S2g_5.UseVisualStyleBackColor = false;
            this.Button_S2g_5.Click += new System.EventHandler(this.Button_S2g_5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(845, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kgf";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGreen;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(753, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 23);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "0.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Teach3
            // 
            this.Teach3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach3.Location = new System.Drawing.Point(3, 3);
            this.Teach3.Name = "Teach3";
            this.Teach3.Size = new System.Drawing.Size(486, 332);
            this.Teach3.TabIndex = 68;
            this.Teach3.Tag = "3";
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.groupBox10);
            this.tabPage12.Controls.Add(this.panel4);
            this.tabPage12.Controls.Add(this.groupBox7);
            this.tabPage12.Controls.Add(this.Teach2);
            this.tabPage12.Location = new System.Drawing.Point(4, 29);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(999, 567);
            this.tabPage12.TabIndex = 6;
            this.tabPage12.Text = " 3 工位 ";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.Text_ForceS3);
            this.groupBox10.Controls.Add(this.Btn_OpenSerialS3);
            this.groupBox10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox10.ForeColor = System.Drawing.Color.Blue;
            this.groupBox10.Location = new System.Drawing.Point(520, 349);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(151, 90);
            this.groupBox10.TabIndex = 51;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "保压";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(117, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "kgf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Value:";
            // 
            // Text_ForceS3
            // 
            this.Text_ForceS3.BackColor = System.Drawing.Color.Black;
            this.Text_ForceS3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_ForceS3.ForeColor = System.Drawing.Color.Lime;
            this.Text_ForceS3.Location = new System.Drawing.Point(55, 22);
            this.Text_ForceS3.Name = "Text_ForceS3";
            this.Text_ForceS3.ReadOnly = true;
            this.Text_ForceS3.Size = new System.Drawing.Size(60, 26);
            this.Text_ForceS3.TabIndex = 6;
            this.Text_ForceS3.Text = "0.00";
            this.Text_ForceS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_OpenSerialS3
            // 
            this.Btn_OpenSerialS3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenSerialS3.ForeColor = System.Drawing.Color.Black;
            this.Btn_OpenSerialS3.Location = new System.Drawing.Point(56, 54);
            this.Btn_OpenSerialS3.Name = "Btn_OpenSerialS3";
            this.Btn_OpenSerialS3.Size = new System.Drawing.Size(59, 32);
            this.Btn_OpenSerialS3.TabIndex = 3;
            this.Btn_OpenSerialS3.Text = "Open";
            this.Btn_OpenSerialS3.UseVisualStyleBackColor = true;
            this.Btn_OpenSerialS3.Click += new System.EventHandler(this.Btn_OpenSerialS3_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Button_S3_2);
            this.panel4.Controls.Add(this.Button_S3_1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(3, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 182);
            this.panel4.TabIndex = 50;
            // 
            // Button_S3_2
            // 
            this.Button_S3_2.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S3_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S3_2.Location = new System.Drawing.Point(18, 57);
            this.Button_S3_2.Name = "Button_S3_2";
            this.Button_S3_2.Size = new System.Drawing.Size(109, 30);
            this.Button_S3_2.TabIndex = 1;
            this.Button_S3_2.Tag = "(0,0,5)";
            this.Button_S3_2.Text = "保压升降气缸";
            this.Button_S3_2.UseVisualStyleBackColor = false;
            this.Button_S3_2.Click += new System.EventHandler(this.Button_S3_2_Click);
            // 
            // Button_S3_1
            // 
            this.Button_S3_1.BackColor = System.Drawing.Color.Gold;
            this.Button_S3_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S3_1.Location = new System.Drawing.Point(18, 7);
            this.Button_S3_1.Name = "Button_S3_1";
            this.Button_S3_1.Size = new System.Drawing.Size(109, 30);
            this.Button_S3_1.TabIndex = 0;
            this.Button_S3_1.Tag = "(0,0,5)";
            this.Button_S3_1.Text = "Z轴刹车继电器";
            this.Button_S3_1.UseVisualStyleBackColor = false;
            this.Button_S3_1.Click += new System.EventHandler(this.Button_S3_1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(845, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Kgf";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(753, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 23);
            this.textBox2.TabIndex = 42;
            this.textBox2.Text = "0.00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button14);
            this.groupBox7.Controls.Add(this.button15);
            this.groupBox7.Controls.Add(this.button16);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(516, 37);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(157, 144);
            this.groupBox7.TabIndex = 48;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "单站调试";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Tomato;
            this.button14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(14, 100);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 30);
            this.button14.TabIndex = 110;
            this.button14.Text = "单站运行";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(81, 36);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 29);
            this.button15.TabIndex = 1;
            this.button15.Text = "停止";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.BurlyWood;
            this.button16.Location = new System.Drawing.Point(14, 36);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(59, 29);
            this.button16.TabIndex = 0;
            this.button16.Text = "暂停";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // Teach2
            // 
            this.Teach2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach2.Location = new System.Drawing.Point(3, 3);
            this.Teach2.Name = "Teach2";
            this.Teach2.Size = new System.Drawing.Size(486, 332);
            this.Teach2.TabIndex = 2;
            this.Teach2.Tag = "1";
            // 
            // TabPage13
            // 
            this.TabPage13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage13.Controls.Add(this.TextBox_CCD2);
            this.TabPage13.Controls.Add(this.TabControl5);
            this.TabPage13.Location = new System.Drawing.Point(4, 29);
            this.TabPage13.Name = "TabPage13";
            this.TabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage13.Size = new System.Drawing.Size(999, 567);
            this.TabPage13.TabIndex = 0;
            this.TabPage13.Text = " 4工位&转盘 ";
            // 
            // TextBox_CCD2
            // 
            this.TextBox_CCD2.Location = new System.Drawing.Point(8, 538);
            this.TextBox_CCD2.Name = "TextBox_CCD2";
            this.TextBox_CCD2.Size = new System.Drawing.Size(983, 26);
            this.TextBox_CCD2.TabIndex = 65;
            // 
            // TabControl5
            // 
            this.TabControl5.Controls.Add(this.TabPage14);
            this.TabControl5.Controls.Add(this.TabPage_LightControl);
            this.TabControl5.Controls.Add(this.TabPage15);
            this.TabControl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl5.Location = new System.Drawing.Point(0, 0);
            this.TabControl5.Name = "TabControl5";
            this.TabControl5.SelectedIndex = 0;
            this.TabControl5.Size = new System.Drawing.Size(1000, 537);
            this.TabControl5.TabIndex = 2;
            // 
            // TabPage14
            // 
            this.TabPage14.BackColor = System.Drawing.Color.White;
            this.TabPage14.Controls.Add(this.panel2);
            this.TabPage14.Controls.Add(this.panel5);
            this.TabPage14.Controls.Add(this.Teach4);
            this.TabPage14.Location = new System.Drawing.Point(4, 29);
            this.TabPage14.Name = "TabPage14";
            this.TabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage14.Size = new System.Drawing.Size(992, 504);
            this.TabPage14.TabIndex = 0;
            this.TabPage14.Text = " 转盘 R ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.CCD_Trigger_S4);
            this.panel2.Controls.Add(this.ComboBox_Cam2);
            this.panel2.Location = new System.Drawing.Point(512, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 106);
            this.panel2.TabIndex = 72;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(6, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 40);
            this.button6.TabIndex = 2;
            this.button6.Tag = "2";
            this.button6.Text = "截图";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // CCD_Trigger_S4
            // 
            this.CCD_Trigger_S4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CCD_Trigger_S4.Image = ((System.Drawing.Image)(resources.GetObject("CCD_Trigger_S4.Image")));
            this.CCD_Trigger_S4.Location = new System.Drawing.Point(120, 58);
            this.CCD_Trigger_S4.Name = "CCD_Trigger_S4";
            this.CCD_Trigger_S4.Size = new System.Drawing.Size(92, 40);
            this.CCD_Trigger_S4.TabIndex = 2;
            this.CCD_Trigger_S4.Tag = "2";
            this.CCD_Trigger_S4.Text = "CCD拍 照";
            this.CCD_Trigger_S4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CCD_Trigger_S4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CCD_Trigger_S4.UseVisualStyleBackColor = true;
            this.CCD_Trigger_S4.Click += new System.EventHandler(this.CCD_Trigger_S4_Click);
            // 
            // ComboBox_Cam2
            // 
            this.ComboBox_Cam2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBox_Cam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Cam2.FormattingEnabled = true;
            this.ComboBox_Cam2.Items.AddRange(new object[] {
            "复检角度拍照",
            "复检同心度拍照"});
            this.ComboBox_Cam2.Location = new System.Drawing.Point(3, 15);
            this.ComboBox_Cam2.Name = "ComboBox_Cam2";
            this.ComboBox_Cam2.Size = new System.Drawing.Size(211, 33);
            this.ComboBox_Cam2.TabIndex = 1;
            this.ComboBox_Cam2.Text = "复检角度拍照";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Button_S4_8);
            this.panel5.Controls.Add(this.Button_S4_7);
            this.panel5.Controls.Add(this.Button_S4_6);
            this.panel5.Controls.Add(this.Button_S4_5);
            this.panel5.Controls.Add(this.Button_S4_4);
            this.panel5.Controls.Add(this.Button_S4_3);
            this.panel5.Controls.Add(this.Button_S4_9);
            this.panel5.Controls.Add(this.Button_S4_2);
            this.panel5.Controls.Add(this.Button_S4_1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Location = new System.Drawing.Point(6, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(486, 156);
            this.panel5.TabIndex = 66;
            // 
            // Button_S4_8
            // 
            this.Button_S4_8.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S4_8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_8.Location = new System.Drawing.Point(358, 44);
            this.Button_S4_8.Name = "Button_S4_8";
            this.Button_S4_8.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_8.TabIndex = 0;
            this.Button_S4_8.Tag = "(0,0,13)";
            this.Button_S4_8.Text = "4#载具破真空";
            this.Button_S4_8.UseVisualStyleBackColor = false;
            this.Button_S4_8.Click += new System.EventHandler(this.Button_S4_8_Click);
            // 
            // Button_S4_7
            // 
            this.Button_S4_7.BackColor = System.Drawing.Color.Khaki;
            this.Button_S4_7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_7.Location = new System.Drawing.Point(358, 7);
            this.Button_S4_7.Name = "Button_S4_7";
            this.Button_S4_7.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_7.TabIndex = 0;
            this.Button_S4_7.Tag = "(0,0,12)";
            this.Button_S4_7.Text = "4#载具真空吸";
            this.Button_S4_7.UseVisualStyleBackColor = false;
            this.Button_S4_7.Click += new System.EventHandler(this.Button_S4_7_Click);
            // 
            // Button_S4_6
            // 
            this.Button_S4_6.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S4_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_6.Location = new System.Drawing.Point(243, 44);
            this.Button_S4_6.Name = "Button_S4_6";
            this.Button_S4_6.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_6.TabIndex = 0;
            this.Button_S4_6.Tag = "(0,0,11)";
            this.Button_S4_6.Text = "3#载具破真空";
            this.Button_S4_6.UseVisualStyleBackColor = false;
            this.Button_S4_6.Click += new System.EventHandler(this.Button_S4_6_Click);
            // 
            // Button_S4_5
            // 
            this.Button_S4_5.BackColor = System.Drawing.Color.Khaki;
            this.Button_S4_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_5.Location = new System.Drawing.Point(243, 7);
            this.Button_S4_5.Name = "Button_S4_5";
            this.Button_S4_5.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_5.TabIndex = 0;
            this.Button_S4_5.Tag = "(0,0,10)";
            this.Button_S4_5.Text = "3#载具真空吸";
            this.Button_S4_5.UseVisualStyleBackColor = false;
            this.Button_S4_5.Click += new System.EventHandler(this.Button_S4_5_Click);
            // 
            // Button_S4_4
            // 
            this.Button_S4_4.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S4_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_4.Location = new System.Drawing.Point(128, 44);
            this.Button_S4_4.Name = "Button_S4_4";
            this.Button_S4_4.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_4.TabIndex = 0;
            this.Button_S4_4.Tag = "(0,0,9)";
            this.Button_S4_4.Text = "2#载具破真空";
            this.Button_S4_4.UseVisualStyleBackColor = false;
            this.Button_S4_4.Click += new System.EventHandler(this.Button_S4_4_Click);
            // 
            // Button_S4_3
            // 
            this.Button_S4_3.BackColor = System.Drawing.Color.Khaki;
            this.Button_S4_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_3.Location = new System.Drawing.Point(128, 7);
            this.Button_S4_3.Name = "Button_S4_3";
            this.Button_S4_3.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_3.TabIndex = 0;
            this.Button_S4_3.Tag = "(0,0,8)";
            this.Button_S4_3.Text = "2#载具真空吸";
            this.Button_S4_3.UseVisualStyleBackColor = false;
            this.Button_S4_3.Click += new System.EventHandler(this.Button_S4_3_Click);
            // 
            // Button_S4_9
            // 
            this.Button_S4_9.BackColor = System.Drawing.Color.LightGreen;
            this.Button_S4_9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_9.Location = new System.Drawing.Point(13, 120);
            this.Button_S4_9.Name = "Button_S4_9";
            this.Button_S4_9.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_9.TabIndex = 1;
            this.Button_S4_9.Tag = "(0,0,6)";
            this.Button_S4_9.Text = "复检气缸";
            this.Button_S4_9.UseVisualStyleBackColor = false;
            this.Button_S4_9.Click += new System.EventHandler(this.Button_S4_9_Click);
            // 
            // Button_S4_2
            // 
            this.Button_S4_2.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_S4_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_2.Location = new System.Drawing.Point(13, 44);
            this.Button_S4_2.Name = "Button_S4_2";
            this.Button_S4_2.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_2.TabIndex = 0;
            this.Button_S4_2.Tag = "(0,0,7)";
            this.Button_S4_2.Text = "1#载具破真空";
            this.Button_S4_2.UseVisualStyleBackColor = false;
            this.Button_S4_2.Click += new System.EventHandler(this.Button_S4_2_Click);
            // 
            // Button_S4_1
            // 
            this.Button_S4_1.BackColor = System.Drawing.Color.Khaki;
            this.Button_S4_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_S4_1.Location = new System.Drawing.Point(13, 7);
            this.Button_S4_1.Name = "Button_S4_1";
            this.Button_S4_1.Size = new System.Drawing.Size(109, 30);
            this.Button_S4_1.TabIndex = 0;
            this.Button_S4_1.Tag = "(0,0,6)";
            this.Button_S4_1.Text = "1#载具真空吸";
            this.Button_S4_1.UseVisualStyleBackColor = false;
            this.Button_S4_1.Click += new System.EventHandler(this.Button_S4_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(845, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Kgf";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGreen;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(753, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 23);
            this.textBox4.TabIndex = 42;
            this.textBox4.Text = "0.00";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Teach4
            // 
            this.Teach4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Teach4.Location = new System.Drawing.Point(6, 6);
            this.Teach4.Name = "Teach4";
            this.Teach4.Size = new System.Drawing.Size(486, 332);
            this.Teach4.TabIndex = 65;
            this.Teach4.Tag = "2";
            // 
            // TabPage_LightControl
            // 
            this.TabPage_LightControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage_LightControl.Controls.Add(this.LightControl1);
            this.TabPage_LightControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage_LightControl.Location = new System.Drawing.Point(4, 29);
            this.TabPage_LightControl.Name = "TabPage_LightControl";
            this.TabPage_LightControl.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_LightControl.Size = new System.Drawing.Size(992, 504);
            this.TabPage_LightControl.TabIndex = 3;
            this.TabPage_LightControl.Text = " Light Source ";
            // 
            // LightControl1
            // 
            this.LightControl1.AutoSize = true;
            this.LightControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.LightControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LightControl1.Location = new System.Drawing.Point(6, 4);
            this.LightControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LightControl1.Name = "LightControl1";
            this.LightControl1.Size = new System.Drawing.Size(486, 426);
            this.LightControl1.TabIndex = 0;
            this.LightControl1.Tag = "0";
            // 
            // TabPage15
            // 
            this.TabPage15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage15.Controls.Add(this.Panel_Calibration);
            this.TabPage15.Location = new System.Drawing.Point(4, 29);
            this.TabPage15.Name = "TabPage15";
            this.TabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage15.Size = new System.Drawing.Size(992, 504);
            this.TabPage15.TabIndex = 1;
            this.TabPage15.Text = "Calibration ";
            // 
            // Panel_Calibration
            // 
            this.Panel_Calibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel_Calibration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Calibration.Controls.Add(this.infoList2);
            this.Panel_Calibration.Controls.Add(this.TextBox_Laser);
            this.Panel_Calibration.Controls.Add(this.Label45);
            this.Panel_Calibration.Controls.Add(this.Label46);
            this.Panel_Calibration.Controls.Add(this.Button_Laser);
            this.Panel_Calibration.Controls.Add(this.Panel16);
            this.Panel_Calibration.Controls.Add(this.Label48);
            this.Panel_Calibration.Controls.Add(this.PictureBox1);
            this.Panel_Calibration.Controls.Add(this.GroupBox11);
            this.Panel_Calibration.Controls.Add(this.GroupBox6);
            this.Panel_Calibration.Controls.Add(this.GroupBox5);
            this.Panel_Calibration.Controls.Add(this.Panel19);
            this.Panel_Calibration.Controls.Add(this.Panel_Vup);
            this.Panel_Calibration.Controls.Add(this.GroupBox1);
            this.Panel_Calibration.Controls.Add(this.Panel17);
            this.Panel_Calibration.Controls.Add(this.GroupBox2);
            this.Panel_Calibration.Location = new System.Drawing.Point(6, 6);
            this.Panel_Calibration.Name = "Panel_Calibration";
            this.Panel_Calibration.Size = new System.Drawing.Size(980, 559);
            this.Panel_Calibration.TabIndex = 0;
            // 
            // infoList2
            // 
            this.infoList2.AutoSize = true;
            this.infoList2.Location = new System.Drawing.Point(630, 5);
            this.infoList2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.infoList2.Name = "infoList2";
            this.infoList2.Size = new System.Drawing.Size(344, 492);
            this.infoList2.TabIndex = 59;
            // 
            // TextBox_Laser
            // 
            this.TextBox_Laser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Laser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Laser.Location = new System.Drawing.Point(80, 348);
            this.TextBox_Laser.Name = "TextBox_Laser";
            this.TextBox_Laser.ReadOnly = true;
            this.TextBox_Laser.Size = new System.Drawing.Size(81, 23);
            this.TextBox_Laser.TabIndex = 56;
            this.TextBox_Laser.Text = "0.0000";
            this.TextBox_Laser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label45.ForeColor = System.Drawing.Color.Black;
            this.Label45.Location = new System.Drawing.Point(160, 349);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(29, 19);
            this.Label45.TabIndex = 58;
            this.Label45.Text = "mm";
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label46.ForeColor = System.Drawing.Color.Black;
            this.Label46.Location = new System.Drawing.Point(22, 354);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(56, 14);
            this.Label46.TabIndex = 57;
            this.Label46.Text = "镭射值:";
            // 
            // Button_Laser
            // 
            this.Button_Laser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Laser.ForeColor = System.Drawing.Color.Black;
            this.Button_Laser.Location = new System.Drawing.Point(206, 345);
            this.Button_Laser.Name = "Button_Laser";
            this.Button_Laser.Size = new System.Drawing.Size(67, 32);
            this.Button_Laser.TabIndex = 55;
            this.Button_Laser.Text = "镭射打开";
            this.Button_Laser.UseVisualStyleBackColor = true;
            // 
            // Panel16
            // 
            this.Panel16.Controls.Add(this.Label55);
            this.Panel16.Controls.Add(this.ComboBox_TL);
            this.Panel16.Controls.Add(this.Button_GetTL);
            this.Panel16.Controls.Add(this.TextBox_TLX);
            this.Panel16.Controls.Add(this.TextBox_TLY);
            this.Panel16.Controls.Add(this.TextBox_TLZ);
            this.Panel16.Controls.Add(this.TextBox_TLA);
            this.Panel16.Controls.Add(this.TextBox_TLB);
            this.Panel16.Controls.Add(this.TextBox_TLC);
            this.Panel16.Controls.Add(this.Label49);
            this.Panel16.Controls.Add(this.Label50);
            this.Panel16.Controls.Add(this.Label51);
            this.Panel16.Controls.Add(this.Label52);
            this.Panel16.Controls.Add(this.Label53);
            this.Panel16.Controls.Add(this.Label54);
            this.Panel16.Location = new System.Drawing.Point(29, 5);
            this.Panel16.Name = "Panel16";
            this.Panel16.Size = new System.Drawing.Size(264, 187);
            this.Panel16.TabIndex = 54;
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.ForeColor = System.Drawing.Color.Red;
            this.Label55.Location = new System.Drawing.Point(14, 0);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(185, 20);
            this.Label55.TabIndex = 54;
            this.Label55.Text = "机械手工具坐标当前值：";
            // 
            // ComboBox_TL
            // 
            this.ComboBox_TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_TL.FormattingEnabled = true;
            this.ComboBox_TL.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ComboBox_TL.Items.AddRange(new object[] {
            "Tool-0",
            "Tool-1",
            "Tool-2",
            "Tool-3",
            "Tool-4"});
            this.ComboBox_TL.Location = new System.Drawing.Point(122, 47);
            this.ComboBox_TL.Name = "ComboBox_TL";
            this.ComboBox_TL.Size = new System.Drawing.Size(114, 28);
            this.ComboBox_TL.TabIndex = 8;
            this.ComboBox_TL.Text = "Tool-0";
            // 
            // Button_GetTL
            // 
            this.Button_GetTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GetTL.Location = new System.Drawing.Point(110, 135);
            this.Button_GetTL.Name = "Button_GetTL";
            this.Button_GetTL.Size = new System.Drawing.Size(149, 43);
            this.Button_GetTL.TabIndex = 7;
            this.Button_GetTL.Text = "获取Rbt当前工具位置";
            this.Button_GetTL.UseVisualStyleBackColor = true;
            // 
            // TextBox_TLX
            // 
            this.TextBox_TLX.BackColor = System.Drawing.Color.White;
            this.TextBox_TLX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TLX.Location = new System.Drawing.Point(42, 44);
            this.TextBox_TLX.Name = "TextBox_TLX";
            this.TextBox_TLX.ReadOnly = true;
            this.TextBox_TLX.Size = new System.Drawing.Size(53, 21);
            this.TextBox_TLX.TabIndex = 1;
            this.TextBox_TLX.Text = "0.00";
            this.TextBox_TLX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_TLY
            // 
            this.TextBox_TLY.BackColor = System.Drawing.Color.White;
            this.TextBox_TLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TLY.Location = new System.Drawing.Point(42, 66);
            this.TextBox_TLY.Name = "TextBox_TLY";
            this.TextBox_TLY.ReadOnly = true;
            this.TextBox_TLY.Size = new System.Drawing.Size(53, 21);
            this.TextBox_TLY.TabIndex = 2;
            this.TextBox_TLY.Text = "0.00";
            this.TextBox_TLY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_TLZ
            // 
            this.TextBox_TLZ.BackColor = System.Drawing.Color.White;
            this.TextBox_TLZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TLZ.Location = new System.Drawing.Point(42, 88);
            this.TextBox_TLZ.Name = "TextBox_TLZ";
            this.TextBox_TLZ.ReadOnly = true;
            this.TextBox_TLZ.Size = new System.Drawing.Size(53, 21);
            this.TextBox_TLZ.TabIndex = 3;
            this.TextBox_TLZ.Text = "0.00";
            this.TextBox_TLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_TLA
            // 
            this.TextBox_TLA.BackColor = System.Drawing.Color.White;
            this.TextBox_TLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TLA.Location = new System.Drawing.Point(42, 110);
            this.TextBox_TLA.Name = "TextBox_TLA";
            this.TextBox_TLA.ReadOnly = true;
            this.TextBox_TLA.Size = new System.Drawing.Size(53, 21);
            this.TextBox_TLA.TabIndex = 4;
            this.TextBox_TLA.Text = "0.00";
            this.TextBox_TLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_TLB
            // 
            this.TextBox_TLB.BackColor = System.Drawing.Color.White;
            this.TextBox_TLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TLB.Location = new System.Drawing.Point(42, 132);
            this.TextBox_TLB.Name = "TextBox_TLB";
            this.TextBox_TLB.ReadOnly = true;
            this.TextBox_TLB.Size = new System.Drawing.Size(53, 21);
            this.TextBox_TLB.TabIndex = 5;
            this.TextBox_TLB.Text = "0.00";
            this.TextBox_TLB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_TLC
            // 
            this.TextBox_TLC.BackColor = System.Drawing.Color.White;
            this.TextBox_TLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TLC.Location = new System.Drawing.Point(41, 154);
            this.TextBox_TLC.Name = "TextBox_TLC";
            this.TextBox_TLC.ReadOnly = true;
            this.TextBox_TLC.Size = new System.Drawing.Size(53, 21);
            this.TextBox_TLC.TabIndex = 6;
            this.TextBox_TLC.Text = "0.00";
            this.TextBox_TLC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.Location = new System.Drawing.Point(15, 157);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(27, 15);
            this.Label49.TabIndex = 6;
            this.Label49.Text = "C：";
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50.Location = new System.Drawing.Point(15, 135);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(27, 15);
            this.Label50.TabIndex = 5;
            this.Label50.Text = "B：";
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.Location = new System.Drawing.Point(15, 113);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(26, 15);
            this.Label51.TabIndex = 4;
            this.Label51.Text = "A：";
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.Location = new System.Drawing.Point(15, 91);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(26, 15);
            this.Label52.TabIndex = 3;
            this.Label52.Text = "Z：";
            // 
            // Label53
            // 
            this.Label53.AutoSize = true;
            this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.Location = new System.Drawing.Point(15, 69);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(26, 15);
            this.Label53.TabIndex = 2;
            this.Label53.Text = "Y：";
            // 
            // Label54
            // 
            this.Label54.AutoSize = true;
            this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label54.Location = new System.Drawing.Point(15, 47);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(27, 15);
            this.Label54.TabIndex = 0;
            this.Label54.Text = "X：";
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.ForeColor = System.Drawing.Color.Red;
            this.Label48.Location = new System.Drawing.Point(332, 5);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(185, 20);
            this.Label48.TabIndex = 53;
            this.Label48.Text = "机械手工具坐标参考值：";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(342, 28);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(280, 156);
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // GroupBox11
            // 
            this.GroupBox11.Controls.Add(this.Panel15);
            this.GroupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox11.Location = new System.Drawing.Point(19, 198);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new System.Drawing.Size(312, 145);
            this.GroupBox11.TabIndex = 51;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "机械手标定";
            // 
            // Panel15
            // 
            this.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel15.Controls.Add(this.Robot_Biaoding);
            this.Panel15.Controls.Add(this.ComboBox_Robot);
            this.Panel15.Location = new System.Drawing.Point(10, 31);
            this.Panel15.Name = "Panel15";
            this.Panel15.Size = new System.Drawing.Size(291, 108);
            this.Panel15.TabIndex = 48;
            // 
            // Robot_Biaoding
            // 
            this.Robot_Biaoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Robot_Biaoding.Location = new System.Drawing.Point(191, 53);
            this.Robot_Biaoding.Name = "Robot_Biaoding";
            this.Robot_Biaoding.Size = new System.Drawing.Size(92, 40);
            this.Robot_Biaoding.TabIndex = 3;
            this.Robot_Biaoding.Tag = "2";
            this.Robot_Biaoding.Text = "开始";
            this.Robot_Biaoding.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Robot
            // 
            this.ComboBox_Robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Robot.FormattingEnabled = true;
            this.ComboBox_Robot.Items.AddRange(new object[] {
            "0.XY-吸嘴1",
            "1.XY-吸嘴2",
            "2.XY-吸嘴3",
            "3.ABC-吸嘴1",
            "4.ABC-吸嘴2",
            "5.ABC-吸嘴3"});
            this.ComboBox_Robot.Location = new System.Drawing.Point(3, 12);
            this.ComboBox_Robot.Name = "ComboBox_Robot";
            this.ComboBox_Robot.Size = new System.Drawing.Size(283, 28);
            this.ComboBox_Robot.TabIndex = 1;
            this.ComboBox_Robot.Text = "0.XY-吸嘴1";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.Panel_Test);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(342, 349);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(267, 145);
            this.GroupBox6.TabIndex = 50;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "动静态测试";
            // 
            // Panel_Test
            // 
            this.Panel_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Test.Controls.Add(this.Label42);
            this.Panel_Test.Controls.Add(this.TextBox_Num);
            this.Panel_Test.Controls.Add(this.Button_Test);
            this.Panel_Test.Controls.Add(this.ComboBox2);
            this.Panel_Test.Location = new System.Drawing.Point(10, 31);
            this.Panel_Test.Name = "Panel_Test";
            this.Panel_Test.Size = new System.Drawing.Size(251, 108);
            this.Panel_Test.TabIndex = 48;
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Location = new System.Drawing.Point(80, 65);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(22, 17);
            this.Label42.TabIndex = 84;
            this.Label42.Text = "次";
            // 
            // TextBox_Num
            // 
            this.TextBox_Num.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Num.Location = new System.Drawing.Point(14, 64);
            this.TextBox_Num.Name = "TextBox_Num";
            this.TextBox_Num.Size = new System.Drawing.Size(60, 23);
            this.TextBox_Num.TabIndex = 83;
            this.TextBox_Num.Text = "35";
            this.TextBox_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_Test
            // 
            this.Button_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Test.Location = new System.Drawing.Point(133, 53);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(92, 40);
            this.Button_Test.TabIndex = 3;
            this.Button_Test.Tag = "2";
            this.Button_Test.Text = "开始";
            this.Button_Test.UseVisualStyleBackColor = true;
            // 
            // ComboBox2
            // 
            this.ComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "0:机械手【静态】测试",
            "1:机械手【动态】测试",
            "2:HSG【静态】测试",
            "3:取料【静态】测试",
            "4:取料【动态】测试",
            "5:复检【静态】测试",
            "6:复检【动态】测试"});
            this.ComboBox2.Location = new System.Drawing.Point(0, 12);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(246, 28);
            this.ComboBox2.TabIndex = 1;
            this.ComboBox2.Text = "0:机械手【静态】测试";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.PanelCalibration);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(342, 198);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(267, 145);
            this.GroupBox5.TabIndex = 49;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "相机标定";
            // 
            // PanelCalibration
            // 
            this.PanelCalibration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCalibration.Controls.Add(this.Btn_CalibrationList);
            this.PanelCalibration.Controls.Add(this.ComboBox_CCD);
            this.PanelCalibration.Controls.Add(this.List_Info);
            this.PanelCalibration.Location = new System.Drawing.Point(10, 31);
            this.PanelCalibration.Name = "PanelCalibration";
            this.PanelCalibration.Size = new System.Drawing.Size(251, 108);
            this.PanelCalibration.TabIndex = 48;
            // 
            // Btn_CalibrationList
            // 
            this.Btn_CalibrationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_CalibrationList.Location = new System.Drawing.Point(133, 53);
            this.Btn_CalibrationList.Name = "Btn_CalibrationList";
            this.Btn_CalibrationList.Size = new System.Drawing.Size(92, 40);
            this.Btn_CalibrationList.TabIndex = 3;
            this.Btn_CalibrationList.Tag = "2";
            this.Btn_CalibrationList.Text = "开始";
            this.Btn_CalibrationList.UseVisualStyleBackColor = true;
            // 
            // ComboBox_CCD
            // 
            this.ComboBox_CCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_CCD.FormattingEnabled = true;
            this.ComboBox_CCD.Items.AddRange(new object[] {
            "0.CCD九点标定-吸嘴1",
            "1.CCD九点标定-吸嘴2",
            "2.CCD九点标定-吸嘴3",
            "3.上下CCD坐标标定-吸嘴1",
            "4.上下CCD坐标标定-吸嘴2",
            "5.上下CCD坐标标定-吸嘴3",
            "6.右取料CCD九点标定"});
            this.ComboBox_CCD.Location = new System.Drawing.Point(0, 12);
            this.ComboBox_CCD.Name = "ComboBox_CCD";
            this.ComboBox_CCD.Size = new System.Drawing.Size(246, 28);
            this.ComboBox_CCD.TabIndex = 1;
            this.ComboBox_CCD.Text = "0.定位下CCD九点标定";
            // 
            // List_Info
            // 
            this.List_Info.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.List_Info.FormattingEnabled = true;
            this.List_Info.HorizontalScrollbar = true;
            this.List_Info.ItemHeight = 14;
            this.List_Info.Location = new System.Drawing.Point(32, 61);
            this.List_Info.Name = "List_Info";
            this.List_Info.Size = new System.Drawing.Size(42, 32);
            this.List_Info.TabIndex = 3;
            // 
            // Panel19
            // 
            this.Panel19.Controls.Add(this.Button8);
            this.Panel19.Controls.Add(this.Label_PDCA_Step);
            this.Panel19.Controls.Add(this.Button4);
            this.Panel19.Controls.Add(this.Label26);
            this.Panel19.Controls.Add(this.Txt_MLBBarcode);
            this.Panel19.Controls.Add(this.Btn_PDCATest);
            this.Panel19.Location = new System.Drawing.Point(19, 381);
            this.Panel19.Name = "Panel19";
            this.Panel19.Size = new System.Drawing.Size(312, 106);
            this.Panel19.TabIndex = 15;
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button8.Location = new System.Drawing.Point(233, 63);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(68, 32);
            this.Button8.TabIndex = 19;
            this.Button8.Text = "触发";
            this.Button8.UseVisualStyleBackColor = true;
            // 
            // Label_PDCA_Step
            // 
            this.Label_PDCA_Step.AutoSize = true;
            this.Label_PDCA_Step.Location = new System.Drawing.Point(87, 69);
            this.Label_PDCA_Step.Name = "Label_PDCA_Step";
            this.Label_PDCA_Step.Size = new System.Drawing.Size(18, 20);
            this.Label_PDCA_Step.TabIndex = 18;
            this.Label_PDCA_Step.Text = "0";
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button4.Location = new System.Drawing.Point(132, 63);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(87, 32);
            this.Button4.TabIndex = 17;
            this.Button4.Text = "查看运行Log";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(10, 23);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(98, 15);
            this.Label26.TabIndex = 15;
            this.Label26.Text = "HSG_Barcode：";
            // 
            // Txt_MLBBarcode
            // 
            this.Txt_MLBBarcode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_MLBBarcode.Location = new System.Drawing.Point(111, 22);
            this.Txt_MLBBarcode.Name = "Txt_MLBBarcode";
            this.Txt_MLBBarcode.Size = new System.Drawing.Size(198, 21);
            this.Txt_MLBBarcode.TabIndex = 13;
            this.Txt_MLBBarcode.Text = "A123456789000095678901234528";
            // 
            // Btn_PDCATest
            // 
            this.Btn_PDCATest.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_PDCATest.Location = new System.Drawing.Point(13, 63);
            this.Btn_PDCATest.Name = "Btn_PDCATest";
            this.Btn_PDCATest.Size = new System.Drawing.Size(68, 32);
            this.Btn_PDCATest.TabIndex = 11;
            this.Btn_PDCATest.Text = "测试PDCA";
            this.Btn_PDCATest.UseVisualStyleBackColor = true;
            // 
            // Panel_Vup
            // 
            this.Panel_Vup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Vup.Controls.Add(this.Btn_Vup_Check);
            this.Panel_Vup.Controls.Add(this.TB_Vup_Angel);
            this.Panel_Vup.Controls.Add(this.Label27);
            this.Panel_Vup.Controls.Add(this.TB_Vup_Center_Y);
            this.Panel_Vup.Controls.Add(this.Label29);
            this.Panel_Vup.Controls.Add(this.Label30);
            this.Panel_Vup.Controls.Add(this.TB_Vup_Center_X);
            this.Panel_Vup.Controls.Add(this.Btn_Vup_Calibration);
            this.Panel_Vup.Location = new System.Drawing.Point(773, 239);
            this.Panel_Vup.Name = "Panel_Vup";
            this.Panel_Vup.Size = new System.Drawing.Size(133, 150);
            this.Panel_Vup.TabIndex = 0;
            this.Panel_Vup.Visible = false;
            // 
            // Btn_Vup_Check
            // 
            this.Btn_Vup_Check.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Vup_Check.Location = new System.Drawing.Point(233, 70);
            this.Btn_Vup_Check.Name = "Btn_Vup_Check";
            this.Btn_Vup_Check.Size = new System.Drawing.Size(150, 30);
            this.Btn_Vup_Check.TabIndex = 8;
            this.Btn_Vup_Check.Text = "VB+ 验证";
            this.Btn_Vup_Check.UseVisualStyleBackColor = true;
            // 
            // TB_Vup_Angel
            // 
            this.TB_Vup_Angel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB_Vup_Angel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Vup_Angel.Location = new System.Drawing.Point(56, 120);
            this.TB_Vup_Angel.Name = "TB_Vup_Angel";
            this.TB_Vup_Angel.Size = new System.Drawing.Size(147, 26);
            this.TB_Vup_Angel.TabIndex = 7;
            this.TB_Vup_Angel.Text = "3";
            this.TB_Vup_Angel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label27.Location = new System.Drawing.Point(20, 96);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(107, 20);
            this.Label27.TabIndex = 6;
            this.Label27.Text = "验证旋转角度：";
            // 
            // TB_Vup_Center_Y
            // 
            this.TB_Vup_Center_Y.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB_Vup_Center_Y.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Vup_Center_Y.Location = new System.Drawing.Point(56, 70);
            this.TB_Vup_Center_Y.Name = "TB_Vup_Center_Y";
            this.TB_Vup_Center_Y.Size = new System.Drawing.Size(147, 26);
            this.TB_Vup_Center_Y.TabIndex = 5;
            this.TB_Vup_Center_Y.Text = "0.00";
            this.TB_Vup_Center_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label29.Location = new System.Drawing.Point(20, 48);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(87, 20);
            this.Label29.TabIndex = 3;
            this.Label29.Text = "旋转中心Y：";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label30.Location = new System.Drawing.Point(20, 0);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(88, 20);
            this.Label30.TabIndex = 2;
            this.Label30.Text = "旋转中心X：";
            // 
            // TB_Vup_Center_X
            // 
            this.TB_Vup_Center_X.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB_Vup_Center_X.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Vup_Center_X.Location = new System.Drawing.Point(56, 20);
            this.TB_Vup_Center_X.Name = "TB_Vup_Center_X";
            this.TB_Vup_Center_X.Size = new System.Drawing.Size(147, 26);
            this.TB_Vup_Center_X.TabIndex = 1;
            this.TB_Vup_Center_X.Text = "0.00";
            this.TB_Vup_Center_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Vup_Calibration
            // 
            this.Btn_Vup_Calibration.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Vup_Calibration.Location = new System.Drawing.Point(233, 16);
            this.Btn_Vup_Calibration.Name = "Btn_Vup_Calibration";
            this.Btn_Vup_Calibration.Size = new System.Drawing.Size(150, 30);
            this.Btn_Vup_Calibration.TabIndex = 0;
            this.Btn_Vup_Calibration.Text = "VB+校正启动";
            this.Btn_Vup_Calibration.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.Txt_StandardPressure);
            this.GroupBox1.Controls.Add(this.Btn_AutoLoadcell);
            this.GroupBox1.Controls.Add(this.Txt_InstallPressure);
            this.GroupBox1.Controls.Add(this.Label74);
            this.GroupBox1.Controls.Add(this.Label73);
            this.GroupBox1.Location = new System.Drawing.Point(809, 229);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(116, 145);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Visible = false;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button3.Location = new System.Drawing.Point(13, 109);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(92, 30);
            this.Button3.TabIndex = 84;
            this.Button3.Text = "压力数据";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button1.Location = new System.Drawing.Point(181, 85);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(87, 30);
            this.Button1.TabIndex = 83;
            this.Button1.Text = "压力验证";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Txt_StandardPressure
            // 
            this.Txt_StandardPressure.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_StandardPressure.Location = new System.Drawing.Point(258, 44);
            this.Txt_StandardPressure.Name = "Txt_StandardPressure";
            this.Txt_StandardPressure.Size = new System.Drawing.Size(60, 23);
            this.Txt_StandardPressure.TabIndex = 82;
            this.Txt_StandardPressure.Text = "0";
            this.Txt_StandardPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_AutoLoadcell
            // 
            this.Btn_AutoLoadcell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_AutoLoadcell.Location = new System.Drawing.Point(13, 19);
            this.Btn_AutoLoadcell.Name = "Btn_AutoLoadcell";
            this.Btn_AutoLoadcell.Size = new System.Drawing.Size(109, 75);
            this.Btn_AutoLoadcell.TabIndex = 43;
            this.Btn_AutoLoadcell.Text = "压力自动标定";
            this.Btn_AutoLoadcell.UseVisualStyleBackColor = true;
            // 
            // Txt_InstallPressure
            // 
            this.Txt_InstallPressure.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_InstallPressure.Location = new System.Drawing.Point(258, 19);
            this.Txt_InstallPressure.Name = "Txt_InstallPressure";
            this.Txt_InstallPressure.Size = new System.Drawing.Size(60, 23);
            this.Txt_InstallPressure.TabIndex = 81;
            this.Txt_InstallPressure.Text = "0";
            this.Txt_InstallPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label74
            // 
            this.Label74.AutoSize = true;
            this.Label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label74.Location = new System.Drawing.Point(186, 47);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(67, 15);
            this.Label74.TabIndex = 80;
            this.Label74.Text = "标准压力：";
            // 
            // Label73
            // 
            this.Label73.AutoSize = true;
            this.Label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label73.Location = new System.Drawing.Point(186, 22);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(67, 15);
            this.Label73.TabIndex = 79;
            this.Label73.Text = "贴合压力：";
            // 
            // Panel17
            // 
            this.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel17.Controls.Add(this.Btn_CaliSave);
            this.Panel17.Controls.Add(this.Btn_Ckeck);
            this.Panel17.Controls.Add(this.Text_CkcekAngle);
            this.Panel17.Controls.Add(this.Label20);
            this.Panel17.Controls.Add(this.Text_CaliY);
            this.Panel17.Controls.Add(this.Label21);
            this.Panel17.Controls.Add(this.Label22);
            this.Panel17.Controls.Add(this.Text_CaliX);
            this.Panel17.Controls.Add(this.Btn_StartCorrection);
            this.Panel17.Location = new System.Drawing.Point(639, 242);
            this.Panel17.Name = "Panel17";
            this.Panel17.Size = new System.Drawing.Size(107, 150);
            this.Panel17.TabIndex = 9;
            this.Panel17.Visible = false;
            // 
            // Btn_CaliSave
            // 
            this.Btn_CaliSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_CaliSave.Location = new System.Drawing.Point(234, 116);
            this.Btn_CaliSave.Name = "Btn_CaliSave";
            this.Btn_CaliSave.Size = new System.Drawing.Size(150, 30);
            this.Btn_CaliSave.TabIndex = 9;
            this.Btn_CaliSave.Text = "保存";
            this.Btn_CaliSave.UseVisualStyleBackColor = true;
            // 
            // Btn_Ckeck
            // 
            this.Btn_Ckeck.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Ckeck.Location = new System.Drawing.Point(233, 70);
            this.Btn_Ckeck.Name = "Btn_Ckeck";
            this.Btn_Ckeck.Size = new System.Drawing.Size(150, 30);
            this.Btn_Ckeck.TabIndex = 8;
            this.Btn_Ckeck.Text = "验证";
            this.Btn_Ckeck.UseVisualStyleBackColor = true;
            // 
            // Text_CkcekAngle
            // 
            this.Text_CkcekAngle.BackColor = System.Drawing.Color.White;
            this.Text_CkcekAngle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_CkcekAngle.Location = new System.Drawing.Point(56, 120);
            this.Text_CkcekAngle.Name = "Text_CkcekAngle";
            this.Text_CkcekAngle.Size = new System.Drawing.Size(147, 26);
            this.Text_CkcekAngle.TabIndex = 7;
            this.Text_CkcekAngle.Text = "3";
            this.Text_CkcekAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label20.Location = new System.Drawing.Point(20, 96);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(107, 20);
            this.Label20.TabIndex = 6;
            this.Label20.Text = "验证旋转角度：";
            // 
            // Text_CaliY
            // 
            this.Text_CaliY.BackColor = System.Drawing.Color.White;
            this.Text_CaliY.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_CaliY.Location = new System.Drawing.Point(56, 70);
            this.Text_CaliY.Name = "Text_CaliY";
            this.Text_CaliY.Size = new System.Drawing.Size(147, 26);
            this.Text_CaliY.TabIndex = 5;
            this.Text_CaliY.Text = "0.00";
            this.Text_CaliY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label21.Location = new System.Drawing.Point(20, 48);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(87, 20);
            this.Label21.TabIndex = 3;
            this.Label21.Text = "旋转中心Y：";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label22.Location = new System.Drawing.Point(20, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(88, 20);
            this.Label22.TabIndex = 2;
            this.Label22.Text = "旋转中心X：";
            // 
            // Text_CaliX
            // 
            this.Text_CaliX.BackColor = System.Drawing.Color.White;
            this.Text_CaliX.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_CaliX.Location = new System.Drawing.Point(56, 20);
            this.Text_CaliX.Name = "Text_CaliX";
            this.Text_CaliX.Size = new System.Drawing.Size(147, 26);
            this.Text_CaliX.TabIndex = 1;
            this.Text_CaliX.Text = "0.00";
            this.Text_CaliX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_StartCorrection
            // 
            this.Btn_StartCorrection.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_StartCorrection.Location = new System.Drawing.Point(233, 16);
            this.Btn_StartCorrection.Name = "Btn_StartCorrection";
            this.Btn_StartCorrection.Size = new System.Drawing.Size(150, 30);
            this.Btn_StartCorrection.TabIndex = 0;
            this.Btn_StartCorrection.Text = "校正启动";
            this.Btn_StartCorrection.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Btn_SaveCamDist);
            this.GroupBox2.Controls.Add(this.Txt_CamDistY);
            this.GroupBox2.Controls.Add(this.Label23);
            this.GroupBox2.Controls.Add(this.Label24);
            this.GroupBox2.Controls.Add(this.Txt_CamDistX);
            this.GroupBox2.Location = new System.Drawing.Point(695, 50);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(196, 160);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "下相机中心距";
            this.GroupBox2.Visible = false;
            // 
            // Btn_SaveCamDist
            // 
            this.Btn_SaveCamDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveCamDist.Location = new System.Drawing.Point(114, 131);
            this.Btn_SaveCamDist.Name = "Btn_SaveCamDist";
            this.Btn_SaveCamDist.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveCamDist.TabIndex = 11;
            this.Btn_SaveCamDist.Text = "保存";
            this.Btn_SaveCamDist.UseVisualStyleBackColor = true;
            // 
            // Txt_CamDistY
            // 
            this.Txt_CamDistY.BackColor = System.Drawing.Color.White;
            this.Txt_CamDistY.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_CamDistY.Location = new System.Drawing.Point(42, 93);
            this.Txt_CamDistY.Name = "Txt_CamDistY";
            this.Txt_CamDistY.Size = new System.Drawing.Size(147, 26);
            this.Txt_CamDistY.TabIndex = 9;
            this.Txt_CamDistY.Text = "0.00";
            this.Txt_CamDistY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label23.Location = new System.Drawing.Point(6, 71);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(87, 20);
            this.Label23.TabIndex = 8;
            this.Label23.Text = "中心间距Y：";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label24.Location = new System.Drawing.Point(6, 23);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(88, 20);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "中心间距X：";
            // 
            // Txt_CamDistX
            // 
            this.Txt_CamDistX.BackColor = System.Drawing.Color.White;
            this.Txt_CamDistX.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_CamDistX.Location = new System.Drawing.Point(42, 43);
            this.Txt_CamDistX.Name = "Txt_CamDistX";
            this.Txt_CamDistX.Size = new System.Drawing.Size(147, 26);
            this.Txt_CamDistX.TabIndex = 6;
            this.Txt_CamDistX.Text = "0.00";
            this.Txt_CamDistX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabPage_Super
            // 
            this.TabPage_Super.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage_Super.Controls.Add(this.Button62);
            this.TabPage_Super.Controls.Add(this.Button61);
            this.TabPage_Super.Controls.Add(this.DataGridView_par);
            this.TabPage_Super.Controls.Add(this.UserManagement);
            this.TabPage_Super.Controls.Add(this.Btn_ParLogin);
            this.TabPage_Super.Location = new System.Drawing.Point(4, 29);
            this.TabPage_Super.Name = "TabPage_Super";
            this.TabPage_Super.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Super.Size = new System.Drawing.Size(999, 567);
            this.TabPage_Super.TabIndex = 2;
            this.TabPage_Super.Text = " Super admin ";
            // 
            // Button62
            // 
            this.Button62.BackColor = System.Drawing.Color.SpringGreen;
            this.Button62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button62.Location = new System.Drawing.Point(657, 17);
            this.Button62.Name = "Button62";
            this.Button62.Size = new System.Drawing.Size(80, 41);
            this.Button62.TabIndex = 13;
            this.Button62.Text = "修改";
            this.Button62.UseVisualStyleBackColor = false;
            this.Button62.Click += new System.EventHandler(this.Button62_Click);
            // 
            // Button61
            // 
            this.Button61.BackColor = System.Drawing.Color.SpringGreen;
            this.Button61.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button61.Location = new System.Drawing.Point(657, 71);
            this.Button61.Name = "Button61";
            this.Button61.Size = new System.Drawing.Size(80, 41);
            this.Button61.TabIndex = 12;
            this.Button61.Text = "保存";
            this.Button61.UseVisualStyleBackColor = false;
            this.Button61.Click += new System.EventHandler(this.Button61_Click);
            // 
            // DataGridView_par
            // 
            this.DataGridView_par.AllowUserToAddRows = false;
            this.DataGridView_par.AllowUserToDeleteRows = false;
            this.DataGridView_par.AllowUserToResizeColumns = false;
            this.DataGridView_par.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView_par.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_par.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_par.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView_par.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView_par.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_par.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28});
            this.DataGridView_par.GridColor = System.Drawing.Color.DarkOrange;
            this.DataGridView_par.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_par.MultiSelect = false;
            this.DataGridView_par.Name = "DataGridView_par";
            this.DataGridView_par.ReadOnly = true;
            this.DataGridView_par.RowHeadersWidth = 4;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView_par.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_par.RowTemplate.Height = 23;
            this.DataGridView_par.Size = new System.Drawing.Size(584, 520);
            this.DataGridView_par.TabIndex = 10;
            // 
            // Column24
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Column24.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column24.HeaderText = "轴号名称";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column24.Width = 150;
            // 
            // Column25
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column25.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column25.HeaderText = "丝杆导程";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column26
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column26.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column26.HeaderText = "减速比";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column27
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column27.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column27.HeaderText = "每转脉冲数";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column27.Width = 120;
            // 
            // Column28
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column28.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column28.HeaderText = "轴速度";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            // 
            // UserManagement
            // 
            this.UserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagement.Location = new System.Drawing.Point(809, 492);
            this.UserManagement.Name = "UserManagement";
            this.UserManagement.Size = new System.Drawing.Size(104, 60);
            this.UserManagement.TabIndex = 8;
            this.UserManagement.Text = "用户管理";
            this.UserManagement.UseVisualStyleBackColor = true;
            this.UserManagement.Click += new System.EventHandler(this.UserManagement_Click);
            // 
            // Btn_ParLogin
            // 
            this.Btn_ParLogin.BackColor = System.Drawing.Color.SpringGreen;
            this.Btn_ParLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ParLogin.Location = new System.Drawing.Point(664, 492);
            this.Btn_ParLogin.Name = "Btn_ParLogin";
            this.Btn_ParLogin.Size = new System.Drawing.Size(104, 60);
            this.Btn_ParLogin.TabIndex = 7;
            this.Btn_ParLogin.Text = "解锁";
            this.Btn_ParLogin.UseVisualStyleBackColor = false;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage3.Controls.Add(this.TabControl3);
            this.TabPage3.Location = new System.Drawing.Point(4, 39);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1008, 608);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "  I/O OutPut Page";
            // 
            // TabControl3
            // 
            this.TabControl3.Controls.Add(this.TabPage7);
            this.TabControl3.Enabled = false;
            this.TabControl3.Location = new System.Drawing.Point(5, 3);
            this.TabControl3.Name = "TabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(1000, 600);
            this.TabControl3.TabIndex = 1;
            // 
            // TabPage7
            // 
            this.TabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage7.Controls.Add(this.OutputClass3);
            this.TabPage7.Controls.Add(this.OutputClass2);
            this.TabPage7.Controls.Add(this.OutputClass1);
            this.TabPage7.Location = new System.Drawing.Point(4, 26);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage7.Size = new System.Drawing.Size(992, 570);
            this.TabPage7.TabIndex = 0;
            this.TabPage7.Text = "General Output ";
            // 
            // OutputClass3
            // 
            this.OutputClass3.Location = new System.Drawing.Point(660, 5);
            this.OutputClass3.Name = "OutputClass3";
            this.OutputClass3.Size = new System.Drawing.Size(329, 538);
            this.OutputClass3.TabIndex = 2;
            this.OutputClass3.Tag = "2";
            // 
            // OutputClass2
            // 
            this.OutputClass2.Location = new System.Drawing.Point(329, 5);
            this.OutputClass2.Name = "OutputClass2";
            this.OutputClass2.Size = new System.Drawing.Size(330, 538);
            this.OutputClass2.TabIndex = 1;
            this.OutputClass2.Tag = "1";
            // 
            // OutputClass1
            // 
            this.OutputClass1.Location = new System.Drawing.Point(-2, 5);
            this.OutputClass1.Name = "OutputClass1";
            this.OutputClass1.Size = new System.Drawing.Size(330, 538);
            this.OutputClass1.TabIndex = 0;
            this.OutputClass1.Tag = "0";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage2.Controls.Add(this.TabControl2);
            this.TabPage2.Location = new System.Drawing.Point(4, 39);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1008, 608);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "  I/O InPut Page   ";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage5);
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl2.Location = new System.Drawing.Point(5, 3);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1000, 600);
            this.TabControl2.TabIndex = 0;
            this.TabControl2.SelectedIndexChanged += new System.EventHandler(this.TabControl2_SelectedIndexChanged);
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage5.Controls.Add(this.InputClass3);
            this.TabPage5.Controls.Add(this.InputClass2);
            this.TabPage5.Controls.Add(this.InputClass1);
            this.TabPage5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage5.Location = new System.Drawing.Point(4, 26);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(992, 570);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "General Input ";
            // 
            // InputClass3
            // 
            this.InputClass3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass3.Location = new System.Drawing.Point(677, 5);
            this.InputClass3.Name = "InputClass3";
            this.InputClass3.Size = new System.Drawing.Size(308, 538);
            this.InputClass3.TabIndex = 2;
            this.InputClass3.Tag = "2";
            // 
            // InputClass2
            // 
            this.InputClass2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass2.Location = new System.Drawing.Point(340, 5);
            this.InputClass2.Name = "InputClass2";
            this.InputClass2.Size = new System.Drawing.Size(308, 538);
            this.InputClass2.TabIndex = 1;
            this.InputClass2.Tag = "1";
            // 
            // InputClass1
            // 
            this.InputClass1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass1.Location = new System.Drawing.Point(3, 5);
            this.InputClass1.Name = "InputClass1";
            this.InputClass1.Size = new System.Drawing.Size(308, 538);
            this.InputClass1.TabIndex = 0;
            this.InputClass1.Tag = "0";
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage6.Controls.Add(this.MotorStatus3);
            this.TabPage6.Controls.Add(this.MotorStatus2);
            this.TabPage6.Controls.Add(this.MotorStatus1);
            this.TabPage6.Location = new System.Drawing.Point(4, 26);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(992, 570);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = " Special Input ";
            // 
            // MotorStatus3
            // 
            this.MotorStatus3.BackColor = System.Drawing.Color.White;
            this.MotorStatus3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorStatus3.Location = new System.Drawing.Point(7, 337);
            this.MotorStatus3.Margin = new System.Windows.Forms.Padding(4);
            this.MotorStatus3.Name = "MotorStatus3";
            this.MotorStatus3.Size = new System.Drawing.Size(421, 157);
            this.MotorStatus3.TabIndex = 2;
            this.MotorStatus3.Tag = "2(1,1)(1,2)(1,3)(1,4)";
            // 
            // MotorStatus2
            // 
            this.MotorStatus2.BackColor = System.Drawing.Color.White;
            this.MotorStatus2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorStatus2.Location = new System.Drawing.Point(7, 172);
            this.MotorStatus2.Margin = new System.Windows.Forms.Padding(4);
            this.MotorStatus2.Name = "MotorStatus2";
            this.MotorStatus2.Size = new System.Drawing.Size(421, 157);
            this.MotorStatus2.TabIndex = 1;
            this.MotorStatus2.Tag = "1(0,5)(0,6)(0,7)(0,8)";
            // 
            // MotorStatus1
            // 
            this.MotorStatus1.BackColor = System.Drawing.Color.White;
            this.MotorStatus1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorStatus1.Location = new System.Drawing.Point(7, 7);
            this.MotorStatus1.Margin = new System.Windows.Forms.Padding(4);
            this.MotorStatus1.Name = "MotorStatus1";
            this.MotorStatus1.Size = new System.Drawing.Size(421, 157);
            this.MotorStatus1.TabIndex = 0;
            this.MotorStatus1.Tag = "0(0,1)(0,2)(0,3)(0,4)";
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage1.Controls.Add(this.button5);
            this.TabPage1.Controls.Add(this.Label_StepL5);
            this.TabPage1.Controls.Add(this.Label_CPK);
            this.TabPage1.Controls.Add(this.button2);
            this.TabPage1.Controls.Add(this.Lab_Home);
            this.TabPage1.Controls.Add(this.Label_WorkMode);
            this.TabPage1.Controls.Add(this.SplitList_LB);
            this.TabPage1.Controls.Add(this.Panel9);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.Label_NG_OK);
            this.TabPage1.Controls.Add(this.Label47);
            this.TabPage1.Controls.Add(this.Panel6);
            this.TabPage1.Controls.Add(this.DataGrid_CheckData);
            this.TabPage1.Location = new System.Drawing.Point(4, 39);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1008, 608);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Engineer Main Page";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(177, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "换料";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Label_StepL5
            // 
            this.Label_StepL5.AutoSize = true;
            this.Label_StepL5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label_StepL5.Location = new System.Drawing.Point(82, 332);
            this.Label_StepL5.Name = "Label_StepL5";
            this.Label_StepL5.Size = new System.Drawing.Size(16, 17);
            this.Label_StepL5.TabIndex = 88;
            this.Label_StepL5.Text = "0";
            this.Label_StepL5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_CPK
            // 
            this.Label_CPK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_CPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPK.ForeColor = System.Drawing.Color.Orange;
            this.Label_CPK.Location = new System.Drawing.Point(818, 21);
            this.Label_CPK.Name = "Label_CPK";
            this.Label_CPK.Size = new System.Drawing.Size(158, 33);
            this.Label_CPK.TabIndex = 83;
            this.Label_CPK.Text = "CPK：32/32";
            this.Label_CPK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CPK.Visible = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(32, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "上料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Lab_Home
            // 
            this.Lab_Home.AutoSize = true;
            this.Lab_Home.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Lab_Home.Location = new System.Drawing.Point(20, 330);
            this.Lab_Home.Name = "Lab_Home";
            this.Lab_Home.Size = new System.Drawing.Size(16, 17);
            this.Lab_Home.TabIndex = 81;
            this.Lab_Home.Text = "0";
            this.Lab_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_WorkMode
            // 
            this.Label_WorkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_WorkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_WorkMode.ForeColor = System.Drawing.Color.Yellow;
            this.Label_WorkMode.Location = new System.Drawing.Point(819, 111);
            this.Label_WorkMode.Name = "Label_WorkMode";
            this.Label_WorkMode.Size = new System.Drawing.Size(158, 33);
            this.Label_WorkMode.TabIndex = 72;
            this.Label_WorkMode.Text = "Dome Mode";
            this.Label_WorkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplitList_LB
            // 
            this.SplitList_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitList_LB.Controls.Add(this.infoList1);
            this.SplitList_LB.Controls.Add(this.PictureBox25);
            this.SplitList_LB.Location = new System.Drawing.Point(3, 3);
            this.SplitList_LB.Name = "SplitList_LB";
            this.SplitList_LB.Size = new System.Drawing.Size(259, 323);
            this.SplitList_LB.TabIndex = 74;
            // 
            // infoList1
            // 
            this.infoList1.AutoSize = true;
            this.infoList1.Location = new System.Drawing.Point(3, 40);
            this.infoList1.Margin = new System.Windows.Forms.Padding(4);
            this.infoList1.Name = "infoList1";
            this.infoList1.Size = new System.Drawing.Size(250, 282);
            this.infoList1.TabIndex = 89;
            // 
            // PictureBox25
            // 
            this.PictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox25.Image")));
            this.PictureBox25.Location = new System.Drawing.Point(3, 1);
            this.PictureBox25.Name = "PictureBox25";
            this.PictureBox25.Size = new System.Drawing.Size(252, 41);
            this.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox25.TabIndex = 82;
            this.PictureBox25.TabStop = false;
            // 
            // Panel9
            // 
            this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel9.Controls.Add(this.Lab_LightContor_Sts);
            this.Panel9.Controls.Add(this.Lab_SafeLight_Sts);
            this.Panel9.Controls.Add(this.Lab_Safe_Sts);
            this.Panel9.Controls.Add(this.Lab_EMG_Sts);
            this.Panel9.Controls.Add(this.Lab_CCD1_Sts);
            this.Panel9.Controls.Add(this.Lab_LC2_Sts);
            this.Panel9.Controls.Add(this.Lab_LC1_Sts);
            this.Panel9.Controls.Add(this.Lab_Air_Sts);
            this.Panel9.Controls.Add(this.Lab_CCD2_Sts);
            this.Panel9.Location = new System.Drawing.Point(794, 154);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(211, 172);
            this.Panel9.TabIndex = 61;
            // 
            // Lab_LightContor_Sts
            // 
            this.Lab_LightContor_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_LightContor_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_LightContor_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_LightContor_Sts.Location = new System.Drawing.Point(13, 139);
            this.Lab_LightContor_Sts.Name = "Lab_LightContor_Sts";
            this.Lab_LightContor_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_LightContor_Sts.TabIndex = 85;
            this.Lab_LightContor_Sts.Text = "光源通信";
            this.Lab_LightContor_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_SafeLight_Sts
            // 
            this.Lab_SafeLight_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_SafeLight_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_SafeLight_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_SafeLight_Sts.Location = new System.Drawing.Point(117, 105);
            this.Lab_SafeLight_Sts.Name = "Lab_SafeLight_Sts";
            this.Lab_SafeLight_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_SafeLight_Sts.TabIndex = 84;
            this.Lab_SafeLight_Sts.Text = "光 幕";
            this.Lab_SafeLight_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Safe_Sts
            // 
            this.Lab_Safe_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_Safe_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Safe_Sts.Location = new System.Drawing.Point(117, 3);
            this.Lab_Safe_Sts.Name = "Lab_Safe_Sts";
            this.Lab_Safe_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_Safe_Sts.TabIndex = 75;
            this.Lab_Safe_Sts.Text = "安全门";
            this.Lab_Safe_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_EMG_Sts
            // 
            this.Lab_EMG_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_EMG_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_EMG_Sts.Location = new System.Drawing.Point(13, 3);
            this.Lab_EMG_Sts.Name = "Lab_EMG_Sts";
            this.Lab_EMG_Sts.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Lab_EMG_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_EMG_Sts.TabIndex = 74;
            this.Lab_EMG_Sts.Text = "    急  停";
            this.Lab_EMG_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_CCD1_Sts
            // 
            this.Lab_CCD1_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_CCD1_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_CCD1_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_CCD1_Sts.Location = new System.Drawing.Point(13, 71);
            this.Lab_CCD1_Sts.Name = "Lab_CCD1_Sts";
            this.Lab_CCD1_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_CCD1_Sts.TabIndex = 83;
            this.Lab_CCD1_Sts.Text = "CCD1通信";
            this.Lab_CCD1_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_LC2_Sts
            // 
            this.Lab_LC2_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_LC2_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_LC2_Sts.Location = new System.Drawing.Point(117, 37);
            this.Lab_LC2_Sts.Name = "Lab_LC2_Sts";
            this.Lab_LC2_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_LC2_Sts.TabIndex = 77;
            this.Lab_LC2_Sts.Text = "保压串口";
            this.Lab_LC2_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_LC1_Sts
            // 
            this.Lab_LC1_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_LC1_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_LC1_Sts.Location = new System.Drawing.Point(13, 37);
            this.Lab_LC1_Sts.Name = "Lab_LC1_Sts";
            this.Lab_LC1_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_LC1_Sts.TabIndex = 76;
            this.Lab_LC1_Sts.Text = "装配串口";
            this.Lab_LC1_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Air_Sts
            // 
            this.Lab_Air_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_Air_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Air_Sts.Location = new System.Drawing.Point(13, 105);
            this.Lab_Air_Sts.Name = "Lab_Air_Sts";
            this.Lab_Air_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_Air_Sts.TabIndex = 71;
            this.Lab_Air_Sts.Text = "正气源状态";
            this.Lab_Air_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_CCD2_Sts
            // 
            this.Lab_CCD2_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_CCD2_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_CCD2_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_CCD2_Sts.Location = new System.Drawing.Point(117, 71);
            this.Lab_CCD2_Sts.Name = "Lab_CCD2_Sts";
            this.Lab_CCD2_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_CCD2_Sts.TabIndex = 70;
            this.Lab_CCD2_Sts.Text = "CCD2通信";
            this.Lab_CCD2_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.Btn_SelectMaterial);
            this.GroupBox9.Controls.Add(this.Text_BlogoNo);
            this.GroupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox9.ForeColor = System.Drawing.Color.Black;
            this.GroupBox9.Location = new System.Drawing.Point(32, 515);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(205, 72);
            this.GroupBox9.TabIndex = 103;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "B-logo";
            // 
            // Btn_SelectMaterial
            // 
            this.Btn_SelectMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectMaterial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SelectMaterial.Location = new System.Drawing.Point(100, 26);
            this.Btn_SelectMaterial.Name = "Btn_SelectMaterial";
            this.Btn_SelectMaterial.Size = new System.Drawing.Size(76, 26);
            this.Btn_SelectMaterial.TabIndex = 3;
            this.Btn_SelectMaterial.Text = "选择物料";
            this.Btn_SelectMaterial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_SelectMaterial.UseVisualStyleBackColor = true;
            this.Btn_SelectMaterial.Click += new System.EventHandler(this.Btn_SelectMaterial_Click);
            // 
            // Text_BlogoNo
            // 
            this.Text_BlogoNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Text_BlogoNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_BlogoNo.ForeColor = System.Drawing.Color.Blue;
            this.Text_BlogoNo.Location = new System.Drawing.Point(19, 26);
            this.Text_BlogoNo.Name = "Text_BlogoNo";
            this.Text_BlogoNo.ReadOnly = true;
            this.Text_BlogoNo.Size = new System.Drawing.Size(47, 26);
            this.Text_BlogoNo.TabIndex = 1;
            this.Text_BlogoNo.Text = "1";
            this.Text_BlogoNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_NG_OK
            // 
            this.Label_NG_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_NG_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NG_OK.Location = new System.Drawing.Point(829, 42);
            this.Label_NG_OK.Name = "Label_NG_OK";
            this.Label_NG_OK.Size = new System.Drawing.Size(139, 64);
            this.Label_NG_OK.TabIndex = 70;
            this.Label_NG_OK.Text = "OK";
            this.Label_NG_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label47
            // 
            this.Label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label47.Location = new System.Drawing.Point(794, 3);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(211, 147);
            this.Label47.TabIndex = 67;
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.GroupBox4);
            this.Panel6.Controls.Add(this.Chk_StaRound);
            this.Panel6.Controls.Add(this.Label_Sta2);
            this.Panel6.Controls.Add(this.Label_Sta3);
            this.Panel6.Controls.Add(this.Label_Sta4);
            this.Panel6.Controls.Add(this.Label_Sta1);
            this.Panel6.Controls.Add(this.GroupBox8);
            this.Panel6.Controls.Add(this.shapeContainer1);
            this.Panel6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel6.Location = new System.Drawing.Point(265, 3);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(527, 323);
            this.Panel6.TabIndex = 74;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.PressS2_Text);
            this.GroupBox4.Controls.Add(this.PressS3_Text);
            this.GroupBox4.Controls.Add(this.Label44);
            this.GroupBox4.Controls.Add(this.Label43);
            this.GroupBox4.Controls.Add(this.Label34);
            this.GroupBox4.Controls.Add(this.Press_Display0);
            this.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.GroupBox4.Location = new System.Drawing.Point(3, 3);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(159, 81);
            this.GroupBox4.TabIndex = 101;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "压力值";
            // 
            // PressS2_Text
            // 
            this.PressS2_Text.BackColor = System.Drawing.Color.Black;
            this.PressS2_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PressS2_Text.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold);
            this.PressS2_Text.ForeColor = System.Drawing.Color.Lime;
            this.PressS2_Text.Location = new System.Drawing.Point(87, 19);
            this.PressS2_Text.Name = "PressS2_Text";
            this.PressS2_Text.Size = new System.Drawing.Size(42, 19);
            this.PressS2_Text.TabIndex = 91;
            this.PressS2_Text.Text = "0.00  ";
            this.PressS2_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressS3_Text
            // 
            this.PressS3_Text.BackColor = System.Drawing.Color.Black;
            this.PressS3_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PressS3_Text.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold);
            this.PressS3_Text.ForeColor = System.Drawing.Color.Lime;
            this.PressS3_Text.Location = new System.Drawing.Point(87, 55);
            this.PressS3_Text.Name = "PressS3_Text";
            this.PressS3_Text.Size = new System.Drawing.Size(42, 19);
            this.PressS3_Text.TabIndex = 75;
            this.PressS3_Text.Text = "0.00  ";
            this.PressS3_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.Location = new System.Drawing.Point(131, 56);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(23, 17);
            this.Label44.TabIndex = 93;
            this.Label44.Text = "kg";
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.Location = new System.Drawing.Point(131, 19);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(23, 17);
            this.Label43.TabIndex = 92;
            this.Label43.Text = "kg";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.Location = new System.Drawing.Point(6, 19);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(70, 15);
            this.Label34.TabIndex = 88;
            this.Label34.Text = "组装压力值:";
            // 
            // Press_Display0
            // 
            this.Press_Display0.AutoSize = true;
            this.Press_Display0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Press_Display0.Location = new System.Drawing.Point(6, 55);
            this.Press_Display0.Name = "Press_Display0";
            this.Press_Display0.Size = new System.Drawing.Size(70, 15);
            this.Press_Display0.TabIndex = 69;
            this.Press_Display0.Text = "保压压力值:";
            // 
            // Chk_StaRound
            // 
            this.Chk_StaRound.AutoSize = true;
            this.Chk_StaRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Chk_StaRound.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Chk_StaRound.Checked = true;
            this.Chk_StaRound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_StaRound.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Chk_StaRound.ForeColor = System.Drawing.Color.Black;
            this.Chk_StaRound.Location = new System.Drawing.Point(231, 135);
            this.Chk_StaRound.Name = "Chk_StaRound";
            this.Chk_StaRound.Size = new System.Drawing.Size(39, 32);
            this.Chk_StaRound.TabIndex = 109;
            this.Chk_StaRound.Text = "转盘";
            this.Chk_StaRound.UseVisualStyleBackColor = false;
            // 
            // Label_Sta2
            // 
            this.Label_Sta2.AutoSize = true;
            this.Label_Sta2.BackColor = System.Drawing.Color.White;
            this.Label_Sta2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Sta2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Sta2.Location = new System.Drawing.Point(166, 136);
            this.Label_Sta2.Name = "Label_Sta2";
            this.Label_Sta2.Size = new System.Drawing.Size(29, 29);
            this.Label_Sta2.TabIndex = 108;
            this.Label_Sta2.Text = "4";
            // 
            // Label_Sta3
            // 
            this.Label_Sta3.AutoSize = true;
            this.Label_Sta3.BackColor = System.Drawing.Color.White;
            this.Label_Sta3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Sta3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Sta3.Location = new System.Drawing.Point(236, 66);
            this.Label_Sta3.Name = "Label_Sta3";
            this.Label_Sta3.Size = new System.Drawing.Size(29, 29);
            this.Label_Sta3.TabIndex = 107;
            this.Label_Sta3.Text = "3";
            // 
            // Label_Sta4
            // 
            this.Label_Sta4.AutoSize = true;
            this.Label_Sta4.BackColor = System.Drawing.Color.White;
            this.Label_Sta4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Sta4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Sta4.Location = new System.Drawing.Point(305, 136);
            this.Label_Sta4.Name = "Label_Sta4";
            this.Label_Sta4.Size = new System.Drawing.Size(29, 29);
            this.Label_Sta4.TabIndex = 106;
            this.Label_Sta4.Text = "2";
            // 
            // Label_Sta1
            // 
            this.Label_Sta1.AutoSize = true;
            this.Label_Sta1.BackColor = System.Drawing.Color.White;
            this.Label_Sta1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Sta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Sta1.Location = new System.Drawing.Point(236, 206);
            this.Label_Sta1.Name = "Label_Sta1";
            this.Label_Sta1.Size = new System.Drawing.Size(29, 29);
            this.Label_Sta1.TabIndex = 105;
            this.Label_Sta1.Text = "1";
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.Label16);
            this.GroupBox8.Controls.Add(this.Label5);
            this.GroupBox8.Controls.Add(this.Product_Num);
            this.GroupBox8.Controls.Add(this.Label134);
            this.GroupBox8.Controls.Add(this.Cycle);
            this.GroupBox8.Controls.Add(this.Label32);
            this.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox8.ForeColor = System.Drawing.Color.Black;
            this.GroupBox8.Location = new System.Drawing.Point(350, 6);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(169, 78);
            this.GroupBox8.TabIndex = 92;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "生产信息";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(9, 52);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(53, 17);
            this.Label16.TabIndex = 90;
            this.Label16.Text = "Count :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(32, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(30, 17);
            this.Label5.TabIndex = 89;
            this.Label5.Text = "CT:";
            // 
            // Product_Num
            // 
            this.Product_Num.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Product_Num.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Product_Num.ForeColor = System.Drawing.Color.Blue;
            this.Product_Num.Location = new System.Drawing.Point(68, 47);
            this.Product_Num.Name = "Product_Num";
            this.Product_Num.ReadOnly = true;
            this.Product_Num.Size = new System.Drawing.Size(64, 26);
            this.Product_Num.TabIndex = 1;
            this.Product_Num.Text = "9999";
            this.Product_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label134
            // 
            this.Label134.AutoSize = true;
            this.Label134.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label134.ForeColor = System.Drawing.Color.Black;
            this.Label134.Location = new System.Drawing.Point(134, 49);
            this.Label134.Name = "Label134";
            this.Label134.Size = new System.Drawing.Size(31, 20);
            this.Label134.TabIndex = 0;
            this.Label134.Text = "pcs";
            // 
            // Cycle
            // 
            this.Cycle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cycle.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.Cycle.ForeColor = System.Drawing.Color.Blue;
            this.Cycle.Location = new System.Drawing.Point(68, 18);
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            this.Cycle.Size = new System.Drawing.Size(64, 26);
            this.Cycle.TabIndex = 1;
            this.Cycle.Text = "0.00";
            this.Cycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label32.ForeColor = System.Drawing.Color.Black;
            this.Label32.Location = new System.Drawing.Point(136, 20);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(17, 20);
            this.Label32.TabIndex = 0;
            this.Label32.Text = "S";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.OvalShape_Sta4,
            this.OvalShape_Sta2,
            this.OvalShape_Sta1,
            this.OvalShape_Sta3,
            this.lineShape2,
            this.lineShape1,
            this.OvalShape_Sta0,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(525, 321);
            this.shapeContainer1.TabIndex = 104;
            this.shapeContainer1.TabStop = false;
            // 
            // OvalShape_Sta4
            // 
            this.OvalShape_Sta4.BackColor = System.Drawing.Color.White;
            this.OvalShape_Sta4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.OvalShape_Sta4.Location = new System.Drawing.Point(155, 125);
            this.OvalShape_Sta4.Name = "OvalShape_Sta4";
            this.OvalShape_Sta4.Size = new System.Drawing.Size(50, 50);
            // 
            // OvalShape_Sta2
            // 
            this.OvalShape_Sta2.BackColor = System.Drawing.Color.White;
            this.OvalShape_Sta2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.OvalShape_Sta2.Location = new System.Drawing.Point(295, 125);
            this.OvalShape_Sta2.Name = "OvalShape_Sta2";
            this.OvalShape_Sta2.Size = new System.Drawing.Size(50, 50);
            // 
            // OvalShape_Sta1
            // 
            this.OvalShape_Sta1.BackColor = System.Drawing.Color.White;
            this.OvalShape_Sta1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.OvalShape_Sta1.Location = new System.Drawing.Point(225, 195);
            this.OvalShape_Sta1.Name = "OvalShape_Sta1";
            this.OvalShape_Sta1.Size = new System.Drawing.Size(50, 50);
            // 
            // OvalShape_Sta3
            // 
            this.OvalShape_Sta3.BackColor = System.Drawing.Color.White;
            this.OvalShape_Sta3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.OvalShape_Sta3.Location = new System.Drawing.Point(225, 55);
            this.OvalShape_Sta3.Name = "OvalShape_Sta3";
            this.OvalShape_Sta3.Size = new System.Drawing.Size(50, 50);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.Visible = false;
            this.lineShape2.X1 = 122;
            this.lineShape2.X2 = 374;
            this.lineShape2.Y1 = 150;
            this.lineShape2.Y2 = 150;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Visible = false;
            this.lineShape1.X1 = 250;
            this.lineShape1.X2 = 250;
            this.lineShape1.Y1 = 267;
            this.lineShape1.Y2 = 37;
            // 
            // OvalShape_Sta0
            // 
            this.OvalShape_Sta0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OvalShape_Sta0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.OvalShape_Sta0.Location = new System.Drawing.Point(223, 123);
            this.OvalShape_Sta0.Name = "OvalShape_Sta0";
            this.OvalShape_Sta0.Size = new System.Drawing.Size(54, 54);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.Location = new System.Drawing.Point(150, 50);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(200, 200);
            // 
            // DataGrid_CheckData
            // 
            this.DataGrid_CheckData.AllowUserToAddRows = false;
            this.DataGrid_CheckData.AllowUserToResizeColumns = false;
            this.DataGrid_CheckData.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGrid_CheckData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid_CheckData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CheckData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGrid_CheckData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_CheckData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.ColTime,
            this.ColProSta,
            this.Column13,
            this.ColCam1CCX,
            this.ColCam1CCY,
            this.Col_CC,
            this.ColCheckA});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_CheckData.DefaultCellStyle = dataGridViewCellStyle16;
            this.DataGrid_CheckData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid_CheckData.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DataGrid_CheckData.Location = new System.Drawing.Point(265, 332);
            this.DataGrid_CheckData.Name = "DataGrid_CheckData";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_CheckData.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGrid_CheckData.RowHeadersVisible = false;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGrid_CheckData.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGrid_CheckData.RowTemplate.Height = 23;
            this.DataGrid_CheckData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_CheckData.Size = new System.Drawing.Size(740, 273);
            this.DataGrid_CheckData.TabIndex = 68;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Date";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 80;
            // 
            // ColTime
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTime.Width = 70;
            // 
            // ColProSta
            // 
            this.ColProSta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColProSta.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColProSta.HeaderText = "OK/NG";
            this.ColProSta.Name = "ColProSta";
            this.ColProSta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColProSta.Width = 59;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "CT";
            this.Column13.Name = "Column13";
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column13.Width = 65;
            // 
            // ColCam1CCX
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColCam1CCX.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColCam1CCX.HeaderText = "Blogo_X";
            this.ColCam1CCX.Name = "ColCam1CCX";
            this.ColCam1CCX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCam1CCY
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColCam1CCY.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColCam1CCY.HeaderText = "Blogo_Y";
            this.ColCam1CCY.Name = "ColCam1CCY";
            this.ColCam1CCY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_CC
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_CC.DefaultCellStyle = dataGridViewCellStyle14;
            this.Col_CC.HeaderText = "Blogo_CC  (0.05)";
            this.Col_CC.Name = "Col_CC";
            this.Col_CC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCheckA
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColCheckA.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColCheckA.HeaderText = "  Blogo_A      (±2)";
            this.ColCheckA.Name = "ColCheckA";
            this.ColCheckA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.ItemSize = new System.Drawing.Size(50, 35);
            this.TabControl1.Location = new System.Drawing.Point(3, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1016, 651);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // Frm_Engineering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Engineering";
            this.ShowInTaskbar = false;
            this.Text = "Frm_Engineering";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Engineering_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Engineering_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Engineering_VisibleChanged);
            this.TabPage4.ResumeLayout(false);
            this.TabControl4.ResumeLayout(false);
            this.TabPage_Review.ResumeLayout(false);
            this.TabPage_Review.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.TabControl6.ResumeLayout(false);
            this.TabPage9.ResumeLayout(false);
            this.TabPage9.PerformLayout();
            this.Panel_S2.ResumeLayout(false);
            this.GroupBox_S2.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel_S2g.ResumeLayout(false);
            this.panel_S2g.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.TabPage13.ResumeLayout(false);
            this.TabPage13.PerformLayout();
            this.TabControl5.ResumeLayout(false);
            this.TabPage14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TabPage_LightControl.ResumeLayout(false);
            this.TabPage_LightControl.PerformLayout();
            this.TabPage15.ResumeLayout(false);
            this.Panel_Calibration.ResumeLayout(false);
            this.Panel_Calibration.PerformLayout();
            this.Panel16.ResumeLayout(false);
            this.Panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox11.ResumeLayout(false);
            this.Panel15.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.Panel_Test.ResumeLayout(false);
            this.Panel_Test.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.PanelCalibration.ResumeLayout(false);
            this.Panel19.ResumeLayout(false);
            this.Panel19.PerformLayout();
            this.Panel_Vup.ResumeLayout(false);
            this.Panel_Vup.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel17.ResumeLayout(false);
            this.Panel17.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabPage_Super.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_par)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabControl3.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.SplitList_LB.ResumeLayout(false);
            this.SplitList_LB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox25)).EndInit();
            this.Panel9.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CheckData)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.TabControl TabControl4;
		internal System.Windows.Forms.TabPage TabPage13;
		internal System.Windows.Forms.TabPage TabPage_Super;
		internal System.Windows.Forms.Button UserManagement;
		internal System.Windows.Forms.Button Btn_ParLogin;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.TabControl TabControl3;
		internal System.Windows.Forms.TabPage TabPage7;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabControl TabControl2;
		internal System.Windows.Forms.TabPage TabPage5;
		internal System.Windows.Forms.TabPage TabPage6;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Label Label_WorkMode;
        internal System.Windows.Forms.Panel Panel9;
		internal System.Windows.Forms.Label Lab_Safe_Sts;
		internal System.Windows.Forms.Label Lab_EMG_Sts;
        internal System.Windows.Forms.Label Lab_LC2_Sts;
        internal System.Windows.Forms.Label Lab_LC1_Sts;
		internal System.Windows.Forms.Label Lab_Air_Sts;
		internal System.Windows.Forms.Label Lab_CCD2_Sts;
		internal System.Windows.Forms.Label Label_NG_OK;
		internal System.Windows.Forms.Label Label47;
        internal System.Windows.Forms.Panel Panel6;
		internal System.Windows.Forms.DataGridView DataGrid_CheckData;
        internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.Label PressS3_Text;
		internal System.Windows.Forms.Label Press_Display0;
        internal System.Windows.Forms.TabPage TabPage_Review;
		internal System.Windows.Forms.TabControl TabControl5;
        internal System.Windows.Forms.TabPage TabPage14;
		internal System.Windows.Forms.TabPage TabPage15;
		internal System.Windows.Forms.Panel Panel_Calibration;
		internal System.Windows.Forms.ListBox List_Info;
		internal System.Windows.Forms.Panel Panel_Vup;
		internal System.Windows.Forms.Button Btn_Vup_Check;
		internal System.Windows.Forms.TextBox TB_Vup_Angel;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.TextBox TB_Vup_Center_Y;
		internal System.Windows.Forms.Label Label29;
		internal System.Windows.Forms.Label Label30;
		internal System.Windows.Forms.TextBox TB_Vup_Center_X;
        internal System.Windows.Forms.Button Btn_Vup_Calibration;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button Btn_AutoLoadcell;
		internal System.Windows.Forms.Button Button_S2_1;
		internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.Label Lab_Home;
		internal System.Windows.Forms.TabPage TabPage_LightControl;
        internal LightControl LightControl1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button Btn_SaveCamDist;
		internal System.Windows.Forms.TextBox Txt_CamDistY;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.TextBox Txt_CamDistX;
		internal System.Windows.Forms.Panel Panel17;
		internal System.Windows.Forms.Button Btn_Ckeck;
		internal System.Windows.Forms.TextBox Text_CkcekAngle;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox Text_CaliY;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.TextBox Text_CaliX;
		internal System.Windows.Forms.Button Btn_StartCorrection;
		internal System.Windows.Forms.Button Btn_PDCATest;
		internal System.Windows.Forms.Button Btn_CaliSave;
		internal System.Windows.Forms.TextBox Txt_MLBBarcode;
		internal System.Windows.Forms.Panel Panel19;
        internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.TextBox Txt_StandardPressure;
		internal System.Windows.Forms.TextBox Txt_InstallPressure;
		internal System.Windows.Forms.Label Label74;
		internal System.Windows.Forms.Label Label73;
		internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel SplitList_LB;
        internal System.Windows.Forms.PictureBox PictureBox25;
		internal System.Windows.Forms.Label PressS2_Text;
        internal System.Windows.Forms.TextBox Product_Num;
        internal System.Windows.Forms.TextBox Cycle;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox Text_BlogoNo;
        internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.GroupBox GroupBox14;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox Text_ForceS2;
        internal System.Windows.Forms.Button Btn_OpenSerialS2;
		internal System.Windows.Forms.DataGridView DataGridView_par;
		internal System.Windows.Forms.Button Button62;
        internal System.Windows.Forms.Button Button61;
		internal System.Windows.Forms.GroupBox GroupBox_S2;
        internal System.Windows.Forms.Button CommandAutoS2;
		internal System.Windows.Forms.Button CmdStopS2;
        internal System.Windows.Forms.Button CmdHoldS2;
		internal System.Windows.Forms.Panel Panel_S2;
		internal System.Windows.Forms.Button CCD_Screen_S2;
		internal System.Windows.Forms.Button CCD_Trigger_S2;
		internal System.Windows.Forms.ComboBox ComboBox_Cam1;
        internal System.Windows.Forms.TextBox TextBox_CCD2;
		internal System.Windows.Forms.Panel PanelCalibration;
		internal System.Windows.Forms.Button Btn_CalibrationList;
		internal System.Windows.Forms.ComboBox ComboBox_CCD;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.Label Label_StepL5;
        internal System.Windows.Forms.Label Label_PDCA_Step;
		internal System.Windows.Forms.Button Button8;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Panel Panel_Test;
		internal System.Windows.Forms.Button Button_Test;
		internal System.Windows.Forms.ComboBox ComboBox2;
		internal System.Windows.Forms.Label Label42;
		internal System.Windows.Forms.TextBox TextBox_Num;
		internal System.Windows.Forms.Label Label_CPK;
		internal System.Windows.Forms.Label Label44;
		internal System.Windows.Forms.Label Label43;
		internal System.Windows.Forms.GroupBox GroupBox11;
		internal System.Windows.Forms.Panel Panel15;
		internal System.Windows.Forms.Button Robot_Biaoding;
		internal System.Windows.Forms.ComboBox ComboBox_Robot;
        internal System.Windows.Forms.TextBox TextBox_CCD1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label48;
		internal System.Windows.Forms.Panel Panel16;
		internal System.Windows.Forms.Button Button_GetTL;
		internal System.Windows.Forms.TextBox TextBox_TLX;
		internal System.Windows.Forms.TextBox TextBox_TLY;
		internal System.Windows.Forms.TextBox TextBox_TLZ;
		internal System.Windows.Forms.TextBox TextBox_TLA;
		internal System.Windows.Forms.TextBox TextBox_TLB;
		internal System.Windows.Forms.TextBox TextBox_TLC;
		internal System.Windows.Forms.Label Label49;
		internal System.Windows.Forms.Label Label50;
		internal System.Windows.Forms.Label Label51;
		internal System.Windows.Forms.Label Label52;
		internal System.Windows.Forms.Label Label53;
		internal System.Windows.Forms.Label Label54;
		internal System.Windows.Forms.ComboBox ComboBox_TL;
		internal System.Windows.Forms.Label Label55;
		internal System.Windows.Forms.TextBox TextBox_Laser;
		internal System.Windows.Forms.Label Label45;
		internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.Button Button_Laser;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column24;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column25;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column26;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column27;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        internal System.Windows.Forms.Label Lab_CCD1_Sts;
        private InfoList infoList1;
        private InfoList infoList2;
        private InputClass InputClass1;
        private InputClass InputClass2;
        private InputClass InputClass3;
        private MotorStatus MotorStatus1;
        private MotorStatus MotorStatus2;
        private MotorStatus MotorStatus3;
        internal Teach Teach1;
        internal TabPage tabPage8;
        internal Teach Teach3;
        internal TabPage tabPage12;
        internal Teach Teach2;
        internal Teach Teach4;
        private GroupBox GroupBox9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        internal Label Label_Sta1;
        internal Label Label_Sta4;
        internal Label Label_Sta3;
        internal Label Label_Sta2;
        internal CheckBox Chk_StaRound;
        private GroupBox GroupBox8;
        private Label Label134;
        private Label Label32;
        private Label Label16;
        private Button button5;
        private Button button2;
        internal Button Btn_SelectMaterial;
        internal Button Button_S2_3;
        internal Button Button_S2_2;
        internal Panel panel_S2g;
        internal Button Button_S2g_7;
        internal Button Button_S2g_11;
        internal Button Button_S2g_10;
        internal Button Button_S2g_9;
        internal Button Button_S2g_1;
        internal Button Button_S2g_4;
        internal Button Button_S2g_2;
        internal Button Button_S2g_3;
        internal Button Button_S2g_8;
        internal Button Button_S2g_6;
        internal Button Button_S2g_5;
        internal Label label2;
        internal TextBox textBox1;
        internal GroupBox groupBox3;
        internal Button button9;
        internal Button button10;
        internal Button button11;
        internal GroupBox groupBox10;
        internal Label label6;
        internal Label label7;
        internal TextBox Text_ForceS3;
        internal Button Btn_OpenSerialS3;
        internal Panel panel4;
        internal Button Button_S3_2;
        internal Button Button_S3_1;
        internal Label label4;
        internal TextBox textBox2;
        internal GroupBox groupBox7;
        internal Button button14;
        internal Button button15;
        internal Button button16;
        internal Panel panel5;
        internal Button Button_S4_8;
        internal Button Button_S4_7;
        internal Button Button_S4_6;
        internal Button Button_S4_5;
        internal Button Button_S4_4;
        internal Button Button_S4_3;
        internal Button Button_S4_9;
        internal Button Button_S4_2;
        internal Button Button_S4_1;
        internal Label label1;
        internal TextBox textBox4;

        //网络定义。  
        internal SocketHelper.TCP.ITcpClient Tcp_Robot = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_CCD1 = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_CCD2 = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_Barcode = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_PDCA = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_HeatBt = new SocketHelper.TCP.ITcpClient();
       
        internal Label Lab_SafeLight_Sts;
        internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_Sta4;
        internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_Sta2;
        internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_Sta1;
        internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_Sta3;
        internal Microsoft.VisualBasic.PowerPacks.OvalShape OvalShape_Sta0;
        internal TabControl TabControl6;
        internal TabPage TabPage9;
        internal CheckBox CheckBox_NeedCCD;
        internal Button BtnM_B_logo;
        internal TextBox TextM_BlogoNo;
        internal Label Label33;
        internal OutputClass OutputClass1;
        internal OutputClass OutputClass2;
        internal OutputClass OutputClass3;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn ColTime;
        private DataGridViewTextBoxColumn ColProSta;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn ColCam1CCX;
        private DataGridViewTextBoxColumn ColCam1CCY;
        private DataGridViewTextBoxColumn Col_CC;
        private DataGridViewTextBoxColumn ColCheckA;
        internal Panel panel2;
        internal Button button6;
        internal Button CCD_Trigger_S4;
        internal ComboBox ComboBox_Cam2;
        internal Label Lab_LightContor_Sts;
        internal GroupBox groupBox12;
        private TextBox textBox_mL;
        private Label label17;
        private TextBox textBox_mA;
        private Label label13;
        private TextBox textBox_mT;
        private Label label14;
        private TextBox textBox_mY;
        private Label label12;
        private TextBox textBox_mX;
        private Label label11;
        private Label label_mT;
        private Label label_mY;
        private Label label_mX;
        internal Button button7;	 
	}
	
}
