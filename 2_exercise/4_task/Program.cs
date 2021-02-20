using System;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            if(num1 % 2 == 0)
            {
                Console.WriteLine("Chetno");
            } else {
                Console.WriteLine("Nechetno");
            }
        }
    }
}
