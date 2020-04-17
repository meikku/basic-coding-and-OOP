namespace Exercise
{
  public class Person
  {
    public string name  { get; }
    public string address { get; }
    public Person(string name, string address)
    {
      this.name = name;
      this.address =  address;
    }
    public override string ToString()
    {
      return this.name + ", " + this.address;
    }

  }
}