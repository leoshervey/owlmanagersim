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
    /// Interaction logic for CareerSelect.xaml
    /// </summary>
    public partial class CareerSelect : Window
    {
        public CareerSelect()
        {
            InitializeComponent();
        }

        private static string teamChosen;

        public static string teamChoice()
        {
            return teamChosen;
        }
        
        private void atlReignChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Atlanta";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void bstUpChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Boston";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void chgHunChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Chengdu";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void dalFueChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Dallas";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void flrMayhChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Florida";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void gzhChrgChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Guangzhou";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void hnzSprkChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Hangzhou";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void hoUOutChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Houston";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void ldnSpfChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "London";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void laGladChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Los Angeles Glad";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void laValChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Los Angeles Val";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void nyExlChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "New York";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void parEtrnChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Paris";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void phlFusChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Philadelphia";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void sfShckChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "San Francisco";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void shgDragChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Shanghai";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void solDynChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Seoul";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void trnDefChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Toronto";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void vanTitnChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Vancouver";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void wasJusChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = "Washington";
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
