using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class NegativeValueException : Exception
    {

        public NegativeValueException(float enteredValue) : base(GetMessage(enteredValue))
        {
        }

        private static string GetMessage(float enteredValue)
        {
            return $"Entered value {enteredValue} is not a positive number";
        }
    }
}
