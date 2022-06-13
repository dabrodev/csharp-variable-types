using System;

namespace ValueTypesWeek2Ex4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types Week 2, Lesson 4");
            // Ex1
            string name;
            string surename;
            int age;
            char sex;
            long PESEL;
            long employeeNumber;

            // Ex2
            char val1 = 'A';
            char val2 = 'B';
            char val3 = 'C';
            Console.WriteLine($"Ex2: {val3}{val2}{val1}");

            //Ex3
            double a = 3.0;
            double b = 4.0;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Ex3: {c}");

            //Ex4
            int num1 = 10;
            double num2 = 12.5;
            string title = "Dotnet School";

            //Ex5
            Console.WriteLine("Your name:");
            var yourName = Console.ReadLine();
            Console.WriteLine("Your surename:");
            var yourSurename = Console.ReadLine();
            Console.WriteLine("Your phone number:");
            var phoneRead = Console.ReadLine();
            int phoneNumber = Int32.Parse(phoneRead);
            var email = Console.ReadLine();
            var heightRead = Console.ReadLine();
            int height = Int32.Parse(heightRead);
            var weightRead = Console.ReadLine();
            double weight = double.Parse(weightRead);
        }
    }

}
