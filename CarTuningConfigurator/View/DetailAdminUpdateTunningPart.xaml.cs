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
    /// Interaction logic for DetailAdminUpdateTunningPart.xaml
    /// </summary>
    public partial class DetailAdminUpdateTunningPart : Window
    {
        AdminController adminController = new AdminController();
        public DetailAdminUpdateTunningPart()
        {
            InitializeComponent();
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[2].Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ChangeOfHorsepower.Text, out int horsepower) && double.TryParse(ChangeOfBrakeForce.Text, out double brakeforce) && double.TryParse(ChangeOfTraction.Text, out double traction) && double.TryParse(ChangeOfWeight.Text, out double weight) && int.TryParse(ChangeOfHighspeed.Text, out int highspeed) && double.TryParse(ChangeOfAcceleration.Text, out double acceleration) && double.TryParse(ChangeOfPrice.Text, out double price))
            {
                if (Category.Text == "Engine" || Category.Text == "Breaks" || Category.Text == "Wing" || Category.Text == "Turbo" || Category.Text == "Transmission" || Category.Text == "WeightReduction" || Category.Text == "Tires" || Category.Text == "ChipTunning" || Category.Text == "Bodywork")
                {
                    adminController.updateTunningPart(thisName.Text, Name.Text, Category.Text, horsepower, brakeforce, traction, weight, highspeed, acceleration, price);
                    MessageBox.Show("Tunning Part erfolgreich upgedated");
                    Application.Current.Windows[2].Close();
                }
                else
                {
                    MessageBox.Show("Die Kategorien sind: Engine, Breaks, Wing, Turbo, Transmissin, WeightReduction, Tires, ChipTunning, Bodywork");
                }
            }
            else
            {
                MessageBox.Show("Tunning Part konnte nicht upgedated werden, achten Sie auf die Datentypen");
            }
        }
    }
}
