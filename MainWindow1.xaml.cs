using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sharon_MidtermV2
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();

        }
        private void RightClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_cust(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You do not have the access to view the Customer Page", "Not A Super User", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn_flight(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You do not have the access to view the Flight Page ", "Not A Super User", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private void btn_airline(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You do not have the access to view the Airline Page", "Not A Super User", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btn_pass(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You do not have the access to view the Passanger Page", "Not A Super User", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void HelpH_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.Background = Brushes.LightPink;
            aw.Title = "Welcome to About Page";
            aw.ShowDialog();
        }


    }
}
