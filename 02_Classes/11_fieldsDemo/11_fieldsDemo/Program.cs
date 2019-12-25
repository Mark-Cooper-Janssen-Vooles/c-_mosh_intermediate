using System;

namespace _11_fieldsDemo
{
    public class Order
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Mark");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote(); //because of a bug, reinitializes the orders list to 0. This is where you'd use a read-only modifier!

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
