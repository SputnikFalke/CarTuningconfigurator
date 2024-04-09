using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class TunningPart
    {
        private string name {  get; set; }
        private string category { get; set; }
        private int changeOfHorsePower { get; set; }
        private double changeOfBrakeForce { get; set; }
        private double changeOfPosture { get; set; }
        private double changeOfWeight { get; set; }
        private int changeOfHighspeed { get; set;}
        private double changeOfAcceleration { get; set; }
        private double changeOfPrice { get; set;}

        public TunningPart() { }
        public TunningPart(string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfPosture, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice)
        {
            this.name = name;
            this.category = category;
            this.changeOfHorsePower = changeOfHorsePower;
            this.changeOfBrakeForce = changeOfBrakeForce;
            this.changeOfPosture = changeOfPosture;
            this.changeOfWeight = changeOfWeight;
            this.changeOfHighspeed = changeOfHighspeed;
            this.changeOfAcceleration = changeOfAcceleration;
            this.changeOfPrice = changeOfPrice;
        }
    }
}
