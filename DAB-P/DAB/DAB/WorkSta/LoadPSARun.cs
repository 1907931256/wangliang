using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DAB
{
    sealed class LoadPSARun 
    { 
        private static Tool.Delay LoadPSATime = new Tool.Delay();
        private static int BufferStep = 0;
        private static string ErrName;
        private static int PickUpNumber = 0; //吸嘴取PSA计数
        public static event Action<string> ShowList;
        public static event Action<string> AddList;

        public static void AutoRun(ref PVar.WorkType StaWork)
        {
            try
            {
                switch (StaWork.Step)
                {
                    case 10:
                        if (PVar.Stop_Flag == false)
                        {
                            StaWork.State = false;
                            LoadPSATime.InitialTime();
                            StaWork.Step = 20;
                        }
                        break;

                    case 20:
                        if (PVar.空跑)
                        {
                            if (StaWork.State == false && StaWork.IsLoadPSA == false  && Gg.GetExDi(1, Gg.InPut2.PSA载台真空吸检测信号) == 0 &&
                                   (PVar.Sta_Work[(int)BVar.工位.流水线0].IsHaveFix || PVar.Sta_Work[(int)BVar.工位.流水线1].IsHaveFix || PVar.Sta_Work[(int)BVar.工位.流水线2].IsHaveFix))
                            {
                                AddList("PSA上料开始！");
                                StaWork.State = true;
                                PickUpNumber = 0;
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 0);
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 0);
                                Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                                LoadPSATime.InitialTime();
                                StaWork.Step = 30;
                            }
                            else if (LoadPSATime.TimeIsUp(50))
                            {
                                StaWork.Step = 10;
                            }
                        }
                        else//*****************************************************
                        {
                            if (StaWork.State == false && StaWork.IsLoadPSA == false && Gg.GetExDi(0, Gg.InPut1.PSA料仓夹紧气缸伸出) == 1 && Gg.GetExDi(1, Gg.InPut2.PSA料仓到位感应信号) == 1 && Gg.GetExDi(1, Gg.InPut2.PSA载台真空吸检测信号) == 0 &&
                                 (PVar.Sta_Work[(int)BVar.工位.流水线0].IsHaveFix || PVar.Sta_Work[(int)BVar.工位.流水线1].IsHaveFix || PVar.Sta_Work[(int)BVar.工位.流水线2].IsHaveFix))
                            {
                                AddList("PSA上料开始！");
                                StaWork.State = true;
                                PickUpNumber = 0;
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 0);
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 0);
                                Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                                LoadPSATime.InitialTime();
                                StaWork.Step = 30;
                            }
                            else if (LoadPSATime.TimeIsUp(50))
                            {
                                StaWork.Step = 10;
                            }
                        }
                        break;

                    case 30:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                            {
                            AddList("PSA搬运Y轴运动到取料位置！");
                            Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴吸料位置], PVar.ParAxis.Speed[Axis.PSA搬运Y轴]);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 40;
                            }
                        else if (LoadPSATime.TimeIsUp(5000))
                            {
                            AddList("PSA吸嘴升降气缸上感应信号异常！");
                            ShowList("PSA吸嘴升降气缸上感应信号异常！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 8000;
                            }
                        break;

                    case 40:
                        if (Gg.ZSPD(0, Axis.PSA搬运Y轴) == false && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0)
                            {
                            AddList("PSA吸嘴升降气缸上信号异常！");
                            ShowList("PSA吸嘴升降气缸上信号异常！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 10000;
                            }

                        if (Gg.ZSPD(0, Axis.PSA搬运Y轴))
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 50;
                            }
                        else if (LoadPSATime.TimeIsUp(5000))
                            {
                            AddList("PSA搬运Y轴运动超时！");
                            ShowList("PSA搬运Y轴运动超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 10000;
                            }
                        break;

                    case 50:
                        if (PVar.空跑)
                        {
                            AddList("PSA料仓上层感应到物料！");
                            Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 0);
                            Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 1);
                            Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                            AddList("PSA吸嘴升降气缸下降取料！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 90;
                        }
                        else
                        {
                            if (Gg.GetExDi(1, Gg.InPut2.PSA料仓上层感应) == 1)
                            {
                                AddList("PSA料仓上层感应到物料！");
                                LoadPSATime.InitialTime();
                                StaWork.Step = 60;
                            }
                            else
                            {
                                //当前位置已经到达最高处
                                if (Gg.GetPrfPosmm(0, Axis.PSA供料Z轴) >= mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴单片位置])
                                {
                                    //回到供料初始位置
                                    Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴初始位置], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);
                                    AddList("PSA物料用完,运动到初始位置！");
                                    ShowList("PSA物料用完,运动到初始位置！");
                                    Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 0);
                                    Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 0);
                                    Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                                    LoadPSATime.InitialTime();
                                    StaWork.Step = 1000;
                                }
                                else
                                {
                                    //继续顶PSA物料
                                    Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴单片位置], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);
                                    AddList("PSA料仓向上顶料！");
                                    LoadPSATime.InitialTime();
                                    StaWork.Step = 60;
                                }
                            }
                        }
                        break;

                    case 60:
                        if (Gg.GetExDi(1, Gg.InPut2.PSA料仓上层感应) == 1)
                            {
                            gts.GT_Stop(0, 1 << (Axis.PSA供料Z轴 - 1), 0);
                            AddList("感应到PSA物料，顶料轴停止！");
                            }
                        if (Gg.ZSPD(0, Axis.PSA供料Z轴) && Gg.GetExDi(1, Gg.InPut2.PSA料仓上层感应) == 0)
                            {
                            Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴初始位置], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);
                            AddList("PSA物料用完,运动到初始位置！");
                            ShowList("PSA物料用完,运动到初始位置！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 1000;
                            }
                        else if (Gg.ZSPD(0, Axis.PSA供料Z轴) && Gg.GetExDi(1, Gg.InPut2.PSA料仓上层感应) == 1)
                            {
                            Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴初始位置], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);
                            AddList("PSA料仓上层感应到物料！");
                           
                            LoadPSATime.InitialTime();
                            StaWork.Step = 70;
                            }
                        else if (Gg.ZSPD(0, Axis.PSA供料Z轴) ==false && LoadPSATime.TimeIsUp(5000))
                            {
                            AddList("PSA供料Z轴运动超时！");
                            ShowList("PSA供料Z轴运动超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 10000;
                            }
                        break;

                    case 70:
                        if (mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴单片位置] - Gg.GetPrfPosmm(0, Axis.PSA供料Z轴)>2)
                            {
                            //2mm/s的速度，按比例向上顶，防止料是倾斜的
                            Gg.AbsMotion(0, Axis.PSA供料Z轴, Gg.GetPrfPosmm(0, Axis.PSA供料Z轴) + (mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴单片位置] - Gg.GetPrfPosmm(0, Axis.PSA供料Z轴)) * 0.08, 2);
                            }
                        PickUpNumber += 1;
                        Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 0);
                        Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 1);
                        Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                        AddList("PSA吸嘴升降气缸下降取料！");
                        LoadPSATime.InitialTime();
                        StaWork.Step = 80;
                        break;

                    case 80:
                        if (Gg.GetExDi(1, Gg.InPut2.搬运PSA真空吸检测信号) == 1)
                            {
                            gts.GT_Stop(0, 1 << (Axis.PSA供料Z轴 - 1), 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 90;
                            }
                        else
                            {
                            if (Gg.ZSPD(0, Axis.PSA供料Z轴))
                                {
                                LoadPSATime.InitialTime();
                                StaWork.Step = 90;
                                }
                            }
                        break;

                    case 90:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 1)
                            {
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 100;
                            }
                        else if (LoadPSATime.TimeIsUp(3000))
                            {
                            AddList("PSA吸嘴升降气缸下降超时！");
                            ShowList("PSA吸嘴升降气缸下降超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 8000;
                            }
                        break;

                    case 100:
                        if (LoadPSATime.TimeIsUp(500))
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 120;
                            }
                        break;

                    case 120:
                        if (Gg.ZSPD(0, Axis.PSA供料Z轴))
                            {
                            AddList("PSA吸嘴升降气缸上升！");
                            Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 130;
                            }
                        break;

                    case 130:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 140;
                            }
                        else if (LoadPSATime.TimeIsUp(3000))
                            {
                            AddList("PSA吸嘴升降气缸上升超时！");
                            ShowList("PSA吸嘴升降气缸上升超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 8000;
                            }
                        break;

                    case 140:
                        if (LoadPSATime.TimeIsUp(500))
                        {
                            if (PVar.空跑)
                            {
                                AddList("PSA吸嘴升降气缸上升到位，真空吸OK！");
                                PickUpNumber = 0;
                                Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴放料位置], PVar.ParAxis.Speed[Axis.PSA搬运Y轴]);
                                LoadPSATime.InitialTime();
                                StaWork.Step = 150;
                            }
                            else
                            {
                                if (Gg.GetExDi(1, Gg.InPut2.搬运PSA真空吸检测信号) == 1)
                                {
                                    AddList("PSA吸嘴升降气缸上升到位，真空吸OK！");
                                    PickUpNumber = 0;
                                    Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴放料位置], PVar.ParAxis.Speed[Axis.PSA搬运Y轴]);
                                    LoadPSATime.InitialTime();
                                    StaWork.Step = 150;
                                }
                                else
                                {
                                    if (PickUpNumber > 1)
                                    {
                                        PickUpNumber = 0;
                                        AddList("PSA吸料真空异常,请检查！");
                                        ShowList("PSA吸料真空异常,请检查！");
                                        ErrName = "Foam吸料真空异常,请确认后继续";
                                        LoadPSATime.InitialTime();
                                        StaWork.Step = 6000;
                                    }
                                    else
                                    {
                                        Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                                        LoadPSATime.InitialTime();
                                        StaWork.Step = 70;
                                    }
                                }
                            }
                        }
                        break;

                    case 150:
                        if (Gg.ZSPD(0, Axis.PSA搬运Y轴))
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 160;
                            }
                        break;

                    case 160:
                        if (LoadPSATime.TimeIsUp(100))
                            {
                            AddList("吸嘴移动到中转台上方！");
                            Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 170;
                            }
                        break;

                    case 170://取料和载具平台很难保证统一平面，这里不判断气缸下信号
                        if (LoadPSATime.TimeIsUp(1500) && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0)
                            {
                            AddList("PSA吸嘴升降气缸下降到位！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 180;
                            }
                        break;

                    case 180:
                        if (LoadPSATime.TimeIsUp(200))
                            {
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 1);
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 0);

                                Gg.SetExDo(0,1, Gg.OutPut2.PSA载台破真空, 0);
                                Gg.SetExDo(0,1, Gg.OutPut2.PSA载台真空吸, 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 190;
                            }
                        break;

                    case 190:
                        if (LoadPSATime.TimeIsUp(1000))
                        {
                            if (PVar.空跑)
                            {
                                AddList("PSA载台真空吸检测信号OK！");
                                Gg.SetExDo(0,1, Gg.OutPut2.PSA载台真空吸, 0);
                                Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                                LoadPSATime.InitialTime();
                                StaWork.Step = 200;
                            }
                            else
                            {
                                if (Gg.GetExDi(1, Gg.InPut2.PSA载台真空吸检测信号) == 1)
                                {
                                    AddList("PSA载台真空吸检测信号OK！");
                                    Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                                    LoadPSATime.InitialTime();
                                    StaWork.Step = 200;
                                }
                                else
                                {
                                    AddList("PSA载台真空吸检测信号异常，请检查！");
                                    Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                                    ErrName = "Foam承接平台真空异常,请确认后继续";
                                    LoadPSATime.InitialTime();
                                    StaWork.Step = 7000;
                                }
                            }
                        }
                        break;

                    case 200:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 210;
                            }
                        else if (LoadPSATime.TimeIsUp(3000))
                            {
                            AddList("PSA吸嘴升降气缸上升超时！");
                            ShowList("PSA吸嘴升降气缸上升超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 8000;
                            }
                        break;

                    case 210:
                        if (LoadPSATime.TimeIsUp(300))
                            {
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA破真空, 0);
                                Gg.SetExDo(0,1, Gg.OutPut2.搬运PSA真空吸, 0);
                            Gg.AbsMotion(0, Axis.PSA搬运Y轴, mFunction.Pos.TeachAxis1[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Y轴吸料位置], PVar.ParAxis.Speed[Axis.PSA搬运Y轴]);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 220;
                            }
                        break;

                    case 220:
                        if (Gg.ZSPD(0, Axis.PSA搬运Y轴) == false && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 0)
                            {
                            AddList("PSA吸嘴升降气缸上信号异常！");
                            ShowList("PSA吸嘴升降气缸上信号异常！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 10000;
                            }

                        if (Gg.ZSPD(0, Axis.PSA搬运Y轴))
                            {
                            StaWork.IsHavePSA = true;//给取PSA信号
                            LoadPSATime.InitialTime();
                            StaWork.Step = 300;
                            }
                        else if (LoadPSATime.TimeIsUp(5000))
                            {
                            AddList("PSA搬运Y轴运动超时！");
                            ShowList("PSA搬运Y轴运动超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 10000;
                            }
                        break;

                    case 300:
                        LoadPSATime.InitialTime();
                        StaWork.Step = 310;
                        break;

                    case 310:
                        if (StaWork.IsHavePSA == false)
                            {
                            LoadPSATime.InitialTime();
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

                    case 6000:
                        if (MessageBox.Show(ErrName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                        {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 6010;
                        }
                        else
                        {
                            Gg.SetExDo(0, 0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                            Gg.AbsMotion(0, Axis.PSA供料Z轴, mFunction.Pos.TeachAxis2[Axis.tTag.PSA供料, Axis.Point供料PSA.PSA_Z轴初始位置], PVar.ParAxis.Speed[Axis.PSA供料Z轴]);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 1000;
                        }
                        break;

                    case 6010:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                            {
                                Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 70;
                            }
                        else 
                            {
                                Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 6020;
                            }
                        break;

                    case 6020:
                        if (Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸上) == 1 && Gg.GetExDi(0, Gg.InPut1.PSA吸嘴升降气缸下) == 0)
                            {
                                Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 1);
                            LoadPSATime.InitialTime();
                            StaWork.Step = 70;
                            }
                        else if (LoadPSATime.TimeIsUp(3000))
                            {
                            AddList("PSA吸嘴升降气缸上升超时！");
                            ShowList("PSA吸嘴升降气缸上升超时！");
                            LoadPSATime.InitialTime();
                            StaWork.Step = 8000;
                            }
                        break;

                    case 7000:
                        if (MessageBox.Show(ErrName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 160;
                            }
                        else
                            {
                            LoadPSATime.InitialTime();
                            StaWork.Step = 10;
                            }
                        break;


                    case 8000:
                        Gg.SetExDo(0,0, Gg.OutPut1.PSA吸嘴升降气缸, 0);
                        StaWork.Enable = false;
                        StaWork.Result = false;
                        StaWork.State = false;
                        StaWork.Step = 10;
                        Frm_Engineering.fEngineering.MacStop();                       
                        break;


                    //遇到异常，设备先暂停，确定后处理************************
                    case 8800:
                        if (Manual.AutoMotionFlag[3])
                        {
                            if (Manual.HoldFlag[3])
                            {
                                Manual.HoldFlag[3] = false;
                                Frm_Engineering.fEngineering.CmdHoldPress.Text = "暂停";
                                Frm_Engineering.fEngineering.CmdHoldPress.BackColor = Color.BurlyWood;
                                ShowList("运动已继续");
                            }
                            else
                            {
                                Manual.HoldFlag[3] = true;
                                Frm_Engineering.fEngineering.CmdHoldPress.Text = "继续";
                                Frm_Engineering.fEngineering.CmdHoldPress.BackColor = Color.Red;
                                ShowList("运动已暂停");
                            }
                        }
                        else
                        {
                            PVar.IsSystemOnPauseMode = true;
                            PVar.MacHold = true;
                            StaWork.StaHold = true;
                            PVar.Stop_Flag = false;
                            Frm_Main.fMain.Btn_Start.Enabled = false;
                            Frm_Main.fMain.Btn_Pause.Enabled = true;
                            Frm_Main.fMain.Btn_Stop.Enabled = false;
                            Frm_Main.fMain.Btn_Start.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                            Frm_Main.fMain.Btn_Pause.BZ_BackColor = PVar.BZColor_SelectedEndBtn;
                            Frm_Main.fMain.Btn_Stop.BZ_BackColor = PVar.BZColor_UnselectedBtn;
                            Frm_Engineering.fEngineering.Auto_Timer.Enabled = false;
                        }

                        PVar.LampStatus = 20;
                        StaWork.Step = BufferStep;
                        break;

                    //严重错误，急停处理
                    case 10000:
                        Frm_Engineering.fEngineering.MacStop();
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


    }
}
