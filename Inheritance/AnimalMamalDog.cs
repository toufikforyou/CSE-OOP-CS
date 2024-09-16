namespace AnimalMammalDog
{
    // Base class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Intermediate class (derived from Animal)
    public class Mammal : Animal
    {
        public void Breathe()
        {
            Console.WriteLine("Breathing...");
        }
    }

    // Derived class (derived from Mammal)
    public class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}