using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public class IPSpec : SpecCore<string>
    {
        private Regex RegexCheckIP = new Regex("(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");
        public override void IsValid(string value)
        {
            if (!RegexCheckIP.IsMatch(value))
            {
                throw new ValidationException($"{value} не является IP-адресом");
            }
        }
    }
}
