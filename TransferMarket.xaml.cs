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
    /// Interaction logic for TransferMarket.xaml
    /// </summary>
    public partial class TransferMarket : Window
    {
        public TransferMarket()
        {
            InitializeComponent();
            Logo();
        }

        private void Logo()
        {
            string team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case "Atlanta":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\ATL.png"));
                    break;
                case "Boston":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\BST.png"));
                    break;
                case "Chengdu":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\CNG.png"));
                    break;
                case "Dallas":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\DLS.png"));
                    break;
                case "Florida":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\FLR.png"));
                    break;
                case "Guangzhou":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\GNZ.png"));
                    break;
                case "Hangzhou":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\HNZ.png"));
                    break;
                case "Houston":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\HOU.png"));
                    break;
                case "London":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LDN.png"));
                    break;
                case "Los Angeles Glad":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LGL.png"));
                    break;
                case "Los Angeles Val":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\LVA.png"));
                    break;
                case "New York":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\NYE.png"));
                    break;
                case "Paris":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\PAR.png"));
                    break;
                case "Philadelphia":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\PHL.png"));
                    break;
                case "San Francisco":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SFS.png"));
                    break;
                case "Seoul":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SHD.png"));
                    break;
                case "Shanghai":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\SLD.png"));
                    break;
                case "Toronto":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\TOR.png"));
                    break;
                case "Vancouver":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\VNC.png"));
                    break;
                case "Washington":
                    badge.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\teamBadges\WAS.png"));
                    break;
            }
        }

        private void transferList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //database tables Players and Staff
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            CareerPage win1 = new CareerPage();
            win1.Show();
            this.Close();
        }
    }
}
