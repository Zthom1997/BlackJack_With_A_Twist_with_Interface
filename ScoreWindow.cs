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
    public partial class scoreWindow : Form
    {
        DAL dal;
        public scoreWindow(DAL _dal)
        {
            InitializeComponent();
            dal = _dal;
        }

        //Method with initial settings when window is loaded
        private void scoreWindow_Load(object sender, EventArgs e)
        {
            player1NameTextBox.Hide();
            player1StateTextBox.Hide();
            player1BetTextBox.Hide();
            player1ChipsTextBox.Hide();

            player2NameTextBox.Hide();
            player2StateTextBox.Hide();
            player2BetTextBox.Hide();
            player2ChipsTextBox.Hide();

            player3NameTextBox.Hide();
            player3StateTextBox.Hide();
            player3BetTextBox.Hide();
            player3ChipsTextBox.Hide();

            player4NameTextBox.Hide();
            player4StateTextBox.Hide();
            player4BetTextBox.Hide();
            player4ChipsTextBox.Hide();

            player5NameTextBox.Hide();
            player5StateTextBox.Hide();
            player5BetTextBox.Hide();
            player5ChipsTextBox.Hide();

            DetermineNumberOfPlayers();

        }

        //Method to determine the number of players and to show the correct player textboxes 
        public void DetermineNumberOfPlayers()
        {
            int numberOfPlayers = dal.game.playerList.Count();
            if (numberOfPlayers >= 1)
            {
                player1NameTextBox.Show();
                player1StateTextBox.Show();
                player1BetTextBox.Show();
                player1ChipsTextBox.Show();
            }
            if (numberOfPlayers >= 2)
            {
                player2NameTextBox.Show();
                player2StateTextBox.Show();
                player2BetTextBox.Show();
                player2ChipsTextBox.Show();
            }
            if (numberOfPlayers >= 3)
            {
                player3NameTextBox.Show();
                player3StateTextBox.Show();
                player3BetTextBox.Show();
                player3ChipsTextBox.Show();
            }
            if (numberOfPlayers >= 4)
            {
                player4NameTextBox.Show();
                player4StateTextBox.Show();
                player4BetTextBox.Show();
                player4ChipsTextBox.Show();
            }
            if (numberOfPlayers >= 5)
            {
                player5NameTextBox.Show();
                player5StateTextBox.Show();
                player5BetTextBox.Show();
                player5ChipsTextBox.Show();
            }
            FillData();
        }

        //Method to fill textboxes for each player with the relevant data
        public void FillData()
        {
            int numberOfPlayers = dal.game.playerList.Count();
            
            dal.game.DetermineWinner(dal);
            if (numberOfPlayers >= 1)
            {
                player1NameTextBox.Text = dal.game.playerList[0].GetName();
                player1StateTextBox.Text = dal.game.GetState();
                player1BetTextBox.Text = dal.game.playerList[0].GetBet().ToString();
                player1ChipsTextBox.Text = dal.game.playerList[0].GetChips().ToString();
            }
            if (numberOfPlayers >= 2)
            {
                player2NameTextBox.Text = dal.game.playerList[1].GetName();
                player2StateTextBox.Text = dal.game.GetState();
                player2BetTextBox.Text = dal.game.playerList[1].GetBet().ToString();
                player2ChipsTextBox.Text = dal.game.playerList[1].GetChips().ToString();
            }
            if (numberOfPlayers >= 3)
            {
                player3NameTextBox.Text = dal.game.playerList[2].GetName();
                player3StateTextBox.Text = dal.game.GetState();
                player3BetTextBox.Text = dal.game.playerList[2].GetBet().ToString();
                player3ChipsTextBox.Text = dal.game.playerList[2].GetChips().ToString();
            }
            if (numberOfPlayers >= 4)
            {
                player4NameTextBox.Text = dal.game.playerList[3].GetName();
                player4StateTextBox.Text = dal.game.GetState();
                player4BetTextBox.Text = dal.game.playerList[3].GetBet().ToString();
                player4ChipsTextBox.Text = dal.game.playerList[3].GetChips().ToString();
            }
            if (numberOfPlayers >= 5)
            {
                player5NameTextBox.Text = dal.game.playerList[4].GetName();
                player5StateTextBox.Text = dal.game.GetState();
                player5BetTextBox.Text = dal.game.playerList[4].GetBet().ToString();
                player5ChipsTextBox.Text = dal.game.playerList[4].GetChips().ToString();
            }
        }

        //Method to activate OK-button
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
