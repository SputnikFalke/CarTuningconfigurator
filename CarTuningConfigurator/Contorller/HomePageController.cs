using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using CarTuningConfigurator.View;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CarTuningConfigurator.Contorller
{
    class HomePageController
    {
        public List<Car> cars;
        public List<TunningPart> tunningParts;
        private DBConnect DBConnect;
        private CarModel CarModel;

        public HomePageController() 
        {
            DBConnect = new DBConnect();
            cars = DBConnect.GetAllCars();
            tunningParts = DBConnect.GetAllTunningPart();
        }

        public Car updateTunningPartfromCar(Car car, List<TunningPart> tunningParts)
        {
            int horsepower = car.Horsepower;
            double brakeforce = car.Brakeforce;
            double traction = car.Traction;
            double weight = car.Weight;
            int highspeed = car.Highspeed;
            double price = car.Price;
            double acceleration = car.Acceleration;
            CarModel = new CarModel();
            CarModel.updateTunningPartsFromCar(car.Model, tunningParts);

            string img = car.Image.ToString();
            string lilImg = car.LittleImage.ToString();

            foreach(var tunningPart in tunningParts)
            {
                horsepower = horsepower + tunningPart.ChangeOfHorsePower;
                brakeforce = brakeforce + tunningPart.ChangeOfBrakeForce;
                traction = traction + tunningPart.ChangeOfTraction;
                weight = weight + tunningPart.ChangeOfWeight;
                highspeed = highspeed + tunningPart.ChangeOfHighspeed;
                price = price + tunningPart.ChangeOfPrice;
                acceleration = acceleration + tunningPart.ChangeOfAcceleration;
            }
            if(brakeforce > 10)
            {
                brakeforce = 10;
            }
            if(traction > 10)
            {
                traction = 10;
            }
            Car car1 = new Car(car.Model, car.Brand, img, lilImg, horsepower, brakeforce, traction, weight, highspeed, acceleration, price, true, tunningParts);
            return car1;
        }

        public void saveCar(User user, Car car)
        {
            DBConnect.InsertCarToDb(car);
            user.cars.Add(car);
            DBConnect.UpdateCarsFromUser(user, user.cars);         
        }

        public void saveTunnedCar(User user, Car car)
        {
            foreach(var car2 in user.cars)
            {
                if(car2.Model == car.Model)
                {
                    user.cars.Remove(car2);
                    user.cars.Add(car);

                    DBConnect.UpdateCarsFromUser(user, user.cars);
                }
            }
        }

    }
}
