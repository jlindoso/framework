using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Interfaces
{
    public interface IDivisorService
    {
        public ResultDTO GetDivisors(Int64 input);
        public bool IsPrimeNumber(Int64 number);
    }
}
