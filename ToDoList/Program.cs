// Section 3, Lesson 86 - Object initializers

// Normally, using a constructor, we can initialize the Person object using its constructor, like so:
// var person = new Person("John", 2000);

// But we can also initialize the Person object with an object initializer:
var person = new Person
{
    Name = "Sally",
    YearOfBirth = 1987
};

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    // Now we do not need the constructor as we are initializing the class with an object initializer (above)

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}