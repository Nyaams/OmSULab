using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.MenuItems
{
    public class Exit : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[0] Exit";
        }
        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
