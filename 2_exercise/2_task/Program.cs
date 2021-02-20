using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 3");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 4");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 5");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sredno aritmetichno {(num1 + num2 + num3 + num4 + num5) / 5.0}");
        }
    }
}
