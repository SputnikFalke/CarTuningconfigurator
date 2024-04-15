using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Contorller
{
    internal class AdminController
    {
        CarModel carModel;
        TunningPartModel tunningPartModel;
        UserModel userModel;
        DBConnect dBConnect;

        public AdminController()
        {
            carModel = new CarModel();
            tunningPartModel = new TunningPartModel();
            userModel = new UserModel();
            dBConnect = new DBConnect();
        }

        public void addUser(string username, string password)
        {
            string salt = "";
            string hashedPassword = HashPassword(salt, password);
            User user = new User(username, hashedPassword);
            dBConnect.InsertUserToDb(user);
            userModel.users = dBConnect.GetAllUsers();
        }
        public void updateUser(string thisUsername, string username, string password)
        {
            string salt = "";
            string hashedPassword = HashPassword(salt, password);
            userModel.users = dBConnect.GetAllUsers();
            User newUser = new User(username, hashedPassword);
            User user = userModel.searchUser(thisUsername);
            dBConnect.UpdateUser(user, newUser);
            userModel.users = dBConnect.GetAllUsers();
        }
        public bool deleteUser(string username)
        {
            bool result = false;
            userModel.users = dBConnect.GetAllUsers();
            foreach (User user in userModel.users)
            {
                if (user.Username == username)
                {
                    dBConnect.DeleteUser(user);
                    userModel.users = dBConnect.GetAllUsers();
                    result = true;
                }
            }
            return result;
        }
        public void addCar(string model, string brand, string image, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, bool modified, List<TunningPart> tunningParts)
        {
            Car car = new Car(model, brand, image, horsepower, brakeforce, traction, weight, highspeed, acceleration, price, modified ,tunningParts);
            dBConnect.InsertCarToDb(car);
            carModel.cars = dBConnect.GetAllCars();
        }
        public Car searchCar(string model)
        {
            carModel.cars = dBConnect.GetAllCars();
            if(carModel.searchCar(model) != null)
            {
                Car car = carModel.searchCar(model);
                return car;
                
            }
            else
            {
                return null;
            }
        }
        public void updateCar(string thisModel, string model, string image, string brand, int horsepower, double brakeforce, double traction, double weight, int highspeed, double acceleration, double price, bool modified, List<TunningPart> tunningParts)
        {
            carModel.cars = dBConnect.GetAllCars();
            Car newCar = new Car(model, brand, image, horsepower, brakeforce, traction, weight, highspeed, acceleration, price, modified, tunningParts);
            Car car = carModel.searchCar(thisModel);
            dBConnect.UpdateCar(car, newCar);
            carModel.cars = dBConnect.GetAllCars();
        }
        public bool deleteCar(string model)
        {
            bool result = false;
            carModel.cars = dBConnect.GetAllCars();
            foreach (Car car in carModel.cars)
            {
                if (car.Model == model)
                {
                    dBConnect.DeleteCar(car);
                    carModel.cars = dBConnect.GetAllCars();
                    result = true;
                }
            }
            return result;
        }
        public bool updateTunningPartsFromCar(string model, List<TunningPart> tunningParts)
        {
            bool result = false;
            carModel.cars = dBConnect.GetAllCars();
            foreach (Car car in carModel.cars)
            {
                if (car.Model == model)
                {
                    dBConnect.UpdateTunningPartsFromCar(car, tunningParts);
                    carModel.cars = dBConnect.GetAllCars();
                    result = true;
                }
            }
            return result;
        }
        public TunningPart searchTunningPart(string name)
        {
            tunningPartModel.tunningParts = dBConnect.GetAllTunningPart();
            if (tunningPartModel.searchTunningPart(name) != null)
            {
                TunningPart tunningPart = tunningPartModel.searchTunningPart(name);
                return tunningPart;

            }
            else
            {
                return null;
            }
        }
        public void addTunningPart(string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfTraction, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice)
        {
            TunningPart tunningPart = new TunningPart(name, category, changeOfHorsePower, changeOfBrakeForce, changeOfTraction, changeOfWeight, changeOfHighspeed, changeOfAcceleration, changeOfPrice);
            dBConnect.InsertTunningPartToDb(tunningPart);
            tunningPartModel.tunningParts = dBConnect.GetAllTunningPart();
        }
        public bool deleteTunningPart(string name)
        {
            bool result = false;
            tunningPartModel.tunningParts = dBConnect.GetAllTunningPart();
            foreach (TunningPart tunningPart in tunningPartModel.tunningParts)
            {
                if (tunningPart.Name == name)
                {
                    dBConnect.DeleteTunningPart(tunningPart);
                    tunningPartModel.tunningParts = dBConnect.GetAllTunningPart();
                    result = true;
                }
            }
            return result;
        }
        public void updateTunningPart(string thisName, string name, string category, int changeOfHorsePower, double changeOfBrakeForce, double changeOfTraction, double changeOfWeight, int changeOfHighspeed, double changeOfAcceleration, double changeOfPrice)
        {
            TunningPart newTunningPart = new TunningPart(name, category, changeOfHorsePower, changeOfBrakeForce, changeOfTraction, changeOfWeight, changeOfHighspeed, changeOfAcceleration, changeOfPrice);
            TunningPart tunningPart = tunningPartModel.searchTunningPart(thisName);
            dBConnect.UpdateTunningPart(tunningPart, newTunningPart);
            tunningPartModel.tunningParts = dBConnect.GetAllTunningPart();
        }

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

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
    }
}
