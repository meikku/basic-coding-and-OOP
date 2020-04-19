namespace Exercise
{
  using System;
  public class Cat : Animal, INoiseCapable
  { 
    private string name;

    public Cat() : this("Cat")
    {

    }

    public Cat(string name) : base(name)
    {
      this.name = name;
    }

    public void Purr()
    {
      Console.WriteLine(this.name + " purrs");
    }
    public void MakeNoise()
    {
      Purr();
    }

  }
}