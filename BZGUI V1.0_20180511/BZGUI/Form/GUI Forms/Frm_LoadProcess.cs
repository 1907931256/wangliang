using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BZGUI
{

    public partial class Frm_LoadProcess
    {
        public static String Ex = "正在加载参数配置文件...    10%";
        public Frm_LoadProcess()
        {
            InitializeComponent();
        }

        private void Frm_LoadProcess_Load(object sender, EventArgs e)
        {
            Frm_Dialog fDialog = new Frm_Dialog();
            //this.TopMost = true;
            this.Visible = false;
            this.Label1.Text = "程序启动加载中，请稍候......";
            this.Label2.Text = "正在加载参数配置文件...    10%";
            Frm_Main.fMain.Show();
            Frm_Main.fMain.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Label2.Text = Ex;
            if (Ex == "加载完成...    100%")
            {
                timer1.Enabled = false;
                this.Hide();
            }
        }

    }
}
