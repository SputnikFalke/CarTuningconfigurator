using CarTuningConfigurator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Contorller
{
    internal class LoginController
    {
        UserModel userModel = new UserModel();
        public String addUser(string username, string password, string confirmpassword)
        {
            
            String resultat;
            if(username.Count() >= 5) 
            {
                if(password.Count() >= 5 && password == confirmpassword) 
                {
                    User user = new User(username, password);
                    userModel.addUser(user);
                    resultat = "erfolgreich";
                }
                else
                {
                    resultat = "Das Password muss min. 5 Zeichen gross sein und mit dem Confirm Password übereinstimmen";
                }
            } 
            else
            {
                resultat = "Der Username muss mindestens 5 Zeichen gross sein";
            }
            return resultat;
        }
        public bool checkUser(string username, string password) 
        {
            bool result = false;
            if(userModel.checkUser(username, password) != null) 
            { 
                result = true;
            }
            return result;
        }
    }
}
