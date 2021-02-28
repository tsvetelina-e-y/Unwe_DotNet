using System;
using System.Text;

namespace _1_homework
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


            int startlongestSequenceIdx = 0;
            int longestSequenceLngth = 1;

            int currentStartIdx = 0;
            int currentSequenceLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i-1] == 1)
                {
                    currentSequenceLength++;

                    if (currentSequenceLength > longestSequenceLngth)
                    {
                        startlongestSequenceIdx = currentStartIdx;
                        longestSequenceLngth = currentSequenceLength;
                    }
                }
                else
                {
                    currentSequenceLength = 1;
                    currentStartIdx = i;
                }
            }


            StringBuilder result = new StringBuilder();

            for (int i = startlongestSequenceIdx; i < startlongestSequenceIdx + longestSequenceLngth; i++)
            {
                result.Append(arr[i]);

                if (i != startlongestSequenceIdx + longestSequenceLngth - 1)
                {
                    result.Append(", ");
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
