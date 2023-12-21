using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.MenuItems
{
    internal class DateTask : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[3] Recursion date";
        }
        public override void Execute()
        {
            RecursiveCalculator.Exe();
        }
    }
}
