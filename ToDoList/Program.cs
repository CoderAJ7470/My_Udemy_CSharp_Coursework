// Section 3, Lesson 89 - Static classes and static methods

Console.WriteLine($"1 + 2 equals {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 equals {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 equals {Calculator.Multiply(1, 2)}");

Console.ReadKey();

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}