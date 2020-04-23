namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class TextInterface
  {
    // Create the userinterface here
    private List<Book> books;
    public TextInterface()
    {
      this.books = new List<Book>();
    }

    public void Start()
    {
      while (true)
      {
      Console.WriteLine("Input the name of the book, empty stops:");
      string name = Console.ReadLine();
      if (name == "")
      {
        break;
      }
      else
      {
        Console.WriteLine("Input the age recommendation:");
        int age = Convert.ToInt32(Console.ReadLine());
        Book book = new Book(name, age);
        this.books.Add(book);
      }

      
      }
      
      this.books.ForEach(Console.WriteLine);
    }
  }
}