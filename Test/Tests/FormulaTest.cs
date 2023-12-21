using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmSULab;
using OmSULab.MenuItems;
using NUnit.Framework;

namespace Tests.OmSULab
{
    [TestFixture]
    public class FormulaTest
    {
        [TestCase(1, 5, 2, 2)]
        public void Test(double x, double y, double z, double res)
        {
            Assert.That(firstFormula.Calc(x,y,z), Is.EqualTo(res));
        }
    }
}