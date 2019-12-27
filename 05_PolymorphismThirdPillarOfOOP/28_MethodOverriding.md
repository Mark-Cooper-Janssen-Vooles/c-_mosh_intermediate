## Method Overriding 
- method overriding
- virtual / override 


Method overriding is modifying the ***implementation*** of an ***inherited method***


public class Shape
{
  public void Draw()
  {
  }
}

public class Circle : Shape
{
}

public class Image : Shape
{
}


--- can be changed to:

public class Shape
{
  public virtual void Draw()
    {
      //default implementation
    }
}

//Draw is a method inherited by Circle and Image. By decorating the Draw method with the "virtual" keyword, that gives us the ability to change its implementation in a derived class. 

public class Circle : Shape
{
  public override void Draw()
  {
    //new implementation
  }
}

//to change its implementation, we use the "override" keyword in the derived class.