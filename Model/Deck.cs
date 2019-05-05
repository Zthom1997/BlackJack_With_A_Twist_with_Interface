using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOfCards.Model
{
    public class Deck
    {
        public List<Card> CardDeck = new List<Card>();
        private readonly Random RandomCard = new Random();

        //Method to create carddeck
        public void CreateDeck()
        {
            //Cards with hearts
            CardDeck.Add(new Card("Harten", "2", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\DeuceHearts.png"));
            CardDeck.Add(new Card("Harten", "3", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\ThreeHearts.png"));
            CardDeck.Add(new Card("Harten", "4", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FourHearts.png"));
            CardDeck.Add(new Card("Harten", "5", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FiveHearts.png"));
            CardDeck.Add(new Card("Harten", "6", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SixHearts.png"));
            CardDeck.Add(new Card("Harten", "7", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SevenHearts.png"));
            CardDeck.Add(new Card("Harten", "8", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\EightHearts.png"));
            CardDeck.Add(new Card("Harten", "9", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\NineHearts.png"));
            CardDeck.Add(new Card("Harten", "10", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\TenHearts.png"));
            CardDeck.Add(new Card("Harten", "Boer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\JackHearts.png"));
            CardDeck.Add(new Card("Harten", "Vrouw", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\QueenHearts.png"));
            CardDeck.Add(new Card("Harten", "Heer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\KingHearts.png"));
            CardDeck.Add(new Card("Harten", "Aas", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\AceHearts.png"));

            //Cards with diamonds
            CardDeck.Add(new Card("Ruiten", "2", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\DeuceDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "3", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\ThreeDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "4", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FourDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "5", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FiveDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "6", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SixDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "7", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SevenDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "8", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\EightDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "9", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\NineDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "10", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\TenDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "Boer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\JackDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "Vrouw", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\QueenDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "Heer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\KingDiamonds.png"));
            CardDeck.Add(new Card("Ruiten", "Aas", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\AceDiamonds.png"));

            //Cards with Spades
            CardDeck.Add(new Card("Schoppen", "2", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\DeuceSpades.png"));
            CardDeck.Add(new Card("Schoppen", "3", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\ThreeSpades.png"));
            CardDeck.Add(new Card("Schoppen", "4", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FourSpades.png"));
            CardDeck.Add(new Card("Schoppen", "5", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FiveSpades.png"));
            CardDeck.Add(new Card("Schoppen", "6", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SixSpades.png"));
            CardDeck.Add(new Card("Schoppen", "7", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SevenSpades.png"));
            CardDeck.Add(new Card("Schoppen", "8", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\EightSpades.png"));
            CardDeck.Add(new Card("Schoppen", "9", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\NineSpades.png"));
            CardDeck.Add(new Card("Schoppen", "10", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\TenSpades.png"));
            CardDeck.Add(new Card("Schoppen", "Boer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\JackSpades.png"));
            CardDeck.Add(new Card("Schoppen", "Vrouw", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\QueenSpades.png"));
            CardDeck.Add(new Card("Schoppen", "Heer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\KingSpades.png"));
            CardDeck.Add(new Card("Schoppen", "Aas", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\AceSpades.png"));

            //Cards with Clubs
            CardDeck.Add(new Card("Klaveren", "2", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\DeuceClubs.png"));
            CardDeck.Add(new Card("Klaveren", "3", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\ThreeClubs.png"));
            CardDeck.Add(new Card("Klaveren", "4", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FourClubs.png"));
            CardDeck.Add(new Card("Klaveren", "5", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\FiveClubs.png"));
            CardDeck.Add(new Card("Klaveren", "6", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SixClubs.png"));
            CardDeck.Add(new Card("Klaveren", "7", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\SevenClubs.png"));
            CardDeck.Add(new Card("Klaveren", "8", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\EightClubs.png"));
            CardDeck.Add(new Card("Klaveren", "9", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\NineClubs.png"));
            CardDeck.Add(new Card("Klaveren", "10", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\TenClubs.png"));
            CardDeck.Add(new Card("Klaveren", "Boer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\JackClubs.png"));
            CardDeck.Add(new Card("Klaveren", "Vrouw", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\QueenClubs.png"));
            CardDeck.Add(new Card("Klaveren", "Heer", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\KingClubs.png"));
            CardDeck.Add(new Card("Klaveren", "Aas", @"D:\School\Vakken\A1D1\GamesOfCards\GamesOfCards\bin\Debug\Kaarten\AceClubs.png"));
        }

        //Method to deal a random card
        public Card DealCard()
        {
            int RandCard = RandomCard.Next(CardDeck.Count());
            Card card = CardDeck[RandCard];
            return card;
        }

        //Method to determine value of card
        //Rank and Suit are converted into deck so GetSuit() returns Rank and GetRank() returns Suit
        public int DetermineValueofCard(Card card)
        {
            int value = 0;
            if (card.GetSuit() == "2" || card.GetSuit() == "3" || card.GetSuit() == "4" || card.GetSuit() == "5" || card.GetSuit() == "6" ||
                    card.GetSuit() == "7" || card.GetSuit() == "8" || card.GetSuit() == "9" || card.GetSuit() == "10")
            {
                value = Int32.Parse(card.GetSuit());
            }
            else if (card.GetSuit() == "Boer" || card.GetSuit() == "Vrouw" || card.GetSuit() == "Heer")
            {
                value = 10;
            }
            else if (card.GetSuit() == "Aas")
            {
                value = 11;
            }
            else if(card.GetSuit() == "Aas")
            {
                value = 1;
            }
            CardDeck.Remove(card);
            return value;
        }


        //Method to reset Carddeck
        public void ResetDeck()
        {
            CardDeck.Clear();
        }
    }
}
