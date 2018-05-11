
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
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace BZGUI
{
	sealed class CapScreenApi
	{
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int ShowWindow(int hwnd, int nCmdShow);
		public const int SW_SHOWMAXIMIZED = 3;
		public const int WM_LBUTTONDOWN = 0x201;
		public const int WM_LBUTTONUP = 0x202;
		public const int MK_RBUTTON = 0x2;
		public const int MK_LBUTTON = 0x1;
		[DllImport("user32",EntryPoint="PostMessageA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int PostMessage(int hwnd, int wMsg, int wParam, int lParam);
		[DllImport("user32",EntryPoint="SendMessageA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
		//Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
		[DllImport("user32",EntryPoint="FindWindowExA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int FindWindowEx(int hWndParent, int hWndChildAfter, string lpClassName, string lpWindowName);
		public static void SShoW_RESTORE(bool Mode)
		{
			int CaptureHwnd = 0;
			string MainWndCaptionName = "";
			string SubWndCaptionName = "";
			if (Mode)
			{
				MainWndCaptionName = "MCT2008";
				SubWndCaptionName = "LJ-Navigator 2 - 监视中 - [显示轮廓]";
			}
			else
			{
				MainWndCaptionName = "LJ-Navigator View profile";
				SubWndCaptionName = "View profile";
			}
			CaptureHwnd = System.Convert.ToInt32(API.FindWindow(Constants.vbNullString, MainWndCaptionName));
			if (CaptureHwnd == 0)
			{
				CaptureHwnd = System.Convert.ToInt32(API.FindWindow(Constants.vbNullString, SubWndCaptionName));
			}
			ShowWindow(CaptureHwnd, SW_SHOWMAXIMIZED);
		}
		
		public static void SShotLaserScreen(bool Mode, string strItemName)
		{
			int CaptureHwnd = 0;
			string MainWndCaptionName = "";
			string SubWndCaptionName = "";
			string S1BmpFileName = "";
			if (Mode)
			{
				MainWndCaptionName = "MCT2008";
				SubWndCaptionName = "LJ-Navigator 2 - 监视中 - [显示轮廓]";
			}
			else
			{
				MainWndCaptionName = "LJ-Navigator View profile";
				SubWndCaptionName = "View profile";
			}
            if (!System.IO.Directory.Exists("E:\\BZ-Data\\Laser"))
			{
            System.IO.Directory.CreateDirectory("E:\\BZ-Data\\Laser");
			}

            if (!System.IO.Directory.Exists("E:\\BZ-Data\\Laser\\S1") )
			{
                System.IO.Directory.CreateDirectory("E:\\BZ-Data\\Laser\\S1");
			}

            if (!System.IO.Directory.Exists("E:\\BZ-Data\\Laser\\S1\\" + DateTime.Now.Date.ToString("yyyy-MM-dd")))
			{
            System.IO.Directory.CreateDirectory("E:\\BZ-Data\\Laser\\S1\\" + DateTime.Now.Date.ToString("yyyy-MM-dd"));
			}
			
			S1BmpFileName = "E:\\BZ-Data\\Laser\\S1\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "\\" + "_" + strItemName + "_" + Strings.Format(DateTime.Now, "yyyyMMddHHmmss") +".bmp";
			
			CaptureHwnd = System.Convert.ToInt32(API.FindWindow(Constants.vbNullString, MainWndCaptionName));
			
			if (CaptureHwnd == 0)
			{
				CaptureHwnd = System.Convert.ToInt32(API.FindWindow(Constants.vbNullString, SubWndCaptionName));
			}
			//Call ShowWindow(CaptureHwnd, SW_SHOWMAXIMIZED)
            IntPtr ss = new IntPtr((int)CaptureHwnd);
			BZ.UI.CaptureScreen cp = new BZ.UI.CaptureScreen();
			cp.BZ_Setup("4TFS-2LZ9-375W-1Oi8-ljge-esx6");
            cp.PrintWindow(ss, S1BmpFileName, Color.Green, strItemName + " SN:" + "  -TRAY_SN:", 50, 0);
		}
		
		public static void SendLaserView(string LaserName)
		{
			switch (LaserName)
			{
				case "A":
					ClickChildWnd(Constants.vbNullString, "LJ-Navigator 2 - 监视中", Constants.vbNullString, "toolStrip1", 380, 20);
					break;
				case "B":
					ClickChildWnd(Constants.vbNullString, "LJ-Navigator 2 - 监视中", Constants.vbNullString, "toolStrip1", 400, 20);
					break;
				default:
					break;
			}
		}
		
		public static void ClickChildWnd(string lpClassNameP, string lpWndNameP, string lpClassNameC, string lpWndNameC, int x, int y)
		{
			//Dim hwndP As Integer, hwndC As Integer, hwndC1 As Integer, hwndC2 As Integer, hwndC3 As Integer
			int hwndP = System.Convert.ToInt32(API.FindWindow(lpClassNameP, lpWndNameP)); //主窗体名
			int hwndC1 = System.Convert.ToInt32(FindWindowEx(hwndP, 0, "WindowsForms10.MDICLIENT.app.0.218f99c", Constants.vbNullString));
			int hwndC2 = System.Convert.ToInt32(FindWindowEx(hwndC1, 0, Constants.vbNullString, "显示轮廓")); //窗体名Diasplay profile
			int hwndC3 = System.Convert.ToInt32(FindWindowEx(hwndC2, 0, Constants.vbNullString, ""));
			int hwndC = System.Convert.ToInt32(FindWindowEx(hwndC3, 0, Constants.vbNullString, lpWndNameC));
			
			PostMessage(hwndC, WM_LBUTTONDOWN, MK_LBUTTON, MKLparam(x, y));
			PostMessage(hwndC, WM_LBUTTONUP, MK_LBUTTON, MKLparam(x, y));
		}
		
		public static int MKLparam(int x, int y)
		{
			int rValue = 0;
			int y2 = 0;
			y2 = y << 16;
			rValue = x + y2;
			return rValue;
		}
		
	}
	
	
	
}
