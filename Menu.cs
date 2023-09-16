using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    public class CMenu
    {
        public static void Summon()
        {
            while (true)
            {
                switch (iGetMenuValue())
                {
                    case 0:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Hello World!");
                        Console.WriteLine("Нажмите клавишу Enter чтобы вернуться");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Вычисление по формуле (y-sqrt(x))/z");
                        Calculation.dCalculation();
                        Console.WriteLine("Нажмите клавишу Enter чтобы вернуться");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Данного значения нет в меню.");
                        Console.WriteLine("Нажмите клавишу Enter чтобы вернуться");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private static int iGetMenuValue()
        {
            Console.Clear();
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Hello World!");
            Console.WriteLine("[2] Calc: (Y-sqrt(X))/Z");
            int iMenuValue = CIOUtils.iSafeRead();
            return iMenuValue;
        }
    }
}
