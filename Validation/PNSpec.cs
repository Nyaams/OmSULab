using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public class PNSpec : SpecCore<string>
    {
        public Regex RegexCheckPhone = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
        public override void IsValid(string value)
        {
            if (!RegexCheckPhone.IsMatch(value))
            {
                throw new ValidationException($"{value} не является Тел. номером");
            }
        }
    }
}
