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
    /// Interaction logic for ChooseHero.xaml
    /// </summary>
    public partial class ChooseHero : Window
    {

        public string choice { get; private set; }

        public ChooseHero(int role)
        {
            InitializeComponent();
            heroRole(role);
        }

        private int selectedSlot;

        private void selectedHero(int selection)
        {
            selectedSlot = selection;
        }

        private void heroRole(int role)
        {
            switch (role)
            {
                case 1:
                    dva.Opacity = 0.4;
                    orisa.Opacity = 0.4;
                    reinhardt.Opacity = 0.4;
                    roadhog.Opacity = 0.4;
                    sigma.Opacity = 0.4;
                    winston.Opacity = 0.4;
                    hammond.Opacity = 0.4;
                    zarya.Opacity = 0.4;
                    ana.Opacity = 0.4;
                    baptiste.Opacity = 0.4;
                    brigitte.Opacity = 0.4;
                    lucio.Opacity = 0.4;
                    mercy.Opacity = 0.4;
                    moira.Opacity = 0.4;
                    zenyatta.Opacity = 0.4;
                    break;
                case 2:
                    ashe.Opacity = 0.4;
                    bastion.Opacity = 0.4;
                    cassidy.Opacity = 0.4;
                    doomfist.Opacity = 0.4;
                    echo.Opacity = 0.4;
                    genji.Opacity = 0.4;
                    hanzo.Opacity = 0.4;
                    junkrat.Opacity = 0.4;
                    mei.Opacity = 0.4;
                    pharah.Opacity = 0.4;
                    reaper.Opacity = 0.4;
                    soldier.Opacity = 0.4;
                    sombra.Opacity = 0.4;
                    symmetra.Opacity = 0.4;
                    torbjorn.Opacity = 0.4;
                    tracer.Opacity = 0.4;
                    widowmaker.Opacity = 0.4;
                    ana.Opacity = 0.4;
                    baptiste.Opacity = 0.4;
                    brigitte.Opacity = 0.4;
                    lucio.Opacity = 0.4;
                    mercy.Opacity = 0.4;
                    moira.Opacity = 0.4;
                    zenyatta.Opacity = 0.4;
                    break;
                case 3:
                    dva.Opacity = 0.4;
                    orisa.Opacity = 0.4;
                    reinhardt.Opacity = 0.4;
                    roadhog.Opacity = 0.4;
                    sigma.Opacity = 0.4;
                    winston.Opacity = 0.4;
                    hammond.Opacity = 0.4;
                    zarya.Opacity = 0.4;
                    ashe.Opacity = 0.4;
                    bastion.Opacity = 0.4;
                    cassidy.Opacity = 0.4;
                    doomfist.Opacity = 0.4;
                    echo.Opacity = 0.4;
                    genji.Opacity = 0.4;
                    hanzo.Opacity = 0.4;
                    junkrat.Opacity = 0.4;
                    mei.Opacity = 0.4;
                    pharah.Opacity = 0.4;
                    reaper.Opacity = 0.4;
                    soldier.Opacity = 0.4;
                    sombra.Opacity = 0.4;
                    symmetra.Opacity = 0.4;
                    torbjorn.Opacity = 0.4;
                    tracer.Opacity = 0.4;
                    widowmaker.Opacity = 0.4;
                    break;
            }
        }
        

        private string getSelectedHero()
        {
            return choice;
        }

        private void dva_Click(object sender, RoutedEventArgs e)
        {
            choice = "7";
            this.Close();
        }

        private void orisa_Click(object sender, RoutedEventArgs e)
        {
            choice = "17";
            this.Close();
        }

        private void reinhardt_Click(object sender, RoutedEventArgs e)
        {
            choice = "20";
            this.Close();
        }

        private void roadhog_Click(object sender, RoutedEventArgs e)
        {
            choice = "21";
            this.Close();
        }

        private void sigma_Click(object sender, RoutedEventArgs e)
        {
            choice = "22";
            this.Close();
        }

        private void winston_Click(object sender, RoutedEventArgs e)
        {
            choice = "29";
            this.Close();
        }

        private void hammond_Click(object sender, RoutedEventArgs e)
        {
            choice = "30";
            this.Close();
        }

        private void zarya_Click(object sender, RoutedEventArgs e)
        {
            choice = "31";
            this.Close();
        }

        private void ashe_Click(object sender, RoutedEventArgs e)
        {
            choice = "2";
            this.Close();
        }

        private void bastion_Click(object sender, RoutedEventArgs e)
        {
            choice = "4";
            this.Close();
        }

        private void cassidy_Click(object sender, RoutedEventArgs e)
        {
            choice = "6";
            this.Close();
        }

        private void doomfist_Click(object sender, RoutedEventArgs e)
        {
            choice = "8";
            this.Close();
        }

        private void echo_Click(object sender, RoutedEventArgs e)
        {
            choice = "9";
            this.Close();
        }

        private void genji_Click(object sender, RoutedEventArgs e)
        {
            choice = "10";
            this.Close();
        }

        private void hanzo_Click(object sender, RoutedEventArgs e)
        {
            choice = "11";
            this.Close();
        }

        private void junkrat_Click(object sender, RoutedEventArgs e)
        {
            choice = "12";
            this.Close();
        }

        private void mei_Click(object sender, RoutedEventArgs e)
        {
            choice = "14";
            this.Close();
        }

        private void pharah_Click(object sender, RoutedEventArgs e)
        {
            choice = "18";
            this.Close();
        }

        private void soldier_Click(object sender, RoutedEventArgs e)
        {
            choice = "23";
            this.Close();
        }

        private void sombra_Click(object sender, RoutedEventArgs e)
        {
            choice = "24";
            this.Close();
        }

        private void symmetra_Click(object sender, RoutedEventArgs e)
        {
            choice = "25";
            this.Close();
        }

        private void torbjorn_Click(object sender, RoutedEventArgs e)
        {
            choice = "26";
            this.Close();
        }

        private void tracer_Click(object sender, RoutedEventArgs e)
        {
            choice = "27";
            this.Close();
        }

        private void widowmaker_Click(object sender, RoutedEventArgs e)
        {
            choice = "28";
            this.Close();
        }

        private void ana_Click(object sender, RoutedEventArgs e)
        {
            choice = "1";
            this.Close();
        }

        private void baptiste_Click(object sender, RoutedEventArgs e)
        {
            choice = "3";
            this.Close();
        }

        private void brigitte_Click(object sender, RoutedEventArgs e)
        {
            choice = "5";
            this.Close();
        }

        private void lucio_Click(object sender, RoutedEventArgs e)
        {
            choice = "13";
            this.Close();
        }

        private void mercy_Click(object sender, RoutedEventArgs e)
        {
            choice = "15";
            this.Close();
        }

        private void moira_Click(object sender, RoutedEventArgs e)
        {
            choice = "16";
            this.Close();
        }

        private void zenyatta_Click(object sender, RoutedEventArgs e)
        {
            choice = "32";
            this.Close();
        }

        private void reaper_Click(object sender, RoutedEventArgs e)
        {
            choice = "19";
            this.Close();
        }
    }
}
