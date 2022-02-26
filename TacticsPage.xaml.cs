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
            string team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case "Atlanta":
                    teamName.Text = team;
                    break;
                case "Boston":
                    teamName.Text = team;
                    break;
                case "Chengdu":
                    teamName.Text = team;
                    break;
                case "Dallas":
                    teamName.Text = team;
                    break;
                case "Florida":
                    teamName.Text = team;
                    break;
                case "Guangzhou":
                    teamName.Text = team;
                    break;
                case "Hangzhou":
                    teamName.Text = team;
                    break;
                case "Houston":
                    teamName.Text = team;
                    break;
                case "London":
                    teamName.Text = team;
                    break;
                case "Los Angeles Glad":
                    teamName.Text = "Gladiators";
                    break;
                case "Los Angeles Val":
                    teamName.Text = "Valiant";
                    break;
                case "New York":
                    teamName.Text = team;
                    break;
                case "Paris":
                    teamName.Text = team;
                    break;
                case "Philadelphia":
                    teamName.Text = "Fusion";
                    break;
                case "San Francisco":
                    teamName.Text = "Shock";
                    break;
                case "Seoul":
                    teamName.Text = team; 
                    break;
                case "Shanghai":
                    teamName.Text = team; 
                    break;
                case "Toronto":
                    teamName.Text = team;
                    break;
                case "Vancouver":
                    teamName.Text = team; 
                    break;
                case "Washington":
                    teamName.Text = team;
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
