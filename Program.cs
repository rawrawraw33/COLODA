namespace COLODA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {

                Console.WriteLine("Press: \n 1) for 52 cards \n 2) for 36 cards \n 3) for exat");

                var str = Console.ReadLine();

                switch (str)
                {
                    case "1":                  
                        Deck1 myDeck = new Deck1();
                        Card myCard = new Card();
                        myDeck.MakeDeck();
                        int winner1 = myDeck.DrawCard();
                        string winner2 = myDeck.cards[winner1];
                        Console.WriteLine("Your card is {0}!", winner2);
                        break;
                    case "2":
                        Deck2 myDeck2 = new Deck2();
                        Card myCard2 = new Card();
                        myDeck2.MakeDeck2();
                        int winner3 = myDeck2.DrawCard2();
                        string winner4 = myDeck2.cards[winner3];
                        Console.WriteLine("Your card is {0}!", winner4);
                        
                        break;
                    case"3":    
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }

            }
            
        }
    }
}