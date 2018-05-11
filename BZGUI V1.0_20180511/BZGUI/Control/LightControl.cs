
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace BZGUI
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
            NumericUpDown_CH2.Value = TrackBar_CH2.Value;
            NumericUpDown_CH3.Value = TrackBar_CH3.Value;
            NumericUpDown_CH4.Value = TrackBar_CH4.Value;
            Command.Com3_Send("LMD,4SPLN,00" + "," +
               Strings.Format(TrackBar_CH1.Value, "000") + "," +
               Strings.Format(TrackBar_CH2.Value, "000") + "," +
               Strings.Format(TrackBar_CH3.Value, "000") + "," +
               Strings.Format(TrackBar_CH4.Value, "000") + ",");
        }

        private void TrackBar_CH2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown_CH1.Value = TrackBar_CH1.Value;
            NumericUpDown_CH2.Value = TrackBar_CH2.Value;
            NumericUpDown_CH3.Value = TrackBar_CH3.Value;
            NumericUpDown_CH4.Value = TrackBar_CH4.Value;
            Command.Com3_Send("LMD,4SPLN,00" + "," +
               Strings.Format(TrackBar_CH1.Value, "000") + "," +
               Strings.Format(TrackBar_CH2.Value, "000") + "," +
               Strings.Format(TrackBar_CH3.Value, "000") + "," +
               Strings.Format(TrackBar_CH4.Value, "000") + ",");
        }

        private void TrackBar_CH3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown_CH1.Value = TrackBar_CH1.Value;
            NumericUpDown_CH2.Value = TrackBar_CH2.Value;
            NumericUpDown_CH3.Value = TrackBar_CH3.Value;
            NumericUpDown_CH4.Value = TrackBar_CH4.Value;
            Command.Com3_Send("LMD,4SPLN,00" + "," +
               Strings.Format(TrackBar_CH1.Value, "000") + "," +
               Strings.Format(TrackBar_CH2.Value, "000") + "," +
               Strings.Format(TrackBar_CH3.Value, "000") + "," +
               Strings.Format(TrackBar_CH4.Value, "000") + ",");
        }

        private void TrackBar_CH4_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown_CH1.Value = TrackBar_CH1.Value;
            NumericUpDown_CH2.Value = TrackBar_CH2.Value;
            NumericUpDown_CH3.Value = TrackBar_CH3.Value;
            NumericUpDown_CH4.Value = TrackBar_CH4.Value;
            Command.Com3_Send("LMD,4SPLN,00" + "," +
               Strings.Format(TrackBar_CH1.Value, "000") + "," +
               Strings.Format(TrackBar_CH2.Value, "000") + "," +
               Strings.Format(TrackBar_CH3.Value, "000") + "," +
               Strings.Format(TrackBar_CH4.Value, "000") + ",");
        }

        private void NumericUpDown_CH1_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_CH1.Value = (int)NumericUpDown_CH1.Value;
            //Command.Com3_Send("LMD,SPLN,00,1," + Strings.Format(TrackBar_CH1.Value, "000") + ",");
        }
        private void NumericUpDown_CH2_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_CH2.Value = (int)NumericUpDown_CH2.Value;
            //Command.Com3_Send("LMD,SPLN,00,2," + Strings.Format(TrackBar_CH2.Value, "000") + ",");
        }

        private void NumericUpDown_CH3_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_CH3.Value = (int)NumericUpDown_CH3.Value;
            //Command.Com3_Send("LMD,SPLN,00,3," + Strings.Format(TrackBar_CH3.Value, "000") + ",");
        }

        private void NumericUpDown_CH4_ValueChanged(object sender, EventArgs e)
        {
            TrackBar_CH4.Value = (int)NumericUpDown_CH4.Value;
            //Command.Com3_Send("LMD,SPLN,00,4," + Strings.Format(TrackBar_CH4.Value, "000") + ",");
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
                Command.Com3_Send("LMD,4SPLN,00,000,000,000,000,");
            }
            else if ((int)this.Tag == 1)
            {
                //Command.Com3_Send("LMD,4SPLN,00,000,000,000,000,");
            }
        }

        private void Btn_Load_CH_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Save_CH_Click(object sender, EventArgs e)
        {

        }
    }

}
