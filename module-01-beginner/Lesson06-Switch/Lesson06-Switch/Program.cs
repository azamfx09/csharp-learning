namespace Lesson06_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 2;

            switch (choice)
            {

                case 1:
                    Console.WriteLine("Start");
                    break;


                case 2:
                    Console.WriteLine("Options");
                    break;

                case 3:
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
