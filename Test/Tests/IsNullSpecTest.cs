using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmSULab;
using OmSULab.MenuItems;
using OmSULab.Validation;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace Tests.OmSULab
{
    [TestFixture]
    public class IsNullSpecificationTest
    {
        [Test]
        public void IsNullSpecification_IsValid_NullArg()
        {
            new IsNullSpec().IsValid(null);
        }

        [Test]
        public void IsNullSpecification_IsValid_NotNullArg_thrValidationEx()
        {
            Assert.Throws<ValidationException>(() => {
                new IsNullSpec().IsValid("www");
            });

        }
    }
}
