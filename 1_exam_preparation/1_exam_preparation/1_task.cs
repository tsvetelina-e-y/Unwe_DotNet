using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _1_exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            string directory = @"E:\unwe\.net\exercices\result.txt";
            StreamWriter sw = new StreamWriter(directory);


            List<String> availableCurrencies = new List<String> { "bgn", "eur", "usd" };
            Dictionary<string, decimal> currencies = new Dictionary<string, decimal>()
            {
                { "bgn-usd", 0.592277m},
                { "bgn-eur", 0.510204m },
                { "usd-bgn", 1.66002m },
                { "usd-eur", 0.831684m },
                { "eur-usd", 1.151978m },
                { "eur-bgn", 1.945000m }

            };

            Console.WriteLine("Hello, Tsvetelina");
            decimal money;
            string currency;

            using (sw)
            {

                while (true)
                {
                    try
                    {

                        Console.WriteLine("Write amount");
                        money = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Write currency");
                        currency = Console.ReadLine();

                        while (!availableCurrencies.Contains(currency.ToLower()))
                        {
                            Console.WriteLine("Not supported Currency");
                            Console.WriteLine("New Currency");
                            currency = Console.ReadLine();
                        };


                        foreach (KeyValuePair<string, decimal> entry in currencies.Where(c => c.Key.ToLower().StartsWith(currency)))
                        {
                            string fromCurrency = entry.Key.Split('-')[0].ToUpper();
                            string toCurrency = entry.Key.Split('-')[1].ToUpper();
                            string sign = GetExt(toCurrency);

                            string result = $"{fromCurrency} - {toCurrency} = {Math.Round(entry.Value * money, 2)}{sign} - {DateTime.Now}";

                            Console.WriteLine(result);



                            sw.WriteLine(result);

                        }


                    }
                    catch (Exception e)
                    {
                        break;
                    }
                  

                }
            }

            sw.Close();

          
        }

        public static string GetExt(string currency)
        {
            switch (currency.ToLower())
            {
                case "bgn":
                    return "lv";
                case "usd":
                    return "$";
                case "eur":
                    return "eur";
                default: return "";
            }
        }
    }
}
