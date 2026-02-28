namespace Lesson_08___Loops_while_foreach;

internal class Program
{
    static void Main(string[] args)
    {



        int[] numbers = { 5, 12, 8, 20, 3 };

        foreach(int number in numbers)
        {
            if(number > 10)
            {
                Console.WriteLine($"Number Generater than 10:{number}");
            }
        }


    }
}
