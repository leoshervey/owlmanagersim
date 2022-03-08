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
        }

        private void nameOfTeam()
        {
            int team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case 1:
                    teamName.Text = "Atlanta";
                    break;
                case 2:
                    teamName.Text = "Boston";
                    break;
                case 3:
                    teamName.Text = "Chengdu";
                    break;
                case 4:
                    teamName.Text = "Dallas";
                    break;
                case 5:
                    teamName.Text = "Florida";
                    break;
                case 6:
                    teamName.Text = "Guangzhou";
                    break;
                case 7:
                    teamName.Text = "Hangzhou";
                    break;
                case 8:
                    teamName.Text = "Houston";
                    break;
                case 9:
                    teamName.Text = "London";
                    break;
                case 10:
                    teamName.Text = "Gladiators";
                    break;
                case 11:
                    teamName.Text = "Valiant";
                    break;
                case 12:
                    teamName.Text = "New York";
                    break;
                case 13:
                    teamName.Text = "Paris";
                    break;
                case 14:
                    teamName.Text = "Fusion";
                    break;
                case 15:
                    teamName.Text = "Shock";
                    break;
                case 16:
                    teamName.Text = "Seoul"; 
                    break;
                case 17:
                    teamName.Text = "Shanghai"; 
                    break;
                case 18:
                    teamName.Text = "Toronto";
                    break;
                case 19:
                    teamName.Text = "Vancouver"; 
                    break;
                case 20:
                    teamName.Text = "Washington";
                    break;
            }
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

        private void hero1Choice(object sender, MouseButtonEventArgs e)
        {
            ChooseHero win1 = new ChooseHero();
            win1.Show();
        }

        private void hero2Choice(object sender, MouseButtonEventArgs e)
        {
            ChooseHero win1 = new ChooseHero();
            win1.Show();
        }

        private void hero3Choice(object sender, MouseButtonEventArgs e)
        {
            ChooseHero win1 = new ChooseHero();
            win1.Show();
        }

        private void hero4Choice(object sender, MouseButtonEventArgs e)
        {
            ChooseHero win1 = new ChooseHero();
            win1.Show();
        }

        private void hero5Choice(object sender, MouseButtonEventArgs e)
        {
            ChooseHero win1 = new ChooseHero();
            win1.Show();
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
    }
}
