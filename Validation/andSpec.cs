using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public class andSpec<T> : SpecCore<T>
    {
        ISpecification<T> spec1 = null;
        ISpecification<T> spec2 = null;

        public andSpec(ISpecification<T> s1, ISpecification<T> s2)
        {
            spec1 = s1;
            spec2 = s2;
        }

        public override void IsValid(T value)
        {
            spec1?.IsValid(value);

            if (spec2 != null)
            {
                spec2.IsValid(value);
            }
        }
    }
}
