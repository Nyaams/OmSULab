using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using OmSULab;
using OmSULab.MenuItems;
using NUnit.Framework;

namespace Tests.OmSULab
{
    [TestFixture]
    public class MenuTest
    {
        [Test]
        public void Menu_ManageItems()
        {
            Menu.Clear();

            Menu.Add(new Exit());
            Assert.That(Menu.iMenuItems, Is.EqualTo(1));

            Menu.Clear();
            Assert.That(Menu.iMenuItems, Is.EqualTo(0));
        }
    }
}
