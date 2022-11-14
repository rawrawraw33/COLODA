using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLODA
{
    public enum CardSuit
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    internal class Card
    {

        private string _name;
        private CardSuit _suit;
        private int _value;

        /// <param name="suit"></param>
        /// <param name="number"></param>

        public static string FullCardName(string suit, string number)
        {

            if (number == "1") number = "Ace";
            if (number == "11") number = "Jack";
            if (number == "12") number = "Queen";
            if (number == "13") number = "King";
            string fullname = number + " of " + suit;
            return fullname;
        }
    }
}
