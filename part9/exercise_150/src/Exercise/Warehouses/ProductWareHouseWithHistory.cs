namespace Exercise 
{
using System.Collections.Generic;

  public class ProductWarehouseWithHistory : ProductWarehouse

  {
    private int initialBalance { get; set; }
    private ChangeHistory warehouseHistory { get; set; }
    

    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
    {
      this.productName = productName;
      this.capacity = capacity;
      this.initialBalance = initialBalance;
      this.warehouseHistory = new ChangeHistory();
      
     
     AddToWarehouse(initialBalance);

    }

    public string History()
    {
      return this.warehouseHistory.ToString();
    }

    new public void AddToWarehouse(int amount)
    {
      
      base.AddToWarehouse(amount);
      this.warehouseHistory.Add(this.balance);

    
    }
    new public int TakeFromWarehouse(int amount)
    {
      base.TakeFromWarehouse(amount);
      this.warehouseHistory.Add(this.balance);
      return amount;
    }
  }
}