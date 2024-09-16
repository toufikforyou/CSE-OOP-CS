namespace AnimalDogExample
{
    // Base class
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak(); // Calls the base class method
            Console.WriteLine("Dog barks");
        }
    }
}