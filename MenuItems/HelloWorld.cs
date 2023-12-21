using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab
{
    internal class HelloWorld : MenuItemCore
    {
        public override string GetTitle()
        {
            return "[1] Hello World!";
        }
        public override void Execute()
        {
            Console.Clear();
            CIOUtils.printfn("Привет Мир!");
            CIOUtils.printfn("Hello World!");
        }
    }
}
