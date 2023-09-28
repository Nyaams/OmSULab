using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class CalculationByTheFormula
    {
        public static double dCalculation()
        {
            Console.Write("Введите аргумент х: ");
            double argX = CIOUtils.dSafeRead();
            while (argX < 0)
            {
                Console.Write("Квадратный корень из отрицательных чисел не является вещественным.\n" +
                              "Введите новое значение аргумента х: ");
                argX = CIOUtils.dSafeRead();
            }

            Console.Write("Введите аргумент y: ");
            double argY = CIOUtils.dSafeRead();

            Console.Write("Введите аргумент z: ");
            double argZ = CIOUtils.dSafeRead();
            while (argZ == 0)
            {
                Console.Write("Деление на 0 невозможно\nВведите новое значение аргумента z: ");
                argZ = CIOUtils.dSafeRead();
            }

            double dResult;
            dResult = (argY - Math.Sqrt(argX)) / argZ;
            Console.WriteLine("(y-√(x))/z = " + Math.Round(dResult, 3));
            return 0;
        }
    }
}
