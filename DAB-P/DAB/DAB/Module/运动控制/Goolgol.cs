using System;

namespace DAB
{
    sealed class Gg
    {
        public static event Action<string> ShowList;    // this.Dialog_OnAdd(s)
        public static event Action<string> AddList;     //this.infoList1.List_OnAdd(s)
        private static object LockMotion = new object();  


        #region 参数定义
        public static bool[] CardOpenFlag = new bool[9];
        private static double[,] TmplVel = new double[5, 9];

        public struct sLnXYZR //四维直线插补，结构体参数
        {
            public short CardNum;
            public short crd;
            //public double X;
            //public double Y;
            //public double Z;
            //public double R;
            public double synVel;
            public double synAcc;
            public double velEnd;
            public short fifo;
        }
        #endregion

        #region 运动控制卡初始化

        public static bool GTS_MotionInit(short CardNum, short AxisNum, string CFG)
        {
            short GT_rtn;

            lock (LockMotion)
            GT_rtn = gts.GT_SetCardNo(CardNum);
            if (CardOpenFlag[CardNum] == false)
            {
                GT_rtn = gts.GT_Open(CardNum, 0, 1);
                if (GT_rtn == 0)
                {
                    CardOpenFlag[CardNum] = true;
                    AddList("运动控制卡" + Convert.ToString(CardNum) + "打开成功！");
                }
                else
                {
                    CardOpenFlag[CardNum] = false;
                    ShowList("运动控制卡" + Convert.ToString(CardNum) + "打开失败！");
                    AddList("运动控制卡" + Convert.ToString(CardNum) + "打开失败！");
                    return false;
                }
            }
            GT_rtn = gts.GT_Reset((short)CardNum); //复位运动控制器
            GT_rtn = gts.GT_LoadConfig((short)CardNum, CFG); //载入运动控制器轴配置文件

            if (GT_rtn == 0)
            {
                AddList(CardNum + "号卡配置文件载入成功！");
                return true;
            }
            else
            {
                AddList(CardNum + "号卡配置文件载入失败！");
                ShowList("运动控制卡" + Convert.ToString(CardNum) + "配置文件载入失败！");
                return false;
            }
        }

        /// <summary>
        /// gts运动控制卡IO扩展模块初始化
        /// </summary>
        /// <returns>布尔</returns>
        /// <remarks>全局变量Get_ExtDoBit</remarks>
        public static bool GTS_ExtmdlInit(short CardNum, string CFG)
        {
            short GT_rtn = 0;

            lock (LockMotion)
            GT_rtn = gts.GT_OpenExtMdlGts((short)0, "gts.dll");
            if (GT_rtn != 0)
            {
                AddList("扩展IO模块打开失败！");
                ShowList("扩展IO模块打开失败！");
                CardOpenFlag[CardNum] = false;
                return false;
            }
            else
            {
                AddList("扩展IO模块打开成功！");
                GT_rtn = gts.GT_ResetExtMdlGts((short)0);
                GT_rtn = gts.GT_LoadExtConfigGts((short)0, CFG);
                if (GT_rtn != 0)
                {
                    AddList("扩展IO配置文件打开失败！");
                    ShowList("扩展IO配置文件打开失败！");
                    CardOpenFlag[CardNum] = false;
                    return false;
                }
                else
                {
                    AddList("扩展IO配置文件打开成功！");
                    CardOpenFlag[CardNum] = true;
                    return true;
                }
            }
        }

        #endregion

        #region 伺服使能

        /// <summary>
        /// 伺服使能
        /// </summary>
        /// <param name="CardNum">卡编号(0~n)</param>
        /// <param name="FirstAxis">卡起始轴编号(1~n)</param>
        /// <param name="LastAxis">卡末端轴编号</param>
        /// <returns>布尔</returns>
        /// <remarks></remarks>
        public static bool Set_AllServoON(short CardNum, short FirstAxis, short LastAxis)
        {
            short rtn;
            short i = (short)0;

            lock (LockMotion)
            for (i = FirstAxis; i <= LastAxis; i++)
            {
                rtn = gts.GT_ClrSts(CardNum, i, (short)1); //清除轴的报警标志
                rtn = gts.GT_SynchAxisPos(CardNum, i); //同步当前卡所有轴的规划位置和编码器位置
                rtn = gts.GT_SetAxisBand(CardNum, i, 500, 20); //设置卡所有轴的到位误差带(5毫秒内500个脉冲)
                rtn = gts.GT_AxisOn(CardNum, i); //打开轴的伺服使能
                if (rtn == 0) //使能
                {
                    AddList(BVar.Axisname[CardNum * 8 + i - 1] + "轴伺服ON打开成功！");
                }
                else
                {
                    AddList(BVar.Axisname[CardNum * 8 + i - 1] + "轴伺服ON打开失败！");
                    ShowList(BVar.Axisname[CardNum * 8 + i - 1] + "轴伺服ON打开失败！");
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region IO汉化定义

        public enum InPut0
        {
            //*0号卡
            机械手准备好 = 1,
            机械手运动中 = 2,
            机械手暂停中 = 3,
            机械手报警 = 4,
            正气压信号侦测 = 5,
            安全门 = 6,


            启动按钮 = 9,
            左接近传感器 = 10,
            右接近传感器 = 11,
            阻挡气缸1伸出 = 12,
            阻挡气缸2伸出 = 13,
            阻挡气缸3伸出 = 14,
            急停按钮 = 15
        }

        public enum InPut1
        {
        //*扩展模块1
            载具夹紧气缸伸出 = 0,
            载具夹紧气缸缩回 = 1,
            保压无杆气缸左 = 2,
            保压无杆气缸右 = 3,
            机械手滑台气缸伸出 = 4,
            机械手滑台气缸缩回 = 5,
            机械手撕膜升降气缸伸出 = 6,
            机械手撕膜升降气缸缩回 = 7,
            撕膜夹爪气缸张开 = 8,
            撕膜夹爪气缸闭合 = 9,
            PSA料仓夹紧气缸伸出 = 10,
            PSA料仓夹紧气缸缩回 = 11,
            PSA吸嘴升降气缸上 = 12,
            PSA吸嘴升降气缸下 = 13,
            光源旋转气缸伸出 = 14,
            光源旋转气缸缩回 = 15 
        }

        public enum InPut2
        {
            //*扩展模块2
            PSA载台真空吸检测信号 = 0,
            搬运PSA真空吸检测信号 = 1,
            载具上产品真空吸检测信号 = 2,
            机械手排线真空吸检测信号 = 3,
            机械手吸嘴真空吸检测信号 = 4,
            机械手夹爪吸膜真空吸检测信号 = 5, 
            //  = 6,
            流水线对射感应1 = 7,
            流水线对射感应2 = 8,
            流水线对射感应3 = 9,
            流水线对射感应4 = 10,
            流水线对射感应5 = 11,
            //  = 12,
            PSA料仓上层感应 = 13,
            PSA料仓下层感应 = 14,
            PSA料仓到位感应信号 = 15
        }

        public enum InPut3
            {
            //*扩展模块3
            //  = 0,
            //  = 1,
            左料仓最上层感应信号 = 2,
            左料仓最下层感应信号 = 3,
            右料仓最上层感应信号 = 4,
            右料仓最下层感应信号 = 5,
            料盘搬运层感应信号 = 6,
            //   = 7,
            //   = 8,
            左料仓到位感应信号 = 9,
            右料仓到位感应信号 = 10,
            料盘夹紧气缸张开 = 11,
            料盘夹紧气缸夹紧 = 12,
            料盘平移无杆气缸左 = 13,
            料盘平移无杆气缸右 = 14,
            //  = 15
            }
        ////===================================================        
        public enum OutPut0
        {
            //*0号卡
            机械手启动 = 0,
            机械手停止 = 1,
            机械手暂停 = 2,
            机械手继续 = 3,
            机械手复位 = 4, 
            红色警示灯 = 5,
            黄色警示灯 = 6,
            绿色警示灯 = 7,
            警示蜂鸣器 = 8,
            步进电机使能 = 9,
            启动按钮指示灯 = 10,
            //载具破真空3 = 11,
            阻挡气缸1 = 12,
            阻挡气缸2 = 13,
            阻挡气缸3 = 14,
            日光灯继电器 = 15 
        }

        public enum OutPut1
        {
        //*扩展模块1
            载具夹紧气缸 = 0,
            //  = 1, 
            保压无杆气缸左 = 2,
            保压无杆气缸右 = 3,
            机械手滑台气缸 = 4,
            机械手撕膜针型气缸 = 5,
            机械手撕膜升降气缸 = 6,
            //  = 7,
            撕膜夹爪气缸 = 8,
            //  = 9,
            PSA料仓夹紧气缸 = 10,
            //  = 11,
            PSA吸嘴升降气缸 = 12,
            //  = 13,
            光源旋转气缸 = 14,
            //  = 15,

        }

        public enum OutPut2
        {
            //*扩展模块2
            PSA载台真空吸 = 0,
            PSA载台破真空 = 1,
            搬运PSA真空吸 = 2,
            搬运PSA破真空 = 3,
            载具上产品真空吸 = 4,
            载具上产品破真空 = 5,
            机械手排线真空吸 = 6,
            机械手排线破真空 = 7,
            机械手吸嘴真空吸 = 8,
            机械手吸嘴破真空 = 9,
            机械手夹爪吸膜真空吸 = 10,
            机械手夹爪吸膜破真空 = 11,
            OK指示灯 = 12,
            NG指示灯 = 13,
            左料盘吸电磁铁 = 14, 
            右料盘吸电磁铁 = 15
        }

        public enum OutPut3
            {
            //*扩展模块3

            料盘夹紧气缸张开 = 11,
            料盘夹紧气缸夹紧 = 12,
            料盘平移无杆气缸左 = 13,
            料盘平移无杆气缸右 = 14,
            离子风扇 = 15
            }
        public enum InAlarm0
        {
            //*0号卡
            流水线1 = 1,
            流水线2 = 2,
            流水线3 = 3,
            保压Z轴 = 4, 
            料仓左Z轴 = 5,
            料仓右Z轴 = 6,
            PSA供料Z轴 = 7,
            PSA搬运Y轴 = 8,
        } 
        public enum InAlarm1
        {
            //*1号卡
            //R轴 = 1,
        }
        #endregion

        #region IO操作
        /// <summary>
        /// 获取板卡IO[卡号][0-15][1：有输入,0无]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetDi(int CardNum, System.ValueType i)
        {
            short di = Convert.ToInt16(i);
            int CardExI = 0;

            lock (LockMotion)
            gts.GT_GetDi((short)CardNum, gts.MC_GPI, out CardExI);
            if ((CardExI & (1 << di)) == 0)
            {
                return (short)0;
            }
            else
            {
                return (short)1;
            }
        }

        /// <summary>
        /// 读取通用输出：1卡号[0,1]，2索引[0,15]；  返回值：1输出打开，0输出关闭
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetDo(short CardNum, System.ValueType i)
        {
            short di = Convert.ToInt16(i);
            int CardExO = 0;

            lock (LockMotion)
            gts.GT_GetDo(CardNum, gts.MC_GPO, out CardExO);
            if ((CardExO & (1 << di)) == 0)
            {
                return (short)1;
            }
            else
            {
                return (short)0;
            }
        }

        /// <summary>
        /// 设置通用输出:[卡号],[0,15],[1：打开输出，0：关闭输出]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="doIndex"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool SetDo(short CardNum, System.ValueType doIndex, short i) //''''''''''''''''''''''''''''''''''
        {
            short di = Convert.ToInt16(doIndex);

            lock (LockMotion)
            gts.GT_SetDoBit(CardNum, gts.MC_GPO, (short)(di + 1), (short)(1 - i));
            return true;
        }

        /// <summary>
        /// 读取扩展输入：GetExDi(模块[0,255]，IO口[0,15]）返回值：0没有输入，1有输入
        /// </summary>
        /// <param name="mdl"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetExDi(short mdl, System.ValueType i)
        {
            ushort CardExI = 0;
            short CardNum = 0;
            short di = Convert.ToInt16(i);

            lock (LockMotion)
            gts.GT_GetExtIoValueGts(CardNum, mdl, ref CardExI);
            if ((CardExI & (1 << di)) == 0)
            {
                return (short)1;
            }
            else
            {
                return (short)0;
            }
        }

        /// <summary>
        /// 读取扩展输出[模块0-？，输出0-15]
        /// </summary>
        /// <param name="mdl"></param>主卡上的第几张扩扎卡
        /// <param name="i"></param>读取的IO号
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetExDo(short mdl, System.ValueType i) //''''''''''''''''''''''''''''
        {
            ushort CardExO = 0;
            short di = Convert.ToInt16(i);

            lock (LockMotion)
            gts.GT_GetExtDoValueGts(0, mdl, ref CardExO);
            if ((CardExO & (1 << di)) == 0)
            {
                return (short)1;
            }
            else
            {
                return (short)0;
            }
        }

        /// <summary>
        /// 设置扩展输出：[板卡号],[IO模块(0开始)], [端口号(0开始)],[输出值：1打开，0关闭)]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Mdl"></param>
        /// <param name="Index"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool SetExDo(short CardNum, short Mdl, System.ValueType Index, short i) //'''''''''''''''设置扩展模块输出IO的电平
        {
            short di = Convert.ToInt16(Index);

            lock (LockMotion)
            gts.GT_SetExtIoBitGts(CardNum, Mdl, di, (ushort)(1 - i));
            return true;
        }

        /// <summary>
        /// 清除各轴的报警,限位和读取轴状态
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="mAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int GetSts(short CardNum, short mAxis)
        {
            int CarGetSts = 0;
            uint temp_pClock = 0;

            lock (LockMotion)
            try
            {
                gts.GT_ClrSts(CardNum, mAxis, (short)1); //清除各轴的报警和限位
                gts.GT_GetSts(CardNum, mAxis, out CarGetSts, (short)1, out temp_pClock); //读取轴状态
                return CarGetSts;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 读取轴使能状态:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetServoOnDi(short CardNum, short Axis)
        {
            int ServoOnSts = 0;

            lock (LockMotion)
            try
            {
                uint temp_pClock = 0;
                gts.GT_GetSts(CardNum, Axis, out ServoOnSts, (short)1, out temp_pClock);
                if ((ServoOnSts & 0x200) == 0)
                {
                    return (short)0;
                }
                else
                {
                    return (short)1;
                }
            }
            catch (Exception)
            {
                return (short)0;
            }
        }

        /// <summary>
        /// 读取原点信号:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetHomeDi(int CardNum, short Axis) //读取原点信号
        {
            int CarHomeDi = 0;

            lock (LockMotion)
            gts.GT_GetDi((short)CardNum, gts.MC_HOME, out CarHomeDi);
            if ((CarHomeDi & (1 << (Axis - 1))) == 0)
            {
                return (short)0;
            }
            else
            {
                return (short)1;
            }
        }

        /// <summary>
        /// 读取驱动报警:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short Get_AlarmDi(int CardNum, System.ValueType Axis) //读取驱动报警
        {
            int CarAxisAlarm = 0;
            short di = Convert.ToInt16(Axis);

            lock (LockMotion)
            gts.GT_GetDi((short)CardNum, gts.MC_ALARM, out CarAxisAlarm);
            if ((CarAxisAlarm & (1 << (di - 1))) == 0)
            {
                return (short)0;
            }
            else
            {
                return (short)1;
            }
        }

        /// <summary>
        /// 读取正限位:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetLimitDi_Z(short CardNum, short Axis) //读取正限位
        {
            int CarLimitZ = 0;

            lock (LockMotion)
            gts.GT_GetDi(CardNum, gts.MC_LIMIT_POSITIVE, out CarLimitZ);
            if ((CarLimitZ & (1 << (Axis - 1))) == 0)
            {
                return (short)0;
            }
            else
            {
                return (short)1;
            }
        }

        /// <summary>
        /// 读取负限位:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static short GetLimitDi_F(short CardNum, short Axis) //读取负限位
        {
            int CarLimitF = 0;

            lock (LockMotion)
            PVar.Rtn = gts.GT_GetDi(CardNum, gts.MC_LIMIT_NEGATIVE, out CarLimitF);
            if ((CarLimitF & (1 << (Axis - 1))) == 0)
            {
                return (short)0;
            }
            else
            {
                return (short)1;
            }
        }

        /// <summary>
        /// 判断马达是否停止运动【目标位置和编码器位置差在0.2mm内】
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool ZSPD(short CardNum, short Axis) //'''判断马达是否停止运动
        {
            bool returnValue = false;
            int AxisStatus = 0;
            uint temp_pClock = 0;

            lock (LockMotion)
            PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out AxisStatus, (short)1, out temp_pClock);
            if (!(System.Convert.ToBoolean(AxisStatus & 0x400) == true))
            {
                gts.GT_GetPos(CardNum, Axis,out Tools.AxisTmplPos[CardNum, Axis]);
                if (System.Math.Abs(Tools.AxisTmplPos[CardNum, Axis] - Gg.GetEncPos(CardNum, Axis)) > 200)
                {
                    returnValue = false;
                }
                else
                {
                    returnValue = true;
                }
            }
            else
            {
                returnValue = false;
            }
            return returnValue;
        }

        #endregion

        #region 获取位置
        /// <summary>
        /// 获取编码器位置,单位plus
        /// 参数:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="gCardNum"></param>
        /// <param name="gAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int GetEncPos(short gCardNum, short gAxis)
            {
            double CarEncPos = 0;

            lock (LockMotion)
                try
                    {
                    uint temp_pClock = 0;
                    if (gAxis == 8)
                        {
                        PVar.Rtn = gts.GT_GetEncPos(gCardNum, gAxis, out CarEncPos, 1, out temp_pClock); //读取编码器位置
                        }
                    else
                        {
                        PVar.Rtn = gts.GT_GetPrfPos(gCardNum, gAxis, out CarEncPos, 1, out temp_pClock); //读取规划器位置
                        }
                    return (int)CarEncPos; //强制类型转换
                    }
                catch (Exception)
                    {
                    return 0;
                    }
            }

        /// <summary>
        /// 获取算好的编码器位置，单位mm
        /// 参数:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="gtsardNum"></param>
        /// <param name="mAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static double GetEncPosmm(short gtsardNum, short mAxis)
        {
            double returnValue = 0;
            lock (LockMotion)
            try
            {
                returnValue = GetEncPos(gtsardNum, mAxis) / PlusPerUnit(gtsardNum, mAxis) / Tools.GeerRate[gtsardNum, mAxis];
            }
            catch (Exception)
            {
                return 0;
            }
            return returnValue;
        }

        /// <summary>
        /// 获取规划器位置,单位plus
        /// 参数:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="gtsardNum"></param>
        /// <param name="mAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int GetPrfPos(short gtsardNum, short mAxis)
        {
            double CarPrfPos = 0;
            lock (LockMotion)
            try
            {
                uint temp_pClock = 0;
                PVar.Rtn = (gts.GT_GetPrfPos(gtsardNum, mAxis, out CarPrfPos, (short)1, out temp_pClock)); //读取规划器位置
                return (int)CarPrfPos; //'强制类型转换
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// 获取算好的规划器位置,单位mm
        /// 参数:[卡号0-4],[轴号1-8]
        /// </summary>
        /// <param name="gtsardNum"></param>
        /// <param name="mAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static double GetPrfPosmm(short gtsardNum, short mAxis)
        {
            double returnValue = 0;
            lock (LockMotion)
            try
            {
                returnValue = GetPrfPos(gtsardNum, mAxis) / PlusPerUnit(gtsardNum, mAxis) / Tools.GeerRate[gtsardNum, mAxis];
            }
            catch (Exception)
            {
                return 0;
            }
            return returnValue;
        }

        /// <summary>
        /// 每1mm的脉冲数：丝杆导成，减速比，每圈脉冲数，PlusPerUnit(卡号[0-1] ,轴号[1-8] )
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="AxisNum"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static double PlusPerUnit(short CardNum, short AxisNum)
        {
            double pPlusPerUnit = 0;
            lock (LockMotion)
            pPlusPerUnit = 1 / Tools.LeadLength[CardNum, AxisNum] * Tools.PlusPerR[CardNum, AxisNum];
            return pPlusPerUnit;
        }

        /// <summary>
        /// 把距离或角度转换成脉冲
        /// </summary>
        /// <param name="gtsard"></param>
        /// <param name="mAxis"></param>
        /// <param name="mDist"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static int GetDist(short gtsard, short mAxis, double mDist)
        {
        lock (LockMotion)
            try
            {
                return Convert.ToInt32((mDist / Tools.LeadLength[gtsard, mAxis]) * Tools.GeerRate[gtsard, mAxis] * Tools.PlusPerR[gtsard, mAxis]);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static double GetVel(short gtsard, short mAxis, double mVel)
        {
        lock (LockMotion)
            try
            {
                return (mVel / Tools.LeadLength[gtsard, mAxis]) * Tools.GeerRate[gtsard, mAxis] * Tools.PlusPerR[gtsard, mAxis] / 1000;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

        #region 运控函数
        //STEP单步运动模式子程序
        /// <summary>
        /// 参数:[卡号0-4],[轴号1-8],[速度],[移动相对距离],[方向]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <param name="Vel"></param>
        /// <param name="Dist"></param>
        /// <param name="Direction"></param>
        /// <remarks></remarks>
        public static void StepMotion(short CardNum, short Axis, double Vel, double Dist, string Direction)
        {          
            short Dir_Renamed = 0;
            double PrfPosTmpl = 0;

            //lock (LockMotion)
            if (Direction == "+") //当前轴正向运动方向判定
            {
                Dir_Renamed = (short)1;
            }
            else
            {
                Dir_Renamed = (short)(-1);
            }
            PrfPosTmpl = GetPrfPosmm(CardNum, Axis) + Dir_Renamed * Dist;
            AbsMotion(CardNum, Axis, PrfPosTmpl, Vel);
        }

        //JOG连续运动模式子程序
        /// <summary>
        /// 参数:[卡号0-4],[轴号1-8],[速度],[方向]
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="Axis"></param>
        /// <param name="Vel"></param>
        /// <param name="Direction"></param>
        /// <remarks></remarks>
        public static void JogMotion(short CardNum, short Axis, int Vel, string Direction)
        {
            short Dir_Renamed = 0;
            double Vel_JSpeed = 0;
            gts.TJogPrm JogPrm = new gts.TJogPrm();
            lock (LockMotion)
            if (Direction == "+") //当前轴正向运动方向判定
            {
                Dir_Renamed = (short)1;
            }
            else if (Direction == "-")
            {
                Dir_Renamed = (short)(-1);
            }
            Vel_JSpeed = GetVel(CardNum, Axis, Vel * Dir_Renamed);
            gts.GT_PrfJog(CardNum, Axis);
            gts.GT_GetJogPrm(CardNum, Axis, out JogPrm);
            JogPrm.acc = 1;
            JogPrm.dec = 1;
            gts.GT_SetJogPrm(CardNum, Axis, ref JogPrm);
            gts.GT_SetVel(CardNum, Axis, Vel_JSpeed); //设置当前轴的目标速度
            gts.GT_Update(CardNum, (1 << (Axis - 1))); //启动当前轴运动
        }

        //ABS绝对运动模式子程序，参数1：轴号；参数2：速度；参数3：相对于原点的位移距离
        /// <summary>
        /// 参数:[卡号0-4],[轴号1-8],[相对于原点的位移距离],[速度]
        /// </summary>
        /// <param name="aCardNum"></param>
        /// <param name="aAxis"></param>
        /// <param name="aPosition"></param>
        /// <param name="Vel"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool AbsMotion(short aCardNum, short aAxis, double aPosition, double Vel)
        {
            gts.TTrapPrm ATrapPrm = new gts.TTrapPrm();
            double Vel_ASpeed = 0;

            lock (LockMotion)
            gts.GT_PrfTrap(aCardNum, aAxis); //设置指定轴为点位模式
            gts.GT_GetTrapPrm(aCardNum, aAxis, out ATrapPrm); //读取点位模式运动参数
            if (GoHome.AxisHome[aCardNum, aAxis].State)
            {
                ATrapPrm.acc = 0.25; //点位运动的加速度。正数，单位：pulse/ms2。
                ATrapPrm.dec = 0.125; //点位运动的减速度。正数，单位：pulse/ms2。
                ATrapPrm.smoothTime = (short)25;
            }
            else
            {
                ATrapPrm.acc = 1;
                ATrapPrm.dec = 1;
                ATrapPrm.smoothTime = (short)25;
            }
            gts.GT_SetTrapPrm(aCardNum, aAxis, ref ATrapPrm); //设置点位模式运动参数
            Vel_ASpeed = GetVel(aCardNum, aAxis, Vel);
            //Tools.AxisTmplPos[aCardNum, aAxis] = GetDist(aCardNum, aAxis, aPosition);
            gts.GT_SetPos(aCardNum, aAxis, GetDist(aCardNum, aAxis, aPosition)); //设置目标位置
            gts.GT_SetVel(aCardNum, aAxis, Vel_ASpeed); //设置目标速度
            gts.GT_Update(aCardNum, (1 << (aAxis - 1))); //启动当前轴运动
            return true;
        }

        /// <summary>
        /// 停止轴运动（设置运动速度为0模式）
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="mAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool AxisStop(short CardNum, short mAxis)
        {
            try
            {
                Tools.AxisTmplPos[CardNum, mAxis] = GetDist(CardNum, mAxis, GetPrfPos(CardNum, mAxis));
                gts.GT_SetVel(CardNum, mAxis, 0); //设置目标速度
                gts.GT_Update(CardNum, (1 << (mAxis - 1))); //启动当前轴运动
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool GetPrfVel(short CardNum, short mAxis)
        {
            try
            {
                uint null_UInt = 0;
                gts.GT_GetPrfVel(CardNum, mAxis, out TmplVel[CardNum, mAxis], (short)1, out null_UInt); //获取规划器速度
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 恢复轴运动（速度0-->原有的速度）
        /// </summary>
        /// <param name="CardNum"></param>
        /// <param name="mAxis"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool AxisStart(short CardNum, short mAxis)
        {
            try
            {
                if (TmplVel[CardNum, mAxis] > 5)
                {

                }
                else
                {
                    TmplVel[CardNum, mAxis] = 10;
                }
                PVar.Rtn = (gts.GT_SetVel(CardNum, mAxis, TmplVel[CardNum, mAxis])); //设置目标速度
                PVar.Rtn = (gts.GT_Update(CardNum, (1 << (mAxis - 1)))); //启动当前轴运动
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void XYZR_Motion(short CardNum, short AxisX, short AxisY, short AxisZ, short AxisR, double X0, double Y0, double Z0, double R0, double Radius_Glue, double Z_Vertical_Angle, double Speed, int PointNum, short AngleEx)
        {
            short i = 0;
            gts.TCrdPrm CrdPrm = new gts.TCrdPrm(); //声明坐标系结构体参数
            sLnXYZR cLnXYZR = new sLnXYZR(); //声明4维直线插补结构体参数

            double XYZR_Speed = 0; //四轴合成速度
            int[] PosXEnd = new int[1001]; //X轴直线终点位置(脉冲数)
            int[] PosYEnd = new int[1001]; //Y轴直线终点位置(脉冲数)
            int[] PosZEnd = new int[1001]; //X轴直线终点位置(脉冲数)
            int[] PosREnd = new int[1001]; //Y轴直线终点位置(脉冲数)
            double AngleTem = 0;
            short Num_Seg = 0;

            //    n = UBound(Array_XY)
            Tools.Pi = 4 * System.Math.Atan(1);
            CrdPrm.dimension = (short)4; //指定坐标系维数为4(X、Y、Z、R的4维插补)
            CrdPrm.synVelMax = 1000; //该坐标系最大合成速度(Pulse/ms)
            CrdPrm.synAccMax = 0.2; //该坐标系最大合成加速度(Pulse/ms^2)
            CrdPrm.evenTime = (short)50; //每个插补段的最小匀速段时间(ms)
            CrdPrm.profile1 = AxisX; //坐标系X维映射相应的规划轴
            switch (AxisX)
            {
                case (short)1:
                    CrdPrm.profile1 = (short)1;
                    CrdPrm.originPos1 = 0;
                    break;
                case (short)2:
                    CrdPrm.profile2 = (short)1;
                    CrdPrm.originPos2 = 0;
                    break;
                case (short)3:
                    CrdPrm.profile3 = (short)1;
                    CrdPrm.originPos3 = 0;
                    break;
                case (short)4:
                    CrdPrm.profile4 = (short)1;
                    CrdPrm.originPos4 = 0;
                    break;
                case (short)5:
                    CrdPrm.profile5 = (short)1;
                    CrdPrm.originPos5 = 0;
                    break;
                case (short)6:
                    CrdPrm.profile6 = (short)1;
                    CrdPrm.originPos6 = 0;
                    break;
                case (short)7:
                    CrdPrm.profile7 = (short)1;
                    CrdPrm.originPos7 = 0;
                    break;
                case (short)8:
                    CrdPrm.profile8 = (short)1;
                    CrdPrm.originPos8 = 0;
                    break;
            }
            switch (AxisY)
            {
                case (short)1:
                    CrdPrm.profile1 = (short)2;
                    CrdPrm.originPos1 = 0;
                    break;
                case (short)2:
                    CrdPrm.profile2 = (short)2;
                    CrdPrm.originPos2 = 0;
                    break;
                case (short)3:
                    CrdPrm.profile3 = (short)2;
                    CrdPrm.originPos3 = 0;
                    break;
                case (short)4:
                    CrdPrm.profile4 = (short)2;
                    CrdPrm.originPos4 = 0;
                    break;
                case (short)5:
                    CrdPrm.profile5 = (short)2;
                    CrdPrm.originPos5 = 0;
                    break;
                case (short)6:
                    CrdPrm.profile6 = (short)2;
                    CrdPrm.originPos6 = 0;
                    break;
                case (short)7:
                    CrdPrm.profile7 = (short)2;
                    CrdPrm.originPos7 = 0;
                    break;
                case (short)8:
                    CrdPrm.profile8 = (short)2;
                    CrdPrm.originPos8 = 0;
                    break;
            }
            switch (AxisZ)
            {
                case (short)1:
                    CrdPrm.profile1 = (short)3;
                    CrdPrm.originPos1 = 0;
                    break;
                case (short)2:
                    CrdPrm.profile2 = (short)3;
                    CrdPrm.originPos2 = 0;
                    break;
                case (short)3:
                    CrdPrm.profile3 = (short)3;
                    CrdPrm.originPos3 = 0;
                    break;
                case (short)4:
                    CrdPrm.profile4 = (short)3;
                    CrdPrm.originPos4 = 0;
                    break;
                case (short)5:
                    CrdPrm.profile5 = (short)3;
                    CrdPrm.originPos5 = 0;
                    break;
                case (short)6:
                    CrdPrm.profile6 = (short)3;
                    CrdPrm.originPos6 = 0;
                    break;
                case (short)7:
                    CrdPrm.profile7 = (short)3;
                    CrdPrm.originPos7 = 0;
                    break;
                case (short)8:
                    CrdPrm.profile8 = (short)3;
                    CrdPrm.originPos8 = 0;
                    break;
            }
            switch (AxisR)
            {
                case (short)1:
                    CrdPrm.profile1 = (short)4;
                    CrdPrm.originPos1 = 0;
                    break;
                case (short)2:
                    CrdPrm.profile2 = (short)4;
                    CrdPrm.originPos2 = 0;
                    break;
                case (short)3:
                    CrdPrm.profile3 = (short)4;
                    CrdPrm.originPos3 = 0;
                    break;
                case (short)4:
                    CrdPrm.profile4 = (short)4;
                    CrdPrm.originPos4 = 0;
                    break;
                case (short)5:
                    CrdPrm.profile5 = (short)4;
                    CrdPrm.originPos5 = 0;
                    break;
                case (short)6:
                    CrdPrm.profile6 = (short)4;
                    CrdPrm.originPos6 = 0;
                    break;
                case (short)7:
                    CrdPrm.profile7 = (short)4;
                    CrdPrm.originPos7 = 0;
                    break;
                case (short)8:
                    CrdPrm.profile8 = (short)4;
                    CrdPrm.originPos8 = 0;
                    break;
            }
            //        .profile1 = AxisX   '坐标系Y维映射相应的规划轴
            //        .profile2 = AxisY   '坐标系Y维映射相应的规划轴
            //        .profile3 = AxisZ   '坐标系Y维映射相应的规划轴
            //        .profile4 = AxisR   '坐标系R维映射相应的规划轴
            CrdPrm.setOriginFlag = (short)1; //需要明确指定坐标系原点的位置(为0则用当前规划位置作为坐标系的原点)
            //        .originPos1 = 0     '指定X维坐标系原点(为0则和机械原点重合)
            //        .originPos2 = 0     '指定Y维坐标系原点(为0则和机械原点重合)
            //        .originPos3 = 0     '指定Z维坐标系原点(为0则和机械原点重合)
            //        .originPos4 = 0     '指定R维坐标系原点(为0则和机械原点重合)
            PVar.Rtn = (gts.GT_SetCrdPrm(CardNum, (short)1, ref CrdPrm)); //建立坐标系1
            if (PVar.Rtn != 0) //判断坐标系建立是否成功
            {
                return;
            }

            //    XYZR_Speed = CDbl(Speed / LeadLength(AxisX) * PlusPerR(AxisX) * GeerRate(AxisX) / 1000) '计算合成目标速度(Pluse/ms)
            //    XYZR_Speed = CDbl(Speed / LeadLength(AxisX) * PlusPerR(AxisX) * GeerRate(AxisX) / 1000 * 10) '计算合成目标速度(Pluse/ms)
            XYZR_Speed = 360 / (2 * Tools.Pi * Radius_Glue / Speed) / 360 * Tools.PlusPerR[0, AxisR] * Tools.GeerRate[0, AxisR] / 1000; //计算合成目标速度(Pluse/ms)

            for (i = 0; i <= PointNum; i++)
            {
                AngleTem = (double)(360 + AngleEx) / PointNum * i;
                PosXEnd[i] = (int)(X0 + Radius_Glue * System.Math.Cos(AngleTem / 180 * Tools.Pi) * Tools.PlusPerR[0, AxisX] * Tools.GeerRate[0, AxisX] / Tools.LeadLength[0, AxisX]); //X直线终点坐标(Pluse)
                PosYEnd[i] = (int)(Y0 + Radius_Glue * System.Math.Sin(AngleTem / 180 * Tools.Pi) * Tools.PlusPerR[0, AxisY] * Tools.GeerRate[0, AxisY] / Tools.LeadLength[0, AxisY]); //X直线终点坐标(Pluse)
                PosZEnd[i] = (int)(Z0 + (Math.Pow(System.Math.Cos(AngleTem / 180 * Tools.Pi / 2), 2) * 2 * Radius_Glue * System.Math.Sin(Z_Vertical_Angle / 180 * Tools.Pi) - Radius_Glue * System.Math.Sin(Z_Vertical_Angle / 180 * Tools.Pi)) * Tools.PlusPerR[0, AxisZ] * Tools.GeerRate[0, AxisZ] / Tools.LeadLength[0, AxisZ]);
                PosREnd[i] = (int)(R0 + AngleTem / 360 * Tools.PlusPerR[0, AxisR] * Tools.GeerRate[0, AxisR]);
            }
            cLnXYZR.CardNum = CardNum; //指定坐标系的卡号
            cLnXYZR.crd = (short)1; //指定坐标系号
            //.X = PosXEnd            '直线X终点坐标
            //.Y = PosYEnd            '直线Y终点坐标
            cLnXYZR.synVel = XYZR_Speed; //合成目标速度
            cLnXYZR.synAcc = 0.15; //合成加速度
            cLnXYZR.velEnd = XYZR_Speed; //终点速度
            cLnXYZR.fifo = (short)0; //缓冲区选择
            PVar.Rtn = (gts.GT_CrdClear(cLnXYZR.CardNum, cLnXYZR.crd, cLnXYZR.fifo)); //清除FIFO
            Num_Seg = (short)((AngleEx / ((double)360 / PointNum) / 2));
            for (i = 0; i <= PointNum; i++) //向FIFO循环压入插补运动数据
            {
                if (i >= 0 && i <= PointNum)
                {
                    PVar.Rtn = (gts.GT_LnXYZA(cLnXYZR.CardNum, cLnXYZR.crd, PosXEnd[i], PosYEnd[i], PosZEnd[i], PosREnd[i], cLnXYZR.synVel, cLnXYZR.synAcc, cLnXYZR.velEnd, cLnXYZR.fifo));
                    if (i == PointNum - Num_Seg)
                    {
                        //GT_BufIO(short cardNum,short crd,ushort doType,ushort doMask,ushort doValue,short fifo);
                        //PublicVariable.Rtn = gts.GT_BufIO(cLnXYZR.CardNum, cLnXYZR.crd, gts.gts_GPO, System.Convert.ToInt16(Math.Pow(2, 11)), System.Convert.ToInt16(Math.Pow(2, 11)), cLnXYZR.fifo); //倒数第2段插补数据之后关闭点胶
                    }
                }
            }
            PVar.Rtn = (gts.GT_LnXYZA(cLnXYZR.CardNum, cLnXYZR.crd, System.Convert.ToInt32(PosXEnd[PointNum] + 0.08 / Tools.LeadLength[0, AxisX] * Tools.PlusPerR[0, AxisX] * Tools.GeerRate[0, AxisX]), PosYEnd[PointNum], PosZEnd[PointNum], PosREnd[PointNum], cLnXYZR.synVel, cLnXYZR.synAcc, cLnXYZR.velEnd, cLnXYZR.fifo));
            PVar.Rtn = (gts.GT_CrdStart(cLnXYZR.CardNum, cLnXYZR.crd, cLnXYZR.fifo)); //启动坐标系1的4维直线插补运动
        }
        #endregion

    }

}
