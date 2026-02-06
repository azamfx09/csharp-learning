namespace Lesson06_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int choice = 2;

            //switch (choice)
            //{

            //    case 1:
            //        Console.WriteLine("Start");
            //        break;


            //    case 2:
            //        Console.WriteLine("Options");
            //        break;

            //    case 3:
            //        Console.WriteLine("Exit");
            //        break;

            //    default:
            //        Console.WriteLine("Wrong choice");
            //        break;
            //}


            //string day = "Saturday";

            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("Work day");
            //        break;

            //    case "Saturday":
            //        Console.WriteLine("Weekend");
            //        break;

            //    default:
            //        Console.WriteLine("Unkdown day");
            //        break;
            //}


            //char grade = 'B';

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Average");
            //        break;

            //    default:
            //        Console.WriteLine("Fail");
            //        break;
            //}



            //int choice = 2;


            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Start game");
            //        break;

            //    case 2:
            //        Console.WriteLine("Load game");
            //        break;

            //    case 3:
            //        Console.WriteLine("Settings");
            //        break;

            //    case 4:
            //        Console.WriteLine("Exit");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            //}



            int day = 7;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Thusday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Weekend");
                    break;


                case 7:
                    Console.WriteLine("Weekend");
                    break;

                default:
                    Console.WriteLine("Wrong day");
                    break;
            }



            char grade = 'C';

            switch (grade)
            {

                case 'A':
                    Console.WriteLine("Excellent");
                    break;


                case 'B':
                    Console.WriteLine("Good");
                    break;


                case 'C':
                    Console.WriteLine("Average");
                    break;


                case 'D':
                    Console.WriteLine("Poor");
                    break;

                default:
                    Console.WriteLine("Fail");
                    break;
            }


            int a = 10;
            int b = 5;
            char operation = '+';


            switch (operation)
            {
                case '+':
                    Console.WriteLine("Plus: " +(a + b));
                    break;


                case '-':
                    Console.WriteLine(a - b);
                    break;



                case '*':
                    Console.WriteLine(a * b);
                    break;


                case '/':
                    Console.WriteLine(a / b);
                    break;


                default:
                        Console.WriteLine("Unkdown Operation");
                    break;
            }



            string phones = "Iphone";

            switch(phones)
            {
                case "Iphone":
                    Console.WriteLine("Apple");
                    break;


                case "android":
                    Console.WriteLine("Samsung");
                    break;


                case "andro":
                    Console.WriteLine("Artel");
                    break;


                case "redmi":
                    Console.WriteLine("Xiaomi");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

                


        }
    }
}
