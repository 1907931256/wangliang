using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB
    {
    class Linechange
        {
        public static bool SetMotor1(bool MotorON, double Speed)
            {
            if (MotorON)
                {
                if (PVar.ParList.CheckSts[3]) //左机
                    {
                    Gg.JogMotion(0, Axis.流水线3, (int)Speed, "-");
                    }
                else
                    {
                    Gg.JogMotion(0, Axis.流水线1, (int)Speed, "+");
                    }
                }
            else
                {
                if (PVar.ParList.CheckSts[3]) //左右机切换
                    {
                    //Gg.AxisStop(0,1);
                    gts.GT_Stop(0, 1 << (Axis.流水线3 - 1), 1 << (Axis.流水线1 - 1));
                    }
                else
                    {
                    //Gg.AxisStop(0, 3);
                    gts.GT_Stop(0, 1 << (Axis.流水线1 - 1), 1 << (Axis.流水线3 - 1));
                    }
                }
            return MotorON;
            }

        public static bool SetMotor2(bool MotorON, double Speed)
            {
            if (MotorON)
                {
                    if (PVar.ParList.CheckSts[3]) //左机
                    {
                        Gg.JogMotion(0, Axis.流水线2, (int)Speed, "-");
                    }
                    else
                    {
                        Gg.JogMotion(0, Axis.流水线2, (int)Speed, "+");
                    }
                }
            else
                {
                Gg.AxisStop(0, Axis.流水线2);
                }
            return MotorON;
            }

        public static bool SetMotor3(bool MotorON, double  Speed)
            {
            if (MotorON)
                {
                if (PVar.ParList.CheckSts[3]) //左右机切换
                    {
                    Gg.JogMotion(0, Axis.流水线1, (int)Speed, "-");//PVar.ParList.Data[43]
                    }
                else
                    {
                    Gg.JogMotion(0, Axis.流水线3, (int)Speed, "+");
                    }
                }
            else
                {
                if (PVar.ParList.CheckSts[3]) //左右机切换
                    {
                    Gg.AxisStop(0, Axis.流水线1);
                    }
                else
                    {
                    Gg.AxisStop(0, Axis.流水线3);
                    }
                }
            return MotorON;
            }

        public static int LineIN()
            {
            int mValue = 0;
            if (PVar.ParList.CheckSts[3]) //左右机切换
                {
                mValue = Gg.GetDi(0, Gg.InPut0.右接近传感器);
                }
            else
                {
                mValue = Gg.GetDi(0, Gg.InPut0.左接近传感器);
                }
            return mValue;
            }

        public static int LineOut()
            {
            int mValue = 0;
            if (PVar.ParList.CheckSts[3]) //左右机切换
                {
                mValue = Gg.GetDi(0, Gg.InPut0.左接近传感器);
                }
            else
                {
                mValue = Gg.GetDi(0, Gg.InPut0.右接近传感器);
                }
            return mValue;
            }



        }
    }
