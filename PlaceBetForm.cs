using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesOfCards.DataAccessLayer;

namespace GamesOfCards
{
    public partial class PlaceBetForm : Form
    {
        DAL dal;
        private int numberOfPlayers;
        private int playerIndex = 0;
        private int bet;
        private string playerName;

        public PlaceBetForm(DAL _dal)
        {
            InitializeComponent();
            Load += new EventHandler(PlaceBetForm_Load);
            dal = _dal;
        }

        //Method with initial settings when window is loaded
        private void PlaceBetForm_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
            placeBetButton.Hide();
            chipsTextBox.Enabled = false;
            totalLeftTextBox.Enabled = false;
            ShowPlayerChips();

            numberOfPlayers = dal.game.playerList.Count();
            playerName = dal.game.playerList[playerIndex].GetName();
            playerLabel.Text = "Plaats inzet: " + playerName;
        }

        //Method to show player chips
        private void ShowPlayerChips()
        {
            chipsTextBox.Text = dal.game.playerList[playerIndex].GetChips().ToString();
        }

        private void CheckBetButton_Click(object sender, EventArgs e)
        {
            try
            { 
                bet = Int32.Parse(betTextBox.Text);
                int totalLeft = dal.game.playerList[playerIndex].GetChips() - bet;
                totalLeftTextBox.Text = totalLeft.ToString();
                CheckBet();
            }
            catch
            {
                errorLabel.Show();
            }
        }

        //Method to check the player bet and give error message if bet is incorrect of not acceptable
        public void CheckBet()
        {
            int chips = dal.game.playerList[playerIndex].GetChips();
            if (chips < bet)
            {
                errorLabel.Text = "Inzet mag niet groter zijn dan het aantal chips";
                errorLabel.TextAlign = ContentAlignment.TopCenter;
                errorLabel.Show();
            }
            else if(bet == 0)
            {
                errorLabel.Text = "De minimale inzet bedraagt 1 chip";
                errorLabel.TextAlign = ContentAlignment.TopCenter;
                betTextBox.Text = 1.ToString();
                errorLabel.Show();
            }
            else
            {
                checkBetButton.Hide();
                placeBetButton.Show();
            }
        }

        //Method to activate the place bet button and check the bet that player has placed
        private void PlaceBetButton_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze inzet wilt plaatsen?", "Inzet plaatsen", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                dal.game.PlacePlayerBet(bet, playerName, dal);

                //if player index is not equal to the number of players than clear textboxes and show next player
                if (playerIndex < numberOfPlayers - 1)
                {
                    betTextBox.Clear();
                    placeBetButton.Hide();
                    checkBetButton.Show();
                    totalLeftTextBox.Clear();
                    errorLabel.Hide();
                    playerIndex++;

                    playerName = dal.game.playerList[playerIndex].GetName();
                    playerLabel.Text = "Plaats inzet: " + playerName;
                    ShowPlayerChips();
                }
                else
                {
                    GameForm gameForm = new GameForm(dal);
                    dal.game.PlaceHouseBet(dal);
                    this.Hide();
                    gameForm.Show();
                }
            }
            else
            {
                placeBetButton.Hide();
                checkBetButton.Show();
            }
        }
    }
}
