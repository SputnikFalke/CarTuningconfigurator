using CarTuningConfigurator.DatabaseConnection;
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
        public List<User> users = new List<User>();
        DBConnect dBConnect;//Controller
        public UserModel()
        {
            dBConnect = new DBConnect(); 
            users = dBConnect.GetAllUsers(); 
        }
       

        public User checkUser(string username, string password) 
        {
            foreach (var user in users)
            {
                if(user.Username == username && user.Password == password) return user;
            }
            return null;
        }

        public bool updateCarsFromUser(string username, List<Car>cars)
        {
            bool result = false;
            foreach (var user in users)
            {
                if (user.Username == username)
                {
                    user.cars = cars;
                    result = true;
                }

            }
            return result;
        }

        
    }
}
