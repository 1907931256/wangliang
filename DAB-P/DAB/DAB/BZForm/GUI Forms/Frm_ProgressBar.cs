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

namespace DAB
{
	public partial class Frm_ProgressBar
	{
        public static Frm_ProgressBar fProgressBar = new Frm_ProgressBar();
		public Frm_ProgressBar()
		{
			InitializeComponent();
            fProgressBar = this;
		}
        public static void IsShowProgresBar(bool IsShow)
            {

            if (IsShow)
                {
                if (fProgressBar == null || fProgressBar.IsDisposed)
                    {
                    fProgressBar = new Frm_ProgressBar();
                    }
                fProgressBar.Show();
                }
            else
                {
                fProgressBar.Close();

                }
            }
		
		public static void SetValueProgressBar(int Value)
		{
			if (Value >= 0 & Value <= 100)
			{
            fProgressBar.InitProgressBar.Value = Value;
			}
		}
	}
}
