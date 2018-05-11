'''Updata 20180505

Integer NetPort201, NetPort202, count
Integer ForceValue
String DataBuffer$, Buffer$
Global String Item$, Axis$, Direction$
Global String CMDFsc$
Global Integer ActiveStep, PalletNum, ProductNum, Px, ActiveStep1
Global Real Axis_Speed, OffsetX, OffsetY, OffsetZ, OffsetR, Length, Axis_SpeedS
Real myForces(8)	'声明实类型的变量。( 4字节实数)。存放压力数组
Global String PosJudge$
Global Integer Local_Num

Function Main
	CMDFsc$ = "Play"
	'2 FS_File文件中有4页，分别为FC:压力控制/FT:压力触发/FCS:压力坐标系/FM:监视器 
	'使用这些功能需要设置对应的参数

'	FSet FM1.ForceSensor, 1 '设置压力传感器编号
'	FSet FCS1.Orientation, 0	'设置力坐标数据
'
'
'	FSet FC1.CoordinateSystem, FCS0 '指定或返回力的坐标系
'	FSet FM1.CoordinateSystem, FCS0 '指定或返回力的坐标系
'	FSet FM1.LPF_Enabled, False, False, True, False, False, False, False, False '启用/禁用或同时返回应用于每个轴的低通滤波器。
'	FSet FM1.LPF_TimeConstants, 0.02, 0.02, 0.02, 0.02, 0.02, 0.02 '这将设置或返回同时应用于力坐标系中每个轴的低通滤波器时间常数的值。
'	FSet FC1.Enabled, True, False, False, False, False, False
'	FSet FC1.TargetForces, 0, 0, 20, 0, 0, 0
'	FSet FC1.Fz_Spring, 0 '设置虚拟外汇弹性系数
'	FSet FC1.Fz_Damper, 2 '设置粘度的虚拟外汇系数
'	FSet FC1.Fz_Mass, 1	'设置虚拟外汇惯性系数
'	FSet FC1.LimitSpeedS, 5	'将最大关节加速度设置为5 [毫米/秒2 ]
'	FSet FC1.LimitAccelS, 500	'将最大关节加速度设置为5 [毫米/秒2 ]
	
'	FLoad "Myforce.frc"		'加载压力设置文件
'	FSet FS1.Reset '复位压力传感器并清零
	
'	Go P0
'	Go P4
'	Move P4 FC1
'	Wait 1
'	If FCOn(1) = Off Then	'FCOn(RobotNo)
'   		Print "力控制功能处于非活动状态"
' 	EndIf
 	count = 1
	Call Init	'函数作为子程序的呼出
   	Xqt Auto 	'执行用函数名指定的任务。
   	Wait 2
   	Xqt LiveData 	'执行用函数名指定的任务
Fend

'机械手控制器初始化
Function Init
	Motor On			'机械手的伺服上电
	Power Low			'设置电源模式为高功率模式  
	Tool 0				'设置工具坐标
    Call Pallet_Init	'初始化料盘    
'    Box 1, 1, -500, CX(HB1GetShim) + 20, -500, CY(HB1GetShim) + 50, -900, 0, On
Fend

'网络连接
Function NetWordConnect
	SetNet #201, "192.168.0.21", 2000, CR, NONE, 0
	NetPort201 = 201
 	OpenNet #201 As Server	'打开201网络端口
 	Print "等待连接" + Str$(NetPort201) + "端口……"
 	Wait 1
 	WaitNet #201	'等待201网络端口连接成功
 	Print Str$(NetPort201) + "端口已连接"
Fend

Function UpdataConnect
	SetNet #202, "192.168.0.21", 2001, CR, NONE, 0
	NetPort202 = 202
 	OpenNet #202 As Server	'打开202网络端口
 	Print "等待连接" + Str$(NetPort202) + "端口……"
 	Wait 1
 	WaitNet #202	'等待202网络端口连接成功
 	Print Str$(NetPort202) + "端口已连接"
Fend

'网络端口接收数据
Function ReceiveData
	Integer Port201_Chars	'接收的字符个数
	Port201_Chars = ChkNet(201)	'返回网络端口的接收缓存内的字符数。
	If Port201_Chars <> 0 Then
		Print "Port201_Chars=", Port201_Chars
	EndIf
	If Port201_Chars > 0 Then	'判断数据个数是否大于0
		Input #NetPort201, Item$, ActiveStep, Axis_Speed, OffsetX, OffsetY, OffsetZ, OffsetR, Px, Axis$, Length, Direction$, PalletNum, ProductNum, Axis_SpeedS
		Print "in_201$ = ", Item$, ActiveStep, Axis_Speed, OffsetX, OffsetY, OffsetZ, OffsetR, Px, " ", Axis$, Length, " ", Direction$, PalletNum, ProductNum, Axis_SpeedS
	Else
		Select Port201_Chars
			Case -1
				Print "网络端口已打开，但尚未建立通讯!"
			Case -2
				Print "网络端口201被占用!"
				Call NetWordConnect	'调网络连接
			Case -3
				Call NetWordConnect	'调网络连接
			Default
		Send
	EndIf
Fend

Function UpData
	Integer Port202_Chars	'接收的字符个数
	Port202_Chars = ChkNet(202)	'返回网络端口的接收缓存内的字符数。
	If Port202_Chars <> 0 Then
		Print "Port202_Chars=", Port202_Chars
	EndIf
	If Port202_Chars > 0 Then	'判断数据个数是否大于0
		Input #NetPort202, CMDFsc$
		Print "in_202$ = ", CMDFsc$
	Else
		Select Port202_Chars
			Case -1
				Print "网络端口已打开，但尚未建立通讯!"
			Case -2
				Print "网络端口202被占用!"
				Call UpdataConnect	'调网络连接
			Case -3
				Call UpdataConnect	'调网络连接
			Default
		Send
	EndIf
Fend

'网络端口发送数据
Function SendData
	If DataBuffer$ <> "" Then
 		Print #201, DataBuffer$
 		DataBuffer$ = ""
	EndIf
Fend
Function SendFcs
	OnErr GoTo noo
	If Buffer$ <> "" Then
 		Print #202, Buffer$
 		Buffer$ = ""
	EndIf
	noo:
Fend

'实时数据更新
Function LiveData
	Do
		Call UpData
		If CMDFsc$ = "Play" Then	'连续更新力和位置
			FGet FM1.Forces, myForces()	'获取压力值
			FGet FM1.Fz_Force, myForces(2)
			ForceValue = myForces(2)	'FZ方向的合力
			Buffer$ = "Play" + "," + Str$(ForceValue) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
			Call SendFcs
'			count = count + 1
'			Print Str$(count)
'			Wait 0.01
		EndIf
		If CMDFsc$ = "Stop" Then	'停止更新
			Buffer$ = "Stop" + "," + Str$(ForceValue) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
			Call SendFcs
			CMDFsc$ = "Wait"
		EndIf
		If CMDFsc$ = "Zero" Then	'对压力传感器清零
			FSet FS1.Reset '复位压力传感器并清零
			Wait 1
			FGet FM1.Forces, myForces()	'获取压力值
			ForceValue = myForces(2)
			Buffer$ = "Zero" + "," + Str$(ForceValue) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
			Call SendFcs
			CMDFsc$ = "Play"
		EndIf
		If CMDFsc$ = "Wait" Then	'停止更新
			Wait 0.01
		EndIf
	Loop
Fend

Function Auto
	String Coord$(10)
	Integer i
	Integer errnum
	Do
	'''********************************************************************************************************************************'''
		Call ReceiveData
	'''********************************************************************************************************************************'''
		Select Item$
			Case "GetVersion"
				If Axis$ = "DAB-SV(1.0.0)_20180505" Then
					Print "机械手版本匹配成功！"
					DataBuffer$ = "GetVersionOK" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				Else
					Print "机械手版本匹配失败！"
					DataBuffer$ = "GetVersionNG" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				EndIf
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				
			Case "SavePx"
				i = Px
				P(i) = CurPos
			    SavePoints "Points.pts"
			    Print "将当前位置保存为 P" + Str$(i) + " 点！"
				DataBuffer$ = "SavePx" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				
				Call Pallet_Init
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				
			Case "Motor"
				If ActiveStep = 0 Then
					Motor Off
					
					Print "机械手伺服使能关闭！"
				EndIf
				If ActiveStep = 1 Then
					Motor On
					Print "机械手伺服使能打开！"
				EndIf
				
				DataBuffer$ = "Motor" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				
			Case "GetPos"
				CMDFsc$ = "Wait"
				If Px = -1 Then  '获取当前坐标值
					Wait 0.2
					DataBuffer$ = "GetPos" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
					Print "回传当前位置的X,Y,Z,R坐标"
					Call SendData
					Call ClearData
				Else
					i = Px	'获取指定点坐标值
					DataBuffer$ = "GetPos" + "," + Str$(CX(P(i))) + "," + Str$(CY(P(i))) + "," + Str$(CZ(P(i))) + "," + Str$(CU(P(i))) + "," + Str$(CV(P(i))) + "," + Str$(CW(P(i)))
					Print "回传P" + Str$(i) + "位置的X,Y,Z,R坐标"
					Call SendData
					Call ClearData
				EndIf
	'''********************************************************************************************************************************'''				
			Case "Move"
				Power Low			'设置低功率
				If Direction$ = "+" Then
					i = 1
				ElseIf Direction$ = "-" Then
					i = -1
				EndIf
				If Axis_SpeedS < 1 Then
					Axis_SpeedS = 1
				EndIf
				If Axis_SpeedS > 20 Then
					Axis_SpeedS = 20
				EndIf
				SpeedS Axis_SpeedS	'设定、显示 Move 、Arc、Arc3、Jump3、Jump3CP 等 CP 动作时的手臂速度。
		        AccelS 20, 20		'进行关于机械手直线动作或 CP 动作的加减速度设定。
			    Speed 1				'通过 Go、Jump、Pulse 命令等设定、显示 PTP 动作的速度。
		     	Accel 1, 1			'进行 Go、Jump、Pulse 等 PTP 动作的加减速度的设定与显示。
	
			    Select Axis$
				   Case "X"
				   	   Move Here +X(i * Length)
				   Case "Y"
					   Move Here +Y(i * Length)
				   Case "Z"
					   Move Here +Z(i * Length)
				   Case "U"
					   Go LJM(Here +U(i * Length))	'返回转换了方向标志的点数据，以便在基于参考点移动到指定点时启用最小关节运动。
				   Case "V"
					   Go LJM(Here +V(i * Length))
				   Case "W"
					   Go LJM(Here +W(i * Length))
			   Send
			   Print "机械手从当前位置沿" + AXIS$ + "坐标轴的" + Direction$ + "方向运动" + Str$(Length) + "CM!"
			   Coord$(0) = FmtStr$(CX(CurPos), "0.000")
			   Coord$(1) = FmtStr$(CY(CurPos), "0.000")
			   Coord$(2) = FmtStr$(CZ(CurPos), "0.000")
			   Coord$(3) = FmtStr$(CU(CurPos), "0.000")
			   Coord$(4) = FmtStr$(CV(CurPos), "0.000")
			   Coord$(5) = FmtStr$(CW(CurPos), "0.000")
			   DataBuffer$ = "Move" + "," + Coord$(0) + "," + Coord$(1) + "," + Coord$(2) + "," + Coord$(3) + "," + Coord$(4) + "," + Coord$(5)
			   Call SendData
			   Call ClearData
	'''********************************************************************************************************************************'''			   
			Case "BMove"
				If Direction$ = "+" Then
					i = 1
				ElseIf Direction$ = "-" Then
					i = -1
				EndIf
				SpeedS Axis_SpeedS
		        AccelS 500, 500
			    Speed 35
		     	Accel 20, 20
		     	
			    Select Axis$
				   Case "X"
	                    BMove XY(i * Length, 0, 0, 0, 0, 0) /(Local_Num)
				   Case "Y"
				   		 BMove XY(0, i * Length, 0, 0, 0, 0) /(Local_Num)
				   Case "Z"
					     BMove XY(0, 0, i * Length, 0, 0, 0) /(Local_Num)
				   Case "U"
	                     BMove XY(0, 0, 0, i * Length, 0, 0) /(Local_Num) ROT
				   Case "V"
	                     BMove XY(0, 0, 0, 0, i * Length, 0) /(Local_Num) ROT
				   Case "W"
	                     BMove XY(0, 0, 0, 0, 0, i * Length) /(Local_Num) ROT
			   Send
			   Print "机械手从当前位置沿" + AXIS$ + "坐标轴的" + Direction$ + "方向运动" + Str$(Length) + "CM!"
			   Coord$(0) = FmtStr$(CX(CurPos @(Local_Num)), "0.000")
			   Coord$(1) = FmtStr$(CY(CurPos @(Local_Num)), "0.000")
			   Coord$(2) = FmtStr$(CZ(CurPos @(Local_Num)), "0.000")
			   Coord$(3) = FmtStr$(CU(CurPos @(Local_Num)), "0.000")
			   Coord$(4) = FmtStr$(CV(CurPos @(Local_Num)), "0.000")
			   Coord$(5) = FmtStr$(CW(CurPos @(Local_Num)), "0.000")
			   DataBuffer$ = "BMove" + "," + Coord$(0) + "," + Coord$(1) + "," + Coord$(2) + "," + Coord$(3) + "," + Coord$(4) + "," + Coord$(5)
			   Print DataBuffer$
			   Call SendData
			   Call ClearData
	'''********************************************************************************************************************************'''				   
			Case "JTran"
				If Direction$ = "+" Then
					i = 1
				ElseIf Direction$ = "-" Then
				i = -1
				EndIf
				SpeedS Axis_SpeedS
		        AccelS 500, 500
			    Speed 10
		     	Accel 15, 15
				Select Axis$
					Case "J1"
						JTran 1, i * Length
					Case "J2"
						JTran 2, i * Length
					Case "J3"
						JTran 3, i * Length
					Case "J4"
						JTran 4, i * Length
					Case "J5"
						JTran 5, i * Length
					Case "J6"
						JTran 6, i * Length
				Send
				Print "机械手从当前位置沿" + AXIS$ + "坐标轴的" + Direction$ + "方向运动" + Str$(Length) + "CM!"
				DataBuffer$ = "JTran" + "," + Str$(Val(FmtStr$(PAgl(CurPos, 1), "0.000"))) + "," + Str$(Val(FmtStr$(PAgl(CurPos, 2), "0.000"))) + "," + Str$(Val(FmtStr$(PAgl(CurPos, 3), "0.000"))) + "," + Str$(Val(FmtStr$(PAgl(CurPos, 4), "0.000"))) + "," + Str$(Val(FmtStr$(PAgl(CurPos, 5), "0.000"))) + "," + Str$(Val(FmtStr$(PAgl(CurPos, 6), "0.000")))
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				   
			Case "CCDStep"
				If Axis_SpeedS < 1 Then
				Axis_SpeedS = 1
				EndIf
				If Axis_SpeedS > 50 Then
					Axis_SpeedS = 50
				EndIf
				If Axis_Speed < 1 Then
					Axis_Speed = 1
				EndIf
				Axis_SpeedS = 10
				Axis_Speed = 10
	        	SpeedS Axis_SpeedS 	'SpeedS 设定、显示 Move 、Arc、Arc3、Jump3、Jump3CP 等 CP 动作时的手臂速度。
		       	AccelS 50, 50  	'进行关于机械手直线动作或 CP 动作的加减速度设定。
			   	Speed Axis_Speed	'通过 Go、Jump、Pulse 命令等设定、显示 PTP 动作的速度。
		    	Accel 50, 50   		'进行 Go、Jump、Pulse 等 PTP 动作的加减速度的设定与显示。
		    	Power Low			'设置低功率
				Select ActiveStep
					   
					Case 4		'开始撕PSA下摸
					   Return_TearPSADownStart
					   
					Case 6		'开始撕PSA上摸
					   Return_TearPSAUpStart
					   
					Case 8		'开始撕Display下摸
					   Return_TearDisplayDownStart
					   
					Case 100		'取PSA位置		   
					   Call GetPSA_CCD_Pos
					   
					Case 200		'装PSA位置		   
					   Call AssemblyPSA_CCD_Pos
					   
					Case 300		'取Display位置		   
					   Call GetDisplay_CCD_Pos
					   
					Case 400		'装Display位置		   
					   Call AssemblyDisplay_CCD_Pos
		    	Send
	    	
		    	Wait 0.2
		    	DataBuffer$ = "CCDStep" + Str$(ActiveStep) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				Call SendData
				Call ClearData
				
			Case "Step"
				If Axis_SpeedS < 1 Then
					Axis_SpeedS = 1
				EndIf
				If Axis_SpeedS > 50 Then
					Axis_SpeedS = 50
				EndIf
				If Axis_Speed < 1 Then
					Axis_Speed = 1
				EndIf
				Axis_SpeedS = 50
				Axis_Speed = 50
	        	SpeedS Axis_SpeedS 	'SpeedS 设定、显示 Move 、Arc、Arc3、Jump3、Jump3CP 等 CP 动作时的手臂速度。
		       	AccelS 50, 50  	'进行关于机械手直线动作或 CP 动作的加减速度设定。
			   	Speed Axis_Speed	'通过 Go、Jump、Pulse 命令等设定、显示 PTP 动作的速度。
		    	Accel 50, 50   		'进行 Go、Jump、Pulse 等 PTP 动作的加减速度的设定与显示。
		    	Power High '设置低功率
				' 0.待机位置          
				' 1.PSA载台拍照位置
				' 2.取PSA位置
				' 3.撕PSA下模位置
				' 4.PSA定位拍照位置
				' 5.预贴PSA位置
				' 6.料盘上拍照位置
				' 7.料盘上取料位置
				' 8.显示屏撕模位置
				' 9.显示屏定位拍照位置
				'10.预贴显示屏位置
				'11.PSA抛料位置
				'12.压力传感器位置
				Select ActiveStep
					Case 0		'待机位置		   
					   Call Return_HomePos
					   
					Case 1		'PSA载台拍照位置		   
					   Call Return_PSAPhotePos
					   
					Case 2		'取PSA位置		   
					   Call Return_GetPSAPos
					   
					Case 3		'撕PSA下模位置
						Call Return_TearPSAPos
						
					Case 4		'PSA定位拍照位置
						Call Return_DownphotePSAPos
						
					Case 5		'预贴PSA位置
						Call Return_PastPSAPos
						
					Case 6		'料盘上拍照位置
						Call Return_DisplayPhotePos
						
					Case 7		'料盘上取料位置
					   	Call Return_GetDisplayPos
					   	
					Case 8		'显示屏撕模位置
						Call Return_TearDisplayPos
						
					Case 9		'显示屏定位拍照位置
						Call Return_DownphoteDisplayPos
						
		    	    Case 10	'预贴显示屏位置
		    	    	Call Return_PastDisplayPos
		    	    	
		    	    Case 11	'PSA抛料位置
						Call Return_ThrowPSAPos
						
					Case 12	'压力传感器位置
						Call Return_LoadcellPos
						
		    	    ''''*************************************************************** 
		    	Send
	    	
		    	Wait 0.2
		    	DataBuffer$ = "Step" + Str$(ActiveStep) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				Call SendData
				Call ClearData
			Case ""
				Wait 0.01
		Send
	
	Loop
Fend

'待机位置
Function Return_HomePos
	Tool 0
'	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
		Move Here :Z(CZ(HomePos))
		Go Here :U(CU(HomePos))
		Move LJM(HomePos)
'	EndIf
Fend

'取PSA位置
Function Return_GetPSAPos
	Tool 0
	Axis_SpeedS = 5
	Axis_Speed = 5
	Move Here :Z(CZ(HomePos)) CP
	Move LJM(GetPSA) :Z(CZ(HomePos) + 2) CP
	Move LJM(GetPSA) :Z(CZ(GetPSA) + 2) CP	'分两段
	SpeedS 2	'开始减速到取料位置
	AccelS 10, 10
	Move LJM(GetPSA) CP
Fend
Function CCD_GetPSAPos
	Tool 0
	Move Here :Z(CZ(HomePos)) CP
	Move LJM(GetPSA) :X(CX(GetPSA) + OffsetX) :Y(CY(GetPSA) + OffsetY) :U(CU(GetPSA) + OffsetR) :Z(CZ(HomePos)) CP
	Wait 0.2 '等待停稳
	Move LJM(CurPos) :Z(CZ(GetPSA) + OffsetZ + 2) CP	'分两段
	SpeedS 2	'开始减速到取料位置
	AccelS 10, 10
	Move LJM(CurPos) :Z(CZ(GetPSA) + OffsetZ)
Fend
'撕PSA下模位置
Function Return_TearPSAPos
	Tool 0
	Move Here :Z(CZ(HomePos)) CP
	Move LJM(TearPSA) :X(CX(TearPSA)) :Z(CZ(HomePos)) CP
	Move Here :Z(CZ(TearPSA)) CP
	Move LJM(TearPSA)
Fend

'撕PSA下模开始撕摸 
Function Return_TearPSADownStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(2) CP
	Move Here +Z(15) +X(-15) CP
Fend

'撕Display下模开始撕摸 
Function Return_TearDisplayDownStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(2) CP
	Move Here +Z(15) +X(-15) CP
Fend

'撕PSA上模开始撕摸 
Function Return_TearPSAUpStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(1) CP
	Move Here +Z(15) +X(-5) CP
Fend

'预贴PSA位置  
Function Return_PastPSAPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
		Move Here :Z(CZ(HomePos))
		Move LJM(PastPSA) :Z(CZ(HomePos))
		Move LJM(PastPSA) Till ForceValue > Length 	'压力判断,单位N
	EndIf
Fend

'料盘上取料位置
Function Return_GetDisplayPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
'		Move Here :Z(CZ(HomePos) + 2)
		Move Here :X(CX(Pallet(PalletNum, ProductNum))) +X(OffsetX) :Y(CY(Pallet(PalletNum, ProductNum))) +Y(OffsetY) :U(CU(Pallet(PalletNum, ProductNum))) +U(OffsetR)
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) +Z(OffsetZ + 2) CP
		SpeedS 5
		AccelS 10, 5
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) +Z(OffsetZ) CP
	EndIf
Fend

'显示屏撕模位置
Function Return_TearDisplayPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
		Move Here :Z(CZ(HomePos))
		Move LJM(TearDisplay) :Z(CZ(HomePos))
		Move LJM(TearDisplay)
	EndIf
Fend

'撕显示屏下模开始撕摸 
Function Return_TearDisplayStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(1) CP
	Move Here +Z(15) +X(-15) CP
Fend

'PSA载台拍照位置
Function Return_PSAPhotePos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
		Move Here :Z(CZ(HomePos))
		Move LJM(PSAPhote) :Z(CZ(HomePos))
		Move LJM(PSAPhote)
	EndIf
Fend

'料盘上拍照位置
Function Return_DisplayPhotePos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move Here :X(CX(Pallet(PalletNum, ProductNum))) :Y(CY(Pallet(PalletNum, ProductNum))) :U(CU(Pallet(PalletNum, ProductNum))) ' +X(OffsetX) +Y(OffsetY)
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) '+Z(OffsetZ)
	Else
		Move Here :Z(CZ(HomePos)) '先运动到安全高度
		Move Here :X(CX(Pallet(PalletNum, ProductNum))) :Y(CY(Pallet(PalletNum, ProductNum))) :U(CU(Pallet(PalletNum, ProductNum))) ' +X(OffsetX) +Y(OffsetY)
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) '+Z(OffsetZ)	
	EndIf
Fend

'PSA定位拍照位置			
Function Return_DownphotePSAPos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move LJM(DownphotePSA) :Z(CZ(HomePos))
		Move LJM(DownphotePSA)
	Else
		Move Here :Z(CZ(HomePos)) '先运动到安全高度
		Move LJM(DownphotePSA) :Z(CZ(HomePos))
		Move LJM(DownphotePSA)
	EndIf
Fend

'下相机定位拍照PSA	=91				
Function Return_DownphoteDisplayPos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move LJM(DownphoteDisplay) :Z(CZ(HomePos))
		Move LJM(DownphoteDisplay)
	Else
		Move Here :Z(CZ(HomePos)) '先运动到安全高度
		Move LJM(DownphoteDisplay) :Z(CZ(HomePos))
		Move LJM(DownphoteDisplay)
	EndIf
Fend

'预贴显示屏位置
Function Return_PastDisplayPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
		Move Here :Z(CZ(HomePos)) '先运动到安全高度
		Move LJM(PastDisplay) :Z(CZ(HomePos))
		Move LJM(PastDisplay)
	EndIf
Fend

'Loadcell上方 =100
Function Return_LoadcellPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4关节值基本没旋转。
		Go Here :Z(CZ(HomePos))
		Move LJM(Loadcell) :Z(CZ(HomePos))
		Move LJM(Loadcell)
	EndIf
Fend

'抛PSA位置 =110
Function Return_ThrowPSAPos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move LJM(ThrowPSA) :Z(CZ(HomePos))
		Move LJM(ThrowPSA)
	Else
		Move Here :Z(CZ(HomePos))
		Move LJM(ThrowPSA) :Z(CZ(HomePos))
		Move LJM(ThrowPSA)
	EndIf
Fend


'根据CCD引导取PSA
Function GetPSA_CCD_Pos
	Tool 0
	CCDPoint = GetPSA
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(GetPSA) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 10)
	Move LJM(CCDPoint)
Fend

'根据CCD引导装PSA
Function AssemblyPSA_CCD_Pos
	Tool 0
	CCDPoint = PastPSA
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(PastPSA) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 10)
	Move LJM(CCDPoint)
Fend

'根据CCD引导取Display
Function GetDisplay_CCD_Pos
	Tool 0
	CCDPoint = Pallet(PalletNum, ProductNum)
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(Pallet(PalletNum, ProductNum)) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 10)
	Move LJM(CCDPoint)
Fend

'根据CCD引导装Display
Function AssemblyDisplay_CCD_Pos
	Tool 0
	CCDPoint = PastDisplay
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(PastDisplay) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 20)
	Move LJM(CCDPoint)
Fend
'清除缓存
Function ClearData
	Item$ = ""			'机械手指令类别参数
	Px = 0				'
	Axis$ = ""
	Direction$ = ""
	ActiveStep = 0
	PalletNum = 0
	ProductNum = 0
	Axis_Speed = 0
	OffsetX = 0
	OffsetY = 0
	OffsetZ = 0
	OffsetR = 0
	Length = 0
Fend

'初始化阵列
Function Pallet_Init
	Pallet 1, P100, P101, P102, 2, 5       		'料盘拍照阵列
	Pallet 2, P104, P105, P106, 2, 5       		'料盘取料阵列
Fend


	


	



