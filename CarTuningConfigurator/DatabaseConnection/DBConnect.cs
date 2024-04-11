using MongoDB.Driver;
using System.Windows;
using System.Windows.Input;
using MongoDB.Bson;
using Amazon.Runtime.SharedInterfaces;
using CarTuningConfigurator.Model;
using System.Text;
using System.Configuration;

namespace CarTuningConfigurator.DatabaseConnection
{
    class DBConnect
    {
        private List<User> users;
        const string DatabaseName = "CarTuningConfigurator";
        const string ConnectionString = "mongodb://localhost:27017";
        string collectioname = "User";
        private IMongoCollection<BsonDocument> collection;
        private IMongoDatabase db;

        // --------------------- Connect toDatabase ----------------------
        public void ConnectToDb()
        {
            var client = new MongoClient(ConnectionString);
            db = client.GetDatabase(DatabaseName);
        }


        // ---------------------- User and Database ----------------------
        // CRUD-Methodes for Users in Database

        public List<User> GetAllUsers() 
        {
            ConnectToDb();
            users = new List<User>();
            collection = db.GetCollection<BsonDocument>(collectioname);
            List<BsonDocument> usersBSON = collection.Find(new BsonDocument()).ToList();

            foreach (var bsonUser in usersBSON) 
            {
                User user = BsonToUser(bsonUser);
                users.Add(user);
            }
            
            return users;
        }
        public void InsertUserToDb(User user) 
        {
            ConnectToDb();
            collection = db.GetCollection<BsonDocument>(collectioname);
            collection.InsertOne(UserToBson(user));
        }

        
        internal void DeleteUser(User user)
        {
            ConnectToDb();
            collection = db.GetCollection<BsonDocument>(collectioname);
            collection.DeleteOne(UserToBson(user));

        }

        // Convert Users from and into BSON-Documents

        public BsonDocument UserToBson(User user)
        {
            var Id = "XXXXX-Y";
            var username = user.Username;
            var password = user.Password;

            var doc = new BsonDocument
            {
                { "_Id",  Id},
                { "username",  username},
                { "password",  password}
            };

            return doc;
        }

        public User BsonToUser(BsonDocument doc) 
        {
            var _username = doc["username"];
            var _password = doc["password"];

            String username = _username.AsString;
            String password = _password.AsString;

            User user = new User(username, password);

            return user;
        }


        // ---------------------- Car and Database ----------------------
    }

}
