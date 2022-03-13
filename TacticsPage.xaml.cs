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
    /// Interaction logic for TacticsPage.xaml
    /// </summary>
    public partial class TacticsPage : Window
    {
        public TacticsPage()
        {
            InitializeComponent();
            nameOfTeam();
            teamInfo();
        }

        private void teamInfo()
        {
            int team;
            string overallSum;
            team = CareerSelect.teamChoice();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.tag, roles.role FROM players, roles WHERE players.role = roles.ID AND players.teamID = @team ORDER BY roles.role DESC;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@team", team);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tag = (string)reader[0] + " | " + (string)reader[1];
                    Player_List.Items.Add(tag);
                    string query2 = @"SELECT  sum(players.overall) FROM players WHERE players.teamID = @team";
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@team", team);
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        overallSum = reader2[0].ToString();
                        teamStrength.Text = overallSum;
                    }
                }
                conn.Close();
            }
        }

        private void nameOfTeam()
        {
            int team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case 1:
                    teamName.Text = "Atlanta";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Atlanta_Reign_Jersey.png", UriKind.Relative));
                    break;
                case 2:
                    teamName.Text = "Boston";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Boston_Uprising_Jersey.png", UriKind.Relative));
                    break;
                case 3:
                    teamName.Text = "Chengdu";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Chengdu_Hunters_Jersey.png", UriKind.Relative));
                    break;
                case 4:
                    teamName.Text = "Dallas";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Dallas_Fuel_Jersey.png", UriKind.Relative));
                    break;
                case 5:
                    teamName.Text = "Florida";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Florida_Mayhem_Jersey.png", UriKind.Relative));
                    break;
                case 6:
                    teamName.Text = "Guangzhou";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Guangzhou_Charge_Jersey.png", UriKind.Relative));
                    break;
                case 7:
                    teamName.Text = "Hangzhou";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Hangzhou_Spark_Jersey.png", UriKind.Relative));
                    break;
                case 8:
                    teamName.Text = "Houston";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Houston_Outlaws_Jersey.png", UriKind.Relative));
                    break;
                case 9:
                    teamName.Text = "London";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\London_Spitfire_Jersey.png", UriKind.Relative));
                    break;
                case 10:
                    teamName.Text = "Gladiators";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Gladiators.png", UriKind.Relative));
                    break;
                case 11:
                    teamName.Text = "Valiant";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Valiant_Jersey.png", UriKind.Relative));
                    break;
                case 12:
                    teamName.Text = "New York";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\New_York_Excelsior_Jersey.png", UriKind.Relative));
                    break;
                case 13:
                    teamName.Text = "Paris";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Paris_Eternal_Jersey.png", UriKind.Relative));
                    break;
                case 14:
                    teamName.Text = "Fusion";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Philadelphia_Fusion_Jersey.png", UriKind.Relative));
                    break;
                case 15:
                    teamName.Text = "Shock";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\San_Francisco_Shock_Jersey.png", UriKind.Relative));
                    break;
                case 16:
                    teamName.Text = "Seoul";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Seoul_Dynasty_Jersey.png", UriKind.Relative));
                    break;
                case 17:
                    teamName.Text = "Shanghai";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Shanghai_Dragons_Jersey.png", UriKind.Relative));
                    break;
                case 18:
                    teamName.Text = "Toronto";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Toronto_Defiant_Jersey.png", UriKind.Relative));
                    break;
                case 19:
                    teamName.Text = "Vancouver";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Vancouver_Titans_Jersey.png", UriKind.Relative));
                    break;
                case 20:
                    teamName.Text = "Washington";
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Washington_Justice_Jersey.png", UriKind.Relative));
                    break;
            }
        }

        private void heroSelection()
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void teamList()
        {
            //database for team list
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void dpsPlayer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dpsPlayer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tankPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void supportPlayer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void supportPlayer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public static int h1, h2, h3, h4, h5;

        private void hero2_Click(object sender, RoutedEventArgs e)
        {
            int hero = 1, selection = 1;
            ChooseHero win1 = new ChooseHero(hero, selection);
            win1.Show();
        }

        private void hero1_Click(object sender, RoutedEventArgs e)
        {
            int hero = 1, selection = 2;
            ChooseHero win1 = new ChooseHero(hero, selection);
            win1.Show();
        }

        private void hero3_Click(object sender, RoutedEventArgs e)
        {
            int hero = 2, selection = 3;
            ChooseHero win1 = new ChooseHero(hero, selection);
            win1.Show();
        }

        private void hero4_Click(object sender, RoutedEventArgs e)
        {
            int hero = 3, selection = 4;
            ChooseHero win1 = new ChooseHero(hero, selection);
            win1.Show();
        }

        private void hero5_Click(object sender, RoutedEventArgs e)
        {
            int hero = 3, selection = 5;
            ChooseHero win1 = new ChooseHero(hero, selection);
            win1.Show();
        }
    }
}
