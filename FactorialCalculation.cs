using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class FactorialCalculation
    {
        public static double dFactorialCalc(double n)
        {
            if (n == 0 || n == 1) 
                return 1;

            return n * dFactorialCalc(n - 1);
        }
        public static double dFactorialOutput()
        {
            RecursiveCalculator.dDateMethodsCall();
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Factorial(" + RecursiveCalculator.dDateResult() + ") = " + dFactorialCalc(RecursiveCalculator.dDateResult()));
            sw.Stop();
            Console.WriteLine($"Время потраченное на вычисление факториала: {sw.Elapsed}");
            return 0;
        }
    }
}
