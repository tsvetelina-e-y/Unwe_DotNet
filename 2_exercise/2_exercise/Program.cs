using System;

namespace _2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1");
            //int num1 = int.Parse(Console.ReadLine());

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sumata na " + num1 + " i " + num2 + " e " + (num1 + num2));
            Console.WriteLine("Sumate na {0} i {1} e {2}", num1, num2, num1 + num2);
            Console.WriteLine($"Sumata na {num1} i {num2} e {num1 + num2}");

        }
    }
}
