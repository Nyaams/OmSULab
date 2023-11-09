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
        static void task3()
        {
            CIOUtils.printfn("Введите первую строку: ");
            string sFirstString = CIOUtils.sSafeRead();

            CIOUtils.printfn("Введите вторую строку: ");
            string sSecondString = CIOUtils.sSafeRead();
            Console.Clear();

            CIOUtils.printfn("Первая строка: " + sFirstString + "\n" + "Вторая строка: " + sSecondString);
            try
            {
                Compare(sFirstString, sSecondString);
                CIOUtils.printfn("\nСовпадают ли они посимвольно? - Совпадают.");
            }
            catch (ValidationException firstEx) { CIOUtils.printfn(firstEx.Message); }

            string sFirstStringForRegExp = sFirstString;
            string sSecondStringForRegExp = sSecondString;
            sFirstString = sFirstString.Replace("  ", " ");
            sFirstString = sFirstString.ToUpper();
            sFirstString = sFirstString.Trim();
            sSecondString = sSecondString.Replace("  ", " ");
            sSecondString = sSecondString.ToUpper();
            sSecondString = sSecondString.Trim();

            try
            {
                ModificationCompare(sFirstString, sSecondString);
                CIOUtils.printfn("Совпадают ли они посимвольно с модификациями? - Совпадают.");
            }
            catch (ValidationException secondEx) { CIOUtils.printfn(secondEx.Message); }

            string sFirstReversedString = new string(sFirstString.Reverse().ToArray());
            try
            {
                ReverseCompare(sFirstReversedString, sSecondString);
                CIOUtils.printfn("Является ли одна строка перевёртышем к другой? - Является.\n");
            }
            catch (ValidationException thirdEx) { CIOUtils.printfn(thirdEx.Message); }

            CIOUtils.printfn(sFirstStringForRegExp);
            RegexCheckEmail(sFirstStringForRegExp);
            RegexCheckPhone(sFirstStringForRegExp);
            RegexCheckIP(sFirstStringForRegExp);

            CIOUtils.printfn("\n" + sSecondStringForRegExp);
            RegexCheckEmail(sSecondStringForRegExp);
            RegexCheckPhone(sSecondStringForRegExp);
            RegexCheckIP(sSecondStringForRegExp);
        }

        public static bool Compare(string firstString, string secondString)
        {
            if (firstString == secondString) return true;
            throw new ValidationException("\nСовпадают ли они посимвольно? - Не совпадают.");
        }
        public static bool ModificationCompare(string firstString, string secondString)
        {
            if (firstString == secondString) return true;
            throw new ValidationException("Совпадают ли они посимвольно с модификациями? - Не совпадают.");
        }
        public static bool ReverseCompare(string firstString, string secondString)
        {
            if (firstString == secondString) return true;
            throw new ValidationException("Является ли одна строка перевёртышем к другой? - Не является.\n");
        }
        public static void RegexCheckEmail(string str)
        {
            try
            {
                isEmail(str);
                CIOUtils.printfn("Строка является Email'ом");
                return;
            }
            catch (ValidationException EmailEx) { CIOUtils.printfn(EmailEx.Message); }
        }
        public static void RegexCheckPhone(string str)
        {
            try
            {
                isPhone(str);
                CIOUtils.printfn("Строка является Тел. номером");
                return;
            }
            catch (ValidationException PhoneEx) { CIOUtils.printfn(PhoneEx.Message); }
        }
        public static void RegexCheckIP(string str)
        {
            try
            {
                isIP(str);
                CIOUtils.printfn("Строка является IP-адресом");
                return;
            }
            catch (ValidationException IPEx) { CIOUtils.printfn(IPEx.Message); }
        }
        public static bool isEmail(string str)
        {
            string sEmailPattern = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
            if (Regex.IsMatch(str, sEmailPattern)) { return true; }
            throw new ValidationException("Строка не является Email'ом");
        }
        public static bool isPhone(string str)
        {
            string sPhonePattern = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
            if (Regex.IsMatch(str, sPhonePattern)) { return true; }
            throw new ValidationException("Строка не является Тел. номером");
        }
        public static bool isIP(string str)
        {
            string sIPAddressPattern = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            if (Regex.IsMatch(str, sIPAddressPattern)) { return true; }
            throw new ValidationException("Строка не является IP-адресом");
        }
        public override void Execute()
        {
            Console.Clear();
            task3();
        }
    }
}
