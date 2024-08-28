public class Student
{
    private string name = "";
    private int age = 0;
    private double grade = 4.00;

    public Student(string name, int age, double grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public Student()
    {

    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public void Display()
    {

        Console.WriteLine($"{name} {age} {grade}");
    }
}