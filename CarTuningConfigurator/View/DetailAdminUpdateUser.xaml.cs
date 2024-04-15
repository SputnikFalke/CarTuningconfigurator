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
using System.Windows.Shapes;

namespace CarTuningConfigurator.View
{
    /// <summary>
    /// Interaction logic for DetailAdminUpdateUser.xaml
    /// </summary>
    public partial class DetailAdminUpdateUser : Window
    {
        AdminController adminController = new AdminController();
        public DetailAdminUpdateUser()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[2].Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (NewUsername.Text.Length >= 5 && NewPassowrd.Text.Length >= 5)
            {
                adminController.updateUser(Username.Text, NewUsername.Text, NewPassowrd.Text);
                MessageBox.Show("User erfolgreich updgedatet");
                Application.Current.Windows[2].Close();
            }
        }
    }
}
