## Fields 

A field is like a variable we declare at the class level, to store data about the instance. 

- Initialization
- Read-only fields


A previous example: 

public class Customer
{
  List<Order> Orders;

  public Customer()
  {
    this.Orders = new List<Order>();
  }
}

However some developers believe we should initialize fields only when values are passed from the outside. In this case, we initialise the orders field without any external values. 

In situations like this, there is another way to initialize the ordrs field: 

public class Customer
{
  List<Order> Orders = new List<Order>();
}

this initializers the Orders field, without the need to create the constructor. 

Benefits are that we can have multiple constructors, and the orders field will always be initialized to an empty list. 

***Read-Only Fields***

public class Customer
{
  readonly List<Order> Orders = new List<Order>();
}

readonly modifier makes sure this field is only assigned once. Creates safety/ robustness in code. 

