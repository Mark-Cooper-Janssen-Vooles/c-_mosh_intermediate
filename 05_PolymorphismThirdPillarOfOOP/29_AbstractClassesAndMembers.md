## Abstract Classes and Members

- Abstract modifier
- Rules about abstract classes and members

The abstract modifier indicates that a class or a member is missing implementation.

public class Shape
{
  public virtual void Draw()
  {
  }
}

public class Circle : Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a circle" );
  }
}

The problem its that its hard to define the implenetation for Draw() for shape. How do we draw 'shape'? it doens't make sense - but it does for rectangle, circle etc. The concept of shape is too abstract. Better to use the abstract modifier! 

It lets the program know this method is missing implenetation, and that the derived classes must provide it. 

Changes to this: 

public abstract class Shape
{
  public abstract void Draw();
}

//not here the Draw() method is declared as abstract, so it doesn't have a body. When we declare a method as abstract, the class that contains it needs to be declared as abstract as well. 

public class Circle : Shape
{
  public override void Draw()
  {
    // implementation for circle
  }
}


***Abstract Members*** rules etc. 
FIRST RULE:
- do not include implementation (purely a decleration)

public abstract void Draw();

SECOND RULE:
- if a member is declared as abstract, the containing class needs to be declared as abstract too. 

public abstract class Shape
{
  public abstract void Draw();
}

THIRD RULE:
- In a derived class, you must implement all abstract members in the base abstract class

since shape had only one abstract method (draw), we only need to implement this one. If it had three, we would need to override all three abstract methods. 


public class Circle : Shape
{
  public override void Draw()
  {
    //implementation for Circle
  }
}

FOURTH RULE: 
- Abstract classes cannot be instantiated.

var shape = new Shape(); //won't compile! 


***Why use Abstract?***

- When you want to provide some common behaviour, while forcing other developers to follow your design.
i.e. whenever a developer derives a class from the shape class, they will be forced to provide an implementation for the draw method. 

