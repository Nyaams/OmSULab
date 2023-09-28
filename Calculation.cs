using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class Calculation
    {
        private static double argX;
        private static double argY;
        private static double argZ;
        private static double dCalculationArguments()
        {
            Console.Write("Введите аргумент х: ");
            argX = CIOUtils.dSafeRead();
            while (argX < 0)
            {
                Console.Write("Квадратный корень из отрицательных чисел не является вещественным.\n" +
                              "Введите новое значение аргумента х: ");
                argX = CIOUtils.dSafeRead();
            }
            Console.Write("Введите аргумент y: ");
            argY = CIOUtils.dSafeRead();
            Console.Write("Введите аргумент z: ");
            while (argZ == 0)
            {
                Console.Write("Деление на 0 невозможно\nВведите новое значение аргумента z: ");
                argZ = CIOUtils.dSafeRead();
            }
            argZ = CIOUtils.dSafeRead();
            return 0;
        }
        public static void dCalculation()
        {
            dCalculationArguments();
            double dResult;
            dResult = (argY - Math.Sqrt(argX)) / argZ;
            Console.WriteLine("(y-√(x))/z = " + Math.Round(dResult, 3));
        }
    }
}
