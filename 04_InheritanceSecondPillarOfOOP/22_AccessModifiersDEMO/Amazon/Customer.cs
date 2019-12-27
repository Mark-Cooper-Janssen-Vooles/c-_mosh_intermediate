using System;
namespace Amazon
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //    Console.WriteLine("promoted to level 1");
            //else
            //    Console.WriteLine("promoted to lvl 2");

            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("promote logic changed");
        }
        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}
