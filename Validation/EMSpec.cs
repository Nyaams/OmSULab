using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public class EMSpec : SpecCore<string>
    {
        private Regex RegexCheckEmail = new Regex("[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+");
        public override void IsValid(string value)
        {
            if (!RegexCheckEmail.IsMatch(value))
            {
                throw new ValidationException($"{value} не является Email'ом");
            }
        }
    }
}
