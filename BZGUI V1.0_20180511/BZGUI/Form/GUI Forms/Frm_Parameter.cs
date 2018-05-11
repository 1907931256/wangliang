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
    public partial class Frm_Parameter : Form
    {
        public static Frm_Parameter fPar = new Frm_Parameter();
        public Frm_Parameter()
        {
            InitializeComponent();
        }

        private void Frm_Parameter_Load(object sender, EventArgs e)
        {
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.MainColor;
        }
    }
}
