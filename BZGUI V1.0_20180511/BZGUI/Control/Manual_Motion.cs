
using System;

namespace BZGUI
{

    public sealed class Manual
    {

        public static event Action<string> ShowList;
        private static PVar.CCDDataType CCD_Vale;
        private static sOffset Offset;
        private struct sOffset
        {
            public double X;
            public double Y;
            public double T;
        }
        #region 普通变量
        private static int TimeOut = 0;
        public static bool[] MotionFlag = new bool[10]; //是否在单步点位运行中标志
        public static bool[] HoldFlag = new bool[10]; //暂停标志
        public static bool[] StopFlag = new bool[10]; //停止标志

        public static bool[,] Manual_Result = new bool[21, 21]; //单站单点位置运动结果
        public static int[,] Manual_Step = new int[21, 21]; //单站单点位置运动步序号

        #endregion

        #region 【B-logo装配工站】


        //【Tag0】到待机位置
        public static void S2_MotionPos0(ref bool Status, int m, int n)
        {
            switch (Manual_Step[m, n])
            {
                //Z轴原点位置=>X/Y/R轴初始位置=>Z轴初始位置
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, BVar.S2_Z, 0, PVar.ParAxis.Speed[BVar.S2_Z]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, BVar.S2_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 3:
                    Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[BVar.S2_X]);
                    Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[m, n], PVar.ParAxis.Speed[BVar.S2_Y]);
                    Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[m, n], PVar.ParAxis.Speed[BVar.S2_R]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 4:
                    if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_Z) && Gg.ZSPD(0, BVar.S2_R))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 5:
                    Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[m, n], PVar.ParAxis.Speed[BVar.S2_Z]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 6:
                    if (Gg.ZSPD(0, BVar.S2_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 7:
                    Manual_Step[m, n] = 1000;
                    break;

                case 1000:
                    Manual_Step[m, n] = 0;
                    Status = false;
                    break;

            }
        }

        //【Tag0】取料拍照位置、取料位置
        private static double disrow = 0;
        private static double discell = 0;
        public static void S2_MotionPos1(ref bool Status, int m, int n)
        {
            if (n == 1 || (n == 2 && Frm_Engineering.fEngineering.CheckBox_NeedCCD.Checked == false))
            {
                switch (Manual_Step[m, n])
                {
                    //Z轴原点位置=>X/Y/R轴初始位置=>Z轴初始位置
                    case 0:
                        Status = true;
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 1:
                        Gg.AbsMotion(0, BVar.S2_Z, 0, PVar.ParAxis.Speed[BVar.S2_Z]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 2:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 3:
                        disrow = BVar.DisRow * ((PVar.Blogo.MaterialCnt - 1) % 2);//判断所在行
                        discell = BVar.DisCell * ((PVar.Blogo.MaterialCnt - 1) / 2);//判断所在列

                        Gg.AbsMotion(0, BVar.S2L_Z, mFunction.Pos.TeachAxis3[3, 3] - discell, PVar.ParAxis.Speed[BVar.S2L_Z]);

                        Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[BVar.S2_X]);
                        Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[m, n] + disrow, PVar.ParAxis.Speed[BVar.S2_Y]);
                        Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[m, n], PVar.ParAxis.Speed[BVar.S2_R]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 4:
                        if (Gg.ZSPD(0, BVar.S2L_Z) && Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_Z) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 5:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[m, n], PVar.ParAxis.Speed[BVar.S2_Z]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 6:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 7:
                        Manual_Step[m, n] = 1000;
                        break;

                    case 1000:
                        Manual_Step[m, n] = 0;
                        Status = false;
                        break;
                }
            }
            else if (n == 2 && Frm_Engineering.fEngineering.CheckBox_NeedCCD.Checked)//取料位置：先CCD拍照后取料
            {
                int sRtn;
                switch (Manual_Step[m, n])
                {
                    //Z轴原点位置=>X/Y/R轴初始位置=>Z轴初始位置
                    case 0:
                        Status = true;
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 1:
                        Gg.AbsMotion(0, BVar.S2_Z, 0, PVar.ParAxis.Speed[BVar.S2_Z]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 2:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 3:
                        disrow = BVar.DisRow * ((PVar.Blogo.MaterialCnt - 1) % 2);//判断所在行
                        discell = BVar.DisCell * ((PVar.Blogo.MaterialCnt - 1) / 2);//判断所在列

                        Gg.AbsMotion(0, BVar.S2L_Z, mFunction.Pos.TeachAxis3[3, 3] - discell, PVar.ParAxis.Speed[BVar.S2L_Z]);

                        //拍照位置
                        Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[m, n - 1], PVar.ParAxis.Speed[BVar.S2_X]);
                        Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[m, n - 1] + disrow, PVar.ParAxis.Speed[BVar.S2_Y]);
                        Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[m, n - 1], PVar.ParAxis.Speed[BVar.S2_R]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 4:
                        if (Gg.ZSPD(0, BVar.S2L_Z) && Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_Z) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 5:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[m, n - 1], PVar.ParAxis.Speed[BVar.S2_Z]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 6:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 7:
                        if (API.GetTickCount() - TimeOut > 200)
                        {
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 8:
                        sRtn = Command.TCP_CCD1_Send(Command.取料拍照 + "," + PVar.ParList.Data[7]);

                        if (sRtn == 1) //命令发送成功
                        {
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        else if (sRtn == 2) //网络链接异常
                        {
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = 1000;
                        }
                        else
                        {
                            ShowList("取料拍照命令发送失败！");
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = 1000;
                        }
                        break;

                    case 9:
                        if (Command.CCD1_Resule && PVar.CCD1_Data[0] == Command.取料拍照)
                        {
                            CCD_Vale.X = Convert.ToDouble(PVar.CCD1_Data[1]);
                            CCD_Vale.Y = Convert.ToDouble(PVar.CCD1_Data[2]);
                            CCD_Vale.T = Convert.ToDouble(PVar.CCD1_Data[3]);
                            CCD_Vale.Judge = Convert.ToDouble(PVar.CCD1_Data[4]);

                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        else
                        {
                            if (API.GetTickCount() - TimeOut > 2000)
                            {
                                ShowList("等待取料拍照数据超时！");
                                TimeOut = API.GetTickCount();
                                Manual_Step[m, n] = 1000;
                            }
                        }
                        Manual_Step[m, n] = 1000;
                        break;

                    case 10:
                        if (CCD_Vale.Judge == 0)
                        {
                            if (CCD_Vale.X > -5 && CCD_Vale.X < 1.5 && Math.Abs(CCD_Vale.Y) < 1.5 && Math.Abs(CCD_Vale.T) < 5)
                            {

                                double tmpX;
                                double tmpY;
                                double mT;
                                double mPI = 3.1415926535897931;
                                double L_Arm = PVar.ParList.Data[9];

                                Offset.T = CCD_Vale.T + PVar.ParList.Data[7]; ;
                                mT = Offset.T * mPI / 180;
                                tmpX = -L_Arm * (1 - System.Math.Cos(mT));
                                tmpY = -L_Arm * System.Math.Sin(mT);

                                Offset.X = CCD_Vale.X + tmpX + PVar.ParList.Data[5];
                                Offset.Y = CCD_Vale.Y + tmpY + PVar.ParList.Data[6];
                                TimeOut = API.GetTickCount();
                                Manual_Step[m, n] = Manual_Step[m, n] + 1;
                            }
                            else
                            {
                                ShowList("物料偏移值过大！");
                                TimeOut = API.GetTickCount();
                                Manual_Step[m, n] = 1000;
                            }
                        }
                        else
                        {
                            ShowList("模型搜索错误！");
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = 1000;
                        }
                        break;

                    case 11:
                        disrow = BVar.DisRow * ((PVar.Blogo.MaterialCnt - 1) % 2);

                        Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[m, n] + Offset.X, PVar.ParAxis.Speed[BVar.S2_X]);
                        Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[m, n] + disrow + Offset.Y, PVar.ParAxis.Speed[BVar.S2_Y]);
                        Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[m, n] + Offset.T, PVar.ParAxis.Speed[BVar.S2_R]);
                        TimeOut = API.GetTickCount();
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 12:
                        if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_R))
                        {
                            TimeOut = API.GetTickCount();
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 13:
                        Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[m, n], PVar.ParAxis.Speed[BVar.S2_Z]);
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        break;

                    case 14:
                        if (Gg.ZSPD(0, BVar.S2_Z))
                        {
                            Manual_Step[m, n] = Manual_Step[m, n] + 1;
                        }
                        break;

                    case 15:
                        Manual_Step[m, n] = 1000;
                        break;

                    case 1000:
                        Manual_Step[m, n] = 0;
                        Status = false;
                        break;
                }
            }

        }

        //【Tag0】拍HSG角度位置、装配位置
        public static void S2_MotionPos3(ref bool Status, int m, int n)
        {
            switch (Manual_Step[m, n])
            {
                //Z轴原点位置=>X/Y/R轴初始位置=>Z轴初始位置
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, BVar.S2_Z, 0, PVar.ParAxis.Speed[BVar.S2_Z]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, BVar.S2_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 3:
                    Gg.AbsMotion(0, BVar.S2_X, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[BVar.S2_X]);
                    Gg.AbsMotion(0, BVar.S2_Y, mFunction.Pos.TeachAxis2[m, n], PVar.ParAxis.Speed[BVar.S2_Y]);
                    Gg.AbsMotion(0, BVar.S2_R, mFunction.Pos.TeachAxis4[m, n], PVar.ParAxis.Speed[BVar.S2_R]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 4:
                    if (Gg.ZSPD(0, BVar.S2_X) && Gg.ZSPD(0, BVar.S2_Y) && Gg.ZSPD(0, BVar.S2_Z) && Gg.ZSPD(0, BVar.S2_R))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 5:
                    Gg.AbsMotion(0, BVar.S2_Z, mFunction.Pos.TeachAxis3[m, n], PVar.ParAxis.Speed[BVar.S2_Z]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 6:
                    if (Gg.ZSPD(0, BVar.S2_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 7:
                    Manual_Step[m, n] = 1000;
                    break;

                case 1000:
                    Manual_Step[m, n] = 0;
                    Status = false;
                    break;

            }
        }
        #endregion


        #region 【保压工站】

        //【Tag1】到待机位置、保压位置
        public static void S3_MotionPos0(ref bool Status, int m, int n)
        {
            switch (Manual_Step[m, n])
            {
                //Z轴原点位置=>X/Y/R轴初始位置=>Z轴初始位置
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, BVar.S3_Z, mFunction.Pos.TeachAxis1[m, n], 20);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, BVar.S3_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 3:
                    Manual_Step[m, n] = 1000;
                    break;

                case 1000:
                    Manual_Step[m, n] = 0;
                    Status = false;
                    break;

            }
        }

        #endregion


        #region 【供料工站】


        //【Tag3】取片料位置、放片料位置、抛片料位置
        public static void S0_MotionPos0(ref bool Status, int m, int n)
        {
            switch (Manual_Step[m, n])
            {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, BVar.S2G_Y, mFunction.Pos.TeachAxis1[m, n], 20);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, BVar.S2G_Y))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 3:
                    Manual_Step[m, n] = 1000;
                    break;

                case 1000:
                    Manual_Step[m, n] = 0;
                    Status = false;
                    break;

            }
        }

        //【Tag3】拉料起始位置
        public static void S0_MotionPos3(ref bool Status, int m, int n)
        {
            switch (Manual_Step[m, n])
            {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, BVar.S2L_Z, mFunction.Pos.TeachAxis3[m, n], 20);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, BVar.S2L_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 3:
                    Manual_Step[m, n] = 1000;
                    break;

                case 1000:
                    Manual_Step[m, n] = 0;
                    Status = false;
                    break;

            }
        }

        //【Tag3】顶片料起始位置、顶片料结束位置
        public static void S0_MotionPos4(ref bool Status, int m, int n)
        {
            switch (Manual_Step[m, n])
            {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, BVar.S2G_Z, mFunction.Pos.TeachAxis2[m, n], 20);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, BVar.S2G_Z))
                    {
                        Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    }
                    break;

                case 3:
                    Manual_Step[m, n] = 1000;
                    break;

                case 1000:
                    Manual_Step[m, n] = 0;
                    Status = false;
                    break;

            }
        }

        #endregion

    }


}
