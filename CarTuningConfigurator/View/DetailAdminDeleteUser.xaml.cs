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
    /// Interaction logic for DetailAdminDeleteUser.xaml
    /// </summary>
    public partial class DetailAdminDeleteUser : Window
    {
        AdminController adminController = new AdminController();
        public DetailAdminDeleteUser()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            if(adminController.deleteUser(Username.Text) == true)
            {
                MessageBox.Show("User erfolgreich gelöscht");
                Application.Current.Windows[2].Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[2].Close();
        }
    }
}
