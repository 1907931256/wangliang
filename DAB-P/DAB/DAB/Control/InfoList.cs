using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DAB
    {
    public partial class InfoList : UserControl
        {
        public InfoList()
            {
            InitializeComponent();
            }

        public void List_OnClear()
            {
            try
                {
                this.BeginInvoke(new Action(() =>
                {
                    this.listBox1.Items.Clear();
                }));
                }
            catch
                {

                }
            }

        public void List_OnAdd(string ListStr, short listType = 0)
            {
            try
                {
                this.BeginInvoke(new Action(() =>
                {
                if (this.listBox1.Items.Count == 500)
                    {
                    this.listBox1.Items.Clear();
                    }

                switch (listType)
                    {
                    case 0:
                        this.listBox1.Items.Add("时间：" + DateTime.Now);
                        this.listBox1.Items.Add("◆" + ListStr);
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        break;
                    case 1:
                        this.listBox1.Items.Add("时间：" + DateTime.Now);
                        this.listBox1.Items.Add("◆" + ListStr);
                        this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
                        FileLog.WriteLog(ListStr);
                        break;
                    default:
                        break;
                    }
                
                }));
                }
            catch
                {

                }
            }

        public void List_OnRemove()
            {
            try
                {
                this.BeginInvoke(new Action(() =>
                {
                    if (this.listBox1.Items.Count > 0)
                        {
                        this.listBox1.Items.RemoveAt(0);
                        }

                }));
                }
            catch
                {

                }
            }

        private void InfoList_Load(object sender, EventArgs e)
            {
            this.listBox1.Size = this.Size;
            }

        }
    }
