using System;
using System.Collections.Generic;
using System.Globalization;
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
                int iValue;
                if (Int32.TryParse(sValue, out iValue))
                    return iValue;
                Console.Write("Неверный формат. Введите целочисленное значение: ");
                
            }
        }
        public static int iSafeReadForMenu()
        {
            while (true)
            {
                string sValue = Console.ReadLine();
                while (string.IsNullOrEmpty(sValue))
                {
                    sValue = Console.ReadLine();
                }
                int iValue;
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
                double dAmount;
                if (Double.TryParse(sAmount, out dAmount))
                    return dAmount;
                Console.Write("Неверный формат. Введите числовое значение: ");
            }
        }
        public static DateTime dtSafeRead()
        {
            while (true)
            {
                string input = Console.ReadLine();
                DateTime date1;
                if (DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out date1))
                {       
                        return date1;
                }
                Console.Write("Вы ввели дату неккоректно, формат ввода (дд.мм.гггг)\n" +
                    "Введите дату заново: ");
            }
        }
        public static string sSafeRead()
        { 
            string sRead = Console.ReadLine() ?? String.Empty;
            return sRead;
        }
        public static void printf(string msg)
        {
            Console.Write(msg);
        }
        public static void printfn(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
