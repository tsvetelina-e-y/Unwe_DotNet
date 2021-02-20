using System;

namespace _8_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Round(4 * Math.PI * radius, 2)}");
            Console.WriteLine($"{Math.Round(3 / 4.0 * Math.PI * Math.Pow(radius, 2), 2)}");
        }
    }
}
