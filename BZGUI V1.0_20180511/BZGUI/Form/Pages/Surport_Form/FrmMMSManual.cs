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
    public partial class FrmMMSManual : Form
    {
        #region 变量定义


        #endregion

        #region 窗体操作

        public FrmMMSManual()
        {
            InitializeComponent();
        }

        private void FrmMMSManual_Load(object sender, EventArgs e)
        {
            this.teach1.Timer.Enabled = true;
        }

        private void FrmMMSManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.teach1.Timer.Enabled = false;
        }

        #endregion

        #region 按钮操作

        private void btn_LaserCal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定需要校正Laser？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (!XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).HomeOK)
            {
                XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).SetStep("请先回零！！", Mycolor.ErrorRed);
                return;
            }
            XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskStart(StationRunMode.标定Laser);
        }

        private void btn_OutputGRR_Click(object sender, EventArgs e)
        {
            string[,] grr1 = new string[9, 3] { { "1", "2", "3" }, { "2", "2", "3" }, { "3", "2", "3" }, { "4", "2", "3" }, { "5", "2", "3" }, { "6", "2", "3" }, { "7", "2", "3" }, { "8", "2", "3" }, { "9", "2", "3" } };
            BZappdll.ExcelOutHelper ExcelGRR = new ExcelOutHelper(Globals.Dir_Bin + "\\Data\\GRR.xlsx", "D:\\GRR.xlsx", true);
            ExcelGRR.ArrayToExcel(2, grr1, 11, 3);

            ExcelGRR.SaveFile("D:\\GRR.xlsx");
        }

        private void btn_ManualPDCA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定手动上传PDCA测试？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            DataManager.Instance.CurrentCheckData.Mod_Brc_A = 1;
            DataManager.Instance.CurrentCheckData.Mod_Brc_CC = 1;
            DataManager.Instance.CurrentCheckData.SN = "FD3WC35AJCM7";
            //.......
            XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).PDCA_Step = 10;
            XTaskManager.Instance.FindTaskById((int)TasksId.MMS测试).TaskStart(StationRunMode.手动上传PDCA);
        }

        private void btn_Cylinder_Trigger(Bool obj)
        {
            if (Gg.GetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀) == 1)
            {
                Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 0);
                btn_Cylinder.Checked = false;
            }
            else
            {
                Gg.SetDo(0, Gg.OutPutMMS0.产品定位气缸电磁阀, 1);
                btn_Cylinder.Checked = true;
            }
        }


        #endregion

        #region 其他


        #endregion

    }
}
