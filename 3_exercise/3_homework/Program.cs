using System;

namespace _3_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int progressionLength = 1;
            int a1 = arr[0];
            int d = arr[1] - arr[0];


            int currentElD = d;
            int currentMemberNum = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                int nextNum = a1 + currentMemberNum * d;

                for (int k = 0; k < arr.Length; k++)
                {
                    // if
                }

            }

        }
    }
}
