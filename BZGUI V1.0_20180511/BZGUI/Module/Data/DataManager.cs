using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BZGUI.Data;

namespace BZGUI
{
    class DataManager
    {
        private static DataManager instance;
        public DataManager()
        { }
        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        public LoginCtr Login = new LoginCtr();
        public CheckData CurrentCheckData = new CheckData();
        public Toosing toosing = new Toosing();
        public Yield yield = new Yield();
        public UPH uph = new UPH();
        public CurrentYield currentyield = new CurrentYield();
        public YieldManager yieldManger = new YieldManager();
        public ToosingManager toosingManger = new ToosingManager();
        public UPHManager uphManger = new UPHManager();
        public ProduceData chartData = new ProduceData();//for chart
        public AlarmRecord alarmRecord = new AlarmRecord();


    }
}
