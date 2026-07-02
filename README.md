A repository for all of my C# code. I am learning C# from the [Ultimate C# Masterclass for 2026](https://www.udemy.com/course/ultimate-csharp-masterclass).

Below is pretty much all code I have typed as part of my learning, and should be in the order of the lessons from the course.

## Section 2 - C# Fundamentals

Console.WriteLine("My first line of C#.");
Console.WriteLine("[S]ee all Todos.");
Console.WriteLine("[A]dd a Todo.");
Console.WriteLine("[R]emove a Todo.");
Console.WriteLine("[E]xit.");

string userInput = "A";
Console.WriteLine(userInput);

userInput = "ABC";
Console.WriteLine(userInput);

int number = 2;
number = 7;


// Basic Operators
int a = 10;
int b = 5;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);

// Implicitly typed variables with the "var" keyword
var word = "Boeing";
var numberBeFifteen = 15;

// pauses program running until the user presses any keyboard key
Console.ReadKey();

# Section 2, Lesson 32

All paths in a non-void method must return a value

# Section 2, Lesson 55

- You can access individual indices before the last one, in an array like this: numbers[^1], numbers[^2]. The carat symbol tells the compiler to look for that particular index from the last one.

# Section 3, Lesson 73

## Naming conventions
- Any public name should use Pascal casing
- Any private field should start with an underscore followed by a lowercase letter
- The name of a method should alway start with a verb

# Section 3, Lesson 81
- Optional parameters must come after all required parameters in the method signature
- They must also be set to compile-time constant i.e., their value cannot be derived from expressions or other methods that will be evaluated at run time
- In case there are two constructors, one with one required parameter, the other with one required and one optional parameter, and a call like this is made:
	- var nameOnly = new MedicalAppointment("Sam");
	- the constructor with the required parameter of type string and variable "name" will be used. The other constructor with the string name and optional parameter of type int and variable days will not be used
	- Same goes for any overloaded mthod with a similar setup
	- ** So in the case of ambiguity, the constructors/methods with no optional parameters will be used

# Section 3, Lesson 83
- The readonly modifier makes fields readable only; they cannot be modified directly outside a class
	- It's good practice to make fields readonly whenever possible
	- Making all fields of an object makes the entire object immutable i.e. it cannot be changed once it is created
	- You can set the values of readonly fields in the constructor of a class, but not change them directly
	- So you cannot do something like this: reactangle1.Width = 10;
	- readonly is used on fiels when it is known for sure that their values will not change after they are set in the constructor
- The const modifier can be assigned only to variables and fields
	- Must be given a compile-time constant; not doing so will result in a run-time error
	- Constants are named using PascalCase

# Section 3, Lesson 86
- Object initializers can be used instead of calling constructors to initialize a class
- The "init" setter is a one-time setter that only initializes a class' properties during class initialization; after that, any property with an init will behave like it only has a getter, not a setter

# Section 3, Lesson 89 - Static classes and static methods
- Static methods
	- Static methods are useful when it is uneccesary to create a new instance of a class rthat does not have fields i.e. it is stateless. Rather than creating a new instance of the class everytime just with a defaultg constructor, you can access methods directly by calling them with the class' name, instead of instantiating the class with the "new" keyword.
	- Static methods belong to the class as a whole, not an instance of the class
	- Static methods cannot access instance data i.e. fields of a class or data returned by other properties of the class
- Static classes
	- When all methods of a class are static, the class itself can be made static with the "static" keyword
	- Static classes can contain only static methods
- ** If a private method does not use any instance data i.e. field values, make it static
- Const fields
	- All const fields are implicitly static

# Section 3, Lesson 91 - Refactoring the Names class so that it meets the Single Resposibility Principle (SRP) - Part 1
- I have two projects in the ToDoList Solution - SRPBeforeRefactoring and SRPAfterRefactoring
- The SRPAfterRefactoring contains all of the refactored code, which shows the refactored class "Names" that meets the SRP

# Section 3, Lesson 95 - Global Using Directives
- Greyed-out using statements like System.Linq, System.Collections.Generic etc can be removed safely from auto-generated files since they are also generated in a .g.cs file in the project's obj folder and used globally from there anyway; so it is redundant to have them in an auto-generated file in you project
- In general, it is good practice to remove greyed-out (unused) statements at the top of your file/s
- Ideally, a separate file is created foir global using statements
- The "global using" directive is available from C# V10 onwards (not avaiable below that version)

# Section 4, Lesson 104 - A need for polymorphism
- The provision of a single interface to entities of different types is called polymorphism
- In the case of our simple pizza example, we have the generic conept of an ingredient, and this concept can be made more concrete by multiple types - cheddar, mozzarella and tomato sauce
	- All of these types can be used wherever the generic concept is needed (in the ingredients list)

# Section 4, Lesson 105 - Inheritance
- Inheritance is something that enables us to create new classes that reuse, extend and modify the behavior defined in other classes
- The class from which we are inheriting is called the base class, and the class which is doing the job of inheriting is called the derived class

# Section 4, Lesson 106 - Inherited members from the base class - Protected modifier
- We have three types of access modifiers - public, private and protected
	- Public: Methods/properties can be fully accessed both, in the derived class as well as an instance of that class
	- Private: Methods/properties can only be accessed in the base class and nowhere else
	- Protected: Methods/properties can be accessed directly inside the derived class, BUT NOT on the instance of that class. Of course, they can also be accessed in the base class also.
