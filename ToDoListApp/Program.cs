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
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");
}

bool checkListIsEmpty()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("\nYou have not added any todos yet.");
        return true;
    }

    return false;
}

// Get the choice of the user
char getUserChoice()
{
    Console.WriteLine("\nEnter your choice below (specify by letter, can be uppercase or lowercase):");

    userInput = Console.ReadLine();

    bool isValid = char.TryParse(userInput, out char choice) && char.IsLetter(choice);

    while (!isValid)
    {
        Console.WriteLine("\nSorry, invalid choice specified. Please select again:");
        showUserOptions();

        userInput = Console.ReadLine();

        isValid = char.TryParse(userInput, out choice) && char.IsLetter(choice);
    }

    Console.WriteLine($"\nYour choice is \"{char.ToUpper(choice)}\"");

    return choice;
}

bool checkForDuplicates(string input)
{
    foreach (var todo in todoList)
    {
        var lowerCaseTodoFromList = todo.ToLower();

        if (lowerCaseTodoFromList.Equals(input.ToLower()))
        {
            return true;
        }
    }

    return false;
}

void showAllTodos()
{
    bool isListEmpty = checkListIsEmpty();

    if (isListEmpty) return;

    Console.WriteLine("\nTodo list:");

    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}: {todoList[i]}");
    }
}
bool checkForInvalidOrEmptyInput(bool isInputValid, bool isEmptyOrNull)
{
    if (isEmptyOrNull)
    {
        Console.WriteLine("\nYour input cannot be blank. Please try again:");
        return false;
    }
    else if (!isInputValid)
    {
        Console.WriteLine("\nYou must input a valid number. Please try again.");
        return false;
    }

    return true;
}

bool checkSelectedNumberInList(int number)
{
    if (number < 0 || number > todoList.Count) return false;

    return true;
}
void removeSelectedTodo()
{
    var userSelection = "";
    bool initialChecksPassed;
    bool listIsEmpty;
    int selectedNumber;

    listIsEmpty = checkListIsEmpty();

    if (listIsEmpty) return;

    do
    {
        Console.WriteLine("\nEnter the list item number for the todo you wish to remove\n" +
        "or enter E to return to the main menu:");
        userSelection = Console.ReadLine();

        if (userSelection == "E" || userSelection == "e") return;

        bool isEmptyOrNull = string.IsNullOrEmpty(userSelection);
        bool isValidNumber = int.TryParse(userSelection, out selectedNumber);

        initialChecksPassed = checkForInvalidOrEmptyInput(isValidNumber, isEmptyOrNull);

        if (initialChecksPassed)
        {
            bool isSelectedNumberInList = checkSelectedNumberInList(selectedNumber - 1);

            if (!isSelectedNumberInList)
            {
                Console.WriteLine("\nThe number you specified does not correspond to any list todo.\n" +
                    "Please check and try again.");
                continue;
            }

            todoList.RemoveAt(selectedNumber - 1);

            Console.WriteLine($"Removed the todo item at position {selectedNumber} in your list.");
        }
    } while (userInput != "E" || userInput != "e");
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
    switch (option)
    {
        case 'A':
        case 'a':
            addATodo();
            break;
        case 'S':
        case 's':
            showAllTodos();
            break;
        case 'R':
        case 'r':
            removeSelectedTodo();
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


