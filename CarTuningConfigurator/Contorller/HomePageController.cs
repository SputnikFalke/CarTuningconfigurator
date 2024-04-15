using CarTuningConfigurator.DatabaseConnection;
using CarTuningConfigurator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Contorller
{
    class HomePageController
    {
        public List<Car> cars;
        private DBConnect DBConnect;

        public HomePageController() 
        {
            DBConnect = new DBConnect();
            cars = DBConnect.GetAllCars();
        }


    }
}
