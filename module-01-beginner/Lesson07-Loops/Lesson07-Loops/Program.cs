using System.IO.Pipes;
using System.Numerics;
using System.Runtime.Serialization.Formatters;

namespace Lesson07_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Salom");
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine("Salom");
            //}


            //for(int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for(int i = 1; i <= 10000; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(2 % 2);

            //var cb = Stopwatch.StartNew();

            //int counter = 0;
            //for(int i = 2147000000; i > 0; i--)
            //{
            //    if ( i%2 == 0)
            //    {
            //        counter++;
            //    }
            //}
            //cb.Stop();
            //Console.WriteLine($" time = {cb.ElapsedMilliseconds}, soni : {counter}");





            //for(int  i = 1; i <= 5; i++)
            //  {
            //      Console.WriteLine(i);
            //  }


            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Hi");
            //}
            //;




            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            //int count = 1;

            //while(count <= 3)
            //{
            //    Console.WriteLine("Hello");
            //    count++;
            //}



            //int count = 1;

            //while(count <= 2)
            //{
            //    Console.WriteLine("Hi");
            //    count++;
            //}

            //task 1

            //int number = 1;

            //while (number <= 5)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}




            //task 2


            //int count = 1;

            //while (count <= 3)
            //{
            //    Console.WriteLine("Learning C#");
            //    count++;
            //}

            //task3


            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum = sum + i;
            //}
            //    Console.WriteLine(sum);


            //int sum = 0;
            //for (int i = 1; i <= 3; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);


            //int sum = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //    }
            //}
            //Console.WriteLine(sum);



            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum = sum + i;
            //    }
            //}
            //Console.WriteLine(sum);


            //int sum = 0;
            //for(int i = 1; i < 5; i++)
            //{
            //    sum = sum + (i * i);
            //}
            //Console.WriteLine(sum);





            //int sum = 0;
            //for(int i = 1; i < 9; i++)
            //{
            //    sum = sum + (i * i);
            //}
            //Console.WriteLine(sum);





            //int son = int.Parse(Console.ReadLine());
            //for(int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(i + " * " +  son + " = " + (i * son));
            //};


            //for(int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Number: " +i);
            //};




            //for(int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " - bu juft son");
            //    }
            //}



            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i + " - bu toq sonlar");
            //    }
            //}


            //int sum = 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine("Total sum: " +sum);


            //int sum = 0;

            //for(int i = 1; i <= 50; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        sum = sum + i;

            //    }
            //}
            //Console.WriteLine("Total sum: " +sum);



            //long product = 1;

            //for(int i = 1; i <= 10; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        product = product * i;
            //        Console.WriteLine("Found a multiple of 3: " +i);
            //    }

            //}
            //Console.WriteLine("Final pruduct: " +product);




            //int password = 0;
            //Console.WriteLine("Parolni kiriting: ");

            //while (password != 1234)
            //{
            //    password = int.Parse(Console.ReadLine());

            //    if(password != 1234)
            //    {
            //        Console.WriteLine("Xato! Qayta urinib koring:");
            //    }
            //}

            //Console.WriteLine("Tabriklayman! Parol to'g'ri xush kelibsiz");



            int password = 0;
            Console.WriteLine("Parolni kiriting: ");

            while (password != 20092010)
            {
                password = int.Parse(Console.ReadLine());

                if(password != 20092010)
                {
                    Console.WriteLine("Parolni noto'g'ri kiritdingiz! Qayta urinib ko'ring: ");
                }
            }

            Console.WriteLine("Parolni to'g'ri kiritdingiz! Xush kelibsiz...");
        }
    }
}
    