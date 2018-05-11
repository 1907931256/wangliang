using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB
    {
    class Axis 
        {
        public const short 流水线1 = 1;
        public const short 流水线2 = 2;
        public const short 流水线3 = 3;
        public const short 保压Z轴 = 4;
        public const short 料仓左Z轴 = 5;
        public const short 料仓右Z轴 = 6;
        public const short PSA供料Z轴 = 7;
        public const short PSA搬运Y轴 = 8;

        public struct tTag 
            { 
            public const short 左料仓 = 1;
            public const short 右料仓 = 2;
            public const short PSA供料 = 3;
            public const short 保压 = 4;
            }

        public struct Point左料仓
            {
            public const short 初始位置 = 0;
            public const short 满盘_10盘定位位置 = 2;
            public const short 单盘_1盘定位位置 = 4;            
            }

        public struct Point右料仓
            {  
            public const short 初始位置 = 0;
            public const short 满载_10盘收料位置 = 2;
            public const short 空载_1盘收料位置= 4;
            }

        public struct Point供料PSA
            { 
            public const short PSA_Z轴初始位置 = 0;
            public const short PSA_Z轴单片位置 = 2;
            public const short PSA_Y轴吸料位置 = 4;
            public const short PSA_Y轴放料位置= 6;
            public const short PSA_Y轴费料位置 = 8;  
            }

        public struct Point保压
            { 
            public const short 初始位置 = 0;
            public const short 保压位置 = 2;
            }
        }
    }
