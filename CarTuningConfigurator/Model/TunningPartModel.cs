using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class TunningPartModel
    {
        private List<TunningPart> tunningParts;

        public TunningPartModel() { }

        public bool addTunnungPart(TunningPart tunningPart)
        {
            bool result = false;
            tunningParts.Add(tunningPart);
            foreach (var tunningPart2 in tunningParts)
            {
                if(tunningPart2.Name == tunningPart.Name)
                {
                    result = true;
                }
            }
            return result;
        }

        public TunningPart searchTunningPart(string name)
        {
            foreach (var tunningPart in tunningParts)
            {
                if(tunningPart.Name == name)
                {
                    return tunningPart;
                }
            }
            return null;
        }
        public bool updateTunningPart(string name,  TunningPart newTuningPart)
        {
            bool result = false;
            foreach(var tunningPart in tunningParts)
            {
                if (tunningPart.Name == name)
                {
                    tunningPart.Name = newTuningPart.Name;
                    tunningPart.Category = newTuningPart.Category;
                    tunningPart.ChangeOfHorsePower = newTuningPart.ChangeOfHorsePower;
                    tunningPart.ChangeOfBrakeForce = newTuningPart.ChangeOfBrakeForce;
                    tunningPart.ChangeOfTraction = newTuningPart.ChangeOfTraction;
                    tunningPart.ChangeOfWeight = newTuningPart.ChangeOfWeight;
                    tunningPart.ChangeOfPrice = newTuningPart.ChangeOfPrice;
                    tunningPart.ChangeOfHighspeed = newTuningPart.ChangeOfHighspeed;
                    tunningPart.ChangeOfAcceleration = newTuningPart.ChangeOfAcceleration;              
                    
                    if(tunningPart.Name ==  newTuningPart.Name && tunningPart.ChangeOfTraction == newTuningPart.ChangeOfTraction && tunningPart.ChangeOfWeight == newTuningPart.ChangeOfWeight && tunningPart.ChangeOfHighspeed == newTuningPart.ChangeOfHighspeed && tunningPart.ChangeOfPrice == newTuningPart.ChangeOfPrice && tunningPart.ChangeOfBrakeForce == newTuningPart.ChangeOfBrakeForce && tunningPart.ChangeOfAcceleration == newTuningPart.ChangeOfAcceleration)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        public bool deleteTunningPart (string name)
        {
            bool result = true;
            foreach(var tunningPart in tunningParts)
            {
                if(tunningPart.Name == name)
                {
                    tunningParts.Remove(tunningPart);
                    foreach(var tunningPart2 in tunningParts)
                    {
                        if (tunningPart2.Name == name)
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
    }
}
