// Multidimensional arrays - Section 2, Lesson 56
char[,] letters = new char[2, 3]; // declares a new array with 2 rows and three columns

// Adding data to the 2D array above
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

// Print out elements to the console
var height = letters.GetLength(0);
var width = letters.GetLength(1);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"Value at {i}, {j} is {letters[i, j]}");
        Console.WriteLine("\nPress any key to exit.");
    }

}

// Can also declare and initialize a 2D array like so:
var letters2 = new char[,]
{
    {'A', 'B', 'C'},
    {'D', 'E', 'F'}
};

Console.ReadKey();