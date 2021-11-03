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
    /// Interaction logic for CareerPage.xaml
    /// </summary>
    public partial class CareerPage : Window
    {
        public CareerPage()
        {
            InitializeComponent();
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int team1 = 500, team2 = 500;
            Gameplay gameplay = new Gameplay();
            string text = gameplay.winLoss(team1, team2);
            tbxMessageTest.Text = (text);            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
