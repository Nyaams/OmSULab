using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    static class Menu
    {
        static List<MenuItemCore> menuItems = new List<MenuItemCore>();
        public static int MenuItems
        {
            get { return menuItems.Count; }
        }
        public static void Execution()
        {            
            {
                while (true)
                {
                    Menu.ShowMenu();
                    menuItems[Menu.iGetMenuValue()].Execute();
                    Console.Write("Нажмите клавишу Enter чтобы вернуться");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void ShowMenu()
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine(menuItems[i].GetTitle());
            }
        }
        static int iGetMenuValue()
        {
            int iMenuValue = CIOUtils.iSafeReadForMenu();
            while (iMenuValue < 0 || iMenuValue > menuItems.Count)
            {
                    Console.Clear();
                    Console.WriteLine("Пункт меню не найден. Попробуйте еще раз. ");
                    iMenuValue = CIOUtils.iSafeReadForMenu();
            }
            return iMenuValue;
        }
        public static void Add(MenuItemCore item) { menuItems.Add(item); }
        public static void Remove(MenuItemCore item) { menuItems.Remove(item); }
        public static void Clear() { menuItems.Clear(); }
    }
}
