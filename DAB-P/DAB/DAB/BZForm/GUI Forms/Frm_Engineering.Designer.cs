
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

namespace DAB
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
        private System.ComponentModel.IContainer components = null;

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
            this.机械手调试 = new System.Windows.Forms.TabPage();
            this.TextBox_CCD = new System.Windows.Forms.TextBox();
            this.TabControl5 = new System.Windows.Forms.TabControl();
            this.手动调试 = new System.Windows.Forms.TabPage();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.Label_Rbt4 = new System.Windows.Forms.Label();
            this.Cmd_MotorON = new System.Windows.Forms.Button();
            this.Cmd_MotorOff = new System.Windows.Forms.Button();
            this.Label_Rbt2 = new System.Windows.Forms.Label();
            this.Label_Rbt3 = new System.Windows.Forms.Label();
            this.Label_Rbt1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_Rbt1 = new System.Windows.Forms.Button();
            this.Btn_Rbt5 = new System.Windows.Forms.Button();
            this.Btn_Rbt4 = new System.Windows.Forms.Button();
            this.Btn_Rbt3 = new System.Windows.Forms.Button();
            this.Btn_Rbt2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.checkBox_Live = new System.Windows.Forms.CheckBox();
            this.Text_Robot_X = new System.Windows.Forms.TextBox();
            this.Text_Robot_Y = new System.Windows.Forms.TextBox();
            this.Text_Robot_Z = new System.Windows.Forms.TextBox();
            this.Text_Robot_U = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.Text_Robot_V = new System.Windows.Forms.TextBox();
            this.MForce_Text = new System.Windows.Forms.TextBox();
            this.Text_Robot_W = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Btn_SelectPalletNum = new System.Windows.Forms.Button();
            this.Txt_PalletSelectNum = new System.Windows.Forms.TextBox();
            this.CmdS2_Save = new System.Windows.Forms.Button();
            this.TrackBar2 = new System.Windows.Forms.TrackBar();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.SavePoint_Check = new System.Windows.Forms.CheckBox();
            this.Combo_RbtDist = new System.Windows.Forms.ComboBox();
            this.Combo_RbtSpeed = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Cmd_RobotRun = new System.Windows.Forms.Button();
            this.Combo_Robot_Pos = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckBox_NeedCCD = new System.Windows.Forms.CheckBox();
            this.Btn_RbtRun12 = new System.Windows.Forms.Button();
            this.Btn_RbtRun10 = new System.Windows.Forms.Button();
            this.Btn_RbtRun8 = new System.Windows.Forms.Button();
            this.Btn_RbtRun11 = new System.Windows.Forms.Button();
            this.Btn_RbtRun9 = new System.Windows.Forms.Button();
            this.Btn_RbtRun7 = new System.Windows.Forms.Button();
            this.Btn_RbtRun6 = new System.Windows.Forms.Button();
            this.Btn_RbtRun5 = new System.Windows.Forms.Button();
            this.Btn_RbtRun4 = new System.Windows.Forms.Button();
            this.Btn_RbtRun3 = new System.Windows.Forms.Button();
            this.Btn_RbtRun2 = new System.Windows.Forms.Button();
            this.Btn_RbtRun1 = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.CommandAuto = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.CmdHold = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CCD_Trigger = new System.Windows.Forms.Button();
            this.ComboBox_Cam2 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Button_O_4 = new System.Windows.Forms.Button();
            this.Button_O_3 = new System.Windows.Forms.Button();
            this.Button_O_5 = new System.Windows.Forms.Button();
            this.Button_O_2 = new System.Windows.Forms.Button();
            this.Rot_SetPressZero = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.Button_P_4 = new System.Windows.Forms.Button();
            this.Button_X_4 = new System.Windows.Forms.Button();
            this.Button_P_3 = new System.Windows.Forms.Button();
            this.Button_X_3 = new System.Windows.Forms.Button();
            this.Button_P_2 = new System.Windows.Forms.Button();
            this.Button_X_2 = new System.Windows.Forms.Button();
            this.Button_O_1 = new System.Windows.Forms.Button();
            this.Button_P_1 = new System.Windows.Forms.Button();
            this.Button_X_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Panel1_Left = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.Btn_L3Z1 = new System.Windows.Forms.Button();
            this.Btn_L2Z1 = new System.Windows.Forms.Button();
            this.Btn_L1Z1 = new System.Windows.Forms.Button();
            this.Btn_L1AZ = new System.Windows.Forms.Button();
            this.Btn_L2AZ = new System.Windows.Forms.Button();
            this.Btn_L3AZ = new System.Windows.Forms.Button();
            this.Btn_L1AF = new System.Windows.Forms.Button();
            this.Btn_L2AF = new System.Windows.Forms.Button();
            this.Btn_L3AF = new System.Windows.Forms.Button();
            this.Btn_L1AST = new System.Windows.Forms.Button();
            this.Btn_L2AST = new System.Windows.Forms.Button();
            this.Btn_L3AST = new System.Windows.Forms.Button();
            this.Panel1_Right = new System.Windows.Forms.Panel();
            this.label38 = new System.Windows.Forms.Label();
            this.Btn_L3Z1N = new System.Windows.Forms.Button();
            this.Btn_L2Z1N = new System.Windows.Forms.Button();
            this.Btn_L1Z1N = new System.Windows.Forms.Button();
            this.Btn_L1BZ = new System.Windows.Forms.Button();
            this.Btn_L2BZ = new System.Windows.Forms.Button();
            this.Btn_L3BZ = new System.Windows.Forms.Button();
            this.Btn_L1BF = new System.Windows.Forms.Button();
            this.Btn_L2BF = new System.Windows.Forms.Button();
            this.Btn_L3BF = new System.Windows.Forms.Button();
            this.Btn_L1BST = new System.Windows.Forms.Button();
            this.Btn_L2BST = new System.Windows.Forms.Button();
            this.Btn_L3BST = new System.Windows.Forms.Button();
            this.校正页面 = new System.Windows.Forms.TabPage();
            this.Panel_Calibration = new System.Windows.Forms.Panel();
            this.GroupBox14 = new System.Windows.Forms.GroupBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Text_Force2 = new System.Windows.Forms.TextBox();
            this.Btn_OpenSerial2 = new System.Windows.Forms.Button();
            this.infoList2 = new DAB.InfoList();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Button_TestStop = new System.Windows.Forms.Button();
            this.Panel_Test = new System.Windows.Forms.Panel();
            this.Combox_CCDTest = new System.Windows.Forms.ComboBox();
            this.Label42 = new System.Windows.Forms.Label();
            this.TextBox_Num = new System.Windows.Forms.TextBox();
            this.Button_Test = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Button_CalibrationStop = new System.Windows.Forms.Button();
            this.PanelCalibration = new System.Windows.Forms.Panel();
            this.Combox_CCD_COR = new System.Windows.Forms.ComboBox();
            this.Btn_CalibrationList = new System.Windows.Forms.Button();
            this.Panel19 = new System.Windows.Forms.Panel();
            this.Trigger = new System.Windows.Forms.Button();
            this.Label_PDCA_Step = new System.Windows.Forms.Label();
            this.Button_OpenPDCAlog = new System.Windows.Forms.Button();
            this.Label26 = new System.Windows.Forms.Label();
            this.Txt_MBarCode = new System.Windows.Forms.TextBox();
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
            this.搬运料盘 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Button_O_7 = new System.Windows.Forms.Button();
            this.Button_O_6 = new System.Windows.Forms.Button();
            this.Button_O_13 = new System.Windows.Forms.Button();
            this.Button_O_12 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Teach2 = new DAB.Teach();
            this.Teach1 = new DAB.Teach();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.CommandAutoS0 = new System.Windows.Forms.Button();
            this.CmdStopS0 = new System.Windows.Forms.Button();
            this.CmdHoldS0 = new System.Windows.Forms.Button();
            this.panel_S2g = new System.Windows.Forms.Panel();
            this.Button_O_9 = new System.Windows.Forms.Button();
            this.Button_O_10 = new System.Windows.Forms.Button();
            this.Button_O_8 = new System.Windows.Forms.Button();
            this.Button_X_5 = new System.Windows.Forms.Button();
            this.Button_P_6 = new System.Windows.Forms.Button();
            this.Button_P_5 = new System.Windows.Forms.Button();
            this.Button_X_6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Teach3 = new DAB.Teach();
            this.保压站 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Text_Force1 = new System.Windows.Forms.TextBox();
            this.Btn_OpenSerial1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Button_J_1 = new System.Windows.Forms.Button();
            this.Button_O_11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CommandAutoPress = new System.Windows.Forms.Button();
            this.CmdStopPress = new System.Windows.Forms.Button();
            this.CmdHoldPress = new System.Windows.Forms.Button();
            this.Teach4 = new DAB.Teach();
            this.机械参数 = new System.Windows.Forms.TabPage();
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
            this.OutputClass3 = new DAB.OutputClass();
            this.OutputClass2 = new DAB.OutputClass();
            this.OutputClass1 = new DAB.OutputClass();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.OutputClass4 = new DAB.OutputClass();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.InputClass3 = new DAB.InputClass();
            this.InputClass2 = new DAB.InputClass();
            this.InputClass1 = new DAB.InputClass();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.InputClass4 = new DAB.InputClass();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.MotorStatus2 = new DAB.MotorStatus();
            this.MotorStatus1 = new DAB.MotorStatus();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.Label_CPK = new System.Windows.Forms.Label();
            this.Label_WorkMode = new System.Windows.Forms.Label();
            this.SplitList_LB = new System.Windows.Forms.Panel();
            this.PictureBox25 = new System.Windows.Forms.PictureBox();
            this.infoList1 = new DAB.InfoList();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Lab_Robot_ASts = new System.Windows.Forms.Label();
            this.Lab_PDCA_Sts = new System.Windows.Forms.Label();
            this.Lab_Robot_Sts = new System.Windows.Forms.Label();
            this.Lab_EMG_Sts = new System.Windows.Forms.Label();
            this.Lab_Safe_Sts = new System.Windows.Forms.Label();
            this.Lab_CCD_Sts = new System.Windows.Forms.Label();
            this.Lab_LC2_Sts = new System.Windows.Forms.Label();
            this.Lab_LC1_Sts = new System.Windows.Forms.Label();
            this.Lab_Air_Sts = new System.Windows.Forms.Label();
            this.Lab_Barcode_Sts = new System.Windows.Forms.Label();
            this.Label_NG_OK = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Lab_DIS_RStep = new System.Windows.Forms.Label();
            this.Lab_DIS_LStep = new System.Windows.Forms.Label();
            this.Lab_Line0Step = new System.Windows.Forms.Label();
            this.Lab_PressStep = new System.Windows.Forms.Label();
            this.Lab_PSAStep = new System.Windows.Forms.Label();
            this.Lab_RobotStep = new System.Windows.Forms.Label();
            this.Lab_HomeStep = new System.Windows.Forms.Label();
            this.Change_PSA = new System.Windows.Forms.Button();
            this.Box_InR5 = new System.Windows.Forms.PictureBox();
            this.Box_InR4 = new System.Windows.Forms.PictureBox();
            this.Box_InR3 = new System.Windows.Forms.PictureBox();
            this.Box_InR2 = new System.Windows.Forms.PictureBox();
            this.Box_InR1 = new System.Windows.Forms.PictureBox();
            this.Box_InL5 = new System.Windows.Forms.PictureBox();
            this.PB_Right2 = new System.Windows.Forms.PictureBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Btn_SelectMaterial = new System.Windows.Forms.Button();
            this.Txt_PalletNum = new System.Windows.Forms.TextBox();
            this.Change_M = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_BarCode = new System.Windows.Forms.TextBox();
            this.Btn_BarCode = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Force_Text = new System.Windows.Forms.Label();
            this.Press1_Text = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Press_Display0 = new System.Windows.Forms.Label();
            this.Box_InR = new System.Windows.Forms.PictureBox();
            this.Box_InL = new System.Windows.Forms.PictureBox();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Product_Num = new System.Windows.Forms.TextBox();
            this.Label134 = new System.Windows.Forms.Label();
            this.Cycle = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.PB_Left2 = new System.Windows.Forms.PictureBox();
            this.Lab_Station1 = new System.Windows.Forms.Label();
            this.Box_InL1 = new System.Windows.Forms.PictureBox();
            this.Box_InL2 = new System.Windows.Forms.PictureBox();
            this.Box_InL3 = new System.Windows.Forms.PictureBox();
            this.Box_InL4 = new System.Windows.Forms.PictureBox();
            this.PB_Right3 = new System.Windows.Forms.PictureBox();
            this.PB_Right1 = new System.Windows.Forms.PictureBox();
            this.PB_Left3 = new System.Windows.Forms.PictureBox();
            this.PB_Left1 = new System.Windows.Forms.PictureBox();
            this.Lab_Line3Step = new System.Windows.Forms.Label();
            this.Lab_Line2Step = new System.Windows.Forms.Label();
            this.Lab_Line1Step = new System.Windows.Forms.Label();
            this.Lab_Station3 = new System.Windows.Forms.Label();
            this.Lab_Station2 = new System.Windows.Forms.Label();
            this.ShapeS3 = new System.Windows.Forms.Label();
            this.ShapeS2 = new System.Windows.Forms.Label();
            this.ShapeS1 = new System.Windows.Forms.Label();
            this.DataGrid_CheckData = new System.Windows.Forms.DataGridView();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProSta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCam1CCX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCam1CCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage4.SuspendLayout();
            this.TabControl4.SuspendLayout();
            this.机械手调试.SuspendLayout();
            this.TabControl5.SuspendLayout();
            this.手动调试.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Panel1_Left.SuspendLayout();
            this.Panel1_Right.SuspendLayout();
            this.校正页面.SuspendLayout();
            this.Panel_Calibration.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.Panel_Test.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.PanelCalibration.SuspendLayout();
            this.Panel19.SuspendLayout();
            this.Panel_Vup.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.搬运料盘.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.panel_S2g.SuspendLayout();
            this.保压站.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.机械参数.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_par)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.TabControl3.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabControl7.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SplitList_LB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox25)).BeginInit();
            this.Panel9.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right2)).BeginInit();
            this.GroupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL)).BeginInit();
            this.GroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left1)).BeginInit();
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
            this.TabControl4.Controls.Add(this.机械手调试);
            this.TabControl4.Controls.Add(this.搬运料盘);
            this.TabControl4.Controls.Add(this.tabPage8);
            this.TabControl4.Controls.Add(this.保压站);
            this.TabControl4.Controls.Add(this.机械参数);
            this.TabControl4.Enabled = false;
            this.TabControl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl4.Location = new System.Drawing.Point(1, 2);
            this.TabControl4.Name = "TabControl4";
            this.TabControl4.SelectedIndex = 0;
            this.TabControl4.Size = new System.Drawing.Size(1007, 600);
            this.TabControl4.TabIndex = 1;
            this.TabControl4.Tag = "4";
            // 
            // 机械手调试
            // 
            this.机械手调试.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.机械手调试.Controls.Add(this.TextBox_CCD);
            this.机械手调试.Controls.Add(this.TabControl5);
            this.机械手调试.Location = new System.Drawing.Point(4, 29);
            this.机械手调试.Name = "机械手调试";
            this.机械手调试.Padding = new System.Windows.Forms.Padding(3);
            this.机械手调试.Size = new System.Drawing.Size(999, 567);
            this.机械手调试.TabIndex = 0;
            this.机械手调试.Text = "机械手调试";
            // 
            // TextBox_CCD
            // 
            this.TextBox_CCD.Location = new System.Drawing.Point(8, 538);
            this.TextBox_CCD.Name = "TextBox_CCD";
            this.TextBox_CCD.Size = new System.Drawing.Size(983, 26);
            this.TextBox_CCD.TabIndex = 65;
            // 
            // TabControl5
            // 
            this.TabControl5.Controls.Add(this.手动调试);
            this.TabControl5.Controls.Add(this.校正页面);
            this.TabControl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl5.Location = new System.Drawing.Point(0, 0);
            this.TabControl5.Name = "TabControl5";
            this.TabControl5.SelectedIndex = 0;
            this.TabControl5.Size = new System.Drawing.Size(1000, 537);
            this.TabControl5.TabIndex = 2;
            // 
            // 手动调试
            // 
            this.手动调试.BackColor = System.Drawing.Color.White;
            this.手动调试.Controls.Add(this.Panel11);
            this.手动调试.Controls.Add(this.panel7);
            this.手动调试.Controls.Add(this.panel8);
            this.手动调试.Controls.Add(this.panel10);
            this.手动调试.Controls.Add(this.panel3);
            this.手动调试.Controls.Add(this.groupBox13);
            this.手动调试.Controls.Add(this.panel2);
            this.手动调试.Controls.Add(this.panel5);
            this.手动调试.Controls.Add(this.Panel1_Left);
            this.手动调试.Controls.Add(this.Panel1_Right);
            this.手动调试.Location = new System.Drawing.Point(4, 29);
            this.手动调试.Name = "手动调试";
            this.手动调试.Padding = new System.Windows.Forms.Padding(3);
            this.手动调试.Size = new System.Drawing.Size(992, 504);
            this.手动调试.TabIndex = 0;
            this.手动调试.Text = "手动调试";
            this.手动调试.Click += new System.EventHandler(this.TabPage14_Click);
            // 
            // Panel11
            // 
            this.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel11.Controls.Add(this.Label_Rbt4);
            this.Panel11.Controls.Add(this.Cmd_MotorON);
            this.Panel11.Controls.Add(this.Cmd_MotorOff);
            this.Panel11.Controls.Add(this.Label_Rbt2);
            this.Panel11.Controls.Add(this.Label_Rbt3);
            this.Panel11.Controls.Add(this.Label_Rbt1);
            this.Panel11.Location = new System.Drawing.Point(2, 132);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(219, 91);
            this.Panel11.TabIndex = 78;
            // 
            // Label_Rbt4
            // 
            this.Label_Rbt4.AutoSize = true;
            this.Label_Rbt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Rbt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Rbt4.Location = new System.Drawing.Point(120, 28);
            this.Label_Rbt4.Name = "Label_Rbt4";
            this.Label_Rbt4.Size = new System.Drawing.Size(74, 19);
            this.Label_Rbt4.TabIndex = 7;
            this.Label_Rbt4.Text = "Rbt报警中";
            // 
            // Cmd_MotorON
            // 
            this.Cmd_MotorON.BackColor = System.Drawing.SystemColors.Menu;
            this.Cmd_MotorON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_MotorON.Location = new System.Drawing.Point(108, 51);
            this.Cmd_MotorON.Name = "Cmd_MotorON";
            this.Cmd_MotorON.Size = new System.Drawing.Size(99, 33);
            this.Cmd_MotorON.TabIndex = 1;
            this.Cmd_MotorON.Tag = "On";
            this.Cmd_MotorON.Text = "Motor On";
            this.Cmd_MotorON.UseVisualStyleBackColor = false;
            this.Cmd_MotorON.Click += new System.EventHandler(this.Cmd_MotorON_Click);
            // 
            // Cmd_MotorOff
            // 
            this.Cmd_MotorOff.BackColor = System.Drawing.SystemColors.Menu;
            this.Cmd_MotorOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_MotorOff.Location = new System.Drawing.Point(3, 51);
            this.Cmd_MotorOff.Name = "Cmd_MotorOff";
            this.Cmd_MotorOff.Size = new System.Drawing.Size(99, 33);
            this.Cmd_MotorOff.TabIndex = 0;
            this.Cmd_MotorOff.Tag = "Off";
            this.Cmd_MotorOff.Text = "Motor Off";
            this.Cmd_MotorOff.UseVisualStyleBackColor = false;
            this.Cmd_MotorOff.Click += new System.EventHandler(this.Cmd_MotorON_Click);
            // 
            // Label_Rbt2
            // 
            this.Label_Rbt2.AutoSize = true;
            this.Label_Rbt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Rbt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Rbt2.Location = new System.Drawing.Point(24, 28);
            this.Label_Rbt2.Name = "Label_Rbt2";
            this.Label_Rbt2.Size = new System.Drawing.Size(74, 19);
            this.Label_Rbt2.TabIndex = 6;
            this.Label_Rbt2.Text = "Rbt运动中";
            // 
            // Label_Rbt3
            // 
            this.Label_Rbt3.AutoSize = true;
            this.Label_Rbt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Rbt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Rbt3.Location = new System.Drawing.Point(120, 5);
            this.Label_Rbt3.Name = "Label_Rbt3";
            this.Label_Rbt3.Size = new System.Drawing.Size(74, 19);
            this.Label_Rbt3.TabIndex = 5;
            this.Label_Rbt3.Text = "Rbt暂停中";
            // 
            // Label_Rbt1
            // 
            this.Label_Rbt1.AutoSize = true;
            this.Label_Rbt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Rbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Rbt1.Location = new System.Drawing.Point(24, 5);
            this.Label_Rbt1.Name = "Label_Rbt1";
            this.Label_Rbt1.Size = new System.Drawing.Size(74, 19);
            this.Label_Rbt1.TabIndex = 4;
            this.Label_Rbt1.Text = "Rbt准备好";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Btn_Rbt1);
            this.panel7.Controls.Add(this.Btn_Rbt5);
            this.panel7.Controls.Add(this.Btn_Rbt4);
            this.panel7.Controls.Add(this.Btn_Rbt3);
            this.panel7.Controls.Add(this.Btn_Rbt2);
            this.panel7.Location = new System.Drawing.Point(227, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(90, 221);
            this.panel7.TabIndex = 77;
            // 
            // Btn_Rbt1
            // 
            this.Btn_Rbt1.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_Rbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Rbt1.Location = new System.Drawing.Point(4, 5);
            this.Btn_Rbt1.Name = "Btn_Rbt1";
            this.Btn_Rbt1.Size = new System.Drawing.Size(80, 33);
            this.Btn_Rbt1.TabIndex = 0;
            this.Btn_Rbt1.Tag = "(0,0,0)";
            this.Btn_Rbt1.Text = "Rbt启动";
            this.Btn_Rbt1.UseVisualStyleBackColor = false;
            this.Btn_Rbt1.Click += new System.EventHandler(this.BtnRobot_Click);
            // 
            // Btn_Rbt5
            // 
            this.Btn_Rbt5.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_Rbt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Rbt5.Location = new System.Drawing.Point(4, 181);
            this.Btn_Rbt5.Name = "Btn_Rbt5";
            this.Btn_Rbt5.Size = new System.Drawing.Size(80, 33);
            this.Btn_Rbt5.TabIndex = 0;
            this.Btn_Rbt5.Tag = "(0,0,4)";
            this.Btn_Rbt5.Text = "Rbt复位";
            this.Btn_Rbt5.UseVisualStyleBackColor = false;
            this.Btn_Rbt5.Click += new System.EventHandler(this.BtnRobot_Click);
            // 
            // Btn_Rbt4
            // 
            this.Btn_Rbt4.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_Rbt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Rbt4.Location = new System.Drawing.Point(4, 137);
            this.Btn_Rbt4.Name = "Btn_Rbt4";
            this.Btn_Rbt4.Size = new System.Drawing.Size(80, 33);
            this.Btn_Rbt4.TabIndex = 0;
            this.Btn_Rbt4.Tag = "(0,0,3)";
            this.Btn_Rbt4.Text = "Rbt继续";
            this.Btn_Rbt4.UseVisualStyleBackColor = false;
            this.Btn_Rbt4.Click += new System.EventHandler(this.BtnRobot_Click);
            // 
            // Btn_Rbt3
            // 
            this.Btn_Rbt3.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_Rbt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Rbt3.Location = new System.Drawing.Point(4, 93);
            this.Btn_Rbt3.Name = "Btn_Rbt3";
            this.Btn_Rbt3.Size = new System.Drawing.Size(80, 33);
            this.Btn_Rbt3.TabIndex = 0;
            this.Btn_Rbt3.Tag = "(0,0,2)";
            this.Btn_Rbt3.Text = "Rbt暂停";
            this.Btn_Rbt3.UseVisualStyleBackColor = false;
            this.Btn_Rbt3.Click += new System.EventHandler(this.BtnRobot_Click);
            // 
            // Btn_Rbt2
            // 
            this.Btn_Rbt2.BackColor = System.Drawing.SystemColors.Menu;
            this.Btn_Rbt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Rbt2.Location = new System.Drawing.Point(4, 49);
            this.Btn_Rbt2.Name = "Btn_Rbt2";
            this.Btn_Rbt2.Size = new System.Drawing.Size(80, 33);
            this.Btn_Rbt2.TabIndex = 0;
            this.Btn_Rbt2.Tag = "(0,0,1)";
            this.Btn_Rbt2.Text = "Rbt停止";
            this.Btn_Rbt2.UseVisualStyleBackColor = false;
            this.Btn_Rbt2.Click += new System.EventHandler(this.BtnRobot_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.checkBox_Live);
            this.panel8.Controls.Add(this.Text_Robot_X);
            this.panel8.Controls.Add(this.Text_Robot_Y);
            this.panel8.Controls.Add(this.Text_Robot_Z);
            this.panel8.Controls.Add(this.Text_Robot_U);
            this.panel8.Controls.Add(this.label41);
            this.panel8.Controls.Add(this.Text_Robot_V);
            this.panel8.Controls.Add(this.MForce_Text);
            this.panel8.Controls.Add(this.Text_Robot_W);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.label28);
            this.panel8.Controls.Add(this.label31);
            this.panel8.Location = new System.Drawing.Point(323, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(142, 221);
            this.panel8.TabIndex = 76;
            // 
            // checkBox_Live
            // 
            this.checkBox_Live.AutoSize = true;
            this.checkBox_Live.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Live.Location = new System.Drawing.Point(7, 190);
            this.checkBox_Live.Name = "checkBox_Live";
            this.checkBox_Live.Size = new System.Drawing.Size(128, 24);
            this.checkBox_Live.TabIndex = 28;
            this.checkBox_Live.Text = " 连续更新坐标";
            this.checkBox_Live.UseVisualStyleBackColor = true;
            this.checkBox_Live.CheckedChanged += new System.EventHandler(this.checkBox_Live_CheckedChanged);
            // 
            // Text_Robot_X
            // 
            this.Text_Robot_X.BackColor = System.Drawing.Color.White;
            this.Text_Robot_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Robot_X.Location = new System.Drawing.Point(42, 8);
            this.Text_Robot_X.Name = "Text_Robot_X";
            this.Text_Robot_X.ReadOnly = true;
            this.Text_Robot_X.Size = new System.Drawing.Size(80, 23);
            this.Text_Robot_X.TabIndex = 1;
            this.Text_Robot_X.Text = "0.00";
            this.Text_Robot_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Robot_Y
            // 
            this.Text_Robot_Y.BackColor = System.Drawing.Color.White;
            this.Text_Robot_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Robot_Y.Location = new System.Drawing.Point(42, 34);
            this.Text_Robot_Y.Name = "Text_Robot_Y";
            this.Text_Robot_Y.ReadOnly = true;
            this.Text_Robot_Y.Size = new System.Drawing.Size(80, 23);
            this.Text_Robot_Y.TabIndex = 2;
            this.Text_Robot_Y.Text = "0.00";
            this.Text_Robot_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Robot_Z
            // 
            this.Text_Robot_Z.BackColor = System.Drawing.Color.White;
            this.Text_Robot_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Robot_Z.Location = new System.Drawing.Point(42, 60);
            this.Text_Robot_Z.Name = "Text_Robot_Z";
            this.Text_Robot_Z.ReadOnly = true;
            this.Text_Robot_Z.Size = new System.Drawing.Size(80, 23);
            this.Text_Robot_Z.TabIndex = 3;
            this.Text_Robot_Z.Text = "0.00";
            this.Text_Robot_Z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Robot_U
            // 
            this.Text_Robot_U.BackColor = System.Drawing.Color.White;
            this.Text_Robot_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Robot_U.Location = new System.Drawing.Point(42, 86);
            this.Text_Robot_U.Name = "Text_Robot_U";
            this.Text_Robot_U.ReadOnly = true;
            this.Text_Robot_U.Size = new System.Drawing.Size(80, 23);
            this.Text_Robot_U.TabIndex = 4;
            this.Text_Robot_U.Text = "0.00";
            this.Text_Robot_U.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(5, 166);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(36, 17);
            this.label41.TabIndex = 54;
            this.label41.Text = "压力";
            // 
            // Text_Robot_V
            // 
            this.Text_Robot_V.BackColor = System.Drawing.Color.White;
            this.Text_Robot_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Robot_V.Location = new System.Drawing.Point(42, 112);
            this.Text_Robot_V.Name = "Text_Robot_V";
            this.Text_Robot_V.ReadOnly = true;
            this.Text_Robot_V.Size = new System.Drawing.Size(80, 23);
            this.Text_Robot_V.TabIndex = 5;
            this.Text_Robot_V.Text = "0.00";
            this.Text_Robot_V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MForce_Text
            // 
            this.MForce_Text.BackColor = System.Drawing.SystemColors.Info;
            this.MForce_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MForce_Text.Location = new System.Drawing.Point(42, 164);
            this.MForce_Text.Name = "MForce_Text";
            this.MForce_Text.ReadOnly = true;
            this.MForce_Text.Size = new System.Drawing.Size(80, 23);
            this.MForce_Text.TabIndex = 52;
            this.MForce_Text.Text = "--";
            this.MForce_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Robot_W
            // 
            this.Text_Robot_W.BackColor = System.Drawing.Color.White;
            this.Text_Robot_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Robot_W.Location = new System.Drawing.Point(42, 138);
            this.Text_Robot_W.Name = "Text_Robot_W";
            this.Text_Robot_W.ReadOnly = true;
            this.Text_Robot_W.Size = new System.Drawing.Size(80, 23);
            this.Text_Robot_W.TabIndex = 6;
            this.Text_Robot_W.Text = "0.00";
            this.Text_Robot_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "W轴";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(10, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "V轴";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(9, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "U轴";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(10, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 17);
            this.label25.TabIndex = 3;
            this.label25.Text = "Z轴";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(10, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 17);
            this.label28.TabIndex = 2;
            this.label28.Text = "Y轴";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(10, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 17);
            this.label31.TabIndex = 0;
            this.label31.Text = "X轴";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.Btn_SelectPalletNum);
            this.panel10.Controls.Add(this.Txt_PalletSelectNum);
            this.panel10.Controls.Add(this.CmdS2_Save);
            this.panel10.Controls.Add(this.TrackBar2);
            this.panel10.Controls.Add(this.TrackBar1);
            this.panel10.Controls.Add(this.SavePoint_Check);
            this.panel10.Controls.Add(this.Combo_RbtDist);
            this.panel10.Controls.Add(this.Combo_RbtSpeed);
            this.panel10.Controls.Add(this.label35);
            this.panel10.Controls.Add(this.label36);
            this.panel10.Controls.Add(this.Cmd_RobotRun);
            this.panel10.Controls.Add(this.Combo_Robot_Pos);
            this.panel10.Location = new System.Drawing.Point(471, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(247, 221);
            this.panel10.TabIndex = 75;
            // 
            // Btn_SelectPalletNum
            // 
            this.Btn_SelectPalletNum.BackColor = System.Drawing.Color.Honeydew;
            this.Btn_SelectPalletNum.Font = new System.Drawing.Font("宋体", 9F);
            this.Btn_SelectPalletNum.Location = new System.Drawing.Point(3, 42);
            this.Btn_SelectPalletNum.Name = "Btn_SelectPalletNum";
            this.Btn_SelectPalletNum.Size = new System.Drawing.Size(56, 33);
            this.Btn_SelectPalletNum.TabIndex = 21;
            this.Btn_SelectPalletNum.Text = "选料";
            this.Btn_SelectPalletNum.UseVisualStyleBackColor = false;
            this.Btn_SelectPalletNum.Visible = false;
            this.Btn_SelectPalletNum.Click += new System.EventHandler(this.Btn_SelectMaterial_Click);
            // 
            // Txt_PalletSelectNum
            // 
            this.Txt_PalletSelectNum.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_PalletSelectNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_PalletSelectNum.ForeColor = System.Drawing.Color.Blue;
            this.Txt_PalletSelectNum.Location = new System.Drawing.Point(72, 46);
            this.Txt_PalletSelectNum.Name = "Txt_PalletSelectNum";
            this.Txt_PalletSelectNum.ReadOnly = true;
            this.Txt_PalletSelectNum.Size = new System.Drawing.Size(47, 26);
            this.Txt_PalletSelectNum.TabIndex = 20;
            this.Txt_PalletSelectNum.Text = "1";
            this.Txt_PalletSelectNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_PalletSelectNum.Visible = false;
            // 
            // CmdS2_Save
            // 
            this.CmdS2_Save.BackColor = System.Drawing.SystemColors.Menu;
            this.CmdS2_Save.Enabled = false;
            this.CmdS2_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmdS2_Save.Location = new System.Drawing.Point(134, 181);
            this.CmdS2_Save.Name = "CmdS2_Save";
            this.CmdS2_Save.Size = new System.Drawing.Size(99, 33);
            this.CmdS2_Save.TabIndex = 7;
            this.CmdS2_Save.Text = "保 存";
            this.CmdS2_Save.UseVisualStyleBackColor = false;
            this.CmdS2_Save.Click += new System.EventHandler(this.CmdS2_Save_Click);
            // 
            // TrackBar2
            // 
            this.TrackBar2.Location = new System.Drawing.Point(131, 140);
            this.TrackBar2.Maximum = 50;
            this.TrackBar2.Name = "TrackBar2";
            this.TrackBar2.Size = new System.Drawing.Size(102, 45);
            this.TrackBar2.TabIndex = 12;
            this.TrackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(6, 140);
            this.TrackBar1.Maximum = 60;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(104, 45);
            this.TrackBar1.TabIndex = 11;
            this.TrackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // SavePoint_Check
            // 
            this.SavePoint_Check.AutoSize = true;
            this.SavePoint_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SavePoint_Check.Location = new System.Drawing.Point(6, 189);
            this.SavePoint_Check.Name = "SavePoint_Check";
            this.SavePoint_Check.Size = new System.Drawing.Size(83, 21);
            this.SavePoint_Check.TabIndex = 10;
            this.SavePoint_Check.Text = "允许保存";
            this.SavePoint_Check.UseVisualStyleBackColor = true;
            this.SavePoint_Check.CheckedChanged += new System.EventHandler(this.SavePoint_Check_CheckedChanged);
            // 
            // Combo_RbtDist
            // 
            this.Combo_RbtDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Combo_RbtDist.FormattingEnabled = true;
            this.Combo_RbtDist.Items.AddRange(new object[] {
            "0.01",
            "0.02",
            "0.1",
            "0.5",
            "1",
            "5",
            "10",
            "50"});
            this.Combo_RbtDist.Location = new System.Drawing.Point(131, 101);
            this.Combo_RbtDist.Name = "Combo_RbtDist";
            this.Combo_RbtDist.Size = new System.Drawing.Size(102, 33);
            this.Combo_RbtDist.TabIndex = 6;
            this.Combo_RbtDist.Text = "0.01";
            // 
            // Combo_RbtSpeed
            // 
            this.Combo_RbtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Combo_RbtSpeed.FormattingEnabled = true;
            this.Combo_RbtSpeed.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.Combo_RbtSpeed.Location = new System.Drawing.Point(6, 101);
            this.Combo_RbtSpeed.Name = "Combo_RbtSpeed";
            this.Combo_RbtSpeed.Size = new System.Drawing.Size(105, 33);
            this.Combo_RbtSpeed.TabIndex = 5;
            this.Combo_RbtSpeed.Text = "20";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(121, 78);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(118, 17);
            this.label35.TabIndex = 4;
            this.label35.Text = "Rbt运动距离(mm)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(3, 77);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(108, 17);
            this.label36.TabIndex = 2;
            this.label36.Text = "Rbt运动速度(%)";
            // 
            // Cmd_RobotRun
            // 
            this.Cmd_RobotRun.BackColor = System.Drawing.SystemColors.Menu;
            this.Cmd_RobotRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmd_RobotRun.Location = new System.Drawing.Point(134, 41);
            this.Cmd_RobotRun.Name = "Cmd_RobotRun";
            this.Cmd_RobotRun.Size = new System.Drawing.Size(99, 33);
            this.Cmd_RobotRun.TabIndex = 1;
            this.Cmd_RobotRun.Text = "运 动";
            this.Cmd_RobotRun.UseVisualStyleBackColor = false;
            this.Cmd_RobotRun.Click += new System.EventHandler(this.Cmd_RobotRun_Click);
            // 
            // Combo_Robot_Pos
            // 
            this.Combo_Robot_Pos.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_Robot_Pos.DropDownHeight = 400;
            this.Combo_Robot_Pos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Robot_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Combo_Robot_Pos.FormattingEnabled = true;
            this.Combo_Robot_Pos.IntegralHeight = false;
            this.Combo_Robot_Pos.Items.AddRange(new object[] {
            " 0.待机位置          ",
            " 1.PSA载台拍照位置",
            " 2.取PSA位置",
            " 3.撕PSA下模位置",
            " 4.PSA定位拍照位置",
            " 5.预贴PSA位置",
            " 6.料盘上拍照位置",
            " 7.料盘上取料位置",
            " 8.显示屏撕模位置",
            " 9.显示屏定位拍照位置",
            "10.预贴显示屏位置",
            "11.PSA抛料位置",
            "12.压力传感器位置"});
            this.Combo_Robot_Pos.Location = new System.Drawing.Point(3, 5);
            this.Combo_Robot_Pos.Name = "Combo_Robot_Pos";
            this.Combo_Robot_Pos.Size = new System.Drawing.Size(230, 33);
            this.Combo_Robot_Pos.TabIndex = 0;
            this.Combo_Robot_Pos.SelectionChangeCommitted += new System.EventHandler(this.Combo_S2_Pos_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CheckBox_NeedCCD);
            this.panel3.Controls.Add(this.Btn_RbtRun12);
            this.panel3.Controls.Add(this.Btn_RbtRun10);
            this.panel3.Controls.Add(this.Btn_RbtRun8);
            this.panel3.Controls.Add(this.Btn_RbtRun11);
            this.panel3.Controls.Add(this.Btn_RbtRun9);
            this.panel3.Controls.Add(this.Btn_RbtRun7);
            this.panel3.Controls.Add(this.Btn_RbtRun6);
            this.panel3.Controls.Add(this.Btn_RbtRun5);
            this.panel3.Controls.Add(this.Btn_RbtRun4);
            this.panel3.Controls.Add(this.Btn_RbtRun3);
            this.panel3.Controls.Add(this.Btn_RbtRun2);
            this.panel3.Controls.Add(this.Btn_RbtRun1);
            this.panel3.Location = new System.Drawing.Point(728, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 333);
            this.panel3.TabIndex = 74;
            // 
            // CheckBox_NeedCCD
            // 
            this.CheckBox_NeedCCD.AutoSize = true;
            this.CheckBox_NeedCCD.Location = new System.Drawing.Point(3, 8);
            this.CheckBox_NeedCCD.Name = "CheckBox_NeedCCD";
            this.CheckBox_NeedCCD.Size = new System.Drawing.Size(62, 24);
            this.CheckBox_NeedCCD.TabIndex = 27;
            this.CheckBox_NeedCCD.Text = "CCD";
            this.CheckBox_NeedCCD.UseVisualStyleBackColor = true;
            // 
            // Btn_RbtRun12
            // 
            this.Btn_RbtRun12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun12.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun12.Image")));
            this.Btn_RbtRun12.Location = new System.Drawing.Point(195, 254);
            this.Btn_RbtRun12.Name = "Btn_RbtRun12";
            this.Btn_RbtRun12.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun12.TabIndex = 1;
            this.Btn_RbtRun12.Tag = "W";
            this.Btn_RbtRun12.Text = "W(+)";
            this.Btn_RbtRun12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun12.UseVisualStyleBackColor = true;
            this.Btn_RbtRun12.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun10
            // 
            this.Btn_RbtRun10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun10.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun10.Image")));
            this.Btn_RbtRun10.Location = new System.Drawing.Point(110, 254);
            this.Btn_RbtRun10.Name = "Btn_RbtRun10";
            this.Btn_RbtRun10.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun10.TabIndex = 1;
            this.Btn_RbtRun10.Tag = "V";
            this.Btn_RbtRun10.Text = "V(+)";
            this.Btn_RbtRun10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun10.UseVisualStyleBackColor = true;
            this.Btn_RbtRun10.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun8
            // 
            this.Btn_RbtRun8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun8.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun8.Image")));
            this.Btn_RbtRun8.Location = new System.Drawing.Point(17, 184);
            this.Btn_RbtRun8.Name = "Btn_RbtRun8";
            this.Btn_RbtRun8.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun8.TabIndex = 0;
            this.Btn_RbtRun8.Tag = "U";
            this.Btn_RbtRun8.Text = "U(-)";
            this.Btn_RbtRun8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun8.UseVisualStyleBackColor = true;
            this.Btn_RbtRun8.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun11
            // 
            this.Btn_RbtRun11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun11.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun11.Image")));
            this.Btn_RbtRun11.Location = new System.Drawing.Point(195, 184);
            this.Btn_RbtRun11.Name = "Btn_RbtRun11";
            this.Btn_RbtRun11.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun11.TabIndex = 0;
            this.Btn_RbtRun11.Tag = "W";
            this.Btn_RbtRun11.Text = "W(-)";
            this.Btn_RbtRun11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun11.UseVisualStyleBackColor = true;
            this.Btn_RbtRun11.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun9
            // 
            this.Btn_RbtRun9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun9.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun9.Image")));
            this.Btn_RbtRun9.Location = new System.Drawing.Point(110, 184);
            this.Btn_RbtRun9.Name = "Btn_RbtRun9";
            this.Btn_RbtRun9.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun9.TabIndex = 0;
            this.Btn_RbtRun9.Tag = "V";
            this.Btn_RbtRun9.Text = "V(-)";
            this.Btn_RbtRun9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun9.UseVisualStyleBackColor = true;
            this.Btn_RbtRun9.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun7
            // 
            this.Btn_RbtRun7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun7.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun7.Image")));
            this.Btn_RbtRun7.Location = new System.Drawing.Point(17, 254);
            this.Btn_RbtRun7.Name = "Btn_RbtRun7";
            this.Btn_RbtRun7.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun7.TabIndex = 1;
            this.Btn_RbtRun7.Tag = "U";
            this.Btn_RbtRun7.Text = "U(+)";
            this.Btn_RbtRun7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun7.UseVisualStyleBackColor = true;
            this.Btn_RbtRun7.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun6
            // 
            this.Btn_RbtRun6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun6.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun6.Image")));
            this.Btn_RbtRun6.Location = new System.Drawing.Point(195, 31);
            this.Btn_RbtRun6.Name = "Btn_RbtRun6";
            this.Btn_RbtRun6.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun6.TabIndex = 1;
            this.Btn_RbtRun6.Tag = "Z";
            this.Btn_RbtRun6.Text = "Z(+)";
            this.Btn_RbtRun6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun6.UseVisualStyleBackColor = true;
            this.Btn_RbtRun6.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun5
            // 
            this.Btn_RbtRun5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun5.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun5.Image")));
            this.Btn_RbtRun5.Location = new System.Drawing.Point(195, 122);
            this.Btn_RbtRun5.Name = "Btn_RbtRun5";
            this.Btn_RbtRun5.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun5.TabIndex = 0;
            this.Btn_RbtRun5.Tag = "Z";
            this.Btn_RbtRun5.Text = "Z(-)";
            this.Btn_RbtRun5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun5.UseVisualStyleBackColor = true;
            this.Btn_RbtRun5.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun4
            // 
            this.Btn_RbtRun4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun4.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun4.Image")));
            this.Btn_RbtRun4.Location = new System.Drawing.Point(17, 81);
            this.Btn_RbtRun4.Name = "Btn_RbtRun4";
            this.Btn_RbtRun4.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun4.TabIndex = 1;
            this.Btn_RbtRun4.Tag = "X";
            this.Btn_RbtRun4.Text = "X(+)";
            this.Btn_RbtRun4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun4.UseVisualStyleBackColor = true;
            this.Btn_RbtRun4.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun3
            // 
            this.Btn_RbtRun3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun3.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun3.Image")));
            this.Btn_RbtRun3.Location = new System.Drawing.Point(134, 81);
            this.Btn_RbtRun3.Name = "Btn_RbtRun3";
            this.Btn_RbtRun3.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun3.TabIndex = 0;
            this.Btn_RbtRun3.Tag = "X";
            this.Btn_RbtRun3.Text = "X(-)";
            this.Btn_RbtRun3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun3.UseVisualStyleBackColor = true;
            this.Btn_RbtRun3.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun2
            // 
            this.Btn_RbtRun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun2.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun2.Image")));
            this.Btn_RbtRun2.Location = new System.Drawing.Point(75, 122);
            this.Btn_RbtRun2.Name = "Btn_RbtRun2";
            this.Btn_RbtRun2.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun2.TabIndex = 1;
            this.Btn_RbtRun2.Tag = "Y";
            this.Btn_RbtRun2.Text = "Y(+)";
            this.Btn_RbtRun2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun2.UseVisualStyleBackColor = true;
            this.Btn_RbtRun2.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // Btn_RbtRun1
            // 
            this.Btn_RbtRun1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RbtRun1.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RbtRun1.Image")));
            this.Btn_RbtRun1.Location = new System.Drawing.Point(75, 32);
            this.Btn_RbtRun1.Name = "Btn_RbtRun1";
            this.Btn_RbtRun1.Size = new System.Drawing.Size(50, 50);
            this.Btn_RbtRun1.TabIndex = 0;
            this.Btn_RbtRun1.Tag = "Y";
            this.Btn_RbtRun1.Text = "Y(-)";
            this.Btn_RbtRun1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_RbtRun1.UseVisualStyleBackColor = true;
            this.Btn_RbtRun1.Click += new System.EventHandler(this.Btn_RbtRun1_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.CommandAuto);
            this.groupBox13.Controls.Add(this.CmdStop);
            this.groupBox13.Controls.Add(this.CmdHold);
            this.groupBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox13.Location = new System.Drawing.Point(728, 341);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(261, 160);
            this.groupBox13.TabIndex = 73;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "单站调试";
            // 
            // CommandAuto
            // 
            this.CommandAuto.BackColor = System.Drawing.Color.Tomato;
            this.CommandAuto.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandAuto.Location = new System.Drawing.Point(59, 111);
            this.CommandAuto.Name = "CommandAuto";
            this.CommandAuto.Size = new System.Drawing.Size(126, 30);
            this.CommandAuto.TabIndex = 110;
            this.CommandAuto.Text = "单站自动运行";
            this.CommandAuto.UseVisualStyleBackColor = false;
            this.CommandAuto.Click += new System.EventHandler(this.CommandAutoS4_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(32, 31);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(59, 29);
            this.CmdStop.TabIndex = 1;
            this.CmdStop.Text = "停止";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStopS4_Click);
            // 
            // CmdHold
            // 
            this.CmdHold.BackColor = System.Drawing.Color.BurlyWood;
            this.CmdHold.Location = new System.Drawing.Point(126, 31);
            this.CmdHold.Name = "CmdHold";
            this.CmdHold.Size = new System.Drawing.Size(59, 29);
            this.CmdHold.TabIndex = 0;
            this.CmdHold.Text = "暂停";
            this.CmdHold.UseVisualStyleBackColor = false;
            this.CmdHold.Click += new System.EventHandler(this.CmdHoldS4_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CCD_Trigger);
            this.panel2.Controls.Add(this.ComboBox_Cam2);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 122);
            this.panel2.TabIndex = 72;
            // 
            // CCD_Trigger
            // 
            this.CCD_Trigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CCD_Trigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CCD_Trigger.Image = ((System.Drawing.Image)(resources.GetObject("CCD_Trigger.Image")));
            this.CCD_Trigger.Location = new System.Drawing.Point(56, 68);
            this.CCD_Trigger.Name = "CCD_Trigger";
            this.CCD_Trigger.Size = new System.Drawing.Size(92, 40);
            this.CCD_Trigger.TabIndex = 2;
            this.CCD_Trigger.Tag = "2";
            this.CCD_Trigger.Text = "CCD拍 照";
            this.CCD_Trigger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CCD_Trigger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CCD_Trigger.UseVisualStyleBackColor = false;
            this.CCD_Trigger.Click += new System.EventHandler(this.CCD_Trigger_Click);
            // 
            // ComboBox_Cam2
            // 
            this.ComboBox_Cam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Cam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Cam2.FormattingEnabled = true;
            this.ComboBox_Cam2.Items.AddRange(new object[] {
            "0.取PSA拍照",
            "1.装PSA定位拍照",
            "2.装Display定位拍照",
            "3.Display预装复检",
            "4.Display贴合复检",
            "5.Bezel取料拍照",
            "6.Bezel定位拍照上",
            "7.Bezel定位拍照下"});
            this.ComboBox_Cam2.Location = new System.Drawing.Point(6, 7);
            this.ComboBox_Cam2.Name = "ComboBox_Cam2";
            this.ComboBox_Cam2.Size = new System.Drawing.Size(198, 33);
            this.ComboBox_Cam2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Button_O_4);
            this.panel5.Controls.Add(this.Button_O_3);
            this.panel5.Controls.Add(this.Button_O_5);
            this.panel5.Controls.Add(this.Button_O_2);
            this.panel5.Controls.Add(this.Rot_SetPressZero);
            this.panel5.Controls.Add(this.label40);
            this.panel5.Controls.Add(this.Button_P_4);
            this.panel5.Controls.Add(this.Button_X_4);
            this.panel5.Controls.Add(this.Button_P_3);
            this.panel5.Controls.Add(this.Button_X_3);
            this.panel5.Controls.Add(this.Button_P_2);
            this.panel5.Controls.Add(this.Button_X_2);
            this.panel5.Controls.Add(this.Button_O_1);
            this.panel5.Controls.Add(this.Button_P_1);
            this.panel5.Controls.Add(this.Button_X_1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Location = new System.Drawing.Point(6, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(716, 156);
            this.panel5.TabIndex = 66;
            // 
            // Button_O_4
            // 
            this.Button_O_4.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_4.Location = new System.Drawing.Point(361, 80);
            this.Button_O_4.Name = "Button_O_4";
            this.Button_O_4.Size = new System.Drawing.Size(109, 30);
            this.Button_O_4.TabIndex = 1;
            this.Button_O_4.Tag = "(0,0,6)";
            this.Button_O_4.Text = "撕膜升降气缸";
            this.Button_O_4.UseVisualStyleBackColor = false;
            this.Button_O_4.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_3
            // 
            this.Button_O_3.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_3.Location = new System.Drawing.Point(243, 80);
            this.Button_O_3.Name = "Button_O_3";
            this.Button_O_3.Size = new System.Drawing.Size(109, 30);
            this.Button_O_3.TabIndex = 1;
            this.Button_O_3.Tag = "(0,0,5)";
            this.Button_O_3.Text = "撕膜针型气缸";
            this.Button_O_3.UseVisualStyleBackColor = false;
            this.Button_O_3.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_5
            // 
            this.Button_O_5.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_5.Location = new System.Drawing.Point(13, 116);
            this.Button_O_5.Name = "Button_O_5";
            this.Button_O_5.Size = new System.Drawing.Size(109, 30);
            this.Button_O_5.TabIndex = 1;
            this.Button_O_5.Tag = "(0,0,14)";
            this.Button_O_5.Text = "光源旋转气缸";
            this.Button_O_5.UseVisualStyleBackColor = false;
            this.Button_O_5.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_2
            // 
            this.Button_O_2.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_2.Location = new System.Drawing.Point(125, 80);
            this.Button_O_2.Name = "Button_O_2";
            this.Button_O_2.Size = new System.Drawing.Size(109, 30);
            this.Button_O_2.TabIndex = 1;
            this.Button_O_2.Tag = "(0,0,4)";
            this.Button_O_2.Text = "滑台气缸";
            this.Button_O_2.UseVisualStyleBackColor = false;
            this.Button_O_2.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Rot_SetPressZero
            // 
            this.Rot_SetPressZero.BackColor = System.Drawing.Color.Khaki;
            this.Rot_SetPressZero.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rot_SetPressZero.Location = new System.Drawing.Point(479, 7);
            this.Rot_SetPressZero.Name = "Rot_SetPressZero";
            this.Rot_SetPressZero.Size = new System.Drawing.Size(109, 30);
            this.Rot_SetPressZero.TabIndex = 0;
            this.Rot_SetPressZero.Tag = "";
            this.Rot_SetPressZero.Text = "复位机械手压力";
            this.Rot_SetPressZero.UseVisualStyleBackColor = false;
            this.Rot_SetPressZero.Click += new System.EventHandler(this.Rot_SetPress_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(714, 356);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(18, 17);
            this.label40.TabIndex = 53;
            this.label40.Text = "N";
            // 
            // Button_P_4
            // 
            this.Button_P_4.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_P_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_P_4.Location = new System.Drawing.Point(358, 44);
            this.Button_P_4.Name = "Button_P_4";
            this.Button_P_4.Size = new System.Drawing.Size(109, 30);
            this.Button_P_4.TabIndex = 1;
            this.Button_P_4.Tag = "(0,1,11)";
            this.Button_P_4.Text = "夹爪吸膜破真空";
            this.Button_P_4.UseVisualStyleBackColor = false;
            this.Button_P_4.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_X_4
            // 
            this.Button_X_4.BackColor = System.Drawing.Color.Khaki;
            this.Button_X_4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_X_4.Location = new System.Drawing.Point(358, 7);
            this.Button_X_4.Name = "Button_X_4";
            this.Button_X_4.Size = new System.Drawing.Size(109, 30);
            this.Button_X_4.TabIndex = 1;
            this.Button_X_4.Tag = "(0,1,10)";
            this.Button_X_4.Text = "夹爪吸膜真空吸";
            this.Button_X_4.UseVisualStyleBackColor = false;
            this.Button_X_4.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_P_3
            // 
            this.Button_P_3.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_P_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_P_3.Location = new System.Drawing.Point(243, 44);
            this.Button_P_3.Name = "Button_P_3";
            this.Button_P_3.Size = new System.Drawing.Size(109, 30);
            this.Button_P_3.TabIndex = 1;
            this.Button_P_3.Tag = "(0,0,9)";
            this.Button_P_3.Text = "主破真空";
            this.Button_P_3.UseVisualStyleBackColor = false;
            this.Button_P_3.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_X_3
            // 
            this.Button_X_3.BackColor = System.Drawing.Color.Khaki;
            this.Button_X_3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_X_3.Location = new System.Drawing.Point(243, 7);
            this.Button_X_3.Name = "Button_X_3";
            this.Button_X_3.Size = new System.Drawing.Size(109, 30);
            this.Button_X_3.TabIndex = 1;
            this.Button_X_3.Tag = "(0,1,8)";
            this.Button_X_3.Text = "主真空吸";
            this.Button_X_3.UseVisualStyleBackColor = false;
            this.Button_X_3.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_P_2
            // 
            this.Button_P_2.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_P_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_P_2.Location = new System.Drawing.Point(128, 44);
            this.Button_P_2.Name = "Button_P_2";
            this.Button_P_2.Size = new System.Drawing.Size(109, 30);
            this.Button_P_2.TabIndex = 1;
            this.Button_P_2.Tag = "(0,1,7)";
            this.Button_P_2.Text = "排线破真空";
            this.Button_P_2.UseVisualStyleBackColor = false;
            this.Button_P_2.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_X_2
            // 
            this.Button_X_2.BackColor = System.Drawing.Color.Khaki;
            this.Button_X_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_X_2.Location = new System.Drawing.Point(128, 7);
            this.Button_X_2.Name = "Button_X_2";
            this.Button_X_2.Size = new System.Drawing.Size(109, 30);
            this.Button_X_2.TabIndex = 1;
            this.Button_X_2.Tag = "(0,1,6)";
            this.Button_X_2.Text = "排线真空吸";
            this.Button_X_2.UseVisualStyleBackColor = false;
            this.Button_X_2.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_1
            // 
            this.Button_O_1.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_1.Location = new System.Drawing.Point(13, 80);
            this.Button_O_1.Name = "Button_O_1";
            this.Button_O_1.Size = new System.Drawing.Size(109, 30);
            this.Button_O_1.TabIndex = 1;
            this.Button_O_1.Tag = "(0,0,0)";
            this.Button_O_1.Text = "载具夹紧气缸";
            this.Button_O_1.UseVisualStyleBackColor = false;
            this.Button_O_1.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_P_1
            // 
            this.Button_P_1.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_P_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_P_1.Location = new System.Drawing.Point(13, 44);
            this.Button_P_1.Name = "Button_P_1";
            this.Button_P_1.Size = new System.Drawing.Size(109, 30);
            this.Button_P_1.TabIndex = 1;
            this.Button_P_1.Tag = "(0,1,5)";
            this.Button_P_1.Text = "载具破真空";
            this.Button_P_1.UseVisualStyleBackColor = false;
            this.Button_P_1.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_X_1
            // 
            this.Button_X_1.BackColor = System.Drawing.Color.Khaki;
            this.Button_X_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_X_1.Location = new System.Drawing.Point(13, 7);
            this.Button_X_1.Name = "Button_X_1";
            this.Button_X_1.Size = new System.Drawing.Size(109, 30);
            this.Button_X_1.TabIndex = 1;
            this.Button_X_1.Tag = "(0,1,4)";
            this.Button_X_1.Text = "载具真空吸";
            this.Button_X_1.UseVisualStyleBackColor = false;
            this.Button_X_1.Click += new System.EventHandler(this.Btn_All_Click);
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
            // Panel1_Left
            // 
            this.Panel1_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1_Left.Controls.Add(this.label37);
            this.Panel1_Left.Controls.Add(this.Btn_L3Z1);
            this.Panel1_Left.Controls.Add(this.Btn_L2Z1);
            this.Panel1_Left.Controls.Add(this.Btn_L1Z1);
            this.Panel1_Left.Controls.Add(this.Btn_L1AZ);
            this.Panel1_Left.Controls.Add(this.Btn_L2AZ);
            this.Panel1_Left.Controls.Add(this.Btn_L3AZ);
            this.Panel1_Left.Controls.Add(this.Btn_L1AF);
            this.Panel1_Left.Controls.Add(this.Btn_L2AF);
            this.Panel1_Left.Controls.Add(this.Btn_L3AF);
            this.Panel1_Left.Controls.Add(this.Btn_L1AST);
            this.Panel1_Left.Controls.Add(this.Btn_L2AST);
            this.Panel1_Left.Controls.Add(this.Btn_L3AST);
            this.Panel1_Left.Location = new System.Drawing.Point(2, 229);
            this.Panel1_Left.Name = "Panel1_Left";
            this.Panel1_Left.Size = new System.Drawing.Size(716, 106);
            this.Panel1_Left.TabIndex = 80;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(3, 79);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(73, 20);
            this.label37.TabIndex = 4;
            this.label37.Text = "左进右出";
            // 
            // Btn_L3Z1
            // 
            this.Btn_L3Z1.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_L3Z1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3Z1.Location = new System.Drawing.Point(468, 5);
            this.Btn_L3Z1.Name = "Btn_L3Z1";
            this.Btn_L3Z1.Size = new System.Drawing.Size(68, 29);
            this.Btn_L3Z1.TabIndex = 0;
            this.Btn_L3Z1.Tag = "(0,0,14)";
            this.Btn_L3Z1.Text = "阻挡气缸3";
            this.Btn_L3Z1.UseVisualStyleBackColor = false;
            this.Btn_L3Z1.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Btn_L2Z1
            // 
            this.Btn_L2Z1.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_L2Z1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2Z1.Location = new System.Drawing.Point(265, 4);
            this.Btn_L2Z1.Name = "Btn_L2Z1";
            this.Btn_L2Z1.Size = new System.Drawing.Size(68, 29);
            this.Btn_L2Z1.TabIndex = 0;
            this.Btn_L2Z1.Tag = "(0,0,13)";
            this.Btn_L2Z1.Text = "阻挡气缸2";
            this.Btn_L2Z1.UseVisualStyleBackColor = false;
            this.Btn_L2Z1.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Btn_L1Z1
            // 
            this.Btn_L1Z1.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_L1Z1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1Z1.Location = new System.Drawing.Point(58, 3);
            this.Btn_L1Z1.Name = "Btn_L1Z1";
            this.Btn_L1Z1.Size = new System.Drawing.Size(68, 30);
            this.Btn_L1Z1.TabIndex = 0;
            this.Btn_L1Z1.Tag = "(0,0,12)";
            this.Btn_L1Z1.Text = "阻挡气缸1";
            this.Btn_L1Z1.UseVisualStyleBackColor = false;
            this.Btn_L1Z1.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Btn_L1AZ
            // 
            this.Btn_L1AZ.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L1AZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1AZ.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L1AZ.Image")));
            this.Btn_L1AZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L1AZ.Location = new System.Drawing.Point(169, 3);
            this.Btn_L1AZ.Name = "Btn_L1AZ";
            this.Btn_L1AZ.Size = new System.Drawing.Size(90, 30);
            this.Btn_L1AZ.TabIndex = 1;
            this.Btn_L1AZ.Tag = "+";
            this.Btn_L1AZ.Text = "L1 正转";
            this.Btn_L1AZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L1AZ.UseVisualStyleBackColor = false;
            this.Btn_L1AZ.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L2AZ
            // 
            this.Btn_L2AZ.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L2AZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2AZ.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L2AZ.Image")));
            this.Btn_L2AZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L2AZ.Location = new System.Drawing.Point(372, 3);
            this.Btn_L2AZ.Name = "Btn_L2AZ";
            this.Btn_L2AZ.Size = new System.Drawing.Size(90, 30);
            this.Btn_L2AZ.TabIndex = 2;
            this.Btn_L2AZ.Tag = "+";
            this.Btn_L2AZ.Text = "L2上 正转";
            this.Btn_L2AZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L2AZ.UseVisualStyleBackColor = false;
            this.Btn_L2AZ.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L3AZ
            // 
            this.Btn_L3AZ.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L3AZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3AZ.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L3AZ.Image")));
            this.Btn_L3AZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L3AZ.Location = new System.Drawing.Point(616, 3);
            this.Btn_L3AZ.Name = "Btn_L3AZ";
            this.Btn_L3AZ.Size = new System.Drawing.Size(90, 30);
            this.Btn_L3AZ.TabIndex = 3;
            this.Btn_L3AZ.Tag = "+";
            this.Btn_L3AZ.Text = "L3 正转";
            this.Btn_L3AZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L3AZ.UseVisualStyleBackColor = false;
            this.Btn_L3AZ.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L1AF
            // 
            this.Btn_L1AF.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L1AF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1AF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L1AF.Image")));
            this.Btn_L1AF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L1AF.Location = new System.Drawing.Point(169, 36);
            this.Btn_L1AF.Name = "Btn_L1AF";
            this.Btn_L1AF.Size = new System.Drawing.Size(90, 30);
            this.Btn_L1AF.TabIndex = 1;
            this.Btn_L1AF.Tag = "-";
            this.Btn_L1AF.Text = "L1 反转";
            this.Btn_L1AF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L1AF.UseVisualStyleBackColor = false;
            this.Btn_L1AF.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L2AF
            // 
            this.Btn_L2AF.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L2AF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2AF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L2AF.Image")));
            this.Btn_L2AF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L2AF.Location = new System.Drawing.Point(372, 36);
            this.Btn_L2AF.Name = "Btn_L2AF";
            this.Btn_L2AF.Size = new System.Drawing.Size(90, 30);
            this.Btn_L2AF.TabIndex = 2;
            this.Btn_L2AF.Tag = "-";
            this.Btn_L2AF.Text = "L2上 反转";
            this.Btn_L2AF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L2AF.UseVisualStyleBackColor = false;
            this.Btn_L2AF.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L3AF
            // 
            this.Btn_L3AF.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L3AF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3AF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L3AF.Image")));
            this.Btn_L3AF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L3AF.Location = new System.Drawing.Point(616, 36);
            this.Btn_L3AF.Name = "Btn_L3AF";
            this.Btn_L3AF.Size = new System.Drawing.Size(90, 30);
            this.Btn_L3AF.TabIndex = 3;
            this.Btn_L3AF.Tag = "-";
            this.Btn_L3AF.Text = "L3 反转";
            this.Btn_L3AF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L3AF.UseVisualStyleBackColor = false;
            this.Btn_L3AF.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L1AST
            // 
            this.Btn_L1AST.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L1AST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1AST.Location = new System.Drawing.Point(169, 69);
            this.Btn_L1AST.Name = "Btn_L1AST";
            this.Btn_L1AST.Size = new System.Drawing.Size(90, 30);
            this.Btn_L1AST.TabIndex = 1;
            this.Btn_L1AST.Tag = "0";
            this.Btn_L1AST.Text = "L1 停止";
            this.Btn_L1AST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L1AST.UseVisualStyleBackColor = false;
            this.Btn_L1AST.Click += new System.EventHandler(this.Btn_L1AST_Click);
            // 
            // Btn_L2AST
            // 
            this.Btn_L2AST.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L2AST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2AST.Location = new System.Drawing.Point(372, 69);
            this.Btn_L2AST.Name = "Btn_L2AST";
            this.Btn_L2AST.Size = new System.Drawing.Size(90, 30);
            this.Btn_L2AST.TabIndex = 2;
            this.Btn_L2AST.Tag = "0";
            this.Btn_L2AST.Text = "L2上 停止";
            this.Btn_L2AST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L2AST.UseVisualStyleBackColor = false;
            this.Btn_L2AST.Click += new System.EventHandler(this.Btn_L1AST_Click);
            // 
            // Btn_L3AST
            // 
            this.Btn_L3AST.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L3AST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3AST.Location = new System.Drawing.Point(616, 69);
            this.Btn_L3AST.Name = "Btn_L3AST";
            this.Btn_L3AST.Size = new System.Drawing.Size(90, 30);
            this.Btn_L3AST.TabIndex = 3;
            this.Btn_L3AST.Tag = "0";
            this.Btn_L3AST.Text = "L3 停止";
            this.Btn_L3AST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L3AST.UseVisualStyleBackColor = false;
            this.Btn_L3AST.Click += new System.EventHandler(this.Btn_L1AST_Click);
            // 
            // Panel1_Right
            // 
            this.Panel1_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1_Right.Controls.Add(this.label38);
            this.Panel1_Right.Controls.Add(this.Btn_L3Z1N);
            this.Panel1_Right.Controls.Add(this.Btn_L2Z1N);
            this.Panel1_Right.Controls.Add(this.Btn_L1Z1N);
            this.Panel1_Right.Controls.Add(this.Btn_L1BZ);
            this.Panel1_Right.Controls.Add(this.Btn_L2BZ);
            this.Panel1_Right.Controls.Add(this.Btn_L3BZ);
            this.Panel1_Right.Controls.Add(this.Btn_L1BF);
            this.Panel1_Right.Controls.Add(this.Btn_L2BF);
            this.Panel1_Right.Controls.Add(this.Btn_L3BF);
            this.Panel1_Right.Controls.Add(this.Btn_L1BST);
            this.Panel1_Right.Controls.Add(this.Btn_L2BST);
            this.Panel1_Right.Controls.Add(this.Btn_L3BST);
            this.Panel1_Right.Location = new System.Drawing.Point(2, 229);
            this.Panel1_Right.Name = "Panel1_Right";
            this.Panel1_Right.Size = new System.Drawing.Size(716, 106);
            this.Panel1_Right.TabIndex = 81;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Red;
            this.label38.Location = new System.Drawing.Point(638, 79);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 20);
            this.label38.TabIndex = 4;
            this.label38.Text = "右进左出";
            // 
            // Btn_L3Z1N
            // 
            this.Btn_L3Z1N.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_L3Z1N.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3Z1N.Location = new System.Drawing.Point(150, 4);
            this.Btn_L3Z1N.Name = "Btn_L3Z1N";
            this.Btn_L3Z1N.Size = new System.Drawing.Size(68, 29);
            this.Btn_L3Z1N.TabIndex = 0;
            this.Btn_L3Z1N.Tag = "(0,0,14)";
            this.Btn_L3Z1N.Text = "阻挡气缸3";
            this.Btn_L3Z1N.UseVisualStyleBackColor = false;
            this.Btn_L3Z1N.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Btn_L2Z1N
            // 
            this.Btn_L2Z1N.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_L2Z1N.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2Z1N.Location = new System.Drawing.Point(369, 6);
            this.Btn_L2Z1N.Name = "Btn_L2Z1N";
            this.Btn_L2Z1N.Size = new System.Drawing.Size(68, 29);
            this.Btn_L2Z1N.TabIndex = 0;
            this.Btn_L2Z1N.Tag = "(0,0,13)";
            this.Btn_L2Z1N.Text = "阻挡气缸2";
            this.Btn_L2Z1N.UseVisualStyleBackColor = false;
            this.Btn_L2Z1N.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Btn_L1Z1N
            // 
            this.Btn_L1Z1N.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_L1Z1N.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1Z1N.Location = new System.Drawing.Point(563, 3);
            this.Btn_L1Z1N.Name = "Btn_L1Z1N";
            this.Btn_L1Z1N.Size = new System.Drawing.Size(68, 30);
            this.Btn_L1Z1N.TabIndex = 0;
            this.Btn_L1Z1N.Tag = "(0,0,12)";
            this.Btn_L1Z1N.Text = "阻挡气缸1";
            this.Btn_L1Z1N.UseVisualStyleBackColor = false;
            this.Btn_L1Z1N.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Btn_L1BZ
            // 
            this.Btn_L1BZ.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L1BZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1BZ.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L1BZ.Image")));
            this.Btn_L1BZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L1BZ.Location = new System.Drawing.Point(12, 3);
            this.Btn_L1BZ.Name = "Btn_L1BZ";
            this.Btn_L1BZ.Size = new System.Drawing.Size(90, 30);
            this.Btn_L1BZ.TabIndex = 1;
            this.Btn_L1BZ.Tag = "+";
            this.Btn_L1BZ.Text = "L3 正转";
            this.Btn_L1BZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L1BZ.UseVisualStyleBackColor = false;
            this.Btn_L1BZ.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L2BZ
            // 
            this.Btn_L2BZ.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L2BZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2BZ.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L2BZ.Image")));
            this.Btn_L2BZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L2BZ.Location = new System.Drawing.Point(224, 3);
            this.Btn_L2BZ.Name = "Btn_L2BZ";
            this.Btn_L2BZ.Size = new System.Drawing.Size(90, 30);
            this.Btn_L2BZ.TabIndex = 2;
            this.Btn_L2BZ.Tag = "+";
            this.Btn_L2BZ.Text = "L2上 正转";
            this.Btn_L2BZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L2BZ.UseVisualStyleBackColor = false;
            this.Btn_L2BZ.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L3BZ
            // 
            this.Btn_L3BZ.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L3BZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3BZ.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L3BZ.Image")));
            this.Btn_L3BZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L3BZ.Location = new System.Drawing.Point(446, 3);
            this.Btn_L3BZ.Name = "Btn_L3BZ";
            this.Btn_L3BZ.Size = new System.Drawing.Size(90, 30);
            this.Btn_L3BZ.TabIndex = 3;
            this.Btn_L3BZ.Tag = "+";
            this.Btn_L3BZ.Text = "L1 正转";
            this.Btn_L3BZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L3BZ.UseVisualStyleBackColor = false;
            this.Btn_L3BZ.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L1BF
            // 
            this.Btn_L1BF.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L1BF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1BF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L1BF.Image")));
            this.Btn_L1BF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L1BF.Location = new System.Drawing.Point(12, 36);
            this.Btn_L1BF.Name = "Btn_L1BF";
            this.Btn_L1BF.Size = new System.Drawing.Size(90, 30);
            this.Btn_L1BF.TabIndex = 1;
            this.Btn_L1BF.Tag = "-";
            this.Btn_L1BF.Text = "L3 反转";
            this.Btn_L1BF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L1BF.UseVisualStyleBackColor = false;
            this.Btn_L1BF.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L2BF
            // 
            this.Btn_L2BF.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L2BF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2BF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L2BF.Image")));
            this.Btn_L2BF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L2BF.Location = new System.Drawing.Point(224, 36);
            this.Btn_L2BF.Name = "Btn_L2BF";
            this.Btn_L2BF.Size = new System.Drawing.Size(90, 30);
            this.Btn_L2BF.TabIndex = 2;
            this.Btn_L2BF.Tag = "-";
            this.Btn_L2BF.Text = "L2上 反转";
            this.Btn_L2BF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L2BF.UseVisualStyleBackColor = false;
            this.Btn_L2BF.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L3BF
            // 
            this.Btn_L3BF.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L3BF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3BF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_L3BF.Image")));
            this.Btn_L3BF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_L3BF.Location = new System.Drawing.Point(446, 36);
            this.Btn_L3BF.Name = "Btn_L3BF";
            this.Btn_L3BF.Size = new System.Drawing.Size(90, 30);
            this.Btn_L3BF.TabIndex = 3;
            this.Btn_L3BF.Tag = "-";
            this.Btn_L3BF.Text = "L1 反转";
            this.Btn_L3BF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L3BF.UseVisualStyleBackColor = false;
            this.Btn_L3BF.Click += new System.EventHandler(this.Btn_L1D_Click);
            // 
            // Btn_L1BST
            // 
            this.Btn_L1BST.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L1BST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L1BST.Location = new System.Drawing.Point(12, 69);
            this.Btn_L1BST.Name = "Btn_L1BST";
            this.Btn_L1BST.Size = new System.Drawing.Size(90, 30);
            this.Btn_L1BST.TabIndex = 1;
            this.Btn_L1BST.Tag = "0";
            this.Btn_L1BST.Text = "L3 停止";
            this.Btn_L1BST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L1BST.UseVisualStyleBackColor = false;
            this.Btn_L1BST.Click += new System.EventHandler(this.Btn_L1AST_Click);
            // 
            // Btn_L2BST
            // 
            this.Btn_L2BST.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L2BST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L2BST.Location = new System.Drawing.Point(224, 69);
            this.Btn_L2BST.Name = "Btn_L2BST";
            this.Btn_L2BST.Size = new System.Drawing.Size(90, 30);
            this.Btn_L2BST.TabIndex = 2;
            this.Btn_L2BST.Tag = "0";
            this.Btn_L2BST.Text = "L2上 停止";
            this.Btn_L2BST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L2BST.UseVisualStyleBackColor = false;
            this.Btn_L2BST.Click += new System.EventHandler(this.Btn_L1AST_Click);
            // 
            // Btn_L3BST
            // 
            this.Btn_L3BST.BackColor = System.Drawing.Color.Wheat;
            this.Btn_L3BST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_L3BST.Location = new System.Drawing.Point(446, 69);
            this.Btn_L3BST.Name = "Btn_L3BST";
            this.Btn_L3BST.Size = new System.Drawing.Size(90, 30);
            this.Btn_L3BST.TabIndex = 3;
            this.Btn_L3BST.Tag = "0";
            this.Btn_L3BST.Text = "L1 停止";
            this.Btn_L3BST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_L3BST.UseVisualStyleBackColor = false;
            this.Btn_L3BST.Click += new System.EventHandler(this.Btn_L1AST_Click);
            // 
            // 校正页面
            // 
            this.校正页面.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.校正页面.Controls.Add(this.Panel_Calibration);
            this.校正页面.Location = new System.Drawing.Point(4, 29);
            this.校正页面.Name = "校正页面";
            this.校正页面.Padding = new System.Windows.Forms.Padding(3);
            this.校正页面.Size = new System.Drawing.Size(992, 504);
            this.校正页面.TabIndex = 1;
            this.校正页面.Text = "校正页面";
            // 
            // Panel_Calibration
            // 
            this.Panel_Calibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel_Calibration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Calibration.Controls.Add(this.GroupBox14);
            this.Panel_Calibration.Controls.Add(this.infoList2);
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
            // GroupBox14
            // 
            this.GroupBox14.Controls.Add(this.Label18);
            this.GroupBox14.Controls.Add(this.Label19);
            this.GroupBox14.Controls.Add(this.Text_Force2);
            this.GroupBox14.Controls.Add(this.Btn_OpenSerial2);
            this.GroupBox14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox14.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox14.Location = new System.Drawing.Point(362, 404);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new System.Drawing.Size(223, 74);
            this.GroupBox14.TabIndex = 62;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "校正";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(122, 28);
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
            this.Label19.Location = new System.Drawing.Point(10, 28);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(49, 14);
            this.Label19.TabIndex = 7;
            this.Label19.Text = "Value:";
            // 
            // Text_Force2
            // 
            this.Text_Force2.BackColor = System.Drawing.Color.Black;
            this.Text_Force2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Force2.ForeColor = System.Drawing.Color.Lime;
            this.Text_Force2.Location = new System.Drawing.Point(60, 22);
            this.Text_Force2.Name = "Text_Force2";
            this.Text_Force2.ReadOnly = true;
            this.Text_Force2.Size = new System.Drawing.Size(60, 26);
            this.Text_Force2.TabIndex = 6;
            this.Text_Force2.Text = "0.00";
            this.Text_Force2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_OpenSerial2
            // 
            this.Btn_OpenSerial2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenSerial2.ForeColor = System.Drawing.Color.Black;
            this.Btn_OpenSerial2.Location = new System.Drawing.Point(156, 22);
            this.Btn_OpenSerial2.Name = "Btn_OpenSerial2";
            this.Btn_OpenSerial2.Size = new System.Drawing.Size(59, 32);
            this.Btn_OpenSerial2.TabIndex = 3;
            this.Btn_OpenSerial2.Text = "Open";
            this.Btn_OpenSerial2.UseVisualStyleBackColor = true;
            this.Btn_OpenSerial2.Click += new System.EventHandler(this.Btn_OpenSerial2_Click);
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
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.Button_TestStop);
            this.GroupBox6.Controls.Add(this.Panel_Test);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(328, 5);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(267, 145);
            this.GroupBox6.TabIndex = 50;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "动静态测试";
            // 
            // Button_TestStop
            // 
            this.Button_TestStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TestStop.Location = new System.Drawing.Point(143, 116);
            this.Button_TestStop.Name = "Button_TestStop";
            this.Button_TestStop.Size = new System.Drawing.Size(65, 29);
            this.Button_TestStop.TabIndex = 87;
            this.Button_TestStop.Tag = "2";
            this.Button_TestStop.Text = "结束";
            this.Button_TestStop.UseVisualStyleBackColor = true;
            this.Button_TestStop.Click += new System.EventHandler(this.Button_TestStop_Click);
            // 
            // Panel_Test
            // 
            this.Panel_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Test.Controls.Add(this.Combox_CCDTest);
            this.Panel_Test.Controls.Add(this.Label42);
            this.Panel_Test.Controls.Add(this.TextBox_Num);
            this.Panel_Test.Controls.Add(this.Button_Test);
            this.Panel_Test.Location = new System.Drawing.Point(10, 31);
            this.Panel_Test.Name = "Panel_Test";
            this.Panel_Test.Size = new System.Drawing.Size(251, 72);
            this.Panel_Test.TabIndex = 48;
            // 
            // Combox_CCDTest
            // 
            this.Combox_CCDTest.FormattingEnabled = true;
            this.Combox_CCDTest.Items.AddRange(new object[] {
            "相机1（T11,1）静态测试",
            "相机1（T11,1）动态测试",
            "相机2（T21,1）静态测试",
            "相机2（T21,1）动态测试",
            "相机3（T31,1）静态测试",
            "",
            "相机4（T41,1）静态测试"});
            this.Combox_CCDTest.Location = new System.Drawing.Point(3, 3);
            this.Combox_CCDTest.Name = "Combox_CCDTest";
            this.Combox_CCDTest.Size = new System.Drawing.Size(243, 25);
            this.Combox_CCDTest.TabIndex = 86;
            this.Combox_CCDTest.Text = "相机1（T11,1）静态测试";
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Location = new System.Drawing.Point(69, 37);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(22, 17);
            this.Label42.TabIndex = 84;
            this.Label42.Text = "次";
            // 
            // TextBox_Num
            // 
            this.TextBox_Num.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Num.Location = new System.Drawing.Point(3, 36);
            this.TextBox_Num.Name = "TextBox_Num";
            this.TextBox_Num.Size = new System.Drawing.Size(60, 23);
            this.TextBox_Num.TabIndex = 83;
            this.TextBox_Num.Text = "35";
            this.TextBox_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_Test
            // 
            this.Button_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Test.Location = new System.Drawing.Point(132, 34);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(65, 29);
            this.Button_Test.TabIndex = 3;
            this.Button_Test.Tag = "2";
            this.Button_Test.Text = "开始";
            this.Button_Test.UseVisualStyleBackColor = true;
            this.Button_Test.Click += new System.EventHandler(this.Btn_CCDTest_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Button_CalibrationStop);
            this.GroupBox5.Controls.Add(this.PanelCalibration);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(3, 5);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(267, 145);
            this.GroupBox5.TabIndex = 49;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "相机标定";
            // 
            // Button_CalibrationStop
            // 
            this.Button_CalibrationStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CalibrationStop.Location = new System.Drawing.Point(148, 116);
            this.Button_CalibrationStop.Name = "Button_CalibrationStop";
            this.Button_CalibrationStop.Size = new System.Drawing.Size(65, 29);
            this.Button_CalibrationStop.TabIndex = 88;
            this.Button_CalibrationStop.Tag = "2";
            this.Button_CalibrationStop.Text = "结束";
            this.Button_CalibrationStop.UseVisualStyleBackColor = true;
            this.Button_CalibrationStop.Click += new System.EventHandler(this.Button_TestStop_Click);
            // 
            // PanelCalibration
            // 
            this.PanelCalibration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCalibration.Controls.Add(this.Combox_CCD_COR);
            this.PanelCalibration.Controls.Add(this.Btn_CalibrationList);
            this.PanelCalibration.Location = new System.Drawing.Point(10, 31);
            this.PanelCalibration.Name = "PanelCalibration";
            this.PanelCalibration.Size = new System.Drawing.Size(251, 72);
            this.PanelCalibration.TabIndex = 48;
            // 
            // Combox_CCD_COR
            // 
            this.Combox_CCD_COR.FormattingEnabled = true;
            this.Combox_CCD_COR.Items.AddRange(new object[] {
            "0.取料相机标定",
            "1.联合标定"});
            this.Combox_CCD_COR.Location = new System.Drawing.Point(2, 3);
            this.Combox_CCD_COR.Name = "Combox_CCD_COR";
            this.Combox_CCD_COR.Size = new System.Drawing.Size(243, 25);
            this.Combox_CCD_COR.TabIndex = 85;
            this.Combox_CCD_COR.Text = "0.取料相机标定";
            // 
            // Btn_CalibrationList
            // 
            this.Btn_CalibrationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_CalibrationList.Location = new System.Drawing.Point(137, 34);
            this.Btn_CalibrationList.Name = "Btn_CalibrationList";
            this.Btn_CalibrationList.Size = new System.Drawing.Size(65, 29);
            this.Btn_CalibrationList.TabIndex = 3;
            this.Btn_CalibrationList.Tag = "2";
            this.Btn_CalibrationList.Text = "开始";
            this.Btn_CalibrationList.UseVisualStyleBackColor = true;
            this.Btn_CalibrationList.Click += new System.EventHandler(this.Btn_CalibrationList_Click);
            // 
            // Panel19
            // 
            this.Panel19.Controls.Add(this.Trigger);
            this.Panel19.Controls.Add(this.Label_PDCA_Step);
            this.Panel19.Controls.Add(this.Button_OpenPDCAlog);
            this.Panel19.Controls.Add(this.Label26);
            this.Panel19.Controls.Add(this.Txt_MBarCode);
            this.Panel19.Controls.Add(this.Btn_PDCATest);
            this.Panel19.Location = new System.Drawing.Point(19, 381);
            this.Panel19.Name = "Panel19";
            this.Panel19.Size = new System.Drawing.Size(312, 106);
            this.Panel19.TabIndex = 15;
            // 
            // Trigger
            // 
            this.Trigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Trigger.Location = new System.Drawing.Point(233, 63);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(68, 32);
            this.Trigger.TabIndex = 19;
            this.Trigger.Text = "触发";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.buttonTrigger_Click);
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
            // Button_OpenPDCAlog
            // 
            this.Button_OpenPDCAlog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_OpenPDCAlog.Location = new System.Drawing.Point(132, 63);
            this.Button_OpenPDCAlog.Name = "Button_OpenPDCAlog";
            this.Button_OpenPDCAlog.Size = new System.Drawing.Size(87, 32);
            this.Button_OpenPDCAlog.TabIndex = 17;
            this.Button_OpenPDCAlog.Text = "查看运行Log";
            this.Button_OpenPDCAlog.UseVisualStyleBackColor = true;
            this.Button_OpenPDCAlog.Click += new System.EventHandler(this.Button_OpenPDCAlog_Click);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(10, 23);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(65, 15);
            this.Label26.TabIndex = 15;
            this.Label26.Text = "Barcode：";
            // 
            // Txt_MBarCode
            // 
            this.Txt_MBarCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_MBarCode.Location = new System.Drawing.Point(95, 22);
            this.Txt_MBarCode.Name = "Txt_MBarCode";
            this.Txt_MBarCode.Size = new System.Drawing.Size(198, 21);
            this.Txt_MBarCode.TabIndex = 13;
            this.Txt_MBarCode.Text = "C076427002JHKJR7";
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
            this.Btn_PDCATest.Click += new System.EventHandler(this.Btn_PDCATest_Click);
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
            // 搬运料盘
            // 
            this.搬运料盘.Controls.Add(this.groupBox12);
            this.搬运料盘.Controls.Add(this.panel12);
            this.搬运料盘.Controls.Add(this.Teach2);
            this.搬运料盘.Controls.Add(this.Teach1);
            this.搬运料盘.Location = new System.Drawing.Point(4, 29);
            this.搬运料盘.Name = "搬运料盘";
            this.搬运料盘.Size = new System.Drawing.Size(999, 567);
            this.搬运料盘.TabIndex = 8;
            this.搬运料盘.Text = "搬运料盘";
            this.搬运料盘.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.button5);
            this.groupBox12.Controls.Add(this.button6);
            this.groupBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox12.Location = new System.Drawing.Point(495, 353);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(251, 144);
            this.groupBox12.TabIndex = 72;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "单站调试";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(55, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 30);
            this.button2.TabIndex = 110;
            this.button2.Text = "自动换料盘";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(140, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "停止";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.BurlyWood;
            this.button6.Location = new System.Drawing.Point(35, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 29);
            this.button6.TabIndex = 0;
            this.button6.Text = "暂停";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.Button_O_7);
            this.panel12.Controls.Add(this.Button_O_6);
            this.panel12.Controls.Add(this.Button_O_13);
            this.panel12.Controls.Add(this.Button_O_12);
            this.panel12.Controls.Add(this.label39);
            this.panel12.Controls.Add(this.textBox5);
            this.panel12.Location = new System.Drawing.Point(3, 353);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(486, 145);
            this.panel12.TabIndex = 71;
            // 
            // Button_O_7
            // 
            this.Button_O_7.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_7.Location = new System.Drawing.Point(152, 105);
            this.Button_O_7.Name = "Button_O_7";
            this.Button_O_7.Size = new System.Drawing.Size(109, 30);
            this.Button_O_7.TabIndex = 1;
            this.Button_O_7.Tag = "(0,1,15)";
            this.Button_O_7.Text = "右料盘吸电磁铁";
            this.Button_O_7.UseVisualStyleBackColor = false;
            this.Button_O_7.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_6
            // 
            this.Button_O_6.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_6.Location = new System.Drawing.Point(18, 105);
            this.Button_O_6.Name = "Button_O_6";
            this.Button_O_6.Size = new System.Drawing.Size(109, 30);
            this.Button_O_6.TabIndex = 1;
            this.Button_O_6.Tag = "(0,1,14)";
            this.Button_O_6.Text = "左料盘吸电磁铁";
            this.Button_O_6.UseVisualStyleBackColor = false;
            this.Button_O_6.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_13
            // 
            this.Button_O_13.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_13.Location = new System.Drawing.Point(152, 6);
            this.Button_O_13.Name = "Button_O_13";
            this.Button_O_13.Size = new System.Drawing.Size(109, 30);
            this.Button_O_13.TabIndex = 1;
            this.Button_O_13.Tag = "(0,2,13)";
            this.Button_O_13.Text = "料盘搬运气缸";
            this.Button_O_13.UseVisualStyleBackColor = false;
            this.Button_O_13.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_12
            // 
            this.Button_O_12.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_12.Location = new System.Drawing.Point(18, 6);
            this.Button_O_12.Name = "Button_O_12";
            this.Button_O_12.Size = new System.Drawing.Size(109, 30);
            this.Button_O_12.TabIndex = 1;
            this.Button_O_12.Tag = "(0,2,11)";
            this.Button_O_12.Text = "料盘夹紧气缸";
            this.Button_O_12.UseVisualStyleBackColor = false;
            this.Button_O_12.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(845, 191);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 17);
            this.label39.TabIndex = 43;
            this.label39.Text = "Kgf";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightGreen;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(753, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 23);
            this.textBox5.TabIndex = 42;
            this.textBox5.Text = "0.00";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Teach2
            // 
            this.Teach2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach2.Location = new System.Drawing.Point(495, 3);
            this.Teach2.Name = "Teach2";
            this.Teach2.Size = new System.Drawing.Size(486, 332);
            this.Teach2.TabIndex = 70;
            this.Teach2.Tag = "2";
            // 
            // Teach1
            // 
            this.Teach1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach1.Location = new System.Drawing.Point(3, 3);
            this.Teach1.Name = "Teach1";
            this.Teach1.Size = new System.Drawing.Size(486, 332);
            this.Teach1.TabIndex = 69;
            this.Teach1.Tag = "1";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox16);
            this.tabPage8.Controls.Add(this.panel_S2g);
            this.tabPage8.Controls.Add(this.Teach3);
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(999, 567);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Tag = "3";
            this.tabPage8.Text = "PSA供料   ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.CommandAutoS0);
            this.groupBox16.Controls.Add(this.CmdStopS0);
            this.groupBox16.Controls.Add(this.CmdHoldS0);
            this.groupBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox16.Location = new System.Drawing.Point(495, 41);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(205, 144);
            this.groupBox16.TabIndex = 130;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "供料调试";
            // 
            // CommandAutoS0
            // 
            this.CommandAutoS0.BackColor = System.Drawing.Color.Tomato;
            this.CommandAutoS0.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandAutoS0.Location = new System.Drawing.Point(40, 97);
            this.CommandAutoS0.Name = "CommandAutoS0";
            this.CommandAutoS0.Size = new System.Drawing.Size(126, 30);
            this.CommandAutoS0.TabIndex = 110;
            this.CommandAutoS0.Text = "PSA供料运行";
            this.CommandAutoS0.UseVisualStyleBackColor = false;
            this.CommandAutoS0.Click += new System.EventHandler(this.CommandAutoS0_Click);
            // 
            // CmdStopS0
            // 
            this.CmdStopS0.Location = new System.Drawing.Point(130, 35);
            this.CmdStopS0.Name = "CmdStopS0";
            this.CmdStopS0.Size = new System.Drawing.Size(59, 29);
            this.CmdStopS0.TabIndex = 1;
            this.CmdStopS0.TabStop = false;
            this.CmdStopS0.Text = "停止";
            this.CmdStopS0.UseVisualStyleBackColor = true;
            this.CmdStopS0.Click += new System.EventHandler(this.CmdStopS0_Click);
            // 
            // CmdHoldS0
            // 
            this.CmdHoldS0.BackColor = System.Drawing.Color.BurlyWood;
            this.CmdHoldS0.Location = new System.Drawing.Point(21, 35);
            this.CmdHoldS0.Name = "CmdHoldS0";
            this.CmdHoldS0.Size = new System.Drawing.Size(59, 29);
            this.CmdHoldS0.TabIndex = 0;
            this.CmdHoldS0.Text = "暂停";
            this.CmdHoldS0.UseVisualStyleBackColor = false;
            this.CmdHoldS0.Click += new System.EventHandler(this.CmdHoldS0_Click);
            // 
            // panel_S2g
            // 
            this.panel_S2g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_S2g.Controls.Add(this.Button_O_9);
            this.panel_S2g.Controls.Add(this.Button_O_10);
            this.panel_S2g.Controls.Add(this.Button_O_8);
            this.panel_S2g.Controls.Add(this.Button_X_5);
            this.panel_S2g.Controls.Add(this.Button_P_6);
            this.panel_S2g.Controls.Add(this.Button_P_5);
            this.panel_S2g.Controls.Add(this.Button_X_6);
            this.panel_S2g.Controls.Add(this.label2);
            this.panel_S2g.Controls.Add(this.textBox1);
            this.panel_S2g.Location = new System.Drawing.Point(3, 341);
            this.panel_S2g.Name = "panel_S2g";
            this.panel_S2g.Size = new System.Drawing.Size(486, 192);
            this.panel_S2g.TabIndex = 69;
            // 
            // Button_O_9
            // 
            this.Button_O_9.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_9.Location = new System.Drawing.Point(121, 109);
            this.Button_O_9.Name = "Button_O_9";
            this.Button_O_9.Size = new System.Drawing.Size(109, 30);
            this.Button_O_9.TabIndex = 1;
            this.Button_O_9.Tag = "(0,0,8)";
            this.Button_O_9.Text = "撕膜夹爪气缸";
            this.Button_O_9.UseVisualStyleBackColor = false;
            this.Button_O_9.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_10
            // 
            this.Button_O_10.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_10.Location = new System.Drawing.Point(6, 157);
            this.Button_O_10.Name = "Button_O_10";
            this.Button_O_10.Size = new System.Drawing.Size(109, 30);
            this.Button_O_10.TabIndex = 1;
            this.Button_O_10.Tag = "(0,0,10)";
            this.Button_O_10.Text = "料仓夹紧气缸";
            this.Button_O_10.UseVisualStyleBackColor = false;
            this.Button_O_10.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_8
            // 
            this.Button_O_8.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_8.Location = new System.Drawing.Point(6, 108);
            this.Button_O_8.Name = "Button_O_8";
            this.Button_O_8.Size = new System.Drawing.Size(109, 30);
            this.Button_O_8.TabIndex = 1;
            this.Button_O_8.Tag = "(0,0,12)";
            this.Button_O_8.Text = "吸嘴升降气缸";
            this.Button_O_8.UseVisualStyleBackColor = false;
            this.Button_O_8.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_X_5
            // 
            this.Button_X_5.BackColor = System.Drawing.Color.Khaki;
            this.Button_X_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_X_5.Location = new System.Drawing.Point(6, 1);
            this.Button_X_5.Name = "Button_X_5";
            this.Button_X_5.Size = new System.Drawing.Size(109, 30);
            this.Button_X_5.TabIndex = 1;
            this.Button_X_5.Tag = "(0,1,0)";
            this.Button_X_5.Text = "PSA载台真空吸";
            this.Button_X_5.UseVisualStyleBackColor = false;
            this.Button_X_5.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_P_6
            // 
            this.Button_P_6.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_P_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_P_6.Location = new System.Drawing.Point(121, 37);
            this.Button_P_6.Name = "Button_P_6";
            this.Button_P_6.Size = new System.Drawing.Size(109, 30);
            this.Button_P_6.TabIndex = 1;
            this.Button_P_6.Tag = "(0,1,3)";
            this.Button_P_6.Text = "搬运PSA破真空";
            this.Button_P_6.UseVisualStyleBackColor = false;
            this.Button_P_6.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_P_5
            // 
            this.Button_P_5.BackColor = System.Drawing.Color.LightSalmon;
            this.Button_P_5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_P_5.Location = new System.Drawing.Point(6, 37);
            this.Button_P_5.Name = "Button_P_5";
            this.Button_P_5.Size = new System.Drawing.Size(109, 30);
            this.Button_P_5.TabIndex = 1;
            this.Button_P_5.Tag = "(0,1,1)";
            this.Button_P_5.Text = "PSA载台破真空";
            this.Button_P_5.UseVisualStyleBackColor = false;
            this.Button_P_5.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_X_6
            // 
            this.Button_X_6.BackColor = System.Drawing.Color.Khaki;
            this.Button_X_6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_X_6.Location = new System.Drawing.Point(121, 1);
            this.Button_X_6.Name = "Button_X_6";
            this.Button_X_6.Size = new System.Drawing.Size(109, 30);
            this.Button_X_6.TabIndex = 1;
            this.Button_X_6.Tag = "(0,1,2)";
            this.Button_X_6.Text = "搬运PSA真空吸";
            this.Button_X_6.UseVisualStyleBackColor = false;
            this.Button_X_6.Click += new System.EventHandler(this.Btn_All_Click);
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
            // 保压站
            // 
            this.保压站.Controls.Add(this.textBox3);
            this.保压站.Controls.Add(this.groupBox10);
            this.保压站.Controls.Add(this.panel4);
            this.保压站.Controls.Add(this.groupBox7);
            this.保压站.Controls.Add(this.Teach4);
            this.保压站.Location = new System.Drawing.Point(4, 29);
            this.保压站.Name = "保压站";
            this.保压站.Size = new System.Drawing.Size(999, 567);
            this.保压站.TabIndex = 6;
            this.保压站.Text = "保压站";
            this.保压站.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(594, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 26);
            this.textBox3.TabIndex = 52;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.Text_Force1);
            this.groupBox10.Controls.Add(this.Btn_OpenSerial1);
            this.groupBox10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox10.ForeColor = System.Drawing.Color.Blue;
            this.groupBox10.Location = new System.Drawing.Point(510, 349);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(223, 80);
            this.groupBox10.TabIndex = 51;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "保压";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(117, 35);
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
            this.label7.Location = new System.Drawing.Point(5, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Value:";
            // 
            // Text_Force1
            // 
            this.Text_Force1.BackColor = System.Drawing.Color.Black;
            this.Text_Force1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_Force1.ForeColor = System.Drawing.Color.Lime;
            this.Text_Force1.Location = new System.Drawing.Point(55, 29);
            this.Text_Force1.Name = "Text_Force1";
            this.Text_Force1.ReadOnly = true;
            this.Text_Force1.Size = new System.Drawing.Size(60, 26);
            this.Text_Force1.TabIndex = 6;
            this.Text_Force1.Text = "0.00";
            this.Text_Force1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_OpenSerial1
            // 
            this.Btn_OpenSerial1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenSerial1.ForeColor = System.Drawing.Color.Black;
            this.Btn_OpenSerial1.Location = new System.Drawing.Point(156, 29);
            this.Btn_OpenSerial1.Name = "Btn_OpenSerial1";
            this.Btn_OpenSerial1.Size = new System.Drawing.Size(59, 32);
            this.Btn_OpenSerial1.TabIndex = 3;
            this.Btn_OpenSerial1.Text = "Open";
            this.Btn_OpenSerial1.UseVisualStyleBackColor = true;
            this.Btn_OpenSerial1.Click += new System.EventHandler(this.Btn_OpenSerial1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Button_J_1);
            this.panel4.Controls.Add(this.Button_O_11);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(3, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 182);
            this.panel4.TabIndex = 50;
            // 
            // Button_J_1
            // 
            this.Button_J_1.BackColor = System.Drawing.Color.Gold;
            this.Button_J_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_J_1.Location = new System.Drawing.Point(18, 3);
            this.Button_J_1.Name = "Button_J_1";
            this.Button_J_1.Size = new System.Drawing.Size(109, 30);
            this.Button_J_1.TabIndex = 0;
            this.Button_J_1.Tag = "(0,0,9)";
            this.Button_J_1.Text = "步进电机使能";
            this.Button_J_1.UseVisualStyleBackColor = false;
            this.Button_J_1.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // Button_O_11
            // 
            this.Button_O_11.BackColor = System.Drawing.Color.LightGreen;
            this.Button_O_11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_O_11.Location = new System.Drawing.Point(18, 57);
            this.Button_O_11.Name = "Button_O_11";
            this.Button_O_11.Size = new System.Drawing.Size(109, 30);
            this.Button_O_11.TabIndex = 1;
            this.Button_O_11.Tag = "(0,0,2)";
            this.Button_O_11.Text = "保压平移气缸";
            this.Button_O_11.UseVisualStyleBackColor = false;
            this.Button_O_11.Click += new System.EventHandler(this.Btn_All_Click);
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
            this.groupBox7.Controls.Add(this.CommandAutoPress);
            this.groupBox7.Controls.Add(this.CmdStopPress);
            this.groupBox7.Controls.Add(this.CmdHoldPress);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(510, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 144);
            this.groupBox7.TabIndex = 48;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "单站调试";
            // 
            // CommandAutoPress
            // 
            this.CommandAutoPress.BackColor = System.Drawing.Color.Tomato;
            this.CommandAutoPress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandAutoPress.Location = new System.Drawing.Point(55, 97);
            this.CommandAutoPress.Name = "CommandAutoPress";
            this.CommandAutoPress.Size = new System.Drawing.Size(126, 30);
            this.CommandAutoPress.TabIndex = 110;
            this.CommandAutoPress.Text = "保压单站运行";
            this.CommandAutoPress.UseVisualStyleBackColor = false;
            this.CommandAutoPress.Click += new System.EventHandler(this.CommandAutoS3_Click);
            // 
            // CmdStopPress
            // 
            this.CmdStopPress.Location = new System.Drawing.Point(140, 35);
            this.CmdStopPress.Name = "CmdStopPress";
            this.CmdStopPress.Size = new System.Drawing.Size(59, 29);
            this.CmdStopPress.TabIndex = 1;
            this.CmdStopPress.Text = "停止";
            this.CmdStopPress.UseVisualStyleBackColor = true;
            this.CmdStopPress.Click += new System.EventHandler(this.CmdStopS3_Click);
            // 
            // CmdHoldPress
            // 
            this.CmdHoldPress.BackColor = System.Drawing.Color.BurlyWood;
            this.CmdHoldPress.Location = new System.Drawing.Point(35, 35);
            this.CmdHoldPress.Name = "CmdHoldPress";
            this.CmdHoldPress.Size = new System.Drawing.Size(59, 29);
            this.CmdHoldPress.TabIndex = 0;
            this.CmdHoldPress.Text = "暂停";
            this.CmdHoldPress.UseVisualStyleBackColor = false;
            this.CmdHoldPress.Click += new System.EventHandler(this.CmdHoldS3_Click);
            // 
            // Teach4
            // 
            this.Teach4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teach4.Location = new System.Drawing.Point(3, 3);
            this.Teach4.Name = "Teach4";
            this.Teach4.Size = new System.Drawing.Size(486, 332);
            this.Teach4.TabIndex = 2;
            this.Teach4.Tag = "4";
            // 
            // 机械参数
            // 
            this.机械参数.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.机械参数.Controls.Add(this.Button62);
            this.机械参数.Controls.Add(this.Button61);
            this.机械参数.Controls.Add(this.DataGridView_par);
            this.机械参数.Controls.Add(this.UserManagement);
            this.机械参数.Controls.Add(this.Btn_ParLogin);
            this.机械参数.Location = new System.Drawing.Point(4, 29);
            this.机械参数.Name = "机械参数";
            this.机械参数.Padding = new System.Windows.Forms.Padding(3);
            this.机械参数.Size = new System.Drawing.Size(999, 567);
            this.机械参数.TabIndex = 2;
            this.机械参数.Text = " Super admin ";
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
            this.TabControl3.Controls.Add(this.tabPage5);
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
            this.TabPage7.Text = "General Output 1";
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.OutputClass4);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(992, 570);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "General Output 2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // OutputClass4
            // 
            this.OutputClass4.Location = new System.Drawing.Point(6, 3);
            this.OutputClass4.Name = "OutputClass4";
            this.OutputClass4.Size = new System.Drawing.Size(330, 538);
            this.OutputClass4.TabIndex = 3;
            this.OutputClass4.Tag = "3";
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
            this.TabControl2.Controls.Add(this.tabPage11);
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl2.Location = new System.Drawing.Point(5, 3);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1000, 600);
            this.TabControl2.TabIndex = 0;
            this.TabControl2.SelectedIndexChanged += new System.EventHandler(this.TabControl2_SelectedIndexChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.tabControl7);
            this.tabPage11.Location = new System.Drawing.Point(4, 26);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(992, 570);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "General Input ";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.tabPage16);
            this.tabControl7.Controls.Add(this.tabPage17);
            this.tabControl7.Location = new System.Drawing.Point(3, 0);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(993, 574);
            this.tabControl7.TabIndex = 0;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.InputClass3);
            this.tabPage16.Controls.Add(this.InputClass2);
            this.tabPage16.Controls.Add(this.InputClass1);
            this.tabPage16.Location = new System.Drawing.Point(4, 26);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(985, 544);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Page 1";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // InputClass3
            // 
            this.InputClass3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass3.Location = new System.Drawing.Point(675, 3);
            this.InputClass3.Name = "InputClass3";
            this.InputClass3.Size = new System.Drawing.Size(308, 538);
            this.InputClass3.TabIndex = 2;
            this.InputClass3.Tag = "2";
            // 
            // InputClass2
            // 
            this.InputClass2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass2.Location = new System.Drawing.Point(338, 3);
            this.InputClass2.Name = "InputClass2";
            this.InputClass2.Size = new System.Drawing.Size(308, 538);
            this.InputClass2.TabIndex = 1;
            this.InputClass2.Tag = "1";
            // 
            // InputClass1
            // 
            this.InputClass1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass1.Location = new System.Drawing.Point(1, 3);
            this.InputClass1.Name = "InputClass1";
            this.InputClass1.Size = new System.Drawing.Size(308, 538);
            this.InputClass1.TabIndex = 0;
            this.InputClass1.Tag = "0";
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.InputClass4);
            this.tabPage17.Location = new System.Drawing.Point(4, 26);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(985, 544);
            this.tabPage17.TabIndex = 1;
            this.tabPage17.Text = "Page 2";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // InputClass4
            // 
            this.InputClass4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputClass4.Location = new System.Drawing.Point(6, 3);
            this.InputClass4.Name = "InputClass4";
            this.InputClass4.Size = new System.Drawing.Size(308, 538);
            this.InputClass4.TabIndex = 3;
            this.InputClass4.Tag = "3";
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage6.Controls.Add(this.MotorStatus2);
            this.TabPage6.Controls.Add(this.MotorStatus1);
            this.TabPage6.Location = new System.Drawing.Point(4, 26);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(992, 570);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = " Special Input ";
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
            this.TabPage1.Controls.Add(this.label8);
            this.TabPage1.Controls.Add(this.Label_CPK);
            this.TabPage1.Controls.Add(this.Label_WorkMode);
            this.TabPage1.Controls.Add(this.SplitList_LB);
            this.TabPage1.Controls.Add(this.Panel9);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(922, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 108;
            this.label8.Text = "2018.4.12";
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
            // Label_WorkMode
            // 
            this.Label_WorkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label_WorkMode.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_WorkMode.ForeColor = System.Drawing.Color.Yellow;
            this.Label_WorkMode.Location = new System.Drawing.Point(812, 25);
            this.Label_WorkMode.Name = "Label_WorkMode";
            this.Label_WorkMode.Size = new System.Drawing.Size(173, 111);
            this.Label_WorkMode.TabIndex = 72;
            this.Label_WorkMode.Text = "空跑中…";
            this.Label_WorkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplitList_LB
            // 
            this.SplitList_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitList_LB.Controls.Add(this.PictureBox25);
            this.SplitList_LB.Controls.Add(this.infoList1);
            this.SplitList_LB.Location = new System.Drawing.Point(3, 3);
            this.SplitList_LB.Name = "SplitList_LB";
            this.SplitList_LB.Size = new System.Drawing.Size(259, 341);
            this.SplitList_LB.TabIndex = 74;
            // 
            // PictureBox25
            // 
            this.PictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox25.Image")));
            this.PictureBox25.Location = new System.Drawing.Point(3, 2);
            this.PictureBox25.Name = "PictureBox25";
            this.PictureBox25.Size = new System.Drawing.Size(252, 25);
            this.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox25.TabIndex = 82;
            this.PictureBox25.TabStop = false;
            // 
            // infoList1
            // 
            this.infoList1.AutoSize = true;
            this.infoList1.Location = new System.Drawing.Point(3, 28);
            this.infoList1.Margin = new System.Windows.Forms.Padding(4);
            this.infoList1.Name = "infoList1";
            this.infoList1.Size = new System.Drawing.Size(251, 312);
            this.infoList1.TabIndex = 89;
            // 
            // Panel9
            // 
            this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel9.Controls.Add(this.Lab_Robot_ASts);
            this.Panel9.Controls.Add(this.Lab_PDCA_Sts);
            this.Panel9.Controls.Add(this.Lab_Robot_Sts);
            this.Panel9.Controls.Add(this.Lab_EMG_Sts);
            this.Panel9.Controls.Add(this.Lab_Safe_Sts);
            this.Panel9.Controls.Add(this.Lab_CCD_Sts);
            this.Panel9.Controls.Add(this.Lab_LC2_Sts);
            this.Panel9.Controls.Add(this.Lab_LC1_Sts);
            this.Panel9.Controls.Add(this.Lab_Air_Sts);
            this.Panel9.Controls.Add(this.Lab_Barcode_Sts);
            this.Panel9.Location = new System.Drawing.Point(794, 154);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(211, 203);
            this.Panel9.TabIndex = 61;
            // 
            // Lab_Robot_ASts
            // 
            this.Lab_Robot_ASts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_Robot_ASts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Robot_ASts.Location = new System.Drawing.Point(13, 167);
            this.Lab_Robot_ASts.Name = "Lab_Robot_ASts";
            this.Lab_Robot_ASts.Size = new System.Drawing.Size(76, 25);
            this.Lab_Robot_ASts.TabIndex = 88;
            this.Lab_Robot_ASts.Text = "机械手报警";
            this.Lab_Robot_ASts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_PDCA_Sts
            // 
            this.Lab_PDCA_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_PDCA_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_PDCA_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_PDCA_Sts.Location = new System.Drawing.Point(117, 167);
            this.Lab_PDCA_Sts.Name = "Lab_PDCA_Sts";
            this.Lab_PDCA_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_PDCA_Sts.TabIndex = 87;
            this.Lab_PDCA_Sts.Text = "PDCA通信";
            this.Lab_PDCA_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Robot_Sts
            // 
            this.Lab_Robot_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_Robot_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_Robot_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Robot_Sts.Location = new System.Drawing.Point(117, 126);
            this.Lab_Robot_Sts.Name = "Lab_Robot_Sts";
            this.Lab_Robot_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_Robot_Sts.TabIndex = 86;
            this.Lab_Robot_Sts.Text = "机械手通信";
            this.Lab_Robot_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Lab_CCD_Sts
            // 
            this.Lab_CCD_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_CCD_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_CCD_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_CCD_Sts.Location = new System.Drawing.Point(13, 85);
            this.Lab_CCD_Sts.Name = "Lab_CCD_Sts";
            this.Lab_CCD_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_CCD_Sts.TabIndex = 83;
            this.Lab_CCD_Sts.Text = "CCD通信";
            this.Lab_CCD_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_LC2_Sts
            // 
            this.Lab_LC2_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_LC2_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_LC2_Sts.Location = new System.Drawing.Point(117, 44);
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
            this.Lab_LC1_Sts.Location = new System.Drawing.Point(13, 44);
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
            this.Lab_Air_Sts.Location = new System.Drawing.Point(13, 126);
            this.Lab_Air_Sts.Name = "Lab_Air_Sts";
            this.Lab_Air_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_Air_Sts.TabIndex = 71;
            this.Lab_Air_Sts.Text = "正气源状态";
            this.Lab_Air_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Barcode_Sts
            // 
            this.Lab_Barcode_Sts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_Barcode_Sts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_Barcode_Sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Barcode_Sts.Location = new System.Drawing.Point(117, 85);
            this.Lab_Barcode_Sts.Name = "Lab_Barcode_Sts";
            this.Lab_Barcode_Sts.Size = new System.Drawing.Size(76, 25);
            this.Lab_Barcode_Sts.TabIndex = 70;
            this.Lab_Barcode_Sts.Text = "条码枪通信";
            this.Lab_Barcode_Sts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Panel6.Controls.Add(this.Lab_DIS_RStep);
            this.Panel6.Controls.Add(this.Lab_DIS_LStep);
            this.Panel6.Controls.Add(this.Lab_Line0Step);
            this.Panel6.Controls.Add(this.Lab_PressStep);
            this.Panel6.Controls.Add(this.Lab_PSAStep);
            this.Panel6.Controls.Add(this.Lab_RobotStep);
            this.Panel6.Controls.Add(this.Lab_HomeStep);
            this.Panel6.Controls.Add(this.Change_PSA);
            this.Panel6.Controls.Add(this.Box_InR5);
            this.Panel6.Controls.Add(this.Box_InR4);
            this.Panel6.Controls.Add(this.Box_InR3);
            this.Panel6.Controls.Add(this.Box_InR2);
            this.Panel6.Controls.Add(this.Box_InR1);
            this.Panel6.Controls.Add(this.Box_InL5);
            this.Panel6.Controls.Add(this.PB_Right2);
            this.Panel6.Controls.Add(this.GroupBox9);
            this.Panel6.Controls.Add(this.groupBox3);
            this.Panel6.Controls.Add(this.GroupBox4);
            this.Panel6.Controls.Add(this.Box_InR);
            this.Panel6.Controls.Add(this.Box_InL);
            this.Panel6.Controls.Add(this.GroupBox8);
            this.Panel6.Controls.Add(this.PB_Left2);
            this.Panel6.Controls.Add(this.Lab_Station1);
            this.Panel6.Controls.Add(this.Box_InL1);
            this.Panel6.Controls.Add(this.Box_InL2);
            this.Panel6.Controls.Add(this.Box_InL3);
            this.Panel6.Controls.Add(this.Box_InL4);
            this.Panel6.Controls.Add(this.PB_Right3);
            this.Panel6.Controls.Add(this.PB_Right1);
            this.Panel6.Controls.Add(this.PB_Left3);
            this.Panel6.Controls.Add(this.PB_Left1);
            this.Panel6.Controls.Add(this.Lab_Line3Step);
            this.Panel6.Controls.Add(this.Lab_Line2Step);
            this.Panel6.Controls.Add(this.Lab_Line1Step);
            this.Panel6.Controls.Add(this.Lab_Station3);
            this.Panel6.Controls.Add(this.Lab_Station2);
            this.Panel6.Controls.Add(this.ShapeS3);
            this.Panel6.Controls.Add(this.ShapeS2);
            this.Panel6.Controls.Add(this.ShapeS1);
            this.Panel6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel6.Location = new System.Drawing.Point(265, 3);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(527, 355);
            this.Panel6.TabIndex = 74;
            // 
            // Lab_DIS_RStep
            // 
            this.Lab_DIS_RStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_DIS_RStep.Location = new System.Drawing.Point(272, 28);
            this.Lab_DIS_RStep.Name = "Lab_DIS_RStep";
            this.Lab_DIS_RStep.Size = new System.Drawing.Size(101, 20);
            this.Lab_DIS_RStep.TabIndex = 134;
            this.Lab_DIS_RStep.Text = "HomeStep";
            this.Lab_DIS_RStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_DIS_LStep
            // 
            this.Lab_DIS_LStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_DIS_LStep.Location = new System.Drawing.Point(140, 30);
            this.Lab_DIS_LStep.Name = "Lab_DIS_LStep";
            this.Lab_DIS_LStep.Size = new System.Drawing.Size(101, 20);
            this.Lab_DIS_LStep.TabIndex = 133;
            this.Lab_DIS_LStep.Text = "HomeStep";
            this.Lab_DIS_LStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Line0Step
            // 
            this.Lab_Line0Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Line0Step.Location = new System.Drawing.Point(3, 26);
            this.Lab_Line0Step.Name = "Lab_Line0Step";
            this.Lab_Line0Step.Size = new System.Drawing.Size(101, 20);
            this.Lab_Line0Step.TabIndex = 132;
            this.Lab_Line0Step.Text = "HomeStep";
            this.Lab_Line0Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_PressStep
            // 
            this.Lab_PressStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_PressStep.Location = new System.Drawing.Point(415, 3);
            this.Lab_PressStep.Name = "Lab_PressStep";
            this.Lab_PressStep.Size = new System.Drawing.Size(101, 20);
            this.Lab_PressStep.TabIndex = 131;
            this.Lab_PressStep.Text = "HomeStep";
            this.Lab_PressStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_PSAStep
            // 
            this.Lab_PSAStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_PSAStep.Location = new System.Drawing.Point(272, 3);
            this.Lab_PSAStep.Name = "Lab_PSAStep";
            this.Lab_PSAStep.Size = new System.Drawing.Size(101, 20);
            this.Lab_PSAStep.TabIndex = 130;
            this.Lab_PSAStep.Text = "HomeStep";
            this.Lab_PSAStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_RobotStep
            // 
            this.Lab_RobotStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_RobotStep.Location = new System.Drawing.Point(140, 3);
            this.Lab_RobotStep.Name = "Lab_RobotStep";
            this.Lab_RobotStep.Size = new System.Drawing.Size(101, 20);
            this.Lab_RobotStep.TabIndex = 129;
            this.Lab_RobotStep.Text = "HomeStep";
            this.Lab_RobotStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_HomeStep
            // 
            this.Lab_HomeStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_HomeStep.Location = new System.Drawing.Point(3, 3);
            this.Lab_HomeStep.Name = "Lab_HomeStep";
            this.Lab_HomeStep.Size = new System.Drawing.Size(101, 20);
            this.Lab_HomeStep.TabIndex = 128;
            this.Lab_HomeStep.Text = "HomeStep";
            this.Lab_HomeStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Change_PSA
            // 
            this.Change_PSA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Change_PSA.Location = new System.Drawing.Point(257, 245);
            this.Change_PSA.Name = "Change_PSA";
            this.Change_PSA.Size = new System.Drawing.Size(60, 43);
            this.Change_PSA.TabIndex = 127;
            this.Change_PSA.Text = "PSA 换料";
            this.Change_PSA.UseVisualStyleBackColor = true;
            this.Change_PSA.Click += new System.EventHandler(this.Change_PSA_Click);
            // 
            // Box_InR5
            // 
            this.Box_InR5.BackColor = System.Drawing.Color.LightGray;
            this.Box_InR5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InR5.Location = new System.Drawing.Point(212, 127);
            this.Box_InR5.Name = "Box_InR5";
            this.Box_InR5.Size = new System.Drawing.Size(12, 12);
            this.Box_InR5.TabIndex = 126;
            this.Box_InR5.TabStop = false;
            // 
            // Box_InR4
            // 
            this.Box_InR4.BackColor = System.Drawing.Color.LightGray;
            this.Box_InR4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InR4.Location = new System.Drawing.Point(292, 127);
            this.Box_InR4.Name = "Box_InR4";
            this.Box_InR4.Size = new System.Drawing.Size(12, 12);
            this.Box_InR4.TabIndex = 125;
            this.Box_InR4.TabStop = false;
            // 
            // Box_InR3
            // 
            this.Box_InR3.BackColor = System.Drawing.Color.LightGray;
            this.Box_InR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InR3.Location = new System.Drawing.Point(362, 127);
            this.Box_InR3.Name = "Box_InR3";
            this.Box_InR3.Size = new System.Drawing.Size(12, 12);
            this.Box_InR3.TabIndex = 124;
            this.Box_InR3.TabStop = false;
            // 
            // Box_InR2
            // 
            this.Box_InR2.BackColor = System.Drawing.Color.LightGray;
            this.Box_InR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InR2.Location = new System.Drawing.Point(399, 127);
            this.Box_InR2.Name = "Box_InR2";
            this.Box_InR2.Size = new System.Drawing.Size(12, 12);
            this.Box_InR2.TabIndex = 123;
            this.Box_InR2.TabStop = false;
            // 
            // Box_InR1
            // 
            this.Box_InR1.BackColor = System.Drawing.Color.LightGray;
            this.Box_InR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InR1.Location = new System.Drawing.Point(504, 127);
            this.Box_InR1.Name = "Box_InR1";
            this.Box_InR1.Size = new System.Drawing.Size(12, 12);
            this.Box_InR1.TabIndex = 122;
            this.Box_InR1.TabStop = false;
            // 
            // Box_InL5
            // 
            this.Box_InL5.BackColor = System.Drawing.Color.LightGray;
            this.Box_InL5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InL5.Location = new System.Drawing.Point(292, 127);
            this.Box_InL5.Name = "Box_InL5";
            this.Box_InL5.Size = new System.Drawing.Size(12, 12);
            this.Box_InL5.TabIndex = 121;
            this.Box_InL5.TabStop = false;
            // 
            // PB_Right2
            // 
            this.PB_Right2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Right2.BackgroundImage")));
            this.PB_Right2.Location = new System.Drawing.Point(250, 112);
            this.PB_Right2.Name = "PB_Right2";
            this.PB_Right2.Size = new System.Drawing.Size(24, 23);
            this.PB_Right2.TabIndex = 110;
            this.PB_Right2.TabStop = false;
            // 
            // GroupBox9
            // 
            this.GroupBox9.Controls.Add(this.Btn_SelectMaterial);
            this.GroupBox9.Controls.Add(this.Txt_PalletNum);
            this.GroupBox9.Controls.Add(this.Change_M);
            this.GroupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox9.ForeColor = System.Drawing.Color.Black;
            this.GroupBox9.Location = new System.Drawing.Point(13, 236);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(228, 56);
            this.GroupBox9.TabIndex = 103;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Display";
            // 
            // Btn_SelectMaterial
            // 
            this.Btn_SelectMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_SelectMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectMaterial.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SelectMaterial.Location = new System.Drawing.Point(80, 18);
            this.Btn_SelectMaterial.Name = "Btn_SelectMaterial";
            this.Btn_SelectMaterial.Size = new System.Drawing.Size(50, 30);
            this.Btn_SelectMaterial.TabIndex = 3;
            this.Btn_SelectMaterial.Text = "· · ·";
            this.Btn_SelectMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_SelectMaterial.UseVisualStyleBackColor = true;
            this.Btn_SelectMaterial.Click += new System.EventHandler(this.Btn_SelectMaterial_Click);
            // 
            // Txt_PalletNum
            // 
            this.Txt_PalletNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_PalletNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_PalletNum.ForeColor = System.Drawing.Color.Blue;
            this.Txt_PalletNum.Location = new System.Drawing.Point(15, 22);
            this.Txt_PalletNum.Name = "Txt_PalletNum";
            this.Txt_PalletNum.ReadOnly = true;
            this.Txt_PalletNum.Size = new System.Drawing.Size(47, 26);
            this.Txt_PalletNum.TabIndex = 1;
            this.Txt_PalletNum.Text = "1";
            this.Txt_PalletNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Change_M
            // 
            this.Change_M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Change_M.Location = new System.Drawing.Point(151, 11);
            this.Change_M.Name = "Change_M";
            this.Change_M.Size = new System.Drawing.Size(60, 39);
            this.Change_M.TabIndex = 5;
            this.Change_M.Text = "Display 换料";
            this.Change_M.UseVisualStyleBackColor = true;
            this.Change_M.Click += new System.EventHandler(this.Change_M_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_BarCode);
            this.groupBox3.Controls.Add(this.Btn_BarCode);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(13, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 53);
            this.groupBox3.TabIndex = 120;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cognex Barcode";
            // 
            // Txt_BarCode
            // 
            this.Txt_BarCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_BarCode.Location = new System.Drawing.Point(5, 20);
            this.Txt_BarCode.Name = "Txt_BarCode";
            this.Txt_BarCode.Size = new System.Drawing.Size(265, 26);
            this.Txt_BarCode.TabIndex = 7;
            this.Txt_BarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_BarCode
            // 
            this.Btn_BarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BarCode.Location = new System.Drawing.Point(279, 20);
            this.Btn_BarCode.Name = "Btn_BarCode";
            this.Btn_BarCode.Size = new System.Drawing.Size(59, 30);
            this.Btn_BarCode.TabIndex = 82;
            this.Btn_BarCode.Text = "Trigger";
            this.Btn_BarCode.UseVisualStyleBackColor = true;
            this.Btn_BarCode.Click += new System.EventHandler(this.buttonTrigger_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Force_Text);
            this.GroupBox4.Controls.Add(this.Press1_Text);
            this.GroupBox4.Controls.Add(this.Label44);
            this.GroupBox4.Controls.Add(this.Label43);
            this.GroupBox4.Controls.Add(this.Label34);
            this.GroupBox4.Controls.Add(this.Press_Display0);
            this.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.GroupBox4.Location = new System.Drawing.Point(188, 153);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(163, 81);
            this.GroupBox4.TabIndex = 101;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "压力值";
            // 
            // Force_Text
            // 
            this.Force_Text.BackColor = System.Drawing.Color.Black;
            this.Force_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Force_Text.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Force_Text.ForeColor = System.Drawing.Color.Lime;
            this.Force_Text.Location = new System.Drawing.Point(87, 19);
            this.Force_Text.Name = "Force_Text";
            this.Force_Text.Size = new System.Drawing.Size(42, 19);
            this.Force_Text.TabIndex = 91;
            this.Force_Text.Text = "0.00  ";
            this.Force_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Press1_Text
            // 
            this.Press1_Text.BackColor = System.Drawing.Color.Black;
            this.Press1_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Press1_Text.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Press1_Text.ForeColor = System.Drawing.Color.Lime;
            this.Press1_Text.Location = new System.Drawing.Point(87, 55);
            this.Press1_Text.Name = "Press1_Text";
            this.Press1_Text.Size = new System.Drawing.Size(42, 19);
            this.Press1_Text.TabIndex = 75;
            this.Press1_Text.Text = "0.00  ";
            this.Press1_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.Location = new System.Drawing.Point(131, 56);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(27, 17);
            this.Label44.TabIndex = 93;
            this.Label44.Text = "kgf";
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.Location = new System.Drawing.Point(136, 20);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(18, 17);
            this.Label43.TabIndex = 92;
            this.Label43.Text = "N";
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
            // Box_InR
            // 
            this.Box_InR.BackColor = System.Drawing.Color.LightGray;
            this.Box_InR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InR.Location = new System.Drawing.Point(510, 83);
            this.Box_InR.Name = "Box_InR";
            this.Box_InR.Size = new System.Drawing.Size(12, 12);
            this.Box_InR.TabIndex = 119;
            this.Box_InR.TabStop = false;
            // 
            // Box_InL
            // 
            this.Box_InL.BackColor = System.Drawing.Color.LightGray;
            this.Box_InL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InL.Location = new System.Drawing.Point(2, 83);
            this.Box_InL.Name = "Box_InL";
            this.Box_InL.Size = new System.Drawing.Size(12, 12);
            this.Box_InL.TabIndex = 118;
            this.Box_InL.TabStop = false;
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
            this.GroupBox8.Location = new System.Drawing.Point(13, 156);
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
            // PB_Left2
            // 
            this.PB_Left2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Left2.BackgroundImage")));
            this.PB_Left2.Location = new System.Drawing.Point(250, 112);
            this.PB_Left2.Name = "PB_Left2";
            this.PB_Left2.Size = new System.Drawing.Size(24, 23);
            this.PB_Left2.TabIndex = 109;
            this.PB_Left2.TabStop = false;
            // 
            // Lab_Station1
            // 
            this.Lab_Station1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lab_Station1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Station1.Location = new System.Drawing.Point(25, 83);
            this.Lab_Station1.Name = "Lab_Station1";
            this.Lab_Station1.Size = new System.Drawing.Size(140, 21);
            this.Lab_Station1.TabIndex = 100;
            this.Lab_Station1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Box_InL1
            // 
            this.Box_InL1.BackColor = System.Drawing.Color.LightGray;
            this.Box_InL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InL1.Location = new System.Drawing.Point(8, 127);
            this.Box_InL1.Name = "Box_InL1";
            this.Box_InL1.Size = new System.Drawing.Size(12, 12);
            this.Box_InL1.TabIndex = 101;
            this.Box_InL1.TabStop = false;
            // 
            // Box_InL2
            // 
            this.Box_InL2.BackColor = System.Drawing.Color.LightGray;
            this.Box_InL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InL2.Location = new System.Drawing.Point(110, 127);
            this.Box_InL2.Name = "Box_InL2";
            this.Box_InL2.Size = new System.Drawing.Size(12, 12);
            this.Box_InL2.TabIndex = 102;
            this.Box_InL2.TabStop = false;
            // 
            // Box_InL3
            // 
            this.Box_InL3.BackColor = System.Drawing.Color.LightGray;
            this.Box_InL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InL3.Location = new System.Drawing.Point(151, 127);
            this.Box_InL3.Name = "Box_InL3";
            this.Box_InL3.Size = new System.Drawing.Size(12, 12);
            this.Box_InL3.TabIndex = 105;
            this.Box_InL3.TabStop = false;
            // 
            // Box_InL4
            // 
            this.Box_InL4.BackColor = System.Drawing.Color.LightGray;
            this.Box_InL4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_InL4.Location = new System.Drawing.Point(212, 127);
            this.Box_InL4.Name = "Box_InL4";
            this.Box_InL4.Size = new System.Drawing.Size(12, 12);
            this.Box_InL4.TabIndex = 106;
            this.Box_InL4.TabStop = false;
            // 
            // PB_Right3
            // 
            this.PB_Right3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Right3.BackgroundImage")));
            this.PB_Right3.Location = new System.Drawing.Point(418, 112);
            this.PB_Right3.Name = "PB_Right3";
            this.PB_Right3.Size = new System.Drawing.Size(24, 23);
            this.PB_Right3.TabIndex = 117;
            this.PB_Right3.TabStop = false;
            // 
            // PB_Right1
            // 
            this.PB_Right1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Right1.BackgroundImage")));
            this.PB_Right1.Location = new System.Drawing.Point(80, 112);
            this.PB_Right1.Name = "PB_Right1";
            this.PB_Right1.Size = new System.Drawing.Size(24, 23);
            this.PB_Right1.TabIndex = 107;
            this.PB_Right1.TabStop = false;
            // 
            // PB_Left3
            // 
            this.PB_Left3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Left3.BackgroundImage")));
            this.PB_Left3.Location = new System.Drawing.Point(418, 112);
            this.PB_Left3.Name = "PB_Left3";
            this.PB_Left3.Size = new System.Drawing.Size(24, 23);
            this.PB_Left3.TabIndex = 116;
            this.PB_Left3.TabStop = false;
            // 
            // PB_Left1
            // 
            this.PB_Left1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Left1.BackgroundImage")));
            this.PB_Left1.Location = new System.Drawing.Point(80, 112);
            this.PB_Left1.Name = "PB_Left1";
            this.PB_Left1.Size = new System.Drawing.Size(24, 23);
            this.PB_Left1.TabIndex = 108;
            this.PB_Left1.TabStop = false;
            // 
            // Lab_Line3Step
            // 
            this.Lab_Line3Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Line3Step.Location = new System.Drawing.Point(359, 60);
            this.Lab_Line3Step.Name = "Lab_Line3Step";
            this.Lab_Line3Step.Size = new System.Drawing.Size(140, 20);
            this.Lab_Line3Step.TabIndex = 111;
            this.Lab_Line3Step.Text = "S3";
            this.Lab_Line3Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Line2Step
            // 
            this.Lab_Line2Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Line2Step.Location = new System.Drawing.Point(192, 60);
            this.Lab_Line2Step.Name = "Lab_Line2Step";
            this.Lab_Line2Step.Size = new System.Drawing.Size(140, 20);
            this.Lab_Line2Step.TabIndex = 112;
            this.Lab_Line2Step.Text = "S2";
            this.Lab_Line2Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Line1Step
            // 
            this.Lab_Line1Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Line1Step.Location = new System.Drawing.Point(25, 60);
            this.Lab_Line1Step.Name = "Lab_Line1Step";
            this.Lab_Line1Step.Size = new System.Drawing.Size(140, 20);
            this.Lab_Line1Step.TabIndex = 113;
            this.Lab_Line1Step.Text = "S1";
            this.Lab_Line1Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Station3
            // 
            this.Lab_Station3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lab_Station3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Station3.Location = new System.Drawing.Point(359, 83);
            this.Lab_Station3.Name = "Lab_Station3";
            this.Lab_Station3.Size = new System.Drawing.Size(140, 21);
            this.Lab_Station3.TabIndex = 115;
            this.Lab_Station3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Station2
            // 
            this.Lab_Station2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lab_Station2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Station2.Location = new System.Drawing.Point(192, 83);
            this.Lab_Station2.Name = "Lab_Station2";
            this.Lab_Station2.Size = new System.Drawing.Size(140, 21);
            this.Lab_Station2.TabIndex = 114;
            this.Lab_Station2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShapeS3
            // 
            this.ShapeS3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShapeS3.Location = new System.Drawing.Point(20, 50);
            this.ShapeS3.Name = "ShapeS3";
            this.ShapeS3.Size = new System.Drawing.Size(150, 89);
            this.ShapeS3.TabIndex = 97;
            // 
            // ShapeS2
            // 
            this.ShapeS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShapeS2.Location = new System.Drawing.Point(187, 50);
            this.ShapeS2.Name = "ShapeS2";
            this.ShapeS2.Size = new System.Drawing.Size(150, 89);
            this.ShapeS2.TabIndex = 98;
            // 
            // ShapeS1
            // 
            this.ShapeS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShapeS1.Location = new System.Drawing.Point(354, 50);
            this.ShapeS1.Name = "ShapeS1";
            this.ShapeS1.Size = new System.Drawing.Size(150, 89);
            this.ShapeS1.TabIndex = 99;
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
            this.Column2,
            this.Column1,
            this.Column13,
            this.ColProSta,
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
            this.DataGrid_CheckData.Location = new System.Drawing.Point(3, 364);
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
            this.DataGrid_CheckData.Size = new System.Drawing.Size(1002, 241);
            this.DataGrid_CheckData.TabIndex = 68;
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
            // Column11
            // 
            this.Column11.HeaderText = "Date";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTime
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColTime.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTime.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fixture";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Color";
            this.Column1.Name = "Column1";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "CT";
            this.Column13.Name = "Column13";
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColProSta
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColProSta.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColProSta.HeaderText = "Result";
            this.ColProSta.Name = "ColProSta";
            this.ColProSta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCam1CCX
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColCam1CCX.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColCam1CCX.HeaderText = "PSA_X";
            this.ColCam1CCX.Name = "ColCam1CCX";
            this.ColCam1CCX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCam1CCY
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColCam1CCY.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColCam1CCY.HeaderText = "PSA_Y";
            this.ColCam1CCY.Name = "ColCam1CCY";
            this.ColCam1CCY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_CC
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_CC.DefaultCellStyle = dataGridViewCellStyle14;
            this.Col_CC.HeaderText = "PSA_CC ";
            this.Col_CC.Name = "Col_CC";
            this.Col_CC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCheckA
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColCheckA.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColCheckA.HeaderText = "PSA_T";
            this.ColCheckA.Name = "ColCheckA";
            this.ColCheckA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.TabPage4.ResumeLayout(false);
            this.TabControl4.ResumeLayout(false);
            this.机械手调试.ResumeLayout(false);
            this.机械手调试.PerformLayout();
            this.TabControl5.ResumeLayout(false);
            this.手动调试.ResumeLayout(false);
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Panel1_Left.ResumeLayout(false);
            this.Panel1_Left.PerformLayout();
            this.Panel1_Right.ResumeLayout(false);
            this.Panel1_Right.PerformLayout();
            this.校正页面.ResumeLayout(false);
            this.Panel_Calibration.ResumeLayout(false);
            this.Panel_Calibration.PerformLayout();
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
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
            this.搬运料盘.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.panel_S2g.ResumeLayout(false);
            this.panel_S2g.PerformLayout();
            this.保压站.ResumeLayout(false);
            this.保压站.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.机械参数.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_par)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabControl3.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabControl7.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.tabPage17.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.SplitList_LB.ResumeLayout(false);
            this.SplitList_LB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox25)).EndInit();
            this.Panel9.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right2)).EndInit();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL)).EndInit();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_InL4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Right1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CheckData)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.TabControl TabControl4;
		internal System.Windows.Forms.TabPage 机械手调试;
		internal System.Windows.Forms.TabPage 机械参数;
		internal System.Windows.Forms.Button UserManagement;
		internal System.Windows.Forms.Button Btn_ParLogin;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.TabControl TabControl3;
		internal System.Windows.Forms.TabPage TabPage7;
		internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabControl TabControl2;
		internal System.Windows.Forms.TabPage TabPage6;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Label Label_WorkMode;
        internal System.Windows.Forms.Panel Panel9;
		internal System.Windows.Forms.Label Lab_Safe_Sts;
		internal System.Windows.Forms.Label Lab_EMG_Sts;
        internal System.Windows.Forms.Label Lab_LC2_Sts;
        internal System.Windows.Forms.Label Lab_LC1_Sts;
		internal System.Windows.Forms.Label Lab_Air_Sts;
		internal System.Windows.Forms.Label Lab_Barcode_Sts;
		internal System.Windows.Forms.Label Label_NG_OK;
        internal System.Windows.Forms.Label Label47;
		internal System.Windows.Forms.DataGridView DataGrid_CheckData;
        internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabControl TabControl5;
        internal System.Windows.Forms.TabPage 手动调试;
        internal System.Windows.Forms.TabPage 校正页面;
		internal System.Windows.Forms.Panel SplitList_LB;
        internal System.Windows.Forms.PictureBox PictureBox25;
		internal System.Windows.Forms.DataGridView DataGridView_par;
		internal System.Windows.Forms.Button Button62;
        internal System.Windows.Forms.Button Button61;
        internal System.Windows.Forms.TextBox TextBox_CCD;
        internal System.Windows.Forms.Label Label_CPK;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column24;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column25;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column26;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column27;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        internal System.Windows.Forms.Label Lab_CCD_Sts;
        private InfoList infoList1;
        private MotorStatus MotorStatus1;
        private MotorStatus MotorStatus2;
        internal TabPage tabPage8;
        internal Teach Teach3;
        internal TabPage 保压站;
        internal Teach Teach4;
        internal Panel panel_S2g;
        internal Button Button_O_8;
        internal Button Button_X_5;
        internal Button Button_P_6;
        internal Button Button_P_5;
        internal Button Button_X_6;
        internal Label label2;
        internal TextBox textBox1;
        internal GroupBox groupBox10;
        internal Label label6;
        internal Label label7;
        internal TextBox Text_Force1;
        internal Button Btn_OpenSerial1;
        internal Panel panel4;
        internal Button Button_O_11;
        internal Label label4;
        internal TextBox textBox2;
        internal GroupBox groupBox7;
        internal Button CommandAutoPress;
        internal Button CmdStopPress;
        internal Button CmdHoldPress;
        internal Panel panel5;
        internal Button Button_P_4;
        internal Button Button_X_4;
        internal Button Button_P_3;
        internal Button Button_X_3;
        internal Button Button_P_2;
        internal Button Button_X_2;
        internal Button Button_O_1;
        internal Button Button_P_1;
        internal Button Button_X_1;
        internal Label label1;
        internal TextBox textBox4;

        //网络定义。  
        internal SocketHelper.TCP.ITcpClient Tcp_Robot = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_RobotData = new SocketHelper.TCP.ITcpClient(); 
        internal SocketHelper.TCP.ITcpClient Tcp_CCD = new SocketHelper.TCP.ITcpClient();
        //internal SocketHelper.TCP.ITcpClient Tcp_CCD2 = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_Barcode = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_PDCA = new SocketHelper.TCP.ITcpClient();
        internal SocketHelper.TCP.ITcpClient Tcp_HeatBt = new SocketHelper.TCP.ITcpClient();
        internal OutputClass OutputClass1;
        internal OutputClass OutputClass2;
        internal OutputClass OutputClass3;
        internal Panel panel2;
        internal Button CCD_Trigger;
        internal ComboBox ComboBox_Cam2;
        internal GroupBox groupBox13;
        internal Button CommandAuto;
        internal Button CmdStop;
        internal Button CmdHold;

        private Label label8;
        internal GroupBox groupBox16;
        internal Button CommandAutoS0;
        internal Button CmdStopS0;
        internal Button CmdHoldS0;
        private TabPage tabPage11;
        private TabControl tabControl7;
        private TabPage tabPage16;
        private InputClass InputClass3;
        private InputClass InputClass2;
        private InputClass InputClass1;
        private TabPage tabPage17;
        private InputClass InputClass4;
        private TabPage tabPage5;
        internal OutputClass OutputClass4;
        private TabPage 搬运料盘;
        internal Teach Teach2;
        internal Teach Teach1;
        internal Panel panel3;
        internal Button Btn_RbtRun12;
        internal Button Btn_RbtRun10;
        internal Button Btn_RbtRun8;
        internal Button Btn_RbtRun11;
        internal Button Btn_RbtRun9;
        internal Button Btn_RbtRun7;
        internal Button Btn_RbtRun6;
        internal Button Btn_RbtRun5;
        internal Button Btn_RbtRun4;
        internal Button Btn_RbtRun3;
        internal Button Btn_RbtRun2;
        internal Button Btn_RbtRun1;
        internal Panel Panel11;
        internal Label Label_Rbt4;
        internal Button Cmd_MotorON;
        internal Button Cmd_MotorOff;
        internal Label Label_Rbt2;
        internal Label Label_Rbt3;
        internal Label Label_Rbt1;
        internal Panel panel7;
        internal Button Btn_Rbt1;
        internal Button Btn_Rbt5;
        internal Button Btn_Rbt4;
        internal Button Btn_Rbt3;
        internal Button Btn_Rbt2;
        internal Panel panel8;
        internal TextBox Text_Robot_X;
        internal TextBox Text_Robot_Y;
        internal TextBox Text_Robot_Z;
        internal TextBox Text_Robot_U;
        internal TextBox Text_Robot_V;
        internal TextBox Text_Robot_W;
        internal Label label9;
        internal Label label10;
        internal Label label15;
        internal Label label25;
        internal Label label28;
        internal Label label31;
        internal Panel panel10;
        internal Button CmdS2_Save;
        internal TrackBar TrackBar2;
        internal TrackBar TrackBar1;
        internal CheckBox SavePoint_Check;
        internal ComboBox Combo_RbtDist;
        internal ComboBox Combo_RbtSpeed;
        internal Label label35;
        internal Label label36;
        internal Button Cmd_RobotRun;
        internal ComboBox Combo_Robot_Pos;
        internal Panel Panel1_Left;
        internal Button Btn_L3Z1;
        internal Button Btn_L2Z1;
        internal Button Btn_L1Z1;
        internal Button Btn_L1AZ;
        internal Button Btn_L2AZ;
        internal Button Btn_L3AZ;
        internal Button Btn_L1AF;
        internal Button Btn_L2AF;
        internal Button Btn_L3AF;
        internal Button Btn_L1AST;
        internal Button Btn_L2AST;
        internal Button Btn_L3AST;
        private Label label37;
        internal Panel Panel1_Right;
        private Label label38;
        internal Button Btn_L3Z1N;
        internal Button Btn_L2Z1N;
        internal Button Btn_L1Z1N;
        internal Button Btn_L1BZ;
        internal Button Btn_L2BZ;
        internal Button Btn_L3BZ;
        internal Button Btn_L1BF;
        internal Button Btn_L2BF;
        internal Button Btn_L3BF;
        internal Button Btn_L1BST;
        internal Button Btn_L2BST;
        internal Button Btn_L3BST;
        internal Panel panel12;
        internal Button Button_O_7;
        internal Button Button_O_6;
        internal Button Button_O_13;
        internal Button Button_O_12;
        internal Label label39;
        internal TextBox textBox5;
        internal TextBox MForce_Text;
        internal Button Rot_SetPressZero;
        internal Label label40;
        internal Button Button_O_4;
        internal Button Button_O_3;
        internal Button Button_O_5;
        internal Button Button_O_2;
        internal Label label41;
        internal Button Button_O_9;
        internal Button Button_O_10;
        internal Label Lab_Robot_Sts;
        internal Label Lab_PDCA_Sts;
        internal Label Lab_Robot_ASts;
        internal Panel Panel6;
        private GroupBox GroupBox9;
        internal Button Btn_SelectMaterial;
        internal TextBox Txt_PalletNum;
        private Button Change_M;
        internal GroupBox GroupBox4;
        internal Label Force_Text;
        internal Label Press1_Text;
        internal Label Label44;
        internal Label Label43;
        internal Label Label34;
        internal Label Press_Display0;
        private GroupBox GroupBox8;
        private Label Label16;
        internal Label Label5;
        internal TextBox Product_Num;
        private Label Label134;
        internal TextBox Cycle;
        private Label Label32;
        internal PictureBox PB_Right2;
        internal GroupBox groupBox3;
        internal TextBox Txt_BarCode;
        internal Button Btn_BarCode;
        internal PictureBox Box_InR;
        internal PictureBox Box_InL;
        internal PictureBox PB_Left2;
        internal Label Lab_Station1;
        internal PictureBox Box_InL1;
        internal PictureBox Box_InL2;
        internal PictureBox Box_InL3;
        internal PictureBox Box_InL4;
        internal PictureBox PB_Right3;
        internal PictureBox PB_Right1;
        internal PictureBox PB_Left3;
        internal PictureBox PB_Left1;
        internal Label Lab_Line3Step;
        internal Label Lab_Line2Step;
        internal Label Lab_Line1Step;
        internal Label Lab_Station3;
        internal Label Lab_Station2;
        internal Label ShapeS3;
        internal Label ShapeS2;
        internal Label ShapeS1;
        internal Button Button_J_1;
        internal PictureBox Box_InL5;
        internal PictureBox Box_InR5;
        internal PictureBox Box_InR4;
        internal PictureBox Box_InR3;
        internal PictureBox Box_InR2;
        internal PictureBox Box_InR1;
        internal Button Btn_SelectPalletNum;
        internal TextBox Txt_PalletSelectNum;
        internal CheckBox CheckBox_NeedCCD;
        internal CheckBox checkBox_Live;
        internal GroupBox groupBox12;
        internal Button button2;
        internal Button button5;
        internal Button button6;
        internal Panel Panel_Calibration;
        private InfoList infoList2;
        internal GroupBox GroupBox6;
        internal Panel Panel_Test;
        internal Label Label42;
        internal TextBox TextBox_Num;
        internal Button Button_Test;
        internal GroupBox GroupBox5;
        internal Panel PanelCalibration;
        internal Button Btn_CalibrationList;
        internal Panel Panel19;
        internal Button Trigger;
        internal Label Label_PDCA_Step;
        internal Button Button_OpenPDCAlog;
        internal Label Label26;
        internal TextBox Txt_MBarCode;
        internal Button Btn_PDCATest;
        internal Panel Panel_Vup;
        internal Button Btn_Vup_Check;
        internal TextBox TB_Vup_Angel;
        internal Label Label27;
        internal TextBox TB_Vup_Center_Y;
        internal Label Label29;
        internal Label Label30;
        internal TextBox TB_Vup_Center_X;
        internal Button Btn_Vup_Calibration;
        internal GroupBox GroupBox1;
        internal Button Button3;
        internal Button Button1;
        internal TextBox Txt_StandardPressure;
        internal Button Btn_AutoLoadcell;
        internal TextBox Txt_InstallPressure;
        internal Label Label74;
        internal Label Label73;
        internal Panel Panel17;
        internal Button Btn_CaliSave;
        internal Button Btn_Ckeck;
        internal TextBox Text_CkcekAngle;
        internal Label Label20;
        internal TextBox Text_CaliY;
        internal Label Label21;
        internal Label Label22;
        internal TextBox Text_CaliX;
        internal Button Btn_StartCorrection;
        internal GroupBox GroupBox2;
        internal Button Btn_SaveCamDist;
        internal TextBox Txt_CamDistY;
        internal Label Label23;
        internal Label Label24;
        internal TextBox Txt_CamDistX;
        private ComboBox Combox_CCD_COR;
        internal Button Button_TestStop;
        private ComboBox Combox_CCDTest;
        internal Button Button_CalibrationStop;
        internal GroupBox GroupBox14;
        internal Label Label18;
        internal Label Label19;
        internal TextBox Text_Force2;
        internal Button Btn_OpenSerial2;
        private Button Change_PSA;
        public TextBox textBox3;
        internal Label Lab_DIS_RStep;
        internal Label Lab_DIS_LStep;
        internal Label Lab_Line0Step;
        internal Label Lab_PressStep;
        internal Label Lab_PSAStep;
        internal Label Lab_RobotStep;
        internal Label Lab_HomeStep;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn ColTime;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn ColProSta;
        private DataGridViewTextBoxColumn ColCam1CCX;
        private DataGridViewTextBoxColumn ColCam1CCY;
        private DataGridViewTextBoxColumn Col_CC;
        private DataGridViewTextBoxColumn ColCheckA;
	}
	
}
