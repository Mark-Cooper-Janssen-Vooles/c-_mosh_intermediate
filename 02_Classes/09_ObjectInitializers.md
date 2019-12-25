## Object Initializers

Can also initilze an object using an object initializer. 

You can use it to avoid creating multiple constructors. 

public class Person
{
  public int Id;
  public string FirstName;
  public string LastName;
  public DateTime Birthdate;
}

Instead of lots of constructors, can just use this syntax: 

var person = new Person 
                {
                  FirstName = "Mark",
                  LastName = "Janssen
                };

"object initialization syntax"
