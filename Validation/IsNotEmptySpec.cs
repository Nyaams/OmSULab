using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public class IsNotEmptySpec : SpecCore<string>
    {
        public override void IsValid(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ValidationException("String is empty");
            }
        }
    }
}
