Console.WriteLine("My first line of C#.");
Console.WriteLine("[S]ee all Todos.");
Console.WriteLine("[A]dd a Todo.");
Console.WriteLine("[R]emove a Todo.");
Console.WriteLine("[E]xit.");

string userInput = Console.ReadLine();
Console.WriteLine("User Input: " + userInput);

// pauses program running until the user presses any keyboard key
Console.ReadKey(); 