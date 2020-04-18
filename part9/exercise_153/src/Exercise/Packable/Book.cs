namespace Exercise
{
    public class Book : IPackable
  {
    private string author;
    private string name;
    private int publicationYear;
    private int weight;

    
    public Book(string author, string name, int publicationYear)
    {
      this.author = author;
      this.name = name;
      this.publicationYear = publicationYear;
      this.weight = 1;
      

    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.author + ": " + this.name + " (" + this.publicationYear + ")";
    }
  }
}