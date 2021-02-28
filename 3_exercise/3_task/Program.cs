using System;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test data: length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("elements: ");
            string[] elements = Console.ReadLine().Split(",");

            Array.Reverse(elements);
            Console.WriteLine(String.Join( ",", elements));

        }
    }
}
