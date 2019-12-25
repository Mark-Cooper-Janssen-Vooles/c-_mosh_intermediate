using System;

namespace _08_ConstructorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCustomer = new Customer(1, "John");

            Console.WriteLine(newCustomer.Id);
            Console.WriteLine(newCustomer.Name);

            var order = new Order();
            newCustomer.Orders.Add(order);
            
        }
    }
}
