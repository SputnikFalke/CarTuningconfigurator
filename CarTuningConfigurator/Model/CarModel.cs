using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarTuningConfigurator.Model
{
    internal class CarModel
    {
        private List<Car> cars = new List<Car>();
        public CarModel() { }

        public void addCar(Car car)
        {
            cars.Add(car);
        }
        public void deleteCar(string model)
        {
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    cars.Remove(car);
                }
            }
        }
        public void updateCar(string model, Car newcar)
        {
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    car.Model = newcar.Model;
                    car.Horsepower = newcar.Horsepower;
                    car.Brand = newcar.Brand;
                    car.Brakeforce = newcar.Brakeforce;
                    car.Acceleration = newcar.Acceleration;
                    car.Highspeed = newcar.Highspeed;
                    car.Weight = newcar.Weight;
                    car.Price = newcar.Price;
                    car.Traction = newcar.Traction;
                }
            }
        }
        public Car searchCar(string model)
        {
            foreach(var car in cars)
            {
                if(car.Model == model)
                {
                    return car;
                }
            }
            return null;
        }
        public void updateTunningPartsFromCar(string  model, List<TunningPart> tunningParts)
        {
            foreach( var car in cars)
            {
                if(car.Model == model)
                {
                    car.tunningParts = tunningParts;
                }
            }
        }
    }
}
