using System;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Media.Imaging;

namespace OWLSimGame
{
    /// <summary>
    /// Interaction logic for TransferPlayerActions.xaml
    /// </summary>
    public partial class TransferPlayerActions : Window
    {
        public TransferPlayerActions(string selected)
        {
            InitializeComponent();
            playerDetails(selected);
            currPlayer = selected;
        }

        private readonly string currPlayer;

        private void Logo(int team)
        {
            switch (team)
            {
                case 1:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\ATL.png", UriKind.Relative));
                    break;
                case 2:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\BST.png", UriKind.Relative));
                    break;
                case 3:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\CNG.png", UriKind.Relative));
                    break;
                case 4:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\DLS.png", UriKind.Relative));
                    break;
                case 5:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\FLR.png", UriKind.Relative));
                    break;
                case 6:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\GNZ.png", UriKind.Relative));
                    break;
                case 7:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\HNZ.png", UriKind.Relative));
                    break;
                case 8:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\HOU.png", UriKind.Relative));
                    break;
                case 9:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\LDN.png", UriKind.Relative));
                    break;
                case 10:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\LGL.png", UriKind.Relative));
                    break;
                case 11:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\LVA.png", UriKind.Relative));
                    break;
                case 12:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\NYE.png", UriKind.Relative));
                    break;
                case 13:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\PAR.png", UriKind.Relative));
                    break;
                case 14:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\PHL.png", UriKind.Relative));
                    break;
                case 15:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\SFS.png", UriKind.Relative));
                    break;
                case 16:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\SHD.png", UriKind.Relative));
                    break;
                case 17:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\SLD.png", UriKind.Relative));
                    break;
                case 18:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\TOR.png", UriKind.Relative));
                    break;
                case 19:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\VNC.png", UriKind.Relative));
                    break;
                case 20:
                    currTeam.Source = new BitmapImage(new Uri(@"teamBadges\WAS.png", UriKind.Relative));
                    break;
            }
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            errorMessages.Content = " ";
            string player;
            int budget;
            int price;
            int overall;
            int userTeam = CareerSelect.teamChoice();
            string team;
            int playerOffer = int.Parse(playerOfferInput.Text);
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.price, players.overall, teams.team, players.tag
                                     FROM players, teams
                                     WHERE players.teamID = teams.ID and players.tag = @player;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@player", currPlayer);
                cmd.Parameters.AddWithValue("@userTeam", userTeam);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    player = reader[3].ToString();
                    string tempPrice = reader[0].ToString();
                    price = Convert.ToInt32(tempPrice);
                    string tempOverall = reader[0].ToString();
                    overall = Convert.ToInt32(tempOverall);
                    team = (string)reader[2];
                    string query2 = @"SELECT avg(players.overall) FROM players";
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        string tempTotalOverall = reader2[0].ToString();
                        double totalOverall = Convert.ToDouble(tempTotalOverall);
                        string query4 = @"SELECT budget FROM teams WHERE ID = @id";
                        SQLiteCommand cmd4 = new SQLiteCommand(query4, conn);
                        cmd4.Parameters.AddWithValue("@id", userTeam);
                        object temp = cmd4.ExecuteScalar();
                        budget = Convert.ToInt32(temp);
                        if (budget >= playerOffer)
                        {
                            bool tranfser = acceptReject(playerOffer, price, overall, totalOverall);
                            if (tranfser == true)
                            {
                                int newBudget = budget - Convert.ToInt32(playerOffer);
                                Logo(userTeam);
                                string query3 = @"UPDATE players SET teamID = @newTeam WHERE players.tag = @player;
                                                        UPDATE teams SET budget = @newBudget WHERE teams.ID = @newTeam;";
                                SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
                                cmd3.Parameters.AddWithValue("@newTeam", userTeam);
                                cmd3.Parameters.AddWithValue("@player", player);
                                cmd3.Parameters.AddWithValue("@newBudget", newBudget);
                                cmd3.ExecuteNonQuery();
                            }
                            else
                            {
                                playerOfferInput.Clear();
                                errorMessages.Content = "Not Accepted";
                            }
                        }
                        else
                        {
                            errorMessages.Content = "Not Enough Funds";
                        }
                    }
                }
                conn.Close();
            }
        }


        private bool acceptReject(int offer, int price, int playerStat, double averagePlayer)
        {
            int offPrice = (offer / price) * 100;
            double dampner;
            int saleChance, ranNum;
            if (offPrice < 80)
            {
                return false;
            }
            else
            {
                if (playerStat > averagePlayer)
                {
                    dampner = 1.5;
                }
                else
                {
                    dampner = 0.8;
                }
                Random rnd = new Random();
                ranNum = rnd.Next(1, 7);
                saleChance = (ranNum * (int)dampner) / 2;
                if (saleChance >= 1.6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void playerDetails(string selected)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                int teamID;
                conn.Open();
                string query = @"SELECT players.tag, players.firstName, players.lastName, nations.country, roles.role, heroes.Name, players.heroKnowledge, players.mechanics, players.gameSense, players.teamWork, players.leadership, players.overall, players.teamID, players.price
                    FROM players, nations, roles, heroes, teams
                    WHERE players.nationality = nations.ID AND players.role = roles.ID AND players.Specalist = heroes.ID AND players.teamID = teams.ID
                    AND players.tag = @playerSelected";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@playerSelected", selected);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    playerName.Content = (string)reader[0];
                    firstNameLbl.Content = (string)reader[1];
                    lastNameLbl.Content = (string)reader[2];
                    nationalityLbl.Content = (string)reader[3];
                    roleLbl.Content = (string)reader[4];
                    specialistLbl.Content = (string)reader[5];
                    heroknwldgeLbl.Content = reader[6].ToString();
                    mechanicsLbl.Content = reader[7].ToString();
                    gmsnseLbl.Content = reader[8].ToString();
                    tmwrkLbl.Content = reader[9].ToString();
                    ldrshpLbl.Content = reader[10].ToString();
                    overallLbl.Content = reader[11].ToString();
                    string cost = reader[13].ToString();
                    priceLbl.Content = string.Format("${0}", cost);
                    string temp = reader[12].ToString();
                    teamID = Convert.ToInt32(temp);
                    Logo(teamID);
                }
                conn.Close();
            }
        }
    }
}
