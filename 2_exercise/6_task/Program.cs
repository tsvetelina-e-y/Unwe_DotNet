using System;

namespace _6_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string let1 = Console.ReadLine();
            string let2 = Console.ReadLine();
            string let3 = Console.ReadLine();

            Console.WriteLine(let1 + let2 + let3);
            Console.WriteLine($"{let1}{let2}{let3}");
        }
    }
}
