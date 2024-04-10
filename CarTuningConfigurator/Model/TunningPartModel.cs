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

        public void addTunnungPart(TunningPart tunningPart)
        {
            tunningParts.Add(tunningPart);
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
        public void updateTunningPart(string name,  TunningPart newTuningPart)
        {
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
                    tunningPart.ChangeOfAcceleration = newTuningPart.ChangeOfAcceleration;                }
            }
        }
        public void deleteTunningPart (string name)
        {
            foreach(var tunningPart in tunningParts)
            {
                if(tunningPart.Name == name)
                {
                    tunningParts.Remove(tunningPart);

                }
            }
        }
    }
}
