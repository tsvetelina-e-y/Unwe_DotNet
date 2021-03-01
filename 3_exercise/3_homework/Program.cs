using System;
using System.Collections.Generic;
using System.Text;

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

            List<int> resultSequence = new List<int>();
            List<int> currentSequence = new List<int>();

            int currentDif;
            int nextNum;
            bool found = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {      
                for (int k = 1; k < arr.Length; k++)
                {
                    currentDif = arr[k] - arr[i];
                    currentSequence.Add(arr[i]);
                    currentSequence.Add(arr[k]);

                    nextNum = arr[k] + currentDif;

                    while(found)
                    {
                        found = false;

                        for (int j = k + 1; j < arr.Length; j++)
                        {
                            if(arr[j] == nextNum)
                            {
                                currentSequence.Add(arr[j]);
                                nextNum = arr[j] + currentDif;
                                found = true;
                                continue;
                            }
                        }
                    }

                    if(currentSequence.Count > resultSequence.Count)
                    {
                        resultSequence = new List<int>(currentSequence);
                    };

                    currentSequence.Clear();

                }

            }

            StringBuilder result = new StringBuilder();
            result.Append("Result: {");

            for (int i = 0; i < resultSequence.Count; i++)
            {
                result.Append(resultSequence[i]);
                if(i != (resultSequence.Count - 1))
                {
                    result.Append(",");
                }
            }

            result.Append("}");

            Console.WriteLine(result.ToString());
        }
    }
}
