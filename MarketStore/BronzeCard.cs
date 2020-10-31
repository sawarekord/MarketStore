using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        public BronzeCard(Customer customer) : base(customer)
        {
            m_initialDiscountRate = 0f;
        }

        protected override float GetDiscountRate()
        {
            if (Owner.Turnover >= 100 && Owner.Turnover <= 300)
            {
                return 1f;
            }
            else if (Owner.Turnover > 300)
            {
                return 2.5f;
            }
            else
            {
                return m_initialDiscountRate;
            }
        }
    }
}
