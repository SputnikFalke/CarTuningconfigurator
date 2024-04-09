﻿using MongoDB.Driver;
using System.Windows;
using System.Windows.Input;
using MongoDB.Bson;
using Amazon.Runtime.SharedInterfaces;

namespace CarTuningConfigurator.DatabaseConnection
{
    class DBConnect
    {
        const string DatabaseName = "CarTuningConfigurator";
        const string ConnectionString = "mongodb://localhost:27017";
        string collectioname = "Cars";
        IMongoCollection<BsonDocument> collection;
        IMongoDatabase database;

        public void ConnectToDb()
        {
            var client = new MongoClient(ConnectionString);
            database = client.GetDatabase(DatabaseName);
            collection = database.GetCollection<BsonDocument>(collectioname);
            
        }
    }

}
