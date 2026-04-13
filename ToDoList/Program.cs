//// String interpolation in C#
//int a = 4, b = 2, c = 10; // can do this in JS also, just with let or var

//Console.WriteLine($"The first number is {a}, the second is {b} and the third is {c}.");
//Console.WriteLine($"The sum of all three is {a + b + c}");

//Console.WriteLine("What would you like to do?");
//Console.WriteLine("[S]ee all todos");
//Console.WriteLine("[A]dd a todo");
//Console.WriteLine("[R]emove a todo");
//Console.WriteLine("[E]xit");

//var userChoice = Console.ReadLine();

//switch (userChoice)
//{
//    case "s":
//    case "S":
//        PrintSelectedOption("See all todos");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("Add a todo");
//        break;
//    case "r":
//    case "R":
//        PrintSelectedOption("Remove a todo");
//        break;
//    case "e":
//    case "E":
//        PrintSelectedOption("Exit the program");
//        break;
//    default:
//        Console.WriteLine("Sorry, invalid choice.");
//        break;
//}

//void PrintSelectedOption(string choice)
//{
//    Console.WriteLine($"You selected {choice}");
//}

Console.WriteLine("Please enter the student's points:");
var studentPoints = Console.ReadLine();

if (int.TryParse(studentPoints, out int points) && !string.IsNullOrWhiteSpace(studentPoints))
{
    points = int.Parse(studentPoints);

    char studentGrade = ConvertPointsToGrade(points);
    Console.WriteLine($"This student's grade is a {studentGrade}");
}
else
{
    Console.WriteLine("Sorry, you must enter a valid number. Please try again.");
}

// Switch Expressions
char ConvertPointsToGrade(int studentPoints)
{
    return studentPoints switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 70 => 'C',
        >= 60 => 'D',
        _ => 'F', // underscore = "wildcard", same as the default keyword in a regular switch
    }; // The closing brace bracket of a switch expression requires a semicolon after it
}

// pauses program running until the user presses any keyboard key
Console.ReadKey();