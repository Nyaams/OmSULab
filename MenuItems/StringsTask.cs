using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.MenuItems
{
    internal class StringsTask : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[4] Strings";
        }
        public override void Execute()
        {
            Console.Clear();
            Strings.task3();
        }
    }
}
