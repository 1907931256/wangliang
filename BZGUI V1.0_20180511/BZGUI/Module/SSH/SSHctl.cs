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
    public partial class SSHctl : UserControl
    {
        public SSHctl()
        {
            InitializeComponent();
            SSH_Thread.Instance.OnSSHInf += Instance_SSHInfoShow;
        }

        private void Instance_SSHInfoShow(string SSHinfo)
        {
            SSHOutput.AppendText(SSHinfo);
            SSHOutput.ScrollToCaret();
            Globals.SSHstring = SSHOutput.Text;
        }

    }
}
