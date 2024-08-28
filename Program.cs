using System;
public partial class Program
{
    public static void Main(string[] args)
    {
        Student std = new Student("Toufik", 21, 3.42);

        Student std2 = new Student();

        std2.Name = "Toufik Hasan";
        std2.Age = 20;
        std2.Grade = 3.29;

        std.Display();

        std2.Display();
    }

    /*
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine(“Addition: ” +(a + b));
            Console.WriteLine(“Subtraction: ” +(a - b));
            Console.WriteLine(“Multiplication: ” +(a * b));
            Console.WriteLine(“Division: ” +(a / b));
        }
    */
    /*
        public static void Main(string[] args)
        {
            int number = 20;

            if (number > 0)
            {
                Console.WriteLine(number +” is positive”);
            }
            else if (number < 0)
            {
                Console.WriteLine(number + " is negative");
            }
            else
            {
                Console.WriteLine(number + " is not valid");
            }
        }
    */
    /*
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Interation " + i);
            }
        }
    */
    /*
        public static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 5)
            {
                Console.WriteLine("Counter " + counter);
                counter++;
            }
        }
    */
    /*
        public static void Main(string[] args)
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not day");
                    break;
            }
        }
    */
    /*
        public static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int searchValue = 20;

            foreach (int value in numbers)
            {
                if (value == searchValue)
                {
                    Console.WriteLine(searchValue + " is found");
                    break;
                }
            }
        }
    */
    /*
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;

            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;

            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

        }
    */

    /*
        public static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Date", "Cherry", "Elderberry" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    */
}
