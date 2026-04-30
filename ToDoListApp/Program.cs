var userInput = "";
char userOption;

// Array to hold the todos
List<string> todoList = new List<string>();

// Show the user all options
void showUserOptions()
{
    Console.WriteLine("\nPlease choose from the following options (choose the correct letter in the box brackets):\n");
    Console.WriteLine("[S]how all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove all todos");
    Console.WriteLine("[E]xit");
}

// Get the choice of the user
char getUserChoice()
{
    Console.WriteLine("\nEnter your choice below (specify by letter, can be uppercase or lowercase):");

    userInput = Console.ReadLine();

    bool isValid = char.TryParse(userInput, out char choice);

    while (!isValid)
    {
        Console.WriteLine("\nSorry, invalid choice specified. Please select again:");
        showUserOptions();

        userInput = Console.ReadLine();

        isValid = char.TryParse(userInput, out choice);
    }

    Console.WriteLine($"\nYour choice is \"{char.ToUpper(choice)}\"");

    return choice;
}

bool checkForDuplicates(string input)
{
    foreach(var todo in todoList)
    {
        if (todoList.Contains(input))
        {
            return true;
        }
    }

    return false;
}

void showAllTodos()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("\nYou have not added any todos yet.");
        return;
    }

    Console.WriteLine("\nTodo list:");

    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {todoList[i]}");
    }
}

void addATodo()
{
    var userInput = "";
    bool isDuplicate = false;
    bool checksPassed = false;

    do
    {
        Console.WriteLine("\nPlease enter your todo/description (must be unique:). Or enter E at any time to\n" +
            "return to the main menu:");
        userInput = Console.ReadLine();

        if (userInput == "E" || userInput == "e")
        {
            Console.WriteLine("Returning to main menu...");
            return;
        }

        if (!string.IsNullOrEmpty(userInput))
        {
            isDuplicate = checkForDuplicates(userInput);

            if (isDuplicate)
            {
                Console.WriteLine("\nThe description must be unique. Please try again.");
                checksPassed = false;
            }
            else
            {
                todoList.Add(userInput);
                Console.WriteLine($"\nSuccessfully added your todo \"{userInput}\"");

                checksPassed = true;
            }
        }
        else
        {
            Console.WriteLine("\nThe description cannot be empty. Please try again.");
            checksPassed = false;
        }
    } while (isDuplicate || !checksPassed);
}

void executeUserOption(char option)
{
    switch(option)
    {
        case 'A':
        case 'a':
            addATodo();
            break;
        case 'S':
        case 's':
            showAllTodos();
            break;
    }
}
void runProgram()
{
    while (userInput != "E" || userInput != "e")
    {
        showUserOptions();

        userOption = getUserChoice();
        executeUserOption(userOption);

        if (userInput == "E" || userInput == "e")
        {
            Console.WriteLine("Closing application... press any key to exit.");
            break;
        }
    }
}

runProgram();

Console.ReadKey();


