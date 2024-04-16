using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Media3D;

namespace CarTuningConfigurator.Contorller
{
    internal class LoginController
    {
        UserModel userModel;
        DBConnect dBConnect;
        public LoginController()
        {
            dBConnect = new DBConnect();
            userModel = new UserModel();
            userModel.users = dBConnect.GetAllUsers();
        }
        //-------------------- User -------------------
        public string addUser(string username, string password, string confirmpassword)
        {

            string resultat = null;
            if(username.Count() >= 5) 
            {
                if(password.Count() >= 5 && password == confirmpassword) 
                {
                    bool otherUsername = false;
                    foreach (var user1 in userModel.users)
                    {
                        if (username == user1.Username)
                        {
                            otherUsername = true;
                        }
                    }  
                    if (otherUsername == false) 
                    {

                        string salt = "";
                        string hashedPassword = HashPassword(salt, password);
                        User user = new User(username, hashedPassword);

                        dBConnect.InsertUserToDb(user);
                        userModel.users = dBConnect.GetAllUsers();
                        resultat = "erfolgreich";
                    }
                    else
                    {
                        resultat = "Der Username ist bereits vergeben";
                    }



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
        public string checkUser(string username, string password) 
        {
            userModel.users = dBConnect.GetAllUsers();
            string result = null;
            string salt = "";
            string hashedPassword = HashPassword(salt, password);

            if(username == "Elia" &&  password == "Kuster")
            {
                result = "admin";
            }
            else if(userModel.checkUser(username, hashedPassword) !=null) 
            {
                result = "user";
            }
            return result;
        }
        public void updateCarsFromUser(string username, List<Car> myCars)
        {
            userModel.updateCarsFromUser(username, myCars);
        }
        //-------------------- Hash -------------------
        public static string HashPassword(string salt, string password)
        {
            string mergedPass = string.Concat(salt, password);
            return EncryptUsingMD5(mergedPass);
        }

        public static string EncryptUsingMD5(string inputStr)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(inputStr));

                // Create a new Stringbuilder to collect the bytes and create a string
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data/format each one as a hexadecimal string
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

    }
}
