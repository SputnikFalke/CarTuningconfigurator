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
        public List<Car> cars = new List<Car>();
        public CarModel() { }



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
