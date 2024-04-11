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
        private List<User> users = new List<User>();
        DBConnect dBConnect;
        public UserModel()
        {
            dBConnect = new DBConnect();
            //User user = new User("Fabio", "Dauru");
            //addUser(user);
            users = dBConnect.GetAllUsers();
        }
        public bool addUser(User user)
        {
          //dBConnect.InsertUserToDb(user);
          bool result = false;
            users.Add(user);
            foreach (var user2 in users)
            {
                if(user2.Username == user.Username)
                {
                    result = true;
                }
            }
            return result;
        }
       
        public void deleteUser(User user) 
        {
            dBConnect.DeleteUser(user);
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
                    if(user.cars == cars)
                    {
                        result = true;
                    }
                }

            }
            return result;
        }

        
    }
}
