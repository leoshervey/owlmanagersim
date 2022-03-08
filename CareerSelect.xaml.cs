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

        private static int teamChosen;

        public static int teamChoice()
        {
            return teamChosen;
        }
        
        private void atlReignChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 1;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void bstUpChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 2;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void chgHunChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 3;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void dalFueChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 4;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void flrMayhChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 5;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void gzhChrgChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 6;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void hnzSprkChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 7;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void hoUOutChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 8;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void ldnSpfChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 9;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void laGladChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 10;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void laValChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 11;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void nyExlChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 12;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void parEtrnChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 13;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void phlFusChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 14;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void sfShckChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 15;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void shgDragChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 17;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void solDynChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 16;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void trnDefChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 18;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void vanTitnChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 19;
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }

        private void wasJusChoice(object sender, MouseButtonEventArgs e)
        {
            teamChosen = 20;
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
