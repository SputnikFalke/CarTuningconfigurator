using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        HomePageController controller = new HomePageController();
        public Home()
        {
            InitializeComponent();
        }

        private void ToStandartCars(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(HomePanel);
            int zIndex2 = Panel.GetZIndex(StandartCarsPanel);
            Panel.SetZIndex(HomePanel, zIndex2);
            Panel.SetZIndex(StandartCarsPanel, zIndex1);
            List<Car> cars = controller.cars;

            foreach (Car car in cars)
            {

                if (car.Modified == false)
                {
                    var binding = new Binding("Image");
                    binding.Source = car;
                    var img = new Image();

                    var btn = new Button();
                    btn.Content = img;
                    btn.Height = 150;
                    btn.Width = 150;
                    btn.Margin = new Thickness(10);
                    btn.Click += (s, e) =>
                    {
                        MessageBox.Show("Funktioniert so wiit");
                    };

                    img.SetBinding(Image.SourceProperty, binding);
                    img.Stretch = Stretch.UniformToFill;
                    HorizontalAlignment = HorizontalAlignment.Center;
                    VerticalAlignment = VerticalAlignment.Center;

                    WrapPanelForStandartCarsImages.Children.Add(btn);
                }
            }
        }

        private void StandartCarsToMainMenu(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(StandartCarsPanel);
            int zIndex2 = Panel.GetZIndex(HomePanel);
            Panel.SetZIndex(StandartCarsPanel, zIndex2);
            Panel.SetZIndex(HomePanel, zIndex1);
        }

        private void ToTunedCars(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(HomePanel);
            int zIndex2 = Panel.GetZIndex(TunedCarsPanel);
            Panel.SetZIndex(HomePanel, zIndex2);
            Panel.SetZIndex(TunedCarsPanel, zIndex1);
            List<Car> cars = controller.cars;

            foreach (Car car in cars)
            {

                if (car.Modified == true)
                {
                    var binding = new Binding("Image");
                    binding.Source = car;
                    var img = new Image();

                    var btn = new Button();
                    btn.Content = img;
                    btn.Height = 150;
                    btn.Width = 150;
                    btn.Margin = new Thickness(10);
                    btn.Click += (s, e) =>
                    {
                        MessageBox.Show("Funktioniert so wiit");
                    };

                    img.SetBinding(Image.SourceProperty, binding);
                    img.Stretch = Stretch.UniformToFill;
                    HorizontalAlignment = HorizontalAlignment.Center;
                    VerticalAlignment = VerticalAlignment.Center;

                    WrapPanelForStandartCarsImages.Children.Add(btn);
                }
            }
        }

        private void TunedCarsToMainMenu(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(TunedCarsPanel);
            int zIndex2 = Panel.GetZIndex(HomePanel);
            Panel.SetZIndex(TunedCarsPanel, zIndex2);
            Panel.SetZIndex(HomePanel, zIndex1);
        }

    }
}