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
    public partial class Bust : Form
    {
        DAL dal;
        string name;
        public Bust(DAL _dal, string _name)
        {
            InitializeComponent();
            dal = _dal;
            name = _name;
        }

        //Method to activate the OK-button
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Method to show the playername in the label
        private void Bust_Load(object sender, EventArgs e)
        {
            playerNameLabel.Text = "Helaas " + name + " !";
        }
    }
}
