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
    /// Interaction logic for DetailAdminAddUser.xaml
    /// </summary>
    public partial class DetailAdminAddUser : Window
    {
        AdminController adminController = new AdminController();
        public DetailAdminAddUser()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if(Username.Text.Length>= 5 && Passowrd.Text.Length>= 5)
            {
                adminController.addUser(Username.Text, Passowrd.Text);
                MessageBox.Show("User erfolgreich hinzugefügt");
                Application.Current.Windows[2].Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[2].Close();
        }
    }
}
