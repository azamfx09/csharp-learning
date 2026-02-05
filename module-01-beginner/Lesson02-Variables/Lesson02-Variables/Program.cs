namespace Lesson02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            string name = "Azamat";
            int age = 16;
            string city = "Samarkand";
            bool isStudent = true;
            double height = 1.77;

            Console.WriteLine("Name:" +name);
            Console.WriteLine("Age:" +age);
            Console.WriteLine("City:" +city);
            Console.WriteLine("isStudent:" +isStudent);
            Console.WriteLine("Height:" +height);




            //Independet Work "Student"

            string StudentName = "Aziz";
            int StudentAge = 19;
            string StudentCity = "Tashkent";
            bool isHuman = true;
            double StudentHeight = 1.70;
            string StudentGender = "Woman";
            int StudentPhoneNumber = 941331313;


            Console.WriteLine("Studen Name:" +StudentName);
            Console.WriteLine();

            Console.WriteLine("Student Age:" +StudentAge);
            Console.WriteLine();
            
            Console.WriteLine("Student City:" +StudentCity);
            Console.WriteLine();

            Console.WriteLine("is Human:" + isHuman);
            Console.WriteLine();    

            Console.WriteLine("Student Height:" +StudentHeight);
            Console.WriteLine();

            Console.WriteLine("Student Gender" +StudentGender);
            Console.WriteLine();

            Console.WriteLine("Student Phone Number:" +StudentPhoneNumber);



            //Independet Work Family


            string FatherName = "Bekzod";
            string MotherName = "Guzal";
            string BrotherName = "Kamron";
            string SisterName = "Kumush";
            int FatherAge = 45;
            int MotherAge = 35;
            int BrotherAge = 20;
            int SisterAge = 16;
            bool SisterWorks = false;
            double SisterSalary = 0;
            bool FatherWorks = false;
            bool MotherWorks = true;
            bool BrotherWorks = true;
            double FatherSalary = 1000;
            double MotherSalary = 2000;
            double BrotherSalary = 2500;



            Console.WriteLine("Father Name:" +FatherName);
            Console.WriteLine("Father Age:" +FatherAge);
            Console.WriteLine("Father Works: " +FatherWorks);
            Console.WriteLine("Father Salary: " +FatherSalary);
            Console.WriteLine();

            Console.WriteLine("Mother Name:" + MotherName);
            Console.WriteLine("Mother Age:" + MotherAge);
            Console.WriteLine("Mother Works: " + MotherWorks);
            Console.WriteLine("Mother Salary: " + MotherSalary);
            Console.WriteLine();

            Console.WriteLine("Brother Name:" + BrotherName);
            Console.WriteLine("Brother Age:" + BrotherAge);
            Console.WriteLine("Brother Works: " + BrotherWorks);
            Console.WriteLine("Brother Salary: " + BrotherSalary);
            Console.WriteLine();

            Console.WriteLine("Sister Name:" + SisterName);
            Console.WriteLine("Sister Age:" + SisterAge);
            Console.WriteLine("Sister Works: " + SisterWorks);
            Console.WriteLine("Sister Salary: " + SisterSalary);


            

            //static void PrintPerson(string role, string name, int age, bool works, double salary)
            //{
            //    Console.WriteLine($"{role} Name: {name}");
            //    Console.WriteLine($"{role} Age: {age}");
            //    Console.WriteLine($"{role} Works: {works}");
            //    Console.WriteLine($"{role} Salary: {salary}");
            //    Console.WriteLine();
            //}

            //PrintPerson("Father", FatherName, FatherAge, FatherWorks, FatherSalary);
            //PrintPerson("Mother", MotherName, MotherAge, MotherWorks, MotherSalary);
            //PrintPerson("Brother", BrotherName, BrotherAge, BrotherWorks, BrotherSalary);
            //PrintPerson("Sister", SisterName, SisterAge, SisterWorks, SisterSalary);

        }
    }
}
