namespace Exercise
{
  using System.Collections.Generic;
  public class Box : IPackable
  {
    private int capacity;
    private int weightOfTheBox {get; set; }
    private List<IPackable> box;
    public Box(int capacity)
    {
      this.capacity = capacity;
      this.box = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
      if (item.Weight() <= this.capacity - weightOfTheBox)
      {
        this.box.Add(item);
        weightOfTheBox += item.Weight();
      }
    }

    public int Weight()
    {
      return weightOfTheBox;
    }

    public override string ToString()
    {
      int itemsInBox = 0;
      foreach (IPackable item in box)
      {
        itemsInBox++;
      }
      return itemsInBox + " items, total weight " + weightOfTheBox + " kg";
    }
  }
}