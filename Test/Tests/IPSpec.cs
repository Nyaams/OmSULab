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
    public class TestIPSpecification
    {
        [Test]
        public void IPSpecification_Validate_IsIP()
        {
            new IPSpec().IsValid("192.168.1.1");
        }
        [Test]
        public void IPSpecification_Validate_IsNoteIP_throwValidationEx()
        {
            Assert.Throws<ValidationException>(() => new IPSpec().IsValid("0"));

        }
    }
}
