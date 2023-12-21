using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    public class Calculation
    {        
        
        public static double dCalculationArguments()
        {
            double dArgumentX, dArgumentY, dArgumentZ;
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
            firstFormula.Calc(dArgumentX, dArgumentY, dArgumentZ);
            return 0;
        }                  
    }
}
