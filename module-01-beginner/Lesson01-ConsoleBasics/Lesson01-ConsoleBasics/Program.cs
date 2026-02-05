using System.Xml;

namespace Lesson01_ConsoleBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Azamat Rakhmonkulov");
            Console.WriteLine("Hello G13");
            Console.WriteLine("My Name Is Azamat");
            Console.WriteLine("Learning C# .net");
            Console.WriteLine("Join is my telegram channel");
            Console.WriteLine("My surname is Rakhmonkulov");
            Console.WriteLine("I am Student");
            Console.WriteLine("mening ismim Azamat ");
            Console.WriteLine("Men dasturchi bo'lmoqchiman");
            Console.WriteLine("Assalomu alekum ");
            Console.WriteLine("Green Screen");



            PrintPerson("Father", fatherName, fatherAge, fatherWorks, fatherSalary);
            PrintPerson("Mother", motherName, motherAge, motherWorks, motherSalary);
            PrintPerson("Brother", brotherName, brotherAge, brotherWorks, brotherSalary);
            PrintPerson("Sister", sisterName, sisterAge, sisterWorks, sisterSalary);

            static void PrintPerson(string role, string name, int age, bool works, double salary)
            {
                Console.WriteLine($"{role} Name: {name}");
                Console.WriteLine($"{role} Age: {age}");
                Console.WriteLine($"{role} Works: {works}");
                Console.WriteLine($"{role} Salary: {salary}");
                Console.WriteLine();
            }




        }
    }
}
