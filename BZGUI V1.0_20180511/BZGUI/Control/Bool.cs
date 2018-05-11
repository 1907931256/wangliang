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
    public partial class Bool : UserControl
    {
        public event Action ON;
        public event Action OFF;
        public event Action<Bool> Trigger;
        private Color colorON = Color.LimeGreen;
        private Color colorOFF = XCore.Mycolor.None;
        private string ONText = "ON"; private string OFFText = "OFF";
        private bool sts;

        public Bool()
        {
            InitializeComponent();
        }

        private void Bool_Load(object sender, EventArgs e)
        {
            this.button1.Text = this.ONText;
            this.button1.BackColor = colorON;
            Checked = true;
        }

        public bool Locked { get; set; }
        public string ON_Text 
        {
            get { return ONText; }
            set { this.ONText=value;}
        }
        public string OFF_Text
        {
            get { return OFFText; }
            set { this.OFFText = value; }
        }

        public void SetText(string _OnText, string _OFFText)
        {
            this.ONText = _OnText;
            this.OFFText = _OFFText;
        }

        public Color ON_Color
        {
            get { return colorON; }
            set { this.colorON = value; }
        }
        public Color OFF_Color
        {
            get { return colorOFF; }
            set { this.colorOFF = value; }
        }

        public void SetColor(Color colorON, Color colorOFF)
        {
            this.colorON = colorON;
            this.colorOFF = colorOFF;
        }

        public void SetColor(Color color)
        {
            this.button1.BackColor = color;
        }

        public bool Checked
        {
            get { return sts; }
            set
            {
                this.sts = value;
                if (this.sts == true)
                {
                    this.button1.BackColor = colorON;
                    this.button1.Text = ONText;
                    if (ON != null)
                    {
                        ON();
                    }
                }
                else
                {
                    this.button1.BackColor = colorOFF;
                    this.button1.Text = OFFText;
                    if (OFF != null)
                    {
                        OFF();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Locked)
            {
                return;
            }
            if (this.sts == true)
            {
                Checked = false;
            }
            else
            {
                Checked = true;
            }
            if (Trigger != null)
            {
                Trigger(this);
            }
        }

    }
}
