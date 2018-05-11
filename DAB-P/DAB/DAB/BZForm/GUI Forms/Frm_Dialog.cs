using System.Drawing;
using System;
using System.Windows.Forms;


namespace DAB
    {
    public partial class Frm_Dialog
        {
        public Frm_Dialog()
            {
            Init();
            InitializeComponent();
            this.ControlBox = false;   // 设置不出现关闭按钮
            }

        private void Init()
            {
            Gg.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Frm_Par.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Frm_Main.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Frm_Engineering.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            mFunction.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Teach.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            GoHome.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Line0Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Line1Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Line2Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Line3Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Sta4Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            LoadPSARun.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            EpsonRobot.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            PressRun.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Calibration.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            CCDTest.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            OutputClass.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            }

        private void Frm_Dialog_Load(object sender, EventArgs e)
            {
            this.Location = new Point(150, 150);
            this.Text = "信息提示";
            PVar.Dialogfrm = true;
            }

        private void Form_QueryUnload(int Cancel, int UnloadMode)
            {
            PVar.Dialogfrm = false;
            }

        private void Button1_Click(object sender, EventArgs e)
            {
            this.Hide();
            this.List_Message.Items.Clear();
            PVar.Dialogfrm = false;
            }

        public void Dialog_OnAdd(string ListStr, short listType = 1)
            {
            try
                {
                if (FileRw.IsNotShow("Frm_Dialog"))
                    {
                    this.Show();
                    }
                this.Show();
                if (this.List_Message.Items.Count == 30)
                    {
                    this.List_Message.Items.Clear();
                    }

                this.BeginInvoke(new Action(() =>
                {
                    this.List_Message.Items.Add("◇" + ListStr);
                    this.List_Message.SelectedIndex = this.List_Message.Items.Count - 1;
                    switch (listType)
                        {
                        case (short)1:
                            FileLog.WriteErrLog(ListStr);
                            break;
                        default:
                            break;
                        }

                }));
                API.BringWindowToTop((int)this.Handle); //将此窗口显示在顶层
                }
            catch
                {

                }
            }


        }
    }
