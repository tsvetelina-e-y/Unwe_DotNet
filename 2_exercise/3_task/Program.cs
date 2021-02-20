using System;

namespace _3_task
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

            Console.WriteLine($"(x*y)*z = {(num1 * num2) * num3}");
            Console.WriteLine($"x*y + y*z = {(num1 * num2 + num2 * num3)}");
        }
    }
}
