using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class Calculation : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[2] Calc: (y-√(x))/z";
        }
        private static double dArgumentX;
        private static double dArgumentY;
        private static double dArgumentZ;
        private static double dCalculationArguments()
        {
            Console.Write("Введите аргумент х: ");
            dArgumentX = CIOUtils.dSafeRead();
            while (dArgumentX < 0)
            {
                Console.Write("Квадратный корень из отрицательных чисел не является вещественным.\n" +
                              "Введите новое значение аргумента х: ");
                dArgumentX = CIOUtils.dSafeRead();
            }
            Console.Write("Введите аргумент y: ");
            dArgumentY = CIOUtils.dSafeRead();
            Console.Write("Введите аргумент z: ");
            dArgumentZ = CIOUtils.dSafeRead();
            while (dArgumentZ == 0)
            {
                Console.Write("Деление на 0 невозможно\nВведите новое значение аргумента z: ");
                dArgumentZ = CIOUtils.dSafeRead();
            }            
            return 0;
        }
        public override void Execute()
        {
            Console.Clear();
            dCalculationArguments();
            double dResult;
            dResult = (dArgumentY - Math.Sqrt(dArgumentX)) / dArgumentZ;
            Console.WriteLine("(y-√(x))/z = " + Math.Round(dResult, 3));
        }
    }
}
