namespace CarEngineExample
{
    class Engine
    {
        public string Type { get; set; } = string.Empty;
    }

    class Car
    {
        public string Model { get; set; }
        public Engine CarEngine { get; set; }

        // Constructor that takes an object as a parameter
        public Car(string model, Engine engine)
        {
            Model = model;
            CarEngine = engine;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}, Engine Type: {CarEngine.Type}");
        }
    }

}