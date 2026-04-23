// Lists - Section 2, Lesson 58

var words = new List<string>
{
    "one",
    "two"
};

foreach (var word in words)
{
    Console.WriteLine(word);
}

var moreWords = new[] { "three", "four", "five", "six" };

// AddRange is a method that adds/appends a given array or list to the end of an existing List
words.AddRange(moreWords);

Console.WriteLine("\nAfter adding more words:\n");
foreach (var word in words)
{
    Console.WriteLine(word);
}

// Some handy properties and methods that can be used with Lists
// Count
Console.WriteLine($"The current length of \"words\" is {words.Count}");

// Can also use IndexOf method to get a given element's index in the List
Console.WriteLine($"The index of \"four\" is {words.IndexOf("four")}");

// Another method to use with Lists is Contains
Console.WriteLine($"Does \"five\" exist in the List? {words.Contains("five")}");
Console.WriteLine($"Does \"eight\" exist in the List? {words.Contains("eight")}");

// Last but not least - Clear - which removes all elements in the List
words.Clear();
Console.WriteLine($"Length of \"words\" after clearing all elements is {words.Count}");

Console.ReadKey();