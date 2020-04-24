namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;

    public Hand()
    {
      this.hand = new List<Card>();
    }



    public void Add(Card card)
    {
      
      if (!this.hand.Contains(card))
      {
        this.hand.Add(card);
      }
    }

    public void Print()
    {
      foreach(Card card in this.hand)
      {
        Console.WriteLine(card);
      }
    }

    public void Sort()
    {
      this.hand.Sort();
    }


    public int CompareTo(Hand hand)
    {
      
      return 0;
    }
  }
}