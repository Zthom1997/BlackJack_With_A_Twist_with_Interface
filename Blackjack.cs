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
    public partial class Blackjack : Form
    {
        DAL dal;
        private string name;

        public Blackjack(DAL _dal, string _name)
        {
            InitializeComponent();
            dal = _dal;
            name = _name;
        }

        //Method to show the player name in the label
        private void Blackjack_Load(object sender, EventArgs e)
        {
            playerNameLabel.Text = name;
        }

        //Method to activate the OK button
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
