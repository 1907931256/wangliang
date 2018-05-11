
using System.Data;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using AxMSScriptControl;
using System.Collections;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace BZGUI
{
	sealed class Calibration
	{
        public event Action<string> ShowList;
		public int[] CalibStep = new int[11];
		public int[] CalibRobotStep = new int[11];
		public string[] LaserDis = new string[6];	
		public bool PauseForGoOn = false;
        private readonly static Calibration instance = new Calibration();
        public static Calibration Instance
        {
            get { return instance; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public Calibration()
        { }

		//CCD九点标定
        public void AutoCalibration0()
		{
			switch (CalibStep[0])
			{
				case 10:
					break;
					
					
				case 700:
					Frm_Engineering.fEngineering.PanelCalibration.Enabled = true;
                    FunctionSub.AddListCalib("相机自动标定成功！");
					BVar.FileRorW.WriteINI("CCD", "CCD九点标定-吸嘴1", "OK", PVar.BZ_CalibrationFileName);
					CalibStep[0] = 0;
					Frm_Engineering.fEngineering.Timer_Calibration.Enabled = false;
					break;
					
				case 8000:
					CalibStep[0] = 0;
					Frm_Engineering.fEngineering.PanelCalibration.Enabled = true;
					BVar.FileRorW.WriteINI("CCD", "CCD九点标定-吸嘴1", "NG", PVar.BZ_CalibrationFileName);
                    FunctionSub.AddListCalib("相机自动标定失败，请检查！");
					ShowList("相机自动标定失败，请检查！");
					Frm_Engineering.fEngineering.Timer_Calibration.Enabled = false;
					break;
					
			}
			
		}
		
		
	}
	
}
