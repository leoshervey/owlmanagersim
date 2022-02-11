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
        public ChooseHero()//int n)
        {
            InitializeComponent();
            //heroRole(n);
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
                    wreckingball.Opacity = 0.4;
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
                    wreckingball.Opacity = 0.4;
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

        private void tank_dva(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_orisa(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_reinhardt(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_roadhog(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_sigma(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_winston(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_wreckingball(object sender, MouseButtonEventArgs e)
        {

        }

        private void tank_zarya(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
