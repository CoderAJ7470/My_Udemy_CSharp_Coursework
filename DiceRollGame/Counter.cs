public class Counter
{
    public int GuessesRemaining { get; private set; } = 3;

    public void DecrementGuessesByOne()
    {
        GuessesRemaining--;
    }
}