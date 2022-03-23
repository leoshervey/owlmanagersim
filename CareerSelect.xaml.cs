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
    /// Interaction logic for CareerSelect.xaml
    /// </summary>
    public partial class CareerSelect : Window
    {
        public CareerSelect()
        {
            InitializeComponent();
        }

        private static int teamChosen;

        public static int teamChoice()
        {
            return teamChosen;
        }
        
        private void atlReignChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 1;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void bstUpChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 2;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void chgHunChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 3;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void dalFueChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 4;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void flrMayhChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 5;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void gzhChrgChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 6;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void hnzSprkChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 7;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void hoUOutChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 8;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void ldnSpfChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 9;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void laGladChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 10;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void laValChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 11;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void nyExlChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 12;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void parEtrnChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 13;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void phlFusChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 14;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void sfShckChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 15;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void shgDragChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 17;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void solDynChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 16;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void trnDefChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 18;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void vanTitnChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 19;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void wasJusChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 20;
            CareerPage win1 = new CareerPage(1,0);
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void teamInformation(int team)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=owl_eng_db.db"))
            {
                conn.Open();
                string query = @"SELECT teams.team, teams.shortTeam, teams.founded, teams.budget, teams.titles, nations.country
                                 FROM teams, nations
                                 WHERE teams.ID = @team AND teams.region = nations.ID;";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@team", team);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader[0].ToString();
                    string abbr = reader[1].ToString();
                    string founded = reader[2].ToString();
                    string budget = reader[3].ToString();
                    string titles = reader[4].ToString();
                    string region = reader[5].ToString();

                    infoBlock.Text = name + ", often known as " + abbr + ", is a team from " + region + ". Founded on " + founded + ", the team has won a total of " + titles + " Overwatch League Grand Finals throughout its lifetime and has accumalated a budget of $" + budget;
                }
                conn.Close();
            }
        }

        private void atlInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Atlanta_Reign_Jersey.png", UriKind.Relative));
            teamInformation(1);
        }

        private void bstInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Boston_Uprising_Jersey.png", UriKind.Relative));
            teamInformation(2);
        }

        private void cngInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Chengdu_Hunters_Jersey.png", UriKind.Relative));
            teamInformation(3);
        }

        private void dalInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Dallas_Fuel_Jersey.png", UriKind.Relative));
            teamInformation(4);
        }

        private void flrInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Florida_Mayhem_Jersey.png", UriKind.Relative));
            teamInformation(5);
        }

        private void gnzInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Guangzhou_Charge_Jersey.png", UriKind.Relative));
            teamInformation(6);
        }

        private void hnzInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Hangzhou_Spark_Jersey.png", UriKind.Relative));
            teamInformation(7);
        }

        private void houInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Houston_Outlaws_Jersey.png", UriKind.Relative));
            teamInformation(8);
        }

        private void ldnInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\London_Spitfire_Jersey.png", UriKind.Relative));
            teamInformation(9);
        }

        private void lagInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Gladiators_Jersey.png", UriKind.Relative));
            teamInformation(10);
        }

        private void lavInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Los_Angeles_Valiant_Jersey.png", UriKind.Relative));
            teamInformation(11);
        }

        private void nyeInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\New_York_Excelsior_Jersey.png", UriKind.Relative));
            teamInformation(12);
        }

        private void parInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Paris_Eternal_Jersey.png", UriKind.Relative));
            teamInformation(13);
        }

        private void phlInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Philadelphia_Fusion_Jersey.png", UriKind.Relative));
            teamInformation(14);
        }

        private void sfsInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\San_Francisco_Shock_Jersey.png", UriKind.Relative));
            teamInformation(15);
        }

        private void solInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Seoul_Dynasty_Jersey.png", UriKind.Relative));
            teamInformation(16);
        }

        private void shgInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Shanghai_Dragons_Jersey.png", UriKind.Relative));
            teamInformation(17);
        }

        private void torInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Toronto_Defiant_Jersey.png", UriKind.Relative));
            teamInformation(18);
        }

        private void vanInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Vancouver_Titans_Jersey.png", UriKind.Relative));
            teamInformation(19);
        }

        private void wasInfo(object sender, DependencyPropertyChangedEventArgs e)
        {
            teamJerseys.Source = new BitmapImage(new Uri(@"jerseysTogether\Washington_Justice_Jersey.png", UriKind.Relative));
            teamInformation(20);
        }
    }
}
