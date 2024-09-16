namespace CarMasineExample
{
    class Car
    {
        public string Model { get; set; }
        public bool IsRunning { get; set; }

        public Car(string model)
        {
            Model = model;
            IsRunning = false;
        }
    }

    class Mechanic
    {
        public void StartCar(Car car)
        {
            car.IsRunning = true;
            Console.WriteLine($"{car.Model} is now running.");
        }
    }

}