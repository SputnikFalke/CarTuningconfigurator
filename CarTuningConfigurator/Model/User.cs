using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class User
    {
        private string Name { get; set; }
        private string Lastname { get; set; }
        private List<Car> cars { get; set; } = new List<Car>();

        public User() {}
        
        public User(string name, string lastname, List<Car> cars)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.cars = cars;
        }
    }
}
