var instructions = new Instructions();
var userInput = new UserInput();
var inputValidation = new InputValidation();
var randomNumber = new RandomNumber();
var counter = new Counter();
var messages = new ProgramFunctions();

void RunProgram()
{
    int generatedNumber = randomNumber.GenerateRandomNumber();

    instructions.ShowInstructions();

    string userGuess = userInput.GetUserInput();

    messages.HandleProgramExit(userGuess, true);

    while (userGuess != "e" && userGuess != "E" && counter.GuessesRemaining > 0)
    {
        int parsedGuess = inputValidation.ValidateUserInput(userGuess);

        if (parsedGuess == generatedNumber)
        {
            Console.WriteLine("Congratulations! You guessed correctly!");
            break;
        }
        else
        {
            counter.DecrementGuessesByOne();

            if (counter.GuessesRemaining == 0)
            {
                Console.WriteLine($"You ran out of guesses. The number was {generatedNumber}.");
                break;
            }

            Console.WriteLine("Good try but your guess is incorrect!");

            Console.WriteLine($"You have {counter.GuessesRemaining} {(counter.GuessesRemaining == 1 ? "guess" : "guesses")} remaining.\n");
        }

        userGuess = userInput.GetUserInput();

        messages.HandleProgramExit(userGuess);
    }
}

RunProgram();

Console.ReadKey();