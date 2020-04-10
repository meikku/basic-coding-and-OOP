using System;
using System.Collections.Generic;


namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
            Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
            books.Add(senseAndSensibility.name, senseAndSensibility);
            books.Add(prideAndPrejudice.name, prideAndPrejudice);

            PrintValues(books);
            Console.WriteLine("-- -- -- --");
            PrintValueIfNameContains(books, "prejud");
        }


        public static void PrintValues(Dictionary<string, Book> dictionary)
        {
            foreach (KeyValuePair<string, Book> book in dictionary)
            {
                Console.WriteLine(book.Value);
            }
        }
        public static void PrintValueIfNameContains(Dictionary<string, Book> dictionary, string text)
        {
            foreach (KeyValuePair<string, Book> book in dictionary)
            {
                string name = book.Value.name.ToLower();
                if (name.Contains(text.ToLower()))
                    
                    {
                        Console.WriteLine(book.Value);
                    }

            }
        }
    }
}

