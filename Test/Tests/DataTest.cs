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
    public class DataTest
    {
        [TestCase("12.12.2000", "15.12.2000", "10.12.2000", "16.12.2000", 4)]
        public void Date_ValidInputs_Success(string s1, string s2, string s3, string s4, double res)
        {
            DateTime start1 = DateTime.ParseExact(s1, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime end1 = DateTime.ParseExact(s2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime start2 = DateTime.ParseExact(s3, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime end2 = DateTime.ParseExact(s4, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Assert.That(RecursiveCalculator.dDateCalculation(start1, end1, start2, end2), Is.EqualTo(res));
        }
    }
}
