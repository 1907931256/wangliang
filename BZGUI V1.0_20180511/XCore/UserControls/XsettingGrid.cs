using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCore
{
    public partial class XSettingGrid : UserControl
    {
        private int id = 1;
        private bool locked = false;

        public XSettingGrid()
        {
            InitializeComponent();
        }
        public bool Locked
        {
            get { return this.locked; }
            set { this.locked = value; }
        }
        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
                this.propertyGrid1.SelectedObject = XSettingManager.Instance.FindSettingById(this.id);
                if (XSettingManager.Instance.FindSettingById(this.id) != null)
                {
                    this.toolStripLabel1.Text = XSettingManager.Instance.FindSettingById(this.id).Name;
                }
            }
        }

        private void btn_keyboard_Click_1(object sender, EventArgs e)
        {
            string strPath = Environment.CurrentDirectory + @"\Tools\Osk.exe";
            System.Diagnostics.Process.Start(strPath);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (locked)
            {
                return;
            }
            if (MessageBox.Show(this, "确认保存[" + XSettingManager.Instance.FindSettingById(this.id).Name + "]？", "询问",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                XSettingManager.Instance.FindSettingById(this.id).SaveSetting();
            }

        }
    }
}
