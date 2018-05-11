
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
	sealed class FileLog
	{
		/// <summary>
		/// 设备正常运行Log写入
		/// </summary>
		/// <param name="Msg"></param>
		/// <remarks></remarks>
		public static void WriteLog(string Msg)
		{
			string TempStr = "";
			string TempStr1 = "";
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd");
			if (System.IO.Directory.Exists(TempStr))
			{
				
			}
			else
			{
				System.IO.Directory.CreateDirectory(TempStr);
			}
			
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_运行日志" +".txt";
			TempStr1 = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + " " + Msg;
			FileRw.WriteDattxt(TempStr, TempStr1);
		}
		
		/// <summary>
		/// 记录软件操作
		/// </summary>
		/// <param name="Msg"></param>
		/// <remarks></remarks>
		public static void OperateLog(string Msg)
		{
			string TempStr = "";
			string TempStr1 = "";
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd");
			if (System.IO.Directory.Exists(TempStr))
			{
				
			}
			else
			{
				System.IO.Directory.CreateDirectory(TempStr);
			}
			
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_操作日志" +".txt";
			TempStr1 = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + " " + Msg;
			FileRw.WriteDattxt(TempStr, TempStr1);
		}
		/// <summary>
		/// 设备正常运行Log写入
		/// </summary>
		/// <param name="Msg"></param>
		/// <remarks></remarks>
		public static void WriteMotionLog(string Msg)
		{
			string TempStr = "";
			string TempStr1 = "";
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd");
			if (System.IO.Directory.Exists(TempStr))
			{
				
			}
			else
			{
				System.IO.Directory.CreateDirectory(TempStr);
			}
			
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_马达日志" +".txt";
			TempStr1 = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + " " + Msg;
			FileRw.WriteDattxt(TempStr, TempStr1);
		}
		/// <summary>
		/// 设备异常Log写入
		/// </summary>
		/// <param name="Msg"></param>
		/// <remarks></remarks>
		public static void WriteErrLog(string Msg)
		{
			string TempStr = "";
			string TempStr1 = "";
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd");
			if (System.IO.Directory.Exists(TempStr))
			{
				
			}
			else
			{
				System.IO.Directory.CreateDirectory(TempStr);
			}
			
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_异常日志" +".txt";
			TempStr1 = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + " " + Msg;
			FileRw.WriteDattxt(TempStr, TempStr1);
		}
		
		/// <summary>
		/// 机械手运行日志
		/// </summary>
		/// <param name="Msg"></param>
		/// <remarks></remarks>
		public static void Robot_log(string Msg)
		{
			string TempStr = "";
			string TempStr1 = "";
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd");
			if (System.IO.Directory.Exists(TempStr))
			{
				
			}
			else
			{
				System.IO.Directory.CreateDirectory(TempStr);
			}
			
			TempStr = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_网络日志" +".txt";
			TempStr1 = "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + " " + Msg;
			FileRw.WriteDattxt(TempStr, TempStr1);
		}
	}
	
}
