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

        public bool addCar(Car car)
        {
            bool result = false;
            cars.Add(car);
            foreach(var car2  in cars)
            {
                if(car2.Model == car.Model)
                {
                    result = true;   
                }
            }
            return result;

        }
        public bool deleteCar(string model)
        {
            bool result = true;
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    cars.Remove(car);
                    foreach (var car2 in cars)
                    {
                        if(car2.Model == model)
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
        public bool updateCar(string model, Car newcar)
        {
            bool result = false;
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
                    car.Modified = newcar.Modified;
                    car.tunningParts = newcar.tunningParts;

                    if(car.Model == newcar.Model && car.Horsepower == newcar.Horsepower && car.Brand == newcar.Brand && car.Brakeforce == newcar.Brakeforce && car.Acceleration ==newcar.Acceleration && car.Highspeed == newcar.Highspeed && car.Weight == newcar.Weight && car.Price == newcar.Price && car.Traction == newcar.Traction && car.Modified == newcar.Modified && car.tunningParts == newcar.tunningParts)
                    {
                        result = true;
                    }
                }
            }
            return result;
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
        public bool updateTunningPartsFromCar(string  model, List<TunningPart> tunningParts)
        {
            bool result = false;
            foreach( var car in cars)
            {
                if(car.Model == model)
                {
                    car.tunningParts = tunningParts;
                    if(car.tunningParts == tunningParts)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
