using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;



namespace BZGUI
{

    public partial class OutputClass
    {
        private static object tTime = new object();
        public OutputClass()
        {
            InitializeComponent();
        }

        bool mLoadOK;
        private Label[] Lab_Index;
        private Label[] Name_Index;
        private OvalShape[] Shape_Index;
        private Button[] Button_Index;

        #region 窗体加载
        private void OutputClass_Load(object sender, EventArgs e)
        {
            //Me.Width = 290
            //Me.Height = 538
            Lab_Index = new Label[16] {Lab_Output_0, Lab_Output_1, Lab_Output_2, Lab_Output_3, Lab_Output_4, Lab_Output_5, Lab_Output_6, Lab_Output_7, 
                Lab_Output_8, Lab_Output_9, Lab_Output_10, Lab_Output_11, Lab_Output_12, Lab_Output_13, Lab_Output_14, Lab_Output_15};
            Name_Index = new Label[16] {Name_Index_0, Name_Index_1, Name_Index_2, Name_Index_3, Name_Index_4, Name_Index_5, Name_Index_6, Name_Index_7, 
                Name_Index_8, Name_Index_9, Name_Index_10, Name_Index_11, Name_Index_12, Name_Index_13, Name_Index_14, Name_Index_15};
            Shape_Index = new OvalShape[16] {OvalShape_0, OvalShape_1, OvalShape_2, OvalShape_3, OvalShape_4, OvalShape_5, OvalShape_6, OvalShape_7, 
                OvalShape_8, OvalShape_9, OvalShape_10, OvalShape_11, OvalShape_12, OvalShape_13, OvalShape_14, OvalShape_15};
            Button_Index = new Button[16] {Output_0, Output_1, Output_2, Output_3, Output_4, Output_5, Output_6, Output_7, 
                Output_8, Output_9, Output_10, Output_11, Output_12, Output_13, Output_14, Output_15};
            mLoadOK = true;

            for (int i = 0; i <= 15; i++)
            {
                Lab_Index[i].Text = BVar.FileRorW.ReadINI("Output", this.Tag + "," + System.Convert.ToString(i), "备用", (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Setting.dll");
            }
            int tag;
            tag = Convert.ToInt32(this.Tag);
            switch (tag)
            {
                case 0:
                    Frame_Output.Text = "输出 DO 00-15(0号卡)";
                    break;
                case 1:
                    Frame_Output.Text = "输出 DO 00-15(1号卡)";
                    break;
                case 2:
                    Frame_Output.Text = "输出 DO 00-15(扩展模块)";
                    break;
            }

            for (int i = 0; i <= 15; i++)
            {
                Lab_Index[i].Text = BVar.FileRorW.ReadINI("Output", this.Tag + "," + System.Convert.ToString(i), "备用", (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Setting.dll");
            }

            IO();
            this.Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Tick);
        }
        #endregion

        #region 定时器

        private void Timer_Tick(object sender, EventArgs e)
        {
            lock (tTime)
            {
                try
                {
                    this.BeginInvoke(new Action(() => { IO(); }));
                }
                catch (Exception)
                {

                }
            }
        }

        private void IO()
        {
            if (mLoadOK == true)
            {
                try
                {
                    for (int i = 0; i < 16; i++)
                    {
                        if (mFunction.mGetDO(System.Convert.ToInt32(this.Tag), i) == 1)
                        {
                            Button_Index[i].Text = "OFF";
                            Button_Index[i].BackColor = Color.LightGreen;
                            Shape_Index[i].FillColor = Color.Lime;
                        }
                        else
                        {
                            Button_Index[i].Text = "ON";
                            Button_Index[i].BackColor = Color.White;
                            Shape_Index[i].FillColor = Color.White;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void OutputClass_Paint(object sender, PaintEventArgs e)
        {
            IO();
        }
        #endregion

        #region 手动按钮

        private void Output_Click(dynamic sender, EventArgs e)
        {
            if (sender.Text == "ON")
            {
                mFunction.mSetDO(System.Convert.ToInt32(this.Tag), System.Convert.ToInt32(sender.Tag), 1);
            }
            else
            {
                mFunction.mSetDO(System.Convert.ToInt32(this.Tag), System.Convert.ToInt32(sender.Tag), 0);
            }
            IO();
        }

        private void Output_0_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_1_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_2_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_3_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_4_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_5_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_6_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_7_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_8_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_9_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_10_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_11_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_12_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_13_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_14_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        private void Output_15_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }

        #endregion

    }
}
