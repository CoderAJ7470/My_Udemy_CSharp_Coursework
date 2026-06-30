public class Instructions
{
    // Tell the user the instructions for the game
    public void ShowInstructions()
    {
        var counter = new Counter();
        int remainingGuesses = counter.GuessesRemaining;

        Console.WriteLine("This is a simple die roll game. I will roll a die and you have " +
            "to guess the number that was rolled. You have " + remainingGuesses + " guesses left. " +
            "Enter \"e\" or \"E\" to exit the game at any time.");
        Console.WriteLine("Rolling die ... Ok, enter your first guess!");
    }
}
