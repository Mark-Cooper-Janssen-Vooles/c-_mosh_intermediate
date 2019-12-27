## Access Modifier

- Why access modifiers are important
- Black box metaphor
- C# access modifiers


A black box: We want to design our objects to look like a black box. There is limited visibility from the outside but there could be a lot of magic going on in the inside. 

Why do we want to design our classes like a black box? It comes down to isolating changes. The more a class reveals about how it works on the inside, the more risky it becomes when we change that class (because there could be other things tht rely on it )

i.e. a DVD player. On the outside you just see a few buttons, aka the "public interface". On the inside there is a circuit board and lots of stuff going on. You want to design a class like the DVD player, the "public interface" (how the rest of your code interacts with it ) should be kept as basic as possible. 


***Access Modifiers***
- public
- private
- protected
- internal 
- protected internal

PUBLIC:
Accessible from everywhere. 

public class Customer
{
  public void Promote()
  {
  }
}

var customer = new Customer();
customer.Promote();
//promote is visible to the outside


PRIVATE: 
Accessible only from inside the class.

public class Customer
{
  private int CalculateRating()
  {
  }
}

cannot do customer.CalculateRating();
//private is the opposite of public, only accessible from inside the class. 


PROTECTED:
Accessible only from the class and its derived classes.

public class Customer
{
  protected int CalculateRating()
  {
  }
}

Any classes derived from this class will still be able to see this method (this breaks encapsulation). A lot of developers consider it a bad design. Mosh says avoid if you can, prefer to use private. 


INTERNAL:
Accessible only from the same assembly. 
Mosh says it doesn't make sense 

internal class RateCalculator
{
}

//in the same assembly, this will work:
var calc = new RateCalculator();

//in a different assembly, wont work:
var calc = new RateCalculator();


PROTECTED INTERNAL:
Accessible only from the same assembly or any derived classes.

public class Customer
{
  protected internal void Weirdo()
  {

  }
}

Mosh says the most weird thing in the c# language. Never use lol.