
using System;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing;


namespace DAB
    {
    public partial class LightControl
        {
        public LightControl()
            {
            InitializeComponent();
            }
        string[] SetArrayData = new string[4];

        #region 操作选项

        private void TrackBar_CH1_ValueChanged(object sender, EventArgs e)
            {
            NumericUpDown_CH1.Value = TrackBar_CH1.Value;
            if (TrackBar_CH1.Value > 0)
                {
                button1.Text = "关闭";
                button1.BackColor = Color.FromArgb(175, 218, 150);
                NumericUpDown_CH1.Value = TrackBar_CH1.Value;
                }
            else
                {
                button1.Text = "打开";
                button1.BackColor = Color.FromArgb(255, 128, 128);
                NumericUpDown_CH1.Value = TrackBar_CH1.Value;
                }
            Thread.Sleep(5);
            Command.Com3_Send("LMD,SSW,00,1," + TrackBar_CH1.Value.ToString("000") + ",");

            }

        private void TrackBar_CH2_ValueChanged(object sender, EventArgs e)
            {
            NumericUpDown_CH2.Value = TrackBar_CH2.Value;
            if (TrackBar_CH2.Value > 0)
                {
                button2.Text = "关闭";
                button2.BackColor = Color.FromArgb(175, 218, 150);
                NumericUpDown_CH2.Value = TrackBar_CH2.Value;
                }
            else
                {
                button2.Text = "打开";
                button2.BackColor = Color.FromArgb(255, 128, 128);
                NumericUpDown_CH2.Value = TrackBar_CH2.Value;
                }
            Thread.Sleep(5);
            Command.Com3_Send("LMD,SSW,00,2," + TrackBar_CH2.Value.ToString("000") + ",");
            }

        private void TrackBar_CH3_ValueChanged(object sender, EventArgs e)
            {
            NumericUpDown_CH3.Value = TrackBar_CH3.Value;
            if (TrackBar_CH3.Value > 0)
                {
                button3.Text = "关闭";
                button3.BackColor = Color.FromArgb(175, 218, 150);
                NumericUpDown_CH3.Value = TrackBar_CH3.Value;
                }
            else
                {
                button3.Text = "打开";
                button3.BackColor = Color.FromArgb(255, 128, 128);
                NumericUpDown_CH3.Value = TrackBar_CH3.Value;
                }
            Thread.Sleep(5);
            Command.Com3_Send("LMD,SSW,00,3," + TrackBar_CH3.Value.ToString("000") + ",");
            }

        private void TrackBar_CH4_ValueChanged(object sender, EventArgs e)
            {
            NumericUpDown_CH4.Value = TrackBar_CH4.Value;
            if (TrackBar_CH4.Value > 0)
                {
                button4.Text = "关闭";
                button4.BackColor = Color.FromArgb(175, 218, 150);
                NumericUpDown_CH4.Value = TrackBar_CH4.Value;
                }
            else
                {
                button4.Text = "打开";
                button4.BackColor = Color.FromArgb(255, 128, 128);
                NumericUpDown_CH4.Value = TrackBar_CH4.Value;
                }
            Thread.Sleep(5);
            Command.Com3_Send("LMD,SSW,00,4," + TrackBar_CH4.Value.ToString("000") + ",");
            }


        //******************************************
        private void NumericUpDown_CH1_MouseUp(object sender, MouseEventArgs e)
            {
            TrackBar_CH1.Value = Convert.ToInt32(NumericUpDown_CH1.Value);
            Thread.Sleep(50);
            Command.Com3_Send("LMD,SSW,00,1," + TrackBar_CH1.Value.ToString("000") + ",");

            }
        private void NumericUpDown_CH2_MouseUp(object sender, MouseEventArgs e)
            {
            TrackBar_CH2.Value = Convert.ToInt32(NumericUpDown_CH2.Value);
            Thread.Sleep(50);
            Command.Com3_Send("LMD,SSW,00,2," + TrackBar_CH2.Value.ToString("000") + ",");
            }

        private void NumericUpDown_CH3_MouseUp(object sender, MouseEventArgs e)
            {
                TrackBar_CH3.Value = Convert.ToInt32(NumericUpDown_CH3.Value);
            Thread.Sleep(50);
            Command.Com3_Send("LMD,SSW,00,3," + TrackBar_CH3.Value.ToString("000") + ",");
            }

        private void NumericUpDown_CH4_MouseUp(object sender, MouseEventArgs e)
            {
                TrackBar_CH4.Value = Convert.ToInt32(NumericUpDown_CH4.Value);
            Thread.Sleep(50);
            Command.Com3_Send("LMD,SSW,00,4," + TrackBar_CH4.Value.ToString("000") + ",");
            }


        private void Btn_Save_CH_Click(Button sender, EventArgs e)
            {
            //    SetArrayData[0] = System.Convert.ToString(TrackBar_CH1.Value);
            //    SetArrayData[1] = System.Convert.ToString(TrackBar_CH2.Value);
            //    SetArrayData[2] = System.Convert.ToString(TrackBar_CH3.Value);
            //    SetArrayData[3] = System.Convert.ToString(TrackBar_CH4.Value);
            //    FunctionSub.SetArray(PVar.ColorSelectd, "#" + Cmb_TriggerSelect.Text + "#", SetArrayData, PVar.BZ_LightSettingPath);
            }

        private void Cmb_TriggerSelect_SelectedIndexChanged(ComboBox sender, EventArgs e)
            {

            }

        private void Btn_Load_CH_Click(Button sender, EventArgs e)
            {

            }

        #endregion

        private void LightControl_Load(object sender, EventArgs e)
            {
            if (Convert.ToInt32(this.Tag) == 0)
                {
                Lab_LightControlName.Text = "光源控制器";
                Cmb_TriggerSelect.Items.Add("Cam1");
                Cmb_TriggerSelect.Items.Add("Cam2");
                Lab_Ch1.Text = "CH1(2站白色环形光)";
                Lab_Ch2.Text = "CH2(2站白色背光)";
                Lab_Ch3.Text = "CH3(4站白色环形光)";
                Lab_Ch4.Text = "CH4(4站白色背光)";
                }
            if (Convert.ToInt32(this.Tag) == 1)
            {
                Lab_LightControlName.Text = "光源控制器";
                Cmb_TriggerSelect.Items.Add("Cam1");
                Cmb_TriggerSelect.Items.Add("Cam2");
                Lab_Ch1.Text = "CH1(2站白色环形光)";
                Lab_Ch2.Text = "CH2(2站白色背光)";
                Lab_Ch3.Text = "CH3(4站白色环形光)";
                Lab_Ch4.Text = "CH4(4站白色背光)";
            }
            Cmb_SelectColor.SelectedIndex = 0;
            Cmb_TriggerSelect.SelectedIndex = 0;
            }

        private void Cmb_SelectColor_SelectedIndexChanged(object sender, EventArgs e)
            {
            PVar.ColorSelectd = Cmb_SelectColor.Text.Substring(0, 3);
            }

        private void Btn_Open_Click(object sender, EventArgs e)
            {
            if (Convert.ToInt32(this.Tag) == 0)
                {
                TrackBar_CH1.Value = 000;
                NumericUpDown_CH1.Value = TrackBar_CH1.Value;

                TrackBar_CH2.Value = 000;
                NumericUpDown_CH2.Value = TrackBar_CH2.Value;

                TrackBar_CH3.Value = 000;
                NumericUpDown_CH3.Value = TrackBar_CH3.Value;

                TrackBar_CH4.Value = 000;
                NumericUpDown_CH4.Value = TrackBar_CH4.Value;

                button1.Text = "打开";
                button2.Text = "打开";
                button3.Text = "打开";
                button4.Text = "打开";
                button1.BackColor = Color.FromArgb(255, 128, 128);
                button2.BackColor = Color.FromArgb(255, 128, 128);
                button3.BackColor = Color.FromArgb(255, 128, 128);
                button4.BackColor = Color.FromArgb(255, 128, 128);

                }
            else if (Convert.ToInt32(this.Tag) == 1)
                {
                TrackBar_CH1.Value = 000;
                NumericUpDown_CH1.Value = TrackBar_CH1.Value;

                TrackBar_CH2.Value = 000;
                NumericUpDown_CH2.Value = TrackBar_CH2.Value;

                TrackBar_CH3.Value = 000;
                NumericUpDown_CH3.Value = TrackBar_CH3.Value;

                TrackBar_CH4.Value = 000;
                NumericUpDown_CH4.Value = TrackBar_CH4.Value;

                button1.Text = "打开";
                button2.Text = "打开";
                button3.Text = "打开";
                button4.Text = "打开";
                button1.BackColor = Color.FromArgb(255, 128, 128);
                button2.BackColor = Color.FromArgb(255, 128, 128);
                button3.BackColor = Color.FromArgb(255, 128, 128);
                button4.BackColor = Color.FromArgb(255, 128, 128);
                //Command.Com3_Send("LMD,4SPLN,00,000,000,000,000,");
                }
            }

        private void Btn_Load_CH_Click(object sender, EventArgs e)
            {

            }

        private void Btn_Save_CH_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            {
            if (button1.Text == "打开")
                {
                button1.Text = "关闭";
                button1.BackColor = Color.FromArgb(175, 218, 150);
                TrackBar_CH1.Value = 255;
                NumericUpDown_CH1.Value = TrackBar_CH1.Value;
                }
            else
                {
                button1.Text = "打开";
                button1.BackColor = Color.FromArgb(255, 128, 128);
                TrackBar_CH1.Value = 000;
                NumericUpDown_CH1.Value = TrackBar_CH1.Value;
                }
            }

        private void button2_Click(object sender, EventArgs e)
            {
            if (button2.Text == "打开")
                {
                button2.Text = "关闭";
                button2.BackColor = Color.FromArgb(175, 218, 150);
                TrackBar_CH2.Value = 255;
                NumericUpDown_CH2.Value = TrackBar_CH2.Value;
                }
            else
                {
                button2.Text = "打开";
                button2.BackColor = Color.FromArgb(255, 128, 128);
                TrackBar_CH2.Value = 000;
                NumericUpDown_CH2.Value = TrackBar_CH2.Value;
                }
            }

        private void button3_Click(object sender, EventArgs e)
            {
            if (button3.Text == "打开")
                {
                button3.Text = "关闭";
                button3.BackColor = Color.FromArgb(175, 218, 150);
                TrackBar_CH3.Value = 255;
                NumericUpDown_CH3.Value = TrackBar_CH3.Value;
                }
            else
                {
                button3.Text = "打开";
                button3.BackColor = Color.FromArgb(255, 128, 128);
                TrackBar_CH3.Value = 000;
                NumericUpDown_CH3.Value = TrackBar_CH3.Value;
                }
            }

        private void button4_Click(object sender, EventArgs e)
            {
            if (button4.Text == "打开")
                {
                button4.Text = "关闭";
                button4.BackColor = Color.FromArgb(175, 218, 150);
                TrackBar_CH4.Value = 255;
                NumericUpDown_CH4.Value = TrackBar_CH4.Value;
                }
            else
                {
                button4.Text = "打开";
                button4.BackColor = Color.FromArgb(255, 128, 128);
                TrackBar_CH4.Value = 000;
                NumericUpDown_CH4.Value = TrackBar_CH4.Value;
                }

            }

        private void NumericUpDown_CH1_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == Convert.ToChar(Constants.vbCr))
                {
                    TrackBar_CH1.Value = Convert.ToInt32(NumericUpDown_CH1.Value);
                 if (TrackBar_CH1.Value > 0)
                     {
                     button1.Text = "关闭";
                     button1.BackColor = Color.FromArgb(175, 218, 150);
                     NumericUpDown_CH1.Value = TrackBar_CH1.Value;
                     }
                 else
                     {
                     button1.Text = "打开";
                     button1.BackColor = Color.FromArgb(255, 128, 128);
                     NumericUpDown_CH1.Value = TrackBar_CH1.Value;
                     }
                }
            }

        private void NumericUpDown_CH2_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == Convert.ToChar(Constants.vbCr))
                {
                    TrackBar_CH2.Value = Convert.ToInt32(NumericUpDown_CH2.Value);
                if (TrackBar_CH2.Value > 0)
                    {
                    button2.Text = "关闭";
                    button2.BackColor = Color.FromArgb(175, 218, 150);
                    NumericUpDown_CH2.Value = TrackBar_CH2.Value;
                    }
                else
                    {
                    button2.Text = "打开";
                    button2.BackColor = Color.FromArgb(255, 128, 128);
                    NumericUpDown_CH2.Value = TrackBar_CH2.Value;
                    }
                }
            }

        private void NumericUpDown_CH3_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == Convert.ToChar(Constants.vbCr))
                {
                    TrackBar_CH3.Value = Convert.ToInt32(NumericUpDown_CH3.Value);
                if (TrackBar_CH3.Value > 0)
                    {
                    button3.Text = "关闭";
                    button3.BackColor = Color.FromArgb(175, 218, 150);
                    NumericUpDown_CH3.Value = TrackBar_CH3.Value;
                    }
                else
                    {
                    button3.Text = "打开";
                    button3.BackColor = Color.FromArgb(255, 128, 128);
                    NumericUpDown_CH3.Value = TrackBar_CH3.Value;
                    }
                }
            }

        private void NumericUpDown_CH4_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == Convert.ToChar(Constants.vbCr))
                {
                    TrackBar_CH4.Value = Convert.ToInt32(NumericUpDown_CH4.Value);
                if (TrackBar_CH4.Value>0)
                    {
                    button4.Text = "关闭";
                    button4.BackColor = Color.FromArgb(175, 218, 150);
                    NumericUpDown_CH4.Value = TrackBar_CH4.Value;
                    }
                else
                    {
                    button4.Text = "打开";
                    button4.BackColor = Color.FromArgb(255, 128, 128);
                    NumericUpDown_CH4.Value = TrackBar_CH4.Value;
                    }
                }
            }

        }

    }
