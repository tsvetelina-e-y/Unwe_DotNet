using System;
using System.Collections.Generic;
using System.IO;

namespace _2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tsvetelina");
            string path = @"E:\unwe\.net\exercices\books.txt";

            List<Book> booksList = new List<Book>();

            StreamReader sr = new StreamReader(path);

            using (sr)
            {
                Console.WriteLine("File Content:");

                string line = sr.ReadLine();
                Book book;

                while(!string.IsNullOrEmpty(line))
                {
                    string[] data = line.Split(",");
                    book = new Book();
                    book.Id = int.Parse(data[0]);
                    book.Title = data[1];
                    book.Author = data[2];
                    book.Year = int.Parse(data[3]);

                    booksList.Add(book);
                    line = sr.ReadLine();

                }

            }

            booksList.ForEach(book =>
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            });

            sr.Close();

            StreamWriter sw = new StreamWriter(path);


            using (sw)
            {
                Console.WriteLine("New book id");
                string bookId;

                Book newBook = new Book();


                while ((bookId = Console.ReadLine()) != string.Empty)
                {
                    int id = int.Parse(bookId);
                    Console.WriteLine("book title");
                    newBook.Id = id;
                    newBook.Title = Console.ReadLine();

                    Console.WriteLine("book author");
                    newBook.Author = Console.ReadLine();

                    Console.WriteLine("book year");
                    newBook.Year = int.Parse(Console.ReadLine());

                    sw.WriteLine($"Id: {newBook.Id}, Title: {newBook.Title}, Author: {newBook.Author}, Year: {newBook.Year}");
                    booksList.Add(newBook);
                }
            }

            sw.Close();

            Console.WriteLine("-------");
            booksList.ForEach(book =>
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            });


        }
    }

    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
