using System;
using Amazon;

namespace _22_AccessModifiersDEMO
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();

        }
    }
}
