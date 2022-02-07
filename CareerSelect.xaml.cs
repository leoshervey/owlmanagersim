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
        private static string teamChosen = "";
        public static string teamChoice()
        {
            return teamChosen;
        }
        
        private void atlReignChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Atlanta";
        }

        private void bstUpChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Boston";
        }

        private void chgHunChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Chengdu";
        }

        private void dalFueChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Dallas";
        }

        private void flrMayhChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Florida";
        }

        private void gzhChrgChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Guangzhou";
        }

        private void hnzSprkChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Hangzhou";
        }

        private void hoUOutChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Houston";
        }

        private void ldnSpfChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "London";
        }

        private void laGladChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Los Angeles Glad";
        }

        private void laValChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Los Angeles Val";
        }

        private void nyExlChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "New York";
        }

        private void parEtrnChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Paris";
        }

        private void phlFusChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Philadelphia";
        }

        private void sfShckChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "San Francisco";
        }

        private void shgDragChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Shanghai";
        }

        private void solDynChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Seoul";
        }

        private void trnDefChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Toronto";
        }

        private void vanTitnChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Vancouver";
        }

        private void wasJusChoice(object sender, MouseButtonEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
            teamChosen = "Washington";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
