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
    /// Interaction logic for DetailAdminUpdateCar.xaml
    /// </summary>
    public partial class DetailAdminUpdateCar : Window
    {
        AdminController adminController = new AdminController();
        public DetailAdminUpdateCar()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[2].Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Horsepower.Text, out int horsepower) && double.TryParse(BrakeForce.Text, out double brakeforce) && double.TryParse(Traction.Text, out double traction) && double.TryParse(Weight.Text, out double weight) && int.TryParse(Hightspeed.Text, out int highspeed) && double.TryParse(Acceleration.Text, out double acceleration) && double.TryParse(Price.Text, out double price))
            {
                adminController.updateCar(thisModel.Text, Model.Text, Brand.Text, horsepower, brakeforce, traction, weight, highspeed, acceleration, price, false, null);
                MessageBox.Show("Auto erfolgreich upgedatet");
                Application.Current.Windows[2].Close();
            }
            else
            {
                MessageBox.Show("Auto konnte nicht hinzugefügt werden, achten Sie auf die Datentypen");
            }
        }
    }
}
