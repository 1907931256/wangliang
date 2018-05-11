
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

namespace BZGUI
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class Frm_Par : System.Windows.Forms.Form
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
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Par));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label144 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.TextBox_1 = new System.Windows.Forms.TextBox();
            this.TextBox_2 = new System.Windows.Forms.TextBox();
            this.TextBox_22 = new System.Windows.Forms.TextBox();
            this.TextBox_23 = new System.Windows.Forms.TextBox();
            this.TextBox_43 = new System.Windows.Forms.TextBox();
            this.TextBox_44 = new System.Windows.Forms.TextBox();
            this.TextBox_3 = new System.Windows.Forms.TextBox();
            this.TextBox_4 = new System.Windows.Forms.TextBox();
            this.TextBox_24 = new System.Windows.Forms.TextBox();
            this.TextBox_25 = new System.Windows.Forms.TextBox();
            this.TextBox_45 = new System.Windows.Forms.TextBox();
            this.TextBox_46 = new System.Windows.Forms.TextBox();
            this.TextBox_5 = new System.Windows.Forms.TextBox();
            this.TextBox_6 = new System.Windows.Forms.TextBox();
            this.TextBox_7 = new System.Windows.Forms.TextBox();
            this.TextBox_26 = new System.Windows.Forms.TextBox();
            this.TextBox_27 = new System.Windows.Forms.TextBox();
            this.TextBox_28 = new System.Windows.Forms.TextBox();
            this.TextBox_47 = new System.Windows.Forms.TextBox();
            this.TextBox_48 = new System.Windows.Forms.TextBox();
            this.TextBox_49 = new System.Windows.Forms.TextBox();
            this.TextBox_8 = new System.Windows.Forms.TextBox();
            this.TextBox_9 = new System.Windows.Forms.TextBox();
            this.TextBox_10 = new System.Windows.Forms.TextBox();
            this.TextBox_29 = new System.Windows.Forms.TextBox();
            this.TextBox_30 = new System.Windows.Forms.TextBox();
            this.TextBox_31 = new System.Windows.Forms.TextBox();
            this.TextBox_50 = new System.Windows.Forms.TextBox();
            this.TextBox_51 = new System.Windows.Forms.TextBox();
            this.TextBox_52 = new System.Windows.Forms.TextBox();
            this.TextBox_11 = new System.Windows.Forms.TextBox();
            this.TextBox_12 = new System.Windows.Forms.TextBox();
            this.TextBox_13 = new System.Windows.Forms.TextBox();
            this.TextBox_32 = new System.Windows.Forms.TextBox();
            this.TextBox_33 = new System.Windows.Forms.TextBox();
            this.TextBox_34 = new System.Windows.Forms.TextBox();
            this.TextBox_53 = new System.Windows.Forms.TextBox();
            this.TextBox_54 = new System.Windows.Forms.TextBox();
            this.TextBox_55 = new System.Windows.Forms.TextBox();
            this.TextBox_14 = new System.Windows.Forms.TextBox();
            this.TextBox_15 = new System.Windows.Forms.TextBox();
            this.TextBox_16 = new System.Windows.Forms.TextBox();
            this.TextBox_35 = new System.Windows.Forms.TextBox();
            this.TextBox_36 = new System.Windows.Forms.TextBox();
            this.TextBox_37 = new System.Windows.Forms.TextBox();
            this.TextBox_56 = new System.Windows.Forms.TextBox();
            this.TextBox_57 = new System.Windows.Forms.TextBox();
            this.TextBox_58 = new System.Windows.Forms.TextBox();
            this.TextBox_17 = new System.Windows.Forms.TextBox();
            this.TextBox_38 = new System.Windows.Forms.TextBox();
            this.TextBox_59 = new System.Windows.Forms.TextBox();
            this.TextBox_18 = new System.Windows.Forms.TextBox();
            this.TextBox_39 = new System.Windows.Forms.TextBox();
            this.TextBox_60 = new System.Windows.Forms.TextBox();
            this.TextBox_19 = new System.Windows.Forms.TextBox();
            this.TextBox_40 = new System.Windows.Forms.TextBox();
            this.TextBox_61 = new System.Windows.Forms.TextBox();
            this.TextBox_20 = new System.Windows.Forms.TextBox();
            this.TextBox_41 = new System.Windows.Forms.TextBox();
            this.TextBox_62 = new System.Windows.Forms.TextBox();
            this.TextBox_21 = new System.Windows.Forms.TextBox();
            this.TextBox_42 = new System.Windows.Forms.TextBox();
            this.TextBox_63 = new System.Windows.Forms.TextBox();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.Label59 = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.Label62 = new System.Windows.Forms.Label();
            this.Label63 = new System.Windows.Forms.Label();
            this.Label64 = new System.Windows.Forms.Label();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.Label67 = new System.Windows.Forms.Label();
            this.Label68 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label75 = new System.Windows.Forms.Label();
            this.Label76 = new System.Windows.Forms.Label();
            this.Label77 = new System.Windows.Forms.Label();
            this.Label78 = new System.Windows.Forms.Label();
            this.Label79 = new System.Windows.Forms.Label();
            this.Label80 = new System.Windows.Forms.Label();
            this.Label81 = new System.Windows.Forms.Label();
            this.Label82 = new System.Windows.Forms.Label();
            this.Label83 = new System.Windows.Forms.Label();
            this.Label84 = new System.Windows.Forms.Label();
            this.Label85 = new System.Windows.Forms.Label();
            this.Label86 = new System.Windows.Forms.Label();
            this.Label87 = new System.Windows.Forms.Label();
            this.Label88 = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.Label65 = new System.Windows.Forms.Label();
            this.Label71 = new System.Windows.Forms.Label();
            this.Label70 = new System.Windows.Forms.Label();
            this.Label69 = new System.Windows.Forms.Label();
            this.Label92 = new System.Windows.Forms.Label();
            this.Label95 = new System.Windows.Forms.Label();
            this.Label96 = new System.Windows.Forms.Label();
            this.Label98 = new System.Windows.Forms.Label();
            this.Label97 = new System.Windows.Forms.Label();
            this.Label94 = new System.Windows.Forms.Label();
            this.Label93 = new System.Windows.Forms.Label();
            this.Label100 = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.Label103 = new System.Windows.Forms.Label();
            this.Label102 = new System.Windows.Forms.Label();
            this.Label101 = new System.Windows.Forms.Label();
            this.Label104 = new System.Windows.Forms.Label();
            this.Label105 = new System.Windows.Forms.Label();
            this.Label106 = new System.Windows.Forms.Label();
            this.Label107 = new System.Windows.Forms.Label();
            this.Label108 = new System.Windows.Forms.Label();
            this.Label109 = new System.Windows.Forms.Label();
            this.Label110 = new System.Windows.Forms.Label();
            this.Label111 = new System.Windows.Forms.Label();
            this.Label112 = new System.Windows.Forms.Label();
            this.Label113 = new System.Windows.Forms.Label();
            this.Label114 = new System.Windows.Forms.Label();
            this.Label115 = new System.Windows.Forms.Label();
            this.Label116 = new System.Windows.Forms.Label();
            this.Label117 = new System.Windows.Forms.Label();
            this.Label118 = new System.Windows.Forms.Label();
            this.Label119 = new System.Windows.Forms.Label();
            this.Label120 = new System.Windows.Forms.Label();
            this.Label121 = new System.Windows.Forms.Label();
            this.Label122 = new System.Windows.Forms.Label();
            this.Label123 = new System.Windows.Forms.Label();
            this.Label124 = new System.Windows.Forms.Label();
            this.Label125 = new System.Windows.Forms.Label();
            this.Label126 = new System.Windows.Forms.Label();
            this.Label127 = new System.Windows.Forms.Label();
            this.Label128 = new System.Windows.Forms.Label();
            this.Label132 = new System.Windows.Forms.Label();
            this.Label133 = new System.Windows.Forms.Label();
            this.Label134 = new System.Windows.Forms.Label();
            this.Label135 = new System.Windows.Forms.Label();
            this.Label136 = new System.Windows.Forms.Label();
            this.Label137 = new System.Windows.Forms.Label();
            this.Label138 = new System.Windows.Forms.Label();
            this.Label139 = new System.Windows.Forms.Label();
            this.Label140 = new System.Windows.Forms.Label();
            this.Label141 = new System.Windows.Forms.Label();
            this.Label142 = new System.Windows.Forms.Label();
            this.Label143 = new System.Windows.Forms.Label();
            this.Label261 = new System.Windows.Forms.Label();
            this.Label264 = new System.Windows.Forms.Label();
            this.Label266 = new System.Windows.Forms.Label();
            this.Label263 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label262 = new System.Windows.Forms.Label();
            this.Label265 = new System.Windows.Forms.Label();
            this.Label90 = new System.Windows.Forms.Label();
            this.Label165 = new System.Windows.Forms.Label();
            this.Label166 = new System.Windows.Forms.Label();
            this.Label167 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Label217 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.CheckBox5 = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.CheckBox7 = new System.Windows.Forms.CheckBox();
            this.CheckBox8 = new System.Windows.Forms.CheckBox();
            this.CheckBox9 = new System.Windows.Forms.CheckBox();
            this.CheckBox10 = new System.Windows.Forms.CheckBox();
            this.CheckBox11 = new System.Windows.Forms.CheckBox();
            this.CheckBox12 = new System.Windows.Forms.CheckBox();
            this.CheckBox13 = new System.Windows.Forms.CheckBox();
            this.CheckBox14 = new System.Windows.Forms.CheckBox();
            this.CheckBox15 = new System.Windows.Forms.CheckBox();
            this.CheckBox16 = new System.Windows.Forms.CheckBox();
            this.CheckBox18 = new System.Windows.Forms.CheckBox();
            this.CheckBox20 = new System.Windows.Forms.CheckBox();
            this.CheckBox21 = new System.Windows.Forms.CheckBox();
            this.CheckBox22 = new System.Windows.Forms.CheckBox();
            this.CheckBox23 = new System.Windows.Forms.CheckBox();
            this.CheckBox24 = new System.Windows.Forms.CheckBox();
            this.CheckBox25 = new System.Windows.Forms.CheckBox();
            this.CheckBox26 = new System.Windows.Forms.CheckBox();
            this.CheckBox27 = new System.Windows.Forms.CheckBox();
            this.CheckBox28 = new System.Windows.Forms.CheckBox();
            this.CheckBox29 = new System.Windows.Forms.CheckBox();
            this.CheckBox30 = new System.Windows.Forms.CheckBox();
            this.CheckBox31 = new System.Windows.Forms.CheckBox();
            this.CheckBox32 = new System.Windows.Forms.CheckBox();
            this.CheckBox34 = new System.Windows.Forms.CheckBox();
            this.CheckBox35 = new System.Windows.Forms.CheckBox();
            this.CheckBox36 = new System.Windows.Forms.CheckBox();
            this.CheckBox37 = new System.Windows.Forms.CheckBox();
            this.CheckBox38 = new System.Windows.Forms.CheckBox();
            this.CheckBox39 = new System.Windows.Forms.CheckBox();
            this.CheckBox40 = new System.Windows.Forms.CheckBox();
            this.CheckBox41 = new System.Windows.Forms.CheckBox();
            this.CheckBox42 = new System.Windows.Forms.CheckBox();
            this.CheckBox43 = new System.Windows.Forms.CheckBox();
            this.CheckBox44 = new System.Windows.Forms.CheckBox();
            this.CheckBox45 = new System.Windows.Forms.CheckBox();
            this.CheckBox46 = new System.Windows.Forms.CheckBox();
            this.CheckBox47 = new System.Windows.Forms.CheckBox();
            this.CheckBox48 = new System.Windows.Forms.CheckBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label180 = new System.Windows.Forms.Label();
            this.Label189 = new System.Windows.Forms.Label();
            this.Label190 = new System.Windows.Forms.Label();
            this.Label191 = new System.Windows.Forms.Label();
            this.Label192 = new System.Windows.Forms.Label();
            this.Label193 = new System.Windows.Forms.Label();
            this.Label194 = new System.Windows.Forms.Label();
            this.Label195 = new System.Windows.Forms.Label();
            this.Label196 = new System.Windows.Forms.Label();
            this.Label197 = new System.Windows.Forms.Label();
            this.Label198 = new System.Windows.Forms.Label();
            this.Label199 = new System.Windows.Forms.Label();
            this.Label212 = new System.Windows.Forms.Label();
            this.Label216 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label179 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox17 = new System.Windows.Forms.CheckBox();
            this.CheckBox19 = new System.Windows.Forms.CheckBox();
            this.CheckBox33 = new System.Windows.Forms.CheckBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Btn_UpadeSoft = new System.Windows.Forms.Button();
            this.GroupBox16 = new System.Windows.Forms.GroupBox();
            this.Button_ErrorCodeOK = new System.Windows.Forms.Button();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Com_ErrorCode1 = new System.Windows.Forms.ComboBox();
            this.Button_ErrorCodeTest = new System.Windows.Forms.Button();
            this.Com_ErrorCode2 = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label170 = new System.Windows.Forms.Label();
            this.txt_PickCCDErrCounts = new System.Windows.Forms.TextBox();
            this.txt_MEMErrCounts = new System.Windows.Forms.TextBox();
            this.Label169 = new System.Windows.Forms.Label();
            this.txt_HsgErrCounts = new System.Windows.Forms.TextBox();
            this.Label89 = new System.Windows.Forms.Label();
            this.txt_PickErrCounts = new System.Windows.Forms.TextBox();
            this.Label130 = new System.Windows.Forms.Label();
            this.txt_HsgSnErrCounts = new System.Windows.Forms.TextBox();
            this.Label131 = new System.Windows.Forms.Label();
            this.GroupBox34 = new System.Windows.Forms.GroupBox();
            this.Label146 = new System.Windows.Forms.Label();
            this.Text_NGCounts = new System.Windows.Forms.TextBox();
            this.Label168 = new System.Windows.Forms.Label();
            this.Text_Yeild = new System.Windows.Forms.TextBox();
            this.Label161 = new System.Windows.Forms.Label();
            this.Btn_ClearCount = new System.Windows.Forms.Button();
            this.Label91 = new System.Windows.Forms.Label();
            this.txt_ProductCounts = new System.Windows.Forms.TextBox();
            this.Text_OKCounts = new System.Windows.Forms.TextBox();
            this.Label129 = new System.Windows.Forms.Label();
            this.Label162 = new System.Windows.Forms.Label();
            this.Label163 = new System.Windows.Forms.Label();
            this.Label164 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Label178 = new System.Windows.Forms.Label();
            this.Label177 = new System.Windows.Forms.Label();
            this.Label175 = new System.Windows.Forms.Label();
            this.Label173 = new System.Windows.Forms.Label();
            this.Label157 = new System.Windows.Forms.Label();
            this.Label156 = new System.Windows.Forms.Label();
            this.Label176 = new System.Windows.Forms.Label();
            this.Label174 = new System.Windows.Forms.Label();
            this.TextMachine1 = new System.Windows.Forms.TextBox();
            this.TextMachine2 = new System.Windows.Forms.TextBox();
            this.TextMachine3 = new System.Windows.Forms.TextBox();
            this.TextMachine4 = new System.Windows.Forms.TextBox();
            this.TextMachine5 = new System.Windows.Forms.TextBox();
            this.TextMachine6 = new System.Windows.Forms.TextBox();
            this.TextMachine7 = new System.Windows.Forms.TextBox();
            this.TextMachine8 = new System.Windows.Forms.TextBox();
            this.TextMachine9 = new System.Windows.Forms.TextBox();
            this.Label254 = new System.Windows.Forms.Label();
            this.TextMachine10 = new System.Windows.Forms.TextBox();
            this.Label155 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label160 = new System.Windows.Forms.Label();
            this.Label151 = new System.Windows.Forms.Label();
            this.Label150 = new System.Windows.Forms.Label();
            this.Label149 = new System.Windows.Forms.Label();
            this.Label148 = new System.Windows.Forms.Label();
            this.Label147 = new System.Windows.Forms.Label();
            this.Label145 = new System.Windows.Forms.Label();
            this.Label152 = new System.Windows.Forms.Label();
            this.Label153 = new System.Windows.Forms.Label();
            this.Label154 = new System.Windows.Forms.Label();
            this.Label158 = new System.Windows.Forms.Label();
            this.Label159 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Btn_ParSave = new System.Windows.Forms.Button();
            this.AxScriptControl1 = new AxMSScriptControl.AxScriptControl();
            this.Btn_ParBackup = new System.Windows.Forms.Button();
            this.Btn_ParKeyboard = new System.Windows.Forms.Button();
            this.Btn_ParEnable = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox34.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AxScriptControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.ItemSize = new System.Drawing.Size(50, 35);
            this.TabControl1.Location = new System.Drawing.Point(3, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(928, 654);
            this.TabControl1.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage1.Controls.Add(this.TableLayoutPanel1);
            this.TabPage1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TabPage1.Location = new System.Drawing.Point(4, 39);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(920, 611);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "  参数设定  ";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 9;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.Label144, 2, 17);
            this.TableLayoutPanel1.Controls.Add(this.Label51, 0, 18);
            this.TableLayoutPanel1.Controls.Add(this.Label50, 0, 17);
            this.TableLayoutPanel1.Controls.Add(this.Label49, 0, 16);
            this.TableLayoutPanel1.Controls.Add(this.Label48, 0, 15);
            this.TableLayoutPanel1.Controls.Add(this.Label47, 0, 14);
            this.TableLayoutPanel1.Controls.Add(this.Label46, 0, 13);
            this.TableLayoutPanel1.Controls.Add(this.Label45, 0, 12);
            this.TableLayoutPanel1.Controls.Add(this.Label44, 0, 11);
            this.TableLayoutPanel1.Controls.Add(this.Label43, 0, 10);
            this.TableLayoutPanel1.Controls.Add(this.Label42, 0, 9);
            this.TableLayoutPanel1.Controls.Add(this.Label41, 0, 8);
            this.TableLayoutPanel1.Controls.Add(this.Label37, 0, 7);
            this.TableLayoutPanel1.Controls.Add(this.Label38, 0, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label40, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label36, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label34, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label39, 0, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label35, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_1, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_2, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_22, 4, 0);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_23, 4, 1);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_43, 7, 0);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_44, 7, 1);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_3, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_4, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_24, 4, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_25, 4, 3);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_45, 7, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_46, 7, 3);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_5, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_6, 1, 5);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_7, 1, 6);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_26, 4, 4);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_27, 4, 5);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_28, 4, 6);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_47, 7, 4);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_48, 7, 5);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_49, 7, 6);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_8, 1, 7);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_9, 1, 8);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_10, 1, 9);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_29, 4, 7);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_30, 4, 8);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_31, 4, 9);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_50, 7, 7);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_51, 7, 8);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_52, 7, 9);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_11, 1, 10);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_12, 1, 11);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_13, 1, 12);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_32, 4, 10);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_33, 4, 11);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_34, 4, 12);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_53, 7, 10);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_54, 7, 11);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_55, 7, 12);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_14, 1, 13);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_15, 1, 14);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_16, 1, 15);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_35, 4, 13);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_36, 4, 14);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_37, 4, 15);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_56, 7, 13);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_57, 7, 14);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_58, 7, 15);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_17, 1, 16);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_38, 4, 16);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_59, 7, 16);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_18, 1, 17);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_39, 4, 17);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_60, 7, 17);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_19, 1, 18);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_40, 4, 18);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_61, 7, 18);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_20, 1, 19);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_41, 4, 19);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_62, 7, 19);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_21, 1, 20);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_42, 4, 20);
            this.TableLayoutPanel1.Controls.Add(this.TextBox_63, 7, 20);
            this.TableLayoutPanel1.Controls.Add(this.Label55, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label58, 3, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label54, 3, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label57, 3, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label53, 3, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label52, 3, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label56, 3, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label59, 3, 7);
            this.TableLayoutPanel1.Controls.Add(this.Label61, 3, 8);
            this.TableLayoutPanel1.Controls.Add(this.Label62, 3, 9);
            this.TableLayoutPanel1.Controls.Add(this.Label63, 3, 10);
            this.TableLayoutPanel1.Controls.Add(this.Label64, 3, 11);
            this.TableLayoutPanel1.Controls.Add(this.Label60, 3, 12);
            this.TableLayoutPanel1.Controls.Add(this.Label66, 3, 13);
            this.TableLayoutPanel1.Controls.Add(this.Label67, 3, 14);
            this.TableLayoutPanel1.Controls.Add(this.Label68, 3, 15);
            this.TableLayoutPanel1.Controls.Add(this.Label73, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label74, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label75, 2, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label76, 2, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label77, 2, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label78, 2, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label79, 2, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label80, 2, 7);
            this.TableLayoutPanel1.Controls.Add(this.Label81, 2, 8);
            this.TableLayoutPanel1.Controls.Add(this.Label82, 2, 9);
            this.TableLayoutPanel1.Controls.Add(this.Label83, 2, 10);
            this.TableLayoutPanel1.Controls.Add(this.Label84, 2, 11);
            this.TableLayoutPanel1.Controls.Add(this.Label85, 2, 12);
            this.TableLayoutPanel1.Controls.Add(this.Label86, 2, 13);
            this.TableLayoutPanel1.Controls.Add(this.Label87, 2, 14);
            this.TableLayoutPanel1.Controls.Add(this.Label88, 2, 15);
            this.TableLayoutPanel1.Controls.Add(this.Label72, 6, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label65, 6, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label71, 6, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label70, 6, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label69, 6, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label92, 5, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label95, 8, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label96, 8, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label98, 8, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label97, 8, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label94, 5, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label93, 5, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label100, 3, 16);
            this.TableLayoutPanel1.Controls.Add(this.Label99, 6, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label103, 6, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label102, 6, 7);
            this.TableLayoutPanel1.Controls.Add(this.Label101, 3, 17);
            this.TableLayoutPanel1.Controls.Add(this.Label104, 3, 18);
            this.TableLayoutPanel1.Controls.Add(this.Label105, 6, 8);
            this.TableLayoutPanel1.Controls.Add(this.Label106, 6, 9);
            this.TableLayoutPanel1.Controls.Add(this.Label107, 6, 10);
            this.TableLayoutPanel1.Controls.Add(this.Label108, 6, 11);
            this.TableLayoutPanel1.Controls.Add(this.Label109, 6, 12);
            this.TableLayoutPanel1.Controls.Add(this.Label110, 6, 13);
            this.TableLayoutPanel1.Controls.Add(this.Label111, 6, 14);
            this.TableLayoutPanel1.Controls.Add(this.Label112, 6, 15);
            this.TableLayoutPanel1.Controls.Add(this.Label113, 6, 16);
            this.TableLayoutPanel1.Controls.Add(this.Label114, 6, 17);
            this.TableLayoutPanel1.Controls.Add(this.Label115, 6, 18);
            this.TableLayoutPanel1.Controls.Add(this.Label116, 5, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label117, 5, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label118, 5, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label119, 5, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label120, 5, 7);
            this.TableLayoutPanel1.Controls.Add(this.Label121, 5, 8);
            this.TableLayoutPanel1.Controls.Add(this.Label122, 5, 9);
            this.TableLayoutPanel1.Controls.Add(this.Label123, 5, 10);
            this.TableLayoutPanel1.Controls.Add(this.Label124, 5, 11);
            this.TableLayoutPanel1.Controls.Add(this.Label125, 5, 12);
            this.TableLayoutPanel1.Controls.Add(this.Label126, 5, 13);
            this.TableLayoutPanel1.Controls.Add(this.Label127, 5, 14);
            this.TableLayoutPanel1.Controls.Add(this.Label128, 5, 15);
            this.TableLayoutPanel1.Controls.Add(this.Label132, 8, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label133, 8, 5);
            this.TableLayoutPanel1.Controls.Add(this.Label134, 8, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label135, 8, 7);
            this.TableLayoutPanel1.Controls.Add(this.Label136, 8, 8);
            this.TableLayoutPanel1.Controls.Add(this.Label137, 8, 9);
            this.TableLayoutPanel1.Controls.Add(this.Label138, 8, 10);
            this.TableLayoutPanel1.Controls.Add(this.Label139, 8, 11);
            this.TableLayoutPanel1.Controls.Add(this.Label140, 8, 12);
            this.TableLayoutPanel1.Controls.Add(this.Label141, 8, 13);
            this.TableLayoutPanel1.Controls.Add(this.Label142, 8, 14);
            this.TableLayoutPanel1.Controls.Add(this.Label143, 8, 15);
            this.TableLayoutPanel1.Controls.Add(this.Label261, 0, 19);
            this.TableLayoutPanel1.Controls.Add(this.Label264, 0, 20);
            this.TableLayoutPanel1.Controls.Add(this.Label266, 6, 20);
            this.TableLayoutPanel1.Controls.Add(this.Label263, 6, 19);
            this.TableLayoutPanel1.Controls.Add(this.Label33, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label262, 3, 19);
            this.TableLayoutPanel1.Controls.Add(this.Label265, 3, 20);
            this.TableLayoutPanel1.Controls.Add(this.Label90, 2, 16);
            this.TableLayoutPanel1.Controls.Add(this.Label165, 2, 18);
            this.TableLayoutPanel1.Controls.Add(this.Label166, 2, 19);
            this.TableLayoutPanel1.Controls.Add(this.Label167, 2, 20);
            this.TableLayoutPanel1.Enabled = false;
            this.TableLayoutPanel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(66, 16);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 21;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(824, 590);
            this.TableLayoutPanel1.TabIndex = 5;
            // 
            // Label144
            // 
            this.Label144.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label144.Location = new System.Drawing.Point(208, 476);
            this.Label144.Name = "Label144";
            this.Label144.Size = new System.Drawing.Size(30, 25);
            this.Label144.TabIndex = 185;
            this.Label144.Text = "kg";
            this.Label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label51
            // 
            this.Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.Location = new System.Drawing.Point(3, 504);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(112, 20);
            this.Label51.TabIndex = 37;
            this.Label51.Text = "2站装配压力:";
            this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label50
            // 
            this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label50.Location = new System.Drawing.Point(3, 476);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(112, 20);
            this.Label50.TabIndex = 35;
            this.Label50.Text = "装配高度偏移:";
            this.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label49
            // 
            this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label49.Location = new System.Drawing.Point(3, 448);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(112, 20);
            this.Label49.TabIndex = 33;
            this.Label49.Text = "精补正高度偏移:";
            this.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label48
            // 
            this.Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label48.Location = new System.Drawing.Point(3, 420);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(112, 25);
            this.Label48.TabIndex = 30;
            this.Label48.Text = "备用参数:";
            this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label47
            // 
            this.Label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label47.Location = new System.Drawing.Point(3, 392);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(112, 25);
            this.Label47.TabIndex = 29;
            this.Label47.Text = "备用参数:";
            this.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label46
            // 
            this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(3, 364);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(112, 25);
            this.Label46.TabIndex = 27;
            this.Label46.Text = "备用参数:";
            this.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label45
            // 
            this.Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label45.Location = new System.Drawing.Point(3, 336);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(112, 25);
            this.Label45.TabIndex = 25;
            this.Label45.Text = "备用参数:";
            this.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label44
            // 
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label44.Location = new System.Drawing.Point(3, 308);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(112, 25);
            this.Label44.TabIndex = 23;
            this.Label44.Text = "备用参数:";
            this.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label43
            // 
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label43.Location = new System.Drawing.Point(3, 280);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(112, 25);
            this.Label43.TabIndex = 21;
            this.Label43.Text = "备用参数:";
            this.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label42
            // 
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label42.Location = new System.Drawing.Point(3, 252);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(112, 25);
            this.Label42.TabIndex = 19;
            this.Label42.Text = "备用参数:";
            this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label41
            // 
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label41.Location = new System.Drawing.Point(3, 224);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(112, 25);
            this.Label41.TabIndex = 17;
            this.Label41.Text = "旋转半径:";
            this.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label37
            // 
            this.Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label37.Location = new System.Drawing.Point(3, 196);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(112, 25);
            this.Label37.TabIndex = 14;
            this.Label37.Text = "备用参数:";
            this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label38
            // 
            this.Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label38.Location = new System.Drawing.Point(3, 168);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(112, 25);
            this.Label38.TabIndex = 12;
            this.Label38.Text = "取料补偿T:";
            this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label40
            // 
            this.Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label40.Location = new System.Drawing.Point(3, 112);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(112, 25);
            this.Label40.TabIndex = 8;
            this.Label40.Text = "取料补偿X:";
            this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label36
            // 
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label36.Location = new System.Drawing.Point(3, 84);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(112, 25);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "备用参数:";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label34
            // 
            this.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label34.Location = new System.Drawing.Point(3, 28);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(112, 25);
            this.Label34.TabIndex = 2;
            this.Label34.Text = "组装补偿Y:";
            this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label39
            // 
            this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label39.Location = new System.Drawing.Point(3, 140);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(112, 25);
            this.Label39.TabIndex = 10;
            this.Label39.Text = "取料补偿Y:";
            this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label35
            // 
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label35.Location = new System.Drawing.Point(3, 56);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(112, 25);
            this.Label35.TabIndex = 4;
            this.Label35.Text = "组装补偿T:";
            this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBox_1
            // 
            this.TextBox_1.BackColor = System.Drawing.Color.White;
            this.TextBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_1.Location = new System.Drawing.Point(121, 3);
            this.TextBox_1.Name = "TextBox_1";
            this.TextBox_1.Size = new System.Drawing.Size(80, 23);
            this.TextBox_1.TabIndex = 1;
            this.TextBox_1.Text = "0.000";
            this.TextBox_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_2
            // 
            this.TextBox_2.BackColor = System.Drawing.Color.White;
            this.TextBox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_2.Location = new System.Drawing.Point(121, 31);
            this.TextBox_2.Name = "TextBox_2";
            this.TextBox_2.Size = new System.Drawing.Size(80, 23);
            this.TextBox_2.TabIndex = 3;
            this.TextBox_2.Text = "0.000";
            this.TextBox_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_22
            // 
            this.TextBox_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_22.Location = new System.Drawing.Point(386, 3);
            this.TextBox_22.Name = "TextBox_22";
            this.TextBox_22.Size = new System.Drawing.Size(80, 23);
            this.TextBox_22.TabIndex = 38;
            this.TextBox_22.Text = "0.000";
            this.TextBox_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_23
            // 
            this.TextBox_23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_23.Location = new System.Drawing.Point(386, 31);
            this.TextBox_23.Name = "TextBox_23";
            this.TextBox_23.Size = new System.Drawing.Size(80, 23);
            this.TextBox_23.TabIndex = 61;
            this.TextBox_23.Text = "0.000";
            this.TextBox_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_43
            // 
            this.TextBox_43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_43.Location = new System.Drawing.Point(667, 3);
            this.TextBox_43.Name = "TextBox_43";
            this.TextBox_43.Size = new System.Drawing.Size(80, 23);
            this.TextBox_43.TabIndex = 98;
            this.TextBox_43.Text = "0.000";
            this.TextBox_43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_44
            // 
            this.TextBox_44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_44.Location = new System.Drawing.Point(667, 31);
            this.TextBox_44.Name = "TextBox_44";
            this.TextBox_44.Size = new System.Drawing.Size(80, 23);
            this.TextBox_44.TabIndex = 99;
            this.TextBox_44.Text = "0.000";
            this.TextBox_44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_3
            // 
            this.TextBox_3.BackColor = System.Drawing.Color.White;
            this.TextBox_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_3.Location = new System.Drawing.Point(121, 59);
            this.TextBox_3.Name = "TextBox_3";
            this.TextBox_3.Size = new System.Drawing.Size(80, 23);
            this.TextBox_3.TabIndex = 5;
            this.TextBox_3.Text = "0.000";
            this.TextBox_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_4
            // 
            this.TextBox_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_4.Location = new System.Drawing.Point(121, 87);
            this.TextBox_4.Name = "TextBox_4";
            this.TextBox_4.Size = new System.Drawing.Size(80, 23);
            this.TextBox_4.TabIndex = 7;
            this.TextBox_4.Text = "0.000";
            this.TextBox_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_24
            // 
            this.TextBox_24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_24.Location = new System.Drawing.Point(386, 59);
            this.TextBox_24.Name = "TextBox_24";
            this.TextBox_24.Size = new System.Drawing.Size(80, 23);
            this.TextBox_24.TabIndex = 62;
            this.TextBox_24.Text = "0.000";
            this.TextBox_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_25
            // 
            this.TextBox_25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_25.Location = new System.Drawing.Point(386, 87);
            this.TextBox_25.Name = "TextBox_25";
            this.TextBox_25.Size = new System.Drawing.Size(80, 23);
            this.TextBox_25.TabIndex = 63;
            this.TextBox_25.Text = "0.000";
            this.TextBox_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_45
            // 
            this.TextBox_45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_45.Location = new System.Drawing.Point(667, 59);
            this.TextBox_45.Name = "TextBox_45";
            this.TextBox_45.Size = new System.Drawing.Size(80, 23);
            this.TextBox_45.TabIndex = 100;
            this.TextBox_45.Text = "0.000";
            this.TextBox_45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_46
            // 
            this.TextBox_46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_46.Location = new System.Drawing.Point(667, 87);
            this.TextBox_46.Name = "TextBox_46";
            this.TextBox_46.Size = new System.Drawing.Size(80, 23);
            this.TextBox_46.TabIndex = 101;
            this.TextBox_46.Text = "0.000";
            this.TextBox_46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_5
            // 
            this.TextBox_5.BackColor = System.Drawing.Color.White;
            this.TextBox_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_5.Location = new System.Drawing.Point(121, 115);
            this.TextBox_5.Name = "TextBox_5";
            this.TextBox_5.Size = new System.Drawing.Size(80, 23);
            this.TextBox_5.TabIndex = 15;
            this.TextBox_5.Text = "0.000";
            this.TextBox_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_6
            // 
            this.TextBox_6.BackColor = System.Drawing.Color.White;
            this.TextBox_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_6.Location = new System.Drawing.Point(121, 143);
            this.TextBox_6.Name = "TextBox_6";
            this.TextBox_6.Size = new System.Drawing.Size(80, 23);
            this.TextBox_6.TabIndex = 13;
            this.TextBox_6.Text = "0.000";
            this.TextBox_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_7
            // 
            this.TextBox_7.BackColor = System.Drawing.Color.White;
            this.TextBox_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_7.Location = new System.Drawing.Point(121, 171);
            this.TextBox_7.Name = "TextBox_7";
            this.TextBox_7.Size = new System.Drawing.Size(80, 23);
            this.TextBox_7.TabIndex = 11;
            this.TextBox_7.Text = "0.000";
            this.TextBox_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_26
            // 
            this.TextBox_26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_26.Location = new System.Drawing.Point(386, 115);
            this.TextBox_26.Name = "TextBox_26";
            this.TextBox_26.Size = new System.Drawing.Size(80, 23);
            this.TextBox_26.TabIndex = 64;
            this.TextBox_26.Text = "0.000";
            this.TextBox_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_27
            // 
            this.TextBox_27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_27.Location = new System.Drawing.Point(386, 143);
            this.TextBox_27.Name = "TextBox_27";
            this.TextBox_27.Size = new System.Drawing.Size(80, 23);
            this.TextBox_27.TabIndex = 65;
            this.TextBox_27.Text = "0.000";
            this.TextBox_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_28
            // 
            this.TextBox_28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_28.Location = new System.Drawing.Point(386, 171);
            this.TextBox_28.Name = "TextBox_28";
            this.TextBox_28.Size = new System.Drawing.Size(80, 23);
            this.TextBox_28.TabIndex = 66;
            this.TextBox_28.Text = "0.000";
            this.TextBox_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_47
            // 
            this.TextBox_47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_47.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_47.Location = new System.Drawing.Point(667, 115);
            this.TextBox_47.Name = "TextBox_47";
            this.TextBox_47.Size = new System.Drawing.Size(80, 23);
            this.TextBox_47.TabIndex = 157;
            this.TextBox_47.Text = "0.000";
            this.TextBox_47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_48
            // 
            this.TextBox_48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_48.Location = new System.Drawing.Point(667, 143);
            this.TextBox_48.Name = "TextBox_48";
            this.TextBox_48.Size = new System.Drawing.Size(80, 23);
            this.TextBox_48.TabIndex = 158;
            this.TextBox_48.Text = "0.000";
            this.TextBox_48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_49
            // 
            this.TextBox_49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_49.Location = new System.Drawing.Point(667, 171);
            this.TextBox_49.Name = "TextBox_49";
            this.TextBox_49.Size = new System.Drawing.Size(80, 23);
            this.TextBox_49.TabIndex = 159;
            this.TextBox_49.Text = "0.000";
            this.TextBox_49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_8
            // 
            this.TextBox_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_8.Location = new System.Drawing.Point(121, 199);
            this.TextBox_8.Name = "TextBox_8";
            this.TextBox_8.Size = new System.Drawing.Size(80, 23);
            this.TextBox_8.TabIndex = 9;
            this.TextBox_8.Text = "0.000";
            this.TextBox_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_9
            // 
            this.TextBox_9.BackColor = System.Drawing.Color.White;
            this.TextBox_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_9.Location = new System.Drawing.Point(121, 227);
            this.TextBox_9.Name = "TextBox_9";
            this.TextBox_9.Size = new System.Drawing.Size(80, 23);
            this.TextBox_9.TabIndex = 16;
            this.TextBox_9.Text = "0.000";
            this.TextBox_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_10
            // 
            this.TextBox_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_10.Location = new System.Drawing.Point(121, 255);
            this.TextBox_10.Name = "TextBox_10";
            this.TextBox_10.Size = new System.Drawing.Size(80, 23);
            this.TextBox_10.TabIndex = 18;
            this.TextBox_10.Text = "0.000";
            this.TextBox_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_29
            // 
            this.TextBox_29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_29.Location = new System.Drawing.Point(386, 199);
            this.TextBox_29.Name = "TextBox_29";
            this.TextBox_29.Size = new System.Drawing.Size(80, 23);
            this.TextBox_29.TabIndex = 86;
            this.TextBox_29.Text = "0.000";
            this.TextBox_29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_30
            // 
            this.TextBox_30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_30.Location = new System.Drawing.Point(386, 227);
            this.TextBox_30.Name = "TextBox_30";
            this.TextBox_30.Size = new System.Drawing.Size(80, 23);
            this.TextBox_30.TabIndex = 87;
            this.TextBox_30.Text = "0.000";
            this.TextBox_30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_31
            // 
            this.TextBox_31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_31.Location = new System.Drawing.Point(386, 255);
            this.TextBox_31.Name = "TextBox_31";
            this.TextBox_31.Size = new System.Drawing.Size(80, 23);
            this.TextBox_31.TabIndex = 88;
            this.TextBox_31.Text = "0.000";
            this.TextBox_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_50
            // 
            this.TextBox_50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_50.Location = new System.Drawing.Point(667, 199);
            this.TextBox_50.Name = "TextBox_50";
            this.TextBox_50.Size = new System.Drawing.Size(80, 23);
            this.TextBox_50.TabIndex = 160;
            this.TextBox_50.Text = "0.000";
            this.TextBox_50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_51
            // 
            this.TextBox_51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_51.Location = new System.Drawing.Point(667, 227);
            this.TextBox_51.Name = "TextBox_51";
            this.TextBox_51.Size = new System.Drawing.Size(80, 23);
            this.TextBox_51.TabIndex = 161;
            this.TextBox_51.Text = "0.000";
            this.TextBox_51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_52
            // 
            this.TextBox_52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_52.Location = new System.Drawing.Point(667, 255);
            this.TextBox_52.Name = "TextBox_52";
            this.TextBox_52.Size = new System.Drawing.Size(80, 23);
            this.TextBox_52.TabIndex = 162;
            this.TextBox_52.Text = "0.000";
            this.TextBox_52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_11
            // 
            this.TextBox_11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_11.Location = new System.Drawing.Point(121, 283);
            this.TextBox_11.Name = "TextBox_11";
            this.TextBox_11.Size = new System.Drawing.Size(80, 23);
            this.TextBox_11.TabIndex = 20;
            this.TextBox_11.Text = "0.000";
            this.TextBox_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_12
            // 
            this.TextBox_12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_12.Location = new System.Drawing.Point(121, 311);
            this.TextBox_12.Name = "TextBox_12";
            this.TextBox_12.Size = new System.Drawing.Size(80, 23);
            this.TextBox_12.TabIndex = 22;
            this.TextBox_12.Text = "0.000";
            this.TextBox_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_13
            // 
            this.TextBox_13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_13.Location = new System.Drawing.Point(121, 339);
            this.TextBox_13.Name = "TextBox_13";
            this.TextBox_13.Size = new System.Drawing.Size(80, 23);
            this.TextBox_13.TabIndex = 24;
            this.TextBox_13.Text = "0.000";
            this.TextBox_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_32
            // 
            this.TextBox_32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_32.Location = new System.Drawing.Point(386, 283);
            this.TextBox_32.Name = "TextBox_32";
            this.TextBox_32.Size = new System.Drawing.Size(80, 23);
            this.TextBox_32.TabIndex = 89;
            this.TextBox_32.Text = "0.000";
            this.TextBox_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_33
            // 
            this.TextBox_33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_33.Location = new System.Drawing.Point(386, 311);
            this.TextBox_33.Name = "TextBox_33";
            this.TextBox_33.Size = new System.Drawing.Size(80, 23);
            this.TextBox_33.TabIndex = 90;
            this.TextBox_33.Text = "0.000";
            this.TextBox_33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_34
            // 
            this.TextBox_34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_34.Location = new System.Drawing.Point(386, 339);
            this.TextBox_34.Name = "TextBox_34";
            this.TextBox_34.Size = new System.Drawing.Size(80, 23);
            this.TextBox_34.TabIndex = 91;
            this.TextBox_34.Text = "0.000";
            this.TextBox_34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_53
            // 
            this.TextBox_53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_53.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_53.Location = new System.Drawing.Point(667, 283);
            this.TextBox_53.Name = "TextBox_53";
            this.TextBox_53.Size = new System.Drawing.Size(80, 23);
            this.TextBox_53.TabIndex = 163;
            this.TextBox_53.Text = "0.000";
            this.TextBox_53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_54
            // 
            this.TextBox_54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_54.Location = new System.Drawing.Point(667, 311);
            this.TextBox_54.Name = "TextBox_54";
            this.TextBox_54.Size = new System.Drawing.Size(80, 23);
            this.TextBox_54.TabIndex = 164;
            this.TextBox_54.Text = "0.000";
            this.TextBox_54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_55
            // 
            this.TextBox_55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_55.Location = new System.Drawing.Point(667, 339);
            this.TextBox_55.Name = "TextBox_55";
            this.TextBox_55.Size = new System.Drawing.Size(80, 23);
            this.TextBox_55.TabIndex = 165;
            this.TextBox_55.Text = "0.000";
            this.TextBox_55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_14
            // 
            this.TextBox_14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_14.Location = new System.Drawing.Point(121, 367);
            this.TextBox_14.Name = "TextBox_14";
            this.TextBox_14.Size = new System.Drawing.Size(80, 23);
            this.TextBox_14.TabIndex = 26;
            this.TextBox_14.Text = "0.000";
            this.TextBox_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_15
            // 
            this.TextBox_15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_15.Location = new System.Drawing.Point(121, 395);
            this.TextBox_15.Name = "TextBox_15";
            this.TextBox_15.Size = new System.Drawing.Size(80, 23);
            this.TextBox_15.TabIndex = 28;
            this.TextBox_15.Text = "0.000";
            this.TextBox_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_16
            // 
            this.TextBox_16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_16.Location = new System.Drawing.Point(121, 423);
            this.TextBox_16.Name = "TextBox_16";
            this.TextBox_16.Size = new System.Drawing.Size(80, 23);
            this.TextBox_16.TabIndex = 31;
            this.TextBox_16.Text = "0.000";
            this.TextBox_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_35
            // 
            this.TextBox_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_35.Location = new System.Drawing.Point(386, 367);
            this.TextBox_35.Name = "TextBox_35";
            this.TextBox_35.Size = new System.Drawing.Size(80, 23);
            this.TextBox_35.TabIndex = 92;
            this.TextBox_35.Text = "0.000";
            this.TextBox_35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_36
            // 
            this.TextBox_36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_36.Location = new System.Drawing.Point(386, 395);
            this.TextBox_36.Name = "TextBox_36";
            this.TextBox_36.Size = new System.Drawing.Size(80, 23);
            this.TextBox_36.TabIndex = 93;
            this.TextBox_36.Text = "0.000";
            this.TextBox_36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_37
            // 
            this.TextBox_37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_37.Location = new System.Drawing.Point(386, 423);
            this.TextBox_37.Name = "TextBox_37";
            this.TextBox_37.Size = new System.Drawing.Size(80, 23);
            this.TextBox_37.TabIndex = 94;
            this.TextBox_37.Text = "0.000";
            this.TextBox_37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_56
            // 
            this.TextBox_56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_56.Location = new System.Drawing.Point(667, 367);
            this.TextBox_56.Name = "TextBox_56";
            this.TextBox_56.Size = new System.Drawing.Size(80, 23);
            this.TextBox_56.TabIndex = 166;
            this.TextBox_56.Text = "0.000";
            this.TextBox_56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_57
            // 
            this.TextBox_57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_57.Location = new System.Drawing.Point(667, 395);
            this.TextBox_57.Name = "TextBox_57";
            this.TextBox_57.Size = new System.Drawing.Size(80, 23);
            this.TextBox_57.TabIndex = 167;
            this.TextBox_57.Text = "0.000";
            this.TextBox_57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_58
            // 
            this.TextBox_58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_58.Location = new System.Drawing.Point(667, 423);
            this.TextBox_58.Name = "TextBox_58";
            this.TextBox_58.Size = new System.Drawing.Size(80, 23);
            this.TextBox_58.TabIndex = 168;
            this.TextBox_58.Text = "0.000";
            this.TextBox_58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_17
            // 
            this.TextBox_17.BackColor = System.Drawing.Color.White;
            this.TextBox_17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_17.Location = new System.Drawing.Point(121, 451);
            this.TextBox_17.Name = "TextBox_17";
            this.TextBox_17.Size = new System.Drawing.Size(80, 23);
            this.TextBox_17.TabIndex = 32;
            this.TextBox_17.Text = "0.000";
            this.TextBox_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_38
            // 
            this.TextBox_38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_38.Location = new System.Drawing.Point(386, 451);
            this.TextBox_38.Name = "TextBox_38";
            this.TextBox_38.Size = new System.Drawing.Size(80, 23);
            this.TextBox_38.TabIndex = 95;
            this.TextBox_38.Text = "0.000";
            this.TextBox_38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_59
            // 
            this.TextBox_59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_59.Location = new System.Drawing.Point(667, 451);
            this.TextBox_59.Name = "TextBox_59";
            this.TextBox_59.Size = new System.Drawing.Size(80, 23);
            this.TextBox_59.TabIndex = 169;
            this.TextBox_59.Text = "0.000";
            this.TextBox_59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_18
            // 
            this.TextBox_18.BackColor = System.Drawing.Color.White;
            this.TextBox_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_18.Location = new System.Drawing.Point(121, 479);
            this.TextBox_18.Name = "TextBox_18";
            this.TextBox_18.Size = new System.Drawing.Size(80, 23);
            this.TextBox_18.TabIndex = 34;
            this.TextBox_18.Text = "0.000";
            this.TextBox_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_39
            // 
            this.TextBox_39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_39.Location = new System.Drawing.Point(386, 479);
            this.TextBox_39.Name = "TextBox_39";
            this.TextBox_39.Size = new System.Drawing.Size(80, 23);
            this.TextBox_39.TabIndex = 96;
            this.TextBox_39.Text = "0.000";
            this.TextBox_39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_60
            // 
            this.TextBox_60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_60.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_60.Location = new System.Drawing.Point(667, 479);
            this.TextBox_60.Name = "TextBox_60";
            this.TextBox_60.Size = new System.Drawing.Size(80, 23);
            this.TextBox_60.TabIndex = 170;
            this.TextBox_60.Text = "0.000";
            this.TextBox_60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_19
            // 
            this.TextBox_19.BackColor = System.Drawing.Color.White;
            this.TextBox_19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_19.Location = new System.Drawing.Point(121, 507);
            this.TextBox_19.Name = "TextBox_19";
            this.TextBox_19.Size = new System.Drawing.Size(80, 23);
            this.TextBox_19.TabIndex = 36;
            this.TextBox_19.Text = "0.000";
            this.TextBox_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_40
            // 
            this.TextBox_40.BackColor = System.Drawing.Color.White;
            this.TextBox_40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_40.Location = new System.Drawing.Point(386, 507);
            this.TextBox_40.Name = "TextBox_40";
            this.TextBox_40.Size = new System.Drawing.Size(80, 23);
            this.TextBox_40.TabIndex = 97;
            this.TextBox_40.Text = "0.000";
            this.TextBox_40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_61
            // 
            this.TextBox_61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_61.Location = new System.Drawing.Point(667, 507);
            this.TextBox_61.Name = "TextBox_61";
            this.TextBox_61.Size = new System.Drawing.Size(80, 23);
            this.TextBox_61.TabIndex = 171;
            this.TextBox_61.Text = "0.000";
            this.TextBox_61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_20
            // 
            this.TextBox_20.BackColor = System.Drawing.Color.White;
            this.TextBox_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_20.Location = new System.Drawing.Point(121, 535);
            this.TextBox_20.Name = "TextBox_20";
            this.TextBox_20.Size = new System.Drawing.Size(80, 23);
            this.TextBox_20.TabIndex = 173;
            this.TextBox_20.Text = "0.000";
            this.TextBox_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_41
            // 
            this.TextBox_41.BackColor = System.Drawing.Color.White;
            this.TextBox_41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_41.Location = new System.Drawing.Point(386, 535);
            this.TextBox_41.Name = "TextBox_41";
            this.TextBox_41.Size = new System.Drawing.Size(80, 23);
            this.TextBox_41.TabIndex = 174;
            this.TextBox_41.Text = "0.000";
            this.TextBox_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_62
            // 
            this.TextBox_62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_62.Location = new System.Drawing.Point(667, 535);
            this.TextBox_62.Name = "TextBox_62";
            this.TextBox_62.Size = new System.Drawing.Size(80, 23);
            this.TextBox_62.TabIndex = 175;
            this.TextBox_62.Text = "0.000";
            this.TextBox_62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_21
            // 
            this.TextBox_21.BackColor = System.Drawing.Color.White;
            this.TextBox_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_21.Location = new System.Drawing.Point(121, 561);
            this.TextBox_21.Name = "TextBox_21";
            this.TextBox_21.Size = new System.Drawing.Size(80, 23);
            this.TextBox_21.TabIndex = 176;
            this.TextBox_21.Text = "0.000";
            this.TextBox_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_42
            // 
            this.TextBox_42.BackColor = System.Drawing.Color.White;
            this.TextBox_42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_42.Location = new System.Drawing.Point(386, 561);
            this.TextBox_42.Name = "TextBox_42";
            this.TextBox_42.Size = new System.Drawing.Size(80, 23);
            this.TextBox_42.TabIndex = 177;
            this.TextBox_42.Text = "0.000";
            this.TextBox_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_63
            // 
            this.TextBox_63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextBox_63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_63.Location = new System.Drawing.Point(667, 561);
            this.TextBox_63.Name = "TextBox_63";
            this.TextBox_63.Size = new System.Drawing.Size(80, 23);
            this.TextBox_63.TabIndex = 178;
            this.TextBox_63.Text = "0.000";
            this.TextBox_63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label55
            // 
            this.Label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label55.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label55.Location = new System.Drawing.Point(254, 0);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(119, 25);
            this.Label55.TabIndex = 42;
            this.Label55.Text = "3站保压距离:";
            this.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label58
            // 
            this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label58.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label58.Location = new System.Drawing.Point(254, 28);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(119, 25);
            this.Label58.TabIndex = 45;
            this.Label58.Text = "3站保压速度:";
            this.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label54
            // 
            this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label54.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label54.Location = new System.Drawing.Point(254, 56);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(119, 20);
            this.Label54.TabIndex = 41;
            this.Label54.Text = "备用参数:";
            this.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label57
            // 
            this.Label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label57.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label57.Location = new System.Drawing.Point(254, 84);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(119, 25);
            this.Label57.TabIndex = 44;
            this.Label57.Text = "备用参数:";
            this.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label53
            // 
            this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label53.Location = new System.Drawing.Point(254, 112);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(119, 25);
            this.Label53.TabIndex = 40;
            this.Label53.Text = "备用参数:";
            this.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label52
            // 
            this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label52.Location = new System.Drawing.Point(254, 140);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(119, 20);
            this.Label52.TabIndex = 39;
            this.Label52.Text = "备用参数:";
            this.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label56
            // 
            this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label56.Location = new System.Drawing.Point(254, 168);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(119, 25);
            this.Label56.TabIndex = 46;
            this.Label56.Text = "备用参数:";
            this.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label59
            // 
            this.Label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label59.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label59.Location = new System.Drawing.Point(254, 196);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(119, 25);
            this.Label59.TabIndex = 47;
            this.Label59.Text = "备用参数:";
            this.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label61
            // 
            this.Label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label61.Location = new System.Drawing.Point(254, 224);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(119, 25);
            this.Label61.TabIndex = 49;
            this.Label61.Text = "备用参数:";
            this.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label62
            // 
            this.Label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label62.Location = new System.Drawing.Point(254, 252);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(119, 25);
            this.Label62.TabIndex = 50;
            this.Label62.Text = "备用参数:";
            this.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label63
            // 
            this.Label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label63.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label63.Location = new System.Drawing.Point(254, 280);
            this.Label63.Name = "Label63";
            this.Label63.Size = new System.Drawing.Size(119, 25);
            this.Label63.TabIndex = 51;
            this.Label63.Text = "备用参数:";
            this.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label64
            // 
            this.Label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label64.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label64.Location = new System.Drawing.Point(254, 308);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(119, 25);
            this.Label64.TabIndex = 52;
            this.Label64.Text = "备用参数:";
            this.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label60
            // 
            this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label60.Location = new System.Drawing.Point(254, 336);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(119, 25);
            this.Label60.TabIndex = 48;
            this.Label60.Text = "备用参数:";
            this.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label66
            // 
            this.Label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label66.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label66.Location = new System.Drawing.Point(254, 364);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(119, 25);
            this.Label66.TabIndex = 54;
            this.Label66.Text = "备用参数:";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label67
            // 
            this.Label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label67.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label67.Location = new System.Drawing.Point(254, 392);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(119, 25);
            this.Label67.TabIndex = 55;
            this.Label67.Text = "备用参数:";
            this.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label68
            // 
            this.Label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label68.Location = new System.Drawing.Point(254, 420);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(119, 25);
            this.Label68.TabIndex = 56;
            this.Label68.Text = "备用参数:";
            this.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label73
            // 
            this.Label73.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label73.Location = new System.Drawing.Point(208, 0);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(30, 25);
            this.Label73.TabIndex = 67;
            this.Label73.Text = "mm";
            this.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label74
            // 
            this.Label74.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label74.Location = new System.Drawing.Point(208, 28);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(30, 25);
            this.Label74.TabIndex = 68;
            this.Label74.Text = "mm";
            this.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label75
            // 
            this.Label75.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label75.Location = new System.Drawing.Point(208, 56);
            this.Label75.Name = "Label75";
            this.Label75.Size = new System.Drawing.Size(30, 25);
            this.Label75.TabIndex = 69;
            this.Label75.Text = "°";
            this.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label76
            // 
            this.Label76.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label76.Location = new System.Drawing.Point(208, 84);
            this.Label76.Name = "Label76";
            this.Label76.Size = new System.Drawing.Size(30, 25);
            this.Label76.TabIndex = 70;
            this.Label76.Text = "mm";
            this.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label77
            // 
            this.Label77.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label77.Location = new System.Drawing.Point(208, 112);
            this.Label77.Name = "Label77";
            this.Label77.Size = new System.Drawing.Size(30, 25);
            this.Label77.TabIndex = 71;
            this.Label77.Text = "mm";
            this.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label78
            // 
            this.Label78.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label78.Location = new System.Drawing.Point(208, 140);
            this.Label78.Name = "Label78";
            this.Label78.Size = new System.Drawing.Size(30, 25);
            this.Label78.TabIndex = 72;
            this.Label78.Text = "mm";
            this.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label79
            // 
            this.Label79.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label79.Location = new System.Drawing.Point(208, 168);
            this.Label79.Name = "Label79";
            this.Label79.Size = new System.Drawing.Size(30, 25);
            this.Label79.TabIndex = 73;
            this.Label79.Text = "°";
            this.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label80
            // 
            this.Label80.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label80.Location = new System.Drawing.Point(208, 196);
            this.Label80.Name = "Label80";
            this.Label80.Size = new System.Drawing.Size(30, 25);
            this.Label80.TabIndex = 74;
            this.Label80.Text = "mm";
            this.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label81
            // 
            this.Label81.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label81.Location = new System.Drawing.Point(208, 224);
            this.Label81.Name = "Label81";
            this.Label81.Size = new System.Drawing.Size(30, 25);
            this.Label81.TabIndex = 75;
            this.Label81.Text = "mm";
            this.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label82
            // 
            this.Label82.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label82.Location = new System.Drawing.Point(208, 252);
            this.Label82.Name = "Label82";
            this.Label82.Size = new System.Drawing.Size(30, 25);
            this.Label82.TabIndex = 76;
            this.Label82.Text = "mm";
            this.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label83
            // 
            this.Label83.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label83.Location = new System.Drawing.Point(208, 280);
            this.Label83.Name = "Label83";
            this.Label83.Size = new System.Drawing.Size(30, 25);
            this.Label83.TabIndex = 77;
            this.Label83.Text = "°";
            this.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label84
            // 
            this.Label84.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label84.Location = new System.Drawing.Point(208, 308);
            this.Label84.Name = "Label84";
            this.Label84.Size = new System.Drawing.Size(30, 25);
            this.Label84.TabIndex = 78;
            this.Label84.Text = "mm";
            this.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label85
            // 
            this.Label85.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label85.Location = new System.Drawing.Point(208, 336);
            this.Label85.Name = "Label85";
            this.Label85.Size = new System.Drawing.Size(30, 25);
            this.Label85.TabIndex = 79;
            this.Label85.Text = "mm";
            this.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label86
            // 
            this.Label86.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label86.Location = new System.Drawing.Point(208, 364);
            this.Label86.Name = "Label86";
            this.Label86.Size = new System.Drawing.Size(30, 25);
            this.Label86.TabIndex = 80;
            this.Label86.Text = "mm";
            this.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label87
            // 
            this.Label87.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label87.Location = new System.Drawing.Point(208, 392);
            this.Label87.Name = "Label87";
            this.Label87.Size = new System.Drawing.Size(30, 25);
            this.Label87.TabIndex = 81;
            this.Label87.Text = "s";
            this.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label88
            // 
            this.Label88.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label88.Location = new System.Drawing.Point(208, 420);
            this.Label88.Name = "Label88";
            this.Label88.Size = new System.Drawing.Size(30, 25);
            this.Label88.TabIndex = 82;
            this.Label88.Text = "次";
            this.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label72
            // 
            this.Label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label72.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label72.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label72.Location = new System.Drawing.Point(526, 0);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(134, 25);
            this.Label72.TabIndex = 60;
            this.Label72.Text = "备用参数:";
            this.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label65
            // 
            this.Label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label65.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label65.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label65.Location = new System.Drawing.Point(526, 28);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(134, 25);
            this.Label65.TabIndex = 53;
            this.Label65.Text = "备用参数:";
            this.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label71
            // 
            this.Label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label71.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label71.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label71.Location = new System.Drawing.Point(526, 56);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(134, 25);
            this.Label71.TabIndex = 59;
            this.Label71.Text = "备用参数:";
            this.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label70
            // 
            this.Label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label70.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label70.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label70.Location = new System.Drawing.Point(526, 84);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(134, 25);
            this.Label70.TabIndex = 58;
            this.Label70.Text = "备用参数:";
            this.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label69
            // 
            this.Label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label69.Location = new System.Drawing.Point(526, 112);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(134, 25);
            this.Label69.TabIndex = 57;
            this.Label69.Text = "备用参数:";
            this.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label92
            // 
            this.Label92.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label92.Location = new System.Drawing.Point(474, 56);
            this.Label92.Name = "Label92";
            this.Label92.Size = new System.Drawing.Size(43, 25);
            this.Label92.TabIndex = 102;
            this.Label92.Text = "mm";
            this.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label95
            // 
            this.Label95.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label95.Location = new System.Drawing.Point(757, 56);
            this.Label95.Name = "Label95";
            this.Label95.Size = new System.Drawing.Size(40, 25);
            this.Label95.TabIndex = 105;
            this.Label95.Text = "mm";
            this.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label96
            // 
            this.Label96.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label96.Location = new System.Drawing.Point(757, 84);
            this.Label96.Name = "Label96";
            this.Label96.Size = new System.Drawing.Size(40, 25);
            this.Label96.TabIndex = 106;
            this.Label96.Text = "mm";
            this.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label98
            // 
            this.Label98.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label98.Location = new System.Drawing.Point(757, 0);
            this.Label98.Name = "Label98";
            this.Label98.Size = new System.Drawing.Size(40, 25);
            this.Label98.TabIndex = 108;
            this.Label98.Text = "mm";
            this.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label97
            // 
            this.Label97.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label97.Location = new System.Drawing.Point(757, 28);
            this.Label97.Name = "Label97";
            this.Label97.Size = new System.Drawing.Size(40, 25);
            this.Label97.TabIndex = 107;
            this.Label97.Text = "mm";
            this.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label94
            // 
            this.Label94.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label94.Location = new System.Drawing.Point(474, 0);
            this.Label94.Name = "Label94";
            this.Label94.Size = new System.Drawing.Size(43, 25);
            this.Label94.TabIndex = 104;
            this.Label94.Text = "mm";
            this.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label93
            // 
            this.Label93.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label93.Location = new System.Drawing.Point(474, 28);
            this.Label93.Name = "Label93";
            this.Label93.Size = new System.Drawing.Size(43, 25);
            this.Label93.TabIndex = 103;
            this.Label93.Text = "mm";
            this.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label100
            // 
            this.Label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label100.Location = new System.Drawing.Point(254, 448);
            this.Label100.Name = "Label100";
            this.Label100.Size = new System.Drawing.Size(119, 25);
            this.Label100.TabIndex = 110;
            this.Label100.Text = "备用参数:";
            this.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label99
            // 
            this.Label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label99.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label99.Location = new System.Drawing.Point(526, 140);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(134, 25);
            this.Label99.TabIndex = 109;
            this.Label99.Text = "备用参数:";
            this.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label103
            // 
            this.Label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label103.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label103.Location = new System.Drawing.Point(526, 168);
            this.Label103.Name = "Label103";
            this.Label103.Size = new System.Drawing.Size(134, 25);
            this.Label103.TabIndex = 113;
            this.Label103.Text = "备用参数:";
            this.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label102
            // 
            this.Label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label102.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label102.Location = new System.Drawing.Point(526, 196);
            this.Label102.Name = "Label102";
            this.Label102.Size = new System.Drawing.Size(134, 25);
            this.Label102.TabIndex = 112;
            this.Label102.Text = "备用参数:";
            this.Label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label101
            // 
            this.Label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label101.Location = new System.Drawing.Point(254, 476);
            this.Label101.Name = "Label101";
            this.Label101.Size = new System.Drawing.Size(119, 25);
            this.Label101.TabIndex = 111;
            this.Label101.Text = "备用参数:";
            this.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label104
            // 
            this.Label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label104.Location = new System.Drawing.Point(254, 504);
            this.Label104.Name = "Label104";
            this.Label104.Size = new System.Drawing.Size(119, 25);
            this.Label104.TabIndex = 114;
            this.Label104.Text = "3站保压压力:";
            this.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label105
            // 
            this.Label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label105.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label105.Location = new System.Drawing.Point(526, 224);
            this.Label105.Name = "Label105";
            this.Label105.Size = new System.Drawing.Size(134, 25);
            this.Label105.TabIndex = 115;
            this.Label105.Text = "备用参数:";
            this.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label106
            // 
            this.Label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label106.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label106.Location = new System.Drawing.Point(526, 252);
            this.Label106.Name = "Label106";
            this.Label106.Size = new System.Drawing.Size(134, 25);
            this.Label106.TabIndex = 116;
            this.Label106.Text = "备用参数:";
            this.Label106.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label107
            // 
            this.Label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label107.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label107.Location = new System.Drawing.Point(526, 280);
            this.Label107.Name = "Label107";
            this.Label107.Size = new System.Drawing.Size(134, 25);
            this.Label107.TabIndex = 117;
            this.Label107.Text = "备用参数:";
            this.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label108
            // 
            this.Label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label108.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label108.Location = new System.Drawing.Point(526, 308);
            this.Label108.Name = "Label108";
            this.Label108.Size = new System.Drawing.Size(134, 25);
            this.Label108.TabIndex = 118;
            this.Label108.Text = "备用参数:";
            this.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label109
            // 
            this.Label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label109.Location = new System.Drawing.Point(526, 336);
            this.Label109.Name = "Label109";
            this.Label109.Size = new System.Drawing.Size(134, 25);
            this.Label109.TabIndex = 119;
            this.Label109.Text = "备用参数:";
            this.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label110
            // 
            this.Label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label110.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label110.Location = new System.Drawing.Point(526, 364);
            this.Label110.Name = "Label110";
            this.Label110.Size = new System.Drawing.Size(134, 25);
            this.Label110.TabIndex = 120;
            this.Label110.Text = "备用参数:";
            this.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label111
            // 
            this.Label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label111.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label111.Location = new System.Drawing.Point(526, 392);
            this.Label111.Name = "Label111";
            this.Label111.Size = new System.Drawing.Size(134, 25);
            this.Label111.TabIndex = 121;
            this.Label111.Text = "备用参数:";
            this.Label111.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label112
            // 
            this.Label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label112.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label112.Location = new System.Drawing.Point(526, 420);
            this.Label112.Name = "Label112";
            this.Label112.Size = new System.Drawing.Size(134, 25);
            this.Label112.TabIndex = 122;
            this.Label112.Text = "备用参数:";
            this.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label113
            // 
            this.Label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label113.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label113.Location = new System.Drawing.Point(526, 448);
            this.Label113.Name = "Label113";
            this.Label113.Size = new System.Drawing.Size(134, 25);
            this.Label113.TabIndex = 123;
            this.Label113.Text = "备用参数:";
            this.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label114
            // 
            this.Label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label114.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label114.Location = new System.Drawing.Point(526, 476);
            this.Label114.Name = "Label114";
            this.Label114.Size = new System.Drawing.Size(134, 25);
            this.Label114.TabIndex = 124;
            this.Label114.Text = "备用参数:";
            this.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label115
            // 
            this.Label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label115.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label115.Location = new System.Drawing.Point(526, 504);
            this.Label115.Name = "Label115";
            this.Label115.Size = new System.Drawing.Size(120, 25);
            this.Label115.TabIndex = 125;
            this.Label115.Text = "备用参数:";
            this.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label116
            // 
            this.Label116.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label116.Location = new System.Drawing.Point(474, 112);
            this.Label116.Name = "Label116";
            this.Label116.Size = new System.Drawing.Size(43, 25);
            this.Label116.TabIndex = 126;
            this.Label116.Text = "mm";
            this.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label117
            // 
            this.Label117.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label117.Location = new System.Drawing.Point(474, 84);
            this.Label117.Name = "Label117";
            this.Label117.Size = new System.Drawing.Size(43, 25);
            this.Label117.TabIndex = 127;
            this.Label117.Text = "mm";
            this.Label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label118
            // 
            this.Label118.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label118.Location = new System.Drawing.Point(474, 140);
            this.Label118.Name = "Label118";
            this.Label118.Size = new System.Drawing.Size(43, 25);
            this.Label118.TabIndex = 128;
            this.Label118.Text = "mm";
            this.Label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label119
            // 
            this.Label119.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label119.Location = new System.Drawing.Point(474, 168);
            this.Label119.Name = "Label119";
            this.Label119.Size = new System.Drawing.Size(43, 25);
            this.Label119.TabIndex = 129;
            this.Label119.Text = "mm";
            this.Label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label120
            // 
            this.Label120.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label120.Location = new System.Drawing.Point(474, 196);
            this.Label120.Name = "Label120";
            this.Label120.Size = new System.Drawing.Size(43, 25);
            this.Label120.TabIndex = 130;
            this.Label120.Text = "mm";
            this.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label121
            // 
            this.Label121.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label121.Location = new System.Drawing.Point(474, 224);
            this.Label121.Name = "Label121";
            this.Label121.Size = new System.Drawing.Size(43, 25);
            this.Label121.TabIndex = 131;
            this.Label121.Text = "mm";
            this.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label122
            // 
            this.Label122.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label122.Location = new System.Drawing.Point(474, 252);
            this.Label122.Name = "Label122";
            this.Label122.Size = new System.Drawing.Size(43, 25);
            this.Label122.TabIndex = 132;
            this.Label122.Text = "mm";
            this.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label123
            // 
            this.Label123.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label123.Location = new System.Drawing.Point(474, 280);
            this.Label123.Name = "Label123";
            this.Label123.Size = new System.Drawing.Size(43, 25);
            this.Label123.TabIndex = 133;
            this.Label123.Text = "mm";
            this.Label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label124
            // 
            this.Label124.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label124.Location = new System.Drawing.Point(474, 308);
            this.Label124.Name = "Label124";
            this.Label124.Size = new System.Drawing.Size(43, 25);
            this.Label124.TabIndex = 134;
            this.Label124.Text = "mm";
            this.Label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label125
            // 
            this.Label125.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label125.Location = new System.Drawing.Point(474, 336);
            this.Label125.Name = "Label125";
            this.Label125.Size = new System.Drawing.Size(43, 25);
            this.Label125.TabIndex = 135;
            this.Label125.Text = "mm";
            this.Label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label126
            // 
            this.Label126.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label126.Location = new System.Drawing.Point(474, 364);
            this.Label126.Name = "Label126";
            this.Label126.Size = new System.Drawing.Size(43, 25);
            this.Label126.TabIndex = 136;
            this.Label126.Text = "mm";
            this.Label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label127
            // 
            this.Label127.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label127.Location = new System.Drawing.Point(474, 392);
            this.Label127.Name = "Label127";
            this.Label127.Size = new System.Drawing.Size(43, 25);
            this.Label127.TabIndex = 137;
            this.Label127.Text = "mm";
            this.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label128
            // 
            this.Label128.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label128.Location = new System.Drawing.Point(474, 420);
            this.Label128.Name = "Label128";
            this.Label128.Size = new System.Drawing.Size(43, 25);
            this.Label128.TabIndex = 138;
            this.Label128.Text = "mm";
            this.Label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label132
            // 
            this.Label132.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label132.Location = new System.Drawing.Point(757, 112);
            this.Label132.Name = "Label132";
            this.Label132.Size = new System.Drawing.Size(40, 25);
            this.Label132.TabIndex = 142;
            this.Label132.Text = "mm";
            this.Label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label133
            // 
            this.Label133.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label133.Location = new System.Drawing.Point(757, 140);
            this.Label133.Name = "Label133";
            this.Label133.Size = new System.Drawing.Size(40, 25);
            this.Label133.TabIndex = 143;
            this.Label133.Text = "mm";
            this.Label133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label134
            // 
            this.Label134.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label134.Location = new System.Drawing.Point(757, 168);
            this.Label134.Name = "Label134";
            this.Label134.Size = new System.Drawing.Size(40, 25);
            this.Label134.TabIndex = 144;
            this.Label134.Text = "mm";
            this.Label134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label135
            // 
            this.Label135.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label135.Location = new System.Drawing.Point(757, 196);
            this.Label135.Name = "Label135";
            this.Label135.Size = new System.Drawing.Size(40, 25);
            this.Label135.TabIndex = 145;
            this.Label135.Text = "mm";
            this.Label135.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label136
            // 
            this.Label136.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label136.Location = new System.Drawing.Point(757, 224);
            this.Label136.Name = "Label136";
            this.Label136.Size = new System.Drawing.Size(40, 25);
            this.Label136.TabIndex = 146;
            this.Label136.Text = "mm";
            this.Label136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label137
            // 
            this.Label137.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label137.Location = new System.Drawing.Point(757, 252);
            this.Label137.Name = "Label137";
            this.Label137.Size = new System.Drawing.Size(40, 25);
            this.Label137.TabIndex = 147;
            this.Label137.Text = "mm";
            this.Label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label138
            // 
            this.Label138.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label138.Location = new System.Drawing.Point(757, 280);
            this.Label138.Name = "Label138";
            this.Label138.Size = new System.Drawing.Size(40, 25);
            this.Label138.TabIndex = 148;
            this.Label138.Text = "mm";
            this.Label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label139
            // 
            this.Label139.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label139.Location = new System.Drawing.Point(757, 308);
            this.Label139.Name = "Label139";
            this.Label139.Size = new System.Drawing.Size(40, 25);
            this.Label139.TabIndex = 149;
            this.Label139.Text = "mm";
            this.Label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label140
            // 
            this.Label140.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label140.Location = new System.Drawing.Point(757, 336);
            this.Label140.Name = "Label140";
            this.Label140.Size = new System.Drawing.Size(40, 25);
            this.Label140.TabIndex = 150;
            this.Label140.Text = "n";
            this.Label140.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label141
            // 
            this.Label141.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label141.Location = new System.Drawing.Point(757, 364);
            this.Label141.Name = "Label141";
            this.Label141.Size = new System.Drawing.Size(40, 25);
            this.Label141.TabIndex = 151;
            this.Label141.Text = "n";
            this.Label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label142
            // 
            this.Label142.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label142.Location = new System.Drawing.Point(757, 392);
            this.Label142.Name = "Label142";
            this.Label142.Size = new System.Drawing.Size(40, 25);
            this.Label142.TabIndex = 152;
            this.Label142.Text = "kg";
            this.Label142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label143
            // 
            this.Label143.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label143.Location = new System.Drawing.Point(757, 420);
            this.Label143.Name = "Label143";
            this.Label143.Size = new System.Drawing.Size(40, 25);
            this.Label143.TabIndex = 153;
            this.Label143.Text = "s";
            this.Label143.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label261
            // 
            this.Label261.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label261.Location = new System.Drawing.Point(3, 532);
            this.Label261.Name = "Label261";
            this.Label261.Size = new System.Drawing.Size(112, 20);
            this.Label261.TabIndex = 172;
            this.Label261.Text = "2站保压时间:";
            this.Label261.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label264
            // 
            this.Label264.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label264.Location = new System.Drawing.Point(3, 558);
            this.Label264.Name = "Label264";
            this.Label264.Size = new System.Drawing.Size(112, 25);
            this.Label264.TabIndex = 181;
            this.Label264.Text = "2站串口端口:";
            this.Label264.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label266
            // 
            this.Label266.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label266.Location = new System.Drawing.Point(526, 558);
            this.Label266.Name = "Label266";
            this.Label266.Size = new System.Drawing.Size(84, 25);
            this.Label266.TabIndex = 183;
            this.Label266.Text = "串口参数:";
            this.Label266.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label263
            // 
            this.Label263.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label263.Location = new System.Drawing.Point(526, 532);
            this.Label263.Name = "Label263";
            this.Label263.Size = new System.Drawing.Size(134, 20);
            this.Label263.TabIndex = 180;
            this.Label263.Text = "串口参数:";
            this.Label263.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label33
            // 
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label33.Location = new System.Drawing.Point(3, 0);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(112, 28);
            this.Label33.TabIndex = 0;
            this.Label33.Text = "组装补偿X:";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label262
            // 
            this.Label262.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label262.Location = new System.Drawing.Point(254, 532);
            this.Label262.Name = "Label262";
            this.Label262.Size = new System.Drawing.Size(119, 20);
            this.Label262.TabIndex = 179;
            this.Label262.Text = "3站保压时间:";
            this.Label262.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label265
            // 
            this.Label265.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label265.Location = new System.Drawing.Point(254, 558);
            this.Label265.Name = "Label265";
            this.Label265.Size = new System.Drawing.Size(119, 32);
            this.Label265.TabIndex = 182;
            this.Label265.Text = "3站串口端口:";
            this.Label265.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label90
            // 
            this.Label90.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label90.Location = new System.Drawing.Point(208, 448);
            this.Label90.Name = "Label90";
            this.Label90.Size = new System.Drawing.Size(30, 25);
            this.Label90.TabIndex = 184;
            this.Label90.Text = "s";
            this.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label165
            // 
            this.Label165.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label165.Location = new System.Drawing.Point(208, 504);
            this.Label165.Name = "Label165";
            this.Label165.Size = new System.Drawing.Size(30, 25);
            this.Label165.TabIndex = 186;
            this.Label165.Text = "s";
            this.Label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label166
            // 
            this.Label166.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label166.Location = new System.Drawing.Point(208, 532);
            this.Label166.Name = "Label166";
            this.Label166.Size = new System.Drawing.Size(30, 25);
            this.Label166.TabIndex = 187;
            this.Label166.Text = "s";
            this.Label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label167
            // 
            this.Label167.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label167.Location = new System.Drawing.Point(208, 558);
            this.Label167.Name = "Label167";
            this.Label167.Size = new System.Drawing.Size(30, 25);
            this.Label167.TabIndex = 188;
            this.Label167.Text = "s";
            this.Label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage2.Controls.Add(this.TableLayoutPanel4);
            this.TabPage2.Location = new System.Drawing.Point(4, 39);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(920, 611);
            this.TabPage2.TabIndex = 3;
            this.TabPage2.Text = "  功能设定  ";
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 6;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.TableLayoutPanel4.Controls.Add(this.Label217, 4, 0);
            this.TableLayoutPanel4.Controls.Add(this.Label19, 2, 12);
            this.TableLayoutPanel4.Controls.Add(this.Label25, 2, 3);
            this.TableLayoutPanel4.Controls.Add(this.Label16, 0, 15);
            this.TableLayoutPanel4.Controls.Add(this.Label14, 0, 13);
            this.TableLayoutPanel4.Controls.Add(this.Label13, 0, 12);
            this.TableLayoutPanel4.Controls.Add(this.Label8, 0, 7);
            this.TableLayoutPanel4.Controls.Add(this.Label7, 0, 6);
            this.TableLayoutPanel4.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.Label2, 0, 1);
            this.TableLayoutPanel4.Controls.Add(this.Label3, 0, 2);
            this.TableLayoutPanel4.Controls.Add(this.Label4, 0, 3);
            this.TableLayoutPanel4.Controls.Add(this.Label5, 0, 4);
            this.TableLayoutPanel4.Controls.Add(this.Label9, 0, 8);
            this.TableLayoutPanel4.Controls.Add(this.Label10, 0, 9);
            this.TableLayoutPanel4.Controls.Add(this.Label11, 0, 10);
            this.TableLayoutPanel4.Controls.Add(this.Label12, 0, 11);
            this.TableLayoutPanel4.Controls.Add(this.Label15, 0, 14);
            this.TableLayoutPanel4.Controls.Add(this.Label6, 0, 5);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox1, 1, 0);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox3, 1, 2);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox4, 1, 3);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox5, 1, 4);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox6, 1, 5);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox7, 1, 6);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox8, 1, 7);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox9, 1, 8);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox10, 1, 9);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox11, 1, 10);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox12, 1, 11);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox13, 1, 12);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox14, 1, 13);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox15, 1, 14);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox16, 1, 15);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox18, 3, 1);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox20, 3, 3);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox21, 3, 4);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox22, 3, 5);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox23, 3, 6);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox24, 3, 7);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox25, 3, 8);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox26, 3, 9);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox27, 3, 10);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox28, 3, 11);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox29, 3, 12);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox30, 3, 13);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox31, 3, 14);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox32, 3, 15);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox34, 5, 1);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox35, 5, 2);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox36, 5, 3);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox37, 5, 4);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox38, 5, 5);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox39, 5, 6);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox40, 5, 7);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox41, 5, 8);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox42, 5, 9);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox43, 5, 10);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox44, 5, 11);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox45, 5, 12);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox46, 5, 13);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox47, 5, 14);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox48, 5, 15);
            this.TableLayoutPanel4.Controls.Add(this.Label29, 2, 10);
            this.TableLayoutPanel4.Controls.Add(this.Label28, 2, 9);
            this.TableLayoutPanel4.Controls.Add(this.Label27, 2, 8);
            this.TableLayoutPanel4.Controls.Add(this.Label18, 2, 13);
            this.TableLayoutPanel4.Controls.Add(this.Label30, 2, 11);
            this.TableLayoutPanel4.Controls.Add(this.Label22, 2, 0);
            this.TableLayoutPanel4.Controls.Add(this.Label23, 2, 1);
            this.TableLayoutPanel4.Controls.Add(this.Label31, 2, 14);
            this.TableLayoutPanel4.Controls.Add(this.Label20, 2, 7);
            this.TableLayoutPanel4.Controls.Add(this.Label24, 2, 2);
            this.TableLayoutPanel4.Controls.Add(this.Label21, 2, 6);
            this.TableLayoutPanel4.Controls.Add(this.Label32, 2, 5);
            this.TableLayoutPanel4.Controls.Add(this.Label26, 2, 4);
            this.TableLayoutPanel4.Controls.Add(this.Label180, 4, 14);
            this.TableLayoutPanel4.Controls.Add(this.Label189, 4, 13);
            this.TableLayoutPanel4.Controls.Add(this.Label190, 4, 12);
            this.TableLayoutPanel4.Controls.Add(this.Label191, 4, 11);
            this.TableLayoutPanel4.Controls.Add(this.Label192, 4, 10);
            this.TableLayoutPanel4.Controls.Add(this.Label193, 4, 9);
            this.TableLayoutPanel4.Controls.Add(this.Label194, 4, 8);
            this.TableLayoutPanel4.Controls.Add(this.Label195, 4, 7);
            this.TableLayoutPanel4.Controls.Add(this.Label196, 4, 6);
            this.TableLayoutPanel4.Controls.Add(this.Label197, 4, 5);
            this.TableLayoutPanel4.Controls.Add(this.Label198, 4, 4);
            this.TableLayoutPanel4.Controls.Add(this.Label199, 4, 3);
            this.TableLayoutPanel4.Controls.Add(this.Label212, 4, 2);
            this.TableLayoutPanel4.Controls.Add(this.Label216, 4, 1);
            this.TableLayoutPanel4.Controls.Add(this.Label17, 2, 15);
            this.TableLayoutPanel4.Controls.Add(this.Label179, 4, 15);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox2, 1, 1);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox17, 3, 0);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox19, 3, 2);
            this.TableLayoutPanel4.Controls.Add(this.CheckBox33, 5, 0);
            this.TableLayoutPanel4.Enabled = false;
            this.TableLayoutPanel4.Location = new System.Drawing.Point(18, 15);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 17;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(882, 559);
            this.TableLayoutPanel4.TabIndex = 0;
            // 
            // Label217
            // 
            this.Label217.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label217.Location = new System.Drawing.Point(571, 0);
            this.Label217.Name = "Label217";
            this.Label217.Size = new System.Drawing.Size(28, 27);
            this.Label217.TabIndex = 91;
            this.Label217.Text = "33";
            this.Label217.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label19
            // 
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(297, 420);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(28, 28);
            this.Label19.TabIndex = 41;
            this.Label19.Text = "29";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label25
            // 
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(297, 105);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(28, 28);
            this.Label25.TabIndex = 32;
            this.Label25.Text = "20";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label16
            // 
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(3, 525);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(28, 28);
            this.Label16.TabIndex = 10;
            this.Label16.Text = "16";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(3, 455);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(28, 28);
            this.Label14.TabIndex = 10;
            this.Label14.Text = "14";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(3, 420);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(28, 28);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "13";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(3, 245);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(14, 28);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "8";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(3, 210);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(14, 28);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "7";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 27);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(14, 28);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "2";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 70);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(14, 28);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(3, 105);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(14, 28);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "4";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(3, 140);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(14, 28);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "5";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(3, 280);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(14, 28);
            this.Label9.TabIndex = 8;
            this.Label9.Text = "9";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(3, 315);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(28, 28);
            this.Label10.TabIndex = 9;
            this.Label10.Text = "10";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(3, 350);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(28, 28);
            this.Label11.TabIndex = 10;
            this.Label11.Text = "11";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(3, 385);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(28, 28);
            this.Label12.TabIndex = 11;
            this.Label12.Text = "12";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(3, 490);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(28, 28);
            this.Label15.TabIndex = 12;
            this.Label15.Text = "15";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(3, 175);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(14, 28);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "6";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox1.Location = new System.Drawing.Point(37, 3);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(254, 29);
            this.CheckBox1.TabIndex = 13;
            this.CheckBox1.Text = "开启安全门功能";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox3
            // 
            this.CheckBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox3.Location = new System.Drawing.Point(37, 73);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(254, 29);
            this.CheckBox3.TabIndex = 15;
            this.CheckBox3.Text = "设备镜像(勾选为左进料,不勾选为右进料)";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox4
            // 
            this.CheckBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox4.Location = new System.Drawing.Point(37, 108);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.Size = new System.Drawing.Size(254, 29);
            this.CheckBox4.TabIndex = 16;
            this.CheckBox4.Text = "开启外部条码";
            this.CheckBox4.UseVisualStyleBackColor = true;
            this.CheckBox4.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox5
            // 
            this.CheckBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox5.Location = new System.Drawing.Point(37, 143);
            this.CheckBox5.Name = "CheckBox5";
            this.CheckBox5.Size = new System.Drawing.Size(254, 29);
            this.CheckBox5.TabIndex = 17;
            this.CheckBox5.Text = "开启SF条码是否过路径";
            this.CheckBox5.UseVisualStyleBackColor = true;
            this.CheckBox5.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox6
            // 
            this.CheckBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox6.Location = new System.Drawing.Point(37, 178);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(254, 29);
            this.CheckBox6.TabIndex = 18;
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox6.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox7
            // 
            this.CheckBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox7.Location = new System.Drawing.Point(37, 213);
            this.CheckBox7.Name = "CheckBox7";
            this.CheckBox7.Size = new System.Drawing.Size(254, 29);
            this.CheckBox7.TabIndex = 19;
            this.CheckBox7.Text = "开启夹紧定位扫条码";
            this.CheckBox7.UseVisualStyleBackColor = true;
            this.CheckBox7.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox8
            // 
            this.CheckBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox8.Location = new System.Drawing.Point(37, 248);
            this.CheckBox8.Name = "CheckBox8";
            this.CheckBox8.Size = new System.Drawing.Size(254, 29);
            this.CheckBox8.TabIndex = 20;
            this.CheckBox8.Text = "开启截图";
            this.CheckBox8.UseVisualStyleBackColor = true;
            this.CheckBox8.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox9
            // 
            this.CheckBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox9.Location = new System.Drawing.Point(37, 283);
            this.CheckBox9.Name = "CheckBox9";
            this.CheckBox9.Size = new System.Drawing.Size(254, 29);
            this.CheckBox9.TabIndex = 21;
            this.CheckBox9.Text = "开启自动切换颜色";
            this.CheckBox9.UseVisualStyleBackColor = true;
            this.CheckBox9.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox10
            // 
            this.CheckBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox10.Location = new System.Drawing.Point(37, 318);
            this.CheckBox10.Name = "CheckBox10";
            this.CheckBox10.Size = new System.Drawing.Size(254, 29);
            this.CheckBox10.TabIndex = 22;
            this.CheckBox10.Text = "勾上屏蔽组装";
            this.CheckBox10.UseVisualStyleBackColor = true;
            this.CheckBox10.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox11
            // 
            this.CheckBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox11.Location = new System.Drawing.Point(37, 353);
            this.CheckBox11.Name = "CheckBox11";
            this.CheckBox11.Size = new System.Drawing.Size(254, 29);
            this.CheckBox11.TabIndex = 23;
            this.CheckBox11.Text = "物料排版(不勾4*15,勾上6*15)";
            this.CheckBox11.UseVisualStyleBackColor = true;
            this.CheckBox11.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox12
            // 
            this.CheckBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox12.Location = new System.Drawing.Point(37, 388);
            this.CheckBox12.Name = "CheckBox12";
            this.CheckBox12.Size = new System.Drawing.Size(254, 29);
            this.CheckBox12.TabIndex = 24;
            this.CheckBox12.Text = "HSG(不勾P1,勾上P2)";
            this.CheckBox12.UseVisualStyleBackColor = true;
            this.CheckBox12.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox13
            // 
            this.CheckBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox13.Location = new System.Drawing.Point(37, 423);
            this.CheckBox13.Name = "CheckBox13";
            this.CheckBox13.Size = new System.Drawing.Size(254, 29);
            this.CheckBox13.TabIndex = 25;
            this.CheckBox13.Text = "备用";
            this.CheckBox13.UseVisualStyleBackColor = true;
            this.CheckBox13.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox14
            // 
            this.CheckBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox14.Location = new System.Drawing.Point(37, 458);
            this.CheckBox14.Name = "CheckBox14";
            this.CheckBox14.Size = new System.Drawing.Size(254, 29);
            this.CheckBox14.TabIndex = 26;
            this.CheckBox14.Text = "备用";
            this.CheckBox14.UseVisualStyleBackColor = true;
            this.CheckBox14.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox15
            // 
            this.CheckBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox15.Location = new System.Drawing.Point(37, 493);
            this.CheckBox15.Name = "CheckBox15";
            this.CheckBox15.Size = new System.Drawing.Size(254, 29);
            this.CheckBox15.TabIndex = 27;
            this.CheckBox15.Text = "备用";
            this.CheckBox15.UseVisualStyleBackColor = true;
            this.CheckBox15.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox16
            // 
            this.CheckBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox16.Location = new System.Drawing.Point(37, 528);
            this.CheckBox16.Name = "CheckBox16";
            this.CheckBox16.Size = new System.Drawing.Size(254, 29);
            this.CheckBox16.TabIndex = 28;
            this.CheckBox16.Text = "备用";
            this.CheckBox16.UseVisualStyleBackColor = true;
            this.CheckBox16.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox18
            // 
            this.CheckBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox18.Location = new System.Drawing.Point(331, 38);
            this.CheckBox18.Name = "CheckBox18";
            this.CheckBox18.Size = new System.Drawing.Size(234, 29);
            this.CheckBox18.TabIndex = 46;
            this.CheckBox18.Text = "开启一次补正功能";
            this.CheckBox18.UseVisualStyleBackColor = true;
            this.CheckBox18.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox20
            // 
            this.CheckBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox20.Location = new System.Drawing.Point(331, 108);
            this.CheckBox20.Name = "CheckBox20";
            this.CheckBox20.Size = new System.Drawing.Size(234, 29);
            this.CheckBox20.TabIndex = 48;
            this.CheckBox20.Text = "勾上开启PDCA";
            this.CheckBox20.UseVisualStyleBackColor = true;
            this.CheckBox20.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox21
            // 
            this.CheckBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox21.Location = new System.Drawing.Point(331, 143);
            this.CheckBox21.Name = "CheckBox21";
            this.CheckBox21.Size = new System.Drawing.Size(234, 29);
            this.CheckBox21.TabIndex = 49;
            this.CheckBox21.Text = "开启HeatBt";
            this.CheckBox21.UseVisualStyleBackColor = true;
            this.CheckBox21.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox22
            // 
            this.CheckBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox22.Location = new System.Drawing.Point(331, 178);
            this.CheckBox22.Name = "CheckBox22";
            this.CheckBox22.Size = new System.Drawing.Size(234, 29);
            this.CheckBox22.TabIndex = 50;
            this.CheckBox22.Text = "CPK";
            this.CheckBox22.UseVisualStyleBackColor = true;
            this.CheckBox22.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox23
            // 
            this.CheckBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox23.Location = new System.Drawing.Point(331, 213);
            this.CheckBox23.Name = "CheckBox23";
            this.CheckBox23.Size = new System.Drawing.Size(234, 29);
            this.CheckBox23.TabIndex = 51;
            this.CheckBox23.Text = "备用";
            this.CheckBox23.UseVisualStyleBackColor = true;
            this.CheckBox23.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox24
            // 
            this.CheckBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox24.Location = new System.Drawing.Point(331, 248);
            this.CheckBox24.Name = "CheckBox24";
            this.CheckBox24.Size = new System.Drawing.Size(234, 29);
            this.CheckBox24.TabIndex = 52;
            this.CheckBox24.Text = "备用";
            this.CheckBox24.UseVisualStyleBackColor = true;
            this.CheckBox24.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox25
            // 
            this.CheckBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox25.Location = new System.Drawing.Point(331, 283);
            this.CheckBox25.Name = "CheckBox25";
            this.CheckBox25.Size = new System.Drawing.Size(234, 29);
            this.CheckBox25.TabIndex = 53;
            this.CheckBox25.Text = "备用";
            this.CheckBox25.UseVisualStyleBackColor = true;
            this.CheckBox25.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox26
            // 
            this.CheckBox26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox26.Location = new System.Drawing.Point(331, 318);
            this.CheckBox26.Name = "CheckBox26";
            this.CheckBox26.Size = new System.Drawing.Size(234, 29);
            this.CheckBox26.TabIndex = 54;
            this.CheckBox26.Text = "备用";
            this.CheckBox26.UseVisualStyleBackColor = true;
            this.CheckBox26.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox27
            // 
            this.CheckBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox27.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox27.Location = new System.Drawing.Point(331, 353);
            this.CheckBox27.Name = "CheckBox27";
            this.CheckBox27.Size = new System.Drawing.Size(234, 29);
            this.CheckBox27.TabIndex = 55;
            this.CheckBox27.Text = "备用";
            this.CheckBox27.UseVisualStyleBackColor = true;
            this.CheckBox27.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox28
            // 
            this.CheckBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox28.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox28.Location = new System.Drawing.Point(331, 388);
            this.CheckBox28.Name = "CheckBox28";
            this.CheckBox28.Size = new System.Drawing.Size(234, 29);
            this.CheckBox28.TabIndex = 56;
            this.CheckBox28.Text = "备用";
            this.CheckBox28.UseVisualStyleBackColor = true;
            this.CheckBox28.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox29
            // 
            this.CheckBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox29.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox29.Location = new System.Drawing.Point(331, 423);
            this.CheckBox29.Name = "CheckBox29";
            this.CheckBox29.Size = new System.Drawing.Size(234, 29);
            this.CheckBox29.TabIndex = 57;
            this.CheckBox29.Text = "备用";
            this.CheckBox29.UseVisualStyleBackColor = true;
            this.CheckBox29.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox30
            // 
            this.CheckBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox30.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox30.Location = new System.Drawing.Point(331, 458);
            this.CheckBox30.Name = "CheckBox30";
            this.CheckBox30.Size = new System.Drawing.Size(234, 29);
            this.CheckBox30.TabIndex = 58;
            this.CheckBox30.Text = "备用";
            this.CheckBox30.UseVisualStyleBackColor = true;
            this.CheckBox30.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox31
            // 
            this.CheckBox31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox31.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox31.Location = new System.Drawing.Point(331, 493);
            this.CheckBox31.Name = "CheckBox31";
            this.CheckBox31.Size = new System.Drawing.Size(234, 29);
            this.CheckBox31.TabIndex = 59;
            this.CheckBox31.Text = "备用";
            this.CheckBox31.UseVisualStyleBackColor = true;
            this.CheckBox31.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox32
            // 
            this.CheckBox32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox32.Location = new System.Drawing.Point(331, 528);
            this.CheckBox32.Name = "CheckBox32";
            this.CheckBox32.Size = new System.Drawing.Size(234, 29);
            this.CheckBox32.TabIndex = 93;
            this.CheckBox32.Text = "勾上开启复检";
            this.CheckBox32.UseVisualStyleBackColor = true;
            this.CheckBox32.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox34
            // 
            this.CheckBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox34.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox34.Location = new System.Drawing.Point(605, 38);
            this.CheckBox34.Name = "CheckBox34";
            this.CheckBox34.Size = new System.Drawing.Size(274, 29);
            this.CheckBox34.TabIndex = 94;
            this.CheckBox34.Text = "备用";
            this.CheckBox34.UseVisualStyleBackColor = true;
            this.CheckBox34.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox35
            // 
            this.CheckBox35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox35.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox35.Location = new System.Drawing.Point(605, 73);
            this.CheckBox35.Name = "CheckBox35";
            this.CheckBox35.Size = new System.Drawing.Size(274, 29);
            this.CheckBox35.TabIndex = 95;
            this.CheckBox35.Text = "备用";
            this.CheckBox35.UseVisualStyleBackColor = true;
            this.CheckBox35.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox36
            // 
            this.CheckBox36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox36.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox36.Location = new System.Drawing.Point(605, 108);
            this.CheckBox36.Name = "CheckBox36";
            this.CheckBox36.Size = new System.Drawing.Size(274, 29);
            this.CheckBox36.TabIndex = 96;
            this.CheckBox36.Text = "备用";
            this.CheckBox36.UseVisualStyleBackColor = true;
            this.CheckBox36.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox37
            // 
            this.CheckBox37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox37.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox37.Location = new System.Drawing.Point(605, 143);
            this.CheckBox37.Name = "CheckBox37";
            this.CheckBox37.Size = new System.Drawing.Size(274, 29);
            this.CheckBox37.TabIndex = 97;
            this.CheckBox37.Text = "备用";
            this.CheckBox37.UseVisualStyleBackColor = true;
            this.CheckBox37.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox38
            // 
            this.CheckBox38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox38.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox38.Location = new System.Drawing.Point(605, 178);
            this.CheckBox38.Name = "CheckBox38";
            this.CheckBox38.Size = new System.Drawing.Size(274, 29);
            this.CheckBox38.TabIndex = 98;
            this.CheckBox38.Text = "备用";
            this.CheckBox38.UseVisualStyleBackColor = true;
            this.CheckBox38.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox39
            // 
            this.CheckBox39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox39.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox39.Location = new System.Drawing.Point(605, 213);
            this.CheckBox39.Name = "CheckBox39";
            this.CheckBox39.Size = new System.Drawing.Size(274, 29);
            this.CheckBox39.TabIndex = 99;
            this.CheckBox39.Text = "备用";
            this.CheckBox39.UseVisualStyleBackColor = true;
            this.CheckBox39.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox40
            // 
            this.CheckBox40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox40.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox40.Location = new System.Drawing.Point(605, 248);
            this.CheckBox40.Name = "CheckBox40";
            this.CheckBox40.Size = new System.Drawing.Size(274, 29);
            this.CheckBox40.TabIndex = 100;
            this.CheckBox40.Text = "备用";
            this.CheckBox40.UseVisualStyleBackColor = true;
            this.CheckBox40.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox41
            // 
            this.CheckBox41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox41.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox41.Location = new System.Drawing.Point(605, 283);
            this.CheckBox41.Name = "CheckBox41";
            this.CheckBox41.Size = new System.Drawing.Size(274, 29);
            this.CheckBox41.TabIndex = 101;
            this.CheckBox41.Text = "备用";
            this.CheckBox41.UseVisualStyleBackColor = true;
            this.CheckBox41.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox42
            // 
            this.CheckBox42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox42.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox42.Location = new System.Drawing.Point(605, 318);
            this.CheckBox42.Name = "CheckBox42";
            this.CheckBox42.Size = new System.Drawing.Size(274, 29);
            this.CheckBox42.TabIndex = 102;
            this.CheckBox42.Text = "备用";
            this.CheckBox42.UseVisualStyleBackColor = true;
            this.CheckBox42.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox43
            // 
            this.CheckBox43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox43.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox43.Location = new System.Drawing.Point(605, 353);
            this.CheckBox43.Name = "CheckBox43";
            this.CheckBox43.Size = new System.Drawing.Size(274, 29);
            this.CheckBox43.TabIndex = 103;
            this.CheckBox43.Text = "备用";
            this.CheckBox43.UseVisualStyleBackColor = true;
            this.CheckBox43.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox44
            // 
            this.CheckBox44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox44.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox44.Location = new System.Drawing.Point(605, 388);
            this.CheckBox44.Name = "CheckBox44";
            this.CheckBox44.Size = new System.Drawing.Size(274, 29);
            this.CheckBox44.TabIndex = 104;
            this.CheckBox44.Text = "备用";
            this.CheckBox44.UseVisualStyleBackColor = true;
            this.CheckBox44.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox45
            // 
            this.CheckBox45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox45.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox45.Location = new System.Drawing.Point(605, 423);
            this.CheckBox45.Name = "CheckBox45";
            this.CheckBox45.Size = new System.Drawing.Size(274, 29);
            this.CheckBox45.TabIndex = 105;
            this.CheckBox45.Text = "备用";
            this.CheckBox45.UseVisualStyleBackColor = true;
            this.CheckBox45.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox46
            // 
            this.CheckBox46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox46.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox46.Location = new System.Drawing.Point(605, 458);
            this.CheckBox46.Name = "CheckBox46";
            this.CheckBox46.Size = new System.Drawing.Size(274, 29);
            this.CheckBox46.TabIndex = 106;
            this.CheckBox46.Text = "备用";
            this.CheckBox46.UseVisualStyleBackColor = true;
            this.CheckBox46.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox47
            // 
            this.CheckBox47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox47.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox47.Location = new System.Drawing.Point(605, 493);
            this.CheckBox47.Name = "CheckBox47";
            this.CheckBox47.Size = new System.Drawing.Size(274, 29);
            this.CheckBox47.TabIndex = 107;
            this.CheckBox47.Text = "备用";
            this.CheckBox47.UseVisualStyleBackColor = true;
            this.CheckBox47.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox48
            // 
            this.CheckBox48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox48.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox48.Location = new System.Drawing.Point(605, 528);
            this.CheckBox48.Name = "CheckBox48";
            this.CheckBox48.Size = new System.Drawing.Size(274, 29);
            this.CheckBox48.TabIndex = 108;
            this.CheckBox48.Text = "备用";
            this.CheckBox48.UseVisualStyleBackColor = true;
            this.CheckBox48.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Label29
            // 
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location = new System.Drawing.Point(297, 350);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(28, 28);
            this.Label29.TabIndex = 42;
            this.Label29.Text = "27";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label28
            // 
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.Location = new System.Drawing.Point(297, 315);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(28, 28);
            this.Label28.TabIndex = 38;
            this.Label28.Text = "26";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label27
            // 
            this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.Location = new System.Drawing.Point(297, 280);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(28, 28);
            this.Label27.TabIndex = 37;
            this.Label27.Text = "25";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label18
            // 
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.Location = new System.Drawing.Point(297, 455);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(28, 28);
            this.Label18.TabIndex = 40;
            this.Label18.Text = "30";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label30
            // 
            this.Label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label30.Location = new System.Drawing.Point(297, 385);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(28, 28);
            this.Label30.TabIndex = 43;
            this.Label30.Text = "28";
            this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label22
            // 
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(297, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(28, 27);
            this.Label22.TabIndex = 29;
            this.Label22.Text = "17";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label23
            // 
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(297, 35);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(28, 28);
            this.Label23.TabIndex = 30;
            this.Label23.Text = "18";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label31
            // 
            this.Label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.Location = new System.Drawing.Point(297, 490);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(28, 28);
            this.Label31.TabIndex = 44;
            this.Label31.Text = "31";
            this.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label20
            // 
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(297, 245);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(28, 28);
            this.Label20.TabIndex = 36;
            this.Label20.Text = "24";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label24
            // 
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.Location = new System.Drawing.Point(297, 70);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(28, 28);
            this.Label24.TabIndex = 31;
            this.Label24.Text = "19";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label21
            // 
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(297, 210);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(28, 28);
            this.Label21.TabIndex = 35;
            this.Label21.Text = "23";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label32
            // 
            this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.Location = new System.Drawing.Point(297, 175);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(28, 28);
            this.Label32.TabIndex = 34;
            this.Label32.Text = "22";
            this.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label26
            // 
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(297, 140);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(28, 28);
            this.Label26.TabIndex = 33;
            this.Label26.Text = "21";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label180
            // 
            this.Label180.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label180.Location = new System.Drawing.Point(571, 490);
            this.Label180.Name = "Label180";
            this.Label180.Size = new System.Drawing.Size(28, 28);
            this.Label180.TabIndex = 77;
            this.Label180.Text = "47";
            this.Label180.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label189
            // 
            this.Label189.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label189.Location = new System.Drawing.Point(571, 455);
            this.Label189.Name = "Label189";
            this.Label189.Size = new System.Drawing.Size(28, 28);
            this.Label189.TabIndex = 78;
            this.Label189.Text = "46";
            this.Label189.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label190
            // 
            this.Label190.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label190.Location = new System.Drawing.Point(571, 420);
            this.Label190.Name = "Label190";
            this.Label190.Size = new System.Drawing.Size(28, 28);
            this.Label190.TabIndex = 79;
            this.Label190.Text = "45";
            this.Label190.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label191
            // 
            this.Label191.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label191.Location = new System.Drawing.Point(571, 385);
            this.Label191.Name = "Label191";
            this.Label191.Size = new System.Drawing.Size(28, 28);
            this.Label191.TabIndex = 80;
            this.Label191.Text = "44";
            this.Label191.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label192
            // 
            this.Label192.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label192.Location = new System.Drawing.Point(571, 350);
            this.Label192.Name = "Label192";
            this.Label192.Size = new System.Drawing.Size(28, 28);
            this.Label192.TabIndex = 81;
            this.Label192.Text = "43";
            this.Label192.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label193
            // 
            this.Label193.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label193.Location = new System.Drawing.Point(571, 315);
            this.Label193.Name = "Label193";
            this.Label193.Size = new System.Drawing.Size(28, 28);
            this.Label193.TabIndex = 82;
            this.Label193.Text = "42";
            this.Label193.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label194
            // 
            this.Label194.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label194.Location = new System.Drawing.Point(571, 280);
            this.Label194.Name = "Label194";
            this.Label194.Size = new System.Drawing.Size(28, 28);
            this.Label194.TabIndex = 83;
            this.Label194.Text = "41";
            this.Label194.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label195
            // 
            this.Label195.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label195.Location = new System.Drawing.Point(571, 245);
            this.Label195.Name = "Label195";
            this.Label195.Size = new System.Drawing.Size(28, 28);
            this.Label195.TabIndex = 84;
            this.Label195.Text = "40";
            this.Label195.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label196
            // 
            this.Label196.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label196.Location = new System.Drawing.Point(571, 210);
            this.Label196.Name = "Label196";
            this.Label196.Size = new System.Drawing.Size(28, 28);
            this.Label196.TabIndex = 85;
            this.Label196.Text = "39";
            this.Label196.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label197
            // 
            this.Label197.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label197.Location = new System.Drawing.Point(571, 175);
            this.Label197.Name = "Label197";
            this.Label197.Size = new System.Drawing.Size(28, 28);
            this.Label197.TabIndex = 86;
            this.Label197.Text = "38";
            this.Label197.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label198
            // 
            this.Label198.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label198.Location = new System.Drawing.Point(571, 140);
            this.Label198.Name = "Label198";
            this.Label198.Size = new System.Drawing.Size(28, 28);
            this.Label198.TabIndex = 87;
            this.Label198.Text = "37";
            this.Label198.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label199
            // 
            this.Label199.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label199.Location = new System.Drawing.Point(571, 105);
            this.Label199.Name = "Label199";
            this.Label199.Size = new System.Drawing.Size(28, 28);
            this.Label199.TabIndex = 88;
            this.Label199.Text = "36";
            this.Label199.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label212
            // 
            this.Label212.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label212.Location = new System.Drawing.Point(571, 70);
            this.Label212.Name = "Label212";
            this.Label212.Size = new System.Drawing.Size(28, 28);
            this.Label212.TabIndex = 89;
            this.Label212.Text = "35";
            this.Label212.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label216
            // 
            this.Label216.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label216.Location = new System.Drawing.Point(571, 35);
            this.Label216.Name = "Label216";
            this.Label216.Size = new System.Drawing.Size(28, 28);
            this.Label216.TabIndex = 90;
            this.Label216.Text = "34";
            this.Label216.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label17
            // 
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(297, 525);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(28, 28);
            this.Label17.TabIndex = 39;
            this.Label17.Text = "32";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label179
            // 
            this.Label179.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label179.Location = new System.Drawing.Point(571, 525);
            this.Label179.Name = "Label179";
            this.Label179.Size = new System.Drawing.Size(28, 28);
            this.Label179.TabIndex = 109;
            this.Label179.Text = "48";
            this.Label179.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckBox2
            // 
            this.CheckBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox2.Location = new System.Drawing.Point(37, 38);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(254, 29);
            this.CheckBox2.TabIndex = 14;
            this.CheckBox2.Text = "开启手持条码枪";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox17
            // 
            this.CheckBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox17.Location = new System.Drawing.Point(331, 3);
            this.CheckBox17.Name = "CheckBox17";
            this.CheckBox17.Size = new System.Drawing.Size(234, 29);
            this.CheckBox17.TabIndex = 47;
            this.CheckBox17.Text = "开启演示功能";
            this.CheckBox17.UseVisualStyleBackColor = true;
            this.CheckBox17.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox19
            // 
            this.CheckBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox19.Location = new System.Drawing.Point(331, 73);
            this.CheckBox19.Name = "CheckBox19";
            this.CheckBox19.Size = new System.Drawing.Size(234, 29);
            this.CheckBox19.TabIndex = 92;
            this.CheckBox19.Text = "开启Errorcode";
            this.CheckBox19.UseVisualStyleBackColor = true;
            this.CheckBox19.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // CheckBox33
            // 
            this.CheckBox33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox33.Location = new System.Drawing.Point(605, 3);
            this.CheckBox33.Name = "CheckBox33";
            this.CheckBox33.Size = new System.Drawing.Size(274, 29);
            this.CheckBox33.TabIndex = 45;
            this.CheckBox33.Text = "备用";
            this.CheckBox33.UseVisualStyleBackColor = true;
            this.CheckBox33.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage3.Controls.Add(this.Button2);
            this.TabPage3.Controls.Add(this.Button1);
            this.TabPage3.Controls.Add(this.Btn_UpadeSoft);
            this.TabPage3.Controls.Add(this.GroupBox16);
            this.TabPage3.Controls.Add(this.GroupBox1);
            this.TabPage3.Controls.Add(this.GroupBox34);
            this.TabPage3.Location = new System.Drawing.Point(4, 39);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(920, 611);
            this.TabPage3.TabIndex = 4;
            this.TabPage3.Text = "  异常统计  ";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(546, 245);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(87, 30);
            this.Button2.TabIndex = 19;
            this.Button2.Text = "TOS";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(419, 245);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(87, 30);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "ERR";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Btn_UpadeSoft
            // 
            this.Btn_UpadeSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UpadeSoft.Location = new System.Drawing.Point(726, 228);
            this.Btn_UpadeSoft.Name = "Btn_UpadeSoft";
            this.Btn_UpadeSoft.Size = new System.Drawing.Size(179, 35);
            this.Btn_UpadeSoft.TabIndex = 17;
            this.Btn_UpadeSoft.Text = "Mini下载软件";
            this.Btn_UpadeSoft.UseVisualStyleBackColor = true;
            // 
            // GroupBox16
            // 
            this.GroupBox16.Controls.Add(this.Button_ErrorCodeOK);
            this.GroupBox16.Controls.Add(this.RadioButton2);
            this.GroupBox16.Controls.Add(this.RadioButton1);
            this.GroupBox16.Controls.Add(this.Com_ErrorCode1);
            this.GroupBox16.Controls.Add(this.Button_ErrorCodeTest);
            this.GroupBox16.Controls.Add(this.Com_ErrorCode2);
            this.GroupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox16.Location = new System.Drawing.Point(419, 28);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new System.Drawing.Size(486, 194);
            this.GroupBox16.TabIndex = 16;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "ErrorCode测试";
            // 
            // Button_ErrorCodeOK
            // 
            this.Button_ErrorCodeOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ErrorCodeOK.Location = new System.Drawing.Point(353, 115);
            this.Button_ErrorCodeOK.Name = "Button_ErrorCodeOK";
            this.Button_ErrorCodeOK.Size = new System.Drawing.Size(115, 33);
            this.Button_ErrorCodeOK.TabIndex = 10;
            this.Button_ErrorCodeOK.Text = "ErrorCode OK";
            this.Button_ErrorCodeOK.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton2.Location = new System.Drawing.Point(17, 121);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(77, 19);
            this.RadioButton2.TabIndex = 9;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "TOS/NPK";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton1.Location = new System.Drawing.Point(17, 68);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(51, 19);
            this.RadioButton1.TabIndex = 8;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "ERR";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Com_ErrorCode1
            // 
            this.Com_ErrorCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_ErrorCode1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Com_ErrorCode1.FormattingEnabled = true;
            this.Com_ErrorCode1.Items.AddRange(new object[] {
            "\"ERR-ESB01-10001,0\"",
            "\"ERR-DOR01-10001,0\"",
            "\"ERR-Servo04-30001,1\"",
            "\"ERR-Servo05-30001,1\"",
            "\"ERR-Servo06-30001,1\"",
            "\"ERR-Servo07-30001,1\"",
            "\"ERR-Servo08-30001,1\"",
            "\"ERR-Servo10-30001,1\"",
            "\"ERR-Servo11-30001,1\"",
            "\"ERR-Servo04-30001,2\"",
            "\"ERR-Servo05-30001,2\"",
            "\"ERR-Servo06-30001,2\"",
            "\"ERR-Servo07-30001,2\"",
            "\"ERR-Servo08-30001,2\"",
            "\"ERR-Servo10-30001,2\"",
            "\"ERR-Servo11-30001,2\"",
            "\"ERR-Servo04-30001,3\"",
            "\"ERR-Servo05-30001,3\"",
            "\"ERR-Servo06-30001,3\"",
            "\"ERR-Servo07-30001,3\"",
            "\"ERR-Servo08-30001,3\"",
            "\"ERR-Servo10-30001,3\"",
            "\"ERR-Servo11-30001,3\"",
            "\"ERR-RBC01-10001,0\"",
            "\"ERR-RBC01-20001,0\"",
            "\"ERR-FXA01-20001,0\"",
            "\"ERR-FXA01-30001,1\"",
            "\"ERR-FXA01-30002,0\"",
            "\"ERR-FXA01-30003,0\"",
            "\"ERR-FXA01-30004,0\"",
            "\"ERR-FXA01-30005,0\"",
            "\"ERR-FXB01-30001,0\"",
            "\"ERR-FXB02-30001,0\"",
            "\"ERR-FXB03-30001,0\"",
            "\"ERR-FXB04-30001,0\"",
            "\"ERR-FXB05-30001,0\"",
            "\"ERR-FXB01-30002,0\"",
            "\"ERR-FXB02-30002,0\"",
            "\"ERR-FXB02-30002,0\"",
            "\"ERR-FXB03-30002,0\"",
            "\"ERR-FXB04-30002,0\"",
            "\"ERR-CCD01-20001,1\"",
            "\"ERR-CCD02-20001,2\"",
            "\"ERR-BSC01-20001,0\"",
            "\"ALM-PFC01-60101,0\"",
            "\"WRN-PFC01-70101,0\"",
            "\"WRN-PFC02-70101,0\""});
            this.Com_ErrorCode1.Location = new System.Drawing.Point(100, 65);
            this.Com_ErrorCode1.Name = "Com_ErrorCode1";
            this.Com_ErrorCode1.Size = new System.Drawing.Size(247, 22);
            this.Com_ErrorCode1.TabIndex = 4;
            // 
            // Button_ErrorCodeTest
            // 
            this.Button_ErrorCodeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ErrorCodeTest.Location = new System.Drawing.Point(353, 59);
            this.Button_ErrorCodeTest.Name = "Button_ErrorCodeTest";
            this.Button_ErrorCodeTest.Size = new System.Drawing.Size(115, 33);
            this.Button_ErrorCodeTest.TabIndex = 5;
            this.Button_ErrorCodeTest.Text = "ErrorCodeTest";
            this.Button_ErrorCodeTest.UseVisualStyleBackColor = true;
            // 
            // Com_ErrorCode2
            // 
            this.Com_ErrorCode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_ErrorCode2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Com_ErrorCode2.FormattingEnabled = true;
            this.Com_ErrorCode2.Items.AddRange(new object[] {
            "\"TOS-PFC01-70201,0\"",
            "\"NPK-PFC01-70601,0\""});
            this.Com_ErrorCode2.Location = new System.Drawing.Point(100, 121);
            this.Com_ErrorCode2.Name = "Com_ErrorCode2";
            this.Com_ErrorCode2.Size = new System.Drawing.Size(247, 22);
            this.Com_ErrorCode2.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label170);
            this.GroupBox1.Controls.Add(this.txt_PickCCDErrCounts);
            this.GroupBox1.Controls.Add(this.txt_MEMErrCounts);
            this.GroupBox1.Controls.Add(this.Label169);
            this.GroupBox1.Controls.Add(this.txt_HsgErrCounts);
            this.GroupBox1.Controls.Add(this.Label89);
            this.GroupBox1.Controls.Add(this.txt_PickErrCounts);
            this.GroupBox1.Controls.Add(this.Label130);
            this.GroupBox1.Controls.Add(this.txt_HsgSnErrCounts);
            this.GroupBox1.Controls.Add(this.Label131);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GroupBox1.Location = new System.Drawing.Point(16, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(376, 294);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Day\'s Count";
            // 
            // Label170
            // 
            this.Label170.AutoSize = true;
            this.Label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label170.Location = new System.Drawing.Point(36, 43);
            this.Label170.Name = "Label170";
            this.Label170.Size = new System.Drawing.Size(106, 17);
            this.Label170.TabIndex = 13;
            this.Label170.Text = "取料拍照异常：";
            // 
            // txt_PickCCDErrCounts
            // 
            this.txt_PickCCDErrCounts.BackColor = System.Drawing.Color.Pink;
            this.txt_PickCCDErrCounts.Enabled = false;
            this.txt_PickCCDErrCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PickCCDErrCounts.Location = new System.Drawing.Point(170, 37);
            this.txt_PickCCDErrCounts.Name = "txt_PickCCDErrCounts";
            this.txt_PickCCDErrCounts.Size = new System.Drawing.Size(100, 23);
            this.txt_PickCCDErrCounts.TabIndex = 12;
            this.txt_PickCCDErrCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MEMErrCounts
            // 
            this.txt_MEMErrCounts.BackColor = System.Drawing.Color.Gold;
            this.txt_MEMErrCounts.Enabled = false;
            this.txt_MEMErrCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MEMErrCounts.Location = new System.Drawing.Point(170, 233);
            this.txt_MEMErrCounts.Name = "txt_MEMErrCounts";
            this.txt_MEMErrCounts.Size = new System.Drawing.Size(100, 23);
            this.txt_MEMErrCounts.TabIndex = 10;
            this.txt_MEMErrCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label169
            // 
            this.Label169.AutoSize = true;
            this.Label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label169.Location = new System.Drawing.Point(36, 239);
            this.Label169.Name = "Label169";
            this.Label169.Size = new System.Drawing.Size(106, 17);
            this.Label169.TabIndex = 11;
            this.Label169.Text = "定位拍照异常：";
            // 
            // txt_HsgErrCounts
            // 
            this.txt_HsgErrCounts.BackColor = System.Drawing.Color.LightPink;
            this.txt_HsgErrCounts.Enabled = false;
            this.txt_HsgErrCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HsgErrCounts.Location = new System.Drawing.Point(170, 184);
            this.txt_HsgErrCounts.Name = "txt_HsgErrCounts";
            this.txt_HsgErrCounts.Size = new System.Drawing.Size(100, 23);
            this.txt_HsgErrCounts.TabIndex = 2;
            this.txt_HsgErrCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label89
            // 
            this.Label89.AutoSize = true;
            this.Label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label89.Location = new System.Drawing.Point(64, 92);
            this.Label89.Name = "Label89";
            this.Label89.Size = new System.Drawing.Size(78, 17);
            this.Label89.TabIndex = 1;
            this.Label89.Text = "吸料异常：";
            // 
            // txt_PickErrCounts
            // 
            this.txt_PickErrCounts.BackColor = System.Drawing.Color.PaleGreen;
            this.txt_PickErrCounts.Enabled = false;
            this.txt_PickErrCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PickErrCounts.Location = new System.Drawing.Point(170, 86);
            this.txt_PickErrCounts.Name = "txt_PickErrCounts";
            this.txt_PickErrCounts.Size = new System.Drawing.Size(100, 23);
            this.txt_PickErrCounts.TabIndex = 0;
            this.txt_PickErrCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label130
            // 
            this.Label130.AutoSize = true;
            this.Label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label130.Location = new System.Drawing.Point(34, 141);
            this.Label130.Name = "Label130";
            this.Label130.Size = new System.Drawing.Size(108, 17);
            this.Label130.TabIndex = 7;
            this.Label130.Text = "HSG条码异常：";
            // 
            // txt_HsgSnErrCounts
            // 
            this.txt_HsgSnErrCounts.BackColor = System.Drawing.Color.LightCyan;
            this.txt_HsgSnErrCounts.Enabled = false;
            this.txt_HsgSnErrCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HsgSnErrCounts.Location = new System.Drawing.Point(170, 135);
            this.txt_HsgSnErrCounts.Name = "txt_HsgSnErrCounts";
            this.txt_HsgSnErrCounts.Size = new System.Drawing.Size(100, 23);
            this.txt_HsgSnErrCounts.TabIndex = 6;
            this.txt_HsgSnErrCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label131
            // 
            this.Label131.AutoSize = true;
            this.Label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label131.Location = new System.Drawing.Point(34, 190);
            this.Label131.Name = "Label131";
            this.Label131.Size = new System.Drawing.Size(108, 17);
            this.Label131.TabIndex = 9;
            this.Label131.Text = "HSG拍照异常：";
            // 
            // GroupBox34
            // 
            this.GroupBox34.Controls.Add(this.Label146);
            this.GroupBox34.Controls.Add(this.Text_NGCounts);
            this.GroupBox34.Controls.Add(this.Label168);
            this.GroupBox34.Controls.Add(this.Text_Yeild);
            this.GroupBox34.Controls.Add(this.Label161);
            this.GroupBox34.Controls.Add(this.Btn_ClearCount);
            this.GroupBox34.Controls.Add(this.Label91);
            this.GroupBox34.Controls.Add(this.txt_ProductCounts);
            this.GroupBox34.Controls.Add(this.Text_OKCounts);
            this.GroupBox34.Controls.Add(this.Label129);
            this.GroupBox34.Controls.Add(this.Label162);
            this.GroupBox34.Controls.Add(this.Label163);
            this.GroupBox34.Controls.Add(this.Label164);
            this.GroupBox34.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox34.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GroupBox34.Location = new System.Drawing.Point(16, 326);
            this.GroupBox34.Name = "GroupBox34";
            this.GroupBox34.Size = new System.Drawing.Size(376, 222);
            this.GroupBox34.TabIndex = 14;
            this.GroupBox34.TabStop = false;
            this.GroupBox34.Text = "Product Day\'s Count";
            // 
            // Label146
            // 
            this.Label146.AutoSize = true;
            this.Label146.ForeColor = System.Drawing.Color.Black;
            this.Label146.Location = new System.Drawing.Point(199, 165);
            this.Label146.Name = "Label146";
            this.Label146.Size = new System.Drawing.Size(23, 17);
            this.Label146.TabIndex = 16;
            this.Label146.Text = "%";
            // 
            // Text_NGCounts
            // 
            this.Text_NGCounts.BackColor = System.Drawing.SystemColors.Control;
            this.Text_NGCounts.ForeColor = System.Drawing.Color.Red;
            this.Text_NGCounts.Location = new System.Drawing.Point(123, 78);
            this.Text_NGCounts.Name = "Text_NGCounts";
            this.Text_NGCounts.ReadOnly = true;
            this.Text_NGCounts.Size = new System.Drawing.Size(70, 25);
            this.Text_NGCounts.TabIndex = 15;
            this.Text_NGCounts.Text = "0";
            this.Text_NGCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label168
            // 
            this.Label168.AutoSize = true;
            this.Label168.ForeColor = System.Drawing.Color.Black;
            this.Label168.Location = new System.Drawing.Point(199, 122);
            this.Label168.Name = "Label168";
            this.Label168.Size = new System.Drawing.Size(32, 17);
            this.Label168.TabIndex = 14;
            this.Label168.Text = "pcs";
            // 
            // Text_Yeild
            // 
            this.Text_Yeild.Location = new System.Drawing.Point(123, 161);
            this.Text_Yeild.Name = "Text_Yeild";
            this.Text_Yeild.ReadOnly = true;
            this.Text_Yeild.Size = new System.Drawing.Size(70, 25);
            this.Text_Yeild.TabIndex = 1;
            this.Text_Yeild.Text = "100";
            this.Text_Yeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label161
            // 
            this.Label161.AutoSize = true;
            this.Label161.ForeColor = System.Drawing.Color.Black;
            this.Label161.Location = new System.Drawing.Point(68, 166);
            this.Label161.Name = "Label161";
            this.Label161.Size = new System.Drawing.Size(55, 17);
            this.Label161.TabIndex = 0;
            this.Label161.Text = "良 率：";
            // 
            // Btn_ClearCount
            // 
            this.Btn_ClearCount.Location = new System.Drawing.Point(296, 188);
            this.Btn_ClearCount.Name = "Btn_ClearCount";
            this.Btn_ClearCount.Size = new System.Drawing.Size(51, 28);
            this.Btn_ClearCount.TabIndex = 2;
            this.Btn_ClearCount.Text = "清零";
            this.Btn_ClearCount.UseVisualStyleBackColor = true;
            this.Btn_ClearCount.Click += new System.EventHandler(this.Btn_ClearCount_Click);
            // 
            // Label91
            // 
            this.Label91.AutoSize = true;
            this.Label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label91.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label91.Location = new System.Drawing.Point(45, 121);
            this.Label91.Name = "Label91";
            this.Label91.Size = new System.Drawing.Size(78, 17);
            this.Label91.TabIndex = 13;
            this.Label91.Text = "产量统计：";
            // 
            // txt_ProductCounts
            // 
            this.txt_ProductCounts.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ProductCounts.Enabled = false;
            this.txt_ProductCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductCounts.Location = new System.Drawing.Point(123, 120);
            this.txt_ProductCounts.Name = "txt_ProductCounts";
            this.txt_ProductCounts.Size = new System.Drawing.Size(70, 23);
            this.txt_ProductCounts.TabIndex = 12;
            this.txt_ProductCounts.Text = "0";
            this.txt_ProductCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_OKCounts
            // 
            this.Text_OKCounts.BackColor = System.Drawing.SystemColors.Control;
            this.Text_OKCounts.ForeColor = System.Drawing.Color.Green;
            this.Text_OKCounts.Location = new System.Drawing.Point(123, 34);
            this.Text_OKCounts.Name = "Text_OKCounts";
            this.Text_OKCounts.ReadOnly = true;
            this.Text_OKCounts.Size = new System.Drawing.Size(70, 25);
            this.Text_OKCounts.TabIndex = 1;
            this.Text_OKCounts.Text = "0";
            this.Text_OKCounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label129
            // 
            this.Label129.AutoSize = true;
            this.Label129.ForeColor = System.Drawing.Color.Black;
            this.Label129.Location = new System.Drawing.Point(199, 82);
            this.Label129.Name = "Label129";
            this.Label129.Size = new System.Drawing.Size(32, 17);
            this.Label129.TabIndex = 0;
            this.Label129.Text = "pcs";
            // 
            // Label162
            // 
            this.Label162.AutoSize = true;
            this.Label162.ForeColor = System.Drawing.Color.Black;
            this.Label162.Location = new System.Drawing.Point(199, 39);
            this.Label162.Name = "Label162";
            this.Label162.Size = new System.Drawing.Size(32, 17);
            this.Label162.TabIndex = 0;
            this.Label162.Text = "pcs";
            // 
            // Label163
            // 
            this.Label163.AutoSize = true;
            this.Label163.ForeColor = System.Drawing.Color.Red;
            this.Label163.Location = new System.Drawing.Point(47, 81);
            this.Label163.Name = "Label163";
            this.Label163.Size = new System.Drawing.Size(76, 17);
            this.Label163.TabIndex = 0;
            this.Label163.Text = "NG 数目：";
            // 
            // Label164
            // 
            this.Label164.AutoSize = true;
            this.Label164.ForeColor = System.Drawing.Color.Green;
            this.Label164.Location = new System.Drawing.Point(47, 39);
            this.Label164.Name = "Label164";
            this.Label164.Size = new System.Drawing.Size(76, 17);
            this.Label164.TabIndex = 0;
            this.Label164.Text = "OK 数目：";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage4.Controls.Add(this.TableLayoutPanel3);
            this.TabPage4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage4.Location = new System.Drawing.Point(4, 39);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(920, 611);
            this.TabPage4.TabIndex = 2;
            this.TabPage4.Text = "  设备信息  ";
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.26229F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.73771F));
            this.TableLayoutPanel3.Controls.Add(this.Label178, 0, 16);
            this.TableLayoutPanel3.Controls.Add(this.Label177, 0, 14);
            this.TableLayoutPanel3.Controls.Add(this.Label175, 0, 10);
            this.TableLayoutPanel3.Controls.Add(this.Label173, 0, 6);
            this.TableLayoutPanel3.Controls.Add(this.Label157, 0, 4);
            this.TableLayoutPanel3.Controls.Add(this.Label156, 0, 2);
            this.TableLayoutPanel3.Controls.Add(this.Label176, 0, 12);
            this.TableLayoutPanel3.Controls.Add(this.Label174, 0, 8);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine1, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine2, 1, 2);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine3, 1, 4);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine4, 1, 6);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine5, 1, 8);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine6, 1, 10);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine7, 1, 12);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine8, 1, 14);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine9, 1, 16);
            this.TableLayoutPanel3.Controls.Add(this.Label254, 0, 18);
            this.TableLayoutPanel3.Controls.Add(this.TextMachine10, 1, 18);
            this.TableLayoutPanel3.Controls.Add(this.Label155, 0, 0);
            this.TableLayoutPanel3.Enabled = false;
            this.TableLayoutPanel3.Location = new System.Drawing.Point(368, 49);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 19;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(244, 528);
            this.TableLayoutPanel3.TabIndex = 0;
            // 
            // Label178
            // 
            this.Label178.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label178.Location = new System.Drawing.Point(3, 448);
            this.Label178.Name = "Label178";
            this.Label178.Size = new System.Drawing.Size(101, 28);
            this.Label178.TabIndex = 19;
            this.Label178.Text = "CCD rev.";
            this.Label178.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label177
            // 
            this.Label177.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label177.Location = new System.Drawing.Point(3, 392);
            this.Label177.Name = "Label177";
            this.Label177.Size = new System.Drawing.Size(101, 26);
            this.Label177.TabIndex = 18;
            this.Label177.Text = "Machine SN";
            this.Label177.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label175
            // 
            this.Label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label175.Location = new System.Drawing.Point(3, 280);
            this.Label175.Name = "Label175";
            this.Label175.Size = new System.Drawing.Size(101, 26);
            this.Label175.TabIndex = 16;
            this.Label175.Text = "AE SubID";
            this.Label175.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label173
            // 
            this.Label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label173.Location = new System.Drawing.Point(3, 168);
            this.Label173.Name = "Label173";
            this.Label173.Size = new System.Drawing.Size(101, 26);
            this.Label173.TabIndex = 14;
            this.Label173.Text = "Line";
            this.Label173.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label157
            // 
            this.Label157.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label157.Location = new System.Drawing.Point(3, 112);
            this.Label157.Name = "Label157";
            this.Label157.Size = new System.Drawing.Size(101, 26);
            this.Label157.TabIndex = 13;
            this.Label157.Text = "Floor";
            this.Label157.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label156
            // 
            this.Label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label156.Location = new System.Drawing.Point(3, 56);
            this.Label156.Name = "Label156";
            this.Label156.Size = new System.Drawing.Size(101, 28);
            this.Label156.TabIndex = 12;
            this.Label156.Text = "BU";
            this.Label156.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label176
            // 
            this.Label176.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label176.Location = new System.Drawing.Point(3, 336);
            this.Label176.Name = "Label176";
            this.Label176.Size = new System.Drawing.Size(101, 26);
            this.Label176.TabIndex = 17;
            this.Label176.Text = "AE Vendor";
            this.Label176.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label174
            // 
            this.Label174.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label174.Location = new System.Drawing.Point(3, 224);
            this.Label174.Name = "Label174";
            this.Label174.Size = new System.Drawing.Size(101, 28);
            this.Label174.TabIndex = 15;
            this.Label174.Text = "AE ID";
            this.Label174.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextMachine1
            // 
            this.TextMachine1.BackColor = System.Drawing.Color.Gold;
            this.TextMachine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine1.Location = new System.Drawing.Point(110, 3);
            this.TextMachine1.Name = "TextMachine1";
            this.TextMachine1.Size = new System.Drawing.Size(116, 23);
            this.TextMachine1.TabIndex = 2;
            this.TextMachine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine2
            // 
            this.TextMachine2.BackColor = System.Drawing.Color.Gold;
            this.TextMachine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine2.Location = new System.Drawing.Point(110, 59);
            this.TextMachine2.Name = "TextMachine2";
            this.TextMachine2.Size = new System.Drawing.Size(116, 23);
            this.TextMachine2.TabIndex = 3;
            this.TextMachine2.Text = "----";
            this.TextMachine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine3
            // 
            this.TextMachine3.BackColor = System.Drawing.Color.Gold;
            this.TextMachine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine3.Location = new System.Drawing.Point(110, 115);
            this.TextMachine3.Name = "TextMachine3";
            this.TextMachine3.Size = new System.Drawing.Size(116, 23);
            this.TextMachine3.TabIndex = 4;
            this.TextMachine3.Text = "---";
            this.TextMachine3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine4
            // 
            this.TextMachine4.BackColor = System.Drawing.Color.Gold;
            this.TextMachine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine4.Location = new System.Drawing.Point(110, 171);
            this.TextMachine4.Name = "TextMachine4";
            this.TextMachine4.Size = new System.Drawing.Size(116, 23);
            this.TextMachine4.TabIndex = 5;
            this.TextMachine4.Text = "---";
            this.TextMachine4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine5
            // 
            this.TextMachine5.BackColor = System.Drawing.Color.Gold;
            this.TextMachine5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine5.Location = new System.Drawing.Point(110, 227);
            this.TextMachine5.Name = "TextMachine5";
            this.TextMachine5.Size = new System.Drawing.Size(116, 23);
            this.TextMachine5.TabIndex = 6;
            this.TextMachine5.Text = "---";
            this.TextMachine5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine6
            // 
            this.TextMachine6.BackColor = System.Drawing.Color.Gold;
            this.TextMachine6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine6.Location = new System.Drawing.Point(110, 283);
            this.TextMachine6.Name = "TextMachine6";
            this.TextMachine6.Size = new System.Drawing.Size(116, 23);
            this.TextMachine6.TabIndex = 7;
            this.TextMachine6.Text = "---";
            this.TextMachine6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine7
            // 
            this.TextMachine7.BackColor = System.Drawing.Color.Gold;
            this.TextMachine7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine7.Location = new System.Drawing.Point(110, 339);
            this.TextMachine7.Name = "TextMachine7";
            this.TextMachine7.Size = new System.Drawing.Size(116, 23);
            this.TextMachine7.TabIndex = 8;
            this.TextMachine7.Text = "BZ";
            this.TextMachine7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine8
            // 
            this.TextMachine8.BackColor = System.Drawing.Color.Gold;
            this.TextMachine8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine8.Location = new System.Drawing.Point(110, 395);
            this.TextMachine8.Name = "TextMachine8";
            this.TextMachine8.Size = new System.Drawing.Size(116, 23);
            this.TextMachine8.TabIndex = 9;
            this.TextMachine8.Text = "001";
            this.TextMachine8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextMachine9
            // 
            this.TextMachine9.BackColor = System.Drawing.Color.Gold;
            this.TextMachine9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMachine9.Location = new System.Drawing.Point(110, 451);
            this.TextMachine9.Name = "TextMachine9";
            this.TextMachine9.Size = new System.Drawing.Size(116, 23);
            this.TextMachine9.TabIndex = 10;
            this.TextMachine9.Text = "01.00";
            this.TextMachine9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label254
            // 
            this.Label254.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label254.Location = new System.Drawing.Point(3, 500);
            this.Label254.Name = "Label254";
            this.Label254.Size = new System.Drawing.Size(101, 28);
            this.Label254.TabIndex = 20;
            this.Label254.Text = "HW rev.";
            this.Label254.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextMachine10
            // 
            this.TextMachine10.BackColor = System.Drawing.Color.Gold;
            this.TextMachine10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextMachine10.Location = new System.Drawing.Point(110, 503);
            this.TextMachine10.Name = "TextMachine10";
            this.TextMachine10.Size = new System.Drawing.Size(116, 23);
            this.TextMachine10.TabIndex = 21;
            this.TextMachine10.Text = "VM0.101";
            this.TextMachine10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label155
            // 
            this.Label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label155.Location = new System.Drawing.Point(3, 0);
            this.Label155.Name = "Label155";
            this.Label155.Size = new System.Drawing.Size(101, 28);
            this.Label155.TabIndex = 11;
            this.Label155.Text = "Project";
            this.Label155.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TabPage5.Controls.Add(this.GroupBox5);
            this.TabPage5.Location = new System.Drawing.Point(4, 39);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(920, 611);
            this.TabPage5.TabIndex = 5;
            this.TabPage5.Text = "帮助文档";
            // 
            // GroupBox5
            // 
            this.GroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.GroupBox5.Controls.Add(this.Label160);
            this.GroupBox5.Controls.Add(this.Label151);
            this.GroupBox5.Controls.Add(this.Label150);
            this.GroupBox5.Controls.Add(this.Label149);
            this.GroupBox5.Controls.Add(this.Label148);
            this.GroupBox5.Controls.Add(this.Label147);
            this.GroupBox5.Controls.Add(this.Label145);
            this.GroupBox5.Controls.Add(this.Label152);
            this.GroupBox5.Controls.Add(this.Label153);
            this.GroupBox5.Controls.Add(this.Label154);
            this.GroupBox5.Controls.Add(this.Label158);
            this.GroupBox5.Controls.Add(this.Label159);
            this.GroupBox5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox5.Location = new System.Drawing.Point(0, 0);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(917, 608);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "驱动器配置参数";
            // 
            // Label160
            // 
            this.Label160.AutoSize = true;
            this.Label160.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label160.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label160.Location = new System.Drawing.Point(269, 243);
            this.Label160.Name = "Label160";
            this.Label160.Size = new System.Drawing.Size(174, 21);
            this.Label160.TabIndex = 17;
            this.Label160.Text = "◆条码枪:192.168.10.55";
            // 
            // Label151
            // 
            this.Label151.AutoSize = true;
            this.Label151.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label151.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label151.Location = new System.Drawing.Point(449, 243);
            this.Label151.Name = "Label151";
            this.Label151.Size = new System.Drawing.Size(161, 21);
            this.Label151.TabIndex = 16;
            this.Label151.Text = "◆PDCA:169.254.0.10";
            // 
            // Label150
            // 
            this.Label150.AutoSize = true;
            this.Label150.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label150.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label150.Location = new System.Drawing.Point(620, 243);
            this.Label150.Name = "Label150";
            this.Label150.Size = new System.Drawing.Size(165, 21);
            this.Label150.TabIndex = 15;
            this.Label150.Text = "◆机械手:192.168.0.20";
            // 
            // Label149
            // 
            this.Label149.AutoSize = true;
            this.Label149.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label149.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label149.Location = new System.Drawing.Point(31, 243);
            this.Label149.Name = "Label149";
            this.Label149.Size = new System.Drawing.Size(237, 21);
            this.Label149.TabIndex = 14;
            this.Label149.Text = "网络IP：◆交换机:192.168.10.68";
            // 
            // Label148
            // 
            this.Label148.AutoSize = true;
            this.Label148.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label148.Location = new System.Drawing.Point(29, 181);
            this.Label148.Name = "Label148";
            this.Label148.Size = new System.Drawing.Size(811, 21);
            this.Label148.TabIndex = 13;
            this.Label148.Text = "CCDX轴：◆P1-00:1001 ◆ P1-01:0100 ◆ P1-44:16 ◆ P1-45:1 ◆P1-46:2500◆P2-15:122 ◆P2-16:" +
    "123 ◆P2-17:121";
            // 
            // Label147
            // 
            this.Label147.AutoSize = true;
            this.Label147.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label147.Location = new System.Drawing.Point(31, 160);
            this.Label147.Name = "Label147";
            this.Label147.Size = new System.Drawing.Size(809, 21);
            this.Label147.TabIndex = 12;
            this.Label147.Text = "光源X轴：◆P1-00:1001 ◆ P1-01:0100 ◆ P1-44:16 ◆ P1-45:1 ◆P1-46:2500◆P2-15:122 ◆P2-16:1" +
    "23 ◆P2-17:121";
            // 
            // Label145
            // 
            this.Label145.AutoSize = true;
            this.Label145.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label145.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label145.Location = new System.Drawing.Point(118, 202);
            this.Label145.Name = "Label145";
            this.Label145.Size = new System.Drawing.Size(692, 21);
            this.Label145.TabIndex = 11;
            this.Label145.Text = "注意：P2-08 :10 为复位伺服，需要断电后，重新设置参数      P1-37 :1-100旋转轴刚性调整参数";
            // 
            // Label152
            // 
            this.Label152.AutoSize = true;
            this.Label152.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label152.Location = new System.Drawing.Point(31, 120);
            this.Label152.Name = "Label152";
            this.Label152.Size = new System.Drawing.Size(819, 21);
            this.Label152.TabIndex = 4;
            this.Label152.Text = "保压R轴：◆P1-00:1001 ◆ P1-01: 0100 ◆ P1-44:40 ◆ P1-45:9 ◆P1-46:9000 ◆P2-15:122 ◆P2-16" +
    ":123 ◆P2-17:121";
            // 
            // Label153
            // 
            this.Label153.AutoSize = true;
            this.Label153.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label153.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label153.Location = new System.Drawing.Point(105, 99);
            this.Label153.Name = "Label153";
            this.Label153.Size = new System.Drawing.Size(622, 21);
            this.Label153.TabIndex = 1;
            this.Label153.Text = "◆P2-19:108 ◆ P2-20:108  （注意：这个参数一定要设置,具体看刹车线接3脚还是5脚）";
            // 
            // Label154
            // 
            this.Label154.AutoSize = true;
            this.Label154.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label154.Location = new System.Drawing.Point(31, 78);
            this.Label154.Name = "Label154";
            this.Label154.Size = new System.Drawing.Size(809, 21);
            this.Label154.TabIndex = 3;
            this.Label154.Text = "保压Z轴：◆P1-00:1001 ◆ P1-01:0100 ◆ P1-44:16 ◆ P1-45:1 ◆P1-46:2500◆P2-15:122 ◆P2-16:1" +
    "23 ◆P2-17:121";
            // 
            // Label158
            // 
            this.Label158.AutoSize = true;
            this.Label158.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label158.Location = new System.Drawing.Point(31, 57);
            this.Label158.Name = "Label158";
            this.Label158.Size = new System.Drawing.Size(809, 21);
            this.Label158.TabIndex = 2;
            this.Label158.Text = "保压Y轴：◆P1-00:1001 ◆ P1-01:0100 ◆ P1-44:16 ◆ P1-45:1 ◆P1-46:2500◆P2-15:122 ◆P2-16:1" +
    "23 ◆P2-17:121";
            // 
            // Label159
            // 
            this.Label159.AutoSize = true;
            this.Label159.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label159.Location = new System.Drawing.Point(31, 36);
            this.Label159.Name = "Label159";
            this.Label159.Size = new System.Drawing.Size(809, 21);
            this.Label159.TabIndex = 1;
            this.Label159.Text = "保压X轴：◆P1-00:1001 ◆ P1-01:0100 ◆ P1-44:16 ◆ P1-45:1 ◆P1-46:2500◆P2-15:122 ◆P2-16:1" +
    "23 ◆P2-17:121";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Btn_ParSave);
            this.Panel1.Controls.Add(this.AxScriptControl1);
            this.Panel1.Controls.Add(this.Btn_ParBackup);
            this.Panel1.Controls.Add(this.Btn_ParKeyboard);
            this.Panel1.Controls.Add(this.Btn_ParEnable);
            this.Panel1.Location = new System.Drawing.Point(931, 40);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(87, 617);
            this.Panel1.TabIndex = 1;
            // 
            // Btn_ParSave
            // 
            this.Btn_ParSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ParSave.Location = new System.Drawing.Point(3, 280);
            this.Btn_ParSave.Name = "Btn_ParSave";
            this.Btn_ParSave.Size = new System.Drawing.Size(80, 60);
            this.Btn_ParSave.TabIndex = 4;
            this.Btn_ParSave.Text = "参数保存";
            this.Btn_ParSave.UseVisualStyleBackColor = true;
            this.Btn_ParSave.Click += new System.EventHandler(this.Btn_ParSave_Click);
            // 
            // AxScriptControl1
            // 
            this.AxScriptControl1.Enabled = true;
            this.AxScriptControl1.Location = new System.Drawing.Point(21, 285);
            this.AxScriptControl1.Name = "AxScriptControl1";
            this.AxScriptControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxScriptControl1.OcxState")));
            this.AxScriptControl1.Size = new System.Drawing.Size(38, 38);
            this.AxScriptControl1.TabIndex = 6;
            // 
            // Btn_ParBackup
            // 
            this.Btn_ParBackup.Enabled = false;
            this.Btn_ParBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ParBackup.Location = new System.Drawing.Point(2, 16);
            this.Btn_ParBackup.Name = "Btn_ParBackup";
            this.Btn_ParBackup.Size = new System.Drawing.Size(80, 60);
            this.Btn_ParBackup.TabIndex = 5;
            this.Btn_ParBackup.Text = "参备份数";
            this.Btn_ParBackup.UseVisualStyleBackColor = true;
            // 
            // Btn_ParKeyboard
            // 
            this.Btn_ParKeyboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ParKeyboard.BackgroundImage")));
            this.Btn_ParKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ParKeyboard.Enabled = false;
            this.Btn_ParKeyboard.Location = new System.Drawing.Point(3, 104);
            this.Btn_ParKeyboard.Name = "Btn_ParKeyboard";
            this.Btn_ParKeyboard.Size = new System.Drawing.Size(80, 60);
            this.Btn_ParKeyboard.TabIndex = 2;
            this.Btn_ParKeyboard.UseVisualStyleBackColor = true;
            this.Btn_ParKeyboard.Click += new System.EventHandler(this.Btn_ParKeyboard_Click);
            // 
            // Btn_ParEnable
            // 
            this.Btn_ParEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ParEnable.Location = new System.Drawing.Point(3, 192);
            this.Btn_ParEnable.Name = "Btn_ParEnable";
            this.Btn_ParEnable.Size = new System.Drawing.Size(80, 60);
            this.Btn_ParEnable.TabIndex = 3;
            this.Btn_ParEnable.Text = "修改允许";
            this.Btn_ParEnable.UseVisualStyleBackColor = true;
            this.Btn_ParEnable.Click += new System.EventHandler(this.Btn_ParEnable_Click);
            // 
            // Frm_Par
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Par";
            this.ShowInTaskbar = false;
            this.Text = "Frm_Par";
            this.Load += new System.EventHandler(this.Frm_Par_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox16.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox34.ResumeLayout(false);
            this.GroupBox34.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AxScriptControl1)).EndInit();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.TextBox TextBox_3;
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Btn_ParBackup;
		internal System.Windows.Forms.Button Btn_ParSave;
		internal System.Windows.Forms.Button Btn_ParKeyboard;
		internal System.Windows.Forms.Button Btn_ParEnable;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
		internal System.Windows.Forms.Label Label178;
		internal System.Windows.Forms.Label Label177;
		internal System.Windows.Forms.Label Label176;
		internal System.Windows.Forms.Label Label175;
		internal System.Windows.Forms.Label Label174;
		internal System.Windows.Forms.Label Label173;
		internal System.Windows.Forms.Label Label157;
		internal System.Windows.Forms.Label Label156;
		internal System.Windows.Forms.TextBox TextMachine1;
		internal System.Windows.Forms.TextBox TextMachine2;
		internal System.Windows.Forms.TextBox TextMachine3;
		internal System.Windows.Forms.TextBox TextMachine4;
		internal System.Windows.Forms.TextBox TextMachine5;
		internal System.Windows.Forms.TextBox TextMachine6;
		internal System.Windows.Forms.TextBox TextMachine7;
		internal System.Windows.Forms.TextBox TextMachine8;
		internal System.Windows.Forms.TextBox TextMachine9;
		internal System.Windows.Forms.Label Label155;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
		internal System.Windows.Forms.Label Label217;
		internal System.Windows.Forms.CheckBox CheckBox33;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.CheckBox CheckBox2;
		internal System.Windows.Forms.CheckBox CheckBox3;
		internal System.Windows.Forms.CheckBox CheckBox4;
		internal System.Windows.Forms.CheckBox CheckBox5;
		internal System.Windows.Forms.CheckBox CheckBox6;
		internal System.Windows.Forms.CheckBox CheckBox7;
		internal System.Windows.Forms.CheckBox CheckBox8;
		internal System.Windows.Forms.CheckBox CheckBox9;
		internal System.Windows.Forms.CheckBox CheckBox10;
		internal System.Windows.Forms.CheckBox CheckBox11;
		internal System.Windows.Forms.CheckBox CheckBox12;
		internal System.Windows.Forms.CheckBox CheckBox13;
		internal System.Windows.Forms.CheckBox CheckBox14;
		internal System.Windows.Forms.CheckBox CheckBox15;
		internal System.Windows.Forms.CheckBox CheckBox16;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label29;
		internal System.Windows.Forms.Label Label28;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label30;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Label Label31;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label32;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.CheckBox CheckBox18;
		internal System.Windows.Forms.CheckBox CheckBox17;
		internal System.Windows.Forms.CheckBox CheckBox20;
		internal System.Windows.Forms.CheckBox CheckBox21;
		internal System.Windows.Forms.CheckBox CheckBox22;
		internal System.Windows.Forms.CheckBox CheckBox23;
		internal System.Windows.Forms.CheckBox CheckBox24;
		internal System.Windows.Forms.CheckBox CheckBox25;
		internal System.Windows.Forms.CheckBox CheckBox26;
		internal System.Windows.Forms.CheckBox CheckBox27;
		internal System.Windows.Forms.CheckBox CheckBox28;
		internal System.Windows.Forms.CheckBox CheckBox29;
		internal System.Windows.Forms.CheckBox CheckBox30;
		internal System.Windows.Forms.CheckBox CheckBox31;
		internal System.Windows.Forms.Label Label180;
		internal System.Windows.Forms.Label Label189;
		internal System.Windows.Forms.Label Label190;
		internal System.Windows.Forms.Label Label191;
		internal System.Windows.Forms.Label Label192;
		internal System.Windows.Forms.Label Label193;
		internal System.Windows.Forms.Label Label194;
		internal System.Windows.Forms.Label Label195;
		internal System.Windows.Forms.Label Label196;
		internal System.Windows.Forms.Label Label197;
		internal System.Windows.Forms.Label Label198;
		internal System.Windows.Forms.Label Label199;
		internal System.Windows.Forms.Label Label212;
		internal System.Windows.Forms.Label Label216;
		internal System.Windows.Forms.CheckBox CheckBox19;
		internal System.Windows.Forms.CheckBox CheckBox32;
		internal System.Windows.Forms.CheckBox CheckBox34;
		internal System.Windows.Forms.CheckBox CheckBox35;
		internal System.Windows.Forms.CheckBox CheckBox36;
		internal System.Windows.Forms.CheckBox CheckBox37;
		internal System.Windows.Forms.CheckBox CheckBox38;
		internal System.Windows.Forms.CheckBox CheckBox39;
		internal System.Windows.Forms.CheckBox CheckBox40;
		internal System.Windows.Forms.CheckBox CheckBox41;
		internal System.Windows.Forms.CheckBox CheckBox42;
		internal System.Windows.Forms.CheckBox CheckBox43;
		internal System.Windows.Forms.CheckBox CheckBox44;
		internal System.Windows.Forms.CheckBox CheckBox45;
		internal System.Windows.Forms.CheckBox CheckBox46;
		internal System.Windows.Forms.CheckBox CheckBox47;
		internal System.Windows.Forms.CheckBox CheckBox48;
		internal System.Windows.Forms.Label Label179;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.Label Label254;
		internal System.Windows.Forms.TextBox TextMachine10;
		internal System.Windows.Forms.Label Label51;
		internal System.Windows.Forms.Label Label50;
		internal System.Windows.Forms.Label Label49;
		internal System.Windows.Forms.Label Label48;
		internal System.Windows.Forms.Label Label47;
		internal System.Windows.Forms.Label Label46;
		internal System.Windows.Forms.Label Label45;
		internal System.Windows.Forms.Label Label44;
		internal System.Windows.Forms.Label Label43;
		internal System.Windows.Forms.Label Label42;
		internal System.Windows.Forms.Label Label41;
		internal System.Windows.Forms.Label Label37;
		internal System.Windows.Forms.Label Label38;
		internal System.Windows.Forms.Label Label40;
		internal System.Windows.Forms.Label Label36;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Label Label39;
		internal System.Windows.Forms.Label Label35;
		internal System.Windows.Forms.TextBox TextBox_1;
		internal System.Windows.Forms.TextBox TextBox_2;
		internal System.Windows.Forms.TextBox TextBox_22;
		internal System.Windows.Forms.TextBox TextBox_23;
		internal System.Windows.Forms.TextBox TextBox_43;
		internal System.Windows.Forms.TextBox TextBox_44;
		internal System.Windows.Forms.TextBox TextBox_4;
		internal System.Windows.Forms.TextBox TextBox_24;
		internal System.Windows.Forms.TextBox TextBox_25;
		internal System.Windows.Forms.TextBox TextBox_45;
		internal System.Windows.Forms.TextBox TextBox_46;
		internal System.Windows.Forms.TextBox TextBox_5;
		internal System.Windows.Forms.TextBox TextBox_6;
		internal System.Windows.Forms.TextBox TextBox_7;
		internal System.Windows.Forms.TextBox TextBox_26;
		internal System.Windows.Forms.TextBox TextBox_27;
		internal System.Windows.Forms.TextBox TextBox_28;
		internal System.Windows.Forms.TextBox TextBox_47;
		internal System.Windows.Forms.TextBox TextBox_48;
		internal System.Windows.Forms.TextBox TextBox_49;
		internal System.Windows.Forms.TextBox TextBox_8;
		internal System.Windows.Forms.TextBox TextBox_9;
		internal System.Windows.Forms.TextBox TextBox_10;
		internal System.Windows.Forms.TextBox TextBox_29;
		internal System.Windows.Forms.TextBox TextBox_30;
		internal System.Windows.Forms.TextBox TextBox_31;
		internal System.Windows.Forms.TextBox TextBox_50;
		internal System.Windows.Forms.TextBox TextBox_51;
		internal System.Windows.Forms.TextBox TextBox_52;
		internal System.Windows.Forms.TextBox TextBox_11;
		internal System.Windows.Forms.TextBox TextBox_12;
		internal System.Windows.Forms.TextBox TextBox_13;
		internal System.Windows.Forms.TextBox TextBox_32;
		internal System.Windows.Forms.TextBox TextBox_33;
		internal System.Windows.Forms.TextBox TextBox_34;
		internal System.Windows.Forms.TextBox TextBox_53;
		internal System.Windows.Forms.TextBox TextBox_54;
		internal System.Windows.Forms.TextBox TextBox_55;
		internal System.Windows.Forms.TextBox TextBox_14;
		internal System.Windows.Forms.TextBox TextBox_15;
		internal System.Windows.Forms.TextBox TextBox_16;
		internal System.Windows.Forms.TextBox TextBox_35;
		internal System.Windows.Forms.TextBox TextBox_36;
		internal System.Windows.Forms.TextBox TextBox_37;
		internal System.Windows.Forms.TextBox TextBox_56;
		internal System.Windows.Forms.TextBox TextBox_57;
		internal System.Windows.Forms.TextBox TextBox_58;
		internal System.Windows.Forms.TextBox TextBox_17;
		internal System.Windows.Forms.TextBox TextBox_38;
		internal System.Windows.Forms.TextBox TextBox_59;
		internal System.Windows.Forms.TextBox TextBox_18;
		internal System.Windows.Forms.TextBox TextBox_39;
		internal System.Windows.Forms.TextBox TextBox_60;
		internal System.Windows.Forms.TextBox TextBox_19;
		internal System.Windows.Forms.TextBox TextBox_40;
		internal System.Windows.Forms.TextBox TextBox_61;
		internal System.Windows.Forms.TextBox TextBox_20;
		internal System.Windows.Forms.TextBox TextBox_41;
		internal System.Windows.Forms.TextBox TextBox_62;
		internal System.Windows.Forms.TextBox TextBox_21;
		internal System.Windows.Forms.TextBox TextBox_42;
		internal System.Windows.Forms.TextBox TextBox_63;
		internal System.Windows.Forms.Label Label55;
		internal System.Windows.Forms.Label Label58;
		internal System.Windows.Forms.Label Label54;
		internal System.Windows.Forms.Label Label57;
		internal System.Windows.Forms.Label Label53;
		internal System.Windows.Forms.Label Label52;
		internal System.Windows.Forms.Label Label56;
		internal System.Windows.Forms.Label Label59;
		internal System.Windows.Forms.Label Label61;
		internal System.Windows.Forms.Label Label62;
		internal System.Windows.Forms.Label Label63;
		internal System.Windows.Forms.Label Label64;
		internal System.Windows.Forms.Label Label60;
		internal System.Windows.Forms.Label Label66;
		internal System.Windows.Forms.Label Label67;
		internal System.Windows.Forms.Label Label68;
		internal System.Windows.Forms.Label Label73;
		internal System.Windows.Forms.Label Label74;
		internal System.Windows.Forms.Label Label75;
		internal System.Windows.Forms.Label Label76;
		internal System.Windows.Forms.Label Label77;
		internal System.Windows.Forms.Label Label78;
		internal System.Windows.Forms.Label Label79;
		internal System.Windows.Forms.Label Label80;
		internal System.Windows.Forms.Label Label81;
		internal System.Windows.Forms.Label Label82;
		internal System.Windows.Forms.Label Label83;
		internal System.Windows.Forms.Label Label84;
		internal System.Windows.Forms.Label Label85;
		internal System.Windows.Forms.Label Label86;
		internal System.Windows.Forms.Label Label87;
		internal System.Windows.Forms.Label Label88;
		internal System.Windows.Forms.Label Label72;
		internal System.Windows.Forms.Label Label65;
		internal System.Windows.Forms.Label Label71;
		internal System.Windows.Forms.Label Label70;
		internal System.Windows.Forms.Label Label69;
		internal System.Windows.Forms.Label Label92;
		internal System.Windows.Forms.Label Label95;
		internal System.Windows.Forms.Label Label96;
		internal System.Windows.Forms.Label Label98;
		internal System.Windows.Forms.Label Label97;
		internal System.Windows.Forms.Label Label94;
		internal System.Windows.Forms.Label Label93;
		internal System.Windows.Forms.Label Label100;
		internal System.Windows.Forms.Label Label99;
		internal System.Windows.Forms.Label Label103;
		internal System.Windows.Forms.Label Label102;
		internal System.Windows.Forms.Label Label101;
		internal System.Windows.Forms.Label Label104;
		internal System.Windows.Forms.Label Label105;
		internal System.Windows.Forms.Label Label106;
		internal System.Windows.Forms.Label Label107;
		internal System.Windows.Forms.Label Label108;
		internal System.Windows.Forms.Label Label109;
		internal System.Windows.Forms.Label Label110;
		internal System.Windows.Forms.Label Label111;
		internal System.Windows.Forms.Label Label112;
		internal System.Windows.Forms.Label Label113;
		internal System.Windows.Forms.Label Label114;
		internal System.Windows.Forms.Label Label115;
		internal System.Windows.Forms.Label Label116;
		internal System.Windows.Forms.Label Label117;
		internal System.Windows.Forms.Label Label118;
		internal System.Windows.Forms.Label Label119;
		internal System.Windows.Forms.Label Label120;
		internal System.Windows.Forms.Label Label121;
		internal System.Windows.Forms.Label Label122;
		internal System.Windows.Forms.Label Label123;
		internal System.Windows.Forms.Label Label124;
		internal System.Windows.Forms.Label Label125;
		internal System.Windows.Forms.Label Label126;
		internal System.Windows.Forms.Label Label127;
		internal System.Windows.Forms.Label Label128;
		internal System.Windows.Forms.Label Label132;
		internal System.Windows.Forms.Label Label133;
		internal System.Windows.Forms.Label Label134;
		internal System.Windows.Forms.Label Label135;
		internal System.Windows.Forms.Label Label136;
		internal System.Windows.Forms.Label Label137;
		internal System.Windows.Forms.Label Label138;
		internal System.Windows.Forms.Label Label139;
		internal System.Windows.Forms.Label Label140;
		internal System.Windows.Forms.Label Label141;
		internal System.Windows.Forms.Label Label142;
		internal System.Windows.Forms.Label Label143;
		internal System.Windows.Forms.Label Label261;
		internal System.Windows.Forms.Label Label264;
		internal System.Windows.Forms.Label Label266;
		internal System.Windows.Forms.Label Label263;
		internal System.Windows.Forms.Label Label33;
		internal System.Windows.Forms.Label Label262;
		internal System.Windows.Forms.Label Label265;
		internal System.Windows.Forms.Label Label130;
		internal System.Windows.Forms.TextBox txt_HsgSnErrCounts;
		internal System.Windows.Forms.TabPage TabPage5;
		internal AxMSScriptControl.AxScriptControl AxScriptControl1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox txt_HsgErrCounts;
		internal System.Windows.Forms.Label Label89;
		internal System.Windows.Forms.Label Label91;
		internal System.Windows.Forms.TextBox txt_ProductCounts;
		internal System.Windows.Forms.TextBox txt_PickErrCounts;
		internal System.Windows.Forms.Label Label131;
		internal System.Windows.Forms.GroupBox GroupBox34;
		internal System.Windows.Forms.Button Btn_ClearCount;
		internal System.Windows.Forms.TextBox Text_Yeild;
		internal System.Windows.Forms.TextBox Text_OKCounts;
		internal System.Windows.Forms.Label Label129;
		internal System.Windows.Forms.Label Label161;
		internal System.Windows.Forms.Label Label162;
		internal System.Windows.Forms.Label Label163;
		internal System.Windows.Forms.Label Label164;
		internal System.Windows.Forms.Label Label144;
		internal System.Windows.Forms.Label Label90;
		internal System.Windows.Forms.Label Label165;
		internal System.Windows.Forms.Label Label166;
		internal System.Windows.Forms.Label Label167;
		internal System.Windows.Forms.Label Label168;
		internal System.Windows.Forms.TextBox txt_MEMErrCounts;
		internal System.Windows.Forms.Label Label169;
		internal System.Windows.Forms.Label Label170;
		internal System.Windows.Forms.TextBox txt_PickCCDErrCounts;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.Label Label145;
		internal System.Windows.Forms.Label Label152;
		internal System.Windows.Forms.Label Label153;
		internal System.Windows.Forms.Label Label154;
		internal System.Windows.Forms.Label Label158;
		internal System.Windows.Forms.Label Label159;
		internal System.Windows.Forms.TextBox Text_NGCounts;
		internal System.Windows.Forms.GroupBox GroupBox16;
		internal System.Windows.Forms.Button Button_ErrorCodeOK;
		internal System.Windows.Forms.RadioButton RadioButton2;
		internal System.Windows.Forms.RadioButton RadioButton1;
		internal System.Windows.Forms.ComboBox Com_ErrorCode1;
		internal System.Windows.Forms.Button Button_ErrorCodeTest;
		internal System.Windows.Forms.ComboBox Com_ErrorCode2;
		internal System.Windows.Forms.Button Btn_UpadeSoft;
		internal System.Windows.Forms.Label Label146;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label148;
		internal System.Windows.Forms.Label Label147;
		internal System.Windows.Forms.Label Label149;
		internal System.Windows.Forms.Label Label150;
		internal System.Windows.Forms.Label Label151;
        internal System.Windows.Forms.Label Label160;
	}
	
}
