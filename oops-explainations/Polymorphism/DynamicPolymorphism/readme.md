
Dynamic polymorphism is implemented by abstract classes and virtual functions.

## Abstract Class
C# allows you to create abstract classes that are used to provide partial class implementation of an class. Implementation is completed when a derived class inherits from it. Abstract classes contain abstract methods, which are implemented by the derived class. The derived classes have more specialized functionality.

Here are the rules about abstract classes:

* You cannot create an instance of an abstract class

* You cannot declare an abstract method outside an abstract class

* When a class is declared sealed, it cannot be inherited, abstract classes cannot be declared sealed.