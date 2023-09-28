using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class FactorialCalculation
    {
        public static double dFactorialCalc(double n)
        {
            if (n == 0 || n == 1) 
                return 1;

            return n * dFactorialCalc(n - 1);
        }
    }
}
