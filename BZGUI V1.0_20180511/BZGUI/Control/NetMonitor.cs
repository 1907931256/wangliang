using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using BZappdll;

namespace BZGUI
{
    public partial class NetMonitor : UserControl
    {
        private Timer timer;
        private bool[] m_netstates;
        private string[] m_IPaddress;
        private string[] m_IPnames;
        private BZappdll.ComSub com = new ComSub();


        public NetMonitor()
        {
            InitializeComponent();
            InitialDgv();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private string[] colHead = new string[] { "", "本地IP", "Name" };
        private void InitialDgv()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns.Add(new DataGridViewImageColumn());
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].HeaderText = colHead[i];
            }
            dataGridView1.Columns[0].Width = 30;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    if (this.IsHandleCreated)
            //        break;
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(10);
            //}
            com.NetGetAllIP(out m_netstates, out m_IPaddress, out m_IPnames);
            //this.BeginInvoke(new Action(() =>
            // {
                 try
                 {
                     dataGridView1.Rows.Clear();
                     for (int i = 0; i < m_netstates.Length; i++)
                     {
                         DataGridViewRow dr = new DataGridViewRow();
                         dr.Cells.Add(new DataGridViewImageCell());
                         dr.Cells.Add(new DataGridViewTextBoxCell());
                         dr.Cells.Add(new DataGridViewTextBoxCell());
                         dr.Cells[0].Value = m_netstates[i] ? Properties.Resources._lampGreen20 : Properties.Resources._lampRed20;
                         dr.Cells[1].Value = m_IPaddress[i];
                         dr.Cells[2].Value = m_IPnames[i];
                         dataGridView1.Rows.Add(dr);
                     }
                 }
                 catch
                 {

                 }
             //}));
        }



    }
}
