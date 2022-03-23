using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for CareerPage.xaml
    /// </summary>
    public partial class CareerPage : Window
    {
        private int _gameWeek;
        private bool _nextMatch;
        private int _totalUserStrength;
        private int _leaguePosition;
        public CareerPage(int gameweek, int totalUserStrength)
        {
            InitializeComponent();
            _gameWeek = gameweek;
            _totalUserStrength = totalUserStrength;
            Logo();
            leagueTableDisplay();
            progress.Visibility = Visibility.Visible;
            if (_gameWeek < 20)
            {
                currDate.Content = "Current Gameday: " + _gameWeek;
                _nextMatch = true;
                progress.Content = "MATCH SCREEN";

            }
            else
            {
                currDate.Content = "End of season";
                _nextMatch = false;
                progress.Visibility = Visibility.Hidden;
            }
            userLeaguePosition.Content = _leaguePosition.ToString() + getSuffix(_leaguePosition);
        }


        private string getSuffix(int pos)
        {
            string suffix;
            switch (pos)
            {
                case 1:
                    suffix = "st";
                    break;
                case 2:
                    suffix = "nd";
                    break;
                case 3:
                    suffix = "rd";
                    break;
                default:
                    suffix = "th";
                    break;
            }
            return suffix;
        }

        private void Logo()
        {
            int team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case 1:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Atlanta_Reign_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\ATL.png", UriKind.Relative));
                    break;
                case 2:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Boston_Uprising_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\BST.png", UriKind.Relative));
                    break;
                case 3:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Chengdu_Hunters_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\CNG.png", UriKind.Relative));
                    break;
                case 4:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Dallas_Fuel_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\DLS.png", UriKind.Relative));
                    break;
                case 5:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Florida_Mayhem_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\FLR.png", UriKind.Relative));
                    break;
                case 6:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Guangzhou_Charge_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\GNZ.png", UriKind.Relative));
                    break;
                case 7:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Hangzhou_Spark_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\HNZ.png", UriKind.Relative));
                    break;
                case 8:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Houston_Outlaws_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\HOU.png", UriKind.Relative));
                    break;
                case 9:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\London_Spitfire_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\LDN.png", UriKind.Relative));
                    break;
                case 10:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Gladiators_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\LGL.png", UriKind.Relative));
                    break;
                case 11:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Valiant_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\LVA.png", UriKind.Relative));
                    break;
                case 12:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\New_York_Excelsior_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\NYE.png", UriKind.Relative));
                    break;
                case 13:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Paris_Eternal_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\PAR.png", UriKind.Relative));
                    break;
                case 14:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Philadelphia_Fusion_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\PHL.png", UriKind.Relative));
                    break;
                case 15:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\San_Francisco_Shock_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\SFS.png", UriKind.Relative));
                    break;
                case 16:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Seoul_Dynasty_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\SLD.png", UriKind.Relative));
                    break;
                case 17:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Shanghai_Dragons_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\SHD.png", UriKind.Relative));
                    break;
                case 18:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Toronto_Defiant_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\TOR.png", UriKind.Relative));
                    break;
                case 19:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Vancouver_Titans_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\VNC.png", UriKind.Relative));
                    break;
                case 20:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Washington_Justice_Jersey.png", UriKind.Relative));
                    teamLogo.Source = new BitmapImage(new Uri(@"teamBadges\WAS.png", UriKind.Relative));
                    break;
            }
        }
        private void closeWindow(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"UPDATE leaguetable
                                 SET Played = @p, Wins = @w, MapDiff = @md, MapWon = @mw, MapLoss = @ml, Losses = @l;";
                SQLiteCommand cmd2 = new SQLiteCommand(query, conn);
                cmd2.Parameters.AddWithValue("@p", 0);
                cmd2.Parameters.AddWithValue("@w", 0);
                cmd2.Parameters.AddWithValue("@md", 0);
                cmd2.Parameters.AddWithValue("@mw", 0);
                cmd2.Parameters.AddWithValue("@ml", 0);
                cmd2.Parameters.AddWithValue("@l", 0);
                cmd2.ExecuteNonQuery();
            }
            CareerSelect win1 = new CareerSelect();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransferMarket win1 = new TransferMarket(_gameWeek);
            win1.Show();
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TacticsPage win1 = new TacticsPage(_gameWeek);
            win1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LeagueInformation win1 = new LeagueInformation(_gameWeek);
            win1.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (_nextMatch == true)
            {
                if (_totalUserStrength > 0)
                {
                    GameplayScreen win1 = new GameplayScreen(_gameWeek, _totalUserStrength);
                    win1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must choose your players for the next match");
                }
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void leagueTableDisplay()
        {
            int count = 0;
            using(SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT teams.shortTeam, leaguetable.Played, leaguetable.Wins, leaguetable.Losses, leaguetable.MapDiff, teams.ID FROM teams, leaguetable WHERE teams.ID = leaguetable.ID ORDER BY leaguetable.Wins DESC, leaguetable.MapDiff DESC, leaguetable.MapWon DESC, leaguetable.MapLoss DESC, leaguetable.Losses ASC;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string table = (string)reader[0] + "        " + reader[1].ToString() + "        " + reader[2].ToString() + "        " + reader[3].ToString() + "        " + reader[4].ToString();
                    leagueTable.Items.Add(table);
                    if (Convert.ToInt32(reader[5]) == CareerSelect.teamChoice())
                    {
                        leagueTable.SelectedIndex = count;
                        _leaguePosition = count + 1;
                    }
                    count++;
                }
                conn.Close();
            }
        }
    }
}