using System;

public class RandomNumber
{
    // Generate a random number from 1 to 6 (inclusive of both)
    public int GenerateRandomNumber()
    {
        const int RANDOM_LOWER_BOUND = 1;

        // 7 since the upper bound is not inclusive and we want the actua random values in the range of 1-6 (inclusive)
        const int RANDOM_UPPER_BOUND = 7;

        var random = new Random();
        var randomNumber = random.Next(RANDOM_LOWER_BOUND, RANDOM_UPPER_BOUND);

        return randomNumber;
    }
}
