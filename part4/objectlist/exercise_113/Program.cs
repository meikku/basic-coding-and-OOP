using System;
using System.Collections.Generic;

namespace exercise_113
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                  break;
                }
                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int publicationYear = Convert.ToInt32(Console.ReadLine());

                books.Add(new Book(name, pages, publicationYear));
            }
            Console.WriteLine("");
            Console.Write("What information will be printed? ");
            string answer = Console.ReadLine();
            if (answer == "everything")
            {
              foreach (Book myfavourite in books)
              Console.WriteLine(myfavourite);
            }
            else if (answer == "title")
            {
              foreach (Book myfavourite in books)
              Console.WriteLine(myfavourite.title);
            }
        }
    }
}




