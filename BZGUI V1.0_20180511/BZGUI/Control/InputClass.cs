using Microsoft.VisualBasic.PowerPacks;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace BZGUI
{
    public partial class InputClass
    {
        public InputClass()
        {
            InitializeComponent();
        }

        private Label[] Lab_Index;
        private Label[] Name_Index;
        private OvalShape[] Shape_Index;
        bool mLoadOK;

        private void InputClass_Load(object sender, EventArgs e)
        {
            //Me.Width = 266
            //Me.Height = 538
            Lab_Index = new Label[16] {Lab_Input_00, Lab_Input_01, Lab_Input_02, Lab_Input_03, Lab_Input_04, Lab_Input_05, Lab_Input_06, Lab_Input_07, 
                Lab_Input_08, Lab_Input_09, Lab_Input_10, Lab_Input_11, Lab_Input_12, Lab_Input_13, Lab_Input_14, Lab_Input_15};
            Name_Index = new Label[16] {Name_Index_0, Name_Index_1, Name_Index_2, Name_Index_3, Name_Index_4, Name_Index_5, Name_Index_6, Name_Index_7, 
                Name_Index_8, Name_Index_9, Name_Index_10, Name_Index_11, Name_Index_12, Name_Index_13, Name_Index_14, Name_Index_15};
            Shape_Index = new OvalShape[16] {OvalShape_0, OvalShape_1, OvalShape_2, OvalShape_3, OvalShape_4, OvalShape_5, OvalShape_6, OvalShape_7, 
                OvalShape_8, OvalShape_9, OvalShape_10, OvalShape_11, OvalShape_12, OvalShape_13, OvalShape_14, OvalShape_15};
            for (var i = 0; i <= 15; i++)
            {
                Shape_Index[i].Left = Name_Index[i].Left + 42;
                Shape_Index[i].Top = Name_Index[i].Top - 17;
            }

            int tag;
            tag = Convert.ToInt32(this.Tag);
            switch (tag)
            {
                case 0:
                    Frame_Input.Text = "输入 DI 00-15(0号卡)";
                    break;
                case 1:
                    Frame_Input.Text = "输入 DI 00-15(1号卡)";
                    break;
                case 2:
                    Frame_Input.Text = "输入 DI 00-15(扩展模块)";
                    break;
            }

            for (int i = 0; i <= 15; i++)
            {
                Lab_Index[i].Text = BVar.FileRorW.ReadINI("Input", this.Tag + "," + System.Convert.ToString(i), "备用", (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.DirectoryPath + "\\Setting.dll");
            }
            mLoadOK = true;
            this.Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mLoadOK)
            {
                lock (this)
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
        }

        private void IO()
        {
            if (mLoadOK)
            {
                try
                {
                    for (var i = 0; i <= 15; i++)
                    {
                        if (mFunction.mGetDi(System.Convert.ToInt16(this.Tag), System.Convert.ToInt16(i)) == 1)
                        {
                            Shape_Index[i].FillColor = Color.Lime;
                        }
                        else
                        {
                            Shape_Index[i].FillColor = Color.White;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }


    }

}
