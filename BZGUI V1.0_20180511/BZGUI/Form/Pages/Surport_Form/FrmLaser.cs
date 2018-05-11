using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BZGUI
{
    public partial class FrmLaser : Form
    {
        public FrmLaser()
        {
            InitializeComponent();
        }

        private void FrmLaser_Load(object sender, EventArgs e)
        {

        }

        private void FrmLaser_VisibleChanged(object sender, EventArgs e)
        {
            //this.pcI9222ctl1.timer1.Enabled = this.Visible ? true : false;
        }

    }
}
