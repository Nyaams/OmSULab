using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class CRecursiveCalculator
    {
        public static int iDateRequest()
        {
            Console.Write("Введите количество вводимых дат: ");
            int iLimitDates = CIOUtils.iSafeRead();
            DateTime[] inputDate = new DateTime[iLimitDates + 1];
            while (iLimitDates % 2 != 0)
            {
                Console.Write("Количество дат должно быть чётным.\n" +
                    "Введите количество снова: ");
                iLimitDates = CIOUtils.iSafeRead();
            }
            for (int i = 0; i < iLimitDates; i++)
            {
                Console.Write($"Введите {i + 1} дату в формате (дд.мм.гггг): ");
                inputDate[i] = CIOUtils.dtSafeRead();
                Console.WriteLine(inputDate[i].ToShortDateString());
            }     
            return 0;
        }
    }
}
