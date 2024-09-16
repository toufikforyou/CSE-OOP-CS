namespace PersonExample
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    class Greeting
    {
        public void SayHello(Person person)
        {
            Console.WriteLine($"Hello, {person.Name}!");
        }
    }
}