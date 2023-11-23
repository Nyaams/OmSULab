using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
	internal class firstFormula : Calculation
	{
		public static void Calc()
		{
			double dResult;
			dResult = (Calculation.ArgumentY() - Math.Sqrt(Calculation.ArgumentX())) / Calculation.ArgumentZ();
			CIOUtils.printfn("(y-√(x))/z = " + Math.Round(dResult, 3));
		}
	}
}
