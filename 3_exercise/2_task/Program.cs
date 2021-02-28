using System;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test data!");
            String[] inputData = Console.ReadLine().Split(",");
            int[] numInput = new int[inputData.Length];

            for (int i = 0; i < inputData.Length; i++)
            {
                numInput[i] = int.Parse(inputData[i].Split("=")[1]);
            }

            Console.WriteLine($"Result: {string.Join(",", numInput)}");

        }
    }
}
