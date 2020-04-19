namespace Exercise
{
  using System;
  public class Dog : Animal, INoiseCapable
  {
    private string name;
    public Dog() : this("Dog")
    {
    }

    public Dog(string name) : base(name)
    {
      this.name = name;
    }

    public void Bark()
    {
      Console.WriteLine(this.name + " barks");
    }
    public void MakeNoise()
    {
      Bark();
    }

  }
}