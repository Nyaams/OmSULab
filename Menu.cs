using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    public class Menu
    {
        public static void Summon()
        {
            while (true)
            {
                switch (MenuValue.iMenuValue())
                {
                    case 0:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        HelloWorld.Hello();
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
                    case 3:
                        Console.Clear();
                        Console.WriteLine("У вас имеется возможность ввести 4 даты.");
                        FactorialCalculation.dFactorialOutput();
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
    }
}
