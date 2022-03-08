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
            int team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case 1:
                    teamID = 1;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\ATL.png", UriKind.Relative));
                    break;
                case 2:
                    teamID = 2;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\BST.png", UriKind.Relative));
                    break;
                case 3:
                    teamID = 3;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\CNG.png", UriKind.Relative));
                    break;
                case 4:
                    teamID = 4;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\DLS.png", UriKind.Relative));
                    break;
                case 5:
                    teamID = 5;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\FLR.png", UriKind.Relative));
                    break;
                case 6:
                    teamID = 6;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\GNZ.png", UriKind.Relative));
                    break;
                case 7:
                    teamID = 7;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\HNZ.png", UriKind.Relative));
                    break;
                case 8:
                    teamID = 8;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\HOU.png", UriKind.Relative));
                    break;
                case 9:
                    teamID = 9;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\LDN.png", UriKind.Relative));
                    break;
                case 10:
                    teamID = 10;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\LGL.png", UriKind.Relative));
                    break;
                case 11:
                    teamID = 11;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\LVA.png", UriKind.Relative));
                    break;
                case 12:
                    teamID = 12;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\NYE.png", UriKind.Relative));
                    break;
                case 13:
                    teamID = 13;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\PAR.png", UriKind.Relative));
                    break;
                case 14:
                    teamID = 14;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\PHL.png", UriKind.Relative));
                    break;
                case 15:
                    teamID = 15;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\SFS.png", UriKind.Relative));
                    break;
                case 17:
                    teamID = 17;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\SHD.png", UriKind.Relative));
                    break;
                case 16:
                    teamID = 16;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\SLD.png", UriKind.Relative));
                    break;
                case 18:
                    teamID = 18;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\TOR.png", UriKind.Relative));
                    break;
                case 19:
                    teamID = 19;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\VNC.png", UriKind.Relative));
                    break;
                case 20:
                    teamID = 20;
                    badge.Source = new BitmapImage(new Uri(@"teamBadges\WAS.png", UriKind.Relative));
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