var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
var onlyAddPositiveNumbers = true;

var sumCalculator = onlyAddPositiveNumbers ? new PositiveNumbersSumCalculator() : new NumbersSumCalculator();

int sum = sumCalculator.Calculate(numbers);

Console.WriteLine(onlyAddPositiveNumbers ? $"Sum of all positive numbers is {sum}" : $"Sum of all numbers is {sum}");
Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;

        foreach (var number in numbers)
        {
            if (WillBeCountedInSum(number))
            {
                sum += number;
            }
        }

        return sum;
    }

    protected virtual bool WillBeCountedInSum(int number)
    {
        return true;
    }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool WillBeCountedInSum(int number)
    {
        return number > 0;
    }
}