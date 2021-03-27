using System;
using System.Collections.Generic;

namespace _5_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            List<List<int>> parts = new List<List<int>>();


            for (int i = 0; i < matrixSize; i++)
            {
                List<int> row = new List<int>(matrixSize);

                for (int k = 0; k < matrixSize; k++)
                {
                    row.Add((i+1) + k * matrixSize);
                }

                parts.Add(row);
            }

            for (int i = 0; i < matrixSize; i++)
            {
                for (int k = 0; k < matrixSize; k++)
                {

                    Console.Write(parts[i][k] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
