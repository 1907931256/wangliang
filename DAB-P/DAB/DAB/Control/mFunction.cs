
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

namespace DAB
    {
    sealed class mFunction //配合用户控件，必备
        {
        public static event Action<string> ShowList;    // this.Dialog_OnAdd(s)
        public struct mPostion
            {
            public string[,] N;
            /// <summary>
            /// Teach控件1轴[Tag号],[点位编号]
            /// </summary>
            /// <remarks></remarks>
            public double[,] TeachAxis1;
            /// <summary>
            /// Teach控件2轴[Tag号],[点位编号]
            /// </summary>
            /// <remarks></remarks>
            public double[,] TeachAxis2;
            /// <summary>
            /// Teach控件3轴[Tag号],[点位编号]
            /// </summary>
            /// <remarks></remarks>
            public double[,] TeachAxis3;
            /// <summary>
            /// Teach控件4轴[Tag号],[点位编号]
            /// </summary>
            /// <remarks></remarks>
            public double[,] TeachAxis4;
            }
        //Teach控件Tag：轴块（4个一组）顺序号（0-7）
        //行对应的是每个tag值,列对应的是每个tag上的 X Y Z R对应的【板卡中的轴号1-8】
        public static short[,] mAxis = new short[,] 
            {
            {0, 1, 2, 3, 4}, 
            {1, 5, 0, 0, 0}, 
            {2, 6, 0, 0, 0}, 
            {3, 8, 7, 0, 0},
            {4, 4, 0, 0, 0}};

        //行对应的是每个tag值,列对应的是每个tag上的X Y Z R轴号对应的【卡号0-3】
        public static short[,] mCard = new short[,] 
           {{0, 0, 0, 0, 0}, 
            {1, 0, 0, 0, 0}, 
            {2, 0, 0, 0, 0}, 
            {3, 0, 0, 0, 0},
            {4, 0, 0, 0, 0}};

        public static mPostion Pos;

        public static bool mSetDO(int CardTag, int Index, int Value)
            {
            //      CardIndex              CardInfo
            //控件  TabIndex  代表卡类型， Tag(A,B) A代表卡号，B代表模块序号（0-15）；
            //CardType=0 固高卡自带IO,CardType=1 固高卡扩展IO。
            int CardType = 0;
            string CardInfo = "0,0";
            int CardIndex = 0;
            int CardNum = 0;
            switch (CardTag)
                {
                case 0: //0号输入单元
                    CardType = 0; //固高卡通用输出
                    CardInfo = "0,0";
                    break;
                case 1: //1号输入单元
                    CardType = 1;
                    CardInfo = "0,0";
                    break;
                case 2: //2号输入单元
                    CardType = 1;
                    CardInfo = "0,1";
                    break;
                case 3: //3号输入单元
                    CardType = 1;
                    CardInfo = "0,2";
                    break;
                case 4: //3号输入单元
                    CardType = 1;
                    CardInfo = "0,3";
                    break;

                }
            CardNum = System.Convert.ToInt32(CardInfo.Substring(0, 1));
            CardIndex = System.Convert.ToInt32(CardInfo.Substring(CardInfo.Length - 1, 1));
            try
                {
                switch (CardType)
                    {
                    case 0:
                        PVar.Rtn = gts.GT_SetDoBit((short)CardNum, gts.MC_GPO, (short)(Index + 1), (short)(Math.Abs(Value - 1)));
                        break;
                    case 1:
                        PVar.Rtn = gts.GT_SetExtIoBitGts((short)CardNum, (short)CardIndex, (short)Index, (ushort)Math.Abs(Value - 1));
                        break;
                    }
                }
            catch (Exception)
                {
                return false;
                }
            return true;
            }

        public static bool NPSetDO(int CardType, int CardNum, int Mdl, int Index)
            {
            try
                {
                switch (CardType)
                    {
                    case 0:
                        PVar.Rtn = gts.GT_SetDoBit((short)CardNum, gts.MC_GPO, (short)(Index + 1), (short)0);
                        break;
                    case 1:
                        PVar.Rtn = gts.GT_SetExtIoBitGts((short)CardNum, (short)Mdl, (short)Index, 0);
                        break;
                    }

                WinAPI.Wait(500);

                switch (CardType)
                    {
                    case 0:
                        PVar.Rtn = gts.GT_SetDoBit((short)CardNum, gts.MC_GPO, (short)(Index + 1), (short)1);
                        break;
                    case 1:
                        PVar.Rtn = gts.GT_SetExtIoBitGts((short)CardNum, (short)Mdl, (short)Index, 1);
                        break;
                    }

                }
            catch (Exception)
                {
                return false;
                }
            return true;
            }

        /// <summary>
        /// 参数：[0板卡，1扩展模块]，[板卡号0-2]，[模块号0-3]，[输出端口号0-15]
        /// </summary>
        /// <param name="CardType"></param>
        /// <param name="CardNum"></param>
        /// <param name="Mdl"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool NSetDO(int CardType, int CardNum, int Mdl, int Index)
            {
            try
                {
                switch (CardType)
                    {
                    case 0:
                        if (Gg.GetDo((short)CardNum, (short)Index) == 1)
                            {
                            Gg.SetDo((short)CardNum, (short)Index, (short)0);
                            }
                        else
                            {
                            Gg.SetDo((short)CardNum, (short)Index, (short)1);
                            }
                        break;
                    case 1:
                        if (Gg.GetExDo((short)Mdl, (short)Index) == 1)
                            {
                            Gg.SetExDo(0, (short)Mdl, (short)Index, (short)0);
                            }
                        else
                            {
                            Gg.SetExDo(0, (short)Mdl, (short)Index, (short)1);
                            }
                        break;
                    }

                }
            catch (Exception)
                {
                return false;
                }
            return true;
            }

        /// <summary>
        /// 参数：[0板卡，1扩展模块]，[板卡号0-2]，[模块号0-3]，[输出端口号0-15]
        /// </summary>
        /// <param name="CardType"></param>
        /// <param name="CardNum"></param>
        /// <param name="Mdl"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int NGetDO(int CardType, int CardNum, int Mdl, int Index)
            {
            int st = 0;
            try
                {
                switch (CardType)
                    {
                    case 0:
                        if (Gg.GetDo((short)CardNum, (short)Index) == 1)
                            {
                            st = 1;
                            }
                        else
                            {
                            st = 0;
                            }
                        break;
                    case 1:
                        if (Gg.GetExDo((short)Mdl, (short)Index) == 1)
                            {
                            st = 1;
                            }
                        else
                            {
                            st = 0;
                            }
                        break;
                    }

                }
            catch (Exception)
                {
                return st;
                }
            return st;
            }

        public static short mGetDO(int CardTag, int index)
            {
            //      CardIndex              CardInfo
            //控件  TabIndex  代表卡类型， Tag(A,B) A代表卡号，B代表模块序号（0-15）；
            //CardType=0 固高卡自带IO,CardType=1 固高卡扩展IO。
            int CardType = 0;
            string CardInfo = "0,0";
            int CardIndex = 0;
            int CardNum = 0;
            int ReturnStr = 0;
            switch (CardTag)
                {
                case 0: //0号输入单元
                    CardType = 0;
                    CardInfo = "0,0";
                    break;
                case 1: //1号输入单元
                    CardType = 1;
                    CardInfo = "0,0";
                    break;
                case 2: //3号输入单元
                    CardType = 1;
                    CardInfo = "0,1";
                    break;
                case 3: //3号输入单元
                    CardType = 1;
                    CardInfo = "0,2";
                    break;
                }
            CardNum = System.Convert.ToInt32(CardInfo.Substring(0, 1));
            CardIndex = System.Convert.ToInt32(CardInfo.Substring(CardInfo.Length - 1, 1));
            try
                {
                switch (CardType)
                    {
                    case 0:
                        ReturnStr = Math.Abs(Gg.GetDo((short)CardNum, (short)index));
                        break;
                    case 1:
                        ReturnStr = Math.Abs(Gg.GetExDo((short)CardIndex, (short)index));
                        break;
                    }
                }
            catch (Exception)
                {
                ReturnStr = 0;
                }
            return (short)ReturnStr;
            }

        public static short mGetDi(short CardTag, short index)
            {
            //      CardIndex              CardInfo
            //控件  TabIndex  代表卡类型， Tag(A,B) A代表卡号，B代表模块序号（0-15）；
            //CardType=0 固高卡自带IO,CardType=1 固高卡扩展IO。
            int CardType = 0;
            string CardInfo = "0,0";
            short CardIndex = 0;
            short CardNum = 0;
            ushort ReturnStr = 0;
            short mGetDiValue = -1;
            switch (CardTag)
                {
                case 0: //0号输入单元
                    CardType = 0;
                    CardInfo = "0,0";
                    break;
                case 1: //0号输入单元
                    CardType = 1;
                    CardInfo = "0,0";
                    break;
                case 2:
                    CardType = 1;
                    CardInfo = "0,1"; //卡号，index
                    break;
                case 3:
                    CardType = 1;
                    CardInfo = "0,2"; //卡号，index
                    break;
                }
            CardNum = System.Convert.ToInt16(CardInfo.Substring(0, 1));
            CardIndex = System.Convert.ToInt16(CardInfo.Substring(CardInfo.Length - 1, 1));
            try
                {
                switch (CardType)
                    {
                    case 0: //固高卡自带通用输入
                        mGetDiValue = Gg.GetDi(CardNum, index);
                        break;
                    case 1: //固高卡扩展输入
                        PVar.Rtn = gts.GT_GetExtIoBitGts(CardNum, CardIndex, index, ref ReturnStr);
                        mGetDiValue = (short)Math.Abs(ReturnStr - 1);
                        break;
                    }
                }
            catch (Exception)
                {
                mGetDiValue = -1;
                }
            return mGetDiValue;
            }

        public static bool mServoON(short CardTag, short CardNum, short AxisIndex)
            {
            //      CardType                 CardInfo
            //控件  TabIndex  代表卡号，     Tag(A,B) A=0代表“固高”，A=1代表其它类型,B代表轴/模块序列号；
            //B代表扩展IO序号（0-15）。
            int CardType = 0;
            switch (CardTag)
                {
                case 0: //0号卡
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    CardType = 0; //固高运动控制卡卡
                    break;
                default: //1号卡
                    CardType = 1;
                    break;
                }
            try
                {
                switch (CardType)
                    {
                    case 0: //固高运动控制卡卡
                        int Sts = 0;
                        PVar.Rtn = gts.GT_ClrSts(CardNum, AxisIndex, 1); //清除轴的报警和限位
                        uint null_UInt32 = 0;
                        PVar.Rtn = gts.GT_GetSts(CardNum, AxisIndex, out Sts, (short)1, out null_UInt32); //读取轴状态

                        if (Convert.ToBoolean(Sts & 0x200))
                            {
                            //If ZSPD(CardNum, AxisIndex) = False Then
                            //    ShowList(CardNum & "号卡第" & AxisIndex & "轴，正在运动中")
                            //End If
                            if (CardNum == 0 && AxisIndex == 3)
                                {
                                Gg.SetDo(0, 4, 0);

                                }

                            PVar.Rtn = gts.GT_AxisOff(CardNum, AxisIndex);
                            gts.GT_Stop(CardNum, 1 << (AxisIndex - 1), 0);
                            GoHome.AxisHome[CardNum, AxisIndex].Step = 0;
                            }
                        else
                            {
                            PVar.Rtn = gts.GT_AxisOn((short)CardNum, AxisIndex);
                            PVar.Rtn = gts.GT_SetPrfPos(CardNum, AxisIndex, Gg.GetEncPos((short)CardNum, AxisIndex));
                            PVar.Rtn = gts.GT_SynchAxisPos((short)CardNum, 1 << ((AxisIndex) - 1)); //将当前轴进行位置同步
                            uint null_UInt322 = 0;
                            PVar.Rtn = gts.GT_GetSts(CardNum, AxisIndex, out Sts, (short)1, out null_UInt322); //读取轴状态
                            if ((Sts & 0x200) == 0)
                                {
                                ShowList(BVar.Axisname[CardNum * 8 + AxisIndex - 1] + "伺服ON打开失败");
                                }
                            else
                                {

                                }
                            }
                        break;
                    case 1:
                        break;

                    }
                }
            catch (Exception)
                {
                return false;
                }
            return true;
            }

        public static void ReDimData()
            {
            Pos.N = new string[9, 100];
            Pos.TeachAxis1 = new double[9, 100];
            Pos.TeachAxis2 = new double[9, 100];
            Pos.TeachAxis3 = new double[9, 100];
            Pos.TeachAxis4 = new double[9, 100];
            }

        #region ReadDatFile
        //读DAT二进制文件
        //参数1：文件名(包含文件路径)
        //参数2：读取的数据存储地址
        public static void ReadPosData(string FileName, System.ValueType ReadData)
            {
            int Filenumber = 0;
            ReDimData();
            try
                {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                Microsoft.VisualBasic.FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                FileSystem.FileGet(Filenumber, ref ReadData);
                mFunction.Pos = (mFunction.mPostion)ReadData;
                Microsoft.VisualBasic.FileSystem.FileClose(Filenumber); //读取完成关闭当前打开的文件
                PVar.IsReadPosData = true;
                }
            catch
                {
                FileSystem.FileClose(Filenumber); //读取出错关闭当前打开的文件
                }
            }
        #endregion

        #region WriteDatFile
        //写DAT二进制文件
        //参数1：文件名(包含文件路径)
        //参数2：需要写入的数据
        public static void WritePosData(string FileName, mPostion WriteData)
            {
            int Filenumber = 0;
            try
                {
                Filenumber = FileSystem.FreeFile(); //获取空闲可用的文件号
                FileSystem.FileOpen(Filenumber, FileName, OpenMode.Binary); //以二进制的形式打开文件
                //long lens = FileSystem.LOF(Filenumber);
                FileSystem.FilePut(Filenumber, WriteData);
                FileSystem.FileClose(Filenumber); //写入完成关闭当前打开的文件
                }
            catch
                {
                FileSystem.FileClose(Filenumber); //写入出错关闭当前打开的文件
                }
            }
        #endregion

        }

    }
