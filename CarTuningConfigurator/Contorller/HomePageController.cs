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
        private DBConnect DBConnect;
        private CarModel CarModel;

        public HomePageController() 
        {
            DBConnect = new DBConnect();
        }

        public void updateTunningPartfromCar(Car car, List<TunningPart> tunningParts)
        {
            car.tunningParts = tunningParts;
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

        public List<Car> GetAllCars()
        {
            return DBConnect.GetAllCars();
        }

        public List<TunningPart> GetAllTunningParts()
        {
            return DBConnect.GetAllTunningPart();
        }
    }
}
