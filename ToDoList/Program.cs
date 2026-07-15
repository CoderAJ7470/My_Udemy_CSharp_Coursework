// Section 4 - Lesson 112

//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new TomatoSauce());
//pizza.AddIngredient(new Mozzarella());

//Console.WriteLine(pizza.ToString());

// ---------------------------
const int priceOfExtraToppingIngredient = 1;
var ingredient = new Ingredient(priceOfExtraToppingIngredient);

// Creating a Cheddar object like this, the constructor from the base class is called first, passing in "2" as the argument - the argument we are passing in to the Cheddar constructor
const int priceOfExtraCheddarTopping = 2;
const int monthsAged = 7;
var cheddar = new Cheddar(priceOfExtraCheddarTopping, monthsAged);

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    // We have overriden the ToString Object class method here instead of keepiung the original name "Describe", since anyone trying to access the Describe method would see the name of the class when calling the ToString method on an instance of the Pizza class (Pizza object). This would cause unnecessary confusion and one would have to dig into the Pizza class code to see there is a method named "Describe". So we override the Object class' ToString method here instead to keep things to standard.
    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

// Base class - any class extending this class can use variables and/or methods in this class
public class Ingredient
{
    public Ingredient(int extraToppingPrice)
    {
        Console.WriteLine("This is the Ingredient class constructor.");

        PriceForExtraTopping = extraToppingPrice;
    }

    public int PriceForExtraTopping { get; }

    public virtual string Name { get; } = "Some ingredient";

    // Overriding the Object class ToString method. Because we are a. overriding this method that is present in the "master base" class Object, and b. printing the 
    public override string ToString() => Name;

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
public class Cheese : Ingredient
{
    public Cheese(int extraToppingPrice) : base(extraToppingPrice)
    {
    }
}

public class Cheddar : Ingredient
{
    public Cheddar(int extraToppingPrice, int agedForMonths) : base(extraToppingPrice)
    {
        Console.WriteLine("This is the Cheddar class constructor.");

        AgedForMonths = agedForMonths;
    }

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
    public Mozzarella(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; } // is the mozzarella a light mozzarella
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name => "Tomato Sauce";
    public int TomatoesIn100Grams { get; } // How many tomatoes are in 100 grams of sauce?
}