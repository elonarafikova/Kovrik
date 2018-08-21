using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kovrik
{
    
    class Constants
  {
    public const int RANK_COUNT = 13; 
    public const int SUIT_COUNT = 4; 
    public const int PACK_COUNT = 1; 
  }

  class Card // карта
  {
    private int suit;     // масть
    private int rank;     // ранг
    
    public int Suit { get { return suit; } }
    public int Rank { get { return rank; } }

    public int ImageIndex { get { return suit * Constants.RANK_COUNT + rank; } }

    // Конструктор карты
    public Card(int suit, int rank)
    {
      this.suit = suit;
      this.rank = rank;
    }
    // Конструктор карты
    public Card(int index)
    {
      rank = index % Constants.RANK_COUNT;
      suit = index / Constants.RANK_COUNT;
    }

  }
  class Place //место
  {
     private Card card;
     public Card Card { get { return card; } set { card = value; } }
     private int x, y; // координаты места

     public int X { get { return x; } set { x = value; } }
     public int Y { get { return y; } set { y = value; } }
     public int num;
     public int suit;
     public bool onplace = false;
     
  }


  class Deck // колода
  {
    public List<Card> cards;
      
    
    public Card GetCard()
    {
        Card card = null;
        if (cards.Count > 0)
        {
            card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
        }
        return card;
    }

    // Конструктор колоды
    public Deck()
    {
      cards = new List<Card>();

      for (int j = 0; j < Constants.SUIT_COUNT; j++)
      {
          for (int k = 0; k < Constants.RANK_COUNT; k++)
          {
              AddCard(new Card(j, k));
          }
      }
    }
    public void clear()
    {
        cards.Clear();
    }

    

    // Добавление карты в колоду
    public void AddCard(Card card)
    {
      cards.Add(card);
    }

    public void Shuffle() //перемешать карты в колоде
    {
        int n;
        Card card;
        Random random = new Random();
        for (int i = 0; i < cards.Count; i++)
        {
            int ind1 = i;
            card = cards[i];
            n = random.Next(cards.Count);
            cards[i] = cards[n];
            cards[n] = card;
        }
    }

  }

}
   
