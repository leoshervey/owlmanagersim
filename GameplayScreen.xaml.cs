using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for GameplayScreen.xaml
    /// </summary>
    public partial class GameplayScreen : Window
    {
        private int _gameday;
        private int _totalUserStrength;
        public GameplayScreen(int gameday, int totalUserStrength)
        {
            InitializeComponent();
            _gameday = gameday;
            _totalUserStrength = totalUserStrength;
            Gameplay gameplay = new Gameplay(gameday, _totalUserStrength, getUserTeamName());
            Title.Content = "Matchday " + gameday;
            back.Visibility = Visibility.Hidden;
            displayResults(gameplay.results, gameplay.userMatch);
        }

        private string getUserTeamName()
        {
            string teamName="";
            int team = CareerSelect.teamChoice();
            switch (team)
                {
                case 1:
                    teamName = "Atlanta Reign";
                    break;
                case 2:
                    teamName = "Boston Uprising";
                    break;
                case 3:
                    teamName = "Chengdu Hunters";
                    break;
                case 4:
                    teamName = "Dallas Fuel";
                    break;
                case 5:
                    teamName = "Florida Mayhem";
                    break;
                case 6:
                    teamName = "Guangzhou Charge";
                    break;
                case 7:
                    teamName = "Hangzhou Spark";
                    break;
                case 8:
                    teamName = "Houston Outlaws";
                    break;
                case 9:
                    teamName = "London Spitfire";
                    break;
                case 10:
                    teamName = "Los Angeles Gladiators";
                    break;
                case 11:
                    teamName = "Los Angeles Valiant";
                    break;
                case 12:
                    teamName = "New York Excelsior";
                    break;
                case 13:
                    teamName = "Paris Eternal";
                    break;
                case 14:
                    teamName = "Philidelphia Fusion";
                    break;
                case 15:
                    teamName = "San Fransisco Shock";
                    break;
                case 16:
                    teamName = "Seoul Dynasty";
                    break;
                case 17:
                    teamName = "Shanghai Dragons";
                    break;
                case 18:
                    teamName = "Toronto Defiant";
                    break;
                case 19:
                    teamName = "Vancouver Titans";
                    break;
                case 20:
                    teamName = "Washington Justice";
                    break;
            }
            return teamName;
        }

        private async Task displayResults(string[] results,int userMatch)
        {
            await Task.Delay(1000);
            label1.Content = "Simulating Match";
            await Task.Delay(250);
            label1.Content = "Simulating Match.";
            await Task.Delay(250);
            label1.Content = "Simulating Match..";
            await Task.Delay(250);
            label1.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 0)
            {
                label1.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1.Content = results[0];
            await Task.Delay(1000);
            label1_Copy.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 1)
            {
                label1_Copy.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy.Content = results[1];
            await Task.Delay(1000);
            label1_Copy1.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy1.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy1.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy1.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 2)
            {
                label1_Copy1.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy1.Content = results[2];
            await Task.Delay(1000);
            label1_Copy2.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy2.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy2.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy2.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 3)
            {
                label1_Copy2.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy2.Content = results[3];
            await Task.Delay(1000);
            label1_Copy3.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy3.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy3.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy3.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 4)
            {
                label1_Copy3.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy3.Content = results[4];
            await Task.Delay(1000);
            label1_Copy4.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy4.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy4.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy4.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 5)
            {
                label1_Copy4.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy4.Content = results[5];
            await Task.Delay(1000);
            label1_Copy5.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy5.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy5.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy5.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 6)
            {
                label1_Copy5.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy5.Content = results[6];
            await Task.Delay(1000);
            label1_Copy6.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy6.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy6.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy6.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 7)
            {
                label1_Copy6.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy6.Content = results[7];
            await Task.Delay(1000);
            label1_Copy7.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy7.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy7.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy7.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 8)
            {
                label1_Copy7.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy7.Content = results[8];
            await Task.Delay(1000);
            label1_Copy8.Content = "Simulating Match";
            await Task.Delay(250);
            label1_Copy8.Content = "Simulating Match.";
            await Task.Delay(250);
            label1_Copy8.Content = "Simulating Match..";
            await Task.Delay(250);
            label1_Copy8.Content = "Simulating Match...";
            await Task.Delay(350);
            if (userMatch == 9)
            {
                label1_Copy8.Background = new SolidColorBrush(Colors.DarkRed);
            }
            label1_Copy8.Content = results[9];
            back.Visibility = Visibility.Visible;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            CareerPage win1 = new CareerPage(_gameday+1,0);
            win1.Show();
            this.Close();
        }
    }
}
