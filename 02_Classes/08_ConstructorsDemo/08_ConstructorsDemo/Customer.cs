using System;
using System.Collections.Generic;

namespace _08_ConstructorsDemo
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(int id)
            : this() //before this constructor is called, it will call the constructor without parameters above (and instantite this.Orders
        {
            this.Id = id;
        }

        //this constructor is the same as below.
        //public Customer(int id, string name )
        //    : this()
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}

        public Customer(int id, string name)
             : this(id) //first it goes to the constructor that just takes id. when it goes there, its gonna first go to a constructor that takes nothing (and sets up orders)
        {
            this.Name = name;
        }

    }
}
