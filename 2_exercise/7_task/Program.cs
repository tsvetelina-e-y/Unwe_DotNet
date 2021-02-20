using System;

namespace _7_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radius");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"P = {Math.Round(Math.PI * radius * 2, 2)}");
            Console.WriteLine($"S = {Math.PI * Math.Pow(radius, 2)}");
        }
    }
}
