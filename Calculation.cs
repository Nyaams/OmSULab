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
        static double dArgumentX;
        static double dArgumentY;
        static double dArgumentZ;
        static double dCalculationArguments()
        {
            CIOUtils.printfn("Введите аргумент х: ");
            dArgumentX = CIOUtils.dSafeRead();
            while (dArgumentX < 0)
            {
                CIOUtils.printfn("Квадратный корень из отрицательных чисел не является вещественным.\n" +
                              "Введите новое значение аргумента х: ");
                dArgumentX = CIOUtils.dSafeRead();
            }
            CIOUtils.printfn("Введите аргумент y: ");
            dArgumentY = CIOUtils.dSafeRead();
            CIOUtils.printfn("Введите аргумент z: ");
            dArgumentZ = CIOUtils.dSafeRead();
            while (dArgumentZ == 0)
            {
                CIOUtils.printfn("Деление на 0 невозможно\nВведите новое значение аргумента z: ");
                dArgumentZ = CIOUtils.dSafeRead();
            }            
            return 0;
        }
        
        public static double ArgumentX()
        {
        	return dArgumentX;
        }
        
        public static double ArgumentY()
        {
        	return dArgumentY;
        }
        
        public static double ArgumentZ()
        {
        	return dArgumentZ;
        }
        
        public override void Execute()
        {
            Console.Clear();
            dCalculationArguments();
            firstFormula.Calc();
        }
    }
}
