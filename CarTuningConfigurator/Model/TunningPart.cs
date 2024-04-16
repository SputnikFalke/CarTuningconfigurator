using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class TunningPart
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public string Category { get; set; }
        public int ChangeOfHorsePower { get; set; }
        public double ChangeOfBrakeForce { get; set; }
        public double ChangeOfTraction { get; set; }
        public double ChangeOfWeight { get; set; }
        public int ChangeOfHighspeed { get; set;}
        public double ChangeOfAcceleration { get; set; }
        public double ChangeOfPrice { get; set;}
        public int stage { get; set; }

        public TunningPart(string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfTraction, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice, int stage)
        {
            this.Name = name;
            this.Category = category;
            this.ChangeOfHorsePower = changeOfHorsePower;
            this.ChangeOfBrakeForce = changeOfBrakeForce;
            this.ChangeOfTraction = changeOfTraction;
            this.ChangeOfWeight = changeOfWeight;
            this.ChangeOfHighspeed = changeOfHighspeed;
            this.ChangeOfAcceleration = changeOfAcceleration;
            this.ChangeOfPrice = changeOfPrice;
            this.stage = stage;
        }
    }
}
