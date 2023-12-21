using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.MenuItems
{
    internal class FormulaTask : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[2] Calc: (y-√(x))/z";
        }
        public override void Execute()
        {
            Console.Clear();
            Calculation.dCalculationArguments();
        }
    }
}
