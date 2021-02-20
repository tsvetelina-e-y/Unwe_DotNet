using System;

namespace _5_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin {0}", num + 273);
            Console.WriteLine("Fahrenheit {0}", num * 18 / 10.0 + 32);
        }
    }
}
