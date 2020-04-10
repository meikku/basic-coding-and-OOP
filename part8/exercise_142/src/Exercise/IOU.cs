using System.Collections.Generic;

namespace Exercise
{
    public class IOU
    {
        private Dictionary<string, int> debt;


        public IOU()
        {
            this.debt = new Dictionary<string, int>();
        }

        public void ChangeDebt(string toWhom, int amount)
        {
            if (this.debt.ContainsKey(toWhom))
            {
                int amountTotal = this.debt[toWhom] + amount;

                if (amountTotal < 0)
                {
                    amountTotal = 0;
                }

                this.debt[toWhom] = amountTotal;



            }
            else if (amount < 0)
            {
                this.debt[toWhom] = 0;

            }
            else
            {
                this.debt[toWhom] = amount;
            }


        }


        public int HowMuchDoIOweTo(string toWhom)
        {


            if (this.debt.ContainsKey(toWhom))
            {
                return this.debt[toWhom];
            }
            else
            {
                return 0;
            }
        }
    }
}
