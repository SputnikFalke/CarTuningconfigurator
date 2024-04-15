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
    /// Interaction logic for DetailAdminDeleteCar.xaml
    /// </summary>
    public partial class DetailAdminDeleteCar : Window
    {
        AdminController adminController = new AdminController();
        public DetailAdminDeleteCar()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            if (adminController.deleteCar(Model.Text) == true)
            {
                MessageBox.Show("Auto erfolgreich gelöscht");
                Application.Current.Windows[2].Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[2].Close();
        }
    }
}
