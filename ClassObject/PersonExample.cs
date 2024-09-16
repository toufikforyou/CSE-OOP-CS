// Define a class named 'Person'
public class Person
{
    // Fields (attributes)
    private string firstName;
    private string lastName;
    private int age;

    // Constructor
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    // Properties (getters and setters)
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0) // Ensure age is non-negative
            {
                age = value;
            }
        }
    }

    // Method to display person's full name
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    // Method to display person's details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {GetFullName()}");
        Console.WriteLine($"Age: {Age}");
    }
}