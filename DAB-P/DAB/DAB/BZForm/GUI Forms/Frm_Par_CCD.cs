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
	
	public partial class Frm_Par_CCD
	{
        public static Frm_Par_CCD fPar_CCD = new Frm_Par_CCD();  
		public Frm_Par_CCD()
		{
			InitializeComponent();
            fPar_CCD = this;
		}

        private void Frm_Par_CCD_Load(object sender, EventArgs e)
            {
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.fMain.Main_Color;
            }

        private void Btn_ParEnable_MouseDown(object sender, EventArgs e)
            {
            if (Frm_Login.fLogin.Visible == false)
                {
                if (Frm_Login.fLogin == null || Frm_Login.fLogin.IsDisposed)
                    {
                    Frm_Login.fLogin = new Frm_Login();
                    }
                Frm_Login.fLogin.Show();
                }
            }

        private void Btn_ParKeyboard_Click(object sender, EventArgs e)
            {
            int SoftKeyBoard_hwnd = 0; //定义标识句柄变量
            int Temp_hwnd = 0;
            Temp_hwnd = System.Convert.ToInt32(API.FindWindow(Constants.vbNullString, "Frm_Main"));
            SoftKeyBoard_hwnd = API.FindWindow(Constants.vbNullString, "屏幕键盘"); //获取屏幕键盘的标识句柄
            if (SoftKeyBoard_hwnd > 0) //判断屏幕键盘的标识句柄是否获取成功，不等于0则说明获取成功
                {
                API.BringWindowToTop(SoftKeyBoard_hwnd); //屏幕键盘已打开则将屏幕键盘放置在所有窗体的顶部
                }
            else
                {
                API.ShellExecute(Temp_hwnd, "Open", "屏幕数字键盘.exe", "", Application.StartupPath, 4); //屏幕键盘未打开则指定路径打开屏幕键盘
                }
            }

        private void Btn_ParEnable_Click(object sender, EventArgs e)
            {
            Frm_Login FrmLogin = new Frm_Login();
            if (FrmLogin.Visible == false)
                {
                FrmLogin.Show();
                FrmLogin.MainPassword.Focus();
                }
            }

        private void Btn_ParSave_Click(object sender, EventArgs e)
            {

            }


		
	}
}
