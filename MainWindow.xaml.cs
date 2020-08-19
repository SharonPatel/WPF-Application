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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sharon_MidtermV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Login> logins = new List<Login>();
        Dictionary<string, string> loginCredentials = new Dictionary<string, string>();
        Login log = new Login();

        public MainWindow()
        {
            InitializeComponent();
            logins.Add(new Login(0, "Sharon", "patel", 1));
            logins.Add(new Login(1, "Patel", "Sharon", 0));


            // Dictionary<string, string> loginCredentials = new Dictionary<string, string>();
            loginCredentials.Add("Sharon", "patel");
            loginCredentials.Add("Patel", "Sharon");
            //var display = from p1 in 

            //              select p1;
            //lstMain.DataContext = display;
        }





        private void btn_Customer_Click(object sender, RoutedEventArgs e)
        {
            var display = from p1 in logins
                          select p1;
            // lstMain.DataContext = display;



            CustomerWindow cw = new CustomerWindow();
            cw.Background = Brushes.Gray;
            cw.Foreground = Brushes.Black;
            cw.Title = "Welcome to the Customer Page";
            cw.ShowDialog();

        }

        private void btn_Flight_Click(object sender, RoutedEventArgs e)
        {
            FlightWindow fw = new FlightWindow();
            fw.Background = Brushes.Black;
            fw.Foreground = Brushes.White;
            fw.Title = "Welcome to Flight Page";
            fw.ShowDialog();

        }

        private void btn_Airlines_Click(object sender, RoutedEventArgs e)
        {
            AirlineWindow aw = new AirlineWindow();
            aw.Background = Brushes.Blue;
            aw.Foreground = Brushes.White;
            aw.Title = "Welcome to Airline Page";
            aw.ShowDialog();
        }

        private void btn_Passanger_Click(object sender, RoutedEventArgs e)
        {
            PassangerWindow pw = new PassangerWindow();
            pw.Background = Brushes.LightPink;
            pw.Title = "Welcome to Airline Page";
            pw.ShowDialog();
        }

        private void RightClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to exit", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else if (result == MessageBoxResult.Yes)
            {
                e.Cancel = false;
           
            }
        }

        private void HelpH_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.Background = Brushes.LightPink;
            aw.Title = "Welcome to About Page";
            aw.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }

                

    }

