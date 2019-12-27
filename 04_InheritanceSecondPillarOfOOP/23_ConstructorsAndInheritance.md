## Constructors and Inheritance

Constructor Inheritance:
- Base class constructors are always executed first.
- Base class constructors are not inherited.

public class Vehicle
{
  private string _registrationNumber;

  public Vehicle(string registrationNumber)
  {
    _registrationNumber = registrationNumber;
  }
}

A car class that derives from vehicle:

public class Car : Vehicle
{
  public Car(string registrationNumber)
  {
    _registrationNumber = registrationNumber; //this won't work! 
  }
}

because the vehicle _registrationNumber field is private, we can't access it in the car class. If it was protected, for arguments sake, we could access it here. But no point, since we'd just be repeating ourselves. Instead better to reuse the code already written in vehicle class. 
***Use the base keyword***

public class Car : Vehicle
{
  public Car(string registrationNumber)
    : base(registrationNumber)
  {
    //initialise fields sepcific to the Car class.
  }
}

