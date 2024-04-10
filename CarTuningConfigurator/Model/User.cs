using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Car> cars { get; set; } = new List<Car>();

        public User() {}
        
        public User(string name, string lastname, List<Car> cars)
        {
            this.Username = name;
            this.Password = lastname;
            this.cars = cars;
        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
