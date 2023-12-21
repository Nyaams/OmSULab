using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmSULab;
using OmSULab.MenuItems;
using OmSULab.Validation;

namespace OmSULab.Validation
{
    public class IsNullSpec : SpecCore<string>
    {
        public override void IsValid(string value)
        {
            if (value != null)
            {
                throw new ValidationException("Value is not null");
            }
        }
    }
}
