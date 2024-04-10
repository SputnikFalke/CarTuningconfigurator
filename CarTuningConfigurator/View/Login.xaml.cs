using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.Model;
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

        Home home = new Home();

        public Login()
        {
            InitializeComponent();
            home.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            bool result = controller.checkUser(Username1.Text, Password.Password);
            if(result == true)
            {
                MessageBox.Show("hoi");
            }
            else
            {
                MessageBox.Show("ade");
            }

            
            
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Register register = new Register();
            register.Show();
            //Application.Current.Windows[0].Close();            

            
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
             

        }
    }
}
