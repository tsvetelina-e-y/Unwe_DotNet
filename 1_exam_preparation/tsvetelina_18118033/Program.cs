using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tsvetelina_18118033
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Hello Tsvetelina!");

            Dictionary<char, string> letters = new Dictionary<char, string>()
            {
                { 'а', "a" },
                { 'б', "b" },
                { 'в', "v" },
                { 'г', "g" },
                { 'д', "d" },
                { 'е', "e"},
                { 'ж', "j"},
                { 'з', "z"},
                { 'и', "i"},
                { 'й', "i"},
                { 'к', "k"},
                { 'л', "l"},
                { 'м', "m"},
                { 'н', "n"},
                { 'о', "o"},
                { 'п', "p"},
                { 'р', "r"},
                { 'с', "s"},
                { 'т', "t"},
                { 'у', "u"},
                { 'ф', "f"},
                { 'х', "h"},
                { 'ц', "c"},
                { 'ч', "ch"},
                { 'ш', "sh"},
                { 'щ', "sht"},
                { 'ъ', "y"},
                { 'ь', "y"},
                { 'ю', "iu"},
                { 'я', "q"},
            };

            Console.WriteLine("How many times");
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("word in bg");
                string word = Console.ReadLine();

                var result = string.Concat(word.Select(c => letters[c]));


                Console.WriteLine($"result {result}");
            }



        }
    }
}
