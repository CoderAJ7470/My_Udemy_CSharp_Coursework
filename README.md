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