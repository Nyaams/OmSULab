using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    public class RecursiveCalculator
    {
        static int iLimitDates = 4;
        static DateTime[] inputDate = new DateTime[iLimitDates + 1];
        static double dDateRequest()
        {
            for (int i = 0; i < iLimitDates; i++)
            {
                CIOUtils.printf($"Введите {i + 1} дату в формате (дд.мм.гггг): ");
                inputDate[i] = CIOUtils.dtSafeRead();                
            }
            while (inputDate[0] > inputDate[1])
            {
                Console.Clear();
                CIOUtils.printfn(inputDate[0].ToShortDateString() + "-" + inputDate[1].ToShortDateString());
                Console.Write("Конечная дата не может быть меньше начальной.\n" +
                              "Введите другое значение конечной даты в первом отрезке: ");
                inputDate[1] = CIOUtils.dtSafeRead();
            }

            while (inputDate[2] > inputDate[3])
            {
                Console.Clear();
                CIOUtils.printfn(inputDate[2].ToShortDateString() + "-" + inputDate[3].ToShortDateString());
                Console.Write("Конечная дата не может быть меньше начальной.\n" +
                              "Введите другое значение конечной даты во втором отрезке: ");
                inputDate[3] = CIOUtils.dtSafeRead();
            }        
            return 0;
        }
        static double dResTest = 0;
        public static double dDateCalculation(DateTime firstDate, DateTime secondDate, DateTime thirdDate, DateTime fourthDate)
        {            
            CIOUtils.printfn("Первый отрезок дат: " + firstDate.ToShortDateString() +
                              "-" + secondDate.ToShortDateString());

            CIOUtils.printfn("Второй отрезок дат: " + thirdDate.ToShortDateString() +
                              "-" + fourthDate.ToShortDateString());

            if (thirdDate > secondDate ||
                fourthDate < firstDate)
            {
                CIOUtils.printfn("Отрезки дат не пересекаются.");
                dResTest = 0;
            }
            else if (thirdDate > firstDate &&
                     fourthDate > secondDate)
                dResTest = (secondDate - thirdDate).TotalDays + 1;

            else if (thirdDate < firstDate &&
                     fourthDate < secondDate)
                dResTest = (fourthDate - firstDate).TotalDays + 1;

            else if (thirdDate > firstDate &&
                     fourthDate < secondDate)
                dResTest = (fourthDate - firstDate).TotalDays;

            else if (thirdDate > firstDate &&
                     fourthDate == secondDate)
                dResTest = (fourthDate - thirdDate).TotalDays + 1;

            else if (thirdDate == firstDate &&
                     fourthDate < secondDate)
                dResTest = (fourthDate - thirdDate).TotalDays + 1;

            else if (thirdDate < firstDate &&
                     fourthDate > secondDate)
                dResTest = (secondDate - firstDate).TotalDays + 1;

            else dResTest = (fourthDate - firstDate).TotalDays + 1;

            while (dResTest > 170)
            {
                CIOUtils.printfn("Значение аргумента больше 170 и не может быть вычислено за отведенное время.\n" +
                                  "Введите данные повторно.");
                return dDateRequest();

            }            
            return dResTest;
        }
        public static double outRes()
        {
            return dResTest;
        }
        static double dRes = 0;
        public static double dDateResult()
        {
            Console.Clear();
            CIOUtils.printfn("Первый отрезок дат: " + inputDate[0].ToShortDateString() +
                              "-" + inputDate[1].ToShortDateString());

            CIOUtils.printfn("Второй отрезок дат: " + inputDate[2].ToShortDateString() +
                              "-" + inputDate[3].ToShortDateString());

            if (inputDate[2] > inputDate[1] ||
                inputDate[3] < inputDate[0])
            {
                CIOUtils.printfn("Отрезки дат не пересекаются.");
                dRes = 0;
            }
            else if (inputDate[2] > inputDate[0] &&
                     inputDate[3] > inputDate[1])
                dRes = (inputDate[1] - inputDate[2]).TotalDays + 1;

            else if (inputDate[2] < inputDate[0] &&
                     inputDate[3] < inputDate[1])
                dRes = (inputDate[3] - inputDate[0]).TotalDays + 1;

            else if (inputDate[2] > inputDate[0] &&
                     inputDate[3] < inputDate[1])
                dRes = (inputDate[3] - inputDate[0]).TotalDays;

            else if (inputDate[2] > inputDate[0] &&
                     inputDate[3] == inputDate[1])
                dRes = (inputDate[3] - inputDate[2]).TotalDays + 1;

            else if (inputDate[2] == inputDate[0] &&
                     inputDate[3] < inputDate[1])
                dRes = (inputDate[3] - inputDate[2]).TotalDays + 1;

            else if (inputDate[2] < inputDate[0] &&
                     inputDate[3] > inputDate[1])
                dRes = (inputDate[1] - inputDate[0]).TotalDays + 1;

            else dRes = (inputDate[3] - inputDate[0]).TotalDays + 1;

            while (dRes > 170)
            {
                CIOUtils.printfn("Значение аргумента больше 170 и не может быть вычислено за отведенное время.\n" +
                                  "Введите данные повторно.");
                return dDateRequest();

            }
            return dRes;
        }
        public static void Exe()
        {
            Console.Clear();
            dDateRequest();
            dDateResult();
            var sw = new Stopwatch();
            sw.Start();
            secondFormula.Calc(dRes);
            sw.Stop();
            CIOUtils.printf($"Время потраченное на вычисление факториала: {sw.Elapsed} \n");
        }
    }
}