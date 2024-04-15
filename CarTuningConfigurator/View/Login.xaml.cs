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

        public Login()
        {
            InitializeComponent();
            home = new Home();
            home.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            bool result = controller.checkUser(Username1.Text, Password.Password);
            int count = 0;

            if (result == true)
            {
                if (home == null)
                {
                    home = new Home();
                }
                home = new Home();
                MessageBox.Show("Anmeldung erfolgreich");
                home.Show();
            }
            else
            {
                MessageBox.Show("ups");
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

        private void SaveData(object sender, RoutedEventArgs e)
        { 
            
        }
    }
}