using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using GamesOfCards.DataAccessLayer;
using GamesOfCards.Model;

namespace GamesOfCards
{
    public partial class GameForm : Form
    {
        DAL dal;
        private int numberOfPlayers;
        private int playerIndex = 0;
        private int positionX;
        private int positonY;

        public GameForm(DAL _dal)
        {
            InitializeComponent();
            dal = _dal;
            Load += new EventHandler(GameForm_Load);
        }

        //Method with initial settings when the window is loaded
        private void GameForm_Load(object sender, EventArgs e)
        {
            PictureBox[] box = { Harten2, Harten3, Harten4, Harten5, Harten6, Harten7, Harten8, Harten9, Harten10, HartenBoer, HartenVrouw, HartenHeer, HartenAas,
                Schoppen2, Schoppen3, Schoppen4, Schoppen5, Schoppen6, Schoppen7, Schoppen8, Schoppen9, Schoppen10, SchoppenBoer, SchoppenVrouw, SchoppenHeer, SchoppenAas,
                Klaveren2, Klaveren3, Klaveren4, Klaveren5, Klaveren6, Klaveren7, Klaveren8, Klaveren9, Klaveren10, KlaverenBoer, KlaverenVrouw, KlaverenHeer, KlaverenAas,
                Ruiten2, Ruiten3, Ruiten4, Ruiten5, Ruiten6, Ruiten7, Ruiten8, Ruiten9, Ruiten10, RuitenBoer, RuitenVrouw, RuitenHeer, RuitenAas, pictureBox14};
            
            foreach(PictureBox pBox in box)
            {
                pBox.Hide();
            }

            priceLabel.BackColor = System.Drawing.Color.Transparent;
            turnPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            resetButton.Hide();
            buyCardButton.Hide();
            standingButton.Hide();
            scoreButton.Hide();

            player1NameLabel.Hide();
            BetPlayer1TextBox.Hide();
            scorePlayer1TextBox.Hide();

            player2LabelName.Hide();
            BetPlayer2TextBox.Hide();
            scorePlayer2TextBox.Hide();

            player3LabelName.Hide();
            BetPlayer3TextBox.Hide();
            scorePlayer3TextBox.Hide();

            player4LabelName.Hide();
            BetPlayer4TextBox.Hide();
            scorePlayer4TextBox.Hide();

            player5LabelName.Hide();
            BetPlayer5TextBox.Hide();
            scorePlayer5TextBox.Hide();

            scoreHouseTextBox.Enabled = false;
            scoreHouseTextBox.Hide();
            scoreHouseTextBox.Text = "Score: " + dal.house.GetValueOfHand();
            priceLabel.Text = "Prijzenpot: " + dal.price.GetPrice().ToString();
            DetermineNumberOfPlayers();
        }

        //Method to determine the number of active players and show the correct textboxes and labels
        public void DetermineNumberOfPlayers()
        {
            int numberOfPlayers = dal.game.playerList.Count();
            if (numberOfPlayers >= 1)
            {
                player1NameLabel.Text = dal.game.playerList[0].GetName();
                BetPlayer1TextBox.Text = dal.game.playerList[0].GetBet().ToString();
                scorePlayer1TextBox.Text = "Score: " + dal.game.playerList[0].GetValueOfHand().ToString();

                player1NameLabel.Show();
                BetPlayer1TextBox.Show();
                scorePlayer1TextBox.Show();

                BetPlayer1TextBox.Enabled = false;
                scorePlayer1TextBox.Enabled = false;
            }

            if(numberOfPlayers >= 2)
            {
                player2LabelName.Text = dal.game.playerList[1].GetName();
                BetPlayer2TextBox.Text = dal.game.playerList[1].GetBet().ToString();
                scorePlayer2TextBox.Text = "Score: " + dal.game.playerList[1].GetValueOfHand().ToString();

                player2LabelName.Show();
                BetPlayer2TextBox.Show();
                scorePlayer2TextBox.Show();

                BetPlayer2TextBox.Enabled = false;
                scorePlayer2TextBox.Enabled = false;
            }

            if(numberOfPlayers >=  3)
            {
                player3LabelName.Text = dal.game.playerList[2].GetName();
                BetPlayer3TextBox.Text = dal.game.playerList[2].GetBet().ToString();
                scorePlayer3TextBox.Text = "Score: " + dal.game.playerList[2].GetValueOfHand().ToString();

                player3LabelName.Show();
                BetPlayer3TextBox.Show();
                scorePlayer3TextBox.Show();

                BetPlayer3TextBox.Enabled = false;
                scorePlayer3TextBox.Enabled = false;
            }

            if (numberOfPlayers >= 4)
            {
                player4LabelName.Text = dal.game.playerList[3].GetName();
                BetPlayer4TextBox.Text = dal.game.playerList[3].GetBet().ToString();
                scorePlayer4TextBox.Text = "Score: " + dal.game.playerList[3].GetValueOfHand().ToString();

                player4LabelName.Show();
                BetPlayer4TextBox.Show();
                scorePlayer4TextBox.Show();

                BetPlayer4TextBox.Enabled = false;
                scorePlayer4TextBox.Enabled = false;
            }

            if(numberOfPlayers >= 5)
            {
                player5LabelName.Text = dal.game.playerList[4].GetName();
                BetPlayer5TextBox.Text = dal.game.playerList[4].GetBet().ToString();
                scorePlayer5TextBox.Text = "Score: " + dal.game.playerList[4].GetValueOfHand().ToString();

                player5LabelName.Show();
                BetPlayer5TextBox.Show();
                scorePlayer5TextBox.Show();

                BetPlayer5TextBox.Enabled = false;
                scorePlayer5TextBox.Enabled = false;
            }
        }

        //Method to deal initial cards and display the player score
        public void StartHit()
        {
            numberOfPlayers = dal.game.playerList.Count();
            for(int i = playerIndex; i < numberOfPlayers; i++)
            {
                int cardsGiven = 0;
                foreach (Player player in dal.game.playerList)
                {
                    while (cardsGiven < 2)
                    {
                        dal.game.PlayerHit(dal.game.playerList[playerIndex].GetName(), dal);
                        if (playerIndex == 0)
                        {
                            scorePlayer1TextBox.Text = "Score: " + dal.game.playerList[playerIndex].GetValueOfHand().ToString();
                            AddPlayerCard(playerIndex, cardsGiven);
                        }
                        if (playerIndex == 1)
                        {
                            scorePlayer2TextBox.Text = "Score: " + dal.game.playerList[playerIndex].GetValueOfHand().ToString();
                            AddPlayerCard(playerIndex, cardsGiven);
                        }
                        else if (playerIndex == 2)
                        {
                            scorePlayer3TextBox.Text = "Score: " + dal.game.playerList[playerIndex].GetValueOfHand().ToString();
                            AddPlayerCard(playerIndex, cardsGiven);
                        }
                        else if (playerIndex == 3)
                        {
                            scorePlayer4TextBox.Text = "Score: " + dal.game.playerList[playerIndex].GetValueOfHand().ToString();
                            AddPlayerCard(playerIndex, cardsGiven);
                        }
                        else if (playerIndex == 4)
                        {
                            scorePlayer5TextBox.Text = "Score: " + dal.game.playerList[playerIndex].GetValueOfHand().ToString();
                            AddPlayerCard(playerIndex, cardsGiven);
                        }
                        cardsGiven++;
                    }
                }
                playerIndex++;
            }

            dal.game.HouseHit(dal);
            scoreHouseTextBox.Text = "Score: " + dal.house.GetValueOfHand();
            scoreHouseTextBox.Text = "Score: " + dal.house.GetValueOfHand().ToString();
            scoreHouseTextBox.Show();
            AddHouseCard();
        }

        //Method to display cards of player and calculate the position for each new card to be placed
        public void AddPlayerCard(int _playerIndex, int _cardsGiven)
        {
            PictureBox[] box = { Harten2, Harten3, Harten4, Harten5, Harten6, Harten7, Harten8, Harten9, Harten10, HartenBoer, HartenVrouw, HartenHeer, HartenAas,
                Schoppen2, Schoppen3, Schoppen4, Schoppen5, Schoppen6, Schoppen7, Schoppen8, Schoppen9, Schoppen10, SchoppenBoer, SchoppenVrouw, SchoppenHeer, SchoppenAas,
                Klaveren2, Klaveren3, Klaveren4, Klaveren5, Klaveren6, Klaveren7, Klaveren8, Klaveren9, Klaveren10, KlaverenBoer, KlaverenVrouw, KlaverenHeer, KlaverenAas,
                Ruiten2, Ruiten3, Ruiten4, Ruiten5, Ruiten6, Ruiten7, Ruiten8, Ruiten9, Ruiten10, RuitenBoer, RuitenVrouw, RuitenHeer, RuitenAas, pictureBox14};

            //Calculate start position for each player and the next position based on number of cards
            if (playerIndex == 0)
            {
                positionX = 20;
                positonY = 269;

                foreach (Card card in dal.game.playerList[playerIndex].hand)
                {
                    positionX += 10;
                    positonY -= 30;
                }
            }
            else if(playerIndex == 1)
            {
                positionX = 201;
                positonY = 320;

                foreach(Card card in dal.game.playerList[playerIndex].hand)
                {
                    positionX += 10;
                    positonY -= 30;
                }

            }
            else if(playerIndex == 2)
            {
                positionX = 385;
                positonY = 346;
                
                foreach(Card card in dal.game.playerList[playerIndex].hand)
                {
                    positionX += 10;
                    positonY -= 30;
                }
            }
            else if(playerIndex == 3)
            {
                positionX = 607;
                positonY = 325;

                foreach(Card card in dal.game.playerList[playerIndex].hand)
                {
                    positionX -= 10;
                    positonY -= 30;
                }
            }
            else if(playerIndex == 4)
            {
                positionX = 767;
                positonY = 275;

                foreach(Card card in dal.game.playerList[playerIndex].hand)
                {
                    positionX -= 10;
                    positonY -= 30;
                }
            }

            //Select picturebox based on card and show it on the screen
            foreach(PictureBox pBox in box)
            {
                if (pBox.Name == dal.game.playerList[_playerIndex].hand[_cardsGiven].GetRank() + dal.game.playerList[_playerIndex].hand[_cardsGiven].GetSuit())
                {
                    pBox.Location = new System.Drawing.Point(positionX, positonY);
                    pBox.BringToFront();
                    pBox.Show();
                }
            }
        }

        //Method to display cards of house and calculate the position for each new card to be placed
        public void AddHouseCard()
        {
            PictureBox[] box = { Harten2, Harten3, Harten4, Harten5, Harten6, Harten7, Harten8, Harten9, Harten10, HartenBoer, HartenVrouw, HartenHeer, HartenAas,
                Schoppen2, Schoppen3, Schoppen4, Schoppen5, Schoppen6, Schoppen7, Schoppen8, Schoppen9, Schoppen10, SchoppenBoer, SchoppenVrouw, SchoppenHeer, SchoppenAas,
                Klaveren2, Klaveren3, Klaveren4, Klaveren5, Klaveren6, Klaveren7, Klaveren8, Klaveren9, Klaveren10, KlaverenBoer, KlaverenVrouw, KlaverenHeer, KlaverenAas,
                Ruiten2, Ruiten3, Ruiten4, Ruiten5, Ruiten6, Ruiten7, Ruiten8, Ruiten9, Ruiten10, RuitenBoer, RuitenVrouw, RuitenHeer, RuitenAas, pictureBox14};

            positionX = 607;
            positonY = 75;

            //Calculate start position for each player and the next position based on number of cards
            foreach (Card card in dal.house.hand)
            {
                positionX -= 25;
                positonY -= 0;

                //Select correct picturebox based on card
                foreach (PictureBox pBox in box)
                {
                    if (pBox.Name == card.GetRank() + card.GetSuit())
                    {
                        pBox.Location = new System.Drawing.Point(positionX, positonY);
                        pBox.BringToFront();
                        pBox.Show();
                    }
                }
            }
        }

        //Method to activate the startgame button
        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Hide();
            StartHit();
            foreach (Player player in dal.game.playerList)
            {
                if(player.HasBlackJack() && player.hand.Count() == 2)
                {
                    Blackjack blackJack = new Blackjack(dal, player.GetName());
                    blackJack.Show();
                }
            }
            playerIndex = 0;
            buyCardButton.Show();
            standingButton.Show();
            turnPlayerLabel.Text = "Beurt aan: " + dal.game.playerList[playerIndex].GetName();
        }

        //Method to buy card for player and calculate the score
        private void buyCardButton_Click(object sender, EventArgs e)
        {
            dal.game.PlayerHit(dal.game.playerList[playerIndex].GetName(), dal);
            int cardsInHand = dal.game.playerList[playerIndex].hand.Count();
            AddPlayerCard(playerIndex, cardsInHand - 1);
            if(playerIndex == 0)
            {
                scorePlayer1TextBox.Text = "Score is: " + dal.game.playerList[playerIndex].GetValueOfHand();
            }
            else if(playerIndex == 1)
            {
                scorePlayer2TextBox.Text = "Score is: " + dal.game.playerList[playerIndex].GetValueOfHand();
            }
            else if(playerIndex == 2)
            {
                scorePlayer3TextBox.Text = "Score is: " + dal.game.playerList[playerIndex].GetValueOfHand();
            }
            else if(playerIndex == 3)
            {
                scorePlayer4TextBox.Text = "Score is: " + dal.game.playerList[playerIndex].GetValueOfHand();
            }
            else if(playerIndex == 4)
            {
                scorePlayer5TextBox.Text = "Score is: " + dal.game.playerList[playerIndex].GetValueOfHand();
            }

            if (dal.game.playerList[playerIndex].Bust() == true)
            {
                Bust bust = new Bust(dal, dal.game.playerList[playerIndex].GetName());
                bust.Show();
                if (playerIndex < numberOfPlayers)
                {
                    playerIndex++;
                    turnPlayerLabel.Text = "Beurt aan: " + dal.game.playerList[playerIndex].GetName();
                }
                else
                {
                    dal.game.HouseHit(dal);
                    foreach (Card card in dal.house.hand)
                    {
                        AddHouseCard();
                        scoreHouseTextBox.Text = "Score: " + dal.house.GetValueOfHand().ToString();
                        buyCardButton.Hide();
                        standingButton.Hide();
                        scoreButton.Show();
                        resetButton.Show();
                    }
                }
            }
        }

        //Method for activating standing button
        private void standingButton_Click(object sender, EventArgs e)
        {
            if (playerIndex + 1 < numberOfPlayers)
            {
                playerIndex++;
                turnPlayerLabel.Text = "Beurt aan: " + dal.game.playerList[playerIndex].GetName();
            }
            else
            {
                dal.game.HouseHit(dal);
                foreach (Card card in dal.house.hand)
                {

                    AddHouseCard();
                    scoreHouseTextBox.Text = "Score: " + dal.house.GetValueOfHand().ToString();
                    buyCardButton.Hide();
                    standingButton.Hide();
                    scoreButton.Show();
                    scoreButton.BringToFront();
                    resetButton.BringToFront();
                    resetButton.Show();
                }
            }
        }

        //Method to activate the score button
        private void scoreButton_Click(object sender, EventArgs e)
        {
            scoreWindow window = new scoreWindow(dal);
            window.Show();
        }

        //Method to reset the window and open a new session
        private void resetButton_Click(object sender, EventArgs e)
        {
            PlaceBetForm placeBetForm = new PlaceBetForm(dal);
            foreach(Player player in dal.game.playerList)
            {
                player.ResetPlayer();
            }

            dal.game.ResetGame(dal);
            playerIndex = 0;
            placeBetForm.Show();
            GameForm_Load(sender, e);
            this.Hide();
        }
    }
}
