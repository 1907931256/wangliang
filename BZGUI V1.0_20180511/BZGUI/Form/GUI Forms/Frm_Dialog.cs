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
using XCore;
using BZappdll;

namespace BZGUI
{
    public partial class Frm_Dialog
    {
        public Frm_Dialog()
        {
            Init();
            InitializeComponent();
            //this.ControlBox = false;   // 设置不出现关闭按钮
        }

        private void Init()
        {
            Gg.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Calibration.Instance.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Frm_Par.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Frm_Main.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Frm_Engineering.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            mFunction.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            Teach.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //GoHome.Instance.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Sta0Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Sta1Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Sta2Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Sta3Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Sta4Run.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //Manual.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            //SSH.Instance.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            DAQ.Instance.ShowList += ((s) => { this.Dialog_OnAdd(s); });
            PageEngineering.ShowList += ((s) => { this.Dialog_OnAdd(s); });
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
                this.Show();
                if (this.List_Message.Items.Count == 30)
                {
                    this.List_Message.Items.Clear();
                }
                Globals.Invoker.ListAddItems(this.List_Message, "◇" + ListStr);
                FileLog.WriteErrLog(ListStr);
                API.BringWindowToTop((int)this.Handle); //将此窗口显示在顶层
                }
            catch
                {

                }
            }


    }
}
