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
    public class AndSpecificationTest
    {
        [Test]
        public void AndSpecification_IsValid_1of2SpecsIsTrue_thrValidationException()
        {
            ISpecification<string> isNotEmptySpec = new IsNotEmptySpec();
            ISpecification<string> isNullSpec = new IsNullSpec();
            andSpec<string> andSpec = new andSpec<string>(isNotEmptySpec, isNullSpec);

            Assert.Throws<ValidationException>(() => { andSpec.IsValid(""); });
        }
    }
}
