using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using BZappdll;

namespace XCore
{
    public class XGlobals
    {
        public static string Dir_Bin = Application.StartupPath;
    }

    public enum MachineModeType
    {
        Production = 0,
        Engineering = 1,
        CPKGRR = 2,
        None = 3,
    }

}
