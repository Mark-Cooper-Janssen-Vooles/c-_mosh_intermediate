### Constructors 

A constructor is a method that is called when an instance of a class is created. 

Its to put an object in an early state (i.e. initialize some of the data fields of the class)

***How to initialize***
public class Customer
{
  public Customer()
  {

  }
}

A constructor has the exact same name as the class (this is a requirement). If you change the name, the compiler will not treat it as a constructor. 

Also note they have no return type. 

If you need to initialize an object upon creation, this is where you put your code. 

The above is a default or "parameterless" constructor. If you don't put a constructor at all, this is what happens behind the scenes anyway. 

Default values: numbers to 0, booleans to false, objects set to null, characters set to empty character .


public class Customer
{
  public string Name;

  public Customer(string name)
  {
    this.Name = name; 
  }
}

"this" is a keyword that references the current object. 

var customer = new Customer("John");

***Constructor Overloading***

Overloading is about having a method with the same name but different signatures.

A signature is what uniquely identifies a method: Its return type, name, and the types and numbers of its paramters (arguments). i.e.: 

public class Customer 
{
  public Customer() {...}

  public Customer(string name) {...}

  public Customer(int id, string name) {...}
}


fast way to create constructor:
in the new class, type "ctor" and hit tab.


you only use constructors in classes where you really want to initialize the objects to an early state, in order to perform. 

Rule of thumb: 
Whenever you have a class and it has a list of any type, always initialize that list to an empty list. i.e. in default constructor type: 
Orders = new List<Order>();