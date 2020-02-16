using System;
namespace exercise_113
{
    public class Book
    {
       public string title;
       public int pages;
       public int publicationYear;

       public Book (string title, int pages, int publicationYear)
       {
           this.title = title;
           this.pages = pages;
           this.publicationYear = publicationYear;
       }
        public override string ToString() 
        {
            return this.title + ", " + this.pages + " pages, " + this.publicationYear;
        }



    }
}