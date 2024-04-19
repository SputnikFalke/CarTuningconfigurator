using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using CarTuningConfigurator.TestFile;
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



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (register == null)
            {
                register = new Register();
            }

            register.Show();
            this.Close();
        }

        private void Log_In(object sender, RoutedEventArgs e)
        {
            User result = controller.checkUser(Username1.Text, Password.Password);
            if (result == null)
            {
                if (Username1.Text == "AddDataAddData")
                {
                    BasicData.AddData addData = new BasicData.AddData();
                }
                if (Username1.Text == "TestTest")
                {
                    TestFile.Test test = new TestFile.Test();
                    test.Message();
                }
                else
                {
                    MessageBox.Show("Anmeldung falsch");
                }

            }
            else
            {
                if (result.Username == "Elia")
                {
                    admin = new Admin();
                    MessageBox.Show("Anmeldung erfolgreich, Chef");
                    admin.Show();
                    this.Close();
                }
                else
                {
                    home = new Home(result.Username);
                    MessageBox.Show("Anmeldung erfolgreich");
                    home.Show();
                    this.Close();
                }
            }
        }

    }
}