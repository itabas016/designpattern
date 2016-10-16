#Design Patterns - Head First Series
See the below list:

* **[Adapter Pattern](#adapter-pattern)**
* **[Bridge Pattern](#bridge-pattern)**
* **[Builder Pattern](#builder-pattern)**
* **[Command Pattern](#command-pattern)**
* **[Composite Pattern](#composite-pattern)**
* **[Compound Pattern](#compound-pattern)**
* **[Decorate Pattern](#decorate-pattern)**
* **[Delegate Pattern](#delegate-pattern)**
* **[Facade Pattern](#facade-pattern)**
* **[Factory Pattern](#factory-pattern)**
* **[Abstract Factory Pattern](#abstract-factory-pattern)**
* **[Flyweight Pattern](#flyweight-pattern)**
* **[Iterator Pattern](#iterator-pattern)**
* **[Observer Pattern](#observer-pattern)**
* **[ProtoType Pattern](#prototype-pattern)**
* **[Proxy Pattern](#proxy-pattern)**
* **[Singleton Pattern](#singleton-pattern)**
* **[State Pattern](#state-pattern)**
* **[Strategry Pattern](#strategry-pattern)**
* **[Template Pattern](#template-pattern)**

###Adapter-Pattern
Adapter pattern works as a bridge between two incompatible interfaces. This type of design pattern comes under structural pattern as this pattern combines the capability of two independent interfaces.

This pattern involves a single class which is responsible to join functionalities of independent or incompatible interfaces. A real life example could be a case of card reader which acts as an adapter between memory card and a laptop. You plugin the memory card into card reader and card reader into the laptop so that memory card can be read via laptop.

#####Implementation
![adapter]

Headfirst example code see project.

Detail tutorialspoint example code see [here](https://www.tutorialspoint.com/design_pattern/adapter_pattern.htm)

###Observer-Pattern
Observer pattern is used when there is one-to-many relationship between objects such as if one object is modified, its depenedent objects are to be notified automatically. Observer pattern falls under behavioral pattern category.

#####Implementation
![observer]

Headfirst example code see project.

Detail tutorialspoint example code see [here](https://www.tutorialspoint.com/design_pattern/observer_pattern.htm)

###Decorate-Pattern
Decorator pattern allows a user to add new functionality to an existing object without altering its structure. This type of design pattern comes under structural pattern as this pattern acts as a wrapper to existing class.

This pattern creates a decorator class which wraps the original class and provides additional functionality keeping class methods signature intact.

We are demonstrating the use of decorator pattern via following example in which we will decorate a shape with some color without alter shape class.

#####Implementation
![decorate]

Headfirst example code see project.

Detail tutorialspoint example code see [here](https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm)

###Factory-Pattern
Factory pattern is one of most used design pattern. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.

#####Implementation
![factory]

Headfirst example code see project.

Detail tutorialspoint example code see [here](https://www.tutorialspoint.com/design_pattern/factory_pattern.htm)

###Abstract-Factory-Pattern
Abstract Factory patterns work around a super-factory which creates other factories. This factory is also called as factory of factories. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

In Abstract Factory pattern an interface is responsible for creating a factory of related objects without explicitly specifying their classes. Each generated factory can give the objects as per the Factory pattern.

#####Implementation
![abstract-factory]

Headfirst example code see project.

Detail tutorialspoint example code see [here](https://www.tutorialspoint.com/design_pattern/factory_pattern.htm)

[adapter]: img/adapter_pattern_uml_diagram.jpg
[observer]: img/observer_pattern_uml_diagram.jpg
[decorate]: img/decorator_pattern_uml_diagram.jpg
[factory]: img/factory_pattern_uml_diagram.jpg
[abstract-factory]: img/abstractfactory_pattern_uml_diagram.jpg

