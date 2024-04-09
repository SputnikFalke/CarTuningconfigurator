using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace CarTuningConfigurator.DatabaseConnection
{
    class DBConnect
    {
        private void ConnectToDB() {
            const string ConnectionString = "mongodb://localhost:27017";
            var client = new MongoClient(ConnectionString);

            
        }
    } 
}
