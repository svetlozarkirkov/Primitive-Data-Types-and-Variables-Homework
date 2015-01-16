using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Enter your gender (m/f): ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter your Personal ID number: ");
            string personalIDnum = Console.ReadLine();
            Console.Write("Enter your unique employee number: ");
            uint uniqueEmployeeID = uint.Parse(Console.ReadLine());

            Console.WriteLine(new string('=',30));
            Console.WriteLine("First Name: {0}",firstName);
            Console.WriteLine("Last Name: {0}",lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: {0}",gender);
            Console.WriteLine("Personal ID number: {0}",personalIDnum);
            Console.WriteLine("Unique employee number: {0}",uniqueEmployeeID);
            Console.WriteLine(new string('=',30));
        }
    }
}
