using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class TunningPart
    {
        private string Name {  get; set; }
        private string Category { get; set; }
        private int ChangeOfHorsePower { get; set; }
        private double ChangeOfBrakeForce { get; set; }
        private double ChangeOfPosture { get; set; }
        private double ChangeOfWeight { get; set; }
        private int ChangeOfHighspeed { get; set;}
        private double ChangeOfAcceleration { get; set; }
        private double ChangeOfPrice { get; set;}

        public TunningPart() { }
        public TunningPart(string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfPosture, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice)
        {
            this.Name = name;
            this.Category = category;
            this.ChangeOfHorsePower = changeOfHorsePower;
            this.ChangeOfBrakeForce = changeOfBrakeForce;
            this.ChangeOfPosture = changeOfPosture;
            this.ChangeOfWeight = changeOfWeight;
            this.ChangeOfHighspeed = changeOfHighspeed;
            this.ChangeOfAcceleration = changeOfAcceleration;
            this.ChangeOfPrice = changeOfPrice;
        }
    }
}
