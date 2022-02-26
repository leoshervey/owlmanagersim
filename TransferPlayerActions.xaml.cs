using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SQLite;

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
        }

        private void Logo(int team)
        { 
            switch (team)
            {
                case 1:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\ATL.png"));
                    break;
                case 2:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\BST.png"));
                    break;
                case 3:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\CNG.png"));
                    break;
                case 4:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\DLS.png"));
                    break;
                case 5:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\FLR.png"));
                    break;
                case 6:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\GNZ.png"));
                    break;
                case 7:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\HNZ.png"));
                    break;
                case 8:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\HOU.png"));
                    break;
                case 9:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LDN.png"));
                    break;
                case 10:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LGL.png"));
                    break;
                case 11:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LVA.png"));
                    break;
                case 12:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\NYE.png"));
                    break;
                case 13:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\PAR.png"));
                    break;
                case 14:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\PHL.png"));
                    break;
                case 15:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SFS.png"));
                    break;
                case 16:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SHD.png"));
                    break;
                case 17:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SLD.png"));
                    break;
                case 18:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\TOR.png"));
                    break;
                case 19:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\VNC.png"));
                    break;
                case 20:
                    currTeam.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\WAS.png"));
                    break;
            }
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
        {

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
                    priceLbl.Content = (string.Format("${0}", cost));
                    string temp = reader[12].ToString();
                    teamID = Convert.ToInt32(temp);
                    Logo(teamID);
                }
                conn.Close();
            }
        }
    }
}
