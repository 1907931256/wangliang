using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BZappdll;

namespace BZGUI
{
    public partial class FrmMMS_Calculate : Form
    {
        List<string[]> lsheight = new List<string[]>();
        List<string[]> lsCurrent = new List<string[]>();
        GraphPane myPane;
        GraphPane myPaneQ;
        GraphPane myPaneAQ;
        GraphPane myPaneCurrent;
        private PointPairList[] listArrayHeight=new PointPairList[3];
        private PointPairList[] listArrayQ = new PointPairList[3];
        private PointPairList[] listArrayAQ = new PointPairList[3];
        private PointPairList[] listArrayCurrent = new PointPairList[2];//for current,mA/V

        public FrmMMS_Calculate()
        {
            InitializeComponent();
        }

        private void FrmMMS_Calculate_Load(object sender, EventArgs e)
        {
            Suface_Equation se = new Suface_Equation();
            se=MMS_algorithm.Instance.Calculating_Coefficient(0.1429,0.1282,0.218);
            Suface_Equation se1 = new Suface_Equation();
            se1.A = 0;
            se1.B = 0;
            se1.C = 1;
            se1.D = 0;
            Suface_Equation se2 = new Suface_Equation();
            se2.A = -1.15385;
            se2.B = 0.692308;
            se2.C = 1;
            se2.D = 2.23077;
            double alfa=MMS_algorithm.Instance.Calculating_dihedral(se,se1);

            this.btn_ShowAQ.Enabled = false;
            this.btn_ShowQ.Enabled = false;
            this.btn_SaveAll.Enabled = false;
            this.btn_Save_Current.Enabled = false;
            lsheight = Globals.csv.ReadCSV(PVar.BZ_ParameterPath + "manual_Test.csv");
            lsCurrent = Globals.csv.ReadCSV(PVar.BZ_ParameterPath + "current_test.csv");
            LoadHeightPane();
            LoadPaneQ();
            LoadPaneAQ();
            LoadPaneCurrent();
        }

        private void btn_Readheigh_Click(object sender, EventArgs e)
        {
            listArrayHeight[0].Clear();
            listArrayHeight[1].Clear();
            listArrayHeight[2].Clear();
            for (int i = 0; i < lsheight.Count - 1; i++)//表头不显示
            {
                listArrayHeight[0].Add(Convert.ToDouble(lsheight[i + 1][0]), Convert.ToDouble(lsheight[i + 1][1]));
                listArrayHeight[1].Add(Convert.ToDouble(lsheight[i + 1][0]), Convert.ToDouble(lsheight[i + 1][2]));
                listArrayHeight[2].Add(Convert.ToDouble(lsheight[i + 1][0]), Convert.ToDouble(lsheight[i + 1][3]));
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
            this.btn_ShowQ.Enabled = true ;
        }

        private void btn_ShowQ_Click(object sender, EventArgs e)
        {
            Suface_Equation se1 = new Suface_Equation();//X=0,A=1
            se1.A = 1; se1.B = 0; se1.C = 0; se1.D = 0;
            Suface_Equation se2 = new Suface_Equation();//Y=0,B=1
            se2.A = 0; se2.B = 1; se2.C = 0; se2.D = 0;
            Suface_Equation se3 = new Suface_Equation();//Z=0,C=1
            se3.A = 0; se3.B = 0; se3.C = 1; se3.D = 0;
            Suface_Equation se = new Suface_Equation();//3个高度的平面方程

            listArrayQ[0].Clear();
            listArrayQ[1].Clear();
            listArrayQ[2].Clear();
            for (int i = 0; i < lsheight.Count - 1; i++)//表头不显示
            {
                se = MMS_algorithm.Instance.Calculating_Coefficient(Convert.ToDouble(lsheight[i + 1][1]), Convert.ToDouble(lsheight[i + 1][2]), Convert.ToDouble(lsheight[i + 1][3]));
                listArrayQ[0].Add(Convert.ToDouble(lsheight[i + 1][0]), MMS_algorithm.Instance.Calculating_dihedral(se,se3));
                listArrayQ[1].Add(Convert.ToDouble(lsheight[i + 1][0]),90- MMS_algorithm.Instance.Calculating_dihedral(se, se2));
                listArrayQ[2].Add(Convert.ToDouble(lsheight[i + 1][0]),90- MMS_algorithm.Instance.Calculating_dihedral(se, se1));
            }
            zedGraphControl2.AxisChange();
            zedGraphControl2.Refresh();
            this.btn_ShowAQ.Enabled = true;
        }

        private void btn_ShowAQ_Click(object sender, EventArgs e)
        {
            listArrayAQ[0].Clear();
            listArrayAQ[1].Clear();
            listArrayAQ[2].Clear();
            for (int i = 0; i < lsheight.Count - 2; i++)//表头不显示, 还有最后一个没有，后一个减去前一个，总体会少一个
            {

                listArrayAQ[0].Add(Convert.ToDouble(lsheight[i + 1][0]), listArrayQ[0][i + 1].Y - listArrayQ[0][i].Y);
                listArrayAQ[1].Add(Convert.ToDouble(lsheight[i + 1][0]), listArrayQ[1][i + 1].Y - listArrayQ[1][i].Y);
                listArrayAQ[2].Add(Convert.ToDouble(lsheight[i + 1][0]), listArrayQ[2][i + 1].Y - listArrayQ[2][i].Y);
            }
            zedGraphControl3.AxisChange();
            zedGraphControl3.Refresh();
            this.btn_SaveAll.Enabled = true;
        }

        List<string[]> ls = new List<string[]>();
        private void btn_SaveAll_Click(object sender, EventArgs e)
        {
            ls.Clear();
            string[] stringheader = new string[] { "Time", "laer_p0", "laer_p1", "laer_p2", "θ Z", "θ Y", "θ X", "θ Z'", "θ Y'", "θ X'" };
            ls.Add(stringheader);
            for (int i = 0; i < lsheight.Count-2; i++)        //最后两组数据不要
            {
                string[] strarr = new string[10];
                strarr[0] = listArrayHeight[0][i].X.ToString();//time
                strarr[1] = listArrayHeight[0][i].Y.ToString();//laser_p0
                strarr[2] = listArrayHeight[1][i].Y.ToString();//laser_p1
                strarr[3] = listArrayHeight[2][i].Y.ToString();//laser_p2
                strarr[4] = listArrayQ[0][i].Y.ToString();//θ Z
                strarr[5] = listArrayQ[1][i].Y.ToString();//θ y
                strarr[6] = listArrayQ[2][i].Y.ToString();//θ x
                strarr[7] = listArrayAQ[0][i].Y.ToString();//θ' Z
                strarr[8] = listArrayAQ[1][i].Y.ToString();//θ' y
                strarr[9] = listArrayAQ[2][i].Y.ToString();//θ' x  可能因为少一个会出错
                ls.Add(strarr);
            }
            string path = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data\\"
                          + DateTime.Now.ToString("yyyyMMdd") + "\\" ;
            if (System.IO.Directory.Exists(path) == false)
                System.IO.Directory.CreateDirectory(path);
            Globals.csv.WriteCSV(path + "SNxxxxxxx_" + DateTime.Now.ToString("HH_mm_ss_fff") + "_raw.csv", ls);

        }

        /// <summary>
        /// Read current
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Curretn_Click(object sender, EventArgs e)
        {
            listArrayCurrent[0].Clear();
            listArrayCurrent[1].Clear();
            for (int i = 0; i < lsCurrent.Count - 16; i++)//前面得16行不需要 表头不显示
            {
                listArrayCurrent[0].Add(Convert.ToDouble(lsCurrent[i + 16][0]), Convert.ToDouble(lsCurrent[i + 16][2]));// PP_12V0 mA
                listArrayCurrent[1].Add(Convert.ToDouble(lsCurrent[i + 16][0]), Convert.ToDouble(lsCurrent[i + 16][3]));// PP_12V0 V
            }
            zedGraphControl4.AxisChange();
            zedGraphControl4.Refresh();

            this.btn_Save_Current.Enabled = true;
        }

        List<string[]> lsC = new List<string[]>();
        /// <summary>
        /// save current
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Current_Click(object sender, EventArgs e)
        {
            lsC.Clear();
            string[] stringheader = new string[] { "Time", " PP_12V0_mA", " PP_12V0_V" };
            lsC.Add(stringheader);
            for (int i = 0; i < lsCurrent.Count - 16; i++)        
            {
                string[] strarr = new string[10];
                strarr[0] = listArrayCurrent[0][i].X.ToString();//time
                strarr[1] = listArrayCurrent[0][i].Y.ToString();//PP_12V0_mA
                strarr[2] = listArrayCurrent[1][i].Y.ToString();//PP_12V0_V
                lsC.Add(strarr);
            }
            string path = PVar.BZ_DataPath + "MMS Data-" + Globals.settingMachineInfo.机器编号 + "\\RAW Displacement Data\\"
                          + DateTime.Now.ToString("yyyyMMdd") + "\\";
            if (System.IO.Directory.Exists(path) == false)
                System.IO.Directory.CreateDirectory(path);
            Globals.csv.WriteCSV(path + "SNxxxxxxx_" + DateTime.Now.ToString("HH_mm_ss_fff") + "_Current_raw.csv", lsC);
        }

        public Bitmap bmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
        public Rectangle eara = Rectangle.Empty;
        private void btn_CopyScreen_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(0, 0, 0, 0, new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));

            Bitmap myPic = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            eara.Width = Screen.AllScreens[0].Bounds.Width;
            eara.Height = Screen.AllScreens[0].Bounds.Height;
            myPic = bmp.Clone(eara, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            myPic.Save("D:\\1122.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("截屏成功！！");
        }

        #region chart_Init
        /// <summary>
        /// 高度
        /// </summary>
        private void LoadHeightPane()
        {
            for (int i = 0; i < listArrayHeight.Length; i++)
            {
                listArrayHeight[i] = new PointPairList();
            }

            myPane = zedGraphControl1.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "高度图";
            myPane.XAxis.Title.Text = "time";
            myPane.YAxis.Title.Text = "distance";
            myPane.YAxis.Scale.MaxAuto = true;
            myPane.XAxis.Scale.MagAuto = true;

            LineItem[] tmp_ai_wave_raw_curve = new LineItem[3];
            tmp_ai_wave_raw_curve[0] = myPane.AddCurve("laer_p0", listArrayHeight[0], Color.FromArgb(197, 145, 68), SymbolType.None);
            tmp_ai_wave_raw_curve[1] = myPane.AddCurve("laer_p1", listArrayHeight[1], Color.FromArgb(153, 162, 69), SymbolType.None);
            tmp_ai_wave_raw_curve[2] = myPane.AddCurve("laer_p2", listArrayHeight[2], Color.FromArgb(91, 174, 108), SymbolType.None);
            tmp_ai_wave_raw_curve[0].Line.Width = 2.0F;//设置线宽
            tmp_ai_wave_raw_curve[1].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[2].Line.Width = 2.0F;

        }
        /// <summary>
        /// 两面角的变化
        /// </summary>
        private void LoadPaneQ()
        {
            for (int i = 0; i < listArrayQ.Length; i++)
            {
                listArrayQ[i] = new PointPairList();
            }

            myPaneQ = zedGraphControl2.GraphPane;

            // Set the titles and axis labels
            myPaneQ.Title.Text = "θ chart";
            myPaneQ.XAxis.Title.Text = "time";
            myPaneQ.YAxis.Title.Text = "distance";
            myPaneQ.YAxis.Scale.MaxAuto = true;
            myPaneQ.XAxis.Scale.MagAuto = true;

            LineItem[] tmp_ai_wave_raw_curve = new LineItem[3];
            tmp_ai_wave_raw_curve[0] = myPaneQ.AddCurve("θ Z", listArrayQ[0], Color.FromArgb(197, 145, 68), SymbolType.None);
            tmp_ai_wave_raw_curve[1] = myPaneQ.AddCurve("θ Y", listArrayQ[1], Color.FromArgb(153, 162, 69), SymbolType.None);
            tmp_ai_wave_raw_curve[2] = myPaneQ.AddCurve("θ X", listArrayQ[2], Color.FromArgb(91, 174, 108), SymbolType.None);
            tmp_ai_wave_raw_curve[0].Line.Width = 2.0F;//设置线宽
            tmp_ai_wave_raw_curve[1].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[2].Line.Width = 2.0F;

        }
        /// <summary>
        /// 两面角度差的变化
        /// </summary>
        private void LoadPaneAQ()
        {
            for (int i = 0; i < listArrayAQ.Length; i++)
            {
                listArrayAQ[i] = new PointPairList();
            }

            myPaneAQ = zedGraphControl3.GraphPane;

            // Set the titles and axis labels
            myPaneAQ.Title.Text = "θ' chart";
            myPaneAQ.XAxis.Title.Text = "time";
            myPaneAQ.YAxis.Title.Text = "distance";
            myPaneAQ.YAxis.Scale.MaxAuto = true;
            myPaneAQ.XAxis.Scale.MagAuto = true;

            LineItem[] tmp_ai_wave_raw_curve = new LineItem[3];
            tmp_ai_wave_raw_curve[0] = myPaneAQ.AddCurve("θ' Z", listArrayAQ[0], Color.FromArgb(197, 145, 68), SymbolType.None);
            tmp_ai_wave_raw_curve[1] = myPaneAQ.AddCurve("θ' Y", listArrayAQ[1], Color.FromArgb(153, 162, 69), SymbolType.None);
            tmp_ai_wave_raw_curve[2] = myPaneAQ.AddCurve("θ' X", listArrayAQ[2], Color.FromArgb(91, 174, 108), SymbolType.None);
            tmp_ai_wave_raw_curve[0].Line.Width = 2.0F;//设置线宽
            tmp_ai_wave_raw_curve[1].Line.Width = 2.0F;
            tmp_ai_wave_raw_curve[2].Line.Width = 2.0F;

        }

        /// <summary>
        /// 电流
        /// </summary>
        private void LoadPaneCurrent()
        {
            for (int i = 0; i < listArrayCurrent.Length; i++)
            {
                listArrayCurrent[i] = new PointPairList();
            }

            myPaneCurrent = zedGraphControl4.GraphPane;

            // Set the titles and axis labels
            myPaneCurrent.Title.Text = "Current chart";
            myPaneCurrent.XAxis.Title.Text = "time";
            myPaneCurrent.YAxis.Title.Text = "Current";
            myPaneCurrent.YAxis.Scale.MaxAuto = true;
            myPaneCurrent.XAxis.Scale.MagAuto = true;

            LineItem[] tmp_ai_wave_raw_curve = new LineItem[2];
            tmp_ai_wave_raw_curve[0] = myPaneCurrent.AddCurve("Current", listArrayCurrent[0], Color.FromArgb(197, 145, 68), SymbolType.None);
            tmp_ai_wave_raw_curve[1] = myPaneCurrent.AddCurve("Voltage", listArrayCurrent[1], Color.FromArgb(153, 162, 69), SymbolType.None);
            tmp_ai_wave_raw_curve[0].Line.Width = 2.0F;//设置线宽
            tmp_ai_wave_raw_curve[1].Line.Width = 2.0F;//设置线宽

        }

        #endregion


    }
}
