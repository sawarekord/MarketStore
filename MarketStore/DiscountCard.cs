using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    abstract class DiscountCard
    {
        public Customer Owner { get; private set; }

        protected float m_initialDiscountRate;

        public DiscountCard(Customer customer)
        {
            if(customer == null)
            {
                throw new Exception("Customer can not be null");
            }

            Owner = customer;
        }

        public float CalculatePrice(float price)
        {
            ValidatePrice(price);

            return price - GetDiscount(price);
        }

        private float GetDiscount(float price)
        {
            return price * GetDiscountRate() / 100;
        }

        protected abstract float GetDiscountRate();

        public void WriteOutput(float price)
        {
            ValidatePrice(price);

            Console.WriteLine($"Purchase value: ${price:0.00}");
            Console.WriteLine($"Discount rate: {GetDiscountRate():0.0}%");
            Console.WriteLine($"Discount: ${GetDiscount(price):0.00}");
            Console.WriteLine($"Total: ${CalculatePrice(price):0.00}");
        }

        private static void ValidatePrice(float price)
        {
            if (price < 0)
            {
                throw new NegativeValueException(price);
            }
        }
    }
}
