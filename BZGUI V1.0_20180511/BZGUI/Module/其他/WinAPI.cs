
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


using VB = Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Threading;


namespace BZGUI
{
	sealed class WinAPI
	{
		
		public const int MAX_TOOLTIP = 64;
		public const int NIF_ICON = 0x2;
		public const int NIF_MESSAGE = 0x1;
		public const int NIF_TIP = 0x4;
		public const int NIM_ADD = 0x0;
		public const int NIM_MODIFY = 0x1;
		public const int NIM_DELETE = 0x2;
		public const int WM_MOUSEMOVE = 0x200;
		public const int WM_LBUTTONDOWN = 0x201;
		public const int WM_LBUTTONUP = 0x202;
		public const int WM_LBUTTONDBLCLK = 0x203;
		public const int WM_RBUTTONDOWN = 0x204;
		public const int WM_RBUTTONUP = 0x205;
		public const int WM_RBUTTONDBLCLK = 0x206;
		public const int SW_RESTORE = 9;
		public const int SW_HIDE = 0;
		public const int WM_SYSCOMMAND = 0x112;
		public const int SC_CLOSE = 0xF060;
		public const int WM_CLOSE = 0x10;
        //public static NOTIFYICONDATA nfIconData;
		
        //public struct NOTIFYICONDATA
        //{
        //    public long cbSize;
        //    public long hwnd;
        //    public long uID;
        //    public long uFlags;
        //    public long uCallbackMessage;
        //    public long hIcon;
        //}
        //public struct SYSTEMTIME
        //{
        //    public int wYear;
        //    public int wMonth;
        //    public int wDayOfWeek;
        //    public int wDay;
        //    public int wHour;
        //    public int wMinute;
        //    public int wSecond;
        //    public int wMilliseconds;
        //}
		
		[DllImport("user32",EntryPoint="GetDC", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int GetDC(int hwnd);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int CloseWindow(int hwnd);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int DestroyWindow(int hwnd);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int wFlags);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int MessageBeep(int wType);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int Beep(int dwFreq, int dwDuration);
		//Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Object) As Integer
		[DllImport("kernel32.dll",EntryPoint="RtlMoveMemory", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern void CopyMemory(long Destination, long source, long Length);
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
        //public static extern void GetSystemTime(SystemTIME lpSystemTime);
		//Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
        //[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long SetWindowPos(long hwnd, long hWndInsertAfter, long X, long Y, long cx, long cy, long wFlags);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long ShowWindow(long hwnd, long nCmdShow);
		[DllImport("shell32.dll",EntryPoint="Shell_NotifyIconA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
        //public static extern long Shell_NotifyIcon(long dwMessage, NOTIFYICONDATA lpData);
        //[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long Beep(long dwFreq, long dwDuration);
		[DllImport("user32",EntryPoint="PostMessageA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long PostMessage(long hwnd, long wMsg, long wParam, object lParam);
		[DllImport("kernel32",EntryPoint="LCMapStringA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long LCMapString(long Locale, long dwMapFlags, string lpSrcStr, long cchSrc, string lpDestStr, long cchDest);
		[DllImport("kernel32",EntryPoint="lstrlenA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long lstrlen(string lpString);
		[DllImport("advapi32.dll",EntryPoint="RegEnumValueA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long RegEnumValue(long hKey, long dwIndex, string lpValueName, long lpcbValueName, long lpReserved, long lpType, object lpData, long lpcbData);
		//Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Object) As Long
		
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long DeleteMenu(int hMenu, int nPosition, int wFlags);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long GetMenuItemCount(long hMenu);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long GetSystemMenu(int hwnd, long bRevert);
		
		[DllImport("user32",EntryPoint="SendMessageA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, byte[] lParam);
		public const int HWND_TOPMOST = -1; //让X为假值
		public const int SWP_SHOWWINDOW = 0x40;
		public const int DJ_BYPOSITION = 0x400;

        public static void Wait(int DT)
            {
            int TT = 0;
            TT = System.Convert.ToInt32(API.GetTickCount());
            do
                {
                System.Threading.Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
                if (System.Convert.ToInt32(API.GetTickCount()) - TT < 0)
                    {
                    TT = System.Convert.ToInt32(API.GetTickCount());
                    }
                } while (!(System.Convert.ToInt32(API.GetTickCount()) - TT >= DT));
            }
		
	}
	
}
