Console.WriteLine("My first line of C#.");
Console.WriteLine("[S]ee all Todos.");
Console.WriteLine("[A]dd a Todo.");
Console.WriteLine("[R]emove a Todo.");
Console.WriteLine("[E]xit.");

string userInput = Console.ReadLine();

// Section 2, Lesson 27 - boolean type
bool someBoolean = true; // explicitly boolean declaration and initialization
var anotherBoolean = false; // implcit boolean declaration and initialization

// Another example
bool isUserInputABC = userInput == "ABC";

// pauses program running until the user presses any keyboard key
Console.ReadKey(); 