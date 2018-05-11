using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using VB = Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using System.Drawing;

namespace DAB
    {

    public partial class MotorStatus
        {
        public MotorStatus()
            {
            InitializeComponent();
            }

        public OvalShape[,] mOvalShape;
        bool mLoadOK;
        int CardTmp;
        int AxisTmp;

        private void MotorStatus_Load(object sender, EventArgs e) 
            {
            mOvalShape = new OvalShape[5, 8] {{null, null, null, null, null, null, null, null}, 
                {null, OvalShape0, OvalShape1, OvalShape2, OvalShape3, OvalShape4, OvalShape5, OvalShape6}, 
                {null, OvalShape7, OvalShape8, OvalShape9, OvalShape10, OvalShape11, OvalShape12, OvalShape13}, 
                {null, OvalShape14, OvalShape15, OvalShape16, OvalShape17, OvalShape18, OvalShape19, OvalShape20}, 
                {null, OvalShape21, OvalShape22, OvalShape23, OvalShape24, OvalShape25, OvalShape26, OvalShape27}};

            int tabindex;
            tabindex = (int)(Conversion.Val(VB.Strings.Mid(System.Convert.ToString(this.Tag), System.Convert.ToInt32(1), 1)));
            switch (tabindex)
                {
                case 0:
                    this.Frame_MotorStaus.Text = "0卡各轴状况";
                    this.X_Axis_Name.Text = "流水线1 ❶";
                    this.Y_Axis_Name.Text = "流水线2 ❷";
                    this.Z_Axis_Name.Text = "流水线3 ❸";
                    this.R_Axis_Name.Text = "PSA搬运Y轴 ❹";
                    Frame_MotorStaus.Text = "0卡：1-4轴";
                    break;
                case 1:
                    this.Frame_MotorStaus.Text = "0卡各轴状况";
                    this.X_Axis_Name.Text = "料仓左轴 ❺";
                    this.Y_Axis_Name.Text = "料仓右轴 ❻";
                    this.Z_Axis_Name.Text = "PSA Z 轴 ❼";
                    this.R_Axis_Name.Text = "搬运Y 轴 ❽";
                    Frame_MotorStaus.Text = "0卡：5-8轴";
                    break;
                }

            mLoadOK = true;
            this.Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Tick);
            }

        #region 定时器


        private void Timer_Tick(object sender, EventArgs e)
            {
            if (mLoadOK == true)
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

        private bool[] IO_Once = new bool[11];

        private void IO()
            {
            for (var i = 1; i <= 4; i++)
                {
                CardTmp = (int)(Conversion.Val(VB.Strings.Mid(System.Convert.ToString(this.Tag), System.Convert.ToInt32((i - 1) * 5 + 3), 1)));
                AxisTmp = (int)(Conversion.Val(VB.Strings.Mid(System.Convert.ToString(this.Tag), System.Convert.ToInt32((i - 1) * 5 + 5), 1)));


                if (AxisTmp != 0)
                    {
                    long StsValue = 0;
                    StsValue = Gg.GetSts((short)CardTmp, (short)AxisTmp);
                  
                    if ((StsValue & 0x200) == 0) //使能
                        {
                        mOvalShape[i, 1].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 1].FillColor = Color.Lime;
                        }

                    if ((StsValue & 0x2) == 0) //报警
                        {
                        mOvalShape[i, 2].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 2].FillColor = Color.Lime;
                        }

                    if ((StsValue & 0x20) == 0) //正限位
                        {
                        mOvalShape[i, 3].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 3].FillColor = Color.Lime;
                        }

                    if (Gg.GetHomeDi((short)CardTmp, (short)AxisTmp) == 0) //原点
                        {
                        mOvalShape[i, 4].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 4].FillColor = Color.Lime;
                        }

                    if ((StsValue & 0x40) == 0) //负限位
                        {
                        mOvalShape[i, 5].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 5].FillColor = Color.Lime;
                        }

                    if ((StsValue & 0x400) == 0) //运动标志
                        {
                        mOvalShape[i, 6].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 6].FillColor = Color.Lime;
                        }

                    if ((StsValue & 0x10) == 0) //误差标志
                        {
                        mOvalShape[i, 7].FillColor = Color.White;
                        }
                    else
                        {
                        mOvalShape[i, 7].FillColor = Color.Lime;
                        }
                    }
                else
                    {
                    if ((int)i == 1)
                        {
                        X_Axis_Name.Visible = false;
                        }
                    else if ((int)i == 2)
                        {
                        Y_Axis_Name.Visible = false;
                        }
                    else if ((int)i == 3)
                        {
                        Z_Axis_Name.Visible = false;
                        }
                    else if ((int)i == 4)
                        {
                        R_Axis_Name.Visible = false;
                        }
                    for (var j = 1; j <= 7; j++)
                        {
                        mOvalShape[i, j].Visible = false;
                        }
                    }
                }
            }
        #endregion


        }
    }
