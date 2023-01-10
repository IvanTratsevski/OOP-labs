using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralLib
{
    public class IntegralExceptions : Exception
    {
        public IntegralExceptions(string message)
            :base(message)
        {
        }
    }
}
