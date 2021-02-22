using System;

namespace _1_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int kath1 = int.Parse(Console.ReadLine());
            int kath2 = int.Parse(Console.ReadLine());
            int hipotenuza = int.Parse(Console.ReadLine());

            Console.WriteLine(kath1 + kath2 + hipotenuza);
            Console.WriteLine((kath1 * kath2) / 2.0);
        }
    }
}
