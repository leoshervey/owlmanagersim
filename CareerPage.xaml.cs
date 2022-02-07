using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
            string team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case "Atlanta":
                    teamJerseys.Source = new BitmapImage(new Uri("ms-appx:///Atlanta_Reign_Jersey.png"));
                    break;
                case "Boston":
                    teamJerseys.Source = new BitmapImage(new Uri("ms-appx:///jerseysTogether/Boston_Uprising_Jersey.png"));
                    break;
                case "Chengdu":
                    teamJerseys.Source = new BitmapImage(new Uri("ms-appx:///jerseysTogether/Chengdu_Hunters_Jersey.png"));
                    break;
            }
        }

        private void closeWindow(object sender, RoutedEventArgs e)
        {
            CareerSelect win1 = new CareerSelect();
            win1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TacticsPage win1 = new TacticsPage();
            win1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //SqlConnection conn = new SqlConnection("owl_eng_db");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT team FROM [teams]");
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine("{1}, {0}", reader.GetString(0), reader.GetInt32(1));
            //}
            //reader.Close();
            //conn.Close();

            //if (Debugger.IsAttached)
            //{
            //    Console.ReadLine();
            //}
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
