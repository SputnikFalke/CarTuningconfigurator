using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class Car
    {
        private String Model {  get; set; }
        private String Brand { get; set; }
        private int Horsepower { get; set; }
        private double Brakeforce { get; set; }
        private double Traction {  get; set; }
        private double Weight { get; set; }
        private int Highspeed { get; set; }
        private double Acceleration { get; set; }
        private double Price { get; set; }
        private List<TunningPart> tunningParts { get; set;} = new List<TunningPart>();

        public Car() { }
        public Car(string model, string brand, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, List<TunningPart> tunningParts)
        {
            this.Model = model;
            this.Brand = brand;
            this.Horsepower = horsepower;
            this.Brakeforce = brakeforce;
            this.Traction = traction;
            this.Weight = weight;
            this.Highspeed = highspeed;
            this.Acceleration = acceleration;
            this.Price = price;
            this.tunningParts = tunningParts;
        }
    }
}
