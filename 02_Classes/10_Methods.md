### Methods 

- Signature of Methods
- Method Overloading
- Params Modifier  //he only thinks this modifier is useful
- Ref Modifier
- Out modifier

***Signatue of a method***
- Name
- Number and type of parameters

public class Point
{
  public void Move(int x, int y) {} 
}

Move, int x and int y are the signatures.

***OVerloading MEthods***
- Having a method with the same name but different signatures

public class Point
{
  public void Move(int x, int y) {} 
  public void Move(Point newLocation) {}
  public void Move(Point newLocation, int speed) {}
}

***A method with varying number of parameters***
public class Calculator
{
  public int Add(int[] numbers) {}
}

can use:
var result = calculator.Add(new int[]{1, 2, 3, 4})

problem: every time we want to pass arguments to this method we have to create and initialize an array. 


Can instead use ..

***The Params Modifier***

public class Calculator
{
  public int Add(params int[] numbers) {}
}

//can now call in traditional form:
var result = calculator.Add(new int[]{1, 2, 3, 4});
//can also call in this new way: 
var result = calculator.Add(1, 2, 3, 4);


If your method may need a varying number of modifiers, can make it easier using the params modifier. 