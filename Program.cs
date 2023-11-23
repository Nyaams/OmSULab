using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class Program
    {
        public static void Main()
        {
            Menu.Add(new Exit());
            Menu.Add(new HelloWorld());
            Menu.Add(new Calculation());
            Menu.Add(new FactorialCalculation());
            Menu.Add(new Strings());
            Menu.Execution();
        }
    }
}
