using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesOfCards.DataAccessLayer;

namespace GamesOfCards.Model
{
    public class Game
    {
        public List<Player> playerList = new List<Player>();
        private string state;

        //Method to set ammount of chips for player
        public void AddPlayers(string _playerName, int _chips, DAL dal)
        {
            playerList.Add(new Player(_playerName));
            foreach(Player player in playerList)
            {
                if(player.GetName() == _playerName)
                {
                    player.SetChips(_chips);
                }
            }
        }

        //Method to place bet for player
        public void PlacePlayerBet(int _bet, string _playerName, DAL dal)
        {
            foreach (Player player in playerList)
            {
                if(player.GetName() == _playerName)
                {
                    int chips = player.GetChips();
                    int bet = _bet;
                    player.SetChips(chips - bet);
                    player.SetBet(bet);
                    dal.price.SetPrice(bet);
                }
            } 
        }

        //Method to place bet for house
        public void PlaceHouseBet(DAL dal)
        {
            int chips = dal.house.GetPot();
            int bet = 100;
            dal.house.SetPot(chips - bet);
            dal.price.SetPrice(bet);
        }

        //Method for the player to take card
        public void PlayerHit(string _playerName, DAL dal)
        {
            foreach(Player player in playerList)
            {
                if(player.GetName() == _playerName)
                {
                    Card card = dal.cardDeck.DealCard();
                    player.hand.Add(card);
                    int valueOfCard = dal.cardDeck.DetermineValueofCard(card);
                    if(valueOfCard == 11 && player.GetValueOfHand() > 11)
                    {
                        valueOfCard = 1;
                    }
                    int playerValue = player.GetValueOfHand();
                    int totalValue = playerValue + valueOfCard;
                    player.SetValueOfHand(totalValue);
                }
            }
        }

        //Method for the house to take a card
        public void HouseHit(DAL dal)
        {
            if(dal.house.hand.Count() == 0)
            {
                Card card = dal.cardDeck.DealCard();
                dal.house.hand.Add(card);
                int valueOfCard = dal.cardDeck.DetermineValueofCard(card);
                if(valueOfCard > 11 && dal.house.GetValueOfHand() > 11)
                {
                    valueOfCard = 1;
                }

                int houseValue = dal.house.GetValueOfHand();
                int totalValue = houseValue + valueOfCard;
                dal.house.SetValueOfHand(totalValue);
            }
            else
            {
                while (dal.house.GetValueOfHand() < 16)
                {
                    Card card = dal.cardDeck.DealCard();
                    dal.house.hand.Add(card);
                    int valueOfCard = dal.cardDeck.DetermineValueofCard(card);
                    if (valueOfCard > 11 && dal.house.GetValueOfHand() > 11)
                    {
                        valueOfCard = 1;
                    }
                    int houseValue = dal.house.GetValueOfHand();
                    int totalValue = houseValue + valueOfCard;
                    dal.house.SetValueOfHand(totalValue);
                }
            }
        }

        //Method to determine game winner and pay out the price
        public string DetermineWinner(DAL _dal)
        {
            bool houseBust = _dal.house.Bust();
            foreach (Player player in playerList)
            {
                if (player.GetValueOfHand() > _dal.house.GetValueOfHand() && player.Bust() == false || houseBust == true && player.Bust() == false)
                {
                    int winnerPrice = (_dal.price.PayPrice(player, player.GetBet()));
                    player.SetChips(player.GetChips() + winnerPrice);
                    state = "Winnaar";
                }
                else if (player.GetValueOfHand() == _dal.house.GetValueOfHand())
                {
                    int bets = _dal.price.GetPrice();
                    _dal.house.SetPot(bets + _dal.house.GetPot());
                    state = "Gelijk";
                }
                else
                {
                    int bets = _dal.price.GetPrice();
                    _dal.house.SetPot(bets + _dal.house.GetPot());
                    state = "Verloren";
                }

                _dal.SavePlayerData(player.GetName(), state, player.GetBet());
            }
            return state;
        }

        public string GetState()
        {
            return state;
        }

        //Method to reset game
        public void ResetGame(DAL _dal)
        {
            _dal.cardDeck.ResetDeck();
            _dal.price.ResetPrice();
            _dal.house.ResetHouse();
            _dal.cardDeck.CreateDeck();
        }
    }
}
