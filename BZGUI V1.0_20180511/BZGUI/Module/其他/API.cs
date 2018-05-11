
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

namespace BZGUI
{
	sealed class API
	{
		[DllImport("kernel32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int GetTickCount();
		[DllImport("kernel32",EntryPoint="GetPrivateProfileStringA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
			public static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, string lpFileName);
		[DllImport("kernel32",EntryPoint="WritePrivateProfileStringA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
		[DllImport("user32",EntryPoint="FindWindowA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int FindWindow(string lpClassName, string lpWindowName);
		[DllImport("user32",EntryPoint="GetDC", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int GetDC(int hwnd);
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int BringWindowToTop(int hwnd);
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
		[DllImport("shell32.dll",EntryPoint="ShellExecuteA", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int ShellExecute(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
		
		[DllImport("user32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern long GetWindowRect(long hwnd, System.Drawing.Rectangle lpRect);
	}
	
}
