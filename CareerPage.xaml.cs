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
        public CareerPage()
        {
            InitializeComponent();
            Logo();
            leagueTableDisplay();
        }
        private void Logo()
        {
            int team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case 1:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Atlanta_Reign_Jersey.png", UriKind.Relative));
                    break;
                case 2:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Boston_Uprising_Jersey.png", UriKind.Relative));
                    break;
                case 3:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Chengdu_Hunters_Jersey.png", UriKind.Relative));
                    break;
                case 4:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Dallas_Fuel_Jersey.png", UriKind.Relative));
                    break;
                case 5:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Florida_Mayhem_Jersey.png", UriKind.Relative));
                    break;
                case 6:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Guangzhou_Charge_Jersey.png", UriKind.Relative));
                    break;
                case 7:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Hangzhou_Spark_Jersey.png", UriKind.Relative));
                    break;
                case 8:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Houston_Outlaws_Jersey.png", UriKind.Relative));
                    break;
                case 9:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\London_Spitfire_Jersey.png", UriKind.Relative));
                    break;
                case 10:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Gladiators_Jersey.png", UriKind.Relative));
                    break;
                case 11:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Valiant_Jersey.png", UriKind.Relative));
                    break;
                case 12:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\New_York_Excelsior_Jersey.png", UriKind.Relative));
                    break;
                case 13:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Paris_Eternal_Jersey.png", UriKind.Relative));
                    break;
                case 14:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Philadelphia_Fusion_Jersey.png", UriKind.Relative));
                    break;
                case 15:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\San_Francisco_Shock_Jersey.png", UriKind.Relative));
                    break;
                case 16:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Seoul_Dynasty_Jersey.png", UriKind.Relative));
                    break;
                case 17:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Shanghai_Dragons_Jersey.png", UriKind.Relative));
                    break;
                case 18:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Toronto_Defiant_Jersey.png", UriKind.Relative));
                    break;
                case 19:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Vancouver_Titans_Jersey.png", UriKind.Relative));
                    break;
                case 20:
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Washington_Justice_Jersey.png", UriKind.Relative));
                    break;
            }
        }
        private void closeWindow(object sender, RoutedEventArgs e)
        {
            CareerSelect win1 = new CareerSelect();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TransferMarket win1 = new TransferMarket();
            win1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TacticsPage win1 = new TacticsPage();
            win1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LeagueInformation win1 = new LeagueInformation();
            win1.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void leagueTableDisplay()
        {
            using(SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT teams.shortTeam, leaguetable.Played, leaguetable.Wins, leaguetable.Losses, leaguetable.MapDiff FROM teams, leaguetable WHERE teams.ID = leaguetable.ID ORDER BY leaguetable.Wins DESC;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string table = (string)reader[0] + "        " + reader[1].ToString() + "        " + reader[2].ToString() + "        " + reader[3].ToString() + "        " + reader[4].ToString();
                    leagueTable.Items.Add(table);
                }
                conn.Close();
            }
        }
    }
}
