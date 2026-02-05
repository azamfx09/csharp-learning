using System.Security.Cryptography.X509Certificates;

namespace Lesson03_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string name = "Azamat";
            int age = 16;
            bool working = true;
            double height =  1.88;



            int a = 10;
            int b = 4;
            double c = 2.5;


            Console.WriteLine(a + b);
            Console.WriteLine(a * c);
            Console.WriteLine(b + a * c);



            string productName = "Phone";
            double productPrice = 999.99;


            Console.WriteLine("Product:" +productName);
            Console.WriteLine("Price :" +productPrice);



            bool hasPassport = true;
            bool inHuman = true;

            Console.WriteLine("Has Passport: " +hasPassport);
            Console.WriteLine("Your Human: " +inHuman);


            int year = 2025;
            int years = 2026;

            Console.WriteLine("Year:" +year);
            Console.WriteLine("Year:" +years);



            string names = "Azamat";
            int agee = 16;
            bool isStudent = true;

            Console.WriteLine("Name:" +names, "Age:" +agee, "Student: " +isStudent);



            double x = 5;
            double y = 2;

            Console.WriteLine("Answer:"+ x/y);
        }
    }
}
