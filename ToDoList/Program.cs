Console.WriteLine("My first line of C#.");
Console.WriteLine("[S]ee all Todos.");
Console.WriteLine("[A]dd a Todo.");
Console.WriteLine("[R]emove a Todo.");
Console.WriteLine("[E]xit.");

string userInput = Console.ReadLine();
Console.WriteLine("User Input: " + userInput);
userInput = "Wisconsin Six Cheese Pizza."; // this line is here to see how the debugger works

// pauses program running until the user presses any keyboard key
Console.ReadKey(); 