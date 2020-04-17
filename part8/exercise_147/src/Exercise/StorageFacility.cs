using System.Collections.Generic;
using System;

namespace Exercise
{
    public class StorageFacility
    {
        public Dictionary<string, List<string>> storedItems;

        public StorageFacility()
        {
            this.storedItems = new Dictionary<string, List<string>>();
        }
        public void Add(string unit, string item)
        {
            if (!this.storedItems.ContainsKey(unit))
            {
                this.storedItems.Add(unit, new List<string>());
            }

            this.storedItems[unit].Add(item);
        }

        public List<string> Contents(string storageUnit)
        {
            if (!this.storedItems.ContainsKey(storageUnit))
            {
                this.storedItems.Add(storageUnit, new List<string>());
            }
            return this.storedItems[storageUnit];

        }
        public void Remove(string storageUnit, string item)
        {
            if (this.storedItems.ContainsKey(storageUnit))
            this.storedItems[storageUnit].Remove(item);
            if (storedItems[storageUnit].Count == 0)
            {
                this.storedItems.Remove(storageUnit);
            }

        }

        public List<string> StorageUnits()
        {
            List<string> printedItems = new List<string>();
            Dictionary<string, List<string>>.KeyCollection keys = this.storedItems.Keys;
            foreach (string printedUnits in keys)
            {
              printedItems.Add(printedUnits);
            
            }
            return printedItems;
        }
    }
}