using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLODA
{
    internal class Deck2
    {
        public string[] cards = new string[36];
        int counter = 0;
        public void MakeDeck2()
        {
            string[] suits = new string[4] { "hearts", "diamonds", "clubs", "spades" };
 
            foreach (string suit in suits)
            {
                for (int i = 6; i < 14; i++)
                {
                    string numName = i.ToString();
                    cards[counter] = Card.FullCardName(suit, numName);
                    counter++;
                }
            }

        }

        public int DrawCard2()
        {
            Random rnd = new Random();
            int chosen = rnd.Next(0, 35);
            return chosen;
        }

    }
}

