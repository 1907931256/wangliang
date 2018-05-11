using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BZGUI
{
    //组装工站
    sealed class Sta2Run
    {
        private static double disrow = 0;
        private static double discell = 0;
        private static int BufferStep = 0;
        private static int TimeOut = 0;
        private static bool Once = false;
        private static int sRtn;
        private static PVar.CCDDataType[] CCD_Vale = new PVar.CCDDataType[10];
        private static int[] T_Count = new int[10];
        private static sOffset Offset;
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        private struct sOffset
        {
            public double X;
            public double Y;
            public double T;
            public double A;
            public double L;
        }

        public static void AutoRun(ref PVar.WorkType StaWork)
        {
            try
            {
                switch (StaWork.Step)
                {
                    case 10:
                        if (PVar.Stop_Flag == false)
                        {
                            StaWork.Result = false;
                            StaWork.State = false;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        //本站工作状态，工站使能，本站是否有产品，转盘工作状态
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (StaWork.State == false && StaWork.Enable && StaWork.IsHaveHSG)
                            {
                                StaWork.State = true;
                                Once = false;
                                Gg.SetDo(1, Gg.OutPut1.取料吸嘴真空吸, 0);
                                Gg.SetDo(1, Gg.OutPut1.取料吸嘴破真空, 0);
                                Command.Com1_Send(Command.压力控制打开);
                                AddList("组装开始！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                StaWork.Step = 10;
                            }
                        }
                        else
                        {
                            if (StaWork.State == false && StaWork.Enable && StaWork.IsHaveHSG)
                            {
                                StaWork.State = true;
                                Once = false;
                                //Gg.SetDo(1, Gg.OutPut1.取料吸嘴真空吸, 0);
                                //Gg.SetDo(1, Gg.OutPut1.取料吸嘴破真空, 0);
                                Command.Com1_Send(Command.压力控制打开);
                                AddList("组装开始！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 30;
                            }
                            else
                            {
                                StaWork.Step = 10;
                            }
                        }

                        break;

                    case 30:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 0], PVar.ParAxis.Speed[BVar.S2_Z]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 40;
                        break;
                    //初始位置
                    case 40:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[0, 0], PVar.ParAxis.Speed[BVar.S2_X]);
                            Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[0, 0], PVar.ParAxis.Speed[BVar.S2_Y]);
                            Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 0], PVar.ParAxis.Speed[BVar.S2_R]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 50;
                        }
                        break;

                    case 50:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 60;
                        }
                        break;

                    case 60:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (PVar.Sta_Work[0].Result)
                            {
                                AddList("供料站物料准备OK！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 70;
                            }
                            else
                            {
                                if (Once == false)
                                {
                                    Once = true;
                                    AddList("等待物料供应…");
                                }
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 70;
                        }

                        break;

                    //拍照位置
                    case 70:
                        disrow = BVar.DisRow * ((PVar.Blogo.MaterialCnt - 1) % 2);//判断所在行
                        discell = BVar.DisCell * ((PVar.Blogo.MaterialCnt - 1) / 2);//判断所在列

                        Gg.AbsMotion(0, BVar.S2L_Z, mFunction.Pos.TeachAxis3[3, 3] - discell, PVar.ParAxis.Speed[BVar.S2L_Z]);

                        Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[0, 1], PVar.ParAxis.Speed[BVar.S2_X]);
                        Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[0, 1] + disrow, PVar.ParAxis.Speed[BVar.S2_Y]);
                        Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 1], PVar.ParAxis.Speed[BVar.S2_R]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 80;
                        break;

                    case 80:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_Z) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 1], PVar.ParAxis.Speed[BVar.S2_Z]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 85;
                        }
                        break;

                    case 85:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 90;
                        }
                        break;

                    case 90:
                        if (API.GetTickCount() - TimeOut > 200)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 100;
                        }
                        break;

                    case 100:
                        sRtn = Command.TCP_CCD1_Send(Command.取料拍照 + "," + PVar.ParList.Data[7]);

                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 110;
                            }
                            else if (sRtn == 2) //网络链接异常
                            {
                                AddList("网络链接异常！");
                                ShowList("网络链接异常！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 100;
                                StaWork.Step = 8000;
                            }
                            else
                            {
                                AddList("取料拍照命令发送失败！");
                                ShowList("取料拍照命令发送失败！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 100;
                                StaWork.Step = 8000;
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 110;
                        }
                        break;

                    case 110:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Command.CCD1_Resule && PVar.CCD1_Data[0] == Command.取料拍照)
                            {
                                AddList("取料拍照数据收到！");
                                CCD_Vale[1].X = Convert.ToDouble(PVar.CCD1_Data[1]);
                                CCD_Vale[1].Y = Convert.ToDouble(PVar.CCD1_Data[2]);
                                CCD_Vale[1].T = Convert.ToDouble(PVar.CCD1_Data[3]);
                                CCD_Vale[1].Judge = Convert.ToDouble(PVar.CCD1_Data[4]);

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 120;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 2000)
                                {
                                    AddList("等待取料拍照数据超时！");
                                    TimeOut = API.GetTickCount();
                                    BufferStep = 100;
                                    StaWork.Step = 8000;
                                }
                            }
                        }
                        else
                        {
                            AddList("取料拍照数据收到！");
                            CCD_Vale[1].X = 0;
                            CCD_Vale[1].Y = 0;
                            CCD_Vale[1].T = 0;
                            CCD_Vale[1].Judge = 0;

                            TimeOut = API.GetTickCount();
                            StaWork.Step = 120;
                        }
                        break;

                    case 120:
                        if (CCD_Vale[1].Judge == 0)
                        {
                            if (CCD_Vale[1].X > -5 && CCD_Vale[1].X < 1.5 && Math.Abs(CCD_Vale[1].Y) < 1.5 && Math.Abs(CCD_Vale[1].T) < 5)
                            {
                                double tmpX;
                                double tmpY;
                                double mT;
                                double mPI = 3.1415926535897931;
                                double L_Arm = PVar.ParList.Data[9];

                                Offset.T = CCD_Vale[1].T + PVar.ParList.Data[7]; ;
                                mT = Offset.T * mPI / 180;
                                tmpX = -L_Arm * (1 - System.Math.Cos(mT));
                                tmpY = -L_Arm * System.Math.Sin(mT);

                                Offset.X = CCD_Vale[1].X + tmpX + PVar.ParList.Data[5];
                                Offset.Y = CCD_Vale[1].Y + tmpY + PVar.ParList.Data[6];

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 130;
                            }
                            else
                            {
                                AddList("物料偏移值过大，取下一个物料！");
                                if (PVar.Blogo.MaterialCnt < 12)
                                {
                                    PVar.Blogo.MaterialCnt += 1;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 70;
                                }
                                else
                                {
                                    //需要更换物料
                                    PVar.Sta_Work[0].Result = false;
                                    PVar.Blogo.MaterialCnt = 1;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 2000;
                                }
                                Frm_Engineering.fEngineering.Text_BlogoNo.Text = PVar.Blogo.MaterialCnt.ToString();
                                Frm_Engineering.fEngineering.TextM_BlogoNo.Text = Frm_Engineering.fEngineering.Text_BlogoNo.Text;
                                BVar.FileRorW.WriteINI("Material_index", "Blogo", PVar.Blogo.MaterialCnt.ToString(), PVar.PublicParPath);
                            }
                        }
                        else
                        {
                            AddList("没有物料，取下一个物料！");
                            if (PVar.Blogo.MaterialCnt < 12)
                            {
                                PVar.Blogo.MaterialCnt += 1;
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 70;
                            }
                            else
                            {
                                //需要更换物料
                                PVar.Sta_Work[0].Result = false;
                                PVar.Blogo.MaterialCnt = 1;
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 2000;
                            }
                            Frm_Engineering.fEngineering.Text_BlogoNo.Text = PVar.Blogo.MaterialCnt.ToString();
                            Frm_Engineering.fEngineering.TextM_BlogoNo.Text = Frm_Engineering.fEngineering.Text_BlogoNo.Text;
                            BVar.FileRorW.WriteINI("Material_index", "Blogo", PVar.Blogo.MaterialCnt.ToString(), PVar.PublicParPath);
                        }
                        break;

                    case 130:
                        disrow = BVar.DisRow * ((PVar.Blogo.MaterialCnt - 1) % 2);

                        Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[0, 2] + Offset.X, PVar.ParAxis.Speed[BVar.S2_X]);
                        Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[0, 2] + disrow + Offset.Y, PVar.ParAxis.Speed[BVar.S2_Y]);
                        Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 2] + Offset.T, PVar.ParAxis.Speed[BVar.S2_R]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 140;
                        break;

                    case 140:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 150;
                        }
                        break;

                    case 150:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 2], PVar.ParAxis.Speed[BVar.S2_Z]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 160;
                        break;

                    case 160:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.SetDo(1, Gg.OutPut1.取料吸嘴真空吸, 1);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 170;
                        }
                        break;

                    case 170:
                        if (Gg.GetDi(0, Gg.InPut0.吸嘴真空检测) == 1 || PVar.ParList.CheckSts[17])
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 180;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                AddList("吸嘴取料真空吸力没达到！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 170;
                                StaWork.Step = 8000;
                            }
                        }
                        break;

                    case 180:
                        //先慢速提起来
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 2] - 2, 5);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 181;
                        break;

                    case 181:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            if (Gg.GetDi(0, Gg.InPut0.吸嘴真空检测) == 1 || PVar.ParList.CheckSts[17])
                            {
                                if (PVar.Blogo.MaterialCnt < 12)
                                {
                                    PVar.Blogo.MaterialCnt += 1;
                                }
                                else
                                {
                                    //需要更换物料
                                    PVar.Sta_Work[0].Result = false;
                                    PVar.Blogo.MaterialCnt = 1;
                                }
                                Frm_Engineering.fEngineering.Text_BlogoNo.Text = PVar.Blogo.MaterialCnt.ToString();
                                Frm_Engineering.fEngineering.TextM_BlogoNo.Text = Frm_Engineering.fEngineering.Text_BlogoNo.Text;
                                BVar.FileRorW.WriteINI("Material_index", "Blogo", PVar.Blogo.MaterialCnt.ToString(), PVar.PublicParPath);

                                Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 0], PVar.ParAxis.Speed[BVar.S2_Z]);
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 190;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 500)
                                {
                                    Gg.SetDo(1, Gg.OutPut1.取料吸嘴真空吸, 0);
                                    AddList("吸嘴真空吸力没达到！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 150;
                                }
                            }
                        }
                        break;

                    case 190:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[0, 3], PVar.ParAxis.Speed[BVar.S2_X]);
                            Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[0, 3], PVar.ParAxis.Speed[BVar.S2_Y]);
                            Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 3], PVar.ParAxis.Speed[BVar.S2_R]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 200;
                        }
                        break;

                    case 200:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R) && PVar.Sta_Work[1].State == false)
                        {
                            Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 3], PVar.ParAxis.Speed[BVar.S2_Z]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 210;
                        }
                        break;

                    case 210:
                        if (Gg.ZSPD(0, BVar.S2_X))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 220;
                        }
                        break;

                    case 220:
                        if (API.GetTickCount() - TimeOut > 200)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 230;
                        }
                        break;

                    case 230:
                        sRtn = Command.TCP_CCD1_Send(Command.装配角度拍照 + "," + PVar.ParList.Data[7]);

                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 240;
                            }
                            else if (sRtn == 2) //网络链接异常
                            {
                                AddList("网络链接异常！");
                                ShowList("网络链接异常！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 230;
                                StaWork.Step = 8000;
                            }
                            else
                            {
                                AddList("装配角度拍照异常！");
                                ShowList("装配角度拍照异常！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 230;
                                StaWork.Step = 8000;
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 240;
                        }
                        break;

                    case 240:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Command.CCD1_Resule && PVar.CCD1_Data[0] == Command.装配角度拍照)
                            {
                                AddList("装配角度拍照数据收到！");
                                CCD_Vale[2].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[2].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[2].T = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[2].A = Convert.ToDouble(PVar.CCD2_Data[4]);
                                CCD_Vale[2].L = Convert.ToDouble(PVar.CCD2_Data[5]);
                                CCD_Vale[2].Judge = Convert.ToDouble(PVar.CCD2_Data[6]);

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 250;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 2000)
                                {
                                    AddList("等待装配角度拍照数据超时！");
                                    TimeOut = API.GetTickCount();
                                    BufferStep = 230;
                                    StaWork.Step = 8000;
                                }
                            }
                        }
                        else
                        {
                            AddList("装配角度拍照数据收到！");
                            CCD_Vale[2].X = 0;
                            CCD_Vale[2].Y = 0;
                            CCD_Vale[2].T = 0;
                            CCD_Vale[2].Judge = 0;

                            TimeOut = API.GetTickCount();
                            StaWork.Step = 250;
                        }
                        break;

                    case 250:
                        if (CCD_Vale[1].Judge == 0)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 260;
                        }
                        else if (CCD_Vale[1].Judge == 1)
                        {
                            AddList("装配角度拍照模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            BufferStep = 230;
                            StaWork.Step = 8000;
                        }
                        else
                        {
                            AddList("CCD装配角度拍照其他异常！");
                            TimeOut = API.GetTickCount();
                            BufferStep = 230;
                            StaWork.Step = 8000;
                        }
                        break;

                    case 260:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 0], PVar.ParAxis.Speed[BVar.S2_Z]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 270;
                        break;

                    case 270:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[0, 4], PVar.ParAxis.Speed[BVar.S2_X]);
                            Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[0, 4], PVar.ParAxis.Speed[BVar.S2_Y]);
                            Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 4]-30, PVar.ParAxis.Speed[BVar.S2_R]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 280;
                        }
                        break;

                    case 280:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            //:装配上方
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 4], PVar.ParAxis.Speed[BVar.S2_Z]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 290;
                        }
                        break;

                    case 290:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 300;
                        }
                        break;

                    case 300:
                        if (API.GetTickCount() - TimeOut > 200)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 310;
                        }
                        break;


                        //:开始装配
                    case 310:
                        sRtn = Command.TCP_CCD1_Send(Command.装配HSG圆拍照 + "," + PVar.ParList.Data[7]);

                        if (PVar.ParList.CheckSts[17] == false)
                            {
                            if (sRtn == 1) //命令发送成功
                                {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 320;
                                }
                            else if (sRtn == 2) //网络链接异常
                                {
                                AddList("网络链接异常！");
                                ShowList("网络链接异常！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 310;
                                StaWork.Step = 8000;
                                }
                            else
                                {
                                AddList("装配HSG圆拍照异常！");
                                ShowList("装配HSG圆拍照异常！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 310;
                                StaWork.Step = 8000;
                                }
                            }
                        else
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 320;
                            }
                        break;

                    case 320:
                        if (PVar.ParList.CheckSts[17] == false)
                            {
                            if (Command.CCD1_Resule && PVar.CCD1_Data[0] == Command.装配HSG圆拍照)
                                {
                                AddList("装配HSG圆拍照数据收到！");
                                CCD_Vale[3].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[3].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[3].T = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[3].A = Convert.ToDouble(PVar.CCD2_Data[4]);
                                CCD_Vale[3].L = Convert.ToDouble(PVar.CCD2_Data[5]);
                                CCD_Vale[3].Judge = Convert.ToDouble(PVar.CCD2_Data[6]);

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 330;
                                }
                            else
                                {
                                if (API.GetTickCount() - TimeOut > 2000)
                                    {
                                    AddList("等待装配HSG圆拍照数据超时！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 1000;
                                    }
                                }
                            }
                        else
                            {
                            AddList("装配HSG圆拍照数据收到！");
                            CCD_Vale[3].X = 0;
                            CCD_Vale[3].Y = 0;
                            CCD_Vale[3].T = 0;
                            CCD_Vale[3].A = 0;
                            CCD_Vale[3].L = 0;
                            CCD_Vale[3].Judge = 0;

                            TimeOut = API.GetTickCount();
                            StaWork.Step = 330;
                            }

                        break;

                    case 330:
                        if (CCD_Vale[1].Judge == 0)
                            {
                            Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 4], PVar.ParAxis.Speed[BVar.S2_R]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 340;
                            }
                        else if (CCD_Vale[1].Judge == 1)
                            {
                            AddList("装配拍照模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            BufferStep = 310;
                            StaWork.Step = 8000;
                            }
                        else
                            {
                            AddList("CCD装配拍照其他异常！");
                            TimeOut = API.GetTickCount();
                            BufferStep = 310;
                            StaWork.Step = 8000;
                            }
                        break;

                    case 340:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 350;
                            }
                        break;

                    case 350:
                        if (API.GetTickCount() - TimeOut > 200)
                            {
                            T_Count[3] = 0;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 360;
                            }
                        break;

                    case 360:
                        if (T_Count[3] < 15)
                            {
                            sRtn = Command.TCP_CCD1_Send(Command.装配Blogo拍照 + "," + PVar.ParList.Data[7]);
                            T_Count[3]++;

                            if (PVar.ParList.CheckSts[17] == false)
                                {
                                if (sRtn == 1) //命令发送成功
                                    {
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 370;
                                    }
                                else if (sRtn == 2) //网络链接异常
                                    {
                                    AddList("网络链接异常！");
                                    ShowList("网络链接异常！");
                                    TimeOut = API.GetTickCount();
                                    BufferStep = 360;
                                    StaWork.Step = 8000;
                                    }
                                else
                                    {
                                    AddList("装配Blogo拍照异常！");
                                    ShowList("装配Blogo拍照异常！");
                                    TimeOut = API.GetTickCount();
                                    BufferStep = 360;
                                    StaWork.Step = 8000;
                                    }
                                }
                            else
                                {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 370;
                                }
                            }
                        else
                            {
                            AddList("装配Blogo拍照次数超限！");
                            ShowList("装配Blogo拍照次数超限！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 4000;
                            }                    
                        break;

                    case 370:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                        if (Command.CCD1_Resule && PVar.CCD1_Data[0] == Command.装配Blogo拍照)
                            {
                            AddList("装配Blogo拍照数据收到！");

                                CCD_Vale[3].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[3].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[3].T = Convert.ToDouble(PVar.CCD2_Data[3]);
                                CCD_Vale[3].A = Convert.ToDouble(PVar.CCD2_Data[4]);
                                CCD_Vale[3].L = Convert.ToDouble(PVar.CCD2_Data[5]);
                                CCD_Vale[3].Judge = Convert.ToDouble(PVar.CCD2_Data[6]);

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 380;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 2000)
                                {
                                AddList("等待装配Blogo拍照数据超时" + T_Count[3] + "次！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 360;
                                }
                            }
                        }
                        else
                        {
                        AddList("装配Blogo拍照数据收到！");
                            CCD_Vale[3].X = 0;
                            CCD_Vale[3].Y = 0;
                            CCD_Vale[3].T = 0;
                            CCD_Vale[3].A = 0;
                            CCD_Vale[3].L = 0;
                            CCD_Vale[3].Judge = 0;

                            TimeOut = API.GetTickCount();
                            StaWork.Step = 380;
                        }

                        break;

                    case 380:
                        if (CCD_Vale[1].Judge == 0)
                            {
                            if (Math.Abs(CCD_Vale[3].T) < 5 && Math.Abs(CCD_Vale[3].X) < 5 && Math.Abs(CCD_Vale[3].Y) < 5)
                                {
                                if (CCD_Vale[3].T < 0.1 && CCD_Vale[3].X < 0.025 && CCD_Vale[3].Y < 0.025)
                                    {
                                    //:满足精度直接下一步
                                    T_Count[3] = 0;
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 400;
                                    }
                                else
                                    {
                                    //:在上方做一次补正
                                    NewXYT();//计算新的XYT
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 382;
                                    }
                                }
                            else
                                {
                                AddList("装配Blogo拍照补正值超限！");
                                ShowList("装配Blogo拍照补正值超限！");
                                TimeOut = API.GetTickCount();
                                BufferStep = 360;
                                StaWork.Step = 8000;
                                }
                            }
                        else if (CCD_Vale[1].Judge == 1)
                            {
                            AddList("装配Blogo拍照模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            BufferStep = 360;
                            StaWork.Step = 8000;
                            }
                        else
                            {
                            AddList("CCD装配Blogo拍照其他异常！");
                            TimeOut = API.GetTickCount();
                            BufferStep = 360;
                            StaWork.Step = 8000;
                            }
                        break;

                    case 382:
                        if (CCD_Vale[3].T > 0.1)
                            {
                            Gg.StepMotion(0, BVar.S2_X, 10, Offset.X, "+");
                            Gg.StepMotion(0, BVar.S2_Y, 10, Offset.Y, "+");
                            Gg.StepMotion(0, BVar.S2_R, 10, Offset.T, "+");
                            }
                        else
                            {
                            Gg.StepMotion(0, BVar.S2_X, 10, CCD_Vale[3].X, "+");
                            Gg.StepMotion(0, BVar.S2_Y, 10, CCD_Vale[3].Y, "+");
                            //：Gg.StepMotion(0, BVar.S2_R, 10, CCD_Vale[3].T, "+");
                            }
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 384;
                        break;

                    case 384:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 386;
                        }
                        break;

                    case 386:
                        if (API.GetTickCount() - TimeOut > 200)
                            {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 360;
                            }
                        break;

                        //:精补高度
                    case 400:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 4] + PVar.ParList.Data[17], PVar.ParAxis.Speed[BVar.S2_Z]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 410;
                        break;

                    case 410:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 420;
                        }
                        break;

                    case 420:
                        if (API.GetTickCount() - TimeOut > 200)
                        {
                            T_Count[3] = 0;
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 430;
                        }
                        break;

                    case 430:
                        T_Count[3]++;
                        sRtn = Command.TCP_CCD1_Send(Command.装配拍照 + "," + PVar.ParList.Data[7]);

                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (sRtn == 1) //命令发送成功
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 440;
                            }
                            else if (sRtn == 2) //网络链接异常
                            {
                                AddList("网络链接异常！");
                                ShowList("网络链接异常！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                            }
                            else
                            {
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                            }
                        }
                        else
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 440;
                        }
                        break;

                    case 440:
                        if (PVar.ParList.CheckSts[17] == false)
                        {
                            if (Command.CCD1_Resule && PVar.CCD1_Data[0] == Command.装配拍照)
                            {
                                AddList("装配拍照数据收到！");
                                CCD_Vale[3].X = Convert.ToDouble(PVar.CCD2_Data[1]);
                                CCD_Vale[3].Y = Convert.ToDouble(PVar.CCD2_Data[2]);
                                CCD_Vale[3].T = Convert.ToDouble(PVar.CCD2_Data[3]);

                                CCD_Vale[3].Judge = Convert.ToDouble(PVar.CCD2_Data[4]);

                                TimeOut = API.GetTickCount();
                                StaWork.Step = 450;
                            }
                            else
                            {
                                if (API.GetTickCount() - TimeOut > 2000)
                                {
                                    AddList("等待装配拍照数据超时！");
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 1000;
                                }
                            }
                        }
                        else
                        {
                            AddList("装配拍照数据收到！");
                            CCD_Vale[3].X = 0;
                            CCD_Vale[3].Y = 0;
                            CCD_Vale[3].T = 0;
                            CCD_Vale[3].Judge = 0;

                            TimeOut = API.GetTickCount();
                            StaWork.Step = 450;
                        }

                        break;

                    case 450:
                        if (CCD_Vale[1].Judge == 0)
                        {
                            if (CCD_Vale[3].T < 0.5 && CCD_Vale[3].X < 0.15 && CCD_Vale[3].Y < 0.15)
                            {
                                if (CCD_Vale[3].T < 0.5 && CCD_Vale[3].X < 0.01 && CCD_Vale[3].Y < 0.01)
                                {
                                    TimeOut = API.GetTickCount();
                                    StaWork.Step = 500;
                                }
                                else
                                {
                                    if (T_Count[3] < 5)
                                    {
                                        TimeOut = API.GetTickCount();
                                        StaWork.Step = 460;
                                    }
                                    else
                                    {
                                        AddList("装配拍照补正次数超限！");
                                        ShowList("装配拍照补正次数超限！");
                                        TimeOut = API.GetTickCount();
                                        StaWork.Step = 4000;
                                    }
                                }
                            }
                            else
                            {
                                AddList("装配拍照精补补正值超限！");
                                ShowList("装配拍照精补补正值超限！");
                                TimeOut = API.GetTickCount();
                                StaWork.Step = 1000;
                            }
                        }
                        else if (CCD_Vale[1].Judge == 1)
                        {
                            AddList("装配拍照模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                        }
                        else
                        {
                            AddList("CCD装配拍照其他异常！");
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 1000;
                        }
                        break;

                    case 460:
                        Gg.StepMotion(0, BVar.S2_X, 10, CCD_Vale[3].X, "+");
                        Gg.StepMotion(0, BVar.S2_Y, 10, CCD_Vale[3].Y, "+");
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 470;
                        break;

                    case 470:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 480;
                        }
                        break;

                    case 480:
                        if (API.GetTickCount() - TimeOut > 200)
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 430;
                        }
                        break;


                    case 500:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 4], 1);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 510;
                        break;

                    case 510:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.SetDo(1, Gg.OutPut1.取料吸嘴真空吸, 0);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 520;
                        }
                        break;

                    case 520:
                        if (API.GetTickCount() - TimeOut >= PVar.ParList.Data[20] * 1000)
                        {
                            Gg.SetDo(1, Gg.OutPut1.取料吸嘴破真空, 1);
                            Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 0], PVar.ParAxis.Speed[BVar.S2_Z]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 530;
                        }
                        break;

                    case 530:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.SetDo(1, Gg.OutPut1.取料吸嘴破真空, 0);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 800;
                        }
                        break;

                    case 800:
                        StaWork.Enable = false;
                        StaWork.Result = true;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    case 1000:
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        break;

                    //遇到异常，设备先暂停，确定后处理************************
                    case 8000:
                        PVar.IsSystemOnPauseMode = true;
                        PVar.MacHold = true;
                        PVar.Stop_Flag = false;
                        Frm_Main.fMain.Btn_Start.Enabled = false;
                        Frm_Main.fMain.Btn_Pause.Enabled = true;
                        Frm_Main.fMain.Btn_Stop.Enabled = false;
                        Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                        Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                        Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;
                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
                        break;

                    //严重错误，急停处理*************
                    case 10000:
                        Frm_Engineering.fEngineering.MacStop();
                        break;

                    //换料跳转******************
                    case 2000:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[0, 0], PVar.ParAxis.Speed[BVar.S2_Z]);
                        TimeOut = API.GetTickCount();
                        StaWork.Step = 2010;
                        break;
                    //初始位置、换料位置
                    case 2010:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[0, 0], PVar.ParAxis.Speed[BVar.S2_X]);
                            Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[0, 0], PVar.ParAxis.Speed[BVar.S2_Y]);
                            Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[0, 0], PVar.ParAxis.Speed[BVar.S2_R]);
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 2020;
                        }
                        break;

                    case 2020:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            TimeOut = API.GetTickCount();
                            StaWork.Step = 60;
                        }
                        break;

                    case 4000:
                        //装配补正异常退出

                        break;
                }

            }
            catch (Exception exc)
            {
                string Error_Str = "";
                string Error_Str1 = "";
                Frm_Engineering.fEngineering.MacStop();
                MessageBox.Show(exc.Message);
                Error_Str = PVar.BZ_LogPath + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_代码异常记录" + ".txt";
                Error_Str1 = "\r\n" + "※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※※" + "\r\n" +
                    "[" + DateTime.Now.ToString("HH:mm:ss") + "]" + "\r\n" + exc.ToString();
                FileRw.WriteDattxt(Error_Str, Error_Str1);
            }
        }

        private static int NewXYT()
        {
            double tmpX;
            double tmpY;
            double radT;
            double radA;
            double radAT;
            double mPI = 3.1415926535897931;
            double L_Arm = CCD_Vale[3].L;

            Offset.T = CCD_Vale[3].T;

            radT = Offset.T * mPI / 180;
            radA = Offset.A * mPI / 180;
            radAT = (Offset.A + Offset.T) * mPI / 180;

            tmpX = -(L_Arm * System.Math.Sin(radAT) - L_Arm * System.Math.Sin(radA));
            tmpY = (L_Arm * (1 - System.Math.Cos(radAT)) - L_Arm * (1 - System.Math.Cos(radA)));

            Offset.X = CCD_Vale[3].X + tmpX;
            Offset.Y = CCD_Vale[3].Y + tmpY;
            return 1;
        } 
    }
}
