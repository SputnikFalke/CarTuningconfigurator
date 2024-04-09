using CarTuningConfigurator.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTuningConfigurator.Contorller
{
    internal class Controller
    {
        private DBConnect dBConnect;
        private MainWindow mainWindow;
        public Controller() {
            mainWindow = new MainWindow();
            dBConnect = new DBConnect();
        }
    }
}
