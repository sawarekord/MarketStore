using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bronzeCustomer = new Customer(-1);
                DiscountCard bronzeCard = new BronzeCard(null);

                Console.WriteLine($"Bronze: Turnover ${bronzeCustomer.Turnover}");
                bronzeCard.WriteOutput(150f);
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Bronze customer exception: {ex.Message}");
                Console.WriteLine();
            }


            try
            {
                var silverCustomer = new Customer(600);
                DiscountCard silverCard = new SilverCard(silverCustomer);

                Console.WriteLine($"Silver: Turnover ${silverCustomer.Turnover}");
                silverCard.WriteOutput(850f);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Silver customer exception: {ex.Message}");
                Console.WriteLine();
            }


            try
            {
                var goldCustomer = new Customer(1500);
                DiscountCard goldCard = new GoldCard(goldCustomer);

                Console.WriteLine($"Gold: Turnover ${goldCustomer.Turnover}");
                goldCard.WriteOutput(1300f);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gold customer exception: {ex.Message}");
            }
        }
    }
}
