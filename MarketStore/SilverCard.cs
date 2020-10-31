using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class SilverCard : DiscountCard
    {
        public SilverCard(Customer customer) : base(customer)
        {
            m_initialDiscountRate = 2f;
        }

        protected override float GetDiscountRate()
        {
            if (Owner.Turnover > 300)
            {
                return 3.5f;
            }
            else
            {
                return m_initialDiscountRate;
            }
        }
    }
}
