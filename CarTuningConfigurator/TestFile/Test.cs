using CarTuningConfigurator.Contorller;
using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using CarTuningConfigurator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarTuningConfigurator.TestFile
{
    internal class Test
    {
        bool Loginresult = false;
        bool Registerresult = false;
        bool AddUser = false;
        bool UpdateUser = false;
        bool DeleteUser = true;
        bool AddCar = false;
        bool UpdateCar = false;
        bool DeleteCar = true;
        bool AddTunningPart = false;
        bool UpdateTunningPart = false;
        bool DeleteTunningPart = true;
        bool SaveTwoCarsToUser = false;
        bool SaveTwoTunningPartsToCar = false;
        bool SaveCarFromUserWithNewTunningParts = false;
        LoginController loginController;
        HomePageController homePageController;
        AdminController adminController;
        DBConnect dbConnect;

        public Test()
        {
            loginController = new LoginController();
            homePageController = new HomePageController();
            adminController = new AdminController();
            dbConnect = new DBConnect();
            RegisterTest();
            LoginTest();
            AddUserTest();
            UpdateUserTest();
            DeleteUserTest();
            AddCarTest();
            UpdateCarTest();
            DeleteCarTest();
            AddTunningPartTest();
            UpdateTunningPartTest();
            DeleteTunningPartTest();
            SaveTwoCarsToUserTest();
            UpdateTwoTunningPartsToCarTest();
            SaveTwoCarsFromUserWithNewTunningPartsTest();
        }

        public void Message()
        {
            MessageBox.Show(" RegisterTest = " + Registerresult + "\n LoginTest = " + Loginresult + "\n AddUserTest = " + AddUser + "\n UpdateUserTest = " + UpdateUser + "\n DeleteUserTest = " + DeleteUser + "\n AddCarTest = " + AddCar + "\n UpdateCarTest = " + UpdateCar + "\n DeleteCarTest = " + DeleteCar + "\n AddTunningPartTest = " + AddTunningPart + "\n UpdateTunningPartTest = " + UpdateTunningPart
                + "\n DeleteTunningPartTest = " + DeleteTunningPart + "\n SaveTwoCarsToUserTest = " + SaveTwoCarsToUser + "\n SaveTwoTunningPartsToCar = " + SaveTwoTunningPartsToCar + "\n SaveTunnedCarFromUserWidthNewTunningParts = " + SaveCarFromUserWithNewTunningParts
                );
        }

        public void RegisterTest()
        {
            loginController.addUser("Test1", "Password1", "Password1");
            foreach(var user in dbConnect.GetAllUsers())
            {
                if(user.Username == "Test1")
                {
                    Registerresult = true;
                    adminController.deleteUser("Test1");
                }
            }
        }

        public void LoginTest()
        {
            loginController.addUser("Test2", "Password2", "Password2");
            User user = loginController.checkUser("Test2", "Password2");
            if(user.Username == "Test2")
            {
                Loginresult = true;
                adminController.deleteUser("Test2");
            }
        }

        public void AddUserTest()
        {
            adminController.addUser("Test3", "Password3");
            foreach (var user in dbConnect.GetAllUsers())
            {
                if (user.Username == "Test3")
                {
                    AddUser = true;
                    adminController.deleteUser("Test3");
                }
            }
        }

        public void UpdateUserTest()
        {
            adminController.addUser("Test4", "Password4");
            adminController.updateUser("Test4", "Test5", "Password5");
            foreach (var user in dbConnect.GetAllUsers())
            {
                if (user.Username == "Test5")
                {
                    UpdateUser = true;
                    adminController.deleteUser("Test5");
                }
            }
        }

        public void DeleteUserTest()
        {
            adminController.addUser("Test6", "Password6");
            adminController.deleteUser("Test6");
            foreach (var user in dbConnect.GetAllUsers())
            {
                if (user.Username == "Test6")
                {
                    DeleteUser = false;
                    adminController.deleteUser("Test6");
                }
            }
        }

        public void AddCarTest()
        {
            adminController.addCar("Test1", "Test1", null, null, 1, 1, 1, 1, 1, 1, 1, false, null);
            foreach (var car in dbConnect.GetAllCars())
            {
                if (car.Model == "Test1")
                {
                    AddCar = true;
                    adminController.deleteCar("Test1");
                }
            }
        }

        public void UpdateCarTest()
        {
            adminController.addCar("Test2", "Test2", null, null, 2, 2, 2, 2, 2, 2, 2, false, null);
            adminController.updateCar("Test2", "Test3", "Test3", null, null, 3, 3, 3, 3, 3, 3, 3, true, null);
            foreach (var car in dbConnect.GetAllCars())
            {
                if (car.Model == "Test3" && car.Brand == "Test3" && car.Horsepower == 3 && car.Brakeforce == 3 && car.Traction == 3 && car.Highspeed == 3 && car.Weight == 3 && car.Acceleration == 3 && car.Price == 3 && car.Modified == true)
                {
                    UpdateCar = true;
                    adminController.deleteCar("Test3");
                }
            }
        }

        public void DeleteCarTest()
        {
            adminController.addCar("Test4", "Test4", null, null , 4, 4, 4, 4, 4, 4, 4, false, null);
            adminController.deleteCar("Test4");
            foreach (var car in dbConnect.GetAllCars())
            {
                if (car.Model == "Test4")
                {
                    DeleteCar = false;
                    adminController.deleteCar("Test4");
                }
            }
        }

        public void AddTunningPartTest()
        {
            adminController.addTunningPart("Test1", "Emgine", 1, 1, 1, 1, 1, 1, 1, 1);
            foreach (var tunningPart in dbConnect.GetAllTunningPart())
            {
                if (tunningPart.Name == "Test1")
                {
                    AddTunningPart = true;
                    adminController.deleteTunningPart("Test1");
                }
            }
        }

        public void UpdateTunningPartTest()
        {
            adminController.addTunningPart("Test2", "Wing", 2, 2, 2, 2, 2, 2, 2, 2);
            adminController.updateTunningPart("Test2", "Test3", "Turbo", 3, 3, 3, 3, 3, 3, 3, 3);
            foreach(var tunningPart in dbConnect.GetAllTunningPart())
            {
                if(tunningPart.Name == "Test3" && tunningPart.Category == "Turbo" && tunningPart.ChangeOfHorsePower == 3 && tunningPart.ChangeOfBrakeForce == 3 && tunningPart.ChangeOfPrice == 3 && tunningPart.ChangeOfTraction == 3 && tunningPart.ChangeOfAcceleration == 3 && tunningPart.ChangeOfHighspeed == 3 && tunningPart.ChangeOfWeight == 3 && tunningPart.stage == 3)
                {
                    UpdateTunningPart = true;
                    adminController.deleteTunningPart("Test3");
                }
            }
        }

        public void DeleteTunningPartTest()
        {
            adminController.addTunningPart("Test4", "Tires", 4, 4, 4, 4, 4, 4, 4, 4);
            adminController.deleteTunningPart("Test4");
            foreach (var tunningPart in dbConnect.GetAllTunningPart())
            {
                if (tunningPart.Name == "Test4")
                {
                    DeleteTunningPart = false;
                    adminController.deleteTunningPart("Test4");
                }
            }
        }

        public void SaveTwoCarsToUserTest()
        {
            Car car1 = new Car("C1", "C1", null, null, 1, 1, 1, 1, 1, 1, 1, false, null);
            Car car2 = new Car("C2", "C2", null, null, 1, 1, 1, 1, 1, 1, 1, true, null);
            User userT = new User("T3", "P3");
            adminController.addUser("T3", "P3");
            homePageController.saveCar(userT, car1);
            homePageController.saveCar(userT, car2);
            foreach(var user in dbConnect.GetAllUsers())
            {
                if(user.Username == "T3")
                {
                    if (userT.cars.Count == 2 && userT.cars.Contains(car1) == true && userT.cars.Contains(car2) == true)
                    {
                        SaveTwoCarsToUser = true;
                        adminController.deleteUser("T3");
                        adminController.deleteCar("C2");
                        adminController.deleteCar("C1");
                    }
                }
            }

        }

        public void UpdateTwoTunningPartsToCarTest()
        {
            TunningPart tunning1 = new TunningPart("t1", "Engine", 1, 1, 1, 1, 1, 1, 1, 1);
            TunningPart tunning2 = new TunningPart("t2", "Wing", 2, 2, 2, 2, 2, 2, 2, 2);
            List<TunningPart> tunningParts = new List<TunningPart>();
            tunningParts.Add(tunning1);
            tunningParts.Add(tunning2);
            Car carT = new Car();
            homePageController.updateTunningPartfromCar(carT, tunningParts);
            if(carT.tunningParts.Count == 2 && carT.tunningParts.Contains(tunning1) == true && carT.tunningParts.Contains(tunning2) == true)
            {
                SaveTwoTunningPartsToCar = true;
            }
        }

        public void SaveTwoCarsFromUserWithNewTunningPartsTest()
        {
            adminController.addCar("te1", "Turbo", null, null, 3, 3, 3, 3, 3, 3, 3, true, null);
            TunningPart tunninger1 = new TunningPart("tes1", "Engine", 6, 6, 6, 6, 6, 6, 6, 6);
            TunningPart tunninger2 = new TunningPart("tes2", "Wing", 8, 8, 8, 8, 8, 8, 8, 8);
            List<TunningPart> tunningParts = new List<TunningPart>();
            tunningParts.Add(tunninger1);
            User user = null;
            Car car = null;
            adminController.addUser("Test23", "Password23");
            foreach(var User in dbConnect.GetAllUsers())
            {
                if(User.Username == "Test23")
                {
                    user = User;
                }
            }
            foreach (var Car in dbConnect.GetAllCars())
            {
                if(Car.Model == "te1")
                {
                    car = Car;
                }
            }
            homePageController.updateTunningPartfromCar(car, tunningParts);
            homePageController.saveCar(user, car);
            foreach(var User in dbConnect.GetAllUsers())
            {
                if(User.Username == user.Username)
                {
                    user = User;
                }
            }
            foreach (var Car in dbConnect.GetAllCars())
            {
                if (Car.Model == "te1")
                {
                    car = Car;
                }
            }
            tunningParts.Add(tunninger2);
            homePageController.updateTunningPartfromCar(car, tunningParts);
            homePageController.saveTunnedCar(user, car);
            if(user.cars.Count == 1 && user.cars.Contains(car) == true)
            {
                SaveCarFromUserWithNewTunningParts = true;
                adminController.deleteCar("te1");
                adminController.deleteUser("Test23");
            }
        }


    }
}

