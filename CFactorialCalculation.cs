using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class CFactorialCalculation
    {
        public static double iFactorialCalc(double n)
        {
            if (n == 0 || n == 1) 
                return 1;

            return n * iFactorialCalc(n - 1);
        }
    }
}
