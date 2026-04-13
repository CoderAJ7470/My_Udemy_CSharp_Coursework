/**
 * Create a simple calculator that takes two integers from user input.
 * The user can enter "A" or "a" for addition, and similar for subtraction and multiplication.
 * If the user enters an invalid choice for the operation or leaves that blank, the program should let the user know as such and still allow the user to terminate the program by pressing any key.
 */

int integerA = 0;
int integerB = 0;

void getUserInput()
{
    var userInputA = "";
    var userInputB = "";

    Console.WriteLine("Hello! Please enter your first number:");
    userInputA = Console.ReadLine();

    if (userInputA != "") {
        integerA = int.Parse(userInputA);
    }

    Console.WriteLine("Please enter your second number:");
    userInputB = Console.ReadLine();

    if (userInputB != ""){
        integerB = int.Parse(userInputB);
    }

    if (userInputA == null || userInputB == null) {
        Console.WriteLine("Sorry, you did not enter one or more numbers. Please try again.");
    }
}
void getUserChoice()
{
    var userChoice = "";

    Console.WriteLine("What operation would you like to perform with " + integerA + " and " + integerB + "?");
    Console.WriteLine("Please indicate by specifying with one of the first letters below:\n");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply\n");

    userChoice = Console.ReadLine();

    performOperation(userChoice.ToLower());
}
void performOperation(string userInput)
{
    if (userInput == "a")
    {
        var sum = integerA + integerB;
        showOperationSummary("addition", integerA, integerB, sum);
    }
    else if (userInput == "s")
    {
        var difference = integerA - integerB;
        showOperationSummary("subtraction", integerA, integerB, difference);
    }
    else if (userInput == "m")
    {
        var product = integerA * integerB;
        showOperationSummary("multiplication", integerA, integerB, product);
    }
    else
    {
        Console.WriteLine("Sorry, invalid option specified. Please check your option and try again.");
    }
}
void showOperationSummary(string operationType, int firstInteger, int secondInteger, int result)
{
    Console.WriteLine("You chose " + operationType);
    Console.WriteLine("The " + operationType + " of " + firstInteger + " and " + secondInteger + " is " + result);
}

getUserInput();
getUserChoice();

Console.WriteLine("\nPress any key to close this window.\n");

Console.ReadKey();