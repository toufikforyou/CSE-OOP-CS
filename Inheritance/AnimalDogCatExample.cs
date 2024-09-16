namespace AnimalDogCatExample
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // Derived class 1
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    // Derived class 2
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }

}