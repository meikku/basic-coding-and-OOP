namespace Exercise
{
  public class Teacher : Person
  {
    public int salary { get; }

    public Teacher (string name, string address, int salary) : base(name, address)
    {
      this.salary = salary;
    }

    public override string ToString()
    {
      return base.ToString() + " salary " + salary + " per month";
    }
  }
}