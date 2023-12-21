using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    public static class Menu
    {
        static List<MenuItemCore> Items = new List<MenuItemCore>();
        public static int iMenuItems
        {
            get 
            { 
                return Items.Count;
            }
        }
        public static void Execution()
        {
            while (true)
            {
                Menu.ShowMenu();
                Items[Menu.iGetMenuValue()].Execute();
                CIOUtils.printf("Нажмите клавишу Enter чтобы вернуться");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ShowMenu()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                CIOUtils.printfn(Items[i].GetTitle());
            }
        }
        static int iGetMenuValue()
        {
            int iMenuValue = CIOUtils.iSafeReadForMenu();
            while (iMenuValue < 0 || iMenuValue >= Items.Count)
            {
                Console.Clear();
                CIOUtils.printfn("Пункт меню не найден. Попробуйте еще раз.\n");
                ShowMenu();
                iMenuValue = CIOUtils.iSafeReadForMenu();
            }
            return iMenuValue;
        }
        public static void Add(MenuItemCore item)
        {
            Items.Add(item);
        }
        public static void Remove(MenuItemCore item)
        {
            Items.Remove(item);
        }
        public static void Clear()
        {
            Items.Clear();
        }
    }
}
