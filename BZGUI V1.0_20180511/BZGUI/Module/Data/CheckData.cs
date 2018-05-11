using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BZGUI.Data
{
    [Serializable]
    public class CheckData
    {
        public CheckData()
        {
            Mod_Brc_X = 999;
            Mod_Brc_Y = 999;
            Mod_Brc_A = 999;
            Mod_Brc_CC = 999;
            #region IPDM
            IPD_Left1 = 999;
            IPD_Right1 = 999;
            IPD_Left2 = 999;
            IPD_Right2 = 999;
            IPD_Left3 = 999;
            IPD_Right3 = 999;
            IPD_Left4 = 999;
            IPD_Right4 = 999;
            IPD_Left5 = 999;
            IPD_Right5 = 999;
            IPD_Left6 = 999;
            IPD_Right6 = 999;
            #endregion
        }

        public double Mod_Brc_X { get; set; }
        public double Mod_Brc_Y { get; set; }
        public double Mod_Brc_A { get; set; }
        public double Mod_Brc_CC { get; set; }
        #region IPDM
        public double IPD_Left1 { get; set; }
        public double IPD_Right1 { get; set; }
        public double IPD_Left2 { get; set; }
        public double IPD_Right2 { get; set; }
        public double IPD_Left3 { get; set; }
        public double IPD_Right3 { get; set; }
        public double IPD_Left4 { get; set; }
        public double IPD_Right4 { get; set; }
        public double IPD_Left5 { get; set; }
        public double IPD_Right5 { get; set; }
        public double IPD_Left6 { get; set; }
        public double IPD_Right6 { get; set; }
        #endregion
        public string SN { get; set; }
        public bool PASS { get; set; }
        public bool PDCAPASS { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string Operator_ID { get; set; }
        public string Mode { get; set; }
        public string TestSeriesID { get; set; }
        public string Prioriyt { get; set; }
    }

}
