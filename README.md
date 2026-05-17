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