using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOfCards.Model
{
    public class Card
    {
        private string rank;
        private string suit;
        private string file;

        public Card(string _rank, string _suit, string _file)
        {
            rank = _rank;
            suit = _suit;
            file = _file;
        }

        //Method to get rank of card
        public string GetRank()
        {
            return rank;
        }

        //Method to get suit of card
        public string GetSuit()
        {
            return suit;
        }

        public string GetFile()
        {
            return file;
        }
    }
}
