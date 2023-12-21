using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public abstract class SpecCore<T> : ISpecification<T>
    {
        public abstract void IsValid(T value);

        public andSpec<T> And(ISpecification<T> spec)
        {
            return new andSpec<T>(this, spec);
        }
    }
}
