using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class Car
    {
        public string Model {  get; set; }
        public string Brand { get; set; }
        public int Horsepower { get; set; }
        public double Brakeforce { get; set; }
        public double Traction {  get; set; }
        public double Weight { get; set; }
        public int Highspeed { get; set; }
        public double Acceleration { get; set; }
        public double Price { get; set; }
        public bool Modified { get; set; }
        public List<TunningPart> tunningParts { get; set;} = new List<TunningPart>();

        public Car() { }
        public Car(string model, string brand, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, bool modified, List<TunningPart> tunningParts)
        {
            Model = model;
            Brand = brand;
            Horsepower = horsepower;
            Brakeforce = brakeforce;
            Traction = traction;
            Weight = weight;
            Highspeed = highspeed;
            Acceleration = acceleration;
            Price = price;
            this.Modified = modified;
            this.tunningParts = tunningParts;
        }
    }
}
