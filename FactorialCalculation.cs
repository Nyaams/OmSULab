using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class FactorialCalculation : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[3] Recursion date";
        }
        public static double dFactorialCalc(double n)
        {
            if (n == 0 || n == 1) 
                return 1;

            return n * dFactorialCalc(n - 1);
        }
        public override void Execute()
        {
            Console.Clear();
            RecursiveCalculator.dDateMethodsCall();
            var sw = new Stopwatch();
            sw.Start();
            CIOUtils.printfn("Factorial(" + RecursiveCalculator.dDateResult() + ") = " + dFactorialCalc(RecursiveCalculator.dDateResult()));
            sw.Stop();
            CIOUtils.printf($"Время потраченное на вычисление факториала: {sw.Elapsed}");
        }
    }
}
