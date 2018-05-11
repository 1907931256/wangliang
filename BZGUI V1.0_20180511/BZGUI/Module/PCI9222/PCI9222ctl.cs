using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZedGraph;
using BZappdll;


namespace BZGUI
{
    public partial class PCI9222ctl : UserControl
    {
        GraphPane myPane;
        string[] RawdataFiles;
        int RawdataCount = 0;
        int RawdataTempCount = 1;
        string path = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data\\"
             + DateTime.Now.ToString("yyyyMMdd") + "\\";

        public PCI9222ctl()
        {
            InitializeComponent();
        }

        private void PCI9222ctl_Load(object sender, EventArgs e)
        {
            myPane = zedGraphControl1.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "Chart_Laser";
            myPane.Title.IsVisible = false;
            myPane.XAxis.Title.Text = "time";
            myPane.XAxis.Title.IsVisible = true;
            myPane.XAxis.Title.FontSpec.Size = 8;
            myPane.YAxis.Title.Text = "distance";
            myPane.YAxis.Title.IsVisible = true;
            myPane.YAxis.Title.FontSpec.Size = 8;
            myPane.YAxis.Scale.Max = 5;
            myPane.YAxis.Scale.Min = -5;
            //myPane.YAxis.Scale.MaxAuto = true;
            myPane.XAxis.Scale.MagAuto = true;

            LineItem[] tmp_ai_wave_raw_curve = new LineItem[5];
            tmp_ai_wave_raw_curve[0] = myPane.AddCurve("laser_p0", DAQ.Instance.listArray[0], Color.FromArgb(197,145,68), SymbolType.None);
            tmp_ai_wave_raw_curve[1] = myPane.AddCurve("laser_p1", DAQ.Instance.listArray[1], Color.FromArgb(153, 162, 69), SymbolType.None);
            tmp_ai_wave_raw_curve[2] = myPane.AddCurve("laser_p2", DAQ.Instance.listArray[2], Color.FromArgb(91, 174, 108), SymbolType.None);
            tmp_ai_wave_raw_curve[3] = myPane.AddCurve("laser_p3", DAQ.Instance.listArray[3], Color.FromArgb(90, 165, 204), SymbolType.None);
            tmp_ai_wave_raw_curve[4] = myPane.AddCurve("laser_p4", DAQ.Instance.listArray[4], Color.FromArgb(160, 141, 237), SymbolType.None);
            tmp_ai_wave_raw_curve[0].Line.Width = 2.0F;//设置线宽
            tmp_ai_wave_raw_curve[1].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[2].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[3].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[4].Line.Width = 2.0F;
            this.timer1.Enabled = true;
        }

        private void PCI9222ctl_Paint(object sender, PaintEventArgs e)
        {
            this.Combo_Date.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                this.Combo_Date.Items.Add((DateTime.Now.AddDays(-i)).ToString("yyyyMMdd"));
            }
            this.Combo_Date.SelectedIndex = 0;
            RawdataFiles = Getfiles(path, "*.csv");
            if (RawdataFiles != null)
            {
                RawdataCount = RawdataFiles.Length;
                RawdataTempCount = 1;
                if (RawdataCount > 0)//显示最新的一个，也就是最后一个
                {
                    int pathlength = RawdataFiles[RawdataCount - 1].Split('\\').Length;

                    this.txt_SN.Text = RawdataFiles[RawdataCount - 1].Split('\\')[pathlength - 1].Split('.')[0];
                    show_SN_chart(RawdataFiles[RawdataCount - 1]);
                    this.label_Count.Text = RawdataTempCount + "/" + RawdataCount.ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Globals.Invoker.SetCtltxt(this.label1, DAQ.Instance.listArray[0].Count.ToString());
                // Calculate the Axis Scale Ranges
                zedGraphControl1.AxisChange();
                zedGraphControl1.Refresh();
            }
            catch { }
        }

        private void Save_csv_Click(object sender, EventArgs e)
        {
            ls.Clear();
            string[] stringheader = new string[] { "Time", "laser_p0", "laser_p1", "laser_p2", "laser_p3", "laser_p4" };
            ls.Add(stringheader);
            for (int i = 0; i < DAQ.Instance.listArray[0].Count; i++)
            {
                string[] strarr = new string[6];
                strarr[0] = DAQ.Instance.listArray[0][i].X.ToString();//time
                strarr[1] = DAQ.Instance.listArray[0][i].Y.ToString();//0-Y
                strarr[2] = DAQ.Instance.listArray[1][i].Y.ToString();
                strarr[3] = DAQ.Instance.listArray[2][i].Y.ToString();
                strarr[4] = DAQ.Instance.listArray[3][i].Y.ToString();
                strarr[5] = DAQ.Instance.listArray[4][i].Y.ToString();//5-Y
                ls.Add(strarr);
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "E:\\";
            sfd.Filter = "csv files(*.csv)|*.csv";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            DialogResult dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string str = sfd.FileName;
                string[] pathstr = str.Split('.');
                Globals.csv.WriteCSV(pathstr[0] + ".csv", ls);
            }
        }
        List<string[]> ls = new List<string[]>();
        private void btn_DataBack_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.InitialDirectory = Globals.Dir_Record_Report;
            this.openFileDialog1.InitialDirectory = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\Report Data";
            this.openFileDialog1.Filter = "csv files(*.csv)|*.csv";
            this.openFileDialog1.FilterIndex = 1;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                //show_SN_chart(path);
            }
        }

        private void show_SN_chart(string path)
        {
            try
            {
                ls = Globals.csv.ReadCSV(path);
                DAQ.Instance.listArray[0].Clear();
                DAQ.Instance.listArray[1].Clear();
                DAQ.Instance.listArray[2].Clear();
                DAQ.Instance.listArray[3].Clear();
                DAQ.Instance.listArray[4].Clear();
                for (int i = 0; i < ls.Count - 1; i++)//表头不显示
                {
                    DAQ.Instance.listArray[0].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][1]));
                    DAQ.Instance.listArray[1].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][2]));
                    DAQ.Instance.listArray[2].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][3]));
                    DAQ.Instance.listArray[3].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][4]));
                    DAQ.Instance.listArray[4].Add(Convert.ToDouble(ls[i + 1][0]), Convert.ToDouble(ls[i + 1][5]));
                }
            }
            catch { }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DAQ.Instance.PCI9222Clear();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            DAQ.Instance.PCI9222StartCollect();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            DAQ.Instance.PCI9222StopCollect();
        }


        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (RawdataCount > 0)
            {
                RawdataTempCount++;
                if (RawdataTempCount >= RawdataCount) RawdataTempCount = RawdataCount;
                this.label_Count.Text = RawdataTempCount + "/" + RawdataCount.ToString();
                show_SN_chart(RawdataFiles[RawdataCount - RawdataTempCount]);
                int pathlength = RawdataFiles[RawdataCount - RawdataTempCount].Split('\\').Length;
                this.txt_SN.Text = RawdataFiles[RawdataCount - RawdataTempCount].Split('\\')[pathlength - 1].Split('.')[0];
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (RawdataCount > 0)
            {
                RawdataTempCount--;
                if (RawdataTempCount <= 0) RawdataTempCount = 1;
                this.label_Count.Text = RawdataTempCount + "/" + RawdataCount.ToString();
                show_SN_chart(RawdataFiles[RawdataCount - RawdataTempCount]);
                int pathlength = RawdataFiles[RawdataCount - RawdataTempCount].Split('\\').Length;
                this.txt_SN.Text = RawdataFiles[RawdataCount - RawdataTempCount].Split('\\')[pathlength - 1].Split('.')[0];
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string pathSearch = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data\\"
                                + Combo_Date.Text + "\\";
            string[] searcharr = Getfiles(pathSearch,"*"+ this.txt_SN.Text + "*");
            if (searcharr.Length >= 1)
            {
                show_SN_chart(searcharr[searcharr.Length-1]);//show the latest one
                MessageBox.Show(searcharr[searcharr.Length - 1]);
            }
        }

        private void Combo_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data\\"
                          + Combo_Date.Text + "\\";
            RawdataFiles = Getfiles(path, "*.csv");
            if (RawdataFiles != null)
            {
                RawdataCount = RawdataFiles.Length;
                if (RawdataCount > 0)
                {
                    RawdataTempCount = 1;
                    this.label_Count.Text = RawdataTempCount + "/" + RawdataCount.ToString();
                    show_SN_chart(RawdataFiles[RawdataCount - RawdataTempCount]);
                    int pathlength = RawdataFiles[RawdataCount - RawdataTempCount].Split('\\').Length;
                    this.txt_SN.Text = RawdataFiles[RawdataCount - RawdataTempCount].Split('\\')[pathlength - 1].Split('.')[0];
                }
                else
                {
                    this.label_Count.Text = "0/0";
                    DAQ.Instance.PCI9222Clear();
                    this.txt_SN.Text = "";

                }
            }
        }

        private string[] Getfiles(string path,string typestring)
        {
            //first way
            try
            {
                return Directory.GetFiles(path, typestring);
            }
            catch { return null; }

            ////2nd way
            //DirectoryInfo folder = new DirectoryInfo(path);
            //foreach (FileInfo file in folder.GetFiles(typestring))
            //{
            //    MessageBox.Show(file.FullName);
            //}
        }


    }
}
