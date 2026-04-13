Console.WriteLine("Please enter a number: ");

string userInput = Console.ReadLine();
int number = int.Parse(userInput);

Console.WriteLine("You entered the number " + number);

// pauses program running until the user presses any keyboard key
Console.ReadKey();