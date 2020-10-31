using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class GoldCard : DiscountCard
    {
        public GoldCard(Customer customer) : base(customer)
        {
            m_initialDiscountRate = 2f;
        }

        protected override float GetDiscountRate()
        {
            var discountRate = (int)Owner.Turnover / 100 + m_initialDiscountRate;

            if (discountRate > 10)
            {
                return 10;
            }
            else
            {
                return discountRate;

            }
        }
    }
}
