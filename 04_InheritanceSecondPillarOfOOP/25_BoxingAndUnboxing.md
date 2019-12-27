### Boxing / Unboxing
- Value types and reference types
- Boxing and unboxing

***Value Types***
- Are stored on the stack
The stack is:
When the program is executed, the limited amount of space in your memory is allocated to each thread of your program. This space is used to store simple values, i.e. primitive types: byte, int, float, char, bool, struct. 

Values stored in the stack have a short lifetype: as soon as they leave the scope they immediately get kicked off the stack by the runtime.

***Reference Types***
- Are stored in the heap 
The heap is a larger amount of memory.
We use heap to store objects that require a longer lifetime. 
- Examples of reference types in c# are any classes i.e. Object, Array, String, DbMigrator, etc. 

Why does it matter?
An object reference can be IMPLICITLY converted to a base class reference. 
Circle circle = new Circle();
Shape shape = circle; 

The object class is the base of all classes in the .NET framework. 

Cirlce circle = new Circle();
Shape shape = circle;
object shape = circle; 
// since object is the base of all classes, you can convert any reference type to it. 

***Boxing***
The process of converting a value type instance to an object reference 
i.e:

int number = 10;
object obj = number;

//or
object obj = 10;

***Unboxing***
The opposite of boxing, i.e. converting a reference type into a value type.

object obj = 10;
int number = (int)obj;



Boxing / Unboxng both have a performance penalty, because of the extra object creation. 