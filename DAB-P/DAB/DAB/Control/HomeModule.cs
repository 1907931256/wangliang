
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

namespace BAM
{
	sealed class HomeModule
	{
		/// <summary>
		/// 定义回原点参数
		/// </summary>
		/// <remarks></remarks>
		public static void HomeValueInt()
		{
			//保压站X
			Tools.HomeSearchDist[0, 4] = 1000; //原点搜索距离
			Tools.HomeOffsetDist[0, 4] = -5; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[0, 4] = -30; //极限到原点的距离
			Tools.HomeOffset[0, 4] = -2; //回完原点后偏移距离
			Tools.HomeVal_1[0, 4] = 10; //第一段回原点搜索速度
			Tools.HomeVal_2[0, 4] = 1; //第二段回原点搜索速度
			//保压站Y
			Tools.HomeSearchDist[0, 5] = -1000; //原点搜索距离
			Tools.HomeOffsetDist[0, 5] = 5; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[0, 5] = 30; //极限到原点的距离
			Tools.HomeOffset[0, 5] = 2; //回完原点后偏移距离
			Tools.HomeVal_1[0, 5] = 10; //第一段回原点搜索速度
			Tools.HomeVal_2[0, 5] = 1; //第二段回原点搜索速度
			//保压站Z
			Tools.HomeSearchDist[0, 6] = -1000; //原点搜索距离
			Tools.HomeOffsetDist[0, 6] = 2; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[0, 6] = 25; //极限到原点的距离
			Tools.HomeOffset[0, 6] = -10; //回完原点后偏移距离
			Tools.HomeVal_1[0, 6] = 10; //第一段回原点搜索速度
			Tools.HomeVal_2[0, 6] = 1; //第二段回原点搜索速度
			//保压站R
			Tools.HomeSearchDist[0, 7] = 360; //原点搜索距离
			Tools.HomeOffsetDist[0, 7] = -5; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[0, 7] = -120; //极限到原点的距离
			Tools.HomeOffset[0, 7] = 0; //回完原点后偏移距离
			Tools.HomeVal_1[0, 7] = 30; //第一段回原点搜索速度
			Tools.HomeVal_2[0, 7] = 2; //第二段回原点搜索速度
			//拨料Z轴
			Tools.HomeSearchDist[0, 8] = -1000; //原点搜索距离
			Tools.HomeOffsetDist[0, 8] = 2; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[0, 8] = 25; //极限到原点的距离
			Tools.HomeOffset[0, 8] = 2; //回完原点后偏移距离
			Tools.HomeVal_1[0, 8] = 20; //第一段回原点搜索速度
			Tools.HomeVal_2[0, 8] = 1; //第二段回原点搜索速度
			//左相机
			Tools.HomeSearchDist[1, 1] = -1000; //原点搜索距离
			Tools.HomeOffsetDist[1, 1] = 5; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[1, 1] = 30; //极限到原点的距离
			Tools.HomeOffset[1, 1] = 2; //回完原点后偏移距离
			Tools.HomeVal_1[1, 1] = 20; //第一段回原点搜索速度
			Tools.HomeVal_2[1, 1] = 1; //第二段回原点搜索速度
			//右相机
			Tools.HomeSearchDist[1, 2] = -1000; //原点搜索距离
			Tools.HomeOffsetDist[1, 2] = 5; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[1, 2] = 30; //极限到原点的距离
			Tools.HomeOffset[1, 2] = 2; //回完原点后偏移距离
			Tools.HomeVal_1[1, 2] = 20; //第一段回原点搜索速度
			Tools.HomeVal_2[1, 2] = 1; //第二段回原点搜索速度
			//右相机光源
			Tools.HomeSearchDist[1, 3] = -1000; //原点搜索距离
			Tools.HomeOffsetDist[1, 3] = 5; //捕获原点后反向偏移距离
			Tools.LimToHomeDist[1, 3] = 30; //极限到原点的距离
			Tools.HomeOffset[1, 3] = 2; //回完原点后偏移距离
			Tools.HomeVal_1[1, 3] = 20; //第一段回原点搜索速度
			Tools.HomeVal_2[1, 3] = 1; //第二段回原点搜索速度
		}
		
		static int[] GoHomeZ_homeOldTime = new int[17];
		
		public static void GoHomeZ(short CardNum, short Axis, int homeLimitDist, int searchDist, int offsetPos, double vel)
		{
			int status = 0;
			gts.TTrapPrm trapPrm = new gts.TTrapPrm();
			short rtn;

            if (Tools.HomeStep[CardNum, Axis] != 0)
			{
				switch (Tools.HomeStep[CardNum, Axis])
				{
					case (short) 10:
						rtn = (gts.GT_ClrSts(CardNum, Axis, (short) 1));
						rtn = (gts.GT_SetPrfPos(CardNum, Axis, 0));
						rtn = (gts.GT_SetEncPos(CardNum, Axis, 0));
                        rtn = (gts.GT_SetEncPos(CardNum, Axis, 0));
						rtn = (gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1))))); //将当前轴进行位置同步
						rtn = (gts.GT_PrfTrap(CardNum, Axis)); //设置当前轴的运动模式为点位模式
						rtn =(gts.GT_GetTrapPrm(CardNum, Axis, out trapPrm)); //获取当前轴点位模式运动参数
						trapPrm.acc = 0.5;
						trapPrm.dec = 0.5;
                        rtn = (gts.GT_SetTrapPrm(CardNum, Axis, ref trapPrm));
						Tools.HomeStep[CardNum, Axis] = (short) 11;
						break;
						
					case (short) 11:
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						Tools.HomeStep[CardNum, Axis] = (short) (Gg.GetHomeDi(CardNum, Axis) == 0 ? 15 : 200); //判断原点是否停在原点上
						break;
						
					case (short) 15:
						rtn = System.Convert.ToInt16(gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME));
						rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + searchDist)));
                        rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel));
                        rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int)(Math.Pow(2, (Axis - 1)))));
						FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 20;
						break;
						
					case (short) 20:
						uint  temp_pClock = 0;
                        rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out  temp_pClock);
						uint temp_pClock2 = 0;
						rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock2); //获取当前轴原点捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis]==1) //判断当前轴是否原点捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0;
							Tools.HomeStep[CardNum, Axis] = (short) 50;
						}
						else if (System.Convert.ToBoolean(status & 0x20) == true) //判断当前轴是否触发负极限
						{
							Tools.HomeStep[CardNum, Axis] = (short) 30;
						}
						else if (System.Convert.ToBoolean(status & 0x400) == false || System.Convert.ToBoolean(status & 0x40) == true) //判断当前轴是否运动停止或是否触发正极限（原点搜索距离太小或触发极限）
						{
							Tools.HomeStep[CardNum, Axis] = (short) 11;
						}
						break;
						
					case (short) 30: //负极限和原点之间距离
						rtn = System.Convert.ToInt16(gts.GT_ClrSts(CardNum, Axis, (short) 1));
						rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + homeLimitDist)));
						rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel));
						rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1)))));
						FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 40;
						break;
						
					case (short) 40:
						rtn = System.Convert.ToInt16(gts.GT_ClrSts(CardNum, Axis, (short) 1));
						uint temp_pClock3 = 0;
						rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock3);
						if (Gg.GetHomeDi(CardNum, Axis) == 1)
						{
							rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + offsetPos))); //设置当前轴的目标位置（即原点偏移距离）
							rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel));
							rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1)))));
							FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						}
						if (System.Convert.ToBoolean(status & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 11;
						}
						break;
						
					case (short) 50:
						uint temp_pClock4 = 0;
						rtn = System.Convert.ToInt16(gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock4));
						rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Tools.HomeTempPos[CardNum, Axis] + 2 * offsetPos)));
						rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel * 0.5));
						rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1)))));
						FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 51;
						break;
						
					case (short) 51:
						uint temp_pClock5 = 0;
						rtn = System.Convert.ToInt16(gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock5)); //获取当前轴的状态
						if (System.Convert.ToBoolean(status & 0x400) == false) //判断当前轴是否运动停止（Z相脉冲修正完成）
						{
							GoHomeZ_homeOldTime[CardNum * 8 + Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 52;
						}
						break;
						
					case (short) 52:
						if (System.Convert.ToInt32(API.GetTickCount()) - GoHomeZ_homeOldTime[CardNum * 8 + Axis] > 500)
						{
							rtn = System.Convert.ToInt16(gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME)); //Home捕获
							//rtn = GT_SetCaptureMode(CardNum, Axis, CAPTURE_INDEX)    '启动当前轴的Z相脉冲捕获，Index捕获
							rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, 250000)); //设置当前轴的目标位置（即Z相脉冲搜索距离）
							rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel * 0.1)); //设置当前轴的目标速度（即Z相脉冲搜索速度）
							rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))))); //启动当前轴点位运动
							FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
							Tools.HomeStep[CardNum, Axis] = (short) 60; //跳转到下一步
						}
						break;
						
					case (short) 60:
						rtn = System.Convert.ToInt16(gts.GT_ClrSts(CardNum, Axis, (short) 1));
						uint temp_pClock6 = 0;
						rtn = System.Convert.ToInt16(gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock6)); //获取当前轴的状态
						uint temp_pClock7 = 0;
						rtn = System.Convert.ToInt16(gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock7)); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否Z相脉冲捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴Z相脉冲捕获触发标志清零
							Tools.HomeStep[CardNum, Axis] = (short) 70;
						}
						else if (System.Convert.ToBoolean(status & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 110; //跳转到第110步（当前轴Z相脉冲未找到，回原点结束，回原点失败）
						}
						break;
						
					case (short) 70:
						rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Tools.HomeTempPos[CardNum, Axis] + offsetPos))); //+ offsetPos
						rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel));
						rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1)))));
						FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 80;
						break;
						
					case (short) 80:
						rtn = System.Convert.ToInt16(gts.GT_ClrSts(CardNum, Axis, (short) 1));
						uint temp_pClock8 = 0;
						rtn = System.Convert.ToInt16(gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock8));
						if (System.Convert.ToBoolean(status & 0x400) == false) //判断当前轴是否运动停止
						{
							GoHomeZ_homeOldTime[CardNum * 8 + Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 90;
						}
						break;
						
					case (short) 90:
						if (System.Convert.ToInt32(API.GetTickCount()) - GoHomeZ_homeOldTime[CardNum * 8 + Axis] > 1000)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 100;
						}
						break;
						
					case (short) 100:
						rtn = System.Convert.ToInt16(gts.GT_SetPrfPos(CardNum, Axis, 0));
						rtn = System.Convert.ToInt16(gts.GT_SetEncPos(CardNum, Axis, 0));
						rtn = System.Convert.ToInt16(gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))));
                        GoHome.AxisHome[CardNum, Axis].Result = true;
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
					case (short) 110:
                        GoHome.AxisHome[CardNum, Axis].Result = false;
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
					case (short) 200:
						rtn = System.Convert.ToInt16(gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + offsetPos)));
						rtn = System.Convert.ToInt16(gts.GT_SetVel(CardNum, Axis, vel));
						rtn = System.Convert.ToInt16(gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1)))));
						FileLog.WriteMotionLog("GoHomeZ-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 210;
						break;
						
					case (short) 210:
						rtn = System.Convert.ToInt16(gts.GT_ClrSts(CardNum, Axis, (short) 1));
						uint temp_pClock9 = 0;
						rtn = System.Convert.ToInt16(gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock9));
						if (System.Convert.ToBoolean(status & 0x400) == false)
						{
							GoHomeZ_homeOldTime[CardNum * 8 + Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 220;
						}
						break;
						
					case (short) 220:
						if (System.Convert.ToInt32(API.GetTickCount()) - GoHomeZ_homeOldTime[CardNum * 8 + Axis] > 200)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 11;
						}
						break;
				}
			}
		}
		

		/// <summary>
        /// 伺服回原点，往负方向回零
		/// </summary>
        static int[,] GoHomeSF_status = new int[5, 9];
		
		public static void GoHomeSF(short CardNum, short Axis, double homeToLimitFDist, double searchHomeDist, double offsetPos, double vel)
		{
            uint temp_pClock = 0;
            if (Tools.HomeStep[CardNum, Axis] != 0)
			{
				switch (Tools.HomeStep[CardNum, Axis])
				{
					case (short) 10:
						PVar.Rtn = (gts.GT_ClrSts(CardNum, Axis, (short) 1)); //清除报警
						PVar.Rtn = (gts.GT_SetPrfPos(CardNum, Axis, 0)); //规划器置零
						PVar.Rtn = (gts.GT_SetEncPos(CardNum, Axis, 0)); //编码器置零
						PVar.Rtn = (gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1))))); //将当前轴进行位置同步
						Tools.HomeCounter[CardNum, Axis] = (short) 0; //回原点计数
						Tools.HomeStep[CardNum, Axis] = (short) 20;
						break;
						
					case (short) 20:
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						if (Gg.GetHomeDi(CardNum, Axis) == 0)
						{
							if (Tools.HomeCounter[CardNum, Axis] > 1)
							{
								Tools.HomeStep[CardNum, Axis] = (short) 140;
							}
							else
							{
								Tools.HomeCounter[CardNum, Axis] = (short) (Tools.HomeCounter[CardNum, Axis] + 1);
								Tools.HomeStep[CardNum, Axis] = (short) 30; //往负方向搜索原点
							}
						}
						else
						{
							Tools.HomeStep[CardNum, Axis] = (short) 200; //往正方向偏离原点
						}
						break;
						
					case (short) 30:
						PVar.Rtn =(gts.GT_ClrSts(CardNum, Axis, (short) 1));
						PVar.Rtn = (gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME)); //第一次原点搜索
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPosmm( CardNum,  Axis) + searchHomeDist), vel); //启动运动，开始搜索原点
						Tools.HomeStep[CardNum, Axis] = (short) 40;
						break;
						
					case (short) 40:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock);
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeCapture[CardNum, Axis] = (short) 0;
							Tools.HomeStep[CardNum, Axis] = (short) 50;
						}
						else if (Gg.GetLimitDi_Z(CardNum, Axis) == 1) //判断当前轴是否触发正极限
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeStep[CardNum, Axis] = (short) 170;
						}
						else if (Gg.GetLimitDi_F(CardNum, Axis) == 1 == true) //判断当前轴是否触发负极限
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeStep[CardNum, Axis] = (short) 150;
						}
						else if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false) //判断当前轴规划器是否运动停止（原点搜索距离太小）
						{
							Tools.HomeStep[CardNum, Axis] = (short) 140;
						}
						break;
						
					case (short) 50:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPosmm( CardNum,  Axis) + offsetPos), 10); //启动运动，原点反向运动
						Tools.HomeStep[CardNum, Axis] = (short) 60;
						break;
						
					case (short) 60:
						PVar.Rtn =gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn =gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴的状态
						if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false) //判断当前轴是否运动停止
						{
							Tools.HomeStep[CardNum, Axis] = (short) 70;
						}
						break;
						
					case (short) 70:
						PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第二次原点搜索
						//Rtn = GT_SetCaptureMode(CardNum, Axis, CAPTURE_INDEX)    '启动当前轴的Z相脉冲捕获
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPosmm( CardNum,  Axis) - offsetPos * 2), 2); //以2mm/s速度找原点
						Tools.HomeStep[CardNum, Axis] = (short) 80; //跳转到下一步
						break;
						
					case (short) 80:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴的状态
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否Z相脉冲捕获触发
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴Z相脉冲捕获触发标志清零
							Tools.HomeStep[CardNum, Axis] = (short) 90;
						}
						else if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 140; //跳转到第110步（当前轴Z相脉冲未找到，回原点结束，回原点失败）
						}
						break;
						
					case (short) 90:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Tools.HomeTempPos[CardNum, Axis] / Gg.PlusPerUnit(CardNum, Axis)), 2);
						Tools.HomeStep[CardNum, Axis] = (short) 100;
						break;
						
					case (short) 100:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false) //判断当前轴是否运动停止
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 110;
						}
						break;
						
					case (short) 110:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 200)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 120;
						}
						break;
						
					case (short) 120:
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
						Tools.HomeStep[CardNum, Axis] = (short) 130;
						break;
						
					case (short) 130:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 50)
						{
							if (Gg.GetEncPos(CardNum, Axis) == 0 && Gg.GetPrfPos(CardNum, Axis) == 0)
							{
                            GoHome.AxisHome[CardNum, Axis].Result = true;
								Tools.HomeStep[CardNum, Axis] = (short) 0;
							}
							else
							{
								Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
								Tools.HomeStep[CardNum, Axis] = (short) 110;
							}
						}
						break;
						
					case (short) 140:
                        GoHome.AxisHome[CardNum, Axis].Result = false;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
						//*********************************************************************************************************************
					case (short) 150: //负极限和原点之间距离
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPosmm( CardNum,  Axis) + homeToLimitFDist), vel * 0.5);
						Tools.HomeStep[CardNum, Axis] = (short) 160;
						break;
						
					case (short) 160:
						PVar.Rtn =gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 20; //重新搜索原点
						}
						break;
						
						//*********************************************************************************************************************
					case (short) 170: //offsetPos大于感应片的宽度
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPosmm( CardNum,  Axis) - offsetPos), vel * 0.5);
						Tools.HomeStep[CardNum, Axis] = (short) 180;
						break;
						
					case (short) 180:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 20; //重新搜索原点
						}
						break;
						
						//*********************************************************************************************************************
					case (short) 200: //offsetPos大于感应片的宽度
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPosmm( CardNum,  Axis) + offsetPos), vel * 0.5);
						Tools.HomeStep[CardNum, Axis] = (short) 210;
						break;
						
					case (short) 210:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeSF_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeSF_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 220;
						}
						break;
						
					case (short) 220:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 200)
						{
							if (Gg.GetHomeDi(CardNum, Axis) == 1)
							{
								Tools.HomeStep[CardNum, Axis] = (short) 140;
							}
						}
						break;
				}
			}
		}
		

        static int[,] GoHomeBJ_status = new int[5, 9];
		
		public static void GoHomeBJ(short CardNum, short Axis, double homeToLimitFDist, double searchHomeDist, double offsetPos, double vel)
		{
            uint temp_pClock = 0;
            if (Tools.HomeStep[CardNum, Axis] != 0)
			{
				switch (Tools.HomeStep[CardNum, Axis])
				{
					case (short) 10:
						PVar.Rtn =gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除报警
						PVar.Rtn =gts.GT_SetPrfPos(CardNum, Axis, 0); //规划器置零
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0); //编码器置零
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						Tools.HomeCounter[CardNum, Axis] = (short) 0; //回原点计数
						Tools.HomeStep[CardNum, Axis] = (short) 20;
						break;
						
					case (short) 20:
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						if (Gg.GetHomeDi(CardNum, Axis) == 0)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 30; //往负方向搜索原点
						}
						else
						{
							Tools.HomeStep[CardNum, Axis] = (short) 200; //往正方向偏离原点
						}
						break;
						
					case (short) 30:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第一次原点搜索
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPosmm( CardNum,  Axis) + searchHomeDist), vel); //启动运动，开始搜索原点
						Tools.HomeStep[CardNum, Axis] = (short) 40;
						break;
						
					case (short) 40:
						PVar.Rtn =gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out temp_pClock);
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeCapture[CardNum, Axis] = (short) 0;
							Tools.HomeStep[CardNum, Axis] = (short) 50;
						}
						else if (Gg.GetLimitDi_Z(CardNum, Axis) == 1) //判断当前轴是否触发正极限
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeStep[CardNum, Axis] = (short) 170;
						}
						else if (Gg.GetLimitDi_F(CardNum, Axis) == 1) //判断当前轴是否触发负极限
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeStep[CardNum, Axis] = (short) 150;
						}
						else if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false) //判断当前轴是否运动停止（原点搜索距离太小）
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeStep[CardNum, Axis] = (short) 20;
						}
						break;
						
					case (short) 50:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPosmm( CardNum,  Axis) + offsetPos), 10); //启动运动，原点反向运动
						Tools.HomeStep[CardNum, Axis] = (short) 60;
						break;
						
					case (short) 60:
						PVar.Rtn =gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴的状态
						if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false) //判断当前轴是否运动停止
						{
							Tools.HomeStep[CardNum, Axis] = (short) 70;
						}
						break;
						
					case (short) 70:
						PVar.Rtn =gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //第二次原点搜索
						//Rtn = GT_SetCaptureMode(CardNum, Axis, CAPTURE_INDEX)    '启动当前轴的Z相脉冲捕获
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPosmm( CardNum,  Axis) - offsetPos * 2), 2);
						Tools.HomeStep[CardNum, Axis] = (short) 80; //跳转到下一步
						break;
						
					case (short) 80:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴的状态
						PVar.Rtn =gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否Z相脉冲捕获触发
						{
							Gg.AxisStop(CardNum, Axis); //当前轴停止
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴Z相脉冲捕获触发标志清零
							Tools.HomeStep[CardNum, Axis] = (short) 90;
						}
						else if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 140; //跳转到第110步（当前轴Z相脉冲未找到，回原点结束，回原点失败）
						}
						break;
						
					case (short) 90:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Tools.HomeTempPos[CardNum, Axis] / Gg.PlusPerUnit(CardNum, Axis)), 2);
						Tools.HomeStep[CardNum, Axis] = (short) 100;
						break;
						
					case (short) 100:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out  temp_pClock);
						if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false) //判断当前轴是否运动停止
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 110;
						}
						break;
						
					case (short) 110:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 1000)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 120;
						}
						break;
						
					case (short) 120:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 500)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 130;
						}
						break;
						
					case (short) 130:
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0);
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0);
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1))));
						GoHome.AxisHome[CardNum, Axis].Result = true;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
					case (short) 140:
                        GoHome.AxisHome[CardNum, Axis].Result = false;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
						//*********************************************************************************************************************
					case (short) 150: //负极限和原点之间距离
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPosmm( CardNum,  Axis) + homeToLimitFDist), vel * 0.5);
						Tools.HomeStep[CardNum, Axis] = (short) 160;
						break;
						
					case (short) 160:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn =gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 20; //重新搜索原点
						}
						break;
						
						//*********************************************************************************************************************
					case (short) 170: //offsetPos大于感应片的宽度
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPosmm( CardNum,  Axis) - offsetPos), vel * 0.5);
						Tools.HomeStep[CardNum, Axis] = (short) 180;
						break;
						
					case (short) 180:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 20; //重新搜索原点
						}
						break;
						
						//*********************************************************************************************************************
					case (short) 200: //offsetPos大于感应片的宽度
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPosmm( CardNum,  Axis) + offsetPos), vel * 0.5);
						Tools.HomeStep[CardNum, Axis] = (short) 210;
						break;
						
					case (short) 210:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out GoHomeBJ_status[CardNum, Axis], (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(GoHomeBJ_status[CardNum, Axis] & 0x400) == false)
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 220;
						}
						break;
						
					case (short) 220:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 200)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 20;
						}
						break;
				}
			}
		}
		
		static int[] GoHomeF_homeOldTime = new int[17];
		
		public static void GoHomeF(short CardNum, short Axis, int homeLimitDist, int searchDist, int offsetPos, double vel)
		{
            uint temp_pClock = 0;
			int status = 0;
			gts.TTrapPrm trapPrm = new gts.TTrapPrm();
            if (Tools.HomeStep[CardNum, Axis] != 0)
			{
				switch (Tools.HomeStep[CardNum, Axis])
				{
					case (short) 10:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0);
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0);
						PVar.Rtn =gts.GT_SetEncPos(CardNum, Axis, 0);
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						PVar.Rtn =gts.GT_PrfTrap(CardNum, Axis); //设置当前轴的运动模式为点位模式
						PVar.Rtn = gts.GT_GetTrapPrm(CardNum, Axis, out trapPrm); //获取当前轴点位模式运动参数
						trapPrm.acc = 0.5;
						trapPrm.dec = 0.5;
						PVar.Rtn = gts.GT_SetTrapPrm(CardNum, Axis, ref trapPrm);
						Tools.HomeStep[CardNum, Axis] = (short) 11;
						break;
						
					case (short) 11:
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						Tools.HomeStep[CardNum, Axis] = (short) (Gg.GetHomeDi(CardNum, Axis) == 0 ? 15 : 200);
						break;
						
					case (short) 15:
						PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME);
						PVar.Rtn = gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + searchDist));
						PVar.Rtn = gts.GT_SetVel(CardNum, Axis, vel);
						PVar.Rtn = gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))));
						FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 20;
						break;
						
					case (short) 20:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock);
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0;
							Tools.HomeStep[CardNum, Axis] = (short) 50;
						}
						else if (System.Convert.ToBoolean(status & 0x40) == true) //判断当前轴是否触发负极限
						{
							Tools.HomeStep[CardNum, Axis] = (short) 30;
						}
						else if (System.Convert.ToBoolean(status & 0x400) == false || System.Convert.ToBoolean(status & 0x20) == true) //判断当前轴是否运动停止或是否触发正极限（原点搜索距离太小或触发极限）
						{
							Tools.HomeStep[CardNum, Axis] = (short) 11;
						}
						break;
						
					case (short) 30: //负极限和原点之间距离
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);
						PVar.Rtn = gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + homeLimitDist));
						PVar.Rtn = gts.GT_SetVel(CardNum, Axis, vel);
						PVar.Rtn = gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))));
						FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 40;
						break;
						
					case (short) 40:
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1);						
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock);
						if (Gg.GetHomeDi(CardNum, Axis) == 1)
						{
							PVar.Rtn = gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + offsetPos)); //设置当前轴的目标位置（即原点偏移距离）
							PVar.Rtn = gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))));
							FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						}
						if (System.Convert.ToBoolean(status & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 11;
						}
						break;
						
					case (short) 50:
						PVar.Rtn = gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Tools.HomeTempPos[CardNum, Axis] + 2 * offsetPos));
						PVar.Rtn = gts.GT_SetVel(CardNum, Axis, vel * 0.5);
						PVar.Rtn = gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))));
						FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 51;
						break;
						
					case (short) 51:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (System.Convert.ToBoolean(status & 0x400) == false) //判断当前轴是否运动停止（Z相脉冲修正完成）
						{
							GoHomeF_homeOldTime[CardNum * 8 + Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 52;
						}
						break;
						
					case (short) 52:
						if (System.Convert.ToInt32(API.GetTickCount()) - GoHomeF_homeOldTime[CardNum * 8 + Axis] > 500)
						{
							PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME);
							//Rtn = GT_SetCaptureMode(CardNum, Axis, CAPTURE_INDEX)    '启动当前轴的Z相脉冲捕获
							PVar.Rtn = gts.GT_SetPos(CardNum, Axis, -250000); //设置当前轴的目标位置（即Z相脉冲搜索距离）
							PVar.Rtn =gts.GT_SetVel(CardNum, Axis, vel * 0.1); //设置当前轴的目标速度（即Z相脉冲搜索速度）
							PVar.Rtn = gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //启动当前轴点位运动
							FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
							Tools.HomeStep[CardNum, Axis] = (short) 60; //跳转到下一步
						}
						break;
						
					case (short) 60:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock); //获取当前轴的状态
						PVar.Rtn =gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
                        if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否Z相脉冲捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴Z相脉冲捕获触发标志清零
							Tools.HomeStep[CardNum, Axis] = (short) 70;
						}
						else if (System.Convert.ToBoolean(status & 0x400) == false)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 110; //跳转到第110步（当前轴Z相脉冲未找到，回原点结束，回原点失败）
						}
						break;
						
					case (short) 70:
						PVar.Rtn = gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Tools.HomeTempPos[CardNum, Axis] + 200)); //+ offsetPos
						PVar.Rtn = gts.GT_SetVel(CardNum, Axis, vel);
						PVar.Rtn =gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))));
						FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 80;
						break;
						
					case (short) 80:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(status & 0x400) == false) //判断当前轴是否运动停止
						{
							GoHomeF_homeOldTime[CardNum * 8 + Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 90;
						}
						break;
						
					case (short) 90:
						if (System.Convert.ToInt32(API.GetTickCount()) - GoHomeF_homeOldTime[CardNum * 8 + Axis] > 1000)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 100;
						}
						break;
						
					case (short) 100:
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0);
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0);
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1))));
                        GoHome.AxisHome[CardNum, Axis].Result = true;
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
					case (short) 110:
                        GoHome.AxisHome[CardNum, Axis].Result = false;
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						Tools.HomeStep[CardNum, Axis] = (short) 0;
						break;
						
					case (short) 200:
						PVar.Rtn = gts.GT_SetPos(CardNum, Axis, System.Convert.ToInt32(Gg.GetEncPos(CardNum, Axis) + offsetPos));
						PVar.Rtn = gts.GT_SetVel(CardNum, Axis, vel);
						PVar.Rtn = gts.GT_Update(CardNum, (int) (Math.Pow(2, (Axis - 1))));
						FileLog.WriteMotionLog("GoHomeF-->" + "卡：" + System.Convert.ToString(CardNum) + " 轴：" + System.Convert.ToString(Axis));
						Tools.HomeStep[CardNum, Axis] = (short) 210;
						break;
						
					case (short) 210:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out status, (short) 1, out temp_pClock);
						if (System.Convert.ToBoolean(status & 0x400) == false)
						{
							GoHomeF_homeOldTime[CardNum * 8 + Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 220;
						}
						break;
						
					case (short) 220:
						if (System.Convert.ToInt32(API.GetTickCount()) - GoHomeF_homeOldTime[CardNum * 8 + Axis] > 200)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 11;
						}
						break;
				}
			}
		}
					
		/// <summary>
		/// 回原点，参数：1卡号，2轴号，3原点偏移距离，4原点搜索距离，5原点偏移位置Offset，6搜索原点速度
		/// </summary>
		/// <remarks></remarks>
		static short Home_tempLogStr;
		
		public static void Home(ref short CardNum, short Axis, int HL_Dist, int SearchPos, int Offset, double Tvel)
		{
			//0                          3               300 000           -1000 000          2500
			int Status = 0;
            uint temp_pClock = 0;
			gts.TTrapPrm TrapPrm = new gts.TTrapPrm();
            if (Tools.HomeStep[CardNum, Axis] != 0)
			{
				switch (Tools.HomeStep[CardNum, Axis])
				{
					case (short) 10:
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						PVar.Rtn =gts.GT_SetTrapPrm(CardNum, Axis, ref TrapPrm); //设置当前轴点位模式运动参数
						if (Gg.GetLimitDi_F(CardNum, Axis) == 1) //判断当前轴是否触发负极限
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 30;
						}
						else if (Gg.GetHomeDi(CardNum, Axis) == 1) //判断当前轴是否触发原点
						{
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + HL_Dist), Tvel);
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 50;
						}
						else
						{
							PVar.Rtn = gts.GT_SetTrapPrm(CardNum, Axis, ref TrapPrm); //设置当前轴点位模式运动参数
							PVar.Rtn =gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //启动当前轴的原点捕获
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + SearchPos), Tvel);
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 20; //跳转到下一步
						}
						break;
					case (short) 20:					
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							PVar.Rtn = gts.GT_Stop(CardNum, (int) (Math.Pow(2, Axis) - 1), (int) (Math.Pow(2, Axis) - 1));
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴原点捕获触发标志清零
							//'**************************步进马达回零专用*******************************
							//Select Case Axis
							//    Case 100    '4, 5, 6, 8
							//        HomeTempPos(CardNum, Axis) = GetPrfPos(CardNum, Axis)
							//    Case Else
							//        HomeTempPos(CardNum, Axis) = GetPrfPos(CardNum, Axis)
							//End Select
							//'*************************************************************************
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 25; //跳转到下一步    'Home
							
						}
						else if (Gg.GetLimitDi_F(CardNum, Axis) == 1) //判断当前轴是否触发负极限
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							PVar.Rtn = gts.GT_AxisOn(CardNum, Axis);
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 30;
							
						}
						else if (Gg.GetHomeDi(CardNum, Axis) == 1) //判断当前轴是否触发原点
						{
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + HL_Dist), Tvel);
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 50;
							
						}
						else if (System.Convert.ToBoolean(Status & 0x400) == false || System.Convert.ToBoolean(Status & 0x20) == true) //判断当前轴是否运动停止（原点搜索距离太小或触发极限）
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 10; //跳转到第10步（重新搜索）
							
						}
						break;
						
					case (short) 25:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100 && System.Convert.ToBoolean(Status & 0x400) == false)
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + 10), Tvel);
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 50; //跳转到下一步        'Home
						}
						break;
						
					case (short) 30:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100 && System.Convert.ToBoolean(Status & 0x400) == false)
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + HL_Dist), Tvel);
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 40; //跳转到下一步        'Home
						}
						break;
						
					case (short) 40:
						if (Gg.GetHomeDi(CardNum, Axis) == 1)
						{
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 50; //跳转到下一步        'Home
						}
						else
						{
                        if (Gg.ZSPD( CardNum,  Axis))
							{
								Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
								Tools.HomeStep[CardNum, Axis] = (short) 150;
							}
						}
						break;
						
					case (short) 50:
						if (Gg.GetHomeDi(CardNum, Axis) == 0)
						{
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + 5), Tvel);
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 51; //跳转到下一步        'Home
						}
						break;
						
					case (short) 51:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100 && System.Convert.ToBoolean(Status & 0x400) == false)
						{
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 80; //跳转到下一步        'Home
						}
						break;
						
					case (short) 60:
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是原点捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴原点捕获触发标志清零
							PVar.Rtn =gts.GT_Stop(CardNum, 1<<(Axis - 1), 1 <<(Axis - 1));
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 70; //跳转到下一步
						}
						else if (System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止
						{
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 150;
						}
						break;
						
					case (short) 70:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + 5), Tvel);
						Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 80; //跳转到下一步
						break;
						
					case (short) 80:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100 && System.Convert.ToBoolean(Status & 0x400) == false)
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
                            PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short)1, out temp_pClock); //获取当前轴的状态
							PVar.Rtn =gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //启动当前轴的原点捕获
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 85; //跳转到下一步
						}
						break;
						
					case (short) 85:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100)
						{
							Tools.HomeStep[CardNum, Axis] = (short) 90; //跳转到下一步
						}
						break;
						
					case (short) 90:
						PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //启动当前轴的原点捕获
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
						
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 25), 5);
						Home_tempLogStr = (short) (Gg.GetPrfPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 10);
						Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount()); //原点修正完成延时200ms等待马达停稳
						Tools.HomeStep[CardNum, Axis] = (short) 100; //跳转到下一步
						break;
						
					case (short) 100:
						PVar.Rtn =gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴原点捕获触发标志清零
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 110; //跳转到下一步
						}
						else if (System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止（原点搜索距离太小或原点信号异常）
						{
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 80; //跳转到第110步（当前轴原点未找到，回原点结束，回原点失败）
						}
						break;
						
					case (short) 110:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(System.Convert.ToInt32(Tools.HomeTempPos[CardNum, Axis] / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis])) + Offset), Tvel);
						Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 120; //跳转到下一步
						break;
						
					case (short) 120:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						
						if (System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止
						{
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeZoneN[CardNum, Axis] = (short) 0;
							Tools.HomeStep[CardNum, Axis] = (short) 130;
						}
						break;
						
					case (short) 130:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 200)
						{
							Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeZoneN[CardNum, Axis] = (short) (Tools.HomeZoneN[CardNum, Axis] + 1);
							Tools.HomeStep[CardNum, Axis] = (short) 140; //跳转到下一步
						}
						break;
						
					case (short) 140:
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
						Tools.HomeStep[CardNum, Axis] = (short) 145; //跳转到下一步
						break;
						
					case (short) 145:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 500)
						{
							Tools.HomeEncPos[CardNum, Axis] = double.Parse(Strings.Format(Gg.GetEncPosmm( CardNum,  Axis), "0.000"));
							Tools.HomePrfPos[CardNum, Axis] = double.Parse(Strings.Format(Gg.GetPrfPosmm( CardNum,  Axis), "0.000"));
                            if ((Tools.HomeEncPos[CardNum, Axis] == 0 && Tools.HomePrfPos[CardNum, Axis] == 0) || Tools.HomeZoneN[CardNum, Axis] > 5)
							{
                            GoHome.AxisHome[CardNum, Axis].Result = true; //当前轴回原点成功
								Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
								Tools.HomeStep[CardNum, Axis] = (short) 0; //跳转到下一步
							}
                            else if (Tools.HomeZoneN[CardNum, Axis] <= 5)
							{
								Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
								Tools.HomeStep[CardNum, Axis] = (short) 130; //跳转到下一步
							}
						}
						break;
						
					case (short) 150:
						
						GoHome.AxisHome[CardNum, Axis].Result = false; //当前轴回原点失败
						Home_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 0; //跳转到下一步
						break;
				}
			}
			
		}
		
		/// <summary>
		/// 回原点，参数：1卡号，2轴号，3原点偏移距离，4原点搜索距离，5原点偏移位置Offset，6搜索原点速度
		/// </summary>
		/// <remarks></remarks>
		static short HomeR_tempLogStr;
		
		public static void HomeR(ref short CardNum, short Axis, int HL_Dist, int SearchPos, int Offset, double Tvel)
		{
			//0                          3               300 000           -1000 000          2500
			int Status = 0;
            uint temp_pClock = 0;
			gts.TTrapPrm TrapPrm = new gts.TTrapPrm();
            if (Tools.HomeStep[CardNum, Axis] != 0)
			{
				switch (Tools.HomeStep[CardNum, Axis])
				{
					case (short) 10:
						Tools.HomeCapture[CardNum, Axis] = (short) 0;
						PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						PVar.Rtn = gts.GT_SetTrapPrm(CardNum, Axis, ref TrapPrm); //设置当前轴点位模式运动参数
						if (Gg.GetLimitDi_F(CardNum, Axis) == 1) //判断当前轴是否触发负极限
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							Tools.HomeStep[CardNum, Axis] = (short) 30;
						}
						else if (Gg.GetHomeDi(CardNum, Axis) == 1) //判断当前轴是否触发原点
						{
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 50), Tvel);
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 50;
						}
						else
						{
							PVar.Rtn = gts.GT_SetTrapPrm(CardNum, Axis, ref TrapPrm); //设置当前轴点位模式运动参数
							PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //启动当前轴的原点捕获
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + SearchPos), Tvel);
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 20; //跳转到下一步
						}
						break;
					case (short) 20:						
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴原点捕获的状态及捕获的当前位置
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							PVar.Rtn = gts.GT_Stop(CardNum, (int) (Math.Pow(2, Axis) - 1), (int) (Math.Pow(2, Axis) - 1));
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴原点捕获触发标志清零
							//**************************步进马达回零专用*******************************
							switch (Axis)
							{
								case (short) 100: //4, 5, 6, 8
									Tools.HomeTempPos[CardNum, Axis] = Gg.GetPrfPos(CardNum, Axis);
									break;
								default:
									Tools.HomeTempPos[CardNum, Axis] = Gg.GetEncPos(CardNum, Axis);
									break;
							}
							//*************************************************************************
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 70; //跳转到下一步    'Home
							
						}
						else if (Gg.GetLimitDi_Z(CardNum, Axis) == 1) //判断当前轴是否触发+极限
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							PVar.Rtn = gts.GT_AxisOn(CardNum, Axis);
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 30;
							
						}
						else if (Gg.GetHomeDi(CardNum, Axis) == 1) //判断当前轴是否触发原点
						{
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + HL_Dist), Tvel);
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 50;
							
						}
						else if (System.Convert.ToBoolean(Status & 0x400) == false || System.Convert.ToBoolean(Status & 0x20) == true) //判断当前轴是否运动停止（原点搜索距离太小或触发极限）
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 10; //跳转到第10步（重新搜索）
							
						}
						break;
					case (short) 30:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100)
						{
							PVar.Rtn = gts.GT_ClrSts(CardNum, Axis, (short) 1); //清除当前轴驱动器报警标志
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 150), Tvel);
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 40; //跳转到下一步        'Home
						}
						break;
					case (short) 40:
						if (Gg.GetHomeDi(CardNum, Axis) == 1)
						{
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 50; //跳转到下一步        'Home
						}
						else
						{
                        if (Gg.ZSPD(CardNum, Axis))
							{
								HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
								Tools.HomeStep[CardNum, Axis] = (short) 150;
							}
						}
						break;
						
					case (short) 50:
						if (Gg.GetHomeDi(CardNum, Axis) == 0)
						{
							Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 10), Tvel);
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 51; //跳转到下一步        'Home
						}
						break;
						
					case (short) 51:
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 100 && System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止（原点搜索距离太小或原点信号异常）
						{
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 90; //跳转到下一步        'Home
						}
						break;
						
					case (short) 60:
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是原点捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴原点捕获触发标志清零
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 70; //跳转到下一步
						}
						else if (System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止
						{
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 150;
						}
						break;
						
					case (short) 70:
						
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 25), Tvel);
						HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 80; //跳转到下一步
						break;
						
					case (short) 80:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Gg.GetHomeDi(CardNum, Axis) == 0 || System.Convert.ToBoolean(Status & 0x400) == false)
						{
							Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount()); //原点修正完成延时200ms等待马达停稳
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 90; //跳转到下一步
						}
						break;
						
					case (short) 90:
						PVar.Rtn = gts.GT_SetCaptureMode(CardNum, Axis, gts.CAPTURE_HOME); //启动当前轴的原点捕获
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) + 50), 5);
						HomeR_tempLogStr = (short) (Gg.GetEncPos(CardNum, Axis) / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis]) - 15);
						HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 100; //跳转到下一步
						break;
						
					case (short) 100:
						PVar.Rtn = gts.GT_GetCaptureStatus(CardNum, Axis, out Tools.HomeCapture[CardNum, Axis], out Tools.HomeTempPos[CardNum, Axis], (short) 1, out temp_pClock); //获取当前轴Z相脉冲捕获的状态及捕获的当前位置
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						if (Tools.HomeCapture[CardNum, Axis] == 1) //判断当前轴是否原点捕获触发
						{
							Tools.HomeCapture[CardNum, Axis] = (short) 0; //当前轴原点捕获触发标志清零
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 110; //跳转到下一步
						}
						else if (System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止（原点搜索距离太小或原点信号异常）
						{
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 150; //跳转到第110步（当前轴原点未找到，回原点结束，回原点失败）
						}
						break;
						
					case (short) 110:
						Gg.AbsMotion( CardNum,  Axis, System.Convert.ToDouble(System.Convert.ToInt32(Tools.HomeTempPos[CardNum, Axis] / ((Tools.PlusPerR[CardNum, Axis] * Tools.GeerRate[CardNum, Axis]) / Tools.LeadLength[CardNum, Axis])) + Offset), Tvel);
						HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 120; //跳转到下一步
						break;
						
					case (short) 120:
						PVar.Rtn = gts.GT_GetSts(CardNum, Axis, out Status, (short) 1, out temp_pClock); //获取当前轴的状态
						
						if (System.Convert.ToBoolean(Status & 0x400) == false) //判断当前轴是否运动停止
						{
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 130;
						}
						Tools.OldTime[CardNum, Axis] = System.Convert.ToInt32(API.GetTickCount());
						break;
						
					case (short) 130:
						
						if (System.Convert.ToInt32(API.GetTickCount()) - Tools.OldTime[CardNum, Axis] > 300)
						{
							HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
							Tools.HomeStep[CardNum, Axis] = (short) 140; //跳转到下一步
						}
						break;
						
					case (short) 140:
						
						PVar.Rtn = gts.GT_SetPrfPos(CardNum, Axis, 0); //将当前轴规划器位置修改为零点
						PVar.Rtn = gts.GT_SetEncPos(CardNum, Axis, 0); //将当前轴编码器位置修改为零点
						PVar.Rtn = gts.GT_SynchAxisPos(CardNum, (int) (Math.Pow(2, (Axis - 1)))); //将当前轴进行位置同步
						GoHome.AxisHome[CardNum, Axis].Result = true; //当前轴回原点成功
						HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 0; //跳转到下一步
						break;
						
					case (short) 150:
						
						GoHome.AxisHome[CardNum, Axis].Result = false; //当前轴回原点失败
						HomeR_tempLogStr = Tools.HomeStep[CardNum, Axis];
						Tools.HomeStep[CardNum, Axis] = (short) 0; //跳转到下一步
						break;
				}
			}
			
		}
		
	}
	
}
