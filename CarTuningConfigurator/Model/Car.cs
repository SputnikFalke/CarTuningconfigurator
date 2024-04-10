using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class Car
    {
        private String model {  get; set; }
        private String brand { get; set; }
        private int horsepower { get; set; }
        private double brakeforce { get; set; }
        private double traction {  get; set; }
        private double weight { get; set; }
        private int highspeed { get; set; }
        private double acceleration { get; set; }
        private double price { get; set; }
        private List<TunningPart> tunningParts { get; set;} = new List<TunningPart>();

        public Car() { }
        public Car(string model, string brand, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, List<TunningPart> tunningParts)
        {
            this.model = model;
            this.brand = brand;
            this.horsepower = horsepower;
            this.brakeforce = brakeforce;
            this.traction = traction;
            this.weight = weight;
            this.highspeed = highspeed;
            this.acceleration = acceleration;
            this.price = price;
            this.tunningParts = tunningParts;
        }
    }
}
