using MongoDB.Driver;
using System.Windows;
using System.Windows.Input;
using MongoDB.Bson;
using Amazon.Runtime.SharedInterfaces;
using CarTuningConfigurator.Model;
using System.Text;
using System.Configuration;
using MongoDB.Bson.Serialization;
using System.Collections.ObjectModel;
using MongoDB.Bson.Serialization.Serializers;

namespace CarTuningConfigurator.DatabaseConnection
{
    class DBConnect
    {
        private List<User> users;
        private List<Car> cars;
        private List<TunningPart> tunningParts;
        const string DatabaseName = "CarTuningConfigurator";
        const string ConnectionString = "mongodb://localhost:27017";
        string collectionameUser = "User";
        string collectionameCar = "Car";
        string collectionameTunningPart = "TunningPart";
        private IMongoDatabase db;

        // --------------------- Connect toDatabase ----------------------
        public void ConnectToDb()
        {
            var client = new MongoClient(ConnectionString);
            db = client.GetDatabase(DatabaseName);
        }

        // ---------------- Get Everything from Database -----------------
        public List<User> GetAllUsers()
        {

            ConnectToDb();

            var collection = db.GetCollection<User>(collectionameUser);
            var result = collection.Find(new BsonDocument()).ToList();
            users = new List<User>();
            foreach (User user in result)
            {
                users.Add(user);
            }
            
            return users;
        }
        public List<Car> GetAllCars()
        {
            ConnectToDb();

            var collection = db.GetCollection<Car>(collectionameCar);
            List<Car> result = collection.Find(new BsonDocument()).ToList();
            cars = new List<Car>();
            foreach (var car in result)
            {
                cars.Add(car);
            }
            return cars;
        }
        public List<TunningPart> GetAllTunningPart()
        {
            ConnectToDb();

            var collection = db.GetCollection<TunningPart>(collectionameTunningPart);
            List<TunningPart> result = collection.Find(new BsonDocument()).ToList();
            tunningParts = new List<TunningPart>();
            foreach (var tunningPart in result)
            {
                tunningParts.Add(tunningPart);
            }
            return tunningParts;
        }
        // --------------------- Insert to Database ----------------------
        public void InsertUserToDb(User user) 
        {
            ConnectToDb();

            var collection = db.GetCollection<User>(collectionameUser);
            collection.InsertOne(user);
        }
        public void InsertCarToDb(Car car)
        {
            ConnectToDb();

            var collection = db.GetCollection<Car>(collectionameCar);
            car.Id = new Guid();
            collection.InsertOne(car);
        }
        public void InsertTunningPartToDb(TunningPart tunningPart)
        {
            ConnectToDb();

            var collection = db.GetCollection<TunningPart>(collectionameTunningPart);
            collection.InsertOne(tunningPart);
        }
        // -------------------- Delete from Database ---------------------
        public void DeleteUser(User user)
        {
            ConnectToDb();
            var collection = db.GetCollection<User>(collectionameUser);
            List<User> result = collection.Find(new BsonDocument()).ToList();
            var filter = Builders<User>.Filter.Eq<Guid>(u => u.Id, user.Id);
            collection.DeleteOne(filter);
        }
        public void DeleteCar(Car car)
        {
            ConnectToDb();
            var collection = db.GetCollection<Car>(collectionameCar);
            List<Car> result = collection.Find(new BsonDocument()).ToList();
            var filter = Builders<Car>.Filter.Eq<Guid>(u => u.Id, car.Id);
            collection.DeleteOne(filter);
        }
        public void DeleteTunningPart(TunningPart tunningPart)
        {
            ConnectToDb();
            var collection = db.GetCollection<TunningPart>(collectionameTunningPart);
            List<TunningPart> result = collection.Find(new BsonDocument()).ToList();
            var filter = Builders<TunningPart>.Filter.Eq<Guid>(u => u.Id, tunningPart.Id);
            collection.DeleteOne(filter);
        }
        // -------------- Update Everything from Database ----------------
        public void UpdateCar(Car car, Car newcar)
        { 
            var collection = db.GetCollection<Car>(collectionameCar);
            var filter = Builders<Car>.Filter.Eq<Guid>(u => u.Id, car.Id);
            newcar.Id = car.Id;
            collection.ReplaceOne(filter, newcar);
        }
        public void UpdateTunningPart(TunningPart tunningPart, TunningPart newTunningPart)
        {
            var collection = db.GetCollection<TunningPart>(collectionameTunningPart);
            var filter = Builders<TunningPart>.Filter.Eq<Guid>(u => u.Id, tunningPart.Id);
            newTunningPart.Id = tunningPart.Id;
            collection.ReplaceOne(filter, newTunningPart);
        }
        public void UpdateUser(User user, User newUser)
        {
            var collection = db.GetCollection<User>(collectionameUser);
            var filter = Builders<User>.Filter.Eq<Guid>(u => u.Id, user.Id);
            newUser.Id = user.Id;
            collection.ReplaceOne(filter, newUser);
        }
        // -------------------- Update from Database ---------------------
        public void UpdateTunningPartsFromCar(Car car, List<TunningPart> tunningParts)
        {
            var collection = db.GetCollection<Car>(collectionameCar);
            var filter = Builders<Car>.Filter.Eq<Guid>(u => u.Id, car.Id);
            var update = Builders<Car>.Update.Set(car => car.tunningParts, tunningParts);
            collection.UpdateOne(filter, update);
        }
        public void UpdateCarsFromUser(User user, List<Car> cars)
        {
            var collection = db.GetCollection<User>(collectionameUser);
            var filter = Builders<User>.Filter.Eq<Guid>(u => u.Id, user.Id);
            var update = Builders<User>.Update.Set(user => user.cars, cars);
            collection.UpdateOne(filter, update);
        }


    }

}
