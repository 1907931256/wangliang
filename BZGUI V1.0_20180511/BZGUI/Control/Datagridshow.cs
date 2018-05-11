using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BZGUI.Data;
using BZappdll;
using XCore;


namespace BZGUI
{
    public partial class Datagridshow : UserControl
    {
        //private string[] columnHeads = new string[] {"Date", "Time", "SN", "Result", "X", "Y", "A", "Dis" };
        private int maxcount = 100;
        //private delegate void InvokeHandler();

        public Datagridshow()
        {
            InitializeComponent();
            if (Globals.settingMachineInfo.什么机器 == WhichMachine.MMS)
            {
                InitDataGridView();
            }
            else
            { 
                InitDataGridViewIDPM(); 
            }
            Task1_测试.OnCurrentInf += Instance_OnInfoIPDM;
            Task1_MMS测试.OnCurrentInf += Instance_OnInfo;
        }

        private void InitDataGridView()//表头和实际读出来的列数不一样，要删除原来的，再新建
        {
            if (System.IO.File.Exists(PVar.ListDataIniPath) == false)//写表头
            {
                string strtemp = "";
                for (int i = 0; i < PVar.DataGrid_CheckDataHeadName.Length; i++)
                {
                    strtemp = strtemp + PVar.DataGrid_CheckDataHeadName[i] + ",";
                }
                strtemp = strtemp.Substring(0, strtemp.Length - 1);//去掉最后一个","
                Globals.csv.WriteStringToCsv(PVar.ListDataIniPath, strtemp);
            }
            Globals.dt_100data = Globals.csv.OpenCSV(PVar.ListDataIniPath);
            #region rebuild csv
            if (Globals.dt_100data.Columns.Count != PVar.DataGrid_CheckDataHeadName.Length)
            {
                //delete the old one
                FileRw.DeleteFile(PVar.ListDataIniPath);
                string strtemp = "";
                for (int i = 0; i < PVar.DataGrid_CheckDataHeadName.Length; i++)
                {
                    strtemp = strtemp + PVar.DataGrid_CheckDataHeadName[i] + ",";
                }
                strtemp = strtemp.Substring(0, strtemp.Length - 1);//去掉最后一个","
                Globals.csv.WriteStringToCsv(PVar.ListDataIniPath, strtemp);
                Globals.dt_100data = Globals.csv.OpenCSV(PVar.ListDataIniPath);
            }
            #endregion
            this.dataGridView1.DataSource = Globals.dt_100data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
      
        private void InitDataGridViewIDPM()
        {
            if (System.IO.File.Exists(PVar.ListDataIniPathIPDM) == false)//写表头
            {
                string strtemp = "";
                for (int i = 0; i < PVar.DataGrid_IPDMCheckDataHeadName.Length; i++)
                {
                    strtemp = strtemp + PVar.DataGrid_IPDMCheckDataHeadName[i] + ",";
                }
                strtemp = strtemp.Substring(0, strtemp.Length - 1);//去掉最后一个","
                Globals.csv.WriteStringToCsv(PVar.ListDataIniPathIPDM, strtemp);
            }
            Globals.dt_100data = Globals.csv.OpenCSV(PVar.ListDataIniPathIPDM);
            #region rebuild csv
            if (Globals.dt_100data.Columns.Count != PVar.DataGrid_IPDMCheckDataHeadName.Length)
            {
                //delete the old one
                FileRw.DeleteFile(PVar.ListDataIniPathIPDM);
                string strtemp = "";
                for (int i = 0; i < PVar.DataGrid_IPDMCheckDataHeadName.Length; i++)
                {
                    strtemp = strtemp + PVar.DataGrid_IPDMCheckDataHeadName[i] + ",";
                }
                strtemp = strtemp.Substring(0, strtemp.Length - 1);//去掉最后一个","
                Globals.csv.WriteStringToCsv(PVar.ListDataIniPathIPDM, strtemp);
                Globals.dt_100data = Globals.csv.OpenCSV(PVar.ListDataIniPathIPDM);
            }
            #endregion
            this.dataGridView1.DataSource = Globals.dt_100data;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Instance_OnInfo(CheckData e)
        {
            lock (this)
            {
                try
                {                    
                    this.BeginInvoke(new Action(() =>
                        {
                            DataRow dr = Globals.dt_100data.NewRow();
                            dr[0] = e.StartDate;
                            dr[1] = e.StartTime;
                            dr[2] = e.SN;
                            dr[3] = e.PDCAPASS ? "OK" : "NG";
                            dr[4] = e.Mod_Brc_X;
                            dr[5] = e.Mod_Brc_Y;
                            dr[6] = e.Mod_Brc_A;
                            dr[7] = e.Mod_Brc_CC;
                            Globals.dt_100data.Rows.InsertAt(dr, 0);
                            if (Globals.dt_100data.Rows.Count > maxcount)//有时候跳出100没有，然后变大红×
                            {
                                Globals.dt_100data.Rows.RemoveAt(maxcount);
                            }
                            Globals.csv.SaveCSV(Globals.dt_100data, PVar.ListDataIniPath);
                            //跑久了会出现大红×

                            dgvHighlightRows(1);
                            this.dataGridView1[3, 0].Style.BackColor = (e.PDCAPASS ? Mycolor.White : Mycolor.ErrorRed);//给第一行判断结果，显示颜色

                        }));

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void Instance_OnInfoIPDM(CheckData e)
        {
            lock (this)
            {
                try
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        DataRow dr = Globals.dt_100data.NewRow();
                        dr[0] = e.StartDate;
                        dr[1] = e.StartTime;
                        dr[2] = e.SN;
                        dr[3] = e.PDCAPASS ? "OK" : "NG";
                        dr[4] = e.IPD_Left1;
                        dr[5] = e.IPD_Right1;
                        dr[6] = e.IPD_Left2;
                        dr[7] = e.IPD_Right2;
                        Globals.dt_100data.Rows.InsertAt(dr, 0);
                        if (Globals.dt_100data.Rows.Count > maxcount)//有时候跳出100没有，然后变大红×
                        {
                            Globals.dt_100data.Rows.RemoveAt(maxcount);
                        }
                        Globals.csv.SaveCSV(Globals.dt_100data, PVar.ListDataIniPathIPDM);//退出的时候保存
                        //跑久了会出现大红×

                        dgvHighlightRows(1);
                        this.dataGridView1[3, 0].Style.BackColor = (e.PDCAPASS ? Mycolor.White : Mycolor.ErrorRed);//给第一行判断结果，显示颜色

                    }));

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        //高亮显示某行
        private void dgvHighlightRows(int rowindex)
        {
            try
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[rowindex].Selected = true;
                this.dataGridView1.FirstDisplayedScrollingRowIndex = rowindex;//滚动定位到具体的行
            }
            catch { }
        }
        //跑久了会出现大红×,试一下这个方法
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            try
            { base.OnPaint(e); }
            catch { Invalidate(); }
        }
        //跑久了会出现大红×,试一下这个方法
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("error happened unknowed");
            //this.BeginInvoke(new InvokeHandler(() =>
            //{}));
            
            ////重新绑定，防止出现打红叉
            //this.Invoke(new InvokeHandler(delegate()
            //    {
            //        this.dataGridView1.DataSource = null;
            //        this.dataGridView1.DataSource = Globals.dt_100data;
            //    }));
        }

        
    }
}
