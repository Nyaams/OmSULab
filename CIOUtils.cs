using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class CIOUtils
    {
        public static int iSafeRead()
        {
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                    return iValue;
                Console.Write("Неверный формат. Введите целочисленное значение: ");
            }
        }
        public static double dSafeRead()
        {
            while (true)
            {
                string sAmount = Console.ReadLine();
                double dAmount = 0;
                if (Double.TryParse(sAmount, out dAmount))
                    return dAmount;
                Console.Write("Неверный формат. Введите числовое значение: ");
            }
        }
    }
}
