public class UserInput
{
    public string GetUserInput()
    {
        Console.Write("Enter your guess: ");

        return Console.ReadLine() ?? "";
    }
}