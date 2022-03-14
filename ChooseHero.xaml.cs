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
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void orisa_Click(object sender, RoutedEventArgs e)
        {
            int choice = 2;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void reinhardt_Click(object sender, RoutedEventArgs e)
        {
            int choice = 3;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void roadhog_Click(object sender, RoutedEventArgs e)
        {
            int choice = 4;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void sigma_Click(object sender, RoutedEventArgs e)
        {
            int choice = 5;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void winston_Click(object sender, RoutedEventArgs e)
        {
            int choice = 6;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void hammond_Click(object sender, RoutedEventArgs e)
        {
            int choice = 7;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void zarya_Click(object sender, RoutedEventArgs e)
        {
            int choice = 8;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void ashe_Click(object sender, RoutedEventArgs e)
        {
            int choice = 9;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void bastion_Click(object sender, RoutedEventArgs e)
        {
            int choice = 10;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void cassidy_Click(object sender, RoutedEventArgs e)
        {
            int choice = 11;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void doomfist_Click(object sender, RoutedEventArgs e)
        {
            int choice = 12;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void echo_Click(object sender, RoutedEventArgs e)
        {
            int choice = 13;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void genji_Click(object sender, RoutedEventArgs e)
        {
            int choice = 14;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void hanzo_Click(object sender, RoutedEventArgs e)
        {
            int choice = 15;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void junkrat_Click(object sender, RoutedEventArgs e)
        {
            int choice = 16;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void mei_Click(object sender, RoutedEventArgs e)
        {
            int choice = 17;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void pharah_Click(object sender, RoutedEventArgs e)
        {
            int choice = 18;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void soldier_Click(object sender, RoutedEventArgs e)
        {
            int choice = 19;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void sombra_Click(object sender, RoutedEventArgs e)
        {
            int choice = 20;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void symmetra_Click(object sender, RoutedEventArgs e)
        {
            int choice = 21;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void torbjorn_Click(object sender, RoutedEventArgs e)
        {
            int choice = 22;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void tracer_Click(object sender, RoutedEventArgs e)
        {
            int choice = 23;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void widowmaker_Click(object sender, RoutedEventArgs e)
        {
            int choice = 24;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void ana_Click(object sender, RoutedEventArgs e)
        {
            int choice = 25;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void baptiste_Click(object sender, RoutedEventArgs e)
        {
            int choice = 26;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void brigitte_Click(object sender, RoutedEventArgs e)
        {
            int choice = 27;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void lucio_Click(object sender, RoutedEventArgs e)
        {
            int choice = 28;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void mercy_Click(object sender, RoutedEventArgs e)
        {
            int choice = 29;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void moira_Click(object sender, RoutedEventArgs e)
        {
            int choice = 30;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void zenyatta_Click(object sender, RoutedEventArgs e)
        {
            int choice = 31;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }

        private void reaper_Click(object sender, RoutedEventArgs e)
        {
            int choice = 32;
            TacticsPage tactics = new TacticsPage();
            tactics.heroPicks(choice);
            this.Close();
        }
    }
}
