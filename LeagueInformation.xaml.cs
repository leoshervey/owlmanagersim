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
    /// Interaction logic for LeagueInformation.xaml
    /// </summary>
    public partial class LeagueInformation : Window
    {
        public LeagueInformation()
        {
            InitializeComponent();
            Logo();
            leagueTableDisplay();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void Logo()
        {
            int team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case 1:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\ATL.png", UriKind.Relative));
                    break;
                case 2:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\BST.png", UriKind.Relative));
                    break;
                case 3:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\CNG.png", UriKind.Relative));
                    break;
                case 4:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\DLS.png", UriKind.Relative));
                    break;
                case 5:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\FLR.png", UriKind.Relative));
                    break;
                case 6:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\GNZ.png", UriKind.Relative));
                    break;
                case 7:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\HNZ.png", UriKind.Relative));
                    break;
                case 8:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\HOU.png", UriKind.Relative));
                    break;
                case 9:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\LDN.png", UriKind.Relative));
                    break;
                case 10:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\LGL.png", UriKind.Relative));
                    break;
                case 11:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\LVA.png", UriKind.Relative));
                    break;
                case 12:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\NYE.png", UriKind.Relative));
                    break;
                case 13:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\PAR.png", UriKind.Relative));
                    break;
                case 14:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\PHL.png", UriKind.Relative));
                    break;
                case 15:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\SFS.png", UriKind.Relative));
                    break;
                case 17:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\SHD.png", UriKind.Relative));
                    break;
                case 16:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\SLD.png", UriKind.Relative));
                    break;
                case 18:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\TOR.png", UriKind.Relative));
                    break;
                case 19:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\VNC.png", UriKind.Relative));
                    break;
                case 20:
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\WAS.png", UriKind.Relative));
                    break;
            }
        }

        private void leagueTableDisplay()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT teams.team, leaguetable.Played, leaguetable.Wins, leaguetable.Losses, leaguetable.MapDiff, leaguetable.MapWon, leaguetable.MapLoss, leaguetable.MapTie FROM teams, leaguetable WHERE teams.ID = leaguetable.ID ORDER BY leaguetable.Wins DESC;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string table = (string)reader[0] + "        " + reader[1].ToString() + "        " + reader[2].ToString() + "        " + reader[3].ToString() + "        " + reader[4].ToString() + "        " + reader[5].ToString() + "        " + reader[6].ToString() + "        " + reader[7].ToString();
                    bigLeagueTable.Items.Add(table);
                }
                conn.Close();
            }
        }
    }
}
