public class Messages
{
    public void HandleProgramExit(string userInput, bool isReturning = false)
    {
        if ((userInput == "e" || userInput == "E") && isReturning)
        {
            Console.WriteLine("Exiting game...");
            return;
        }
        
        if ((userInput == "e" || userInput == "E") && !isReturning)
        {
            Console.WriteLine("Exiting game...");
        }
    }
}
