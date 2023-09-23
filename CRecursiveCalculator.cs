using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static double iDateRequest()
        {
            int iLimitDates = 4;
            DateTime[] inputDate = new DateTime[iLimitDates + 1];

            Console.WriteLine("У вас имеется возможность ввести 4 даты.");
            for (int i = 0; i < iLimitDates; i++)
            {
                Console.Write($"Введите {i + 1} дату в формате (дд.мм.гггг): ");
                inputDate[i] = CIOUtils.dtSafeRead();
            }

            while (inputDate[0] > inputDate[1])
            {
                Console.Clear();
                Console.WriteLine(inputDate[0].ToShortDateString() + "-" + inputDate[1].ToShortDateString());
                Console.Write("Конечная дата не может быть меньше начальной.\n" +
                              "Введите другое значение конечной даты в первом отрезке: ");
                inputDate[1] = CIOUtils.dtSafeRead();
            }

            while (inputDate[2] > inputDate[3])
            {
                Console.Clear();
                Console.WriteLine(inputDate[2].ToShortDateString() + "-" + inputDate[3].ToShortDateString());
                Console.Write("Конечная дата не может быть меньше начальной.\n" +
                              "Введите другое значение конечной даты во втором отрезке: ");
                inputDate[3] = CIOUtils.dtSafeRead();
            }
            Console.Clear();
            Console.WriteLine("Первый отрезок дат: " + inputDate[0].ToShortDateString() +
                              "-" + inputDate[1].ToShortDateString());

            Console.WriteLine("Второй отрезок дат: " + inputDate[2].ToShortDateString() +
                              "-" + inputDate[3].ToShortDateString());

            double dSum = 0;
            if (inputDate[2] > inputDate[1] ||
                inputDate[3] < inputDate[0])
            {
                Console.WriteLine("Отрезки дат не пересекаются.");
                dSum = 0;
            }
            else if (inputDate[2] > inputDate[0] &&
                     inputDate[3] > inputDate[1])
                dSum = (inputDate[1] - inputDate[2]).TotalDays + 1;
            else if (inputDate[2] < inputDate[0] &&
                     inputDate[3] < inputDate[1])
                dSum = (inputDate[3] - inputDate[0]).TotalDays + 1;
            else if (inputDate[2] > inputDate[0] &&
                     inputDate[3] < inputDate[1])
                dSum = (inputDate[3] - inputDate[0]).TotalDays;
            else if (inputDate[2] > inputDate[0] &&
                     inputDate[3] == inputDate[1])
                dSum = (inputDate[3] - inputDate[2]).TotalDays + 1;
            else if (inputDate[2] == inputDate[0] &&
                     inputDate[3] < inputDate[1])
                dSum = (inputDate[3] - inputDate[2]).TotalDays + 1;
            else if (inputDate[2] < inputDate[0] &&
                     inputDate[3] > inputDate[1])
                dSum = (inputDate[1] - inputDate[0]).TotalDays + 1;
            else dSum = (inputDate[3] - inputDate[0]).TotalDays + 1;

            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("Factorial(" + dSum + ") = " + CFactorialCalculation.iFactorialCalc(dSum));
            sw.Stop();
            Console.WriteLine($"Время потраченное на вычисление факториала: {sw.Elapsed}");
            return 0;
        }
    }
}