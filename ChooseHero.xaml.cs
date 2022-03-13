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
        public ChooseHero(int role, int selection)
        {
            InitializeComponent();
            heroRole(role);
            selectedHero(selection);
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

        //private void selectPlayer (int hero, int slot)
        //{
        //    switch (hero)
        //    {
        //        case 1:
        //            TacticsPage.h3 = 
        //            break;
        //    }
        //}

        private void dva_Click(object sender, RoutedEventArgs e)
        {
            int choice = 1;
            //selectPlayer(choice, selectedSlot);
            TacticsPage win1 = new TacticsPage();
            win1.Close();
            win1.Show();
            this.Close();
        }

        private void orisa_Click(object sender, RoutedEventArgs e)
        {
            int choice = 2;
        }

        private void reinhardt_Click(object sender, RoutedEventArgs e)
        {
            int choice = 3;
        }

        private void roadhog_Click(object sender, RoutedEventArgs e)
        {
            int choice = 4;
        }

        private void sigma_Click(object sender, RoutedEventArgs e)
        {
            int choice = 5;
        }

        private void winston_Click(object sender, RoutedEventArgs e)
        {
            int choice = 6;
        }

        private void hammond_Click(object sender, RoutedEventArgs e)
        {
            int choice = 7;
        }

        private void zarya_Click(object sender, RoutedEventArgs e)
        {
            int choice = 8;
        }

        private void ashe_Click(object sender, RoutedEventArgs e)
        {
            int choice = 9;
        }

        private void bastion_Click(object sender, RoutedEventArgs e)
        {
            int choice = 10;
        }

        private void cassidy_Click(object sender, RoutedEventArgs e)
        {
            int choice = 11;
        }

        private void doomfist_Click(object sender, RoutedEventArgs e)
        {
            int choice = 12;
        }

        private void echo_Click(object sender, RoutedEventArgs e)
        {
            int choice = 13;
        }

        private void genji_Click(object sender, RoutedEventArgs e)
        {
            int choice = 14;
        }

        private void hanzo_Click(object sender, RoutedEventArgs e)
        {
            int choice = 15;
        }

        private void junkrat_Click(object sender, RoutedEventArgs e)
        {
            int choice = 16;
        }

        private void mei_Click(object sender, RoutedEventArgs e)
        {
            int choice = 17;
        }

        private void pharah_Click(object sender, RoutedEventArgs e)
        {
            int choice = 18;
        }

        private void soldier_Click(object sender, RoutedEventArgs e)
        {
            int choice = 19;
        }

        private void sombra_Click(object sender, RoutedEventArgs e)
        {
            int choice = 20;
        }

        private void symmetra_Click(object sender, RoutedEventArgs e)
        {
            int choice = 21;
        }

        private void torbjorn_Click(object sender, RoutedEventArgs e)
        {
            int choice = 22;
        }

        private void tracer_Click(object sender, RoutedEventArgs e)
        {
            int choice = 23;
        }

        private void widowmaker_Click(object sender, RoutedEventArgs e)
        {
            int choice = 24;
        }

        private void ana_Click(object sender, RoutedEventArgs e)
        {
            int choice = 25;
        }

        private void baptiste_Click(object sender, RoutedEventArgs e)
        {
            int choice = 26;
        }

        private void brigitte_Click(object sender, RoutedEventArgs e)
        {
            int choice = 27;
        }

        private void lucio_Click(object sender, RoutedEventArgs e)
        {
            int choice = 28;
        }

        private void mercy_Click(object sender, RoutedEventArgs e)
        {
            int choice = 29;
        }

        private void moira_Click(object sender, RoutedEventArgs e)
        {
            int choice = 30;
        }

        private void zenyatta_Click(object sender, RoutedEventArgs e)
        {
            int choice = 31;
        }

        private void reaper_Click(object sender, RoutedEventArgs e)
        {
            int choice = 32;
        }
    }
}
