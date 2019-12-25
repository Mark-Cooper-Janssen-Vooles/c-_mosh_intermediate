## Inheritance

- What is inheritance
- What are the benefits? 
- UML Notation
- Syntax

A kind of relationship between two classes that allows one to inherit code from the other. 
Is-A relationship 
(A car Is-A vehicle)

Benefits:
- Code re-use
- Polymorphic behavior 

---

i.e. 
Parent / base class / super class
High level:
PresentationObject class

Child / derived class
Lower level: (classes that inherit from presentation object)
Text class
Table class
Image class 

---

Syntax: 

public class PresentationObject
{
  //common shared code
}

public class Text : PresentationObject
{
  //code specific to text
}


---

in c# a class can have only 1 parent. 