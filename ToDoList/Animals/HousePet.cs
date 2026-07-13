namespace MainCoursework.Animals
{

    class Animal
    {
        public virtual void MakesSound() => Console.WriteLine("Makes a generic animal sound");
    }

    class HousePet : Animal
    {
        public override void MakesSound() => Console.WriteLine("Some noises made here depending on the house pet");
    }

    class Dog : Animal
    {
        public override void MakesSound() => Console.WriteLine("Bark!");
    }

    class Terrier
    {

    }
}