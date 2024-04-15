using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using Microsoft.Win32;
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

namespace CarTuningConfigurator.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        LoginController controller = new LoginController();
        Home home;
        Register register;
        Admin admin;

        public Login()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string result = controller.checkUser(Username1.Text, Password.Password);

            if (result == "user")
            {
                home = new Home();
                MessageBox.Show("Anmeldung erfolgreich");
                home.Show();
                Application.Current.Windows[0].Close();
            }
            else if(result == "admin")
            {
                admin = new Admin();
                MessageBox.Show("Anmeldung erfolgreich, Chef");
                admin.Show();
                Application.Current.Windows[0].Close();
            }
            else
            {
                MessageBox.Show("Anmeldung fehlgeschlagen");
            }
        }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (register == null)
            {
                register = new Register();
            }

            register.Show();
            Application.Current.Windows[0].Close();
        }

    }
}