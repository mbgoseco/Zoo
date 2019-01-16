# Zoo

## Description
This app uses the visualzation of a zoo and its animals to demonstrate and practice the 4 principals of Object Oriented Programming: Abstraction,  Inheritence, Encapsulation, and Polymorphism. This is represented by a number of zoo animals with various properties and methods that are defined in different places accross the heirarchy of the zoo's class structure.

## Documentation
Here some definitions and examples of the principals of OOP in use within this app:

- Abstraction: The use of classes and class members that are declared but then only implemented in their derived classes. In our Zoo app we have many abstract classes, properties and methods, such as the LaysEggs and Speak(), both declared in the base Animals class, but then used in their child classes through the use of the override keyword.

- Inheritence: This is how classes can be created to use their parent classes and thus "inherit" their contained members. The indvidual animals in our zoo, such as the bear or the alligator inherit all of the classes above them, and so the bear is also a member of the Mammal class, while the alligator is also a member of the Reptile class, and both are members of the Animal class and have access to their respective properties and methods.

- Encapsulation: This allows members of classes to be accessed, or encapsulated, within a single object, and is also use to control access to those members like hiding those not used. When our Zoo creates and instance of a tiger, lets call him Tony, then now Tony has access to all the members of his class and those it inherited, all called by the same object like Tony.Speak() or Tony.FurColor.

- Polymorphism: The idea that when a property or method has been declared, it can be implemented in defferent classed to different effects. In the Zoo app, a virtual string property called OpenHours has a default value in the Animals class of "9am - 8pm". However in the Reptiles class it is overridden to the value of "9am - 6pm" to represent the operating hours of just the reptiles exhibit. Also, in the base class is an abstract property called AnimalCount which is used in each individual aniamal's class to assign the quantity of that animal in the zoo.

## Interfaces
An interface is a set of properties, methods, events, or indexers that can be implemented by multiple classes. They work similar to abstract class, however a class can only inherit a single abstract class, whereas a class can inherit multiple interfaces. Our Zoo uses two interfaces:

- IFeed
 - Members: string Feed();
 - Used by class: Tiger, BrownBear, BlackBear, Platypus, Alligator, SeaTurtle, BoxTurtle, KingCobra

- ISwim
 - Members: string Swim();
 - Used by class: Tiger, BrownBear, BlackBear, Platypus, Alligator, SeaTurtle

These interfaces were designed to be accessed by concrete class or object that can swim and/or get hungry. 

## Diagram
![diagram]()

## Examples
![screenhot]()