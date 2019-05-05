using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesOfCards.Model;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GamesOfCards.DataAccessLayer
{
    public class DAL
    {
        //Objects needed for playing
        public Deck cardDeck = new Deck();
        public Game game = new Game();
        public Price price = new Price(0);
        public House house = new House(1000);

        string connectionString = @"Data Source=LAPTOP-OPTB5SH8\MS_SQLSERVER;Initial Catalog=BlackJack_With_A_Twist;Integrated Security=True";

        public void SavePlayerData(string _name, string _state, int _bet)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                string commandString = "INSERT INTO tblPlayerInformation (Name, State, Bet) VALUES(@Name, @State, @Bet)";
                using(SqlCommand cmd = new SqlCommand(commandString, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", _name);
                    cmd.Parameters.AddWithValue("@State", _state);
                    cmd.Parameters.AddWithValue("@Bet", _bet);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Dispose();
            }


        }
    }
}
