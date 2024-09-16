namespace AnimalExample
{
    // Base class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}