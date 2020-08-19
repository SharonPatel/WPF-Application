using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for Passanger.xaml
    /// </summary>
    public partial class PassangerWindow : Window
    {
        Stack<Passanger> passanger = new Stack<Passanger>();
       
      
        public PassangerWindow()
        {
            InitializeComponent();


            passanger.Push(new Passanger(4, 4, 3));
            passanger.Push(new Passanger(3, 3, 1));
            passanger.Push(new Passanger(2, 1, 2));
             passanger.Push(new Passanger(1, 0, 0));



            var display = from pass1 in passanger
                          select pass1;
            lstPassanger.DataContext = display;



        }

        private void lstPassanger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstPassanger.SelectedIndex;
            var display = from pass1 in passanger
                          where pass1.ID == i
                          select pass1;
            foreach (var s in display)
            {
                txt_custId.Text = s.CustomerID.ToString();
                txt_flightID.Text = s.FlightID.ToString();
                
            }
        }

            private void btnAdd_Click(object sender, RoutedEventArgs e)
          {
            try
            {
                if (txt_custId.Text == "" || txt_flightID.Text == "")

                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    passanger.Push(new Passanger(passanger.Count, int.Parse(txt_custId.Text), int.Parse(txt_flightID.Text)));


                    var add = from pass1 in passanger
                              select pass1;

                    lstPassanger.DataContext = add;

                    txt_custId.Clear();
                    txt_flightID.Clear();
                    MessageBox.Show("Changes have been made!", "Added Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select the list box the text box are empty", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_custId.Text == "" || txt_flightID.Text == "")
                {
                    MessageBox.Show("Textbox are empty", "Try Again", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    Passanger pass = new Passanger(lstPassanger.SelectedIndex, int.Parse(txt_custId.Text),
                        int.Parse(txt_flightID.Text));


                    //passanger[lstPassanger.SelectedIndex] = pass;

                    var update = from pass1 in passanger
                                 select pass1;
                    lstPassanger.DataContext = update;

                    txt_custId.Clear();
                    txt_flightID.Clear();
                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Please select the list box the text box are empty", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_custId.Text == "" || txt_flightID.Text == "")
                {
                    MessageBox.Show("Textbox are empty", "Try Again", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {

                    for (int i = 0; i < passanger.Count; i++)
                    {
                        if (i == lstPassanger.SelectedIndex)
                        {
                            passanger.Pop();
                        }
                        else
                        {
                            passanger.Push(passanger.Pop());
                        }


                    }
                    var delete = from pass1 in passanger
                                 select pass1;
                    lstPassanger.DataContext = delete;


                    txt_custId.Clear();
                    txt_flightID.Clear();

                    MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);

                    
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to Add", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
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
            try
            {
                if (txt_custId.Text == "" || txt_flightID.Text == "")

                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    passanger.Push(new Passanger(passanger.Count, int.Parse(txt_custId.Text), int.Parse(txt_flightID.Text)));


                    var add = from pass1 in passanger
                              select pass1;

                    lstPassanger.DataContext = add;

                    txt_custId.Clear();
                    txt_flightID.Clear();
                    MessageBox.Show("Changes have been made!", "Added Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select the list box the text box are empty", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuItem_Click_Update(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_custId.Text == "" || txt_flightID.Text == "")
                {
                    MessageBox.Show("Textbox are empty", "Try Again", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    Passanger pass = new Passanger(lstPassanger.SelectedIndex, int.Parse(txt_custId.Text),
                        int.Parse(txt_flightID.Text));


                    //passanger[lstPassanger.SelectedIndex] = pass;

                    var update = from pass1 in passanger
                                 select pass1;
                    lstPassanger.DataContext = update;

                    txt_custId.Clear();
                    txt_flightID.Clear();
                    MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to update or textbox are empty", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void MenuItem_Click_Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_custId.Text == "" || txt_flightID.Text == "")
                {
                    MessageBox.Show("Textbox are empty", "Try Again", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {

                    for (int i = 0; i < passanger.Count; i++)
                    {
                        if (i == lstPassanger.SelectedIndex)
                        {
                            passanger.Pop();
                        }
                        else
                        {
                            passanger.Push(passanger.Pop());
                        }
                    }
                    var delete = from pass1 in passanger
                                 select pass1;

                    lstPassanger.DataContext = delete;

                    txt_custId.Clear();
                    txt_flightID.Clear();

                    MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected to delete", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }




    }
}

