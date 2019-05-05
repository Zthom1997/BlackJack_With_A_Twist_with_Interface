using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesOfCards.Model;

namespace GamesOfCards
{
    public partial class NumberOfPlayerForm : Form
    {
        public int numberOfPlayers;

        public NumberOfPlayerForm()
        {
            InitializeComponent();
            Load += new EventHandler(NumberOfPlayerForm_Load);
        }

        //Method with initial settings when window is loaded
        private void NumberOfPlayerForm_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        //Method to get the number of players
        public int GetNumberOfPlayers()
        {
            return numberOfPlayers;
        }

        //Button to add number of players to the game when button is clicked
        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfPlayers = Int32.Parse(numberOfPlayersTextBox.Text);
                StartGame();
            }
            catch
            {
                errorLabel.BackColor = System.Drawing.Color.Transparent;
                errorLabel.Show();
                numberOfPlayersTextBox.Clear();
            }

        }

        //Method to start game
        public void StartGame()
        {
            PlayerNameForm playerNameForm = new PlayerNameForm();
            if (numberOfPlayers <= 5)
            {
                playerNameForm.SetNumberOfPlayers(numberOfPlayers);
                this.Hide();
                playerNameForm.Show();
            }
            else
            {
                errorLabel.Text = "Er kunnen niet meer dan 5 spelers \ndeelnemen";
                errorLabel.BackColor = System.Drawing.Color.Transparent;
                errorLabel.TextAlign = ContentAlignment.MiddleCenter;
                errorLabel.Show();
            }
        }
    }
}
