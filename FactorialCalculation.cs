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
        public override void Execute()
        {
            Console.Clear();
            RecursiveCalculator.dDateMethodsCall();
            var sw = new Stopwatch();
            sw.Start();
            secondFormula.Calc();
            sw.Stop();
            CIOUtils.printf($"Время потраченное на вычисление факториала: {sw.Elapsed} \n");
        }
    }
}
