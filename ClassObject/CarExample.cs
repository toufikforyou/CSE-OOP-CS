// Define a class named 'Car'
public class Car
{
    // Fields (attributes)
    private string make;
    private string model;
    private int year;
    private double price;

    // Constructor
    public Car(string make, string model, int year, double price)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.price = price;
    }

    // Properties (getters and setters)
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Method to display car details
    public void DisplayDetails()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Price: ${Price}");
    }
}