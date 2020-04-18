namespace Exercise
{
  using System.Collections.Generic;

  public class OneItemBox : Box
  {
     private List<Item> items;
    
    public OneItemBox()
    { 
      this.items = new List<Item>();
      
    }

    public override void Add(Item item)
    {
      if (this.items.Count == 0)
      {
        this.items.Add(item);
      }
      else return;
    }


    public override bool IsInBox(Item item)
    {
      
      return this.items.Contains(item);
    }
  }
}
