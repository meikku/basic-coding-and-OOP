namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class ChangeHistory
    {
        private List<int> history { get; set; }
       
       

        public ChangeHistory()
        {
            this.history = new List<int>();
           
        }

        public void Add(int status)
        {
            this.history.Add(status);
        }

        public void Clear()
        {

            this.history.Clear();
        }

        public int MaxValue()
        {
            int maxValue = 0;
            foreach (int value in this.history)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }

            }
            if (this.history.Count == 0)
            {
                return 0;
            }
            return maxValue;
        }

        public int MinValue()
        {
            int minValue = 0;
            if (this.history.Count == 0)
            {
                return minValue;
            }
            else if (this.history.Count >= 1)
            {
                 minValue = this.history[0];
           
            foreach (int value in history)
            {
                if (value < minValue)
                {
                    minValue = value;
                }

            }
            }
            return minValue;
        }

        public override string ToString()
        {
            
            int lastStatus = this.history.Count - 1;
            return "Current: " + this.history[lastStatus] + " Min: " + MinValue() + " Max: " + MaxValue();
        }
    }
}
