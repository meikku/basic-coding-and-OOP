namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private int capacity { get; set; }
    private List<Item> items { get; set; }
    private int weightOfBoxedItems { get; set; }
    public BoxWithMaxWeight(int capacity)
    {
      this.items = new List<Item>();
      this.capacity = capacity;
      this.weightOfBoxedItems = 0;
    }

    public override void Add(Item item)
    {
      if (this.capacity >= weightOfBoxedItems + item.weight)
      {
        this.items.Add(item);
        weightOfBoxedItems = weightOfBoxedItems + item.weight;
      }
    }


    public override bool IsInBox(Item item)
    {
     
      return this.items.Contains(item);
    }
  }
}