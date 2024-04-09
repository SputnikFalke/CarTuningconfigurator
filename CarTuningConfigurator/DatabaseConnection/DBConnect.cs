using MongoDB.Driver;
using System.Windows;

namespace CarTuningConfigurator.DatabaseConnection
{
    class DBConnect
    {
        void ConnectToDb()
        {
            const string ConnectionString = "mongodb://localhost:27017";
            var client = new MongoClient(ConnectionString);

            Console.WriteLine(client);
            Console.WriteLine("Hallo Mensch");

        }
    }

}
