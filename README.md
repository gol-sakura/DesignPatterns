# 👩🏻‍💻  Software Design Patterns 

[![N|Solid](https://image.freepik.com/free-vector/woman-with-laptop-education-working-concept_113065-224.jpg)](https://refactoring.guru/design-patterns/csharp)



---------
**Design pattern** in the object-oriented programming is a way to solve common design problems which happen in real-world application development. Selecting and usage of design patterns depends on needs and problems. Design patterns categorize in three types: 
- **Creational Design Pattern** 
- **Structural Design Pattern**
- **Behavioral Design Pattern**
--------
## 👾 **Design Patterns used for this project** 👾

In this project two types of Behavioral Design Pattern, Command & Observer patterns, has been used along with Factory pattern which goes under Creational Design pattern category. 

👉 **Command Design Pattern**

Encapsulates a request as an object that hold all the information about the request. It even allows operation like undo and redo. This project will model a system in which an order can be created for a flower market, and add, remove, redo and change flowers.

👓 **Observer Design Pattern**

Defines the one to many relationships between objects. When one object changes state so all its dependants are going to be notified and updated automatically. For this projects flower shops can subscribe to the those markets which produce and sell flowers.

🏭 **Factory Design Pattern**

Is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. Implementation of the Invoker also includes an implementation of the factory method pattern which provides a efficient way to execute related methods.

#### 🤖 **SOLID Design principles** 🤖

These principles, when combined together, make it easy for a programmer to develop software that are easy to maintain and extend. They also make it easy for developers to avoid code smells, easily refactor code, and are also a part of the agile or adaptive software development. There are five SOLID principles:

[![N|Solid](https://amitshahi.dev/static/500403c0fabdd69504307a79a5417fd9/be90f/solid.jpg)](https://refactoring.guru/design-patterns/csharp)

## 🤖 **SOLID Design Patterns used for this project** 🤖

**The Dependency Inversion Principle (DIP)** states that a high-level class must not depend upon a lower level class. They must both depend upon abstractions. And, secondly, an abstraction must not depend upon details, but the details must depend upon abstractions. This will ensure the class and ultimately the whole application is very robust and easy to maintain and expand, if required.

-------

### 📚 **Refrences** 📚 

- [How to use Factory Method Design Pattern in C#](https://dev.to/gary_woodfine/how-to-use-factory-method-design-pattern-in-c-3ia3)
- [C# Design Patterns – Factory Method](https://code-maze.com/factory-method/)
- [Factory Method](https://refactoring.guru/design-patterns/factory-method)
- [Factory - C# Design Patterns](https://www.dofactory.com/net/factory-method-design-pattern)
- [Design Patterns in C# With Real-time Examples](https://dotnettutorials.net/course/dot-net-design-patterns/)
- [Design Patterns In C# .NET](https://www.c-sharpcorner.com/UploadFile/bd5be5/design-patterns-in-net/)
- [Behavioral Design Pattern in C#](https://dotnettutorials.net/lesson/behavioral-design-pattern/)
- [C# Design Patterns – Command](https://code-maze.com/command/)
- [Boost Your C# With Behavioural Design Patterns](https://www.udemy.com/course/boost-your-csharp-code-with-behavioural-design-patterns/)
- [Behavioral Design Pattern for .NET](https://www.c-sharpcorner.com/UploadFile/nipuntomar/behavioral-design-pattern-for-net-part-1/#:~:text=Behavioral%20Design%20patterns%20are%20the,communicate%20between%20classes%20and%20object.)
- [Command Design Pattern in C# with Real-time Example](https://dotnettutorials.net/lesson/command-design-pattern/)
- [How to use the command design pattern in C#](https://www.infoworld.com/article/3409800/how-to-use-the-command-design-pattern-in-c.html)
- [Command](https://www.dofactory.com/net/command-design-pattern)
- [Observer Design Pattern](https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern)
- [Observer Design Pattern Best Practices](https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern-best-practices)
- [Implement an Observer](https://docs.microsoft.com/en-us/dotnet/standard/events/how-to-implement-an-observer)
- [Implement a Provider](https://docs.microsoft.com/en-us/dotnet/standard/events/how-to-implement-a-provider)
- [Observer Also known as: Event-Subscriber, Listener](https://refactoring.guru/design-patterns/observer)
- [IObservable<T> Interface](https://docs.microsoft.com/en-us/dotnet/api/system.iobservable-1?view=net-5.0)
- [Learn C# Design Patterns Step by Step in 8 hours](https://www.youtube.com/watch?v=YDobmucohqk&ab_channel=.NETInterviewPreparationvideos)
- [IObserver<T>.OnCompleted Method](https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1.oncompleted?view=net-5.0#System_IObserver_1_OnCompleted)
- [IObserver<T>.OnNext(T) Method](https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1.onnext?view=net-5.0#System_IObserver_1_OnNext__0_)
- [IObserver<T>.OnError(Exception) Method](https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1.onerror?view=net-5.0#System_IObserver_1_OnError_System_Exception_)
- [IComparable<T> Interface](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-5.0)
- [IComparable<T>.CompareTo(T) Method](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1.compareto?view=net-5.0#System_IComparable_1_CompareTo__0_)
- [SOLID Design Principles Explained - C#](https://www.dotnettricks.com/learn/designpatterns/solid-design-principles-explained-using-csharp)
- [SOLID Design principles](https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425)
- [SOLID Design Principles Introduction](https://www.youtube.com/watch?v=HLFbeC78YlU&ab_channel=kudvenkat)
- [Becoming a better developer by using the SOLID design principles](https://www.youtube.com/watch?v=rtmFCcjEgEw&list=PLqC1o5z-uQjcByPPS6G6ray-XiTZqgG6f&index=3&t=0s&ab_channel=LaraconEU)
- [Use MVC, SOLID Principles, and Design Patterns in .NET](https://openclassrooms.com/en/courses/5671481-use-mvc-solid-principles-and-design-patterns-in-net)
- [Examples and definitions of the SOLID principles in Software Design](https://blog.scottlogic.com/2018/06/26/solid-principles.html)

















[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)


   [dill]: <https://github.com/joemccann/dillinger>
   [git-repo-url]: <https://github.com/joemccann/dillinger.git>
   [john gruber]: <http://daringfireball.net>
   [df1]: <http://daringfireball.net/projects/markdown/>
   [markdown-it]: <https://github.com/markdown-it/markdown-it>
   [Ace Editor]: <http://ace.ajax.org>
   [node.js]: <http://nodejs.org>
   [Twitter Bootstrap]: <http://twitter.github.com/bootstrap/>
   [jQuery]: <http://jquery.com>
   [@tjholowaychuk]: <http://twitter.com/tjholowaychuk>
   [express]: <http://expressjs.com>
   [AngularJS]: <http://angularjs.org>
   [Gulp]: <http://gulpjs.com>

   [PlDb]: <https://github.com/joemccann/dillinger/tree/master/plugins/dropbox/README.md>
   [PlGh]: <https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md>
   [PlGd]: <https://github.com/joemccann/dillinger/tree/master/plugins/googledrive/README.md>
   [PlOd]: <https://github.com/joemccann/dillinger/tree/master/plugins/onedrive/README.md>
   [PlMe]: <https://github.com/joemccann/dillinger/tree/master/plugins/medium/README.md>
   [PlGa]: <https://github.com/RahulHP/dillinger/blob/master/plugins/googleanalytics/README.md>
