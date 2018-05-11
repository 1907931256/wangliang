'''Updata 20180505

Integer NetPort201, NetPort202, count
Integer ForceValue
String DataBuffer$, Buffer$
Global String Item$, Axis$, Direction$
Global String CMDFsc$
Global Integer ActiveStep, PalletNum, ProductNum, Px, ActiveStep1
Global Real Axis_Speed, OffsetX, OffsetY, OffsetZ, OffsetR, Length, Axis_SpeedS
Real myForces(8)	'����ʵ���͵ı�����( 4�ֽ�ʵ��)�����ѹ������
Global String PosJudge$
Global Integer Local_Num

Function Main
	CMDFsc$ = "Play"
	'2 FS_File�ļ�����4ҳ���ֱ�ΪFC:ѹ������/FT:ѹ������/FCS:ѹ������ϵ/FM:������ 
	'ʹ����Щ������Ҫ���ö�Ӧ�Ĳ���

'	FSet FM1.ForceSensor, 1 '����ѹ�����������
'	FSet FCS1.Orientation, 0	'��������������
'
'
'	FSet FC1.CoordinateSystem, FCS0 'ָ���򷵻���������ϵ
'	FSet FM1.CoordinateSystem, FCS0 'ָ���򷵻���������ϵ
'	FSet FM1.LPF_Enabled, False, False, True, False, False, False, False, False '����/���û�ͬʱ����Ӧ����ÿ����ĵ�ͨ�˲�����
'	FSet FM1.LPF_TimeConstants, 0.02, 0.02, 0.02, 0.02, 0.02, 0.02 '�⽫���û򷵻�ͬʱӦ����������ϵ��ÿ����ĵ�ͨ�˲���ʱ�䳣����ֵ��
'	FSet FC1.Enabled, True, False, False, False, False, False
'	FSet FC1.TargetForces, 0, 0, 20, 0, 0, 0
'	FSet FC1.Fz_Spring, 0 '����������㵯��ϵ��
'	FSet FC1.Fz_Damper, 2 '����ճ�ȵ��������ϵ��
'	FSet FC1.Fz_Mass, 1	'��������������ϵ��
'	FSet FC1.LimitSpeedS, 5	'�����ؽڼ��ٶ�����Ϊ5 [����/��2 ]
'	FSet FC1.LimitAccelS, 500	'�����ؽڼ��ٶ�����Ϊ5 [����/��2 ]
	
'	FLoad "Myforce.frc"		'����ѹ�������ļ�
'	FSet FS1.Reset '��λѹ��������������
	
'	Go P0
'	Go P4
'	Move P4 FC1
'	Wait 1
'	If FCOn(1) = Off Then	'FCOn(RobotNo)
'   		Print "�����ƹ��ܴ��ڷǻ״̬"
' 	EndIf
 	count = 1
	Call Init	'������Ϊ�ӳ���ĺ���
   	Xqt Auto 	'ִ���ú�����ָ��������
   	Wait 2
   	Xqt LiveData 	'ִ���ú�����ָ��������
Fend

'��е�ֿ�������ʼ��
Function Init
	Motor On			'��е�ֵ��ŷ��ϵ�
	Power Low			'���õ�ԴģʽΪ�߹���ģʽ  
	Tool 0				'���ù�������
    Call Pallet_Init	'��ʼ������    
'    Box 1, 1, -500, CX(HB1GetShim) + 20, -500, CY(HB1GetShim) + 50, -900, 0, On
Fend

'��������
Function NetWordConnect
	SetNet #201, "192.168.0.21", 2000, CR, NONE, 0
	NetPort201 = 201
 	OpenNet #201 As Server	'��201����˿�
 	Print "�ȴ�����" + Str$(NetPort201) + "�˿ڡ���"
 	Wait 1
 	WaitNet #201	'�ȴ�201����˿����ӳɹ�
 	Print Str$(NetPort201) + "�˿�������"
Fend

Function UpdataConnect
	SetNet #202, "192.168.0.21", 2001, CR, NONE, 0
	NetPort202 = 202
 	OpenNet #202 As Server	'��202����˿�
 	Print "�ȴ�����" + Str$(NetPort202) + "�˿ڡ���"
 	Wait 1
 	WaitNet #202	'�ȴ�202����˿����ӳɹ�
 	Print Str$(NetPort202) + "�˿�������"
Fend

'����˿ڽ�������
Function ReceiveData
	Integer Port201_Chars	'���յ��ַ�����
	Port201_Chars = ChkNet(201)	'��������˿ڵĽ��ջ����ڵ��ַ�����
	If Port201_Chars <> 0 Then
		Print "Port201_Chars=", Port201_Chars
	EndIf
	If Port201_Chars > 0 Then	'�ж����ݸ����Ƿ����0
		Input #NetPort201, Item$, ActiveStep, Axis_Speed, OffsetX, OffsetY, OffsetZ, OffsetR, Px, Axis$, Length, Direction$, PalletNum, ProductNum, Axis_SpeedS
		Print "in_201$ = ", Item$, ActiveStep, Axis_Speed, OffsetX, OffsetY, OffsetZ, OffsetR, Px, " ", Axis$, Length, " ", Direction$, PalletNum, ProductNum, Axis_SpeedS
	Else
		Select Port201_Chars
			Case -1
				Print "����˿��Ѵ򿪣�����δ����ͨѶ!"
			Case -2
				Print "����˿�201��ռ��!"
				Call NetWordConnect	'����������
			Case -3
				Call NetWordConnect	'����������
			Default
		Send
	EndIf
Fend

Function UpData
	Integer Port202_Chars	'���յ��ַ�����
	Port202_Chars = ChkNet(202)	'��������˿ڵĽ��ջ����ڵ��ַ�����
	If Port202_Chars <> 0 Then
		Print "Port202_Chars=", Port202_Chars
	EndIf
	If Port202_Chars > 0 Then	'�ж����ݸ����Ƿ����0
		Input #NetPort202, CMDFsc$
		Print "in_202$ = ", CMDFsc$
	Else
		Select Port202_Chars
			Case -1
				Print "����˿��Ѵ򿪣�����δ����ͨѶ!"
			Case -2
				Print "����˿�202��ռ��!"
				Call UpdataConnect	'����������
			Case -3
				Call UpdataConnect	'����������
			Default
		Send
	EndIf
Fend

'����˿ڷ�������
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

'ʵʱ���ݸ���
Function LiveData
	Do
		Call UpData
		If CMDFsc$ = "Play" Then	'������������λ��
			FGet FM1.Forces, myForces()	'��ȡѹ��ֵ
			FGet FM1.Fz_Force, myForces(2)
			ForceValue = myForces(2)	'FZ����ĺ���
			Buffer$ = "Play" + "," + Str$(ForceValue) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
			Call SendFcs
'			count = count + 1
'			Print Str$(count)
'			Wait 0.01
		EndIf
		If CMDFsc$ = "Stop" Then	'ֹͣ����
			Buffer$ = "Stop" + "," + Str$(ForceValue) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
			Call SendFcs
			CMDFsc$ = "Wait"
		EndIf
		If CMDFsc$ = "Zero" Then	'��ѹ������������
			FSet FS1.Reset '��λѹ��������������
			Wait 1
			FGet FM1.Forces, myForces()	'��ȡѹ��ֵ
			ForceValue = myForces(2)
			Buffer$ = "Zero" + "," + Str$(ForceValue) + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
			Call SendFcs
			CMDFsc$ = "Play"
		EndIf
		If CMDFsc$ = "Wait" Then	'ֹͣ����
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
					Print "��е�ְ汾ƥ��ɹ���"
					DataBuffer$ = "GetVersionOK" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				Else
					Print "��е�ְ汾ƥ��ʧ�ܣ�"
					DataBuffer$ = "GetVersionNG" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				EndIf
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				
			Case "SavePx"
				i = Px
				P(i) = CurPos
			    SavePoints "Points.pts"
			    Print "����ǰλ�ñ���Ϊ P" + Str$(i) + " �㣡"
				DataBuffer$ = "SavePx" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				
				Call Pallet_Init
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				
			Case "Motor"
				If ActiveStep = 0 Then
					Motor Off
					
					Print "��е���ŷ�ʹ�ܹرգ�"
				EndIf
				If ActiveStep = 1 Then
					Motor On
					Print "��е���ŷ�ʹ�ܴ򿪣�"
				EndIf
				
				DataBuffer$ = "Motor" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
				Call SendData
				Call ClearData
	'''********************************************************************************************************************************'''				
			Case "GetPos"
				CMDFsc$ = "Wait"
				If Px = -1 Then  '��ȡ��ǰ����ֵ
					Wait 0.2
					DataBuffer$ = "GetPos" + "," + Str$(CX(CurPos)) + "," + Str$(CY(CurPos)) + "," + Str$(CZ(CurPos)) + "," + Str$(CU(CurPos)) + "," + Str$(CV(CurPos)) + "," + Str$(CW(CurPos))
					Print "�ش���ǰλ�õ�X,Y,Z,R����"
					Call SendData
					Call ClearData
				Else
					i = Px	'��ȡָ��������ֵ
					DataBuffer$ = "GetPos" + "," + Str$(CX(P(i))) + "," + Str$(CY(P(i))) + "," + Str$(CZ(P(i))) + "," + Str$(CU(P(i))) + "," + Str$(CV(P(i))) + "," + Str$(CW(P(i)))
					Print "�ش�P" + Str$(i) + "λ�õ�X,Y,Z,R����"
					Call SendData
					Call ClearData
				EndIf
	'''********************************************************************************************************************************'''				
			Case "Move"
				Power Low			'���õ͹���
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
				SpeedS Axis_SpeedS	'�趨����ʾ Move ��Arc��Arc3��Jump3��Jump3CP �� CP ����ʱ���ֱ��ٶȡ�
		        AccelS 20, 20		'���й��ڻ�е��ֱ�߶����� CP �����ļӼ��ٶ��趨��
			    Speed 1				'ͨ�� Go��Jump��Pulse ������趨����ʾ PTP �������ٶȡ�
		     	Accel 1, 1			'���� Go��Jump��Pulse �� PTP �����ļӼ��ٶȵ��趨����ʾ��
	
			    Select Axis$
				   Case "X"
				   	   Move Here +X(i * Length)
				   Case "Y"
					   Move Here +Y(i * Length)
				   Case "Z"
					   Move Here +Z(i * Length)
				   Case "U"
					   Go LJM(Here +U(i * Length))	'����ת���˷����־�ĵ����ݣ��Ա��ڻ��ڲο����ƶ���ָ����ʱ������С�ؽ��˶���
				   Case "V"
					   Go LJM(Here +V(i * Length))
				   Case "W"
					   Go LJM(Here +W(i * Length))
			   Send
			   Print "��е�ִӵ�ǰλ����" + AXIS$ + "�������" + Direction$ + "�����˶�" + Str$(Length) + "CM!"
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
			   Print "��е�ִӵ�ǰλ����" + AXIS$ + "�������" + Direction$ + "�����˶�" + Str$(Length) + "CM!"
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
				Print "��е�ִӵ�ǰλ����" + AXIS$ + "�������" + Direction$ + "�����˶�" + Str$(Length) + "CM!"
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
	        	SpeedS Axis_SpeedS 	'SpeedS �趨����ʾ Move ��Arc��Arc3��Jump3��Jump3CP �� CP ����ʱ���ֱ��ٶȡ�
		       	AccelS 50, 50  	'���й��ڻ�е��ֱ�߶����� CP �����ļӼ��ٶ��趨��
			   	Speed Axis_Speed	'ͨ�� Go��Jump��Pulse ������趨����ʾ PTP �������ٶȡ�
		    	Accel 50, 50   		'���� Go��Jump��Pulse �� PTP �����ļӼ��ٶȵ��趨����ʾ��
		    	Power Low			'���õ͹���
				Select ActiveStep
					   
					Case 4		'��ʼ˺PSA����
					   Return_TearPSADownStart
					   
					Case 6		'��ʼ˺PSA����
					   Return_TearPSAUpStart
					   
					Case 8		'��ʼ˺Display����
					   Return_TearDisplayDownStart
					   
					Case 100		'ȡPSAλ��		   
					   Call GetPSA_CCD_Pos
					   
					Case 200		'װPSAλ��		   
					   Call AssemblyPSA_CCD_Pos
					   
					Case 300		'ȡDisplayλ��		   
					   Call GetDisplay_CCD_Pos
					   
					Case 400		'װDisplayλ��		   
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
	        	SpeedS Axis_SpeedS 	'SpeedS �趨����ʾ Move ��Arc��Arc3��Jump3��Jump3CP �� CP ����ʱ���ֱ��ٶȡ�
		       	AccelS 50, 50  	'���й��ڻ�е��ֱ�߶����� CP �����ļӼ��ٶ��趨��
			   	Speed Axis_Speed	'ͨ�� Go��Jump��Pulse ������趨����ʾ PTP �������ٶȡ�
		    	Accel 50, 50   		'���� Go��Jump��Pulse �� PTP �����ļӼ��ٶȵ��趨����ʾ��
		    	Power High '���õ͹���
				' 0.����λ��          
				' 1.PSA��̨����λ��
				' 2.ȡPSAλ��
				' 3.˺PSA��ģλ��
				' 4.PSA��λ����λ��
				' 5.Ԥ��PSAλ��
				' 6.����������λ��
				' 7.������ȡ��λ��
				' 8.��ʾ��˺ģλ��
				' 9.��ʾ����λ����λ��
				'10.Ԥ����ʾ��λ��
				'11.PSA����λ��
				'12.ѹ��������λ��
				Select ActiveStep
					Case 0		'����λ��		   
					   Call Return_HomePos
					   
					Case 1		'PSA��̨����λ��		   
					   Call Return_PSAPhotePos
					   
					Case 2		'ȡPSAλ��		   
					   Call Return_GetPSAPos
					   
					Case 3		'˺PSA��ģλ��
						Call Return_TearPSAPos
						
					Case 4		'PSA��λ����λ��
						Call Return_DownphotePSAPos
						
					Case 5		'Ԥ��PSAλ��
						Call Return_PastPSAPos
						
					Case 6		'����������λ��
						Call Return_DisplayPhotePos
						
					Case 7		'������ȡ��λ��
					   	Call Return_GetDisplayPos
					   	
					Case 8		'��ʾ��˺ģλ��
						Call Return_TearDisplayPos
						
					Case 9		'��ʾ����λ����λ��
						Call Return_DownphoteDisplayPos
						
		    	    Case 10	'Ԥ����ʾ��λ��
		    	    	Call Return_PastDisplayPos
		    	    	
		    	    Case 11	'PSA����λ��
						Call Return_ThrowPSAPos
						
					Case 12	'ѹ��������λ��
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

'����λ��
Function Return_HomePos
	Tool 0
'	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
		Move Here :Z(CZ(HomePos))
		Go Here :U(CU(HomePos))
		Move LJM(HomePos)
'	EndIf
Fend

'ȡPSAλ��
Function Return_GetPSAPos
	Tool 0
	Axis_SpeedS = 5
	Axis_Speed = 5
	Move Here :Z(CZ(HomePos)) CP
	Move LJM(GetPSA) :Z(CZ(HomePos) + 2) CP
	Move LJM(GetPSA) :Z(CZ(GetPSA) + 2) CP	'������
	SpeedS 2	'��ʼ���ٵ�ȡ��λ��
	AccelS 10, 10
	Move LJM(GetPSA) CP
Fend
Function CCD_GetPSAPos
	Tool 0
	Move Here :Z(CZ(HomePos)) CP
	Move LJM(GetPSA) :X(CX(GetPSA) + OffsetX) :Y(CY(GetPSA) + OffsetY) :U(CU(GetPSA) + OffsetR) :Z(CZ(HomePos)) CP
	Wait 0.2 '�ȴ�ͣ��
	Move LJM(CurPos) :Z(CZ(GetPSA) + OffsetZ + 2) CP	'������
	SpeedS 2	'��ʼ���ٵ�ȡ��λ��
	AccelS 10, 10
	Move LJM(CurPos) :Z(CZ(GetPSA) + OffsetZ)
Fend
'˺PSA��ģλ��
Function Return_TearPSAPos
	Tool 0
	Move Here :Z(CZ(HomePos)) CP
	Move LJM(TearPSA) :X(CX(TearPSA)) :Z(CZ(HomePos)) CP
	Move Here :Z(CZ(TearPSA)) CP
	Move LJM(TearPSA)
Fend

'˺PSA��ģ��ʼ˺�� 
Function Return_TearPSADownStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(2) CP
	Move Here +Z(15) +X(-15) CP
Fend

'˺Display��ģ��ʼ˺�� 
Function Return_TearDisplayDownStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(2) CP
	Move Here +Z(15) +X(-15) CP
Fend

'˺PSA��ģ��ʼ˺�� 
Function Return_TearPSAUpStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(1) CP
	Move Here +Z(15) +X(-5) CP
Fend

'Ԥ��PSAλ��  
Function Return_PastPSAPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
		Move Here :Z(CZ(HomePos))
		Move LJM(PastPSA) :Z(CZ(HomePos))
		Move LJM(PastPSA) Till ForceValue > Length 	'ѹ���ж�,��λN
	EndIf
Fend

'������ȡ��λ��
Function Return_GetDisplayPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
'		Move Here :Z(CZ(HomePos) + 2)
		Move Here :X(CX(Pallet(PalletNum, ProductNum))) +X(OffsetX) :Y(CY(Pallet(PalletNum, ProductNum))) +Y(OffsetY) :U(CU(Pallet(PalletNum, ProductNum))) +U(OffsetR)
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) +Z(OffsetZ + 2) CP
		SpeedS 5
		AccelS 10, 5
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) +Z(OffsetZ) CP
	EndIf
Fend

'��ʾ��˺ģλ��
Function Return_TearDisplayPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
		Move Here :Z(CZ(HomePos))
		Move LJM(TearDisplay) :Z(CZ(HomePos))
		Move LJM(TearDisplay)
	EndIf
Fend

'˺��ʾ����ģ��ʼ˺�� 
Function Return_TearDisplayStart
	Tool 0
	SpeedS 10
	AccelS 50, 50
	Move Here +Z(1) CP
	Move Here +Z(15) +X(-15) CP
Fend

'PSA��̨����λ��
Function Return_PSAPhotePos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
		Move Here :Z(CZ(HomePos))
		Move LJM(PSAPhote) :Z(CZ(HomePos))
		Move LJM(PSAPhote)
	EndIf
Fend

'����������λ��
Function Return_DisplayPhotePos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move Here :X(CX(Pallet(PalletNum, ProductNum))) :Y(CY(Pallet(PalletNum, ProductNum))) :U(CU(Pallet(PalletNum, ProductNum))) ' +X(OffsetX) +Y(OffsetY)
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) '+Z(OffsetZ)
	Else
		Move Here :Z(CZ(HomePos)) '���˶�����ȫ�߶�
		Move Here :X(CX(Pallet(PalletNum, ProductNum))) :Y(CY(Pallet(PalletNum, ProductNum))) :U(CU(Pallet(PalletNum, ProductNum))) ' +X(OffsetX) +Y(OffsetY)
		Move Here :Z(CZ(Pallet(PalletNum, ProductNum))) '+Z(OffsetZ)	
	EndIf
Fend

'PSA��λ����λ��			
Function Return_DownphotePSAPos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move LJM(DownphotePSA) :Z(CZ(HomePos))
		Move LJM(DownphotePSA)
	Else
		Move Here :Z(CZ(HomePos)) '���˶�����ȫ�߶�
		Move LJM(DownphotePSA) :Z(CZ(HomePos))
		Move LJM(DownphotePSA)
	EndIf
Fend

'�������λ����PSA	=91				
Function Return_DownphoteDisplayPos
	Tool 0
	If CZ(CurPos) > CZ(HomePos) Then
		Move LJM(DownphoteDisplay) :Z(CZ(HomePos))
		Move LJM(DownphoteDisplay)
	Else
		Move Here :Z(CZ(HomePos)) '���˶�����ȫ�߶�
		Move LJM(DownphoteDisplay) :Z(CZ(HomePos))
		Move LJM(DownphoteDisplay)
	EndIf
Fend

'Ԥ����ʾ��λ��
Function Return_PastDisplayPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
		Move Here :Z(CZ(HomePos)) '���˶�����ȫ�߶�
		Move LJM(PastDisplay) :Z(CZ(HomePos))
		Move LJM(PastDisplay)
	EndIf
Fend

'Loadcell�Ϸ� =100
Function Return_LoadcellPos
	Tool 0
	If Abs(Agl(4)) < 5 Then   '4�ؽ�ֵ����û��ת��
		Go Here :Z(CZ(HomePos))
		Move LJM(Loadcell) :Z(CZ(HomePos))
		Move LJM(Loadcell)
	EndIf
Fend

'��PSAλ�� =110
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


'����CCD����ȡPSA
Function GetPSA_CCD_Pos
	Tool 0
	CCDPoint = GetPSA
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(GetPSA) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 10)
	Move LJM(CCDPoint)
Fend

'����CCD����װPSA
Function AssemblyPSA_CCD_Pos
	Tool 0
	CCDPoint = PastPSA
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(PastPSA) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 10)
	Move LJM(CCDPoint)
Fend

'����CCD����ȡDisplay
Function GetDisplay_CCD_Pos
	Tool 0
	CCDPoint = Pallet(PalletNum, ProductNum)
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(Pallet(PalletNum, ProductNum)) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 10)
	Move LJM(CCDPoint)
Fend

'����CCD����װDisplay
Function AssemblyDisplay_CCD_Pos
	Tool 0
	CCDPoint = PastDisplay
	CCDPoint = CCDPoint :X(OffsetX) :Y(OffsetY) :Z(CZ(PastDisplay) + OffsetZ) :U(OffsetR)
	Move LJM(CCDPoint) :Z(CZ(CCDPoint) + 20)
	Move LJM(CCDPoint)
Fend
'�������
Function ClearData
	Item$ = ""			'��е��ָ��������
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

'��ʼ������
Function Pallet_Init
	Pallet 1, P100, P101, P102, 2, 5       		'������������
	Pallet 2, P104, P105, P106, 2, 5       		'����ȡ������
Fend


	


	



