// Section 3, Lesson 86 - Object initializers

// Normally, using a constructor, we can initialize the Person object using its constructor, like so:
var person = new Person("John", 2000);

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}