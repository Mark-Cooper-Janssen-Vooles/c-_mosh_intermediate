## Access Modifiers
In c# we have 5 access modifiers: 
- Public
- Private
- Protected
- Internal
- Protected Internal

An access modifier is a way to control access to a class and/or its members.

Its used to create safety in our programs.

public class Customer
{
  private string Name;
}

var john = new Customer();
john.Name; //this won't compile cos its private!

***Object Oriented Programming***
- Encapsulation / information handling
- Inheritance
- Polymorphism 

Encapsulation:
Define fields as private
Provide getter/setter methods as public

public class Person
{
  private string Name;

//i.e. setter:
  public void SetName(string name)
  {
    if(!String.IsNullOrEmpty(name))
      this.Name = name;
  }

//i.e. getter:
  public string GetName()
  {
    return Name;
  }
}

for fields the convention is to use the camelCase prefix with an underline: 
Private fields should start with an underline and follow camelCase.

public class Person
{
  private string _name;

  public void SetName(string name)
  {
    if(!String.IsNullOrEmpty(name))
      this._name = name;
  }

  public string GetName()
  {
    return _name;
  }
}