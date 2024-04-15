using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class TunningPartModel
    {
        public List<TunningPart> tunningParts;

        public TunningPartModel() { }

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
    }
}
