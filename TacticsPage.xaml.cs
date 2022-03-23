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
        public int ovr1, ovr2, ovr3, ovr4, ovr5, her1, her2, her3, her4, her5;
        private int _week;
        public int totalOvr = 0;
        public bool selectedHeroes1 = false, selectedHeroes2 = false, selectedHeroes3 = false, selectedHeroes4 = false, selectedHeroes5 = false;
        public bool selectedPlayers1 = false, selectedPlayers2 = false, selectedPlayers3 = false, selectedPlayers4 = false, selectedPlayers5 = false;

        public TacticsPage(int week)
        {
            InitializeComponent();
            _week = week;
            nameOfTeam();
            damagePlayers();
            tankPlayers();
            supportPlayers();
            teamMentalities.Visibility = Visibility.Hidden;
        }

        private void damagePlayers()
        {
            int team;
            team = CareerSelect.teamChoice();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.tag FROM players, roles WHERE players.role = roles.ID AND players.teamID = @team AND players.role = 9;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@team", team);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string listTag = (string)reader[0];
                    string comboTag = (string)reader[0];
                    damageList.Items.Add(listTag);
                    dpsPlayer1.Items.Add(comboTag);
                    dpsPlayer2.Items.Add(comboTag);
                }
                conn.Close();
            }
        }

        private void tankPlayers()
        {
            int team;
            team = CareerSelect.teamChoice();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.tag FROM players, roles WHERE players.role = roles.ID AND players.teamID = @team AND players.role = 10;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@team", team);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string listTag = (string)reader[0];
                    string comboTag = (string)reader[0];
                    tankList.Items.Add(listTag);
                    tankPlayer.Items.Add(comboTag);
                }
            }
        }

        private void supportPlayers()
        {
            int team;
            team = CareerSelect.teamChoice();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.tag FROM players, roles WHERE players.role = roles.ID AND players.teamID = @team AND players.role = 11;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@team", team);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string listTag = (string)reader[0];
                    string comboTag = (string)reader[0];
                    supportList.Items.Add(listTag);
                    supportPlayer1.Items.Add(comboTag);
                    supportPlayer2.Items.Add(comboTag);
                }
            }
        }

        private void strengthOfTeam()
        {
            totalOvr = ovr1 + ovr2 + ovr3 + ovr4 + ovr5 + her1 + her2 + her3 + her4 + her5;
            teamStrength.Text = totalOvr.ToString();
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
                    teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Gladiators_Jersey.png", UriKind.Relative));
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((selectedPlayers1 && selectedPlayers2 && selectedPlayers3 && selectedPlayers4 && selectedPlayers5 == true) && (selectedHeroes1 && selectedHeroes2 && selectedHeroes3 && selectedHeroes4 && selectedHeroes5 == true))
            {
                CareerPage win1 = new CareerPage(_week, totalOvr);
                win1.Show();
                this.Close();
            }
            else if (selectedHeroes1 == false)
            {
                MessageBox.Show("You must choose your heroes");
            }
            else
            {
                MessageBox.Show("You must choose your team players");
            }
        }

        private int getPlayerValue(string name)
        {
            int value;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT players.overall FROM players WHERE players.tag = @name";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                object temp = cmd.ExecuteScalar();
                value = Convert.ToInt32(temp);
                conn.Close();
            }
            return value;
        }

        private int getHeroValue(int ID)
        {
            int value;
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT heroes.Strength
                                 FROM heroes
                                 WHERE heroes.ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                object temp = cmd.ExecuteScalar();
                value = Convert.ToInt32(temp);
                conn.Close();
            }
            return value;
        }

        private void dpsPlayer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             string name = dpsPlayer1.SelectedItem.ToString();
             ovr2 = getPlayerValue(name);
             selectedPlayers1 = true;
             strengthOfTeam();
        }

        private void dpsPlayer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = dpsPlayer2.SelectedItem.ToString();
            ovr1 = getPlayerValue(name);
            selectedPlayers2 = true;
            strengthOfTeam();
        }

        private void tankPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = tankPlayer.SelectedItem.ToString();
            ovr3 = getPlayerValue(name);
            selectedPlayers3 = true;
            strengthOfTeam();
        }

        private void supportPlayer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = supportPlayer1.SelectedItem.ToString();
            ovr4 = getPlayerValue(name);
            selectedPlayers4 = true;
            strengthOfTeam();
        }

        private void supportPlayer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = supportPlayer2.SelectedItem.ToString();
            ovr5 = getPlayerValue(name);
            selectedPlayers5 = true;
            strengthOfTeam();
        }

        public static int selection;

        public void heroPicks(int hero)
        {
            if (selection == 1)
            {
                switch (hero)
                {
                    case 2:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Ashe.png", UriKind.Relative))
                        };
                        break;
                    case 4:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Bastion.png", UriKind.Relative))
                        };
                        break;
                    case 6:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-cassidy.png", UriKind.Relative))
                        };
                        break;
                    case 8:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Doomfist.png", UriKind.Relative))
                        };
                        break;
                    case 9:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Echo.png", UriKind.Relative))
                        };
                        break;
                    case 10:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Genji.png", UriKind.Relative))
                        };
                        break;
                    case 11:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Hanzo.png", UriKind.Relative))
                        };
                        break;
                    case 12:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Junkrat.png", UriKind.Relative))
                        };
                        break;
                    case 14:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Mei.png", UriKind.Relative))
                        };
                        break;
                    case 18:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Pharah.png", UriKind.Relative))
                        };
                        break;
                    case 23:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Soldier_76.png", UriKind.Relative))
                        };
                        break;
                    case 24:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Sombra.png", UriKind.Relative))
                        };
                        break;
                    case 25:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.3sDqH.png", UriKind.Relative))
                        };
                        break;
                    case 26:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.3OBuQ.png", UriKind.Relative))
                        };
                        break;
                    case 27:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Tracer.png", UriKind.Relative))
                        };
                        break;
                    case 28:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.29jKn.png", UriKind.Relative))
                        };
                        break;
                    case 19:
                        hero2.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.24wg5.png", UriKind.Relative))
                        };
                        break;
                }
            }
            else if (selection == 2)
            {
                switch (hero)
                {
                    case 2:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Ashe.png", UriKind.Relative))
                        };
                        break;
                    case 4:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Bastion.png", UriKind.Relative))
                        };
                        break;
                    case 6:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-cassidy.png", UriKind.Relative))
                        };
                        break;
                    case 8:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Doomfist.png", UriKind.Relative))
                        };
                        break;
                    case 9:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Echo.png", UriKind.Relative))
                        };
                        break;
                    case 10:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Genji.png", UriKind.Relative))
                        };
                        break;
                    case 11:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Hanzo.png", UriKind.Relative))
                        };
                        break;
                    case 12:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Junkrat.png", UriKind.Relative))
                        };
                        break;
                    case 14:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Mei.png", UriKind.Relative))
                        };
                        break;
                    case 18:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Pharah.png", UriKind.Relative))
                        };
                        break;
                    case 23:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Soldier_76.png", UriKind.Relative))
                        };
                        break;
                    case 24:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Sombra.png", UriKind.Relative))
                        };
                        break;
                    case 25:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.3sDqH.png", UriKind.Relative))
                        };
                        break;
                    case 26:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.3OBuQ.png", UriKind.Relative))
                        };
                        break;
                    case 27:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Tracer.png", UriKind.Relative))
                        };
                        break;
                    case 28:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.29jKn.png", UriKind.Relative))
                        };
                        break;
                    case 19:
                        hero1.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.24wg5.png", UriKind.Relative))
                        };
                        break;
                }
            }
            else if (selection == 3)
            {
                switch (hero)
                {
                    case 7:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-D.Va.png", UriKind.Relative))
                        };
                        break;
                    case 17:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Orisa.png", UriKind.Relative))
                        };
                        break;
                    case 20:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.0s4jW.png", UriKind.Relative))
                        };
                        break;
                    case 21:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Roadhog.png", UriKind.Relative))
                        };
                        break;
                    case 22:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Sigma.png", UriKind.Relative))
                        };
                        break;
                    case 29:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.0AIzO.png", UriKind.Relative))
                        };
                        break;
                    case 30:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Wrecking_Ball.png", UriKind.Relative))
                        };
                        break;
                    case 31:
                        hero3.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Zarya.png", UriKind.Relative))
                        };
                        break;
                }
            }
            else if (selection == 4)
            {
                switch (hero)
                {
                    case 1:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Ana.png", UriKind.Relative))
                        };
                        break;
                    case 3:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Baptiste.png", UriKind.Relative))
                        };
                        break;
                    case 5:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Brigitte.png", UriKind.Relative))
                        };
                        break;
                    case 13:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Lúcio.png", UriKind.Relative))
                        };
                        break;
                    case 15:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Mercy.png", UriKind.Relative))
                        };
                        break;
                    case 16:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Moira.png", UriKind.Relative))
                        };
                        break;
                    case 32:
                        hero4.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.03Fcx.png", UriKind.Relative))
                        };
                        break;
                }
            }
            else
            {
                switch (hero)
                {
                    case 1:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Ana.png", UriKind.Relative))
                        };
                        break;
                    case 3:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Baptiste.png", UriKind.Relative))
                        };
                        break;
                    case 5:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Brigitte.png", UriKind.Relative))
                        };
                        break;
                    case 13:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Lúcio.png", UriKind.Relative))
                        };
                        break;
                    case 15:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Mercy.png", UriKind.Relative))
                        };
                        break;
                    case 16:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-Moira.png", UriKind.Relative))
                        };
                        break;
                    case 32:
                        hero5.Content = new Image
                        {
                            Source = new BitmapImage(new Uri(@"heroes\Icon-portrait.03Fcx.png", UriKind.Relative))
                        };
                        break;
                }
            }
        }

        private void hero2_Click(object sender, RoutedEventArgs e)
        {
            int hero = 1;
            selection = 1;
            selectedHeroes1 = true;
            ChooseHero win1 = new ChooseHero(hero);
            win1.ShowDialog();
            hero = Convert.ToInt32(win1.choice);
            her1 = getHeroValue(hero);
            strengthOfTeam();
            heroPicks(hero);
        }

        private void hero1_Click(object sender, RoutedEventArgs e)
        {
            int hero = 1;
            selection = 2;
            selectedHeroes2 = true;
            ChooseHero win1 = new ChooseHero(hero);
            win1.ShowDialog();
            hero = Convert.ToInt32(win1.choice);
            her2 = getHeroValue(hero);
            strengthOfTeam();
            heroPicks(hero);
        }

        private void hero3_Click(object sender, RoutedEventArgs e)
        {
            int hero = 2;
            selection = 3;
            selectedHeroes3 = true;
            ChooseHero win1 = new ChooseHero(hero);
            win1.ShowDialog();
            hero = Convert.ToInt32(win1.choice);
            her3 = getHeroValue(hero);
            strengthOfTeam();
            heroPicks(hero);
        }

        private void hero4_Click(object sender, RoutedEventArgs e)
        {
            int hero = 3;
            selection = 4;
            selectedHeroes4 = true;
            ChooseHero win1 = new ChooseHero(hero);
            win1.ShowDialog();
            hero = Convert.ToInt32(win1.choice);
            her4 = getHeroValue(hero);
            strengthOfTeam();
            heroPicks(hero);
        }

        private void hero5_Click(object sender, RoutedEventArgs e)
        {
            int hero = 3;
            selection = 5;
            selectedHeroes5 = true;
            ChooseHero win1 = new ChooseHero(hero);
            win1.ShowDialog();
            hero = Convert.ToInt32(win1.choice);
            her5 = getHeroValue(hero);
            strengthOfTeam();
            heroPicks(hero);
        }

        private void Player_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object playerSelected = damageList.SelectedItem;
            TransferPlayerActions win1 = new TransferPlayerActions(playerSelected.ToString(),_week,false);
            win1.Show();
        }

        private void tankList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object playerSelected = tankList.SelectedItem;
            TransferPlayerActions win1 = new TransferPlayerActions(playerSelected.ToString(), _week, false);
            win1.Show();
        }

        private void supportList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object playerSelected = supportList.SelectedItem;
            TransferPlayerActions win1 = new TransferPlayerActions(playerSelected.ToString(), _week, false);
            win1.Show();
        }
    }
}
