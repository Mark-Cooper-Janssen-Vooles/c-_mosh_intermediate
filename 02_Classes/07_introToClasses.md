## Classes

- what is a class
- example of a class
- what is an object
- static members 

A class is a building blok of a software application. 

An app consists of multiple classes, each responsible for a part of the application. 

In a web app we might have the following areas: (a bit like MVC ) 
- presentation (V)
- business logic / domain (C)
- data access / presistance (M)

In presentation we might have a class called "PostView" responsible for displaying a post to the user. 

In business logic, we might have a class of "Post" itself. 

In the data access / presistance, we might have a class called "PostRepository" 


***Anatomy of a Class***
- Data (represented by fields)
- Behaviour (represented by methods / functions )

i.e. 
Person 
------
(data)
Name: strng
Age: byte
Height: float 
Weight: byte 
---
methods: (provide behaviour )
Walk()
Talk()
Eat()
Sleep()


Post
---
Title: string
Description: string
DateTime: DateTime
---
Publish()
Like()
Comment(message)


***Object***
An object is different from a class. An instance of a class resides in the memory. 

If person is the class, we can have instances of this class like John, Mary, Scott 




***Declaring Class***

public and class are reserved keywords in a class. Person is the name. Use PascalCase to name your classes.

public class Person 
{

  //declare data:
  public string Name;

  //declare behavior: (or method)
  // return type 'void' means it doesn't return any value.
  public void Introduce()
  {
    Console.WriteLine("Hi, my name is " + Name);
  }


}

***Creating new Instances***

//when naming use camelCase

Person person = new Person();
or 
var person = new Person();

***Using Objects***

person.Name = "Mark";
person.Introduce();

***Class Members***
- Instance: accessible from an object 
i.e. person.Introduce;

- Static: accessible from the class.
i.e. Console.WriteLine();
Console is the class, and WriteLine is the static method. I.e. we don't have to create an instance of console in order to call WriteLine. We cann it directly on the class! 

***Why use Static Members?***
- To represent concepts that are singleton, i.e. only one instance of that concept in the memory. 
- DateTime.Now => we only need one instance of this. 
- Console.WriteLine() => we only have one console, thus all the members of the console class are defined as static. 

***Declaring Static Members***
public class Person
{
  public static int PeopleCount = 0;
}

To declare a method as static, all you have to do is declare the static keyword after the access modifier. You can use it on any members (methods) on a class.

