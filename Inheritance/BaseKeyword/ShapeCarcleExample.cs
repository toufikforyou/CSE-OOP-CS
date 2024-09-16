namespace ShapeCercle
{
    // Base class
    public class Shape
    {
        public virtual string Color { get; set; } = "Red";
    }

    // Derived class
    public class Circle : Shape
    {
        public override string Color
        {
            get => base.Color; // Accesses the base class property
            set => base.Color = value; // Sets the base class property
        }

        public void DisplayColor()
        {
            Console.WriteLine($"Circle color: {Color}");
        }
    }
}