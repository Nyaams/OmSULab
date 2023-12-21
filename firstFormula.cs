using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
	public class firstFormula : Calculation
	{
		public static double Calc(double ArgX, double ArgY, double ArgZ)
		{
			double dResult;
			dResult = (- Math.Sqrt(ArgX) + ArgY) / ArgZ;
			CIOUtils.printfn("(y-√(x))/z = " + Math.Round(dResult, 3));
			return dResult;
		}
	}
}
