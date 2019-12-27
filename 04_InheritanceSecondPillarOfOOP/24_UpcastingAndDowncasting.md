## Upcasting and Downcasting

- Conversion from a derived class to a base class (upcasting)
- Conversion from a base class to a derived class (downcasting)
- The as and is keywords 

***Upcasting***

public class Shape
{
}

public class Circle : Shape
{
}

Circle circle = new Circle();
Shape shape = circle; 

We can convert an object of circle, to its base class reference (shape)

***Downcasting***

Circle anotherCircle = (Circle)shape

We can convert shape to circle using an explicit cast. Casting can throw an invalid cast exception.

i.e. Car car = (Car)shape; //throws InvalidCastException

ti prevent this exception from happening we can use ..

***The as keyword***

//explicit cast, may get an exception:
Car car = (Car) obj;


//safer way, use as keyword: 
Car car = obj as Car;
if (car != null)
{

}

When using as: If the object cannot be converted to the target type, we will not get an exception. Instead, null is returned. In the next line we can check if its not null. 

***The is keyword***

With the is keyword we can check the type of an object. 

if (obj is Car)
{
  //then we can safely cast it to the car
  Car car = (Car) obj;
}