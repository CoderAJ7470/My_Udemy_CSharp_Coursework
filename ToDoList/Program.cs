// Section 4 - Lesson 109 - Inheritance Hierarchy

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.Describe());

var cheddar = new Cheddar();

// Can call this method that exists in the Ingredient class on an instance of the Cheddar class b/c Cheddar extends Ingreditent i.e. Cheddar is a derived from Ingredient. Note that only public methods can be called in the derived class, not private methods
Console.WriteLine("\n" + cheddar.PublicMethod());
cheddar.CallingMethodsFromTheBaseClass();

var ingredient = new Ingredient();
ingredient.PublicIntTypeField = 10;

cheddar.PublicIntTypeField = 20;

Console.WriteLine($"\nValue of PublicIntTypeField in Ingredient: {ingredient.PublicIntTypeField}; value of PublicIntTypeField in Cheddar: {cheddar.PublicIntTypeField}");

// Exposing the public "Name" property from the Cheddar class:
Console.WriteLine($"\nExposing the Cheddar class Name property value gives us: {cheddar.Name}");

// We can do this and it is perfectly valid in C#. This is b/c Cheddar is an Ingredient and vice-versa:
Ingredient ingredient2 = new Cheddar();
Console.WriteLine($"\nValue returned after assigning ingredient2 a new Cheddar object, AND marking a. Ingredient Name \"virtual\" and b. marking derived class Name properties \"override\": {ingredient2}");

// Creating a new List of Ingredients
var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new TomatoSauce(),
    new Mozzarella()
};

Console.WriteLine("\nOutputting the list of ingredients (Name property values) from derived classes:");

// Iterating over the above List
foreach (var ingredientName in ingredients)
{
    Console.WriteLine(ingredientName);
}

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