using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    public abstract class MenuItemCore
    {
        public abstract string GetTitle();
        public abstract void Execute();
    }
}
