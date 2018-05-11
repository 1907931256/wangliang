using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BZGUI
{
    class Algorithm
    {
        public static bool FitCircle(double[] x, double[] y, out double center_x, out double center_y, out double r)
        {
            center_x = 0;
            center_y = 0;
            r = 0;
            try
            {
                int count = x.Length;
                if (count < 3)
                    return false;

                double x1 = 0.0f;
                double y1 = 0.0f;
                double x2 = 0.0f;
                double y2 = 0.0f;
                double x3 = 0.0f;
                double y3 = 0.0f;
                double x1y1 = 0.0f;
                double x1y2 = 0.0f;
                double x2y1 = 0.0f;

                for (int i = 0; i < count; i++)
                {
                    x1 += x[i];
                    y1 += y[i];
                    x2 += Math.Pow(x[i], 2);
                    y2 += Math.Pow(y[i], 2);
                    x3 += Math.Pow(x[i], 3);
                    y3 += Math.Pow(y[i], 3);
                    x1y1 += x[i] * y[i];
                    x1y2 += x[i] * y[i] * y[i];
                    x2y1 += x[i] * x[i] * y[i];
                }

                double C, D, E, G, H, N;
                double a, b, c;
                N = count;
                C = N * x2 - x1 * x1;
                D = N * x1y1 - x1 * y1;
                E = N * x3 + N * x1y2 - (x2 + y2) * x1;
                G = N * y2 - y1 * y1;
                H = N * x2y1 + N * y3 - (x2 + y2) * y1;
                a = (H * D - E * G) / (C * G - D * D);
                b = (H * C - E * D) / (D * D - G * C);
                c = -(a * x1 + b * y1 + x2 + y2) / N;

                double A, B, R;
                A = a / (-2);
                B = b / (-2);
                R = (float)Math.Sqrt(a * a + b * b - 4 * c) / 2;

                center_x = A;
                center_y = B;
                r = R;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RotateByAnyPoint(double center_x, double center_y, double x1, double y1, double theta, out double x2, out double y2)
        {
            double rad = theta * Math.PI / 180;
            x2 = (x1 - center_x) * Math.Cos(rad) - (y1 - center_y) * Math.Sin(rad) + center_x;
            y2 = (x1 - center_x) * Math.Sin(rad) + (y1 - center_y) * Math.Cos(rad) + center_y;
            return true;
        }

        public static bool FitLineByTowPoints(double[] p1, double[] p2, out double k, out double b)
        {
            k = 1;
            b = 0;
            try
            {
                k = (p2[1] - p1[1]) / (p2[0] - p1[0]);
                b = p1[1] - p1[0] * k;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool GetYByXOnLine(double k, double b, double x, out double y)
        {
            y = 0;
            try
            {
                y = k * x + b;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool GetXByYOnLine(double k, double b, double y, out double x)
        {
            x = 0;
            try
            {
                x = (y - b) / k;
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
