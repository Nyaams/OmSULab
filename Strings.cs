using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OmSULab
{
    internal class Strings : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[4] Strings";
        }
        static void task4()
        {
            Console.WriteLine("Введите первую строку: ");
            string sFirstString = CIOUtils.sSafeRead();            
            Console.Clear();

            Console.WriteLine("Введите вторую строку: ");
            string sSecondString = CIOUtils.sSafeRead();
            Console.Clear();

            Console.WriteLine("Первая строка: " + sFirstString + "\n" + "Вторая строка: " + sSecondString);
            if (sFirstString == sSecondString) 
            { 
                Console.WriteLine("\nСовпадают ли они посимвольно? - Совпадают."); 
            }
            else 
            { 
                Console.WriteLine("\nСовпадают ли они посимвольно? - Не совпадают."); 
            }
            sFirstString = sFirstString.Replace("  ", " ");            
            sFirstString = sFirstString.ToUpper();
            sFirstString = sFirstString.Trim();
            sSecondString = sSecondString.Replace("  ", " ");
            sSecondString = sSecondString.ToUpper();
            sSecondString = sSecondString.Trim();
            string sFirstStringForRegExp = sFirstString;
            string sSecondStringForRegExp = sSecondString;

            if (sFirstString == sSecondString)
            {
                Console.WriteLine("Совпадают ли они посимвольно с модификациями? - Совпадают."); 
            }
            else 
            { 
                Console.WriteLine("Совпадают ли они посимвольно с модификациями? - Не совпадают."); 
            }

            string sFirstModifiedString = new string(sFirstString.Reverse().ToArray());
            if (sFirstModifiedString == sSecondString)
            {
                Console.WriteLine("Является ли одна строка перевёртышем к другой? - Является.\n");
            }
            else
            {
                Console.WriteLine("Является ли одна строка перевёртышем к другой? - Не является.\n");
            }

            string sEmailPattern = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
            if (Regex.IsMatch(sFirstStringForRegExp, sEmailPattern))
                Console.WriteLine("Первая строка является Email'ом: " + sFirstStringForRegExp);
            else { Console.WriteLine("Первая строка не является Email'ом"); }
            
            string sPhonePattern = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
            if (Regex.IsMatch(sFirstStringForRegExp, sPhonePattern))
                Console.WriteLine("Первая строка является Тел. номером: " + sFirstStringForRegExp);
            else { Console.WriteLine("Первая строка не является Тел. номером"); }
            
            string sIPAddress = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            if (Regex.IsMatch(sFirstStringForRegExp, sIPAddress))
                Console.WriteLine("Первая строка является IP-адресом: " + sFirstStringForRegExp + "\n");
            else { Console.WriteLine("Первая строка не является IP-адресом\n"); }

            if (Regex.IsMatch(sSecondStringForRegExp, sEmailPattern))
                Console.WriteLine("Вторая строка является Email'ом: " + sSecondStringForRegExp);
            else { Console.WriteLine("Вторая строка не является Email'ом"); }            
           
            if (Regex.IsMatch(sSecondStringForRegExp, sPhonePattern))
                Console.WriteLine("Вторая строка является Тел. номером: " + sSecondStringForRegExp);
            else { Console.WriteLine("Вторая строка не является Тел. номером"); }            
            
            if (Regex.IsMatch(sSecondStringForRegExp, sIPAddress))
                Console.WriteLine("Вторая строка является IP-адресом: " + sSecondStringForRegExp);
            else { Console.WriteLine("Вторая строка не является IP-адресом\n"); }
        }
        public override void Execute()
        {
            Console.Clear();
            Strings.task4();
        }
    }
}
