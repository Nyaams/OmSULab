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
    public class TestEMSpecification
    {
        [Test]
        public void EMSpecification_Validate_IsEM()
        {
            new EMSpec().IsValid("geon@ihateregex.io");
        }
        [Test]
        public void EMSpecification_Validate_IsNoteEM_throwValidationEx()
        {
            Assert.Throws<ValidationException>(() => new EMSpec().IsValid("0"));

        }
    }
}
