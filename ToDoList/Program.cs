// String interpolation in C#
int a = 4, b = 2, c = 10; // can do this in JS also, just with let or var

Console.WriteLine($"The first number is {a}, the second is {b} and the third is {c}.");
Console.WriteLine($"The sum of all three is {a + b + c}");

Console.WriteLine("What would you like to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "s":
    case "S":
        PrintSelectedOption("See all todos");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a todo");
        break;
    case "r":
    case "R":
        PrintSelectedOption("Remove a todo");
        break;
    case "e":
    case "E":
        PrintSelectedOption("Exit the program");
        break;
    default:
        Console.WriteLine("Sorry, invalid choice.");
        break;
}

void PrintSelectedOption(string choice)
{
    Console.WriteLine($"You selected {choice}");
}

// pauses program running until the user presses any keyboard key
Console.ReadKey();