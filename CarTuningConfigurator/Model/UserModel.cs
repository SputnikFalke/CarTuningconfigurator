using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CarTuningConfigurator.Model
{
    class UserModel
    {
        private List<User> users = new List<User>();
        public UserModel()
        {
            User user = new User("Elia", "Kuster");
            addUser(user);
        }
        public void addUser(User user)
        {
            users.Add(user);
        }

        public User checkUser(string username, string password) 
        {
            foreach (var user in users)
            {
                if(user.Username == username && user.Password == password) return user;
            }
            return null;
        }

        public void updateCarsFromUser(string username, List<Car>cars)
        {
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    user.cars = cars;
                }
            }
        }

        
    }
}
