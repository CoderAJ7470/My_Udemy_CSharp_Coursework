// Sec 3, lesson 68 - Introduction to OOP

// Some fun with the DateTime object to get information about international pizza day
//var internationalPizzaDay2026 = new DateTime(2026, 2, 9);
//var intlPizzaDay26Year = internationalPizzaDay2026.Year;
//var intlPizzaDay26Month = internationalPizzaDay2026.Month;
//var intlPizzaDay26Day = internationalPizzaDay2026.Day;
//var pizzaDayOfTheWeek26 = internationalPizzaDay2026.DayOfWeek;

//Console.WriteLine($"International pizza day in 2026 was on {intlPizzaDay26Month}/{intlPizzaDay26Day}/{intlPizzaDay26Year}\n");
//Console.WriteLine($"This year, it fell on a {pizzaDayOfTheWeek26}");

//var internationalPizzaDay2027 = internationalPizzaDay2026.AddYears(1);

//var intlPizzaDay27Year = internationalPizzaDay2027.Year;
//var intlPizzaDay27Month = internationalPizzaDay2027.Month;
//var intlPizzaDay27Day = internationalPizzaDay2027.Day;
//var pizzaDayOfTheWeek27 = internationalPizzaDay2027.DayOfWeek;

//Console.WriteLine($"\nInternational pizza day in 2027 will be on {intlPizzaDay26Month}/{intlPizzaDay26Day}/{intlPizzaDay26Year}\n");
//Console.WriteLine($"It will fall on a {pizzaDayOfTheWeek27}");

// Creating a custom class

//Console.ReadKey();

var rectangleOne = new Rectangle(); // using the default built-in constructor since we have not written our own

Console.WriteLine($"The width is {rectangleOne.width}");
Console.WriteLine($"The height is {rectangleOne.height}");

class Rectangle
{
    public int width;
    public int height;
}


