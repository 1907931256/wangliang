
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace DAB
    {
    public partial class Frm_Materiel
        {
        public static Frm_Materiel fMateriel = new Frm_Materiel();
        public Frm_Materiel()
            {
            InitializeComponent();
            fMateriel = this;
            }

        private void Btn_Sure_Click(object sender, EventArgs e)
            {
            this.Close();
            }


        private void Frm_Materiel_Load(object sender, EventArgs e)
            {
            int i = 0;
            int j = 0;
            this.Top = 200;
            this.Left = 450;
            this.Opacity = 0.95;

            //this.Size = new System.Drawing.Size(308, 520);
            //DataGridView1.Size = new System.Drawing.Size(245, 500);
            DataGridView1.RowCount = 5; //行
            DataGridView1.ColumnCount = 2; //列
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.ColumnHeadersVisible = false;


            for (j = 1; j <= DataGridView1.RowCount; j++)
                {
                for (i = 1; i <= DataGridView1.ColumnCount; i++)
                    {
                    DataGridView1[i - 1, j - 1].Value = (j - 1) * DataGridView1.ColumnCount + i;
                    DataGridView1.Rows[j - 1].Height = 60;
                    DataGridView1.Rows[j - 1].DividerHeight = 10;
                    }
                }

            DataGridView1.AllowUserToResizeRows = false;
            DataGridView1.AllowUserToResizeColumns = false;

            i = (int.Parse(BVar.FileRorW.ReadINI("Material_index", "Display", PVar.Tray.MaterialCnt.ToString(), PVar.PublicParPath))) - 1;       
            int n = i / 2;
            int m = i % 2;
            DataGridView1.Rows[n].Cells[m].Selected = true;
            DataGridView1.Rows[0].Cells[0].Style.SelectionBackColor = Color.Aquamarine;
            DataGridView1.Rows[n].Cells[m].Style.SelectionBackColor = Color.Red;
            DataGridView1.Rows[n].Cells[m].Style.SelectionForeColor = Color.Red;
            PVar.IsOpenFrmMateriel = true;
            }


        #region Display
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            short Rowindex = (short)e.RowIndex;
            short ColumnIndex = (short)e.ColumnIndex;
            Frm_Engineering.fEngineering.Txt_PalletNum.Text = System.Convert.ToString(DataGridView1[ColumnIndex, Rowindex].Value);
            Frm_Engineering.fEngineering.Txt_PalletSelectNum.Text = System.Convert.ToString(DataGridView1[ColumnIndex, Rowindex].Value);
            PVar.Tray.MaterialCnt = System.Convert.ToInt32(DataGridView1[ColumnIndex, Rowindex].Value);
            BVar.FileRorW.WriteINI("Material_index", "Display", PVar.Tray.MaterialCnt.ToString(), PVar.PublicParPath);
            this.Close();
            PVar.IsOpenFrmMateriel = false;
            }
        #endregion

        private void Btn_cancel_Click(object sender, EventArgs e)
            {
            this.Close();
            PVar.IsOpenFrmMateriel = false;
            }
        }
    }
