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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        List<Customer> customerDetails = new List<Customer>();
        public CustomerWindow()
        {
            InitializeComponent();
            customerDetails.Add(new Customer(customerDetails.Count, "Sharon", "brampton", "abc@gmail.com", "2345672"));
            customerDetails.Add(new Customer(customerDetails.Count, "Deep", "New-York", "xyz@gmail.com", "4556565"));
            customerDetails.Add(new Customer(customerDetails.Count, "Deep", "New-York", "xyz@gmail.com", "4556565"));
            customerDetails.Add(new Customer(customerDetails.Count, "Deep", "New-York", "xyz@gmail.com", "4556565"));
            customerDetails.Add(new Customer(customerDetails.Count, "Smiley", "Missisagua", "ewr@gmail.com", "4566664"));
            customerDetails.Add(new Customer(customerDetails.Count, "Sweety", "Etobicoke", "trgt@gmail.com", "565644"));
            customerDetails.Add(new Customer(customerDetails.Count, "Sanjay", "brampton", "ert@gmail.com", "4567765"));

            var names = from cust1 in customerDetails
                        select cust1;

            lstCustomer.DataContext = names;
        }
        private void lstCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstCustomer.SelectedIndex;
            var selectedCrew = from cust1 in customerDetails
                               where cust1.ID == i
                               select cust1;

            foreach (var s in selectedCrew)
            {
                custName.Text = s.Name;
                custAdd.Text = s.Address;
                custEmail.Text = s.Email;
                custPhone.Text = s.Phone;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (custName.Text == "" || custAdd.Text == "" ||
               custEmail.Text == "" || custPhone.Text == "")
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                customerDetails.Add(new Customer(customerDetails.Count, custName.Text,
                            custAdd.Text, custEmail.Text,
                            custPhone.Text));

                var names = from cust1 in customerDetails
                            select cust1;

                lstCustomer.DataContext = names;

                custName.Clear();
                custAdd.Clear();
                custEmail.Clear();
                custPhone.Clear();
                MessageBox.Show("Changes have been made!", "Added Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        } catch (FormatException)
            {
                MessageBox.Show("No rows are selected", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }



        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer cust = new Customer(lstCustomer.SelectedIndex, custName.Text,
                    custAdd.Text, custEmail.Text, custPhone.Text);

               customerDetails[lstCustomer.SelectedIndex] = cust;

                var names = from cust1 in customerDetails
                            select cust1;
                lstCustomer.DataContext = names;

                custName.Clear();
                custAdd.Clear();
                custEmail.Clear();
                custPhone.Clear();
                MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
         
            try {

                customerDetails.RemoveAt(lstCustomer.SelectedIndex);

                for (int i = 0; i < customerDetails.Count; i++)
                    customerDetails[i].ID = i;

                var names = from cust1 in customerDetails
                            select cust1;

                lstCustomer.DataContext = names;

                custName.Clear();
                custAdd.Clear();
                custEmail.Clear();
                custPhone.Clear();
                MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (FormatException)
            {
                MessageBox.Show("Check the entered data", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
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
            aw.Background = Brushes.LightPink;
            aw.Title = "Welcome to About Page";
            aw.ShowDialog();

        }

        private void MenuItem_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                if (custName.Text == "" || custAdd.Text == "" ||
                   custEmail.Text == "" || custPhone.Text == "")
                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    customerDetails.Add(new Customer(customerDetails.Count, custName.Text,
                                custAdd.Text, custEmail.Text,
                                custPhone.Text));

                    var names = from cust1 in customerDetails
                                select cust1;

                    lstCustomer.DataContext = names;

                    custName.Clear();
                    custAdd.Clear();
                    custEmail.Clear();
                    custPhone.Clear();
                    MessageBox.Show("Changes have been made!", "Added Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("No rows are selected ", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuItem_Click_Update(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer cust = new Customer(lstCustomer.SelectedIndex, custName.Text,
                    custAdd.Text, custEmail.Text, custPhone.Text);

                customerDetails[lstCustomer.SelectedIndex] = cust;

                var names = from cust1 in customerDetails
                            select cust1;
                lstCustomer.DataContext = names;

                custName.Clear();
                custAdd.Clear();
                custEmail.Clear();
                custPhone.Clear();
                MessageBox.Show("Changes have been made!", "Updated Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void MenuItem_Click_Delete(object sender, RoutedEventArgs e)
        {
            try
            {

                customerDetails.RemoveAt(lstCustomer.SelectedIndex);

                for (int i = 0; i < customerDetails.Count; i++)
                    customerDetails[i].ID = i;

                var names = from cust1 in customerDetails
                            select cust1;

                lstCustomer.DataContext = names;

                custName.Clear();
                custAdd.Clear();
                custEmail.Clear();
                custPhone.Clear();
                MessageBox.Show("Changes have been made!", "Deleted Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No rows are selected", "Try again", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


    }
}
