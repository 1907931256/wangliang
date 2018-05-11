using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BZGUI
{
    public enum StationRunMode
    {
        空跑,
        自动运行,
        自动准备,
        标定Laser,
        手动上传PDCA,
        CCD触发,
        条码枪触发,
    }

    public enum TasksId
    {
        Manchine=0,
        测试 = 1,
        MMS测试=2,
        组装 = 3,
    }

    public enum SettingId
    {
        参数设定 = 1,
        功能设定 = 2,
        设备参数 = 3,
        Laser参数 = 4,
    }


    /// <summary>
    /// show Result Event
    /// </summary>
    enum EnumShowResult
    {
        Empty,
        OK,
        NG,
    }


}
