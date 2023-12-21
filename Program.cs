using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OmSULab;
using OmSULab.MenuItems;

namespace OmSULab
{
    internal class Program
    {
        public static void Main()
        {
            Menu.Add(new Exit());
            Menu.Add(new HelloWorld());
            Menu.Add(new FormulaTask());
            Menu.Add(new DateTask());
            Menu.Add(new StringsTask());
            Menu.Execution();
        }
    }
}
