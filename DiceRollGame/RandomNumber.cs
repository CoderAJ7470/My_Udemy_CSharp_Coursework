using System;

public class RandomNumber
{
    // Generate a random number from 1 to 6 (inclusive of both)
    public int GenerateRandomNumber()
    {
        var random = new Random();
        var randomNumber = random.Next(1, 7);

        return randomNumber;
    }
}
