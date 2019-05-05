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
    public partial class PlayerNameForm : Form
    {
        DAL dal = new DAL();
        private int numberOfPlayers;
        private int playersCreated = 1;
        private int playerChips;

        public PlayerNameForm()
        {
            InitializeComponent();
            Load += new EventHandler(PlayerNameForm_Load);
        }

        //Method with initial settings when window is loaded
        private void PlayerNameForm_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
            errorLabel2.Hide();
            playerLabel.Text = "Voer naam in van speler " + playersCreated;
            dal.cardDeck.CreateDeck();
        }

        //Method to set numberOfPlayers equal to input in NumberOfPlayerForm
        public void SetNumberOfPlayers(int _value)
        {
            numberOfPlayers = _value;
        }

        //Method to activate button for adding players
        private void AddPlayerButton_Click(object sender, EventArgs e)
        {

            if(playerNameTextBox.Text.Length < 3)
            {
                errorLabel2.Show();
            }
            else
            {
                try
                {
                    playerChips = int.Parse(chipTextBox.Text);
                    AddPlayer();
                }
                catch
                {
                    errorLabel.Show();
                }
            }
        }
        
        //Method to add player to game
        public void AddPlayer()
        {
            //Add Player to game
            dal.game.AddPlayers(playerNameTextBox.Text, playerChips, dal);

            //Reset interface if playersCreated < numberOfPlayers
            if (playersCreated < numberOfPlayers)
            {
                playerNameTextBox.Clear();
                chipTextBox.Clear();
                errorLabel.Hide();
                errorLabel2.Hide();
                playersCreated += 1;
                playerLabel.Text = "Voer naam in van speler " + playersCreated;
            }
            else
            {
                //Continu program to next window
                PlaceBetForm placeBetForm = new PlaceBetForm(dal);
                this.Hide();
                placeBetForm.Show();
            }
        }
    }
}
