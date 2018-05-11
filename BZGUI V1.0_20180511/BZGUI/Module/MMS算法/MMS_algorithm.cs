using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BZGUI
{
    public struct Suface_Equation
    {
        public double A;
        public double B;
        public double C;
        public double D;
    }

    class MMS_algorithm
    {
        private readonly static MMS_algorithm instance = new MMS_algorithm();

        /// <summary>
        /// 构造函数
        /// </summary>
        public MMS_algorithm()
        { }

        public static MMS_algorithm Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// 三点求面方式
        /// </summary>
        /// <param name="z1"></param>
        /// <param name="z2"></param>
        /// <param name="z3"></param>
        /// <returns></returns>
        public Suface_Equation Calculating_Coefficient(double z1,double z2,double z3)
        {
            double x1 = 17.8;
            double y1 = 50;
            double x2 = 22.8;
            double y2 = 50;
            double x3 = 51.8;
            double y3 = 9.5;
            double a2 = x2 - x1;
            double b2 = y2 - y1;
            double c2 = z2 - z1;

            double a3 = x3 - x1;
            double b3 = y3 - y1;
            double c3 = z3 - z1;

            double A = b2 * c3 - b3 * c2;
            double B = a3 * c2 - a2 * c3;
            double C = a2 * b3 - a3 * b2;
            double D = a2 * c3 * y1 + a3 * b2 * z1 + b3 * c2 * x1 - x1 * b2 * c3 - a2 * b3 * z1 - a3 * c2 * y1;
            Suface_Equation se = new Suface_Equation();
            se.A = A; se.B = B; se.C = C; se.D = D;
            return se;
        }
        /// <summary>
        /// 已知两个面，求两面角
        /// </summary>
        /// <param name="Coeff1"></param>
        /// <param name="Coeff2"></param>
        /// <returns></returns>
        public double Calculating_dihedral(Suface_Equation Coeff1, Suface_Equation Coeff2)//两面角
        {
            double h =Math.Sqrt(Coeff1.A*Coeff1.A +Coeff1.B*Coeff1.B +Coeff1.C*Coeff1.C);
            double i = Math.Sqrt(Coeff2.A * Coeff2.A + Coeff2.B * Coeff2.B + Coeff2.C * Coeff2.C);
            double j = Math.Abs(Coeff1.A * Coeff2.A + Coeff1.B * Coeff2.B +  Coeff1.C  * Coeff2.C);
            double CosA =j / (h * i);
            if (CosA == 1)
            {
                return 0;
            }
            else
            {
                return (Math.Acos(CosA))*(180/Math.PI);            
            }
        }


    }
}
