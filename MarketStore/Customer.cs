using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Customer
    {
        public float Turnover { get; set; }

        public Customer(float turnover)
        {
            if(turnover < 0f)
            {
                throw new NegativeValueException(turnover);
            }

            Turnover = turnover;
        }
    }
}
