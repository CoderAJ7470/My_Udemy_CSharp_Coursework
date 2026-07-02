// Section 4 - Lesson 104

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.Describe());

var cheddar = new Cheddar();

// Can call this method that exists in the Ingredient class on an instance of the Cheddar class b/c Cheddar extends Ingreditent i.e. Cheddar is a derived from Ingredient. Note that only public methods can be called in the derived class, not private methods
Console.WriteLine("\n" + cheddar.PublicMethod());
cheddar.CallingMethodsFromTheBaseClass();

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
    // Can be used on an instance of any class derived from this class OR inside the derived class itself
    public string PublicMethod() => "This string is being returned from a public method in the Ingredient class";
    
    // Can be used ONLY in this class
    private string PrivateMethod() => "\nThis string is being returned from a private method in the Ingredient class";
    
    // Can be used ONLY INSIDE the DERIVED class, but not on an instance of it
    protected string ProtectedMethod() => "This string is being returned from a protected method in the Ingredient class";
}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar Cheese";
    public int AgedForMonths { get; }

    public void CallingMethodsFromTheBaseClass()
    {
        Console.WriteLine("\nCalling the Ingredient class public method directly inside the " +
            $"Cheddar class: {PublicMethod()}");
        Console.WriteLine("\nCalling the Ingredient class protected method directly inside the " +
            $"Cheddar class: {ProtectedMethod()}");
    }
}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Suace";
    public int TomatoesIn100Grams { get; } // How many tomatoes are in 100 grams of sauce?
}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public bool IsLight { get; } // is the mozzarella a light mozzarella
}