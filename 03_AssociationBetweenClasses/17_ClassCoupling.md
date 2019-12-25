## Class Coupling

Coupling is a measure of how interconnected classes and subsystems are. 

A software application is comprised of various classes packaged in namespaces and assemblies. 

If we need to make a change in class A, does class B and class F have to be changed? They will atleast need to be redeployed. 

If class D and class C are dependent on class B, it will also effect these. Etc, butterfly effect. 

"Tightly coupled" design => classes who are closely related or dependent on each other. Its BAD! 



***Loosely coupled => the ideal software.***

But how? 
- Encapsulation (access modifiers)
- Relationships between classes (this section)
- Interfaces (seperate section)

***Types of relationships***
- Inheritance
- composition
- Favour composition over inheritance

*compoisition relationships involve less coupling. 

