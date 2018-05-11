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
    public partial class ShowResult : UserControl
    {
        public ShowResult()
        {
            InitializeComponent();
            Task2_组装.EventShowResult += new Action<EnumShowResult>(OnshowResult); ;
        }

        private void OnshowResult(EnumShowResult ESR)
        {
            switch (ESR)
            {
                case EnumShowResult.Empty:
                    Globals.Invoker.SetCtltxt(this.lab_OKNG, "--");
                    Globals.Invoker.SetCtl_FontColor(this.lab_OKNG, Color.Lime);
                    break;
                case EnumShowResult.NG:
                    Globals.Invoker.SetCtltxt(this.lab_OKNG, "NG");
                    Globals.Invoker.SetCtl_FontColor(this.lab_OKNG, Color.Red);
                    break;
                case EnumShowResult.OK:
                    Globals.Invoker.SetCtltxt(this.lab_OKNG, "OK");
                    Globals.Invoker.SetCtl_FontColor(this.lab_OKNG, Color.Lime);
                    break;
            }

        }
    }
}
