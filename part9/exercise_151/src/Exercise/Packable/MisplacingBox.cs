namespace Exercise
{
  using System.Collections.Generic;
  public class MisplacingBox : Box
  {
    private List<Item> items;
    public MisplacingBox()
    {
      this.items = new List<Item>();
    }

    public override void Add(Item item)
    {
      this.items.Add(item);
    }


    public override bool IsInBox(Item item)
    {
      return false;
    }
  }
}