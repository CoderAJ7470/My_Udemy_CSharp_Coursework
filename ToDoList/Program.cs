// Section 3, Lesson 89 - Static classes and static methods

var calculator = new Calculator();

Console.WriteLine($"1 + 2 equals {calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 equals {calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 equals {calculator.Multiply(1, 2)}");

// Note that both this object and the one above are indentical - this class is a stateles class, since it only has methods and no fields
var calculatorTwo = new Calculator();

Console.WriteLine($"34 + 678 equals {calculatorTwo.Add(34, 678)}");

Console.ReadKey();

class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}