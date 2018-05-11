using System.Runtime.InteropServices;

namespace DAB
    {
    public class gts
        {
        public const short MC_NONE = -1;

        public const short MC_LIMIT_POSITIVE = 0;
        public const short MC_LIMIT_NEGATIVE = 1;
        public const short MC_ALARM = 2;
        public const short MC_HOME = 3;
        public const short MC_GPI = 4;
        public const short MC_ARRIVE = 5;

        public const short MC_ENABLE = 10;
        public const short MC_CLEAR = 11;
        public const short MC_GPO = 12;

        public const short MC_DAC = 20;
        public const short MC_STEP = 21;
        public const short MC_PULSE = 22;
        public const short MC_ENCODER = 23;
        public const short MC_ADC = 24;

        public const short MC_AXIS = 30;
        public const short MC_PROFILE = 31;
        public const short MC_CONTROL = 32;

        public const short CAPTURE_HOME = 1;
        public const short CAPTURE_INDEX = 2;
        public const short CAPTURE_PROBE = 3;
        public const short CAPTURE_HSIO0 = 6;
        public const short CAPTURE_HSIO1 = 7;

        public const short PT_MODE_STATIC = 0;
        public const short PT_MODE_DYNAMIC = 1;

        public const short PT_SEGMENT_NORMAL = 0;
        public const short PT_SEGMENT_EVEN = 1;
        public const short PT_SEGMENT_STOP = 2;

        public const short GEAR_MASTER_ENCODER = 1;
        public const short GEAR_MASTER_PROFILE = 2;
        public const short GEAR_MASTER_AXIS = 3;

        public const short FOLLOW_MASTER_ENCODER = 1;
        public const short FOLLOW_MASTER_PROFILE = 2;
        public const short FOLLOW_MASTER_AXIS = 3;

        public const short FOLLOW_EVENT_START = 1;
        public const short FOLLOW_EVENT_PASS = 2;

        public const short GEAR_EVENT_START = 1;
        public const short GEAR_EVENT_PASS = 2;
        public const short GEAR_EVENT_AREA = 5;

        public const short FOLLOW_SEGMENT_NORMAL = 0;
        public const short FOLLOW_SEGMENT_EVEN = 1;
        public const short FOLLOW_SEGMENT_STOP = 2;
        public const short FOLLOW_SEGMENT_CONTINUE = 3;

        public const short INTERPOLATION_AXIS_MAX = 4;
        public const short CRD_FIFO_MAX = 4096;
        public const short CRD_MAX = 2;
        public const short CRD_OPERATION_DATA_EXT_MAX = 2;

        public const short CRD_OPERATION_TYPE_NONE = 0;
        public const short CRD_OPERATION_TYPE_BUF_IO_DELAY = 1;
        public const short CRD_OPERATION_TYPE_LASER_ON = 2;
        public const short CRD_OPERATION_TYPE_LASER_OFF = 3;
        public const short CRD_OPERATION_TYPE_BUF_DA = 4;
        public const short CRD_OPERATION_TYPE_LASER_CMD = 5;
        public const short CRD_OPERATION_TYPE_LASER_FOLLOW = 6;
        public const short CRD_OPERATION_TYPE_LMTS_ON = 7;
        public const short CRD_OPERATION_TYPE_LMTS_OFF = 8;
        public const short CRD_OPERATION_TYPE_SET_STOP_IO = 9;
        public const short CRD_OPERATION_TYPE_BUF_MOVE = 10;
        public const short CRD_OPERATION_TYPE_BUF_GEAR = 11;
        public const short CRD_OPERATION_TYPE_SET_SEG_NUM = 12;
        public const short CRD_OPERATION_TYPE_STOP_MOTION = 13;
        public const short CRD_OPERATION_TYPE_SET_VAR_VALUE = 14;
        public const short CRD_OPERATION_TYPE_JUMP_NEXT_SEG = 15;
        public const short CRD_OPERATION_TYPE_SYNCH_PRF_POS = 16;
        public const short CRD_OPERATION_TYPE_VIRTUAL_TO_ACTUAL = 17;
        public const short CRD_OPERATION_TYPE_SET_USER_VAR = 18;
        public const short CRD_OPERATION_TYPE_SET_DO_BIT_PULSE = 19;

        public const short INTERPOLATION_MOTION_TYPE_LINE = 0;
        public const short INTERPOLATION_MOTION_TYPE_CIRCLE = 1;
        public const short INTERPOLATION_MOTION_TYPE_HELIX = 2;

        public const short INTERPOLATION_CIRCLE_PLAT_XY = 0;
        public const short INTERPOLATION_CIRCLE_PLAT_YZ = 1;
        public const short INTERPOLATION_CIRCLE_PLAT_ZX = 2;

        public const short INTERPOLATION_HELIX_CIRCLE_XY_LINE_Z = 0;
        public const short INTERPOLATION_HELIX_CIRCLE_YZ_LINE_X = 1;
        public const short INTERPOLATION_HELIX_CIRCLE_ZX_LINE_Y = 2;

        public const short INTERPOLATION_CIRCLE_DIR_CW = 0;
        public const short INTERPOLATION_CIRCLE_DIR_CCW = 1;


        public struct TTrapPrm
            {
            public double acc;
            public double dec;
            public double velStart;
            public short smoothTime;
            }

        public struct TJogPrm
            {
            public double acc;
            public double dec;
            public double smooth;
            }

        public struct TPid
            {
            public double kp;
            public double ki;
            public double kd;
            public double kvff;
            public double kaff;

            public int integralLimit;
            public int derivativeLimit;
            public short limit;
            }

        public struct TThreadSts
            {
            public short run;
            public short error;
            public double result;
            public short line;
            }

        public struct TVarInfo
            {
            public short id;
            public short dataType;
            public double dumb0;
            public double dumb1;
            public double dumb2;
            public double dumb3;
            }

        public struct TCrdPrm
            {
            public short dimension;
            public short profile1;
            public short profile2;
            public short profile3;
            public short profile4;
            public short profile5;
            public short profile6;
            public short profile7;
            public short profile8;

            public double synVelMax;
            public double synAccMax;
            public short evenTime;
            public short setOriginFlag;
            public long originPos1;
            public long originPos2;
            public long originPos3;
            public long originPos4;
            public long originPos5;
            public long originPos6;
            public long originPos7;
            public long originPos8;
            }

        public struct TCrdBufOperation
            {
            public short flag;
            public ushort delay;
            public short doType;
            public ushort doMask;
            public ushort doValue;
            public ushort dataExt1;
            public ushort dataExt2;
            }

        public struct TCrdData
            {
            public short motionType;
            public short circlePlat;
            public long posX;
            public long posY;
            public long posZ;
            public long posA;
            public double radius;
            public short circleDir;
            public double lCenterX;
            public double lCenterY;
            public double vel;
            public double acc;
            public short velEndZero;
            public TCrdBufOperation operation;

            public double cosX;
            public double cosY;
            public double cosZ;
            public double cosA;
            public double velEnd;
            public double velEndAdjust;
            public double r;
            }

        public struct TTrigger
            {
            public short encoder;
            public short probeType;
            public short probeIndex;
            public short offset;
            public short windowOnly;
            public long firstPosition;
            public long lastPosition;
            }

        public struct TTriggerStatus
            {
            public short execute;
            public short done;
            public long position;
            }

        [DllImport("gts.dll")]
        public static extern short GT_SetCardNo(short cardNum);
        [DllImport("gts.dll")]
        public static extern short GT_GetCardNo(short cardNum, out short index);

        [DllImport("gts.dll")]
        public static extern short GT_Open(short cardNum, short channel, short param);
        [DllImport("gts.dll")]
        public static extern short GT_Close(short cardNum);

        [DllImport("gts.dll")]
        public static extern short GT_LoadConfig(short cardNum, string pFile);

        [DllImport("gts.dll")]
        public static extern short GT_GetVersion(short cardNum, out string pVersion);

        [DllImport("gts.dll")]
        public static extern short GT_SetDo(short cardNum, short doType, int value);
        [DllImport("gts.dll")]
        public static extern short GT_SetDoBit(short cardNum, short doType, short doIndex, short value);
        [DllImport("gts.dll")]
        public static extern short GT_GetDo(short cardNum, short doType, out int pValue);
        [DllImport("gts.dll")]
        public static extern short GT_SetDoBitReverse(short cardNum, short doType, short doIndex, short value, short reverseTime);

        [DllImport("gts.dll")]
        public static extern short GT_GetDi(short cardNum, short diType, out int pValue);
        [DllImport("gts.dll")]
        public static extern short GT_GetDiReverseCount(short cardNum, short diType, short diIndex, out uint reverseCount, short count);
        [DllImport("gts.dll")]
        public static extern short GT_SetDiReverseCount(short cardNum, short diType, short diIndex, ref uint reverseCount, short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetDiRaw(short cardNum, short diType, out int pValue);

        [DllImport("gts.dll")]
        public static extern short GT_SetDac(short cardNum, short dac, ref short value, short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetDac(short cardNum, short dac, out short value, short count, out uint pClock);

        [DllImport("gts.dll")]
        public static extern short GT_GetAdc(short cardNum, short adc, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAdcValue(short cardNum, short adc, out short pValue, short count, out uint pClock);

        [DllImport("gts.dll")]
        public static extern short GT_SetEncPos(short cardNum, short encoder, int encPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncPos(short cardNum, short encoder, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetEncVel(short cardNum, short encoder, out double pValue, short count, out uint pClock);

        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureMode(short cardNum, short encoder, short mode);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureMode(short cardNum, short encoder, out short pMode, short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetCaptureStatus(short cardNum, short encoder, out short pStatus, out int pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_SetCaptureSense(short cardNum, short encoder, short mode, short sense);
        [DllImport("gts.dll")]
        public static extern short GT_ClearCaptureStatus(short cardNum, short encoder);

        [DllImport("gts.dll")]
        public static extern short GT_Reset(short cardNum);
        [DllImport("gts.dll")]
        public static extern short GT_GetClock(short cardNum, out uint pClock, out uint pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_GetClockHighPrecision(short cardNum, out uint pClock);

        [DllImport("gts.dll")]
        public static extern short GT_GetSts(short cardNum, short axis, out int pSts, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_ClrSts(short cardNum, short axis, short count);
        [DllImport("gts.dll")]
        public static extern short GT_AxisOn(short cardNum, short axis);
        [DllImport("gts.dll")]
        public static extern short GT_AxisOff(short cardNum, short axis);
        [DllImport("gts.dll")]
        public static extern short GT_Stop(short cardNum, int mask, int option);
        [DllImport("gts.dll")]
        public static extern short GT_SetPrfPos(short cardNum, short profile, int prfPos);
        [DllImport("gts.dll")]
        public static extern short GT_SynchAxisPos(short cardNum, int mask);
        [DllImport("gts.dll")]
        public static extern short GT_ZeroPos(short cardNum, short axis, short count);

        [DllImport("gts.dll")]
        public static extern short GT_SetSoftLimit(short cardNum, short axis, int positive, int negative);
        [DllImport("gts.dll")]
        public static extern short GT_GetSoftLimit(short cardNum, short axis, out int pPositive, out int pNegative);
        [DllImport("gts.dll")]
        public static extern short GT_SetAxisBand(short cardNum, short axis, int band, int time);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisBand(short cardNum, short axis, out int pBand, out int pTime);
        [DllImport("gts.dll")]
        public static extern short GT_SetBacklash(short cardNum, short axis, int compValue, double compChangeValue, int compDir);
        [DllImport("gts.dll")]
        public static extern short GT_GetBacklash(short cardNum, short axis, out int pCompValue, out double pCompChangeValue, out int pCompDir);

        [DllImport("gts.dll")]
        public static extern short GT_GetPrfPos(short cardNum, short profile, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfVel(short cardNum, short profile, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfAcc(short cardNum, short profile, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetPrfMode(short cardNum, short profile, out int pValue, short count, out uint pClock);

        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfPos(short cardNum, short axis, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfVel(short cardNum, short axis, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisPrfAcc(short cardNum, short axis, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncPos(short cardNum, short axis, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncVel(short cardNum, short axis, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisEncAcc(short cardNum, short axis, out double pValue, short count, out uint pClock);
        [DllImport("gts.dll")]
        public static extern short GT_GetAxisError(short cardNum, short axis, out double pValue, short count, out uint pClock);

        [DllImport("gts.dll")]
        public static extern short GT_SetControlFilter(short cardNum, short control, short index);
        [DllImport("gts.dll")]
        public static extern short GT_GetControlFilter(short cardNum, short control, out short pIndex);

        [DllImport("gts.dll")]
        public static extern short GT_SetPid(short cardNum, short control, short index, ref TPid pPid);
        [DllImport("gts.dll")]
        public static extern short GT_GetPid(short cardNum, short control, short index, out TPid pPid);

        [DllImport("gts.dll")]
        public static extern short GT_Update(short cardNum, int mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetPos(short cardNum, short profile, int pos);
        [DllImport("gts.dll")]
        public static extern short GT_GetPos(short cardNum, short profile, out int pPos);
        [DllImport("gts.dll")]
        public static extern short GT_SetVel(short cardNum, short profile, double vel);
        [DllImport("gts.dll")]
        public static extern short GT_GetVel(short cardNum, short profile, out double pVel);

        [DllImport("gts.dll")]
        public static extern short GT_PrfTrap(short cardNum, short profile);
        [DllImport("gts.dll")]
        public static extern short GT_SetTrapPrm(short cardNum, short profile, ref TTrapPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetTrapPrm(short cardNum, short profile, out TTrapPrm pPrm);

        [DllImport("gts.dll")]
        public static extern short GT_PrfJog(short cardNum, short profile);
        [DllImport("gts.dll")]
        public static extern short GT_SetJogPrm(short cardNum, short profile, ref TJogPrm pPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetJogPrm(short cardNum, short profile, out TJogPrm pPrm);

        [DllImport("gts.dll")]
        public static extern short GT_PrfPt(short cardNum, short profile, short mode);
        [DllImport("gts.dll")]
        public static extern short GT_SetPtLoop(short cardNum, short profile, int loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtLoop(short cardNum, short profile, out int pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_PtSpace(short cardNum, short profile, out short pSpace, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtData(short cardNum, short profile, double pos, int time, short type, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtClear(short cardNum, short profile, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_PtStart(short cardNum, int mask, int option);
        [DllImport("gts.dll")]
        public static extern short GT_SetPtMemory(short cardNum, short profile, short memory);
        [DllImport("gts.dll")]
        public static extern short GT_GetPtMemory(short cardNum, short profile, out short pMemory);

        [DllImport("gts.dll")]
        public static extern short GT_PrfGear(short cardNum, short profile, short dir);
        [DllImport("gts.dll")]
        public static extern short GT_SetGearMaster(short cardNum, short profile, short masterIndex, short masterType, short masterItem);
        [DllImport("gts.dll")]
        public static extern short GT_GetGearMaster(short cardNum, short profile, out short pMasterIndex, out short pMasterType, out short pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GT_SetGearRatio(short cardNum, short profile, int masterEven, int slaveEven, int masterSlope);
        [DllImport("gts.dll")]
        public static extern short GT_GetGearRatio(short cardNum, short profile, out int pMasterEven, out int pSlaveEven, out int pMasterSlope);
        [DllImport("gts.dll")]
        public static extern short GT_GearStart(short cardNum, int mask);

        [DllImport("gts.dll")]
        public static extern short GT_PrfFollow(short cardNum, short profile, short dir);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowMaster(short cardNum, short profile, short masterIndex, short masterType, short masterItem);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowMaster(short cardNum, short profile, out short pMasterIndex, out short pMasterType, out short pMasterItem);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowLoop(short cardNum, short profile, int loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowLoop(short cardNum, short profile, out int pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowEvent(short cardNum, short profile, short followEvent, short masterDir, int pos);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowEvent(short cardNum, short profile, out short pFollowEvent, out short pMasterDir, out int pPos);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSpace(short cardNum, short profile, out short pSpace, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowData(short cardNum, short profile, int masterSegment, double slaveSegment, short type, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowClear(short cardNum, short profile, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_FollowStart(short cardNum, int mask, int option);
        [DllImport("gts.dll")]
        public static extern short GT_FollowSwitch(short cardNum, int mask);
        [DllImport("gts.dll")]
        public static extern short GT_SetFollowMemory(short cardNum, short profile, short memory);
        [DllImport("gts.dll")]
        public static extern short GT_GetFollowMemory(short cardNum, short profile, out short memory);

        [DllImport("gts.dll")]
        public static extern short GT_Download(short cardNum, string pFileName);

        [DllImport("gts.dll")]
        public static extern short GT_GetFunId(short cardNum, string pFunName, out short pFunId);
        [DllImport("gts.dll")]
        public static extern short GT_Bind(short cardNum, short thread, short funId, short page);

        [DllImport("gts.dll")]
        public static extern short GT_RunThread(short cardNum, short thread);
        [DllImport("gts.dll")]
        public static extern short GT_StopThread(short cardNum, short thread);
        [DllImport("gts.dll")]
        public static extern short GT_PauseThread(short cardNum, short thread);

        [DllImport("gts.dll")]
        public static extern short GT_GetThreadSts(short cardNum, short thread, out TThreadSts pThreadSts);

        [DllImport("gts.dll")]
        public static extern short GT_GetVarId(short cardNum, string pFunName, string pVarName, out TVarInfo pVarInfo);
        [DllImport("gts.dll")]
        public static extern short GT_SetVarValue(short cardNum, short page, ref TVarInfo pVarInfo, ref double pValue, short count);
        [DllImport("gts.dll")]
        public static extern short GT_GetVarValue(short cardNum, short page, ref TVarInfo pVarInfo, out double pValue, short count);

        [DllImport("gts.dll")]
        public static extern short GT_SetCrdPrm(short cardNum, short crd, ref TCrdPrm pCrdPrm);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdPrm(short cardNum, short crd, out TCrdPrm pCrdPrm);
        [DllImport("gts.dll")]
        public static extern short GT_CrdSpace(short cardNum, short crd, out int pSpace, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdData(short cardNum, short crd, short pCrdData, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdStart(short cardNum, short mask, short option);
        [DllImport("gts.dll")]
        public static extern short GT_SetOverride(short cardNum, short crd, double synVelRatio);
        [DllImport("gts.dll")]
        public static extern short GT_InitLookAhead(short cardNum, short crd, short fifo, double T, double accMax, short n, ref TCrdData pLookAheadBuf);
        [DllImport("gts.dll")]
        public static extern short GT_CrdClear(short cardNum, short crd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_CrdStatus(short cardNum, short crd, out short pRun, out int pSegment, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_SetUserSegNum(short cardNum, short crd, int segNum, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetUserSegNum(short cardNum, short crd, out int pSegment, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_GetRemainderSegNum(short cardNum, short crd, out int pSegment, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_SetCrdStopDec(short cardNum, short crd, double decSmoothStop, double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdStopDec(short cardNum, short crd, out double pDecSmoothStop, out double pDecAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdPos(short cardNum, short crd, out double pPos);
        [DllImport("gts.dll")]
        public static extern short GT_GetCrdVel(short cardNum, short crd, out double pSynVel);

        [DllImport("gts.dll")]
        public static extern short GT_PrfPvt(short cardNum, short profile);
        [DllImport("gts.dll")]
        public static extern short GT_SetPvtLoop(short cardNum, short profile, int loop);
        [DllImport("gts.dll")]
        public static extern short GT_GetPvtLoop(short cardNum, short profile, out int pLoopCount, out int pLoop);
        [DllImport("gts.dll")]
        public static extern short GT_PvtStatus(short cardNum, short profile, out short pTableId, out double pTime, short count);
        [DllImport("gts.dll")]
        public static extern short GT_PvtStart(short cardNum, int mask);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableSelect(short cardNum, short profile, short tableId);

        [DllImport("gts.dll")]
        public static extern short GT_PvtTable(short cardNum, short tableId, int count, ref double pTime, ref double pPos, ref double pVel);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableEx(short cardNum, short tableId, int count, ref double pTime, ref double pPos, ref double pVelBegin, ref double pVelEnd);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableComplete(short cardNum, short tableId, int count, ref double pTime, ref double pPos, ref double pA, ref double pB, ref double pC, double velBegin, double velEnd);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTablePercent(short cardNum, short tableId, int count, ref double pTime, ref double pPos, ref double pPercent, double velBegin);
        [DllImport("gts.dll")]
        public static extern short GT_PvtPercentCalculate(short cardNum, int n, ref double pTime, ref double pPos, ref double pPercent, double velBegin, ref double pVel);
        [DllImport("gts.dll")]
        public static extern short GT_PvtTableContinuous(short cardNum, short tableId, int count, ref double pPos, ref double pVel, ref double pPercent, ref double pVelMax, ref double pAcc, ref double pDec, double timeBegin);
        [DllImport("gts.dll")]
        public static extern short GT_PvtContinuousCalculate(short cardNum, int n, ref double pPos, ref double pVel, ref double pPercent, ref double pVelMax, ref double pAcc, ref double pDec, ref double pTime);

        [DllImport("gts.dll")]
        public static extern short GT_AlarmOff(short cardNum, short axis);
        [DllImport("gts.dll")]
        public static extern short GT_AlarmOn(short cardNum, short axis);
        [DllImport("gts.dll")]
        public static extern short GT_LmtsOn(short cardNum, short axis, short limitType);
        [DllImport("gts.dll")]
        public static extern short GT_LmtsOff(short cardNum, short axis, short limitType);
        [DllImport("gts.dll")]
        public static extern short GT_ProfileScale(short cardNum, short axis, short alpha, short beta);
        [DllImport("gts.dll")]
        public static extern short GT_EncScale(short cardNum, short axis, short alpha, short beta);
        [DllImport("gts.dll")]
        public static extern short GT_StepDir(short cardNum, short step);
        [DllImport("gts.dll")]
        public static extern short GT_StepPulse(short cardNum, short step);
        [DllImport("gts.dll")]
        public static extern short GT_SetMtrBias(short cardNum, short dac, short bias);
        [DllImport("gts.dll")]
        public static extern short GT_GetMtrBias(short cardNum, short dac, out short pBias);
        [DllImport("gts.dll")]
        public static extern short GT_SetMtrLmt(short cardNum, short dac, short limit);
        [DllImport("gts.dll")]
        public static extern short GT_GetMtrLmt(short dac, out short pLimit);
        [DllImport("gts.dll")]
        public static extern short GT_EncSns(short cardNum, ushort sense);
        [DllImport("gts.dll")]
        public static extern short GT_EncOn(short cardNum, short encoder);
        [DllImport("gts.dll")]
        public static extern short GT_EncOff(short cardNum, short encoder);
        [DllImport("gts.dll")]
        public static extern short GT_SetPosErr(short cardNum, short control, int error);
        [DllImport("gts.dll")]
        public static extern short GT_GetPosErr(short cardNum, short control, out int pError);
        [DllImport("gts.dll")]
        public static extern short GT_SetStopDec(short cardNum, short profile, double decSmoothStop, double decAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_GetStopDec(short cardNum, short profile, out double pDecSmoothStop, out double pDecAbruptStop);
        [DllImport("gts.dll")]
        public static extern short GT_LmtSns(short cardNum, ushort sense);
        [DllImport("gts.dll")]
        public static extern short GT_CtrlMode(short cardNum, short axis, short mode);
        [DllImport("gts.dll")]
        public static extern short GT_SetStopIo(short cardNum, short axis, short stopType, short inputType, short inputIndex);
        [DllImport("gts.dll")]
        public static extern short GT_GpiSns(short cardNum, ushort sense);

        [DllImport("gts.dll")]
        public static extern short GT_CrdDataCircle(short cardNum, short crd, ref TCrdData pCrdData, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXY(short cardNum, short crd, int x, int y, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZ(short cardNum, short crd, int x, int y, int z, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZA(short cardNum, short crd, int x, int y, int z, int a, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYG0(short cardNum, short crd, int x, int y, double synVel, double synAcc, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZG0(short cardNum, short crd, int x, int y, int z, double synVel, double synAcc, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_LnXYZAG0(short cardNum, short crd, int x, int y, int z, int a, double synVel, double synAcc, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYR(short cardNum, short crd, int x, int y, double radius, short circleDir, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcXYC(short cardNum, short crd, int x, int y, double xCenter, double yCenter, short circleDir, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZR(short cardNum, short crd, int y, int z, double radius, short circleDir, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcYZC(short cardNum, short crd, int y, int z, double yCenter, double zCenter, short circleDir, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXR(short cardNum, short crd, int z, int x, double radius, short circleDir, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_ArcZXC(short cardNum, short crd, int z, int x, double zCenter, double xCenter, short circleDir, double synVel, double synAcc, double velEnd, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufIO(short cardNum, short crd, ushort doType, ushort doMask, ushort doValue, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDelay(short cardNum, short crd, ushort delayTime, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufDA(short cardNum, short crd, short chn, short daValue, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufLmtsOn(short cardNum, short crd, short axis, short limitType, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufLmtsOff(short cardNum, short crd, short axis, short limitType, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufSetStopIo(short cardNum, short crd, short axis, short stopType, short inputType, short inputIndex, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufMove(short cardNum, short crd, short moveAxis, int pos, double vel, double acc, short modal, short fifo);
        [DllImport("gts.dll")]
        public static extern short GT_BufGear(short cardNum, short crd, short gearAxis, int pos, short fifo);

        [DllImport("gts.dll")]
        public static extern short GT_HomeInit(short cardNum);
        [DllImport("gts.dll")]
        public static extern short GT_Home(short cardNum, short axis, int pos, double vel, double acc, int offset);
        [DllImport("gts.dll")]
        public static extern short GT_Index(short cardNum, short axis, int pos, int offset);
        [DllImport("gts.dll")]
        public static extern short GT_HomeStop(short cardNum, short axis, int pos, double vel, double acc);
        [DllImport("gts.dll")]
        public static extern short GT_HomeSts(short cardNum, short axis, out ushort pStatus);

        [DllImport("gts.dll")]
        public static extern short GT_ComparePulse(short cardNum, short level, short outputType, short time);
        [DllImport("gts.dll")]
        public static extern short GT_CompareStop(short cardNum);
        [DllImport("gts.dll")]
        public static extern short GT_CompareStatus(short cardNum, out short pStatus, out int pCount);
        [DllImport("gts.dll")]
        public static extern short GT_CompareData(short cardNum, short encoder, short source, short pulseType, short startLevel, short time, ref int pBuf1, short count1, ref int pBuf2, short count2);
        [DllImport("gts.dll")]
        public static extern short GT_CompareLinear(short cardNum, short encoder, short channel, int startPos, int repeatTimes, int interval, short time, short source);

        [DllImport("gts.dll")]
        public static extern short GT_OpenExtMdlGts(short cardNum, string pDllName);
        [DllImport("gts.dll")]
        public static extern short GT_CloseExtMdlGts(short cardNum);
        [DllImport("gts.dll")]
        public static extern short GT_SwitchtoCardNoExtMdlGts(short cardNum, short card);
        [DllImport("gts.dll")]
        public static extern short GT_ResetExtMdlGts(short cardNum);
        [DllImport("gts.dll")]
        public static extern short GT_LoadExtConfigGts(short cardNum, string fileName);
        [DllImport("gts.dll")]
        public static extern short GT_SetExtIoValueGts(short cardNum, short mdl, ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_GetExtIoValueGts(short cardNum, short mdl, ref ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_SetExtIoBitGts(short cardNum, short mdl, short index, ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_GetExtIoBitGts(short cardNum, short mdl, short index, ref ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_GetExtAdValueGts(short cardNum, short mdl, short chn, ref ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_GetExtAdVoltageGts(short cardNum, short mdl, short chn, ref double value);
        [DllImport("gts.dll")]
        public static extern short GT_SetExtDaValueGts(short cardNum, short mdl, short chn, ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_SetExtDaVoltageGts(short cardNum, short mdl, short chn, double value);
        [DllImport("gts.dll")]
        public static extern short GT_GetStsExtMdlGts(short cardNum, short mdl, short chn, ref ushort value);
        [DllImport("gts.dll")]
        public static extern short GT_GetExtDoValueGts(short cardNum, short mdl, ref ushort value);
        }
    }
