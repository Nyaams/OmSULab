using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmSULab.Validation
{
    public interface ISpecification<T>
    {
        void IsValid(T value);
    }
}
