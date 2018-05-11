using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCore;
using BZappdll;
namespace BZGUI
{
    public partial class FrmIPDMManual : Form
    {
        #region 变量定义


        #endregion

        #region 窗体操作

        public FrmIPDMManual()
        {
            InitializeComponent();
        }

        private void FrmIPDMManual_Load(object sender, EventArgs e)
        {
            this.teach1.Timer.Enabled = true;
        }

        #endregion

        private void FrmIPDMManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.teach1.Timer.Enabled = false;
        }

 

        #region 按钮操作
        private void btn_CCD_Click(object sender, EventArgs e)
        {
            XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskStart(StationRunMode.CCD触发);
        }

        #endregion

        private void Btn_Scanner_Click(object sender, EventArgs e)
        {
            XTaskManager.Instance.FindTaskById((int)TasksId.测试).TaskStart(StationRunMode.条码枪触发);
        }

        #region 其他


        #endregion


    }
}
