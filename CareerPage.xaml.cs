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
            Logo();
        }
        private void Logo()
        {
            string team;
            team = CareerSelect.teamChoice();
            switch (team)
            {
                case "Atlanta":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Atlanta_Reign_Jersey.png"));
                    break;
                case "Boston":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Boston_Uprising_Jersey.png"));
                    break;
                case "Chengdu":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Chengdu_Hunters_Jersey.png"));
                    break;
                case "Dallas":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Dallas_Fuel_Jersey.png"));
                    break;
                case "Florida":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Florida_Mayhem_Jersey.png"));
                    break;
                case "Guangzhou":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Guangzhou_Charge_Jersey.png"));
                    break;
                case "Hangzhou":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Hangzhou_Spark_Jersey.png"));
                    break;
                case "Houston":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Houston_Outlaws_Jersey.png"));
                    break;
                case "London":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\London_Spitfire_Jersey.png"));
                    break;
                case "Los Angeles Glad":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Los_Angeles_Gladiators_Jersey.png"));
                    break;
                case "Los Angeles Val":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Los_Angeles_Valiant_Jersey.png"));
                    break;
                case "New York":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\New_York_Excelsior_Jersey.png"));
                    break;
                case "Paris":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Paris_Eternal_Jersey.png"));
                    break;
                case "Philadelphia":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Philadelphia_Fusion_Jersey.png"));
                    break;
                case "San Francisco":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\San_Francisco_Shock_Jersey.png"));
                    break;
                case "Seoul":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Seoul_Dynasty_Jersey.png"));
                    break;
                case "Shanghai":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Shanghai_Dragons_Jersey.png"));
                    break;
                case "Toronto":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Toronto_Defiant_Jersey.png"));
                    break;
                case "Vancouver":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Vancouver_Titans_Jersey.png"));
                    break;
                case "Washington":
                    teamJerseys.Source = new BitmapImage(new Uri(@"X:\NEA\Solution\leosherveyNEASolution\jerseysTogether\Washington_Justice_Jersey.png"));
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
            TransferMarket win1 = new TransferMarket();
            win1.Show();
            this.Close();
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
