using System;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int firstDigit = input / 1000;
            int secondDigit = input % 1000 / 100;
            int thirdDigit = input % 100 / 10;
            int fourthDigit = input % 10;

            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine($"{fourthDigit}{thirdDigit}{secondDigit}{firstDigit}");
            Console.WriteLine($"{fourthDigit}{firstDigit}{secondDigit}{thirdDigit}");
            Console.WriteLine($"{firstDigit}{thirdDigit}{secondDigit}{fourthDigit}");


        }
    }
}
