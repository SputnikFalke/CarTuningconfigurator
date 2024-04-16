using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.View;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        AdminController adminController;
        public Admin()
        {
            InitializeComponent();
            adminController = new AdminController();
        }

        private void add_User(object sender, RoutedEventArgs e)
        {
            DetailAdminAddUser detailAdminAddUser = new DetailAdminAddUser();
            detailAdminAddUser.Show();
        }
        private void add_Car(object sender, RoutedEventArgs e)
        {
            DetailAdminAddCar detailAdminAddCar = new DetailAdminAddCar();
            detailAdminAddCar.Show();
        }
        private void add_TunningPart(object sender, RoutedEventArgs e)
        {
            DetailAdminAddTunningPart detailAdminAddTunningPart = new DetailAdminAddTunningPart();
            detailAdminAddTunningPart.Show();
        }
        private void update_User(object sender, RoutedEventArgs e)
        {
            DetailAdminUpdateUser detailAdminUpdateUser = new DetailAdminUpdateUser();
            detailAdminUpdateUser.Show();
        }
        private void update_Car(object sender, RoutedEventArgs e)
        {
            DetailAdminUpdateCar detailAdminUpdateCar = new DetailAdminUpdateCar();
            detailAdminUpdateCar.Show();
        }
        private void update_TunningPart(object sender, RoutedEventArgs e)
        {
            DetailAdminUpdateTunningPart detailAdminUpdateTunningPart = new DetailAdminUpdateTunningPart();
            detailAdminUpdateTunningPart.Show();
        }
        private void delete_User(object sender, RoutedEventArgs e)
        {
            DetailAdminDeleteUser detailAdminDeleteUser = new DetailAdminDeleteUser();
            detailAdminDeleteUser.Show();
        }
        private void delete_Car(object sender, RoutedEventArgs e)
        {
            DetailAdminDeleteCar detailAdminDeleteCar = new DetailAdminDeleteCar();
            detailAdminDeleteCar.Show();
        }
        private void delete_TunningPart(object sender, RoutedEventArgs e)
        {
            DetailAdminDeleteTunningPart detailAdminDeleteTunningPart = new DetailAdminDeleteTunningPart();
            detailAdminDeleteTunningPart.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            MessageBox.Show("Bye Bye Boss");
            login.Show();
            Application.Current.Windows[0].Close();
        }
    }
}
