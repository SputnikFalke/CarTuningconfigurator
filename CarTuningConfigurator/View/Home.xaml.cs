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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        public void addImage()
        {
            
        }

        private void ToStandartCars(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(HomePanel);
            int zIndex2 = Panel.GetZIndex(StandartCarsPanel);
            Panel.SetZIndex(HomePanel, zIndex2);
            Panel.SetZIndex(StandartCarsPanel, zIndex1);

        }
    }
}
