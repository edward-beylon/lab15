using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace трпо15
{
    class AgeOverSizeException: ApplicationException
    {
        
        public int Value { get; }
        public AgeOverSizeException(string message, int val)
        : base(message)
        {
            Value = val;
        }
    }
}
