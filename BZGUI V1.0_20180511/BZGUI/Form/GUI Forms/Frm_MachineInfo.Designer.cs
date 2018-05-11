
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
	partial class Frm_MachineInfo : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MachineInfo));
            this.Label_TotalLifeRejects = new System.Windows.Forms.Label();
            this.Label_TotalLifeCycle = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label_SoftwareVersion = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label59 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Panel3 = new BoTech.Panel();
            this.Panel1 = new BoTech.Panel();
            this.Panel2 = new BoTech.Panel();
            this.Panel4 = new BoTech.Panel();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_TotalLifeRejects
            // 
            this.Label_TotalLifeRejects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label_TotalLifeRejects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalLifeRejects.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalLifeRejects.Location = new System.Drawing.Point(220, 162);
            this.Label_TotalLifeRejects.Name = "Label_TotalLifeRejects";
            this.Label_TotalLifeRejects.Size = new System.Drawing.Size(82, 27);
            this.Label_TotalLifeRejects.TabIndex = 37;
            this.Label_TotalLifeRejects.Text = "0 PCS";
            this.Label_TotalLifeRejects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_TotalLifeCycle
            // 
            this.Label_TotalLifeCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label_TotalLifeCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalLifeCycle.ForeColor = System.Drawing.Color.Black;
            this.Label_TotalLifeCycle.Location = new System.Drawing.Point(220, 129);
            this.Label_TotalLifeCycle.Name = "Label_TotalLifeCycle";
            this.Label_TotalLifeCycle.Size = new System.Drawing.Size(82, 27);
            this.Label_TotalLifeCycle.TabIndex = 36;
            this.Label_TotalLifeCycle.Text = "0 PCS";
            this.Label_TotalLifeCycle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label41
            // 
            this.Label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.ForeColor = System.Drawing.Color.Black;
            this.Label41.Location = new System.Drawing.Point(220, 30);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(147, 27);
            this.Label41.TabIndex = 35;
            this.Label41.Text = "07/26/17";
            this.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label39
            // 
            this.Label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.ForeColor = System.Drawing.Color.Black;
            this.Label39.Location = new System.Drawing.Point(54, 162);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(160, 27);
            this.Label39.TabIndex = 32;
            this.Label39.Text = "Total Life Rejects:";
            this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(220, 96);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(165, 27);
            this.Label11.TabIndex = 34;
            this.Label11.Text = "07/26/17";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label38
            // 
            this.Label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.ForeColor = System.Drawing.Color.Black;
            this.Label38.Location = new System.Drawing.Point(54, 129);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(160, 27);
            this.Label38.TabIndex = 31;
            this.Label38.Text = "Total Life Cycles:";
            this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_SoftwareVersion
            // 
            this.Label_SoftwareVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label_SoftwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SoftwareVersion.ForeColor = System.Drawing.Color.Black;
            this.Label_SoftwareVersion.Location = new System.Drawing.Point(220, 63);
            this.Label_SoftwareVersion.Name = "Label_SoftwareVersion";
            this.Label_SoftwareVersion.Size = new System.Drawing.Size(165, 27);
            this.Label_SoftwareVersion.TabIndex = 33;
            this.Label_SoftwareVersion.Text = "SV1.0.0";
            this.Label_SoftwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label37
            // 
            this.Label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.ForeColor = System.Drawing.Color.Black;
            this.Label37.Location = new System.Drawing.Point(54, 96);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(160, 27);
            this.Label37.TabIndex = 30;
            this.Label37.Text = "SW Updated:";
            this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label36
            // 
            this.Label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.ForeColor = System.Drawing.Color.Black;
            this.Label36.Location = new System.Drawing.Point(54, 63);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(160, 27);
            this.Label36.TabIndex = 29;
            this.Label36.Text = "SW Rev:";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label35
            // 
            this.Label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.ForeColor = System.Drawing.Color.Black;
            this.Label35.Location = new System.Drawing.Point(54, 30);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(160, 27);
            this.Label35.TabIndex = 28;
            this.Label35.Text = "Build Date:";
            this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(196, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 27);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "0.6 Psi";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label40
            // 
            this.Label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label40.ForeColor = System.Drawing.Color.Black;
            this.Label40.Location = new System.Drawing.Point(43, 96);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(156, 27);
            this.Label40.TabIndex = 21;
            this.Label40.Text = "Air Press Rail:";
            this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(196, 63);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 27);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "0.6 Psi";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(43, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(156, 27);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Air Press Clamp:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(196, 30);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(73, 27);
            this.Label12.TabIndex = 18;
            this.Label12.Text = "0.6 Psi";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(43, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(156, 27);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Air Press In:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Gainsboro;
            this.Label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(399, 172);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(123, 50);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "XG-H500M";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label60
            // 
            this.Label60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label60.Location = new System.Drawing.Point(276, 55);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(1, 115);
            this.Label60.TabIndex = 29;
            // 
            // Label59
            // 
            this.Label59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label59.Location = new System.Drawing.Point(399, 55);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(1, 115);
            this.Label59.TabIndex = 28;
            // 
            // Label57
            // 
            this.Label57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label57.Location = new System.Drawing.Point(153, 55);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(1, 115);
            this.Label57.TabIndex = 27;
            // 
            // Label42
            // 
            this.Label42.BackColor = System.Drawing.Color.Gainsboro;
            this.Label42.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.ForeColor = System.Drawing.Color.Black;
            this.Label42.Location = new System.Drawing.Point(399, 122);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(123, 50);
            this.Label42.TabIndex = 24;
            this.Label42.Text = "XG-X 2500";
            this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label43
            // 
            this.Label43.BackColor = System.Drawing.Color.Gainsboro;
            this.Label43.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.ForeColor = System.Drawing.Color.Black;
            this.Label43.Location = new System.Drawing.Point(276, 122);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(123, 50);
            this.Label43.TabIndex = 23;
            this.Label43.Text = "DMR-262X-1540-P";
            this.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label55
            // 
            this.Label55.BackColor = System.Drawing.Color.Gainsboro;
            this.Label55.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.ForeColor = System.Drawing.Color.Black;
            this.Label55.Location = new System.Drawing.Point(153, 122);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(123, 50);
            this.Label55.TabIndex = 22;
            this.Label55.Text = "LH-45C-12V-W";
            this.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label56
            // 
            this.Label56.BackColor = System.Drawing.Color.Gainsboro;
            this.Label56.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.ForeColor = System.Drawing.Color.Black;
            this.Label56.Location = new System.Drawing.Point(30, 122);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(123, 50);
            this.Label56.TabIndex = 21;
            this.Label56.Text = "RV-2F-1D-S11";
            this.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label48
            // 
            this.Label48.BackColor = System.Drawing.Color.White;
            this.Label48.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label48.ForeColor = System.Drawing.Color.Black;
            this.Label48.Location = new System.Drawing.Point(399, 96);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(123, 25);
            this.Label48.TabIndex = 20;
            this.Label48.Text = "Keyence";
            this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label49
            // 
            this.Label49.BackColor = System.Drawing.Color.White;
            this.Label49.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.ForeColor = System.Drawing.Color.Black;
            this.Label49.Location = new System.Drawing.Point(276, 96);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(123, 25);
            this.Label49.TabIndex = 19;
            this.Label49.Text = "Cognex";
            this.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label50
            // 
            this.Label50.BackColor = System.Drawing.Color.White;
            this.Label50.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50.ForeColor = System.Drawing.Color.Black;
            this.Label50.Location = new System.Drawing.Point(153, 96);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(123, 25);
            this.Label50.TabIndex = 18;
            this.Label50.Text = "LH";
            this.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label51
            // 
            this.Label51.BackColor = System.Drawing.Color.White;
            this.Label51.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label51.ForeColor = System.Drawing.Color.Black;
            this.Label51.Location = new System.Drawing.Point(30, 96);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(123, 25);
            this.Label51.TabIndex = 17;
            this.Label51.Text = "Mitsubishi";
            this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label46
            // 
            this.Label46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label46.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.ForeColor = System.Drawing.Color.White;
            this.Label46.Location = new System.Drawing.Point(399, 55);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(123, 40);
            this.Label46.TabIndex = 16;
            this.Label46.Text = "VISION";
            this.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label47
            // 
            this.Label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label47.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.ForeColor = System.Drawing.Color.White;
            this.Label47.Location = new System.Drawing.Point(276, 55);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(123, 40);
            this.Label47.TabIndex = 15;
            this.Label47.Text = "SCAN";
            this.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label45
            // 
            this.Label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label45.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label45.ForeColor = System.Drawing.Color.White;
            this.Label45.Location = new System.Drawing.Point(153, 55);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(123, 40);
            this.Label45.TabIndex = 14;
            this.Label45.Text = "LIGHT";
            this.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label44
            // 
            this.Label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.Label44.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.ForeColor = System.Drawing.Color.White;
            this.Label44.Location = new System.Drawing.Point(30, 55);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(123, 40);
            this.Label44.TabIndex = 13;
            this.Label44.Text = "MOTION";
            this.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(319, 181);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(127, 17);
            this.Label6.TabIndex = 30;
            this.Label6.Text = "Final Check";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label54
            // 
            this.Label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label54.ForeColor = System.Drawing.Color.Black;
            this.Label54.Image = ((System.Drawing.Image)(resources.GetObject("Label54.Image")));
            this.Label54.Location = new System.Drawing.Point(294, 81);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(24, 24);
            this.Label54.TabIndex = 29;
            this.Label54.Text = ">";
            // 
            // Label53
            // 
            this.Label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.ForeColor = System.Drawing.Color.Black;
            this.Label53.Image = ((System.Drawing.Image)(resources.GetObject("Label53.Image")));
            this.Label53.Location = new System.Drawing.Point(141, 81);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(24, 24);
            this.Label53.TabIndex = 28;
            this.Label53.Text = ">";
            // 
            // Label58
            // 
            this.Label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.ForeColor = System.Drawing.Color.Black;
            this.Label58.Image = ((System.Drawing.Image)(resources.GetObject("Label58.Image")));
            this.Label58.Location = new System.Drawing.Point(294, 81);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(24, 24);
            this.Label58.TabIndex = 27;
            this.Label58.Visible = false;
            // 
            // Label61
            // 
            this.Label61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label61.ForeColor = System.Drawing.Color.Black;
            this.Label61.Image = ((System.Drawing.Image)(resources.GetObject("Label61.Image")));
            this.Label61.Location = new System.Drawing.Point(141, 81);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(24, 24);
            this.Label61.TabIndex = 26;
            this.Label61.Visible = false;
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.Color.Black;
            this.Label34.Location = new System.Drawing.Point(319, 149);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(127, 17);
            this.Label34.TabIndex = 24;
            this.Label34.Text = "OUTPUT";
            this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.ForeColor = System.Drawing.Color.Black;
            this.Label33.Location = new System.Drawing.Point(13, 181);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(100, 20);
            this.Label33.TabIndex = 23;
            this.Label33.Text = "Get Barcode";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.ForeColor = System.Drawing.Color.Black;
            this.Label32.Location = new System.Drawing.Point(166, 181);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(128, 20);
            this.Label32.TabIndex = 22;
            this.Label32.Text = "Place Membrane";
            // 
            // Label31
            // 
            this.Label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.ForeColor = System.Drawing.Color.Black;
            this.Label31.Location = new System.Drawing.Point(166, 149);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(127, 17);
            this.Label31.TabIndex = 20;
            this.Label31.Text = "WORK";
            this.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.ForeColor = System.Drawing.Color.Black;
            this.Label28.Location = new System.Drawing.Point(13, 149);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(127, 17);
            this.Label28.TabIndex = 18;
            this.Label28.Text = "INPUT";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(191)))));
            this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.Color.Black;
            this.Label27.Location = new System.Drawing.Point(319, 55);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(127, 71);
            this.Label27.TabIndex = 17;
            this.Label27.Text = "WAITING";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(218)))), ((int)(((byte)(150)))));
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.Color.Black;
            this.Label26.Location = new System.Drawing.Point(166, 55);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(127, 71);
            this.Label26.TabIndex = 16;
            this.Label26.Text = "ACTIVE";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label25
            // 
            this.Label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(191)))));
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.Color.Black;
            this.Label25.Location = new System.Drawing.Point(13, 55);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(127, 71);
            this.Label25.TabIndex = 15;
            this.Label25.Text = "WAITING";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            this.Panel3.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.BZ_Radius = 11;
            this.Panel3.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Label40);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.Label12);
            this.Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel3.Location = new System.Drawing.Point(558, 2);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(458, 221);
            this.Panel3.TabIndex = 47;
            // 
            // Panel1
            // 
            this.Panel1.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel1.BZ_Radius = 11;
            this.Panel1.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label26);
            this.Panel1.Controls.Add(this.Label54);
            this.Panel1.Controls.Add(this.Label25);
            this.Panel1.Controls.Add(this.Label53);
            this.Panel1.Controls.Add(this.Label27);
            this.Panel1.Controls.Add(this.Label58);
            this.Panel1.Controls.Add(this.Label28);
            this.Panel1.Controls.Add(this.Label61);
            this.Panel1.Controls.Add(this.Label31);
            this.Panel1.Controls.Add(this.Label34);
            this.Panel1.Controls.Add(this.Label32);
            this.Panel1.Controls.Add(this.Label33);
            this.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel1.Location = new System.Drawing.Point(558, 228);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(458, 427);
            this.Panel1.TabIndex = 48;
            // 
            // Panel2
            // 
            this.Panel2.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel2.BZ_Radius = 11;
            this.Panel2.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel2.Controls.Add(this.Label_TotalLifeRejects);
            this.Panel2.Controls.Add(this.Label36);
            this.Panel2.Controls.Add(this.Label_TotalLifeCycle);
            this.Panel2.Controls.Add(this.Label35);
            this.Panel2.Controls.Add(this.Label41);
            this.Panel2.Controls.Add(this.Label37);
            this.Panel2.Controls.Add(this.Label39);
            this.Panel2.Controls.Add(this.Label_SoftwareVersion);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label38);
            this.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel2.Location = new System.Drawing.Point(3, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(550, 221);
            this.Panel2.TabIndex = 49;
            // 
            // Panel4
            // 
            this.Panel4.BZ_Color = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel4.BZ_Radius = 11;
            this.Panel4.BZ_RoundStyle = BoTech.Panel.RoundStyle.All;
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.Label45);
            this.Panel4.Controls.Add(this.Label60);
            this.Panel4.Controls.Add(this.Label44);
            this.Panel4.Controls.Add(this.Label59);
            this.Panel4.Controls.Add(this.Label47);
            this.Panel4.Controls.Add(this.Label57);
            this.Panel4.Controls.Add(this.Label46);
            this.Panel4.Controls.Add(this.Label42);
            this.Panel4.Controls.Add(this.Label51);
            this.Panel4.Controls.Add(this.Label43);
            this.Panel4.Controls.Add(this.Label50);
            this.Panel4.Controls.Add(this.Label55);
            this.Panel4.Controls.Add(this.Label49);
            this.Panel4.Controls.Add(this.Label56);
            this.Panel4.Controls.Add(this.Label48);
            this.Panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Panel4.Location = new System.Drawing.Point(3, 228);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(550, 427);
            this.Panel4.TabIndex = 50;
            // 
            // Frm_MachineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MachineInfo";
            this.ShowInTaskbar = false;
            this.Text = "Frm_MachineInfo";
            this.Load += new System.EventHandler(this.Frm_MachineInfo_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label Label42;
		internal System.Windows.Forms.Label Label43;
		internal System.Windows.Forms.Label Label55;
		internal System.Windows.Forms.Label Label56;
		internal System.Windows.Forms.Label Label48;
		internal System.Windows.Forms.Label Label50;
		internal System.Windows.Forms.Label Label51;
		internal System.Windows.Forms.Label Label46;
		internal System.Windows.Forms.Label Label47;
		internal System.Windows.Forms.Label Label45;
		internal System.Windows.Forms.Label Label44;
		internal System.Windows.Forms.Label Label58;
		internal System.Windows.Forms.Label Label61;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Label Label33;
		internal System.Windows.Forms.Label Label32;
		internal System.Windows.Forms.Label Label31;
		internal System.Windows.Forms.Label Label28;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label40;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label_TotalLifeRejects;
		internal System.Windows.Forms.Label Label_TotalLifeCycle;
		internal System.Windows.Forms.Label Label41;
		internal System.Windows.Forms.Label Label39;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label38;
		internal System.Windows.Forms.Label Label_SoftwareVersion;
		internal System.Windows.Forms.Label Label37;
		internal System.Windows.Forms.Label Label36;
		internal System.Windows.Forms.Label Label35;
		internal System.Windows.Forms.Label Label60;
		internal System.Windows.Forms.Label Label59;
		internal System.Windows.Forms.Label Label57;
		internal System.Windows.Forms.Label Label54;
		internal System.Windows.Forms.Label Label53;
		internal System.Windows.Forms.Label Label49;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal BoTech.Panel Panel3;
		internal BoTech.Panel Panel1;
		internal BoTech.Panel Panel2;
		internal BoTech.Panel Panel4;
	}
	
}
