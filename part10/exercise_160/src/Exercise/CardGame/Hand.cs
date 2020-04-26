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
      int valueOfHand = 0;     

      foreach(Card card in this.hand)
      {
        valueOfHand += card.value;
      }

      int valueOfCompared = 0; 

    foreach(Card compared in hand.hand)
    {
      valueOfCompared += compared.value;
    }
      
      return valueOfHand - valueOfCompared;
    }
  }
}