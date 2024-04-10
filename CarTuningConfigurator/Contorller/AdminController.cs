using CarTuningConfigurator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Contorller
{
    internal class AdminController
    {
        CarModel carModel = new CarModel();
        TunningPartModel tunningPartModel = new TunningPartModel();

        public void addCar(string model, string brand, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, List<TunningPart> tunningParts)
        {
            Car car = new Car(model, brand, horsepower, brakeforce, traction, weight, highspeed, acceleration, price, tunningParts);
            carModel.addCar(car);
        }
        public Car searchCar(string model)
        {
            Car car = carModel.searchCar(model);
            return car;
        }
        public void updateCar(string thisModel, string model, string brand, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, List<TunningPart> tunningParts)
        {
            Car car = new Car(model, brand, horsepower, brakeforce, traction, weight, highspeed, acceleration, price, tunningParts);
            carModel.updateCar(thisModel, car);
        }
        public void deleteCar(string model)
        {
            carModel.deleteCar(model);
        }
        public void updateTunningPartsFromCar(string model, List<TunningPart> tunningParts)
        {
            carModel.updateTunningPartsFromCar(model, tunningParts);
        }
        public TunningPart searchTunningPart(string name)
        {
            TunningPart tuningPart = tunningPartModel.searchTunningPart(name);
            return tuningPart;
        }
        public void addTunningPart(string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfTraction, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice)
        {
            TunningPart tunningPart = new TunningPart(name, category, changeOfHorsePower, changeOfBrakeForce, changeOfTraction, changeOfWeight, changeOfHighspeed, changeOfAcceleration, changeOfPrice);
            tunningPartModel.addTunnungPart(tunningPart);
        }
        public void deleteTunningPart(string name)
        {
            tunningPartModel.deleteTunningPart(name);
        }
        public void updateTunningPart(string thisName, string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfTraction, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice)
        {
            TunningPart tunningPart = new TunningPart(name, category, changeOfHorsePower, changeOfBrakeForce, changeOfTraction, changeOfWeight, changeOfHighspeed, changeOfAcceleration, changeOfPrice);
            tunningPartModel.updateTunningPart(name, tunningPart);
        }
    }
}
