using Microsoft.VisualBasic.PowerPacks;
using VB = Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic;

namespace DAB
    {
    public partial class Teach
        {
        public Teach()
            {
            InitializeComponent();
            }

        public static event Action<string> ShowList;    // this.Dialog_OnAdd(s)
        private FunctionSub Function = new FunctionSub();
        #region 变量定义
        public Button[] Btn_Servo;
        public Button[] Btn_Home;
        public TextBox[] Text_EncPos;
        public TextBox[] Text_PrfPos;
        public TextBox[] Text_Dist;
        public OvalShape[,] mOvalShape;
        int mIndex;
        bool mLoadOK;
        double mHomeVel;
        #endregion

        #region 自定参数

        private void LongDist_CheckedChanged(object sender, EventArgs e)
            {
            if (LongDist.Checked == true)
                {
                Text_Dist_X.Enabled = false;
                Text_Dist_Y.Enabled = false;
                Text_Dist_Z.Enabled = false;
                Text_Dist_R.Enabled = false;
                Text_Dist_X.Text = "5.000";
                Text_Dist_Y.Text = "5.000";
                Text_Dist_Z.Text = "5.000";
                Text_Dist_R.Text = "5.000";
                }
            }

        private void MidDist_CheckedChanged(object sender, EventArgs e)
            {
            if (MidDist.Checked == true)
                {
                Text_Dist_X.Enabled = false;
                Text_Dist_Y.Enabled = false;
                Text_Dist_Z.Enabled = false;
                Text_Dist_R.Enabled = false;
                Text_Dist_X.Text = "1.000";
                Text_Dist_Y.Text = "1.000";
                Text_Dist_Z.Text = "1.000";
                Text_Dist_R.Text = "1.000";
                }
            }

        private void SmallDist_CheckedChanged(object sender, EventArgs e)
            {
            if (SmallDist.Checked == true)
                {
                Text_Dist_X.Enabled = false;
                Text_Dist_Y.Enabled = false;
                Text_Dist_Z.Enabled = false;
                Text_Dist_R.Enabled = false;
                Text_Dist_X.Text = "0.100";
                Text_Dist_Y.Text = "0.100";
                Text_Dist_Z.Text = "0.100";
                Text_Dist_R.Text = "0.100";
                }
            }

        private void mLianXu_CheckedChanged(object sender, EventArgs e)
            {
            if (mLianXu.Checked == true)
                {
                Text_Dist_X.Enabled = false;
                Text_Dist_Y.Enabled = false;
                Text_Dist_Z.Enabled = false;
                Text_Dist_R.Enabled = false;
                }
            }

        private void mDinYi_CheckedChanged(object sender, EventArgs e)
            {
            if (mDinYi.Checked == true)
                {
                Text_Dist_X.Enabled = true;
                Text_Dist_Y.Enabled = true;
                Text_Dist_Z.Enabled = true;
                Text_Dist_R.Enabled = true;
                Text_Dist_X.Text = "0.01";
                Text_Dist_Y.Text = "0.01";
                Text_Dist_Z.Text = "0.01";
                Text_Dist_R.Text = "0.01";
                }
            }

        #endregion

        #region 窗体加载

        private void Teach_Load(object sender, EventArgs e)
            {
            Point[] mPoint = new Point[9];
            Image[] mImage = new Image[9];
            this.TabControl.SelectTab(1);
            this.TabControl1.SelectTab(1);
            this.Width = 486;
            this.Height = 332;
            ComBox_Speed.Text = System.Convert.ToString(ComBox_Speed.Items[2]);
            mIndex = System.Convert.ToInt32(this.Tag);

            mFunction.ReadPosData(PVar.BZ_ParameterPath + "\\PosData.dat", mFunction.Pos);
            mPoint[1] = XAdd.Location;
            mPoint[2] = XDec.Location;
            mPoint[3] = YAdd.Location;
            mPoint[4] = YDec.Location;
            mImage[1] = XAdd.Image;
            mImage[2] = XDec.Image;
            mImage[3] = YAdd.Image;
            mImage[4] = YDec.Image;
            mPoint[5] = ZAdd.Location;
            mPoint[6] = ZDec.Location;
            mPoint[7] = RAdd.Location;
            mPoint[8] = RDec.Location;
            mImage[5] = ZAdd.Image;
            mImage[6] = ZDec.Image;
            mImage[7] = RAdd.Image;
            mImage[8] = RDec.Image;

            //**************************手动修改按钮方向位置移动*********************


            int tag;
            tag = Convert.ToInt32(this.Tag);
            switch (tag)
                {
                case 0:
                    Label_AName.Visible = false;

                    XAdd.Image = Properties.Resources.zuo;
                    XDec.Image = Properties.Resources.you;
                    XAdd.Location = new Point(0 + mPoint[2].X, 0 + mPoint[2].Y);
                    XDec.Location = new Point(0 + mPoint[1].X, 0 + mPoint[1].Y);
                    RAdd.Location = mPoint[8];
                    RDec.Location = mPoint[7];
                    ZDec.BackColor = Color.DarkOrange;
                    ZAdd.BackColor = Color.DarkOrange;
                    RAdd.Image = Properties.Resources.xun;
                    RDec.Image = Properties.Resources.ni;
                    break;
                case 1:
                    Label_AName.Text = "左料盘";
                    Label18.Text = "Z";
                    XAdd.Text = "Z+";
                    XDec.Text = "Z-";
                    XDec.BackColor = Color.DarkOrange;
                    XAdd.BackColor = Color.DarkOrange;
                    XDec.Location = new Point(0 + mPoint[3].X, 0 + mPoint[3].Y);
                    XAdd.Location = new Point(0 + mPoint[4].X, 0 + mPoint[4].Y);

                    Btn_Servo_X.Text = " Z   使能";
                    Btn_Home_X.Text = "  Z   回原点";

                    Btn_Servo_X.Location = new Point(30 + Btn_Servo_X.Location.X, 25 + Btn_Servo_X.Location.Y);
                    Btn_Home_X.Location = new Point(30 + Btn_Home_X.Location.X, 25 + Btn_Home_X.Location.Y);
                    //修改点位表格的名称
                    TeachAxis1.HeaderText = "Z";
                    TeachAxis2.HeaderText = "*";
                    TeachAxis3.HeaderText = "*";
                    TeachAxis4.HeaderText = "*";
                    //修改轴位置的名称
                    Label_Pos_X.Text = "Z(mm)";
                    Label_Pos_Y.Text = "*(mm)";
                    Label_Pos_Z.Text = "*(mm)";
                    Label_Pos_R.Text = "*(mm)";
                    ALabel1.Text = "Z(mm)";
                    ALabel2.Text = "*(mm)";
                    ALabel3.Text = "*(mm)";
                    ALabel4.Text = "*(mm)";

                    XAdd.Image = Properties.Resources.shang;
                    XDec.Image = Properties.Resources.xia;

                    Btn_Servo_Y.Visible = false;
                    Btn_Home_Y.Visible = false;
                    Btn_Servo_Z.Visible = false;
                    Btn_Home_Z.Visible = false;
                    Btn_Servo_R.Visible = false;
                    Btn_Home_R.Visible = false;
                    this.Label19.Visible = false;
                    this.OvalShape7.Visible = false;
                    this.OvalShape8.Visible = false;
                    this.OvalShape9.Visible = false;
                    this.OvalShape10.Visible = false;
                    this.OvalShape11.Visible = false;
                    this.OvalShape12.Visible = false;
                    this.OvalShape13.Visible = false;
                    this.Label20.Visible = false;
                    this.OvalShape14.Visible = false;
                    this.OvalShape15.Visible = false;
                    this.OvalShape16.Visible = false;
                    this.OvalShape17.Visible = false;
                    this.OvalShape18.Visible = false;
                    this.OvalShape19.Visible = false;
                    this.OvalShape20.Visible = false;
                    this.Label21.Visible = false;
                    this.OvalShape21.Visible = false;
                    this.OvalShape22.Visible = false;
                    this.OvalShape23.Visible = false;
                    this.OvalShape24.Visible = false;
                    this.OvalShape25.Visible = false;
                    this.OvalShape26.Visible = false;
                    this.OvalShape27.Visible = false;
                    YAdd.Visible = false;
                    YDec.Visible = false;
                    ZAdd.Visible = false;
                    ZDec.Visible = false;
                    RAdd.Visible = false;
                    RDec.Visible = false;
                    break;
                case 2:
                    Label_AName.Text = "右料盘";
                    Label18.Text = "Z";
                    XAdd.Text = "Z+";
                    XDec.Text = "Z-";
                    XDec.BackColor = Color.DarkOrange;
                    XAdd.BackColor = Color.DarkOrange;
                    XDec.Location = new Point(0 + mPoint[3].X, 0 + mPoint[3].Y);
                    XAdd.Location = new Point(0 + mPoint[4].X, 0 + mPoint[4].Y);

                    Btn_Servo_X.Text = " Z   使能";
                    Btn_Home_X.Text = "  Z   回原点";

                    Btn_Servo_X.Location = new Point(30 + Btn_Servo_X.Location.X, 25 + Btn_Servo_X.Location.Y);
                    Btn_Home_X.Location = new Point(30 + Btn_Home_X.Location.X, 25 + Btn_Home_X.Location.Y);
                    //修改点位表格的名称
                    TeachAxis1.HeaderText = "Z";
                    TeachAxis2.HeaderText = "*";
                    TeachAxis3.HeaderText = "*";
                    TeachAxis4.HeaderText = "*";
                    //修改轴位置的名称
                    Label_Pos_X.Text = "Z(mm)";
                    Label_Pos_Y.Text = "*(mm)";
                    Label_Pos_Z.Text = "*(mm)";
                    Label_Pos_R.Text = "*(mm)";
                    ALabel1.Text = "Z(mm)";
                    ALabel2.Text = "*(mm)";
                    ALabel3.Text = "*(mm)";
                    ALabel4.Text = "*(mm)";

                    XAdd.Image = Properties.Resources.shang;
                    XDec.Image = Properties.Resources.xia;

                    Btn_Servo_Y.Visible = false;
                    Btn_Home_Y.Visible = false;
                    Btn_Servo_Z.Visible = false;
                    Btn_Home_Z.Visible = false;
                    Btn_Servo_R.Visible = false;
                    Btn_Home_R.Visible = false;
                    this.Label19.Visible = false;
                    this.OvalShape7.Visible = false;
                    this.OvalShape8.Visible = false;
                    this.OvalShape9.Visible = false;
                    this.OvalShape10.Visible = false;
                    this.OvalShape11.Visible = false;
                    this.OvalShape12.Visible = false;
                    this.OvalShape13.Visible = false;
                    this.Label20.Visible = false;
                    this.OvalShape14.Visible = false;
                    this.OvalShape15.Visible = false;
                    this.OvalShape16.Visible = false;
                    this.OvalShape17.Visible = false;
                    this.OvalShape18.Visible = false;
                    this.OvalShape19.Visible = false;
                    this.OvalShape20.Visible = false;
                    this.Label21.Visible = false;
                    this.OvalShape21.Visible = false;
                    this.OvalShape22.Visible = false;
                    this.OvalShape23.Visible = false;
                    this.OvalShape24.Visible = false;
                    this.OvalShape25.Visible = false;
                    this.OvalShape26.Visible = false;
                    this.OvalShape27.Visible = false;
                    YAdd.Visible = false;
                    YDec.Visible = false;
                    ZAdd.Visible = false;
                    ZDec.Visible = false;
                    RAdd.Visible = false;
                    RDec.Visible = false;
                    break;
                case 4:
                    Label_AName.Text = "保压站";
                    Label18.Text = "Z";
                    XAdd.Text = "Z+";
                    XDec.Text = "Z-";
                    XDec.BackColor = Color.DarkOrange;
                    XAdd.BackColor = Color.DarkOrange;
                    XAdd.Location = new Point(0 + mPoint[3].X, 0 + mPoint[3].Y);
                    XDec.Location = new Point(0 + mPoint[4].X, 0 + mPoint[4].Y);

                    Btn_Servo_X.Text = " Z   使能";
                    Btn_Home_X.Text = "  Z   回原点";

                    Btn_Servo_X.Location = new Point(30 + Btn_Servo_X.Location.X, 25 + Btn_Servo_X.Location.Y);
                    Btn_Home_X.Location = new Point(30 + Btn_Home_X.Location.X, 25 + Btn_Home_X.Location.Y);
                    //修改点位表格的名称
                    TeachAxis1.HeaderText = "Z";
                    TeachAxis2.HeaderText = "*";
                    TeachAxis3.HeaderText = "*";
                    TeachAxis4.HeaderText = "*";
                    //修改轴位置的名称
                    Label_Pos_X.Text = "Z(mm)";
                    Label_Pos_Y.Text = "*(mm)";
                    Label_Pos_Z.Text = "*(mm)";
                    Label_Pos_R.Text = "*(mm)";
                    ALabel1.Text = "Z(mm)";
                    ALabel2.Text = "*(mm)";
                    ALabel3.Text = "*(mm)";
                    ALabel4.Text = "*(mm)";

                    XAdd.Image = Properties.Resources.xia;
                    XDec.Image = Properties.Resources.shang;

                    Btn_Servo_Y.Visible = false;
                    Btn_Home_Y.Visible = false;
                    Btn_Servo_Z.Visible = false;
                    Btn_Home_Z.Visible = false;
                    Btn_Servo_R.Visible = false;
                    Btn_Home_R.Visible = false;
                    this.Label19.Visible = false;
                    this.OvalShape7.Visible = false;
                    this.OvalShape8.Visible = false;
                    this.OvalShape9.Visible = false;
                    this.OvalShape10.Visible = false;
                    this.OvalShape11.Visible = false;
                    this.OvalShape12.Visible = false;
                    this.OvalShape13.Visible = false;
                    this.Label20.Visible = false;
                    this.OvalShape14.Visible = false;
                    this.OvalShape15.Visible = false;
                    this.OvalShape16.Visible = false;
                    this.OvalShape17.Visible = false;
                    this.OvalShape18.Visible = false;
                    this.OvalShape19.Visible = false;
                    this.OvalShape20.Visible = false;
                    this.Label21.Visible = false;
                    this.OvalShape21.Visible = false;
                    this.OvalShape22.Visible = false;
                    this.OvalShape23.Visible = false;
                    this.OvalShape24.Visible = false;
                    this.OvalShape25.Visible = false;
                    this.OvalShape26.Visible = false;
                    this.OvalShape27.Visible = false;
                    YAdd.Visible = false;
                    YDec.Visible = false;
                    ZAdd.Visible = false;
                    ZDec.Visible = false;
                    RAdd.Visible = false;
                    RDec.Visible = false;
                    break;
                case 3:
                    Label_AName.Visible = false;
                    //Label_AName.Text = "";
                    //修改名称
                    XAdd.Text = "搬运Y+";
                    XDec.Text = "搬运Y-";
                    YAdd.Text = "PSA Z+";
                    YDec.Text = "PSA Z-";
                    ZAdd.Text = "Z2+";
                    ZDec.Text = "Z2-";
                    Label18.Text = "Y";
                    Label19.Text = "Z";
                    Label20.Text = "Z2";
                    Btn_Servo_X.Text = "搬运Y 使能";
                    Btn_Home_X.Text = "搬运Y 回原点";
                    Btn_Servo_Y.Text = "Z轴PSA  使能";
                    Btn_Home_Y.Text = "Z轴PSA 回原点";
                    Btn_Servo_Z.Text = " Z2   使能";
                    Btn_Home_Z.Text = " Z2  回原点";

                    //修改点位表格的名称
                    TeachAxis1.HeaderText = "Y";
                    TeachAxis2.HeaderText = "Z";
                    TeachAxis3.HeaderText = "Z*";
                    TeachAxis4.HeaderText = "*";

                    //修改轴位置的名称
                    Label_Pos_X.Text = "Y(mm)";
                    Label_Pos_Y.Text = "Z(mm)";
                    Label_Pos_Z.Text = "*(mm)";
                    Label_Pos_R.Text = "*(mm)";
                    ALabel1.Text = "Y(mm)";
                    ALabel2.Text = "Z(mm)";
                    ALabel3.Text = "*(mm)";
                    ALabel4.Text = "*(mm)";

                    //修改按钮的位置
                    XAdd.Location = new Point(0 + mPoint[3].X, -10 + mPoint[3].Y);
                    XDec.Location = new Point(0 + mPoint[4].X, -10 + mPoint[4].Y);
                    YDec.Location = new Point(-0 + mPoint[5].X, 0 + mPoint[5].Y);
                    YAdd.Location = new Point(-0 + mPoint[6].X, 0 + mPoint[6].Y);
                    ZAdd.Location = new Point(45 + mPoint[5].X, 0 + mPoint[5].Y);
                    ZDec.Location = new Point(45 + mPoint[6].X, 0 + mPoint[6].Y);


                    Btn_Servo_Z.Visible = false;
                    Btn_Home_Z.Visible = false;
                    Btn_Servo_R.Visible = false;
                    Btn_Home_R.Visible = false;

                    this.Label20.Visible = false;
                    this.OvalShape14.Visible = false;
                    this.OvalShape15.Visible = false;
                    this.OvalShape16.Visible = false;
                    this.OvalShape17.Visible = false;
                    this.OvalShape18.Visible = false;
                    this.OvalShape19.Visible = false;
                    this.OvalShape20.Visible = false;
                    this.Label21.Visible = false;
                    this.OvalShape21.Visible = false;
                    this.OvalShape22.Visible = false;
                    this.OvalShape23.Visible = false;
                    this.OvalShape24.Visible = false;
                    this.OvalShape25.Visible = false;
                    this.OvalShape26.Visible = false;
                    this.OvalShape27.Visible = false;
                    //修改背景颜色
                    YDec.BackColor = Color.Bisque;
                    YAdd.BackColor = Color.Bisque;
                    ZDec.BackColor = Color.Bisque;
                    ZAdd.BackColor = Color.Bisque;

                    //修改按钮图片
                    XAdd.Image = Properties.Resources.hou;
                    XDec.Image = Properties.Resources.qian;
                    YAdd.Image = Properties.Resources.shang;
                    YDec.Image = Properties.Resources.xia;
                    //ZAdd.Image = Properties.Resources.xia;
                    //ZDec.Image = Properties.Resources.shang;
                    //RAdd.Image = Properties.Resources.hou
                    //RDec.Image = Properties.Resources.qian

                    //隐藏按钮
                    //XAdd.Visible = False : XDec.Visible = False;
                    //YAdd.Visible = false; YDec.Visible = false;
                    ZAdd.Visible = false;
                    ZDec.Visible = false;
                    RAdd.Visible = false;
                    RDec.Visible = false;
                    break;
                }
            Data(); //显示数据
            Btn_Servo = new Button[5] { null, Btn_Servo_X, Btn_Servo_Y, Btn_Servo_Z, Btn_Servo_R };
            Btn_Home = new Button[5] { null, Btn_Home_X, Btn_Home_Y, Btn_Home_Z, Btn_Home_R };
            Text_EncPos = new TextBox[5] { null, Text_EncPos_X, Text_EncPos_Y, Text_EncPos_Z, Text_EncPos_R };
            Text_PrfPos = new TextBox[5] { null, Text_PrfPos_X, Text_PrfPos_Y, Text_PrfPos_Z, Text_PrfPos_R };
            Text_Dist = new TextBox[5] { null, Text_Dist_X, Text_Dist_Y, Text_Dist_Z, Text_Dist_R };

            mOvalShape = new OvalShape[5, 8] { { null, null, null, null, null, null, null, null }, { null, OvalShape0, OvalShape1, OvalShape2, OvalShape3, OvalShape4, OvalShape5, OvalShape6 }, { null, OvalShape7, OvalShape8, OvalShape9, OvalShape10, OvalShape11, OvalShape12, OvalShape13 }, { null, OvalShape14, OvalShape15, OvalShape16, OvalShape17, OvalShape18, OvalShape19, OvalShape20 }, { null, OvalShape21, OvalShape22, OvalShape23, OvalShape24, OvalShape25, OvalShape26, OvalShape27 } };
            mLoadOK = true;
            //Timer.Tick += new System.EventHandler(Timer_Tick);
            this.Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Tick);
            }
        #endregion

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

        private void Data()
            {
            for (int i = 1; i <= 15; i++)
                {
                DataGridView1.Rows.Add();
                }
            ComBox_PosList.Items.Clear();
            for (int i = 0; i <= 15; i++)
                {
                DataGridView1.Rows[i].Cells[0].Value = "P" + System.Convert.ToString(i);
                DataGridView1.Rows[i].Cells[0].Value = "P" + System.Convert.ToString(i);
                String pos;
                pos = mFunction.Pos.N[mIndex, (int)i];

                if (pos == "" || pos == null)
                    {
                    ComBox_PosList.Items.Add("P" + System.Convert.ToString(i));
                    ComBox_Aim.Items.Add("P" + System.Convert.ToString(i));
                    }
                else
                    {
                    ComBox_PosList.Items.Add("P" + System.Convert.ToString(i) + "-" + mFunction.Pos.N[mIndex, (int)i]);
                    ComBox_Aim.Items.Add("P" + System.Convert.ToString(i) + "-" + mFunction.Pos.N[mIndex, (int)i]);
                    }
                }
            ComBox_PosList.Text = System.Convert.ToString(ComBox_PosList.Items[0]);
            ComBox_Aim.Text = System.Convert.ToString(ComBox_PosList.Items[0]);
            try
                {
                for (int i = 0; i <= 15; i++)
                    {
                    //DataGridView1.Rows[i].Cells[1].Value = Convert.ToString(mFunction.Pos.N[mIndex, i]);
                    //DataGridView1.Rows[i].Cells[2].Value = Convert.ToString(mFunction.Pos.TeachAxis1[mIndex, i]);
                    //DataGridView1.Rows[i].Cells[3].Value =Convert.ToString( mFunction.Pos.TeachAxis2[mIndex, i]);
                    //DataGridView1.Rows[i].Cells[4].Value = Convert.ToString(mFunction.Pos.TeachAxis3[mIndex, i]);
                    //DataGridView1.Rows[i].Cells[5].Value = Convert.ToString(mFunction.Pos.TeachAxis4[mIndex, i]);

                    DataGridView1[1, i].Value = mFunction.Pos.N[mIndex, i];
                    DataGridView1[2, i].Value = mFunction.Pos.TeachAxis1[mIndex, i];
                    DataGridView1[3, i].Value = mFunction.Pos.TeachAxis2[mIndex, i];
                    DataGridView1[4, i].Value = mFunction.Pos.TeachAxis3[mIndex, i];
                    DataGridView1[5, i].Value = mFunction.Pos.TeachAxis4[mIndex, i];
                    }
                }
            catch (Exception)
                {

                }
            }


        private void IO()
            {

            for (int i = 1; i <= 4; i++)
                {
                if (Convert.ToInt32(mFunction.mAxis[Convert.ToInt32(this.Tag), i]) != 0)
                    {
                    if ((GoHome.Reset.State == false && GoHome.AxisHome[mFunction.mCard[Convert.ToInt32(this.Tag), i], mFunction.mAxis[Convert.ToInt32(this.Tag), i]].Step != 0))
                        {

                        if (mFunction.mCard[Convert.ToInt32(this.Tag), i] * 8 + mFunction.mAxis[Convert.ToInt32(this.Tag), i] == 4)
                            {
                            GoHome.GotoHome(0, 4, 30, -90, 20, -3, 5);
                            }
                        else if (mFunction.mCard[Convert.ToInt32(this.Tag), i] * 8 + mFunction.mAxis[Convert.ToInt32(this.Tag), i] == 5)
                            {
                            GoHome.GotoHome(0, 5,30, -1000, 10, 1, 5);
                            }
                        else if (mFunction.mCard[Convert.ToInt32(this.Tag), i] * 8 + mFunction.mAxis[Convert.ToInt32(this.Tag), i] == 6)
                            {
                            GoHome.GotoHome(0, 6, 30, -1000, 10, 1, 5);
                            }
                        else if (mFunction.mCard[Convert.ToInt32(this.Tag), i] * 8 + mFunction.mAxis[Convert.ToInt32(this.Tag), i] == 7)
                            {
                            GoHome.GotoHome(0, 7, 30, -1000, 10, 1, 5);
                            }
                        else if (mFunction.mCard[Convert.ToInt32(this.Tag), i] * 8 + mFunction.mAxis[Convert.ToInt32(this.Tag), i] == 8)
                            {
                            GoHome.GotoHome(0, 8, 30, -1000, 10, 1, 10);
                            }
                        }
                    if (this.TabControl.SelectedIndex == 1 && mFunction.mAxis[Convert.ToInt32(this.Tag), i] != 0)
                        {
                        if (mFunction.mCard[Convert.ToInt32(this.Tag), i] * 8 + mFunction.mAxis[Convert.ToInt32(this.Tag), i] == 8)
                            {
                            Text_EncPos[i].Text = Strings.Format(Gg.GetEncPosmm((short)(mFunction.mCard[Convert.ToInt32(this.Tag), i]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), i])), "0.000");
                            Text_PrfPos[i].Text = Strings.Format(Gg.GetPrfPosmm((short)(mFunction.mCard[Convert.ToInt32(this.Tag), i]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), i])), "0.000");
                            }
                        else
                            {
                            Text_EncPos[i].Text = Strings.Format(Gg.GetPrfPosmm((short)(mFunction.mCard[Convert.ToInt32(this.Tag), i]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), i])), "0.000");
                            Text_PrfPos[i].Text = Strings.Format(Gg.GetPrfPosmm((short)(mFunction.mCard[Convert.ToInt32(this.Tag), i]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), i])), "0.000");
                            }
                        }

                    if (this.TabControl.SelectedIndex == 0 && mFunction.mAxis[Convert.ToInt32(this.Tag), i] != 0)
                        {
                        if (GoHome.AxisHome[mFunction.mCard[Convert.ToInt32(this.Tag), i], mFunction.mAxis[Convert.ToInt32(this.Tag), i]].Result == false)
                            {
                            Btn_Home[i].BackColor = Color.White;
                            }
                        else
                            {
                            Btn_Home[i].BackColor = Color.LightGreen;
                            }

                        long StsValue = 0;
                        StsValue = Gg.GetSts((short)(mFunction.mCard[Convert.ToInt32(this.Tag), i]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), i]));

                        if ((StsValue & 0x200) == 0) //使能
                            {
                            mOvalShape[i, 1].FillColor = Color.White;
                            Btn_Servo[i].BackColor = Color.White;
                            }
                        else
                            {
                            mOvalShape[i, 1].FillColor = Color.Lime;
                            Btn_Servo[i].BackColor = Color.LightGreen;
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

                        if (Gg.GetHomeDi((short)(mFunction.mCard[Convert.ToInt32(this.Tag), i]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), i])) == 0) //原点
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
                    }
                }
            }
        #endregion

        #region 手动按钮

        private void XDec_MouseDown(object sender, MouseEventArgs e)
            {
            string mDir = "";
            int mCardIndex = 0;
            int mAxisIndex = 0;
            double mVel = 0;
            double nVel = 0;
            double mDist = 0;
            Button btn = sender as Button;
            mCardIndex = mFunction.mCard[Convert.ToInt32(this.Tag), btn.TabIndex];
            mAxisIndex = mFunction.mAxis[Convert.ToInt32(this.Tag), btn.TabIndex];
            if (Convert.ToInt32(btn.Tag) == 1)
                {
                mDir = "+";
                }
            else
                {
                mDir = "-";
                }
            //MessageBox.Show(mCardIndex & "," & mAxisIndex & "," & mDir)
            if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 0)
                {
                nVel = 1;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 1)
                {
                nVel = 5;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 2)
                {
                nVel = 10;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 3)
                {
                nVel = 30;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 4)
                {
                nVel = 50;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 5)
                {
                nVel = 100;
                }
            else
                {
                if (System.Convert.ToDouble(ComBox_Speed.Text) > 0)
                    {
                    nVel = Conversion.Val(ComBox_Speed.Text);
                    }
                else
                    {
                    nVel = 1;
                    ComBox_Speed.Text = System.Convert.ToString(ComBox_Speed.Items[0]);
                    }
                }

            mVel = nVel;
            mDist = System.Convert.ToDouble(Text_Dist[btn.TabIndex].Text);

            if (Gg.GetServoOnDi((short)mCardIndex, (short)mAxisIndex) == 0)
                {
                ShowList("请先打开" + System.Convert.ToString(mCardIndex) + "号卡第" + System.Convert.ToString(mAxisIndex) + "轴伺服ON");
                return;
                }

            if (mAxisIndex == 7)//上料PSA的Z轴
                {
                if (nVel > 5)
                    {
                    nVel = 5;
                    }
                }

            if (mAxisIndex == 8)//PSA搬运Y轴
                {
                //判断升降气缸是否在上方
                if (Gg.GetExDo(0, Gg.OutPut1.PSA吸嘴升降气缸) == 1 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 1)
                    {
                    ShowList("PSA吸嘴升降气缸不在上方！");
                    return;
                    }
                //先获取机械手的位置
                if (Frm_Engineering.fEngineering.Rbt_SendCmd("GetPos", "0", "0", "0", "0", "0", "0", "-1", "0", "0", "0", "0", "0", "0") == false)
                    {
                    ShowList("机械手网络未连接！");
                    return;
                    }
                int iTime = System.Convert.ToInt32(API.GetTickCount());
                do
                    {
                    if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 2000)
                        {
                        EpsonRobot.RobotIsWork = false;
                        ShowList("机械手网络通信超时！");
                        return;
                        }
                    System.Threading.Thread.Sleep(1);
                    Application.DoEvents();
                    } while (EpsonRobot.sRobot_Status != "GetPos");

                if (EpsonRobot.RobotPos.X > 250)
                    {
                    ShowList("机械手不在安全位置，请运动到初始位置！");
                    return;
                    }
                }

            if (mLianXu.Checked == true)
                {
                Gg.JogMotion((short)mCardIndex, (short)mAxisIndex, (int)mVel, mDir);
                }
            else
                {
                Gg.StepMotion((short)mCardIndex, (short)mAxisIndex, mVel, mDist, mDir);
                }
            }

        private void XDec_MouseUp(object sender, MouseEventArgs e)
            {
            int mCardIndex = 0;
            int mAxisIndex = 0;
            Button btn = sender as Button;
            mCardIndex = mFunction.mCard[Convert.ToInt32(this.Tag), btn.TabIndex];
            mAxisIndex = mFunction.mAxis[Convert.ToInt32(this.Tag), btn.TabIndex];
            if (mLianXu.Checked == true)
                {
                Gg.AxisStop((short)mCardIndex, (short)mAxisIndex);
                }
            gts.GT_ClrSts((short)mCardIndex, (short)mAxisIndex, (short)1); //清除各轴的报警和限位
            WinAPI.Wait(400);
            Tools.AxisTmplPos[(short)mCardIndex, (short)mAxisIndex] = Gg.GetEncPos((short)mCardIndex, (short)mAxisIndex);
            }

        private void Btn_DeletePos_Click(object sender, EventArgs e)
            {
            int nIndex = 0;

            int Myval = 0;
            nIndex = DataGridView1.CurrentRow.Index;
            if (Convert.ToString(DataGridView1[1, nIndex].Value) != "" && DataGridView1[1, nIndex].Value != null)
                {
                Myval = (int)(Interaction.MsgBox("准备删除点" + DataGridView1[0, nIndex].Value + "-<" + DataGridView1[1, nIndex].Value + ">吗?", Constants.vbYesNo, "示教点"));
                }
            else
                {
                Myval = (int)(Interaction.MsgBox("准备删除点" + DataGridView1[0, nIndex].Value + "吗?", Constants.vbYesNo, "示教点"));
                }
            if (Myval == (int)Constants.vbYes)
                {
                DataGridView1[1, nIndex].Value = "";
                for (var i = 2; i <= 5; i++)
                    {
                    DataGridView1[i, nIndex].Value = 0;
                    }
                }
            }

        private void Btn_SavePos_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("确定要保存吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) //设备初始化判定
                {
                return;
                }
            Btn_SavePos.Enabled = false;
            try
                {
                for (int i = 0; i <= 15; i++)
                    {
                    mFunction.Pos.N[mIndex, (int)i] = Convert.ToString(DataGridView1[1, i].Value);
                    mFunction.Pos.TeachAxis1[mIndex, i] = Convert.ToDouble(DataGridView1[2, i].Value);
                    mFunction.Pos.TeachAxis2[mIndex, i] = Convert.ToDouble(DataGridView1[3, i].Value);
                    mFunction.Pos.TeachAxis3[mIndex, i] = Convert.ToDouble(DataGridView1[4, i].Value);
                    mFunction.Pos.TeachAxis4[mIndex, i] = Convert.ToDouble(DataGridView1[5, i].Value);
                    }
                }
            catch (Exception)
                {

                }

            mFunction.WritePosData(PVar.BZ_ParameterPath + "\\PosData.dat", mFunction.Pos);

            ComBox_PosList.Items.Clear();
            ComBox_Aim.Items.Clear();
            for (int i = 0; i <= 15; i++)
                {
                if (mFunction.Pos.N[mIndex, i] == "" || mFunction.Pos.N[mIndex, i] == null)
                    {
                    ComBox_PosList.Items.Add("P" + Convert.ToString(i));
                    ComBox_Aim.Items.Add("P" + Convert.ToString(i));
                    }
                else
                    {
                    ComBox_PosList.Items.Add("P" + Convert.ToString(i) + "-" + mFunction.Pos.N[mIndex, i]);
                    ComBox_Aim.Items.Add("P" + Convert.ToString(i) + "-" + mFunction.Pos.N[mIndex, i]);
                    }
                }
            ComBox_PosList.Text = Convert.ToString(ComBox_PosList.Items[0]);
            ComBox_Aim.Text = Convert.ToString(ComBox_PosList.Items[0]);

            Btn_SavePos.Enabled = true;
            MessageBox.Show("保存成功！");
            }

        private void Btn_AddPos_Click(object sender, EventArgs e)
            {
            checkBox_Safe.Checked = false;
            int Myval = 0;
            int nIndex = 0;
            int Card_X = 0;
            int Card_Y = 0;
            int Card_Z = 0;
            int Card_R = 0;
            int Axis_X = 0;
            int Axis_Y = 0;
            int Axis_Z = 0;
            int Axis_R = 0;

            Card_X = mFunction.mCard[Convert.ToInt32(this.Tag), 1];
            Card_Y = mFunction.mCard[Convert.ToInt32(this.Tag), 2];
            Card_Z = mFunction.mCard[Convert.ToInt32(this.Tag), 3];
            Card_R = mFunction.mCard[Convert.ToInt32(this.Tag), 4];
            Axis_X = mFunction.mAxis[Convert.ToInt32(this.Tag), 1];
            Axis_Y = mFunction.mAxis[Convert.ToInt32(this.Tag), 2];
            Axis_Z = mFunction.mAxis[Convert.ToInt32(this.Tag), 3];
            Axis_R = mFunction.mAxis[Convert.ToInt32(this.Tag), 4];

            if (Gg.GetServoOnDi((short)Card_X, (short)Axis_X) == 0 & Axis_X != 0)
                {
                MessageBox.Show(VB.Strings.Mid(XAdd.Text, 1, XAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_Y, (short)Axis_Y) == 0 & Axis_Y != 0)
                {
                MessageBox.Show(VB.Strings.Mid(YAdd.Text, 1, YAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_Z, (short)Axis_Z) == 0 & Axis_Z != 0)
                {
                MessageBox.Show(VB.Strings.Mid(ZAdd.Text, 1, ZAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_R, (short)Axis_R) == 0 & Axis_R != 0)
                {
                MessageBox.Show(VB.Strings.Mid(RAdd.Text, 1, RAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (GoHome.AxisHome[Card_X, Axis_X].Result == false && Axis_X != 0)
                {
                MessageBox.Show(VB.Strings.Mid(XAdd.Text, 1, XAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (GoHome.AxisHome[Card_Y, Axis_Y].Result == false && Axis_Y != 0)
                {
                MessageBox.Show(VB.Strings.Mid(YAdd.Text, 1, YAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (GoHome.AxisHome[Card_Z, Axis_Z].Result == false && Axis_Z != 0)
                {
                MessageBox.Show(VB.Strings.Mid(ZAdd.Text, 1, ZAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (GoHome.AxisHome[Card_R, Axis_R].Result == false && Axis_R != 0)
                {
                MessageBox.Show(VB.Strings.Mid(RAdd.Text, 1, RAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            nIndex = ComBox_PosList.Items.IndexOf(ComBox_PosList.Text);
            if (Convert.ToString(DataGridView1[1, nIndex].Value) != "" && DataGridView1[1, nIndex].Value != null)
                {
                Myval = (int)(Interaction.MsgBox("准备重新加点" + DataGridView1[0, nIndex].Value + "-<" + DataGridView1[1, nIndex].Value + ">吗?", Constants.vbYesNo, "示教点"));
                }
            else
                {
                Myval = (int)(Interaction.MsgBox("准备重新加点" + DataGridView1[0, nIndex].Value + "吗?", Constants.vbYesNo, "示教点"));
                }

            //返回值vbYes
            if (Myval == (int)Constants.vbYes)
                {
                mFunction.Pos.TeachAxis1[mIndex, nIndex] = double.Parse(Text_EncPos_X.Text);
                mFunction.Pos.TeachAxis2[mIndex, nIndex] = double.Parse(Text_EncPos_Y.Text);
                mFunction.Pos.TeachAxis3[mIndex, nIndex] = double.Parse(Text_EncPos_Z.Text);
                mFunction.Pos.TeachAxis4[mIndex, nIndex] = double.Parse(Text_EncPos_R.Text);

                mFunction.WritePosData(PVar.BZ_ParameterPath + "\\PosData.dat", mFunction.Pos);

                DataGridView1[2, nIndex].Value = mFunction.Pos.TeachAxis1[mIndex, nIndex];
                DataGridView1[3, nIndex].Value = mFunction.Pos.TeachAxis2[mIndex, nIndex];
                DataGridView1[4, nIndex].Value = mFunction.Pos.TeachAxis3[mIndex, nIndex];
                DataGridView1[5, nIndex].Value = mFunction.Pos.TeachAxis4[mIndex, nIndex];
                }
            }

        private void Btn_Go_Click(object sender, EventArgs e)
            {
            int Myval = 0;
            int nIndex = 0;
            short Card_X = 0;
            short Card_Y = 0;
            short Card_Z = 0;
            short Card_R = 0;
            short Axis_X = 0;
            short Axis_Y = 0;
            short Axis_Z = 0;
            short Axis_R = 0;
            int nVel = 0;

            Card_X = mFunction.mCard[Convert.ToInt32(this.Tag), 1];
            Card_Y = mFunction.mCard[Convert.ToInt32(this.Tag), 2];
            Card_Z = mFunction.mCard[Convert.ToInt32(this.Tag), 3];
            Card_R = mFunction.mCard[Convert.ToInt32(this.Tag), 4];
            Axis_X = mFunction.mAxis[Convert.ToInt32(this.Tag), 1];
            Axis_Y = mFunction.mAxis[Convert.ToInt32(this.Tag), 2];
            Axis_Z = mFunction.mAxis[Convert.ToInt32(this.Tag), 3];
            Axis_R = mFunction.mAxis[Convert.ToInt32(this.Tag), 4];


            if (GoHome.Reset.Result == false)
                {
                ShowList("设备未初始化，请先初始化！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_X, (short)Axis_X) == 0 & Axis_X != 0)
                {
                ShowList(VB.Strings.Mid(XAdd.Text, 1, XAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_Y, (short)Axis_Y) == 0 & Axis_Y != 0)
                {
                ShowList(VB.Strings.Mid(YAdd.Text, 1, YAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_Z, (short)Axis_Z) == 0 & Axis_Z != 0)
                {
                ShowList(VB.Strings.Mid(ZAdd.Text, 1, ZAdd.Text.Length - 1) + "轴未使能！");
                return;
                }

            if (Gg.GetServoOnDi((short)Card_R, (short)Axis_R) == 0 & Axis_R != 0)
                {
                ShowList(VB.Strings.Mid(RAdd.Text, 1, RAdd.Text.Length - 1) + "轴未使能！");
                return;
                }
            if (GoHome.AxisHome[Card_X, Axis_X].Result == false && Axis_X != 0)
                {
                ShowList(VB.Strings.Mid(XAdd.Text, 1, XAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (GoHome.AxisHome[Card_Y, Axis_Y].Result == false && Axis_Y != 0)
                {
                ShowList(VB.Strings.Mid(YAdd.Text, 1, YAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (GoHome.AxisHome[Card_Z, Axis_Z].Result == false && Axis_Z != 0)
                {
                ShowList(VB.Strings.Mid(ZAdd.Text, 1, ZAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (GoHome.AxisHome[Card_R, Axis_R].Result == false && Axis_R != 0)
                {
                ShowList(VB.Strings.Mid(RAdd.Text, 1, RAdd.Text.Length - 1) + "轴未回零！");
                return;
                }

            if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 0)
                {
                nVel = 1;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 1)
                {
                nVel = 5;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 2)
                {
                nVel = 10;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 3)
                {
                nVel = 30;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 4)
                {
                nVel = 50;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 5)
                {
                nVel = 100;
                }
            else
                {
                if (System.Convert.ToDouble(ComBox_Speed.Text) > 0)
                    {
                    nVel = (int)(Conversion.Val(ComBox_Speed.Text));
                    }
                else
                    {
                    nVel = 1;
                    ComBox_Speed.Text = System.Convert.ToString(ComBox_Speed.Items[0]);
                    }
                }

            nIndex = ComBox_Aim.Items.IndexOf(ComBox_Aim.Text);

            if (System.Convert.ToString(DataGridView1[1, nIndex].Value) != "" && DataGridView1[1, nIndex].Value != null)
                {
                Myval = (int)(Interaction.MsgBox("准备执行命令：" + ComBox_CMD.Text + "-<" + DataGridView1[1, nIndex].Value + ">吗?", Constants.vbYesNo, "运动"));
                }
            else
                {
                Myval = (int)(Interaction.MsgBox("准备执行命令：" + ComBox_CMD.Text + " " + DataGridView1[0, nIndex].Value + "吗?", Constants.vbYesNo, "运动"));
                }
            //返回值vbYes


            if (Myval == (int)Constants.vbYes)
                {
                ShowList("运动到" + ComBox_Aim.Text + "，请等待……");
                if (ComBox_CMD.Text == "Go")
                    {
                    if (Axis_X != 0)
                        {
                        Gg.AbsMotion(Card_X, Axis_X, mFunction.Pos.TeachAxis1[Convert.ToInt32(this.Tag), nIndex], nVel);
                        }
                    if (Axis_Y != 0)
                        {
                        Gg.AbsMotion(Card_Y, Axis_Y, mFunction.Pos.TeachAxis2[Convert.ToInt32(this.Tag), nIndex], nVel);
                        }
                    if (Axis_Z != 0)
                        {
                        Gg.AbsMotion(Card_Z, Axis_Z, mFunction.Pos.TeachAxis3[Convert.ToInt32(this.Tag), nIndex], nVel);
                        }
                    if (Axis_R != 0)
                        {
                        Gg.AbsMotion(Card_R, Axis_R, mFunction.Pos.TeachAxis4[Convert.ToInt32(this.Tag), nIndex], nVel);
                        }
                    }
                else if (ComBox_CMD.Text == "Jump")
                    {
                    //选择模块
                    //----------------------------
                    //【Tag1】料盘左仓
                    //----------------------------
                    if (Convert.ToInt32(this.Tag) == 1)
                        {
                        if (Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘左供料)] == true)
                            {
                            ShowList("正在手动运行中，请稍等…");
                            return;
                            }

                        if (Gg.GetExDi(2, Gg.InPut3.左料仓到位感应信号) == 0) //左料仓到位感应信号
                            {
                            ShowList("左料仓到位感应信号异常");
                            return;
                            }
                        else
                            {
                            Gg.SetExDo(0, 2, Gg.OutPut2.左料盘吸电磁铁, 1);
                            }

                        switch (nIndex) //当前模块里面的点位
                            {
                            case 0://初始位置
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘左供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(2, Gg.InPut3.左料仓到位感应信号) == 0) //左料仓到位感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.料仓左Z轴 - 1), 1 << (Axis.料仓左Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，料仓到位感应信号异常中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }

                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘左供料)]) //判断【B-logo组装站】停止按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.料盘左供料)] == false)
                                        {
                                        Manual.S2_MotionPos0(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘左供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘左供料)] = false;
                                break;

                            case 2://满盘(10盘)定位位置
                            case 4://单盘(1盘)定位位置
                                if (Gg.GetExDi(2, Gg.InPut3.左料仓最上层感应信号) == 1 && Gg.GetEncPosmm(0, Axis.料仓左Z轴) <= mFunction.Pos.TeachAxis1[System.Convert.ToInt32(this.Tag), nIndex]) //左料仓最上层感应信号
                                    {
                                    ShowList("左料仓最上层感应信号已经触发");
                                    return;
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘左供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(2, Gg.InPut3.左料仓最上层感应信号) == 1 && Gg.GetEncPosmm(0, Axis.料仓左Z轴) <= mFunction.Pos.TeachAxis1[System.Convert.ToInt32(this.Tag), nIndex]) //左料仓最上层感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.料仓左Z轴 - 1), 1 << (Axis.料仓左Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，左料仓最上层感应信号触发中断");
                                        break;
                                        }
                                    if (Gg.GetExDi(2, Gg.InPut3.左料仓到位感应信号) == 0) //左料仓到位感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.料仓左Z轴 - 1), 1 << (Axis.料仓左Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，料仓到位感应信号异常中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }

                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘左供料)])
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.料盘左供料)] == false)
                                        {
                                        Manual.S2_MotionPos1(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘左供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘左供料)] = false;
                                break;

                            default:
                                Interaction.MsgBox("工程师没有设定这个手动点位，运行命令无效", Constants.vbOKOnly, "提示");
                                break;
                            }
                        }

                    //----------------------------
                    //【Tag2】料盘右仓
                    //----------------------------
                    else if (Convert.ToInt32(this.Tag) == 2)
                        {
                        if (Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘右供料)] == true)
                            {
                            ShowList("正在手动运行中，请稍等…");
                            return;
                            }
                        if (Gg.GetExDi(2, Gg.InPut3.右料仓到位感应信号) == 0) //右料仓到位感应信号
                            {
                            ShowList("右料仓到位感应信号异常");
                            return;
                            }
                        else
                            {
                            Gg.SetExDo(0, 2, Gg.OutPut2.右料盘吸电磁铁, 1);
                            }
                        switch (nIndex) //当前模块里面的点位
                            {
                            case 0://初始位置
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘右供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(2, Gg.InPut3.右料仓到位感应信号) == 0) //右料仓到位感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.料仓右Z轴 - 1), 1 << (Axis.料仓右Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，料仓到位感应信号异常中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘右供料)]) 
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.料盘右供料)] == false)
                                        {
                                        Manual.S3_MotionPos0(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘右供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘右供料)] = false;
                                break;

                            case 2://满载(10盘)收料位置
                            case 4://空载(1盘)收料位置
                                if (Gg.GetExDi(2, Gg.InPut3.右料仓最上层感应信号) == 1 && Gg.GetEncPosmm(0, Axis.料仓右Z轴) <= mFunction.Pos.TeachAxis1[System.Convert.ToInt32(this.Tag), nIndex]) //右料仓最上层感应信号
                                    {
                                    ShowList("右料仓最上层感应信号已经触发");
                                    return;
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘右供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(2, Gg.InPut3.右料仓到位感应信号) == 0) //右料仓到位感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.料仓右Z轴 - 1), 1 << (Axis.料仓右Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，料仓到位感应信号异常中断");
                                        break;
                                        }
                                    if (Gg.GetExDi(2, Gg.InPut3.右料仓最上层感应信号) == 1 && Gg.GetEncPosmm(0, Axis.料仓右Z轴) <= mFunction.Pos.TeachAxis1[System.Convert.ToInt32(this.Tag), nIndex]) //右料仓最上层感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.料仓右Z轴 - 1), 1 << (Axis.料仓右Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，料仓到位感应信号异常中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘右供料)])
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.料盘右供料)] == false)
                                        {
                                        Manual.S3_MotionPos1(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.料盘右供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.料盘右供料)] = false;
                                break;

                            default:
                                Interaction.MsgBox("工程师没有设定这个手动点位，运行命令无效", Constants.vbOKOnly, "提示");
                                break;
                            }
                        }


                    //----------------------------
                    //【Tag3】PSA供料
                    //----------------------------
                    else if (Convert.ToInt32(this.Tag) == 3)
                        {
                        if (Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] == true)
                            {
                            ShowList("正在手动运行中，请稍等…");
                            return;
                            }
                        switch (nIndex) //当前模块里面的点位
                            {
                            case 0://PSA【Z】轴初始位置
                            
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(1, Gg.InPut2.PSA料仓到位感应信号) == 0) //PSA料仓到位感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.PSA供料Z轴 - 1), 1 << (Axis.PSA供料Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，PSA料仓到位感应信号异常中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.PSA供料)])
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.PSA供料)] == false)
                                        {
                                        Manual.S4_MotionPos0(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.PSA供料)] = false;
                                break;

                            case 2://PSA【Z】轴单片位置
                                if (Gg.GetExDi(1, Gg.InPut2.PSA料仓上层感应) == 1 && Gg.GetEncPosmm(0, Axis.PSA供料Z轴) <= mFunction.Pos.TeachAxis1[System.Convert.ToInt32(this.Tag), nIndex]) //PSA料仓上层感应
                                    {
                                    ShowList("PSA料仓上层感应已经触发");
                                    return;
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(1, Gg.InPut2.PSA料仓到位感应信号) == 0) //PSA料仓到位感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.PSA供料Z轴 - 1), 1 << (Axis.PSA供料Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，料仓到位感应信号异常中断");
                                        break;
                                        }
                                    if (Gg.GetExDi(1, Gg.InPut2.PSA料仓上层感应) == 1 && Gg.GetEncPosmm(0, Axis.PSA供料Z轴) <= mFunction.Pos.TeachAxis1[System.Convert.ToInt32(this.Tag), nIndex]) //右料仓最上层感应信号
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.PSA供料Z轴 - 1), 1 << (Axis.PSA供料Z轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，PSA料仓上层感应中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.PSA供料)])
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.PSA供料)] == false)
                                        {
                                        Manual.S4_MotionPos0(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.PSA供料)] = false;
                                break;

                            case 4://PSA【Y】轴吸料位置
                            case 6://PSA【Y】轴放料位置
                            case 8://PSA【Y】轴费料位置
                                //判断升降气缸是否在上方
                                if (Gg.GetExDo(0, Gg.OutPut1.PSA吸嘴升降气缸) == 1 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 1)
                                    {
                                    ShowList("PSA吸嘴升降气缸不在上方！");
                                    return;
                                    }
                                //先获取机械手的位置
                                if (Frm_Engineering.fEngineering.Rbt_SendCmd("GetPos", "0", "0", "0", "0", "0", "0", "-1", "0", "0", "0", "0", "0", "0") == false)
                                    {
                                    ShowList("机械手网络未连接！");
                                    return;
                                    }
                                int iTime = System.Convert.ToInt32(API.GetTickCount());
                                do
                                    {
                                    if (System.Convert.ToInt32(API.GetTickCount()) - iTime > 2000)
                                        {
                                        EpsonRobot.RobotIsWork = false;
                                        ShowList("机械手网络通信超时！");
                                        return;
                                        }
                                    System.Threading.Thread.Sleep(1);
                                    Application.DoEvents();
                                    } while (EpsonRobot.sRobot_Status != "GetPos");

                                if (EpsonRobot.RobotPos.X >250 )
                                    {
                                    ShowList("机械手不在安全位置，请运动到初始位置！");
                                    return;
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 1 || Gg.GetExDo(0, Gg.OutPut1.PSA吸嘴升降气缸) == 1) //PSA吸嘴升降气缸上
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        PVar.Rtn = gts.GT_Stop(0, 1 << (Axis.PSA搬运Y轴 - 1), 1 << (Axis.PSA搬运Y轴 - 1)); //当站所有轴紧急停止
                                        ShowList("运动到" + ComBox_Aim.Text + "，PSA吸嘴升降气缸上感应信号异常中断");
                                        break;
                                        }
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.PSA供料)])
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.PSA供料)] == false)
                                        {
                                        Manual.S5_MotionPos0(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.PSA供料)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.PSA供料)] = false;
                                break;

                            default:
                                Interaction.MsgBox("工程师没有设定这个手动点位，运行命令无效", Constants.vbOKOnly, "提示");
                                break;
                            }
                        }
                    //----------------------------
                    //【Tag4】保压工位
                    //----------------------------
                    else if (Convert.ToInt32(this.Tag) == 4)
                        {
                        switch (nIndex) //当前模块里面的点位
                            {
                            case 0://初始位置
                            case 2://保压位置
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.保压)] = true;
                                Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] = true;
                                while (true)
                                    {
                                    System.Threading.Thread.Sleep(5);

                                    if (Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex] == false) //等待运动完成
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，完成");
                                        break;
                                        }
                                    if (Gg.GetDi(0, Gg.InPut0.急停按钮) == 1) //判断急停按钮是否按下
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，急停中断");
                                        break;
                                        }
                                    if (Manual.StopFlag[Convert.ToInt32(BVar.工位.保压)])
                                        {
                                        Manual.Manual_Step[Convert.ToInt32(this.Tag), nIndex] = 0;
                                        ShowList("运动到" + ComBox_Aim.Text + "，停止中断");
                                        break;
                                        }
                                    if (Manual.HoldFlag[Convert.ToInt32(BVar.工位.保压)] == false)
                                        {
                                        Manual.S6_MotionPos0(ref Manual.Manual_Result[Convert.ToInt32(this.Tag), nIndex], System.Convert.ToInt32(this.Tag), nIndex); //运动到待机位置
                                        WinAPI.Wait(50);
                                        }
                                    Application.DoEvents();
                                    }
                                Manual.MotionFlag[Convert.ToInt32(BVar.工位.保压)] = false;
                                Manual.StopFlag[Convert.ToInt32(BVar.工位.保压)] = false;
                                break;


                            default:
                                Interaction.MsgBox("工程师没有设定这个手动点位，运行命令无效", Constants.vbOKOnly, "提示");
                                break;
                            }
                        }
                    }
                }
            }



        private void Btn_Servo_X_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            mFunction.mServoON((Convert.ToInt16(this.Tag)), mFunction.mCard[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)], mFunction.mAxis[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)]);
            }

        private void Btn_Home_X_Click(object sender, EventArgs e)
            {
            Button btn = sender as Button;
            if (Gg.GetServoOnDi((short)(mFunction.mCard[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)]), (short)(mFunction.mAxis[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)])) == 0)
                {
                MessageBox.Show(VB.Strings.Mid(System.Convert.ToString(btn.Text), 1, Strings.Len(btn.Text) - 1) + "轴未使能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }

            if (Interaction.MsgBox("确定" + mFunction.mCard[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)].ToString() + "卡" + mFunction.mAxis[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)].ToString() + "轴回原点？", (int)Constants.vbInformation + Constants.vbOKCancel, null) == Constants.vbCancel)
                {
                return;
                }

            if ((Convert.ToInt32(this.Tag) == 3 && Convert.ToInt32(btn.Tag) == 1))
                {
                if (Gg.GetExDo(0, Gg.OutPut1.PSA吸嘴升降气缸) == 1 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0 || Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 1)
                    {
                    ShowList("PSA吸嘴升降气缸不在上方！");
                    return;
                    }

                }

            if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 0)
                {
                mHomeVel = 1;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 1)
                {
                mHomeVel = 5;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 2)
                {
                mHomeVel = 10;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 3)
                {
                mHomeVel = 30;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 4)
                {
                mHomeVel = 50;
                }
            else if (ComBox_Speed.Items.IndexOf(ComBox_Speed.Text) == 5)
                {
                mHomeVel = 100;
                }
            else
                {
                if (System.Convert.ToDouble(ComBox_Speed.Text) > 0)
                    {
                    mHomeVel = Conversion.Val(ComBox_Speed.Text);
                    }
                else
                    {
                    mHomeVel = 1;
                    ComBox_Speed.Text = System.Convert.ToString(ComBox_Speed.Items[0]);
                    }
                }

            GoHome.AxisHome[mFunction.mCard[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)], mFunction.mAxis[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)]].Result = false;
            GoHome.AxisHome[mFunction.mCard[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)], mFunction.mAxis[Convert.ToInt32(this.Tag), Convert.ToInt32(btn.Tag)]].Step = 10;

            }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
            {
            switch (TabControl1.SelectedIndex)
                {
                case 0:
                    ComBox_PosList.SelectedIndex = ComBox_Aim.SelectedIndex;
                    break;
                case 1:
                    Btn_AddPos.Enabled = false;
                    checkBox_Safe.Checked = false;
                    ComBox_Aim.SelectedIndex = ComBox_PosList.SelectedIndex;
                    break;
                }
            }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
            Btn_AddPos.Enabled = checkBox_Safe.Checked ? true : false;
            }

        //屏蔽键盘事件输入
        private void ComBox_List_KeyPress(object sender, KeyPressEventArgs e)
            {
            e.Handled = true;
            }

        }

    }
