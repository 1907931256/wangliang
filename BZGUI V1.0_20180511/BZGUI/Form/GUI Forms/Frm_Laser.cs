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
    public partial class Frm_Laser : Form
    {
        public static Frm_Laser fPar_Laser = new Frm_Laser();  
        public Frm_Laser()
        {
            InitializeComponent();
        }

        private void Frm_Laser_Load(object sender, EventArgs e)
        {
            this.Location = PVar.ChildFrmOffsetPoint;
            this.Size = new Size(1020, 660);
            this.BackColor = Frm_Main.MainColor;
        }
    }
}
