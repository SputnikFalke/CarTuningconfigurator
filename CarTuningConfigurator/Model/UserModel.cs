using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Model
{
    internal class UserModel
    {
        private List<User> users { get; set; } = new List<User>();
        public UserModel() { }
        public void addUser(User user) 
        {  
            users.Add(user); 
        }
        public void deleteUser(User user) 
        {
            users.Remove(user);
        }
        public User searchUser(User user)
        {
            foreach (User user2 in users)
            {
                if (user2 == user) { return user2; }
            }
            return null;
        }
        public void updateUser(User user, User newuser) 
        {
            foreach (User user2 in users)
            {
                if (user2 == user) 
                { 
                }
            }
        }
        
    }
}
