using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using CarTuningConfigurator.View;
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

        public int horsePowerChangeTotal;
        public int brakePowerChangeTotal;
        public int weightChangeTotal;
        public int tractionChangeTotal;
        public int highspeedChangeTotal;
        public int accelerationChangeTotal;
        public int priceChangeTotal;

        TunningPart result = null;
        TunningPart brakesResult = null;
        TunningPart engineResult = null;
        TunningPart TurboResult = null;
        TunningPart WingResult = null;
        TunningPart TiresResult = null;

        HomePageController controller = new HomePageController();
        UserModel UserModel = new UserModel();
        Car currentCar;
        User theUser = null;
        string currentUpgradePanel;
        
        public Home(string username)
        {
            InitializeComponent();
            currentCar = new Car();  
            theUser = UserModel.searchUser(username);


            //
            // This Part renders Cars into the StandartCars View
            List<Car> cars = controller.cars;
            List<TunningPart> tunningParts = controller.tunningParts;


            foreach (Car car in cars)
            {

                if (car.Modified == false)
                {
                    var binding = new Binding("LittleImage");
                    binding.Source = car;
                    var img = new Image();

                    var btn = new Button();
                    btn.Content = img;
                    btn.Height = 150;
                    btn.Width = 150;
                    btn.Margin = new Thickness(10);
                    btn.Click += (s, e) =>
                    { 

                        int zIndex1 = Panel.GetZIndex(StandartCarsPanel);
                        int zIndex2 = Panel.GetZIndex(DetailviewOfCar);
                        Panel.SetZIndex(StandartCarsPanel, zIndex2);
                        Panel.SetZIndex(DetailviewOfCar, zIndex1);

                        var backgroundImagebinding = new Binding("Image");
                        backgroundImagebinding.Source = car;
                        DetailViewBackgroundImage.SetBinding(Image.SourceProperty, backgroundImagebinding);

                        var brandBinding = new Binding("Brand");
                        brandBinding.Source = car;
                        BrandLabel.SetBinding(Label.ContentProperty, brandBinding);

                        var modelBinding = new Binding("Model");
                        modelBinding.Source = car;
                        ModelLabel.SetBinding(Label.ContentProperty, modelBinding);

                        var hpBinding = new Binding("Horsepower");
                        hpBinding.Source = car;
                        HorsePowerLabel.SetBinding(Label.ContentProperty, hpBinding);

                        var bpBinding = new Binding("Breakpower");
                        bpBinding.Source = car;
                        BrakePowerLabel.SetBinding(Label.ContentProperty, bpBinding);

                        var weightBinding = new Binding("Weight");
                        weightBinding.Source = car;
                        WightLabel.SetBinding(Label.ContentProperty, weightBinding);

                        var tractionBinding = new Binding("Traction");
                        tractionBinding.Source = car;
                        TractionLabel.SetBinding(Label.ContentProperty, tractionBinding);

                        var highspeedBinding = new Binding("Highspeed");
                        highspeedBinding.Source = car;
                        HighspeedLabel.SetBinding(Label.ContentProperty, highspeedBinding);

                        var accelerationBinding = new Binding("Acceleration");
                        accelerationBinding.Source = car;
                        AccelerationLabel.SetBinding(Label.ContentProperty, accelerationBinding);

                        var priceBinding = new Binding("Price");
                        priceBinding.Source = car;
                        PriceLabel.SetBinding(Label.ContentProperty, priceBinding);

                    };

                    img.SetBinding(Image.SourceProperty, binding);
                    img.Stretch = Stretch.UniformToFill;
                    HorizontalAlignment = HorizontalAlignment.Center;
                    VerticalAlignment = VerticalAlignment.Center;

                    WrapPanelForStandartCarsImages.Children.Add(btn);
                }
            }
            // End of Render
            //
            // This Part renders Cars into the TunedCars View
            if(theUser != null)
            {
                foreach (Car car in theUser.cars)
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


            
            // End of Render
            //
            // This renders Mods Into the mod list
            
           
        }

        private void ToStandartCars(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(HomePanel);
            int zIndex2 = Panel.GetZIndex(StandartCarsPanel);
            Panel.SetZIndex(HomePanel, zIndex2);
            Panel.SetZIndex(StandartCarsPanel, zIndex1);

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
        }

        private void TunedCarsToMainMenu(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(TunedCarsPanel);
            int zIndex2 = Panel.GetZIndex(HomePanel);
            Panel.SetZIndex(TunedCarsPanel, zIndex2);
            Panel.SetZIndex(HomePanel, zIndex1);
        }

        private void ToDetailView(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(StandartCarsPanel);
            int zIndex2 = Panel.GetZIndex(DetailviewOfCar);
            Panel.SetZIndex(StandartCarsPanel, zIndex2);
            Panel.SetZIndex(DetailviewOfCar, zIndex1);

        }

        private void ToSelectionOfStandartCars(object sender, RoutedEventArgs e)
        {
            int zIndex1 = Panel.GetZIndex(DetailviewOfCar);
            int zIndex2 = Panel.GetZIndex(StandartCarsPanel);
            Panel.SetZIndex(DetailviewOfCar, zIndex2);
            Panel.SetZIndex(StandartCarsPanel, zIndex1);
        }

        private void UpgradeBrakes(object sender, RoutedEventArgs e)
        {
            UpgradeBrake.Visibility = Visibility.Collapsed;
            UpgradesPanel.Visibility = Visibility.Visible;
            int zIndex1 = Panel.GetZIndex(UpgradeBrake);
            int zIndex2 = Panel.GetZIndex(UpgradesPanel);
            Panel.SetZIndex(UpgradesPanel, zIndex2);
            Panel.SetZIndex(UpgradeBrake, zIndex1);

            currentUpgradePanel = "Brakes";
            List<TunningPart> brakes = GetTunningParts("Breaks");
            LoadPanel(brakes);

        }

        private void UpgradeEngine(object sender, RoutedEventArgs e)
        {
            UpgradeBrake.Visibility = Visibility.Collapsed;
            UpgradesPanel.Visibility = Visibility.Visible;
            int zIndex1 = Panel.GetZIndex(UpgradeBrake);
            int zIndex2 = Panel.GetZIndex(UpgradesPanel);
            Panel.SetZIndex(UpgradesPanel, zIndex2);
            Panel.SetZIndex(UpgradeBrake, zIndex1);

            currentUpgradePanel = "Engine";
            List<TunningPart> engines = GetTunningParts("Engine");
            LoadPanel(engines);

        }

        private void UpgradeTurbo(object sender, RoutedEventArgs e)
        {
            UpgradeBrake.Visibility = Visibility.Collapsed;
            UpgradesPanel.Visibility = Visibility.Visible;
            int zIndex1 = Panel.GetZIndex(UpgradeBrake);
            int zIndex2 = Panel.GetZIndex(UpgradesPanel);
            Panel.SetZIndex(UpgradesPanel, zIndex2);
            Panel.SetZIndex(UpgradeBrake, zIndex1);

            currentUpgradePanel = "Turbo";
            List<TunningPart> turbos = GetTunningParts("Turbo");
            LoadPanel(turbos);

        }

        private void UpgradeTires(object sender, RoutedEventArgs e)
        {
            UpgradeBrake.Visibility = Visibility.Collapsed;
            UpgradesPanel.Visibility = Visibility.Visible;
            int zIndex1 = Panel.GetZIndex(UpgradeBrake);
            int zIndex2 = Panel.GetZIndex(UpgradesPanel);
            Panel.SetZIndex(UpgradesPanel, zIndex2);
            Panel.SetZIndex(UpgradeBrake, zIndex1);

            currentUpgradePanel = "Tires";
            List<TunningPart> tires = GetTunningParts("Tires");
            LoadPanel(tires);

        }

        private void UpgradeWing(object sender, RoutedEventArgs e)
        {
            UpgradeBrake.Visibility = Visibility.Collapsed;
            UpgradesPanel.Visibility = Visibility.Visible;
            int zIndex1 = Panel.GetZIndex(UpgradeBrake);
            int zIndex2 = Panel.GetZIndex(UpgradesPanel);
            Panel.SetZIndex(UpgradesPanel, zIndex2);
            Panel.SetZIndex(UpgradeBrake, zIndex1);

            currentUpgradePanel = "Wing";
            List<TunningPart> wings = GetTunningParts("Wing");
            LoadPanel(wings);

        }

        private void GoBackToUpgradeSelection(object sender, RoutedEventArgs e)
        {
            UpgradesPanel.Visibility = Visibility.Collapsed;
            UpgradeBrake.Visibility = Visibility.Visible;
            int zIndex1 = Panel.GetZIndex(UpgradesPanel);
            int zIndex2 = Panel.GetZIndex(UpgradeBrake);
            Panel.SetZIndex(UpgradeBrake, zIndex2);
            Panel.SetZIndex(UpgradesPanel, zIndex1);

        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private List<TunningPart> GetTunningParts(string Category) 
        {
            List<TunningPart> parts = new List<TunningPart>();

            foreach (var part in controller.tunningParts) 
            {
                if (part.Category == Category) 
                {
                    parts.Add(part);
                }
            }

            return parts;
        }

        private void LoadPanel(List<TunningPart> parts)
        {
            warppanelForTuningStages.Children.Clear();
            var value = BrakePowerLabel.Content;
            RadioButton rdbtn;
            

            foreach (TunningPart part in parts)
            {
                rdbtn = new RadioButton();
                
                var breaksBinding = new Binding();
                breaksBinding.Source = part;
                rdbtn.Content = part.Name;
                result = checkSelectedPanel(currentUpgradePanel);
                if (result != null && rdbtn.Content == result.Name) 
                {
                    rdbtn.IsChecked = true;
                }
                else
                {
                    rdbtn.IsChecked = false;
                } 
                rdbtn.Checked += (sender, e) =>
                {
                    horsePowerChangeTotal = part.ChangeOfHorsePower + horsePowerChangeTotal;
                    BrakePowerLabel.Content = value + "+" + horsePowerChangeTotal;
                    result = part;
                    setRightResult(result);
                };
                rdbtn.Unchecked += (sender, e) =>
                {
                    BrakePowerLabel.Content = value;
                };
                
                
                warppanelForTuningStages.Children.Add(rdbtn);
            }
        }

        private void setRightResult(TunningPart result)
        {
            switch(result.Category) 
            {
                case "Breaks":
                    brakesResult = result;
                    break;
                case "Wing":
                    WingResult = result;
                    break;
                case "Engine":
                    engineResult = result;
                    break;
                case "Turbo":
                    TurboResult = result;
                    break;
                case "Tires":
                    TiresResult = result;
                    break;
                default:
                    MessageBox.Show("funktionagled doch nd");
                    break;
            }
        }

        private TunningPart checkSelectedPanel(string currentUpgradePanel)
        {

            switch (currentUpgradePanel)
            {
                case "Brakes":
                    result = brakesResult;
                    break;
                case "Wing":
                    result = WingResult;
                    break;
                case "Engine":
                    result = engineResult;
                    break;
                case "Turbo":
                    result = TurboResult;
                    break;
                case "Tires":
                    result = TiresResult;
                    break;
                default: 
                    result = null; 
                    break;
            }

            return result;
        }

        private void Save_Car(object sender, RoutedEventArgs e)
        {
            currentCar.Modified = true;
            controller.saveCar(theUser, currentCar);
        }

        private void Save_Tunned_Car(object sender, RoutedEventArgs e)
        {
            controller.saveTunnedCar(theUser, currentCar);
        }

    }

}