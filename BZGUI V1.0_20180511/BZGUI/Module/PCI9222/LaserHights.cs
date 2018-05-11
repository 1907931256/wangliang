using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZGUI
{
    public partial class LaserHights : UserControl
    {
        private Timer timer;
        public LaserHights()
        {
            InitializeComponent();
            InitialDgv();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            timer.Start();
        }


        private string[] colHead = new string[] { "Name", "Value" };
        private void InitialDgv()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Columns[i].HeaderText = colHead[i];
            }
            dataGridView1.Columns[0].Width = (int)(this.dataGridView1.Width * 0.5);
        }

        private string[] TestName = new string[] { "laser_p0", "laser_p1","laser_p2","laser_p3","laser_p4"};
        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < 5; i++)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.Cells.Add(new DataGridViewTextBoxCell());
                    dr.Cells.Add(new DataGridViewTextBoxCell());
                    dr.Cells[0].Value = TestName[i];
                    dr.Cells[1].Value = DAQ.Instance.LaserHight[i].ToString("f4");
                    dataGridView1.Rows.Add(dr);
                }
            }
            catch
            {

            }

        }


    }
}
