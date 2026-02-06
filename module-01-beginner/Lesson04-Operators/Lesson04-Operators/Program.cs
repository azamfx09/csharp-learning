namespace Lesson04_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //int a = 10;
            //int b = 3;


            //Console.WriteLine("a =" +a);
            //Console.WriteLine("b =" +b);
            //Console.WriteLine();

            //Console.WriteLine("a + b = " + (a + b));
            //Console.WriteLine("a - b = " + (a - b));
            //Console.WriteLine("a * b = " +(a * b));
            //Console.WriteLine("a / b = " + (a / b));
            //Console.WriteLine("a % b = " +(a % b));



            //Task No1

            //int a = 28;
            //int b = 93;
            //double c = 12;

            //Console.WriteLine("a * b + c = " +(a * b + c ));
            //Console.WriteLine("c * a / b = " +(c * a / b ));
            //Console.WriteLine("b / c * a = " +(double) b / c * a );


            //Console.WriteLine();
            //Console.WriteLine("Comparison operators:");

            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a <= b);




            //Task No2


            //int age = 18;

            //if (age >= 19){
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}


            //int number = 7;

            //if(number > 10)
            //{
            //    Console.WriteLine("Big");
            //}
            //else
            //{
            //    Console.WriteLine("Small");
            //}




            //int age = 16;

            //if(age >= 18)
            //{
            //    Console.WriteLine("Allowed");
            //}
            //else
            //{
            //    Console.WriteLine("Not allowed");
            //}


            //int score = 80;

            //if (score >= 60)
            //{
            //    Console.WriteLine("Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}




            //int age = 17;
            //int money = 120;

            //if (age >= 18 && money >= 100)
            //{
            //    Console.WriteLine("You can enter");
            //}
            //else
            //{
            //    Console.WriteLine("Acces denied");
            //}



            //    int score = 78;

            //    if (score >= 90)
            //    {
            //        if (score >= 70)
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("Average");
            //            }
            //            Console.WriteLine("Good");
            //        }
            //        Console.WriteLine();
            //    }

            //    else
            //    {
            //        Console.WriteLine("Fail");
            //    }

            //



            int score = 78;

            if (score >= 90)
            {
                Console.WriteLine("Excellent");
            }

            else if (score >= 70)
            {
                Console.WriteLine("Good");
            }

            else if (score >= 60)
            {
                Console.WriteLine("Average");
            }

            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
