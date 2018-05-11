
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
	public partial class MessageShow
	{
		public MessageShow()
		{
			InitializeComponent();
		}
		
		private void Btn_Confirm_Click(object sender, EventArgs e)
		{
			

			
			if (this.Lab_Message.Text.Substring(0, 4) == "请换料盘")
			{
				//HuanLiao = False
			}
			this.Dispose();
		}
	}
}
