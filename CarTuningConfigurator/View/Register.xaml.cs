using CarTuningConfigurator.Contorller;
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

namespace CarTuningConfigurator.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        Login login;

        LoginController loginController = new LoginController();

        public Register()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string resultat = loginController.addUser(Username1.Text, Password.Password, ConfirmPasswordT.Password);
            MessageBox.Show(resultat);
            MessageBox.Show(Password.Password);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(login == null)
            {
                login = new Login();
            }
            login.Show();
            Application.Current.Windows[0].Close();
        }
    }
}
