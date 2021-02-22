using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if("aeiouAEIOU".IndexOf(input) >= 0)
            {
                Console.WriteLine("vowel");
            } else if (Char.IsDigit(input[0]))
            {
                Console.WriteLine("digit");
            } else
            {
                Console.WriteLine("other symbol");
            }
        }
    }
}
