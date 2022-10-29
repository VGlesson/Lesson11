using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    struct Line
    {
        public double coefK;
        public double CoefK
        {
            get
            {
                return coefK;
            }
            set
            {
                if (value != 0)
                {
                    coefK = value;
                }
                else
                {
                    Console.WriteLine("Коэффициент k не может быть равен 0");
                }
            }
        }

        public double coefB { get; set; }
        public static double CoefB { get; internal set; }

        public Line(double CoefK, double CoefB)
        {
            this.coefK = CoefK;

            this.coefB = CoefB;
        }
        public void Root()
        {
            Console.WriteLine("Решение уравнения. Х = {0}", (-CoefB) / CoefK);
        } 
    }
}

