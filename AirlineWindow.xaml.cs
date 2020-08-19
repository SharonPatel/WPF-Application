using System;
using System.Collections;
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
    /// Interaction logic for AirlineWindow.xaml
    /// </summary>
    public partial class AirlineWindow : Window
    {
        Queue<Airlines> airline = new Queue<Airlines>();
        public AirlineWindow()
        {
            InitializeComponent();
           airline.Enqueue(new Airlines(airline.Count, "Qatar", "Boeing ", 12, "Chicken"));
            airline.Enqueue(new Airlines(airline.Count, "Singapore ", "Lockheed ", 15, "Shushi"));
            airline.Enqueue(new Airlines(airline.Count, "Emirates", "Cirrus", 18, "Sandwiches"));
            airline.Enqueue(new Airlines(airline.Count, "Qantas", "Learjet", 18, "Pancakes"));


            var display = from air1 in airline
                           select air1;
            lstAirline.DataContext = display;
        }
        private void lstAirline_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstAirline.SelectedIndex;
            var airnames = from air1 in airline
                           where air1.ID == i
                           select air1;
            foreach (var s in airnames)
            {
                txt_name.Text = s.Name;
                
                txt_seats.Text  = Convert.ToString(s.SeatsAvailable);
            
            }
        }

            private void btnAdd_Click(object sender, RoutedEventArgs e)
           {
            if (txt_name.Text == "" || txt_seats.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                
               if(rb1.IsChecked == true && rb1_meal.IsChecked == true) { 
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text , rb1.Content.ToString() ,int.Parse(txt_seats.Text), rb1_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();
                    
                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (rb1.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb1.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (rb2.IsChecked == true && rb1_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb2.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                if (rb2.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb2.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to Add", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (rb1.IsChecked == true && rb1_meal.IsChecked == true)
                {

                    int i = lstAirline.SelectedIndex;
                    


                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                    rb1.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString());


                    var updated = from air1 in airline
                                 select air1;
                   
                    lstAirline.DataContext = updated;       
                    txt_name.Clear();
                    txt_seats.Clear();
                   
                MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }
                if (rb1.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                      rb1.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString());
                    var updated = from air1 in airline
                                  select air1;
                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                if (rb2.IsChecked == true && rb1_meal.IsChecked == true)
                {
                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                      rb2.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString());
                    var updated = from air1 in airline
                                  select air1;
                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                if (rb2.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                      rb2.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString());
                    var updated = from air1 in airline
                                  select air1;
                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to Add", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 

            for (int i = 0; i < airline.Count; i++)
            {
                if (i == lstAirline.SelectedIndex)
                {
                    airline.Dequeue();
                }
                else
                {
                    airline.Enqueue(airline.Dequeue());
                }
                   
                }
                var names = from air1 in airline
                            select air1;

                lstAirline.DataContext = names;

                txt_name.Clear();

                txt_seats.Clear();

                MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Check the inputed format", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void RightClick_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void HelpH_Click(object sender, RoutedEventArgs e)
        {
            
                AboutWindow aw = new AboutWindow();
               aw.Background = Brushes.SeaGreen;
                aw.Title = "Welcome to About Page";
                aw.ShowDialog();
            

        }

        private void MenuItem_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_name.Text == "" || txt_seats.Text == "")
                {
                    MessageBox.Show("No text box can be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (rb1.IsChecked == true && rb1_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb1.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (rb1.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb1.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (rb2.IsChecked == true && rb1_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb2.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                if (rb2.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    airline.Enqueue(new Airlines(airline.Count, txt_name.Text, rb2.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString()));
                    var add = from air1 in airline
                              select air1;

                    lstAirline.DataContext = add;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Airlines details have been successfully added", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to Add", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void MenuItem_Click_Update(object sender, RoutedEventArgs e)
        {

            try
            {
                if (rb1.IsChecked == true && rb1_meal.IsChecked == true)
                {

                    int i = lstAirline.SelectedIndex;



                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                    rb1.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString());


                    var updated = from air1 in airline
                                  select air1;

                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                if (rb1.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                      rb1.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString());
                    var updated = from air1 in airline
                                  select air1;
                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                if (rb2.IsChecked == true && rb1_meal.IsChecked == true)
                {
                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                      rb2.Content.ToString(), int.Parse(txt_seats.Text), rb1_meal.Content.ToString());
                    var updated = from air1 in airline
                                  select air1;
                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                if (rb2.IsChecked == true && rb2_meal.IsChecked == true)
                {
                    Airlines air = new Airlines(lstAirline.SelectedIndex, txt_name.Text,
                      rb2.Content.ToString(), int.Parse(txt_seats.Text), rb2_meal.Content.ToString());
                    var updated = from air1 in airline
                                  select air1;
                    lstAirline.DataContext = updated;
                    txt_name.Clear();
                    txt_seats.Clear();

                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected ", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuItem_Click_Delete(object sender, RoutedEventArgs e)
        {
            try
            {

                for (int i = 0; i < airline.Count; i++)
                {
                    if (i == lstAirline.SelectedIndex)
                    {
                        airline.Dequeue();
                    }
                    else
                    {
                        airline.Enqueue(airline.Dequeue());
                    }
                }
                var names = from air1 in airline
                            select air1;

                lstAirline.DataContext = names;

                txt_name.Clear();

                txt_seats.Clear();

                MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }



    }
}
