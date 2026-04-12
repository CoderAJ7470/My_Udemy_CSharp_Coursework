Console.WriteLine("My first line of C#.");
Console.WriteLine("[S]ee all Todos.");
Console.WriteLine("[A]dd a Todo.");
Console.WriteLine("[R]emove a Todo.");
Console.WriteLine("[E]xit.\n");

string userInput = Console.ReadLine();

// Section 2, Lesson 27 - boolean type
bool isUserInputABC = userInput == "ABC";

// Sec. 2, L 28
var number = 10;
var isLargerThan4AndSmallerThan9 = number > 4 && number < 9; // false
var isLargerThan4OrSmallerThan9 = number > 4 || number < 9; // true

// pauses program running until the user presses any keyboard key
Console.ReadKey(); 