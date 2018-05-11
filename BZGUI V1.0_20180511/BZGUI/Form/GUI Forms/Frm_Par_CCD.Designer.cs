
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
	partial class Frm_Par_CCD : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Par_CCD));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.Label39 = new System.Windows.Forms.Label();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.TextBox13 = new System.Windows.Forms.TextBox();
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.TextBox17 = new System.Windows.Forms.TextBox();
            this.TextBox15 = new System.Windows.Forms.TextBox();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox19 = new System.Windows.Forms.TextBox();
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
            this.TextBox20 = new System.Windows.Forms.TextBox();
            this.TextBox21 = new System.Windows.Forms.TextBox();
            this.TextBox22 = new System.Windows.Forms.TextBox();
            this.TextBox23 = new System.Windows.Forms.TextBox();
            this.TextBox24 = new System.Windows.Forms.TextBox();
            this.TextBox25 = new System.Windows.Forms.TextBox();
            this.TextBox26 = new System.Windows.Forms.TextBox();
            this.TextBox27 = new System.Windows.Forms.TextBox();
            this.TextBox28 = new System.Windows.Forms.TextBox();
            this.TextBox29 = new System.Windows.Forms.TextBox();
            this.TextBox30 = new System.Windows.Forms.TextBox();
            this.TextBox31 = new System.Windows.Forms.TextBox();
            this.TextBox32 = new System.Windows.Forms.TextBox();
            this.TextBox33 = new System.Windows.Forms.TextBox();
            this.TextBox34 = new System.Windows.Forms.TextBox();
            this.TextBox35 = new System.Windows.Forms.TextBox();
            this.TextBox36 = new System.Windows.Forms.TextBox();
            this.TextBox37 = new System.Windows.Forms.TextBox();
            this.TextBox38 = new System.Windows.Forms.TextBox();
            this.Label100 = new System.Windows.Forms.Label();
            this.Label101 = new System.Windows.Forms.Label();
            this.Label104 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label55 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Btn_ParBackup = new System.Windows.Forms.Button();
            this.Btn_ParSave = new System.Windows.Forms.Button();
            this.Btn_ParKeyboard = new System.Windows.Forms.Button();
            this.Btn_ParEnable = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.ItemSize = new System.Drawing.Size(50, 35);
            this.TabControl1.Location = new System.Drawing.Point(2, 5);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(928, 654);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage1.Controls.Add(this.TableLayoutPanel1);
            this.TabPage1.Location = new System.Drawing.Point(4, 39);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(920, 611);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "  CCD参数设定";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 7;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.TableLayoutPanel1.Controls.Add(this.TextBox2, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.TextBox3, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBox4, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.TextBox5, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label38, 0, 6);
            this.TableLayoutPanel1.Controls.Add(this.TextBox6, 1, 5);
            this.TableLayoutPanel1.Controls.Add(this.TextBox8, 1, 7);
            this.TableLayoutPanel1.Controls.Add(this.TextBox7, 1, 6);
            this.TableLayoutPanel1.Controls.Add(this.Label39, 0, 5);
            this.TableLayoutPanel1.Controls.Add(this.TextBox9, 1, 8);
            this.TableLayoutPanel1.Controls.Add(this.TextBox12, 1, 11);
            this.TableLayoutPanel1.Controls.Add(this.TextBox10, 1, 9);
            this.TableLayoutPanel1.Controls.Add(this.TextBox14, 1, 13);
            this.TableLayoutPanel1.Controls.Add(this.TextBox11, 1, 10);
            this.TableLayoutPanel1.Controls.Add(this.TextBox13, 1, 12);
            this.TableLayoutPanel1.Controls.Add(this.TextBox16, 1, 15);
            this.TableLayoutPanel1.Controls.Add(this.TextBox17, 1, 16);
            this.TableLayoutPanel1.Controls.Add(this.TextBox15, 1, 14);
            this.TableLayoutPanel1.Controls.Add(this.TextBox18, 1, 17);
            this.TableLayoutPanel1.Controls.Add(this.TextBox1, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.TextBox19, 1, 18);
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
            this.TableLayoutPanel1.Controls.Add(this.TextBox20, 4, 0);
            this.TableLayoutPanel1.Controls.Add(this.TextBox21, 4, 1);
            this.TableLayoutPanel1.Controls.Add(this.TextBox22, 4, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBox23, 4, 3);
            this.TableLayoutPanel1.Controls.Add(this.TextBox24, 4, 4);
            this.TableLayoutPanel1.Controls.Add(this.TextBox25, 4, 5);
            this.TableLayoutPanel1.Controls.Add(this.TextBox26, 4, 6);
            this.TableLayoutPanel1.Controls.Add(this.TextBox27, 4, 7);
            this.TableLayoutPanel1.Controls.Add(this.TextBox28, 4, 8);
            this.TableLayoutPanel1.Controls.Add(this.TextBox29, 4, 9);
            this.TableLayoutPanel1.Controls.Add(this.TextBox30, 4, 10);
            this.TableLayoutPanel1.Controls.Add(this.TextBox31, 4, 11);
            this.TableLayoutPanel1.Controls.Add(this.TextBox32, 4, 12);
            this.TableLayoutPanel1.Controls.Add(this.TextBox33, 4, 13);
            this.TableLayoutPanel1.Controls.Add(this.TextBox34, 4, 14);
            this.TableLayoutPanel1.Controls.Add(this.TextBox35, 4, 15);
            this.TableLayoutPanel1.Controls.Add(this.TextBox36, 4, 16);
            this.TableLayoutPanel1.Controls.Add(this.TextBox37, 4, 17);
            this.TableLayoutPanel1.Controls.Add(this.TextBox38, 4, 18);
            this.TableLayoutPanel1.Controls.Add(this.Label100, 3, 16);
            this.TableLayoutPanel1.Controls.Add(this.Label101, 3, 17);
            this.TableLayoutPanel1.Controls.Add(this.Label104, 3, 18);
            this.TableLayoutPanel1.Controls.Add(this.Label34, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label35, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label36, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label40, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label33, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label58, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.Label54, 3, 1);
            this.TableLayoutPanel1.Controls.Add(this.Label57, 3, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label53, 3, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label55, 3, 4);
            this.TableLayoutPanel1.Enabled = false;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(110, 32);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 20;
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
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(700, 550);
            this.TableLayoutPanel1.TabIndex = 6;
            // 
            // Label51
            // 
            this.Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.Location = new System.Drawing.Point(3, 504);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(144, 20);
            this.Label51.TabIndex = 37;
            this.Label51.Text = "  备  份  :";
            this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label50
            // 
            this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50.Location = new System.Drawing.Point(3, 476);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(144, 20);
            this.Label50.TabIndex = 35;
            this.Label50.Text = "  备  份  :";
            this.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label49
            // 
            this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.Location = new System.Drawing.Point(3, 448);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(144, 20);
            this.Label49.TabIndex = 33;
            this.Label49.Text = "  备  份  :";
            this.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label48
            // 
            this.Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label48.Location = new System.Drawing.Point(3, 420);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(144, 25);
            this.Label48.TabIndex = 30;
            this.Label48.Text = "  备  份  :";
            this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label47
            // 
            this.Label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.Location = new System.Drawing.Point(3, 392);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(144, 25);
            this.Label47.TabIndex = 29;
            this.Label47.Text = "  备  份  :";
            this.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label46
            // 
            this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location = new System.Drawing.Point(3, 364);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(144, 25);
            this.Label46.TabIndex = 27;
            this.Label46.Text = "  备  份  :";
            this.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label45
            // 
            this.Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label45.Location = new System.Drawing.Point(3, 336);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(144, 25);
            this.Label45.TabIndex = 25;
            this.Label45.Text = "  备  份  :";
            this.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label44
            // 
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.Location = new System.Drawing.Point(3, 308);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(144, 25);
            this.Label44.TabIndex = 23;
            this.Label44.Text = "  备  份  :";
            this.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label43
            // 
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.Location = new System.Drawing.Point(3, 280);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(144, 25);
            this.Label43.TabIndex = 21;
            this.Label43.Text = "  备  份  :";
            this.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label42
            // 
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.Location = new System.Drawing.Point(3, 252);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(144, 25);
            this.Label42.TabIndex = 19;
            this.Label42.Text = "  备  份  :";
            this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label41
            // 
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(3, 224);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(144, 25);
            this.Label41.TabIndex = 17;
            this.Label41.Text = "  备  份  :";
            this.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label37
            // 
            this.Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.Location = new System.Drawing.Point(3, 196);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(144, 25);
            this.Label37.TabIndex = 14;
            this.Label37.Text = "  备  份  :";
            this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(153, 31);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(114, 23);
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Text = "0";
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(153, 59);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(114, 23);
            this.TextBox3.TabIndex = 5;
            this.TextBox3.Text = "0";
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            this.TextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.Location = new System.Drawing.Point(153, 87);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(114, 23);
            this.TextBox4.TabIndex = 7;
            this.TextBox4.Text = "0";
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.Location = new System.Drawing.Point(153, 115);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(114, 23);
            this.TextBox5.TabIndex = 15;
            this.TextBox5.Text = "0";
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label38
            // 
            this.Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.Location = new System.Drawing.Point(3, 168);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(144, 25);
            this.Label38.TabIndex = 12;
            this.Label38.Text = "  备  份  :";
            this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox6
            // 
            this.TextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox6.Location = new System.Drawing.Point(153, 143);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(114, 23);
            this.TextBox6.TabIndex = 13;
            this.TextBox6.Text = "0";
            this.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox8.Location = new System.Drawing.Point(153, 199);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(114, 23);
            this.TextBox8.TabIndex = 9;
            this.TextBox8.Text = "0";
            this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7.Location = new System.Drawing.Point(153, 171);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(114, 23);
            this.TextBox7.TabIndex = 11;
            this.TextBox7.Text = "0";
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label39
            // 
            this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.Location = new System.Drawing.Point(3, 140);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(144, 25);
            this.Label39.TabIndex = 10;
            this.Label39.Text = "  备  份  :";
            this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox9
            // 
            this.TextBox9.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox9.Location = new System.Drawing.Point(153, 227);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(114, 23);
            this.TextBox9.TabIndex = 16;
            this.TextBox9.Text = "0";
            this.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox12
            // 
            this.TextBox12.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox12.Location = new System.Drawing.Point(153, 311);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(114, 23);
            this.TextBox12.TabIndex = 22;
            this.TextBox12.Text = "0";
            this.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox10
            // 
            this.TextBox10.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox10.Location = new System.Drawing.Point(153, 255);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new System.Drawing.Size(114, 23);
            this.TextBox10.TabIndex = 18;
            this.TextBox10.Text = "0";
            this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox14
            // 
            this.TextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox14.Location = new System.Drawing.Point(153, 367);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.Size = new System.Drawing.Size(114, 23);
            this.TextBox14.TabIndex = 26;
            this.TextBox14.Text = "0";
            this.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox11
            // 
            this.TextBox11.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox11.Location = new System.Drawing.Point(153, 283);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.Size = new System.Drawing.Size(114, 23);
            this.TextBox11.TabIndex = 20;
            this.TextBox11.Text = "0";
            this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox13
            // 
            this.TextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox13.Location = new System.Drawing.Point(153, 339);
            this.TextBox13.Name = "TextBox13";
            this.TextBox13.Size = new System.Drawing.Size(114, 23);
            this.TextBox13.TabIndex = 24;
            this.TextBox13.Text = "0";
            this.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox16
            // 
            this.TextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox16.Location = new System.Drawing.Point(153, 423);
            this.TextBox16.Name = "TextBox16";
            this.TextBox16.Size = new System.Drawing.Size(114, 23);
            this.TextBox16.TabIndex = 31;
            this.TextBox16.Text = "0";
            this.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox17
            // 
            this.TextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox17.Location = new System.Drawing.Point(153, 451);
            this.TextBox17.Name = "TextBox17";
            this.TextBox17.Size = new System.Drawing.Size(114, 23);
            this.TextBox17.TabIndex = 32;
            this.TextBox17.Text = "0";
            this.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox15
            // 
            this.TextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox15.Location = new System.Drawing.Point(153, 395);
            this.TextBox15.Name = "TextBox15";
            this.TextBox15.Size = new System.Drawing.Size(114, 23);
            this.TextBox15.TabIndex = 28;
            this.TextBox15.Text = "0";
            this.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox18
            // 
            this.TextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox18.Location = new System.Drawing.Point(153, 479);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.Size = new System.Drawing.Size(114, 23);
            this.TextBox18.TabIndex = 34;
            this.TextBox18.Text = "0";
            this.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(153, 3);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(114, 23);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "0";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox19
            // 
            this.TextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox19.Location = new System.Drawing.Point(153, 507);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.Size = new System.Drawing.Size(114, 23);
            this.TextBox19.TabIndex = 36;
            this.TextBox19.Text = "0";
            this.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label52
            // 
            this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.Location = new System.Drawing.Point(309, 140);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(144, 20);
            this.Label52.TabIndex = 39;
            this.Label52.Text = "  备  份  :";
            this.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label56
            // 
            this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.Location = new System.Drawing.Point(309, 168);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(144, 25);
            this.Label56.TabIndex = 46;
            this.Label56.Text = "  备  份  :";
            this.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label59
            // 
            this.Label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label59.Location = new System.Drawing.Point(309, 196);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(144, 25);
            this.Label59.TabIndex = 47;
            this.Label59.Text = "  备  份  :";
            this.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label61
            // 
            this.Label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label61.Location = new System.Drawing.Point(309, 224);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(144, 25);
            this.Label61.TabIndex = 49;
            this.Label61.Text = "  备  份  :";
            this.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label62
            // 
            this.Label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label62.Location = new System.Drawing.Point(309, 252);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(144, 25);
            this.Label62.TabIndex = 50;
            this.Label62.Text = "  备  份  :";
            this.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label63
            // 
            this.Label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label63.Location = new System.Drawing.Point(309, 280);
            this.Label63.Name = "Label63";
            this.Label63.Size = new System.Drawing.Size(144, 25);
            this.Label63.TabIndex = 51;
            this.Label63.Text = "  备  份  :";
            this.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label64
            // 
            this.Label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label64.Location = new System.Drawing.Point(309, 308);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(144, 25);
            this.Label64.TabIndex = 52;
            this.Label64.Text = "  备  份  :";
            this.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label60
            // 
            this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label60.Location = new System.Drawing.Point(309, 336);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(144, 25);
            this.Label60.TabIndex = 48;
            this.Label60.Text = "  备  份  :";
            this.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label66
            // 
            this.Label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label66.Location = new System.Drawing.Point(309, 364);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(144, 25);
            this.Label66.TabIndex = 54;
            this.Label66.Text = "  备  份  :";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label67
            // 
            this.Label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label67.Location = new System.Drawing.Point(309, 392);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(144, 25);
            this.Label67.TabIndex = 55;
            this.Label67.Text = "  备  份  :";
            this.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label68
            // 
            this.Label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label68.Location = new System.Drawing.Point(309, 420);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(144, 25);
            this.Label68.TabIndex = 56;
            this.Label68.Text = "  备  份  :";
            this.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox20
            // 
            this.TextBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox20.Location = new System.Drawing.Point(459, 3);
            this.TextBox20.Name = "TextBox20";
            this.TextBox20.Size = new System.Drawing.Size(114, 23);
            this.TextBox20.TabIndex = 38;
            this.TextBox20.Text = "0";
            this.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox21
            // 
            this.TextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox21.Location = new System.Drawing.Point(459, 31);
            this.TextBox21.Name = "TextBox21";
            this.TextBox21.Size = new System.Drawing.Size(114, 23);
            this.TextBox21.TabIndex = 61;
            this.TextBox21.Text = "0";
            this.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox22
            // 
            this.TextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox22.Location = new System.Drawing.Point(459, 59);
            this.TextBox22.Name = "TextBox22";
            this.TextBox22.Size = new System.Drawing.Size(114, 23);
            this.TextBox22.TabIndex = 62;
            this.TextBox22.Text = "0";
            this.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox23
            // 
            this.TextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox23.Location = new System.Drawing.Point(459, 87);
            this.TextBox23.Name = "TextBox23";
            this.TextBox23.Size = new System.Drawing.Size(114, 23);
            this.TextBox23.TabIndex = 63;
            this.TextBox23.Text = "0";
            this.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox24
            // 
            this.TextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox24.Location = new System.Drawing.Point(459, 115);
            this.TextBox24.Name = "TextBox24";
            this.TextBox24.Size = new System.Drawing.Size(114, 23);
            this.TextBox24.TabIndex = 64;
            this.TextBox24.Text = "0";
            this.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox25
            // 
            this.TextBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox25.Location = new System.Drawing.Point(459, 143);
            this.TextBox25.Name = "TextBox25";
            this.TextBox25.Size = new System.Drawing.Size(114, 23);
            this.TextBox25.TabIndex = 65;
            this.TextBox25.Text = "0";
            this.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox26
            // 
            this.TextBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox26.Location = new System.Drawing.Point(459, 171);
            this.TextBox26.Name = "TextBox26";
            this.TextBox26.Size = new System.Drawing.Size(114, 23);
            this.TextBox26.TabIndex = 66;
            this.TextBox26.Text = "0";
            this.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox27
            // 
            this.TextBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox27.Location = new System.Drawing.Point(459, 199);
            this.TextBox27.Name = "TextBox27";
            this.TextBox27.Size = new System.Drawing.Size(114, 23);
            this.TextBox27.TabIndex = 86;
            this.TextBox27.Text = "0";
            this.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox28
            // 
            this.TextBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox28.Location = new System.Drawing.Point(459, 227);
            this.TextBox28.Name = "TextBox28";
            this.TextBox28.Size = new System.Drawing.Size(114, 23);
            this.TextBox28.TabIndex = 87;
            this.TextBox28.Text = "0";
            this.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox29
            // 
            this.TextBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox29.Location = new System.Drawing.Point(459, 255);
            this.TextBox29.Name = "TextBox29";
            this.TextBox29.Size = new System.Drawing.Size(114, 23);
            this.TextBox29.TabIndex = 88;
            this.TextBox29.Text = "0";
            this.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox30
            // 
            this.TextBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox30.Location = new System.Drawing.Point(459, 283);
            this.TextBox30.Name = "TextBox30";
            this.TextBox30.Size = new System.Drawing.Size(114, 23);
            this.TextBox30.TabIndex = 89;
            this.TextBox30.Text = "0";
            this.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox31
            // 
            this.TextBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox31.Location = new System.Drawing.Point(459, 311);
            this.TextBox31.Name = "TextBox31";
            this.TextBox31.Size = new System.Drawing.Size(114, 23);
            this.TextBox31.TabIndex = 90;
            this.TextBox31.Text = "0";
            this.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox32
            // 
            this.TextBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox32.Location = new System.Drawing.Point(459, 339);
            this.TextBox32.Name = "TextBox32";
            this.TextBox32.Size = new System.Drawing.Size(114, 23);
            this.TextBox32.TabIndex = 91;
            this.TextBox32.Text = "0";
            this.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox33
            // 
            this.TextBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox33.Location = new System.Drawing.Point(459, 367);
            this.TextBox33.Name = "TextBox33";
            this.TextBox33.Size = new System.Drawing.Size(114, 23);
            this.TextBox33.TabIndex = 92;
            this.TextBox33.Text = "0";
            this.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox34
            // 
            this.TextBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox34.Location = new System.Drawing.Point(459, 395);
            this.TextBox34.Name = "TextBox34";
            this.TextBox34.Size = new System.Drawing.Size(114, 23);
            this.TextBox34.TabIndex = 93;
            this.TextBox34.Text = "0";
            this.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox35
            // 
            this.TextBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox35.Location = new System.Drawing.Point(459, 423);
            this.TextBox35.Name = "TextBox35";
            this.TextBox35.Size = new System.Drawing.Size(114, 23);
            this.TextBox35.TabIndex = 94;
            this.TextBox35.Text = "0";
            this.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox36
            // 
            this.TextBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox36.Location = new System.Drawing.Point(459, 451);
            this.TextBox36.Name = "TextBox36";
            this.TextBox36.Size = new System.Drawing.Size(114, 23);
            this.TextBox36.TabIndex = 95;
            this.TextBox36.Text = "0";
            this.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox37
            // 
            this.TextBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox37.Location = new System.Drawing.Point(459, 479);
            this.TextBox37.Name = "TextBox37";
            this.TextBox37.Size = new System.Drawing.Size(114, 23);
            this.TextBox37.TabIndex = 96;
            this.TextBox37.Text = "0";
            this.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox38
            // 
            this.TextBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox38.Location = new System.Drawing.Point(459, 507);
            this.TextBox38.Name = "TextBox38";
            this.TextBox38.Size = new System.Drawing.Size(114, 23);
            this.TextBox38.TabIndex = 97;
            this.TextBox38.Text = "0";
            this.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label100
            // 
            this.Label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label100.Location = new System.Drawing.Point(309, 448);
            this.Label100.Name = "Label100";
            this.Label100.Size = new System.Drawing.Size(144, 25);
            this.Label100.TabIndex = 110;
            this.Label100.Text = "  备  份  :";
            this.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label101
            // 
            this.Label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label101.Location = new System.Drawing.Point(309, 476);
            this.Label101.Name = "Label101";
            this.Label101.Size = new System.Drawing.Size(144, 25);
            this.Label101.TabIndex = 111;
            this.Label101.Text = "  备  份  :";
            this.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label104
            // 
            this.Label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label104.Location = new System.Drawing.Point(309, 504);
            this.Label104.Name = "Label104";
            this.Label104.Size = new System.Drawing.Size(144, 25);
            this.Label104.TabIndex = 114;
            this.Label104.Text = "  备  份  :";
            this.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label34
            // 
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.Location = new System.Drawing.Point(3, 0);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(144, 25);
            this.Label34.TabIndex = 2;
            this.Label34.Text = "CCD光源端口:";
            this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label35
            // 
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.Location = new System.Drawing.Point(3, 28);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(144, 25);
            this.Label35.TabIndex = 4;
            this.Label35.Text = "  备  份  :";
            this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label36
            // 
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.Location = new System.Drawing.Point(3, 56);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(144, 25);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "  备  份  :";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label40
            // 
            this.Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label40.Location = new System.Drawing.Point(3, 84);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(144, 25);
            this.Label40.TabIndex = 8;
            this.Label40.Text = "  备  份  :";
            this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label33
            // 
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.Location = new System.Drawing.Point(3, 112);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(144, 25);
            this.Label33.TabIndex = 0;
            this.Label33.Text = "  备  份  :";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label58
            // 
            this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.Location = new System.Drawing.Point(309, 0);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(144, 25);
            this.Label58.TabIndex = 45;
            this.Label58.Text = "  备  份  :";
            this.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label54
            // 
            this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label54.Location = new System.Drawing.Point(309, 28);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(144, 20);
            this.Label54.TabIndex = 41;
            this.Label54.Text = "  备  份  :";
            this.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label57
            // 
            this.Label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label57.Location = new System.Drawing.Point(309, 56);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(144, 25);
            this.Label57.TabIndex = 44;
            this.Label57.Text = "  备  份  :";
            this.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label53
            // 
            this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.Location = new System.Drawing.Point(309, 84);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(144, 25);
            this.Label53.TabIndex = 40;
            this.Label53.Text = "  备  份  :";
            this.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label55
            // 
            this.Label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.Location = new System.Drawing.Point(309, 112);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(144, 25);
            this.Label55.TabIndex = 42;
            this.Label55.Text = "  备  份  :";
            this.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Btn_ParBackup);
            this.Panel1.Controls.Add(this.Btn_ParSave);
            this.Panel1.Controls.Add(this.Btn_ParKeyboard);
            this.Panel1.Controls.Add(this.Btn_ParEnable);
            this.Panel1.Location = new System.Drawing.Point(931, 40);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(87, 617);
            this.Panel1.TabIndex = 2;
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
            this.Btn_ParBackup.Click += new System.EventHandler(this.Btn_ParBackup_Click);
            // 
            // Btn_ParSave
            // 
            this.Btn_ParSave.Enabled = false;
            this.Btn_ParSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ParSave.Location = new System.Drawing.Point(3, 280);
            this.Btn_ParSave.Name = "Btn_ParSave";
            this.Btn_ParSave.Size = new System.Drawing.Size(80, 60);
            this.Btn_ParSave.TabIndex = 4;
            this.Btn_ParSave.Text = "参数保存";
            this.Btn_ParSave.UseVisualStyleBackColor = true;
            this.Btn_ParSave.Click += new System.EventHandler(this.Btn_ParSave_Click);
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
            this.Btn_ParKeyboard.Click += new System.EventHandler(this.Btn_ParKeyboard_Click_1);
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
            // Frm_Par_CCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Par_CCD";
            this.ShowInTaskbar = false;
            this.Text = "Frm_Par_CCD";
            this.Load += new System.EventHandler(this.Frm_Par_CCD_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
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
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.Label Label38;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.Label Label40;
		internal System.Windows.Forms.Label Label33;
		internal System.Windows.Forms.Label Label36;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Label Label39;
		internal System.Windows.Forms.Label Label35;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.TextBox TextBox13;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.TextBox TextBox15;
		internal System.Windows.Forms.TextBox TextBox18;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.TextBox TextBox19;
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
		internal System.Windows.Forms.TextBox TextBox20;
		internal System.Windows.Forms.TextBox TextBox21;
		internal System.Windows.Forms.TextBox TextBox22;
		internal System.Windows.Forms.TextBox TextBox23;
		internal System.Windows.Forms.TextBox TextBox24;
		internal System.Windows.Forms.TextBox TextBox25;
		internal System.Windows.Forms.TextBox TextBox26;
		internal System.Windows.Forms.TextBox TextBox27;
		internal System.Windows.Forms.TextBox TextBox28;
		internal System.Windows.Forms.TextBox TextBox29;
		internal System.Windows.Forms.TextBox TextBox30;
		internal System.Windows.Forms.TextBox TextBox31;
		internal System.Windows.Forms.TextBox TextBox32;
		internal System.Windows.Forms.TextBox TextBox33;
		internal System.Windows.Forms.TextBox TextBox34;
		internal System.Windows.Forms.TextBox TextBox35;
		internal System.Windows.Forms.TextBox TextBox36;
		internal System.Windows.Forms.TextBox TextBox37;
		internal System.Windows.Forms.TextBox TextBox38;
		internal System.Windows.Forms.Label Label100;
		internal System.Windows.Forms.Label Label101;
		internal System.Windows.Forms.Label Label104;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Btn_ParBackup;
		internal System.Windows.Forms.Button Btn_ParSave;
		internal System.Windows.Forms.Button Btn_ParKeyboard;
		internal System.Windows.Forms.Button Btn_ParEnable;
	}
	
}
