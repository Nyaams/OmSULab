using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class MenuValue
    {
        private static int iGetMenuValue()
        {
            Console.Clear();
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Hello World!");
            Console.WriteLine("[2] Calc: (Y-sqrt(X))/Z");
            Console.WriteLine("[3] Recursion date");
            int iMenuValue = CIOUtils.iSafeReadForMenu();
            return iMenuValue;
        }
        public static int iMenuValue()
        { 
            return iGetMenuValue();
        }
    }
}
