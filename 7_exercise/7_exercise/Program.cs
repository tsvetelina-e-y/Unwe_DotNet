using System;
using System.IO;

namespace _7_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"E:\unwe\.net\exercices\Example.txt");
            using(sw)
            {
                Console.WriteLine("Press any key to begin and esc to stop");
                Console.ReadKey(true);

                while(Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    sw.WriteLine(Console.ReadLine());
                }
            }

            sw.Close();

            StreamReader sr = new StreamReader(@"E:\unwe\.net\exercices\Example.txt");
            using(sr)
            {
                Console.WriteLine("File Content:");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
