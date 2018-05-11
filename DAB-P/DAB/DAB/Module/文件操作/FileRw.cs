
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
using System.Xml;
using System.Xml.Serialization;
using System.Data.OleDb;
using VB = Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;


namespace DAB
{
	sealed class FileRw
	{
		private static object WriteDattxt_L = new object();
		static int WriteExcel_k = 0;


#region 读写配置参数

        public static void ReadParData(string FileName, System.ValueType ReadData)
            {
            int Filenumber = 0;
            try
                {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FileGet(Filenumber, ref ReadData);
                PVar.ParList = (PVar.mPar)ReadData;
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
                PVar.IsReadParData = true;
                }
            catch (Exception)
                {
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
                PVar.IsReadParData = false;
                }
            }


        public static void WriteParData(string FileName, System.ValueType WriteData)
            {
            int Filenumber = 0;
            try
                {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FilePut(Filenumber, WriteData);
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
                }
            catch
                {
                FileSystem.FileClose(Filenumber); //写入出错关闭当前打开的文件
                }
            }
#endregion
		
#region 功能：TXT文件写入
		public static void WriteDattxt(string Filename, string WriteData)
		{
			lock(WriteDattxt_L)
			{
				try
				{
					System.IO.StreamWriter rs = new System.IO.StreamWriter(Filename, true);
					rs.WriteLine(WriteData);
					rs.Flush();
					rs.Close();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("文件写入失败" + ex.Message, (int) MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误");
				}
			}
		}
#endregion
		
#region 功能：TXT文件读取
		public static dynamic ReadDattxt(string Filename)
		{
			string readdata = "";
			string readline = "";
			System.IO.StreamReader rs = new System.IO.StreamReader(Filename, true);
			try
			{
				do
				{
					readline = rs.ReadLine();
					readdata = readdata + readline;
				} while (!(rs.EndOfStream == true));
				return readdata;
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("文件读取失败：" + ex.Message, (int) MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误");
				return "";
			}
		}
#endregion
		
#region 加载月良率数据
        public static void WriteYieldFile(string Filename, PVar.YieldOfMonthData WriteData)
            {
            int Filenumber = 0;
            try
                {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, Filename, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FilePut(Filenumber, WriteData);
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
                }
            catch (Exception ex)
                {
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
                Interaction.MsgBox("文件写入失败" + ex.Message, (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误");
                }
            }

        public static void ReadYieldFile(string Filename, System.ValueType ReadData)
		{
			int Filenumber = 0;			
			try
			{
            PVar.YieldOfMonth.NgCount = new int[30];
            PVar.YieldOfMonth.ProductCount = new int[30];
            PVar.YieldOfMonth.RecordTime = new DateTime[30];
				
				if (System.IO.File.Exists(Filename) == false)
				{
					for (var i = 0; i <= 29; i++)
					{
						PVar.YieldOfMonth.NgCount[(int) i] = 0;
						PVar.YieldOfMonth.ProductCount[(int) i] = 1;
						PVar.YieldOfMonth.RecordTime[(int) i] = DateTime.Now;
					}
					WriteYieldFile(Filename, PVar.YieldOfMonth);
				}

                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, Filename, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FileGet(Filenumber, ref ReadData);
                PVar.YieldOfMonth = (PVar.YieldOfMonthData)ReadData;
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("文件读取失败：" + ex.Message, (int) MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误");
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
			}
		}
		
#endregion		
		
#region 功能：读取用户信息
		
		public static void WriteDatFilePassWord(string Filename, PVar.sPassWord WriteData)
		{
        int Filenumber = 0;
        try
            {
            Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
            FileSystem.FileOpen(Filenumber, Filename, OpenMode.Binary); //以二进制的形式打开文件
            //long lens = FileSystem.LOF(Filenumber);
            FileSystem.FilePut(Filenumber, WriteData);
            FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
        catch (Exception ex)
            {
            Interaction.MsgBox("文件写入失败" + ex.Message, (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误");
            FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
		}
#endregion
		
#region 功能：读取二进制文件
        public static void ReadDatFilePassWord(string Filename, System.ValueType ReadData)
		{
        int Filenumber = 0;
        try
            {
            Filenumber =  FileSystem.FreeFile(); //获取空闲可用的文件号
            FileSystem.FileOpen(Filenumber, Filename, OpenMode.Binary); //以二进制的形式打开文件
            FileSystem.FileGet(Filenumber, ref ReadData); 
            PVar.Login = (PVar.sPassWord)ReadData;
            FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
        catch (Exception ex)
            {
            Interaction.MsgBox("密码文件读取失败：" + ex.Message, (int)MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "错误");
            FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
            }
        }
#endregion
		
#region 功能：INI文件写入
		public static void IniWriteValue(string iniFile, string section, string key, string value)
		{
			API.WritePrivateProfileString(section, key, value, iniFile +".ini");
		}
#endregion
		
#region 功能：INI文件读
		public static string IniGetStringValue(string iniFile, string section, string key, string defaultValue)
		{
			string value = "";
			const int SIZE = 1024 * 10;
			int rtn = 0;
			System.Text.StringBuilder sb = new System.Text.StringBuilder(SIZE);
			value = defaultValue;
			rtn = System.Convert.ToInt32(API.GetPrivateProfileString(section, key, defaultValue, sb, SIZE, iniFile +".ini"));
			if (rtn != 0)
			{
				value = sb.ToString();
			}
			return value;
		}
		public static double IniGetNValue(string iniFile, string section, string key, double defaultValue)
		{
			string value = "";
			const int SIZE = 1024 * 10;
			int rtn = 0;
			System.Text.StringBuilder sb = new System.Text.StringBuilder(SIZE);
			value = System.Convert.ToString(defaultValue);
			rtn = System.Convert.ToInt32(API.GetPrivateProfileString(section, key, System.Convert.ToString(defaultValue), sb, SIZE, iniFile +".ini"));
			if (rtn != 0)
			{
				value = sb.ToString();
			}
			return double.Parse( value);
		}
#endregion
		
#region 功能：删除INI Section
		public static void DelIniSec(string iniFile, string SectionName) //清除section
		{
			int retval;
			retval = System.Convert.ToInt32(API.WritePrivateProfileString(SectionName, null, "", iniFile));
		}
#endregion
		
#region 功能：连接数据库
		public static dynamic DataBaseConn(string strPathFileFolder)
		{
			try
			{
				string str = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + strPathFileFolder + "; Jet OLEDB:database Password=430923198212312912;";
				//Dim str As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & strPathFileFolder & "; Jet OLEDB:database Password=123456;"
				PVar.Conn = new OleDbConnection(str);
				PVar.Conn.Open();
				return "OK";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ex;
			}
		}
#endregion
		
#region 功能：将数据库内容读取到DataGrid中
		public static dynamic DataBaseRead(DataGridView FormDataGridViewName, string DataBaseName)
		{
			try
			{
				string strsql = string.Format("select * from " + DataBaseName + " order by 1");
				PVar.CmdView = new OleDbCommand(strsql, PVar.Conn);
				PVar.CmdView.ExecuteNonQuery();
				var da = new OleDbDataAdapter(strsql, PVar.Conn);
				DataSet ds = new DataSet();
				da.Fill(ds);
				//If IsOpenFrmEngineering = True Then
				FormDataGridViewName.DataSource = ds.Tables[0];
				//End If
				//For i = 0 To 3
				//    AxisMachine(i + 1).dpulse = ds.Tables(0).Rows(i)("每转脉冲数")
				//    AxisMachine(i + 1).dLead = ds.Tables(0).Rows(i)("丝杆导程")
				//    AxisMachine(i + 1).duRatio = ds.Tables(0).Rows(i)("传动比")
				//    AxisMachine(i + 1).dAccRate = ds.Tables(0).Rows(i)("加速度")
				
				//    AxisMachine(i + 1).dDecRate = ds.Tables(0).Rows(i)("减速度")
				//    AxisMachine(i + 1).dMoveSpeed = ds.Tables(0).Rows(i)("单轴移动速度")
				//    AxisMachine(i + 1).dHomeSpeed = ds.Tables(0).Rows(i)("回零速度")
				//    AxisMachine(i + 1).dHomeOffset = ds.Tables(0).Rows(i)("原点偏移量")
				
				//    AxisMachine(i + 1).lHomeDirNeg = ds.Tables(0).Rows(i)("回零方向")
				//    AxisMachine(i + 1).lStop0Active = ds.Tables(0).Rows(i)("原点有效电平")
				//    AxisMachine(i + 1).lSearchRange = ds.Tables(0).Rows(i)("原点搜索范围")
				//    AxisMachine(i + 1).lLimitRange = ds.Tables(0).Rows(i)("限位到原点的距离")
				//    AxisMachine(i + 1).lBackRange = ds.Tables(0).Rows(i)("反向移动距离")
				//Next i
				return "OK";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ex;
			}
		}
#endregion
		
#region 功能：将DataGrid内容写到数据库中
		public static dynamic DataBaseWrite(DataGridView FormDataGridViewName, string DataBaseName)
		{
			UInt16 i = 0;
			try
			{
				string strsql = string.Format("select * from " + DataBaseName + " order by 1");
				OleDbCommand cmdView = new OleDbCommand(strsql, PVar.Conn);
				cmdView.ExecuteNonQuery();
				var da = new OleDbDataAdapter(strsql, PVar.Conn);
				OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
				da.UpdateCommand = cb.GetUpdateCommand();
				DataSet ds = new DataSet();
				da.Fill(ds);
				for (i = 0; i <= 3; i++)
				{
					ds.Tables[0].Rows[i]["序号"] = FormDataGridViewName[0, i].Value;
                    ds.Tables[0].Rows[i]["卡号"] = FormDataGridViewName[1, i].Value;
                    ds.Tables[0].Rows[i]["轴号"] = FormDataGridViewName[2, i].Value;
                    ds.Tables[0].Rows[i]["轴名称"] = FormDataGridViewName[3, i].Value;
                    ds.Tables[0].Rows[i]["每转脉冲数"] = FormDataGridViewName[4, i].Value;
                    ds.Tables[0].Rows[i]["丝杆导程"] = FormDataGridViewName[5, i].Value;

                    ds.Tables[0].Rows[i]["传动比"] = FormDataGridViewName[6, i].Value;
                    ds.Tables[0].Rows[i]["加速度"] = FormDataGridViewName[7, i].Value;

                    ds.Tables[0].Rows[i]["减速度"] = FormDataGridViewName[8, i].Value;
                    ds.Tables[0].Rows[i]["单轴移动速度"] = FormDataGridViewName[9, i].Value;
                    ds.Tables[0].Rows[i]["回零速度"] = FormDataGridViewName[10, i].Value;

                    ds.Tables[0].Rows[i]["原点偏移量"] = FormDataGridViewName[11, i].Value;
                    ds.Tables[0].Rows[i]["回零方向"] = FormDataGridViewName[12, i].Value;
                    ds.Tables[0].Rows[i]["原点有效电平"] = FormDataGridViewName[13, i].Value;

                    ds.Tables[0].Rows[i]["原点搜索范围"] = FormDataGridViewName[14, i].Value;
                    ds.Tables[0].Rows[i]["限位到原点的距离"] = FormDataGridViewName[15, i].Value;
                    ds.Tables[0].Rows[i]["反向移动距离"] = FormDataGridViewName[16, i].Value;
				}
				da.Update(ds);
				return "OK";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return ex;
			}
		}
#endregion
		
#region 功能：从数据库中读取数据
		public static dynamic GetSql(string Sheet, string ParItem, string DefaultValue, string ParVaLue)
		{
			string ReturnValue = "";
			try
			{
				string strsql = "Select " + ParVaLue + "  from " + Sheet + " where Name=" + "\'" + ParItem + "\'";
				PVar.CmdView = new OleDbCommand(strsql, PVar.Conn);
				PVar.Dr = PVar.CmdView.ExecuteReader();
				if (PVar.Dr.Read() == true)
				{
					ReturnValue = System.Convert.ToString(PVar.Dr[ParVaLue]);
				}
				else
				{
					ReturnValue = DefaultValue;
					strsql = "insert into " + Sheet + " (Name," + ParVaLue + ") values(\'" + ParItem + "\',\'" + DefaultValue + "\')";
					PVar.CmdView = new OleDbCommand(strsql, PVar.Conn);
					PVar.CmdView.ExecuteNonQuery();
				}
				return ReturnValue;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return "";
			}
		}
#endregion
		
#region 功能：向数据库中写入数据
		public static void SetSql(string Sheet, string ParItem, string Pvalue)
		{
			try
			{
				string StrSql = "update [" + Sheet + " ] set [ParValue]=\'" + Pvalue + "\' where [Name]=\'" + ParItem + "\'";
				PVar.CmdView = new OleDbCommand(StrSql, PVar.Conn);
				PVar.CmdView.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
#endregion
		
#region 功能：从数据库中筛选数据
		public static dynamic SelectSql(string DataBaseName)
		{
			//Try
			//    Dim strsql As String = String.Format("select * from " & DataBaseName & " where [Name] > " & BeforeDate & " and  [Name] <= " & CurrentDate & " order by [Name] desc")
			//    CmdView = New OleDbCommand(strsql, Conn)
			//    CmdView.ExecuteNonQuery()
			//    Dim da = New OleDbDataAdapter(strsql, Conn)
			//    Dim ds As New DataSet
			//    da.Fill(ds)
			//    Frm_Engineering.DataGrid_CheckData.DataSource = ds.Tables(0)
			return Constants.vbNull;
			//Catch ex As Exception
			//    MessageBox.Show(ex.Message)
			//    Return ex
			//End Try
		}
#endregion
		
#region 功能：删除表格数据
		public static void DataBaseDelete()
		{
			string ReturnValue;
			try
			{
				string strsql = "delete ([X]) from [Database001] Where [ID]<=" + System.Convert.ToString(10);
				PVar.CmdView = new OleDbCommand(strsql, PVar.Conn);
				PVar.Dr = PVar.CmdView.ExecuteReader();
				if (PVar.Dr.Read() == true)
				{
					ReturnValue = System.Convert.ToString(PVar.Dr[0]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
#endregion
		
#region XML创建文件
		public static void CreatXml(string XmlFileName)
		{
			try
			{
				System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(XmlFileName, System.Text.Encoding.GetEncoding("utf-8"));
				writer.Formatting = System.Xml.Formatting.Indented;
				writer.WriteRaw("<System Parameter Save>");
				writer.WriteStartElement("Config");
				//writer.WriteEndElement()
				writer.WriteFullEndElement();
				writer.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
			}
		}
#endregion
		
#region XML文件写
		public static void WriteXml(string XmlFileName, System.ValueType WriteData)
		{
			try
			{
                //if (Dir(XmlFileName, Constants.vbDirectory) == "")
                //{
                //    MkDir(XmlFileName);
                //}
				System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(System.ValueType));
				System.IO.StreamWriter file = new System.IO.StreamWriter(XmlFileName);
				writer.Serialize(file, WriteData);
				file.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
			}
		}
#endregion
		
#region XML文件读
		public static void ReadXml(string XmlFileName, ref System.ValueType ReadData)
		{
			try
			{
                //if (Dir(XmlFileName, Constants.vbDirectory) == "")
                //{
                //    MkDir(XmlFileName);
                //}
				System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(System.ValueType));
				System.IO.StreamReader file = new System.IO.StreamReader(XmlFileName);
				ReadData = (System.ValueType) (reader.Deserialize(file));
				file.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
			}
			
		}
#endregion
		
#region 窗体加载判断
		public static bool IsNotShow(string FrmName)
		{
			if (Application.OpenForms[FrmName] == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
#endregion
		
#region 直方图
		public static void Chart_Histogram(Chart ChartName, string XAxisName, string YAxisName, string[] XAxisData, double[] YAxisData, double XAxisLabAgle)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("X轴");
			dt.Columns.Add("Y轴");
			DataRow dr = default(DataRow);
			for (int i = 1; i <= 8; i++)
			{
				dr = dt.NewRow();
				dr[0] = XAxisData[i - 1];
				VBMath.Randomize();
				dr[1] = YAxisData[i];
				dt.Rows.Add(dr);
			}
			dr = null;
			Chart with_1 = ChartName;
			with_1.DataSource = dt; //dt作为Chart的数据源
			with_1.Series.Clear();
			with_1.Legends.Clear();
			with_1.ChartAreas.Clear();
			with_1.ChartAreas.Add("Y轴");
			with_1.Legends.Add("Y轴");
			with_1.Series.Add("Y轴");
			ChartName.Series["Y轴"].LegendToolTip = "Y轴图例";
			ChartName.ChartAreas["Y轴"].AxisX.Title = XAxisName; //添加AxisX Titles
			ChartName.ChartAreas["Y轴"].AxisY.Title = YAxisName; //添加AxisY Titles
			ChartName.Series["Y轴"].IsValueShownAsLabel = true; //标签显示数据值
			ChartName.Legends["Y轴"].DockedToChartArea = "Y轴"; //指定Legend所属ChartArea
			ChartName.ChartAreas["Y轴"].Area3DStyle.Enable3D = false; //启用3D样式
			ChartName.ChartAreas["Y轴"].AxisX.LineColor = System.Drawing.Color.LightGray; //设置轴的线条颜色
			ChartName.ChartAreas["Y轴"].AxisY.LineColor = System.Drawing.Color.LightGray; //设置轴的线条颜色
			ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray; //设置网格线颜色
			ChartName.ChartAreas["Y轴"].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray; //设置网格线颜色
			ChartName.ChartAreas["Y轴"].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartName.ChartAreas["Y轴"].AxisX.LabelStyle.Angle = (int)XAxisLabAgle; //X轴标题倾斜角度
			ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.Interval = 1; //设置X轴间隔距离
            ChartName.ChartAreas["Y轴"].AxisY.IsLabelAutoFit = true; //设置是否自动调整轴标签
            //ChartName.ChartAreas["Y轴"].AxisY.IsStartedFromZero = False          '设置是否自动将数据值均为正值时轴的最小值设置为0，存在负数据值时，将使用数据轴最小值
			ChartName.Legends["Y轴"].Enabled = false;

            ChartName.Series[0].YValueMembers = "Y轴";
            ChartName.Series[0].XValueMember = "X轴";
            ChartName.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
			ChartName.DataBind();
		}
#endregion
		
#region 曲线图
		public static void Chart_Curve(Chart ChartName, string TitleName, string XAxisName, string YAxisName, string SelectMode, string[] XAxisData, double[] YAxisData, double XAxisLabAgle, double MaxValue, double MinValue, bool IsDisplayLine)
		{
        Frm_RunInfo FrmRunInfo = new Frm_RunInfo();
			long i = 0;
			long Temp = 0;
			DataTable dt = new DataTable();
			dt.Columns.Add("X轴");
			dt.Columns.Add("Y轴");
			DataRow dr = default(DataRow);
			if (ChartName.Name == "Chart_HOUSING")
			{
				if (IniGetNValue(PVar.UIChartCurveName, "CurveData", "TotalNum", 0) == 49)
				{
					Temp = 49;
				}
				else
				{
					Temp = (long) (IniGetNValue(PVar.UIChartCurveName, "CurveData", "CurrentNum", 0));
				}
				if (Temp > 0)
				{
					for (i = 0; i <= Temp; i++)
					{
						dr = dt.NewRow();
						dr[0] = (i + 1).ToString(); //X轴
						dr[1] = YAxisData[i]; //Y轴
						dt.Rows.Add(dr);
					}
					dr = null;
				}
			}
			else
			{
				if (ChartName.Name == "Chart_YieldOverview")
				{
                Temp = FrmRunInfo.TrackBar_yeild.Value;
				}
				if (ChartName.Name == "Chart_Tossing")
				{
                Temp = FrmRunInfo.TrackBar_tossing.Value;
					
				}
				if (ChartName.Name == "Chart_UPH")
				{
                Temp = FrmRunInfo.TrackBar_uph.Value;
				}
				for (i = 0; i <= Temp - 1; i++)
				{
					dr = dt.NewRow();
					dr[0] = XAxisData[i]; //X轴
					dr[1] = YAxisData[i]; //Y轴
					dt.Rows.Add(dr);
				}
				dr = null;
			}
			Chart with_1 = ChartName;
			ChartName.DataSource = dt; //dt作为chart的数据源
			ChartName.Series.Clear();
			ChartName.Legends.Clear();
			ChartName.ChartAreas.Clear();
			ChartName.Titles.Clear();
			ChartName.Titles.Add(TitleName);
			ChartName.ChartAreas.Add("Y轴");
			ChartName.Series.Add("Y轴");
			ChartName.Series.Add("X轴");
			ChartName.Series["Y轴"].LegendToolTip = "Y轴图例";
			ChartName.ChartAreas["Y轴"].AxisX.Title = XAxisName; //添加AxisX Titles
			ChartName.ChartAreas["Y轴"].AxisY.Title = YAxisName; //添加AxisY Titles
			if (ChartName.Name != "Chart_HOUSING")
			{
				ChartName.Series["Y轴"].IsValueShownAsLabel = true; //标签显示数据值
			}
			ChartName.ChartAreas["Y轴"].Area3DStyle.Enable3D = false; //启用3D样式
			ChartName.BackSecondaryColor = System.Drawing.Color.Yellow; //设置背景的辅助颜色
			ChartName.BorderlineColor = System.Drawing.Color.Yellow; //设置图像边框的颜色
			ChartName.BorderlineWidth = 1; //设置图像的边框宽度
			ChartName.ChartAreas["Y轴"].AxisX.LineColor = System.Drawing.Color.LightGray; //设置轴的线条颜色
			ChartName.ChartAreas["Y轴"].AxisY.LineColor = System.Drawing.Color.LightGray; //设置轴的线条颜色
			ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray; //设置网格线颜色
			ChartName.ChartAreas["Y轴"].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray; //设置网格线颜色
			ChartName.ChartAreas["Y轴"].AxisY.IsLabelAutoFit = true; //设置是否自动调整轴标签
			ChartName.ChartAreas["Y轴"].BackColor = Color.FromArgb(255, 255, 255);
			ChartName.BackColor = Color.FromArgb(238, 238, 238);
			if (ChartName.Name == "Chart_HOUSING")
			{
				ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.Interval = 1; //设置X轴间隔距离
				ChartName.ChartAreas["Y轴"].AxisY.IsStartedFromZero = false; //设置是否自动将数据值均为正值时轴的最小值设置为0，存在负数据值时，将使用数据轴最小值
			}
			else
			{
				ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.Interval = 1; //设置X轴间隔距离
			}
			ChartName.ChartAreas["Y轴"].AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number; ////设置刻度线的间隔的度量单位
			ChartName.ChartAreas["Y轴"].AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number; ////设置刻度线的间隔的度量单位
			ChartName.ChartAreas["Y轴"].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartName.ChartAreas["Y轴"].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			ChartName.ChartAreas["Y轴"].AxisX.MajorTickMark.Interval = 1;
			if (ChartName.Name == "Chart_HOUSING")
			{
				ChartName.ChartAreas["Y轴"].AxisY.MajorTickMark.Interval = 0.01; //设置刻度线的间隔
				ChartName.ChartAreas["Y轴"].AxisY.Maximum = double.Parse(Strings.Format(MaxValue, "0.00")) + 0.1;
				ChartName.ChartAreas["Y轴"].AxisY.Minimum = double.Parse(Strings.Format(MinValue, "0.00")) - 0.1;
			}
			else
			{
				ChartName.ChartAreas["Y轴"].AxisY.MajorTickMark.Interval = 1; //设置刻度线的间隔
			}
            ChartName.ChartAreas["Y轴"].AxisX.LabelStyle.Angle = (int)XAxisLabAgle; //X轴标题倾斜角度

            ChartName.Series[0].YValueMembers = "Y轴";
            ChartName.Series[0].XValueMember = "X轴";
			if (ChartName.Name == "Chart_HOUSING")
			{
            ChartName.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			}
			else if (ChartName.Name == "Chart_UPH")
			{
            ChartName.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
			}
			else
			{
            ChartName.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			}
            ChartName.Series[0].Color = Color.Blue;
			if (ChartName.Name != "Chart_UPH")
			{

            ChartName.Series[1].YValueMembers = "Y轴";
            ChartName.Series[1].XValueMember = "X轴";
            ChartName.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            ChartName.Series[1].Color = Color.Gold;
			}
			if (IsDisplayLine)
			{
				System.Windows.Forms.DataVisualization.Charting.StripLine S1 = default(System.Windows.Forms.DataVisualization.Charting.StripLine);
				System.Windows.Forms.DataVisualization.Charting.StripLine S2 = default(System.Windows.Forms.DataVisualization.Charting.StripLine);
				System.Windows.Forms.DataVisualization.Charting.StripLine S3 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
				S1.BorderColor = Color.Red;
				S1.IntervalOffset = double.Parse(Strings.Format(MinValue, "0.00"));
				S2.BorderColor = Color.Red;
				S2.IntervalOffset = double.Parse(Strings.Format(MaxValue, "0.00"));
				S3.BorderColor = Color.Green;
				S3.IntervalOffset = double.Parse(Strings.Format((MaxValue + MinValue) / 2, "0.00"));
				ChartName.ChartAreas["Y轴"].AxisY.StripLines.Add(S1);
				ChartName.ChartAreas["Y轴"].AxisY.StripLines.Add(S2);
				ChartName.ChartAreas["Y轴"].AxisY.StripLines.Add(S3);
			}
			ChartName.DataBind();
		}
#endregion


        public static void WriteExcel()
            {
            int i = 0;
            int j = 0;
            Random rand = new System.Random(10);
            Microsoft.Office.Interop.Excel.Application oXL = default(Microsoft.Office.Interop.Excel.Application);
            Microsoft.Office.Interop.Excel.Workbook oWB = default(Microsoft.Office.Interop.Excel.Workbook);
            Microsoft.Office.Interop.Excel.Worksheet oSheet = default(Microsoft.Office.Interop.Excel.Worksheet);

            try
                {
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = false;
                //oXL.Workbooks.Add()   '添加一个新的Excel文件
                oWB = oXL.Workbooks.Open("E:\\DDtt.xlsx");
                oXL.Sheets.Add();
                WriteExcel_k++; //SN计数器
                oXL.Sheets[1].Name = "测试SN" + System.Convert.ToString(WriteExcel_k);
                oSheet = oWB.Worksheets[oXL.Sheets[1].Name];
                oSheet.Select();
                ((Microsoft.Office.Interop.Excel._Worksheet)oSheet).Activate();

                //循环写入数据
                oWB.Worksheets[1].Select();
                oSheet = oWB.Worksheets[1];
                ((Microsoft.Office.Interop.Excel._Worksheet)oSheet).Activate();
                for (i = 1; i <= 5; i++)
                    {
                    for (j = 1; j <= 5; j++)
                        {

                        oSheet.Cells[i, j].Value = rand.Next(); //随机数字
                        }
                    }
                oWB.Save();
                //oSheet.SaveAs("E:\DDtt.xlsx")
                }
            catch (Exception ex)
                {

                MessageBox.Show(ex.ToString());
                }
            finally
                {
                //oXL.Quit()
                }
            oWB = null;
            oXL = null;

            }
		
	}	
}
