
using System;

namespace DAB
    {

    public sealed class Manual
        {

        //public static event Action<string> ShowList;
        //private static PVar.CCDDataType CCD_Vale;
        //private static sOffset Offset;
        //private struct sOffset
        //    {
        //    public double X;
        //    public double Y;
        //    public double T;
        //    }
        #region 普通变量
        //private static int TimeOut = 0;
        //private static int Count = 0; 
        public static bool[] AutoMotionFlag = new bool[10]; //是否在单自动运行中标志 
        public static bool[] MotionFlag = new bool[10]; //是否在单步点位运行中标志
        public static bool[] HoldFlag = new bool[10]; //暂停标志
        public static bool[] StopFlag = new bool[10]; //停止标志

        public static bool[,] Manual_Result = new bool[21, 21]; //单站单点位置运动结果
        public static int[,] Manual_Step = new int[21, 21]; //单站单点位置运动步序号

        #endregion

        #region 【料仓工站】

        //【Tag1】初始位置
        public static void S2_MotionPos0(ref bool Status, int m, int n)
            { 
            switch (Manual_Step[m, n])
                {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.料仓左Z轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.料仓左Z轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.料仓左Z轴))
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

        //【Tag1】满盘(10盘)定位位置,//单盘(1盘)定位位置    
        public static void S2_MotionPos1(ref bool Status, int m, int n)
            { 
            switch (Manual_Step[m, n])
                {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.料仓左Z轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.料仓左Z轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.料仓左Z轴))
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

        //【Tag2】料盘右仓初始位置   
        public static void S3_MotionPos0(ref bool Status, int m, int n)
            {
            switch (Manual_Step[m, n])
                {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.料仓右Z轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.料仓右Z轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.料仓右Z轴))
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

        //【Tag2】满载(10盘)收料位置 //空载(1盘)收料位置    
        public static void S3_MotionPos1(ref bool Status, int m, int n)
            {
            switch (Manual_Step[m, n])
                {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.料仓右Z轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.料仓右Z轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.料仓右Z轴))
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

        //【Tag3】//PSA【Z】轴初始位置    //PSA【Z】轴单片位置
        public static void S4_MotionPos0(ref bool Status, int m, int n)
            {
            switch (Manual_Step[m, n])
                {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.PSA供料Z轴))
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

        //【Tag3】//PSA【Y】轴吸料位置  //PSA【Y】轴放料位置  //PSA【Y】轴费料位置
        public static void S5_MotionPos0(ref bool Status, int m, int n)
            {
            switch (Manual_Step[m, n])
                {
                case 0: 
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.PSA搬运Y轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.PSA搬运Y轴))
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

        //【Tag4】//初始位置  //保压位置
        public static void S6_MotionPos0(ref bool Status, int m, int n)
            { 
            switch (Manual_Step[m, n])
                {
                case 0:
                    Status = true;
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 1:
                    Gg.AbsMotion(0, Axis.保压Z轴, mFunction.Pos.TeachAxis1[m, n], PVar.ParAxis.Speed[Axis.保压Z轴]);
                    Manual_Step[m, n] = Manual_Step[m, n] + 1;
                    break;

                case 2:
                    if (Gg.ZSPD(0, Axis.保压Z轴))
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
