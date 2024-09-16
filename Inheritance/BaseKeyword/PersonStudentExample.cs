namespace PersonStudent
{
    // Base class
    public class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }
    }

    // Derived class
    public class Student : Person
    {
        public int StudentID { get; }

        public Student(string name, int studentID) : base(name)
        {
            StudentID = studentID;
        }
    }
}