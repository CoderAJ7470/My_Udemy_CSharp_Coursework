// Section 4 - Lesson 109 - Inheritance Hierarchy

//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new TomatoSauce());
//pizza.AddIngredient(new Mozzarella());

//Console.WriteLine(pizza.Describe());

using MainCoursework.Animals;

var cheddar = new Cheddar();

// Each will print the type's full name
Console.WriteLine(new TomatoSauce()); // prints "TomatoSauce"
Console.WriteLine(new HousePet()); // prints MainCoursework.Animals.Housepet
Console.WriteLine(new List<int>()); // prints System.Collections.Generic.List`1[System.Int32]

// Each will print the passed-in string, or string conversion if required via the ToString method
Console.WriteLine($"\n{123}"); // prints "123"
Console.WriteLine(new DateTime(2026, 7, 13)); // prints 7/13/2026 12:00:00 AM
Console.WriteLine("Hello"); // prints "Hello"

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

// Base class - any class extending this class can use variables and/or methods in this class
public class Ingredient
{
    public virtual string Name { get; } = "Some ingredient";

    // can be accessed in any derived class of this class, but the derived class CAN change the value set here i.e. the derived class does not have to use the value declared here, it can set its own value to this same field
    public int PublicIntTypeField;

    // Can be used on an instance of any class derived from this class OR inside the derived class itself
    public string PublicMethod() => "This string is being returned from a public method in the Ingredient class";

    // Can be used ONLY in this class
    private string PrivateMethod() => "\nThis string is being returned from a private method in the Ingredient class";

    // Can be used ONLY INSIDE the DERIVED class, but not on an instance of it
    protected string ProtectedMethod() => "This string is being returned from a protected method in the Ingredient class";
}

// To illustrate inheritance hierarchy
public class Cheese: Ingredient
{

}

public class Cheddar : Cheese
{
    // The "override" keyword here is overriding the base class (Ingredient) property "Name"
    public override string Name => "Cheddar Cheese";
    public int AgedForMonths { get; }

    public void CallingMethodsFromTheBaseClass()
    {
        Console.WriteLine("\nCalling the Ingredient class public method directly inside the " +
            $"Cheddar class: {PublicMethod()}");
        Console.WriteLine("\nCalling the Ingredient class protected method directly inside the " +
            $"Cheddar class: {ProtectedMethod()}");
    }
}

// This class is just demonstrate the concept of linear inheritance
public class ItalianFoodItem
{

}

public class Mozzarella : Cheese
{
    public string Name => "Mozzarella";
    public bool IsLight { get; } // is the mozzarella a light mozzarella
}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato Sauce";
    public int TomatoesIn100Grams { get; } // How many tomatoes are in 100 grams of sauce?
}