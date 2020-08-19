using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        List<Flights> flights = new List<Flights>();
        List<Airlines> air = new List<Airlines>();
        public FlightWindow()
        {
            InitializeComponent();
            flights.Add(new Flights(flights.Count, air.Count , "Brampton", "London", "12-09-2020", 14.20));
            flights.Add(new Flights(flights.Count, air.Count, "Newyork", "London", "21-10-2020", 1.20));
            flights.Add(new Flights(flights.Count, air.Count, "Etobicoke", "Missisagua", "2-01-2019", 16));
            flights.Add(new Flights(flights.Count, air.Count, "Brampton", "London", "12-12-2020", 12));

            var names = from flight1 in flights
                        select flight1;

            lstFlight.DataContext = names;

        }
        private void lstFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try { 
            int i = lstFlight.SelectedIndex;
            var selectedFlight = from flight1 in flights
                                 where flight1.ID == i
                                 select flight1;


            foreach (var s in selectedFlight)
            {
                txt_city.Text = s.DepartureCity;
                txt_dest.Text = s.DestinationCity;
                txt_date.Text = s.DepartureDate;
                txt_time.Text = s.FlightTime.ToString();
            }
           }catch (FormatException)
            {
                MessageBox.Show("No rows are selected to Add", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try { 
            try
            {
                if (txt_city.Text == "" || txt_dest.Text == "" ||
                  txt_date.Text == "" || txt_time.Text == "")
                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    flights.Add(new Flights(flights.Count, air.Count, txt_city.Text,
                                txt_dest.Text, txt_date.Text,
                                double.Parse(txt_time.Text)));

                    var insert = from flight1 in flights
                                 select flight1;

                    lstFlight.DataContext = insert;

                    txt_city.Clear();
                    txt_dest.Clear();
                    txt_date.Clear();
                    txt_time.Clear();
                    MessageBox.Show("Changes have been made!", "Added Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Time is invalid please add proper value", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        } catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected or Invalid Time", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    Flights fli = new Flights(lstFlight.SelectedIndex, air.Count, txt_city.Text,
                                txt_dest.Text, txt_date.Text,
                                double.Parse(txt_time.Text));



                    flights[lstFlight.SelectedIndex] = fli;

                    var update = from flight1 in flights
                                 select flight1;
                    lstFlight.DataContext = update;

                    txt_city.Clear();
                    txt_dest.Clear();
                    txt_date.Clear();
                    txt_time.Clear();
                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("No rows are selected to update", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected or Invalid Time", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    flights.RemoveAt(lstFlight.SelectedIndex);

                    // reorder ID's - not good practise but needed to avoid breaking this app
                    for (int i = 0; i < flights.Count; i++)
                        flights[i].ID = i;

                    var delete = from flight1 in flights
                                 select flight1;

                    lstFlight.DataContext = delete;

                    txt_city.Clear();
                    txt_dest.Clear();
                    txt_date.Clear();
                    txt_time.Clear();
                    MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Time is invalid", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected to delete or Invalid Time", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        
            

}

        private void RightClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void HelpH_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.Background = Brushes.LightPink;
            aw.Title = "Welcome to About Page";
            aw.ShowDialog();

        }

        private void MenuItem_Add(object sender, RoutedEventArgs e)
        {
            try { 
            try
            {
                if (txt_city.Text == "" || txt_dest.Text == "" ||
                  txt_date.Text == "" || txt_time.Text == "")
                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    flights.Add(new Flights(flights.Count, air.Count, txt_city.Text,
                                txt_dest.Text, txt_date.Text,
                                double.Parse(txt_time.Text)));

                    var insert = from flight1 in flights
                                 select flight1;

                    lstFlight.DataContext = insert;

                    txt_city.Clear();
                    txt_dest.Clear();
                    txt_date.Clear();
                    txt_time.Clear();
                    MessageBox.Show("Changes have been made!", "Added Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Time is invalid please add proper value", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected  or Invalid Time", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
}

        private void MenuItem_Click_Update(object sender, RoutedEventArgs e)
        {
            try { 
            try
            {
                Flights fli = new Flights(lstFlight.SelectedIndex, air.Count, txt_city.Text,
                            txt_dest.Text, txt_date.Text,
                            double.Parse(txt_time.Text));



                flights[lstFlight.SelectedIndex] = fli;

                var update = from flight1 in flights
                             select flight1;
                lstFlight.DataContext = update;

                txt_city.Clear();
                txt_dest.Clear();
                txt_date.Clear();
                txt_time.Clear();
                MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to update", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected or Invalid Time", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

}

        private void MenuItem_Click_Delete(object sender, RoutedEventArgs e)
        {
            try { 
            try
            {
                flights.RemoveAt(lstFlight.SelectedIndex);

                // reorder ID's - not good practise but needed to avoid breaking this app
                for (int i = 0; i < flights.Count; i++)
                    flights[i].ID = i;

                var delete = from flight1 in flights
                             select flight1;

                lstFlight.DataContext = delete;

                txt_city.Clear();
                txt_dest.Clear();
                txt_date.Clear();
                txt_time.Clear();
                MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to delete", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected to delete ", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
}

    }
}
