using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.PowerPacks;

namespace BZGUI
{
    public partial class ParaAxis : UserControl
    {
        public ParaAxis()
        {
            InitializeComponent();
            DataGridView_par.RowCount = BVar.AxisNum;
        }
        

        private void ParaAxis_SizeChanged(object sender, EventArgs e)
        {
            //this.MaximumSize = this.Size;
            //this.MinimumSize = this.Size;
        }

        private void ParaAxis_Load(object sender, EventArgs e)
        {
            ParaAxisFile.Instance.ReadParAxis(PVar.ParAxisPath, PVar.ParAxis);//读取机械参数
            ParaAxisFile.Instance.FresshMachinePar();//把1维参数转换成2维的机械参数
            LoadParAxis();
        }

        private void Button62_Click(object sender, EventArgs e)
        {
            if (Button62.BackColor == Color.Red)
            {
                DataGridView_par.ReadOnly = true;
                Button62.BackColor = Color.SpringGreen;
            }
            else
            {
                DataGridView_par.ReadOnly = false;
                Button62.BackColor = Color.Red;
            }
        }

        private void Button61_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("确认保存吗？", (int)Constants.vbInformation + Constants.vbOKCancel, "提示") == Constants.vbOK)
            {
                for (var i = 0; i <= DataGridView_par.RowCount - 1; i++)
                {
                    PVar.ParAxis.Lead[i + 1] = System.Convert.ToDouble(DataGridView_par[1, i].Value);     //丝杠导程
                    PVar.ParAxis.Ratio[i + 1] = System.Convert.ToDouble(DataGridView_par[2, i].Value);    //减速比
                    PVar.ParAxis.pulse[i + 1] = System.Convert.ToDouble(DataGridView_par[3, i].Value);    //每转脉冲
                    PVar.ParAxis.Speed[i + 1] = System.Convert.ToDouble(DataGridView_par[4, i].Value);    //轴速度
                    if (PVar.ParAxis.Speed[i + 1] > 400)
                    {
                        MessageBox.Show(DataGridView_par[0, i].Value + "[" + System.Convert.ToString(PVar.ParAxis.Speed[i + 1]) + "]" + "轴速度设置大于[400]！");
                        ParaAxisFile.Instance.ReadParAxis(PVar.ParAxisPath, PVar.ParAxis);
                        for (var j = 0; j <= DataGridView_par.RowCount - 1; j++)
                        {
                            DataGridView_par[4, i].Value = PVar.ParAxis.Speed[i + 1];
                        }

                        return;
                    }
                }
                ParaAxisFile.Instance.WriteParAxis(PVar.ParAxisPath, PVar.ParAxis);
                ParaAxisFile.Instance.FresshMachinePar();
                DataGridView_par.ReadOnly = true;
                Button62.BackColor = Color.SpringGreen;
                MessageBox.Show("    保存OK！");
            }
        }

        /// <summary>
        /// 加载工程界面各轴参数
        /// </summary>
        /// <remarks></remarks>
        private void LoadParAxis()
        {
            for (var i = 0; i < BVar.AxisNum; i++)
            {
                DataGridView_par[0, i].Value = BVar.Axisname[(int)i];//轴号
                DataGridView_par[1, i].Value = PVar.ParAxis.Lead[i + 1];//丝杠导程
                DataGridView_par[2, i].Value = PVar.ParAxis.Ratio[i + 1];//减速比
                DataGridView_par[3, i].Value = PVar.ParAxis.pulse[i + 1];//每转脉冲
                DataGridView_par[4, i].Value = PVar.ParAxis.Speed[i + 1];//轴速度
            }
            for (int i = 0; i < 5; i++)
            {
                DataGridView_par.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; //设定每一列的排序类型为不排序
            }
        }


    }
}
