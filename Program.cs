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
        static void Main(string[] args)
        {
            MenuValue.Add(new Exit());
            MenuValue.Add(new HelloWorld());
            MenuValue.Add(new Calculation());
            MenuValue.Add(new FactorialCalculation());
            MenuValue.Add(new Strings());
            MenuValue.Start();
        }
    }
}
