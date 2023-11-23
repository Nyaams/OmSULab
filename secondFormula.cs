using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
	internal class secondFormula : Calculation
	{
	    public static double dFactorialCalc(double n)
        {
            if (n == 0 || n == 1) 
                return 1;

            return n * dFactorialCalc(n - 1);
        }
		public static void Calc()
		{
            CIOUtils.printfn("Factorial(" + RecursiveCalculator.dDateResult() + ") = " + dFactorialCalc(RecursiveCalculator.dDateResult()));
		}
	}
}
