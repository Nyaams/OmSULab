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
    public class TestPNSpecification
    {
        [Test]
        public void PNSpecification_Validate_IsPN()
        {
            new PNSpec().IsValid("8989829304");
        }
        [Test]
        public void PNSpecification_Validate_IsNotePN_throwValidationEx()
        {
            Assert.Throws<ValidationException>(() => new PNSpec().IsValid("0"));

        }
    }
}
