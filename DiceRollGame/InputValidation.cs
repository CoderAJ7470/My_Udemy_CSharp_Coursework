public class InputValidation
{
    public int ValidateUserInput(string input)
    {
        bool isValid = int.TryParse(input, out int userGuess);

        while (!isValid)
        {
            Console.WriteLine("Incorrect input specified. Please try again:");
            input = Console.ReadLine() ?? "";

            isValid = int.TryParse(input, out userGuess);
        }

        return userGuess;
    }
}