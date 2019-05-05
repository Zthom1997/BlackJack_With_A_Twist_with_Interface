using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesOfCards.Model
{
    public class Player
    {
        private string name;
        private int valueOfHand;
        private bool bust = false;
        private bool standing = false;
        private int chips;
        private int bet;
        public List<Card> hand = new List<Card>();

        public Player(string _name)
        {
            name = _name;
        }

        //Method to set name of player
        public void SetName(string _name)
        {
            name = _name;
        }

        //Method to get name of player
        public string GetName()
        {
            return name;
        }

        //Method to set value of hand
        public void SetValueOfHand(int _valueOfHand)
        {
            valueOfHand = _valueOfHand;
        }

        //Method to view value of hand
        public int GetValueOfHand()
        {
            return valueOfHand;
        }

        public void SetStanding(bool _isStanding)
        {
            standing = _isStanding;
        }

        public bool GetStanding()
        {
            return standing;
        }

        public void SetBust(bool _bust)
        {
            bust = _bust;
        }

        public int GetChips()
        {
            return chips;
        }

        public void SetChips(int _chips)
        {
            chips = _chips;
        }

        public void SetBet(int _bet)
        {
            bet = _bet;
        }

        public int GetBet()
        {
            return bet;
        }

        //Method to check if player has blackjack
        public bool HasBlackJack()
        {
            if (valueOfHand == 21 && hand.Count() == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to check player bust
        public bool Bust()
        {
            if (valueOfHand > 21)
            {
                bust = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to reset player properties
        public void ResetPlayer()
        {
            standing = false;
            bust = false;
            valueOfHand = 0;
            hand.Clear();
        }
    }
}
