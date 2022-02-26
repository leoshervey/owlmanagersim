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
using System.Data;

namespace OWLSimGame
{
    /// <summary>
    /// Interaction logic for TransferMarket.xaml
    /// </summary>
    public partial class TransferMarket : Window
    {
        int teamID;
        public TransferMarket()
        {
            InitializeComponent();
            Logo();
            teamBudget();
        }

        private void Logo()
        {
            string team;

            team = CareerSelect.teamChoice();
            switch (team)
            {
                case "Atlanta":
                    teamID = 1;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\ATL.png"));
                    break;
                case "Boston":
                    teamID = 2;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\BST.png"));
                    break;
                case "Chengdu":
                    teamID = 3;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\CNG.png"));
                    break;
                case "Dallas":
                    teamID = 4;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\DLS.png"));
                    break;
                case "Florida":
                    teamID = 5;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\FLR.png"));
                    break;
                case "Guangzhou":
                    teamID = 6;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\GNZ.png"));
                    break;
                case "Hangzhou":
                    teamID = 7;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\HNZ.png"));
                    break;
                case "Houston":
                    teamID = 8;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\HOU.png"));
                    break;
                case "London":
                    teamID = 9;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LDN.png"));
                    break;
                case "Los Angeles Glad":
                    teamID = 10;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LGL.png"));
                    break;
                case "Los Angeles Val":
                    teamID = 11;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LVA.png"));
                    break;
                case "New York":
                    teamID = 12;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\NYE.png"));
                    break;
                case "Paris":
                    teamID = 13;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\PAR.png"));
                    break;
                case "Philadelphia":
                    teamID = 14;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\PHL.png"));
                    break;
                case "San Francisco":
                    teamID = 15;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SFS.png"));
                    break;
                case "Seoul":
                    teamID = 16;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SHD.png"));
                    break;
                case "Shanghai":
                    teamID = 17;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SLD.png"));
                    break;
                case "Toronto":
                    teamID = 18;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\TOR.png"));
                    break;
                case "Vancouver":
                    teamID = 19;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\VNC.png"));
                    break;
                case "Washington":
                    teamID = 20;
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\WAS.png"));
                    break;
            }
        }

        private void transferList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (transferList.)
            object playerSelected = transferList.SelectedItem;
            TransferPlayerActions win1 = new TransferPlayerActions(playerSelected.ToString());
            win1.Show();

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void playerSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            transferList.Items.Clear();
            //lblTag.Content = "";
            txtBlNames.Text = "";
            txtBlTeams.Text = "";
            txtBlOverall.Text = "";
            txtBlNationality.Text = "";
            txtBlRole.Text = "";
            if (!String.IsNullOrEmpty(playerSearchBar.Text))
            {
                sqlSearch(playerSearchBar.Text);
            }
        }

        private void teamBudget()
        {
            String finance; ;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT budget FROM teams WHERE ID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", teamID);
                object temp = cmd.ExecuteScalar();
                finance = temp.ToString();
                budgetBox.Content = string.Format("${0:C}", finance);
                conn.Close();
            }
        }

        private void sqlSearch(string value)
        {
            string tagLabel;
            string teams ="";
            string names = "";
            string overalls = "";
            string roles = "";
            string nationalities = "";
            StringBuilder name = new StringBuilder();
            StringBuilder overallLabel = new StringBuilder();

            StringBuilder nationalityLabel = new StringBuilder();
            StringBuilder rolelabel = new StringBuilder();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.firstName, players.lastName, players.tag, teams.team, players.overall, nations.country, roles.role
                        FROM players, teams, nations, roles
                        WHERE players.teamID = teams.ID AND players.nationality = nations.ID AND players.role = roles.ID
                        AND tag LIKE @name";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", teamID);
                cmd.Parameters.AddWithValue("@name", value + "%");
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    names += (string)reader[0] + " " + (string)reader[1] + "\n";
                    txtBlNames.Text = names;
                    tagLabel = (string)reader[2];
                    transferList.Items.Add(tagLabel);
                    teams += (string)reader[3] + "\n";
                    txtBlTeams.Text = teams;
                    if (reader.IsDBNull(4))
                    {
                        overalls += "\n";
                    }
                    else
                    {
                        overalls += reader.GetInt32(4).ToString() + "\n";
                    }
                    txtBlOverall.Text = overalls;

                    roles += (string)reader[6] + "\n";
                    txtBlRole.Text = roles;
                    nationalities += (string)reader[5] + "\n";
                    txtBlNationality.Text = nationalities;
                }
                conn.Close();
            }
        }
    }
}