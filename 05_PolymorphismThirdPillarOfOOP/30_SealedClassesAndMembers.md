## Sealed Classes and Members

Sealed classes are the opposite of abstract classes. 

The sealed modifier prevents derivation of classes or overriding of methods. 

Can be applied to a class, or a class method. 

e.g. 

public class Circle : Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a circle");
  }
}

to...

public sealed class Circle : Shape
{
  public override void Draw()
  {
    Console.WriteLine("Drawing a circle");
  }
}

Now we cannot create a class that derives from circle. 

Or we can apply it to the draw method: 

public class Circle : Shape
{
  public sealed override void Draw()
  {
    Console.WriteLine("Drawing a circle");
  }
}

Sealed can only be applied to methods that are overriding the virtual method on the base class. 

***Why?***
- Sealed classes are slightly faster because of some run-time optimizations
- Mosh thinks it doesn't matter and is hardly ever used. Mosh hasnt used it in 12 years lol


