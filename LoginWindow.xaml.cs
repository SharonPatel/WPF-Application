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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        List<Login> logins = new List<Login>();
        Dictionary<string, List<Login>> loginCredentials = new Dictionary<string, List<Login>>();
        public LoginWindow()
        {
            InitializeComponent();
            logins.Add(new Login(0, "Sharon", "patel", 1));
            logins.Add(new Login(1, "Patel", "Sharon", 0));
            logins.Add(new Login(0, "Corona", "Virus", 1));
            logins.Add(new Login(1, "jack", "jack123", 0));
            logins.Add(new Login(1, "Nick", "john", 1));



            // Dictionary<string, string> loginCredentials = new Dictionary<string, string>();
            loginCredentials.Add("Sharon",logins);
            loginCredentials.Add("Patel", logins);
            loginCredentials.Add("Corona", logins);
            loginCredentials.Add("jack", logins);
            loginCredentials.Add("Nick", logins);
          

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Boolean found = false;


            foreach (KeyValuePair<string, List<Login>> ele2 in loginCredentials)
            {
                var display = from login1 in logins
                             
                              select login1;
                foreach (var i in display)

                    if (ele2.Key.Equals(txt1.Text) && ele2.Value.Equals(logins))
                    {
                        if (txt1.Text == "Sharon" && txt2.Password == "patel" || txt1.Text == "Corona" && txt2.Password == "Virus"
                            || txt1.Text == "Nick" && txt2.Password == "john")
                        {
                            MainWindow m = new MainWindow();
                            m.Background = Brushes.Yellow;
                            m.Foreground = Brushes.Black;
                            m.Title = "Welcome";
                            m.ShowDialog();
                            found = true;
                            break;
                        }
                       
                     }
                if (ele2.Key.Equals(txt1.Text) && ele2.Value.Equals(logins))
                {
                    if (txt1.Text == "Patel" && txt2.Password == "Sharon" || txt1.Text == "jack" && txt2.Password == "jack123")
                    {
                        MainWindow1 m = new MainWindow1();
                        m.Background = Brushes.Yellow;
                        m.Foreground = Brushes.Black;
                        m.Title = "Welcome";
                        found = true;
                        m.ShowDialog();
                        break;
                    }


                }



            }
           
            if (!found)
            {

                MessageBox.Show("Login Failed", "UserName or Password is not correct",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
           
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
