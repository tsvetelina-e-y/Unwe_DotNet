using System;

namespace _3_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number");
            int num = int.Parse(Console.ReadLine());

            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = num * (i + 1);
            }

            Console.Write("Result: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{num}*{i + 1}={nums[i]}");

                if(i != (nums.Length - 1))
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
