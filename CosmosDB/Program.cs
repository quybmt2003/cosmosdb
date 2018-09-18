using System;
using System.Collections.Generic;
using CosmosDB.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CosmosDB
{
    class Program
    {
        private static string _url = "mongodb://walasmgen:hDM6w3vEbOCzTKLGSngqCGwshY52CCV3wwfE8CM33PW4NHwNCDTFDIyyKelw8Gw04anTjdrn8yym3B9aghlc5w==@walasmgen.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        private static MongoClient _client;
        private static IMongoDatabase _database;
        private static IMongoCollection<CuttingTool> _collection;
        static void Main(string[] args)
        {
            InitializeConnection();
            Console.WriteLine("Starting Inserting documents");
            Insert();
            Console.WriteLine("DONE!");
            Console.ReadKey();
        }

        static void InitializeConnection()
        {
            Console.WriteLine("Initializing the connection");
            _client = new MongoClient(new MongoUrl(_url));
            _database = _client.GetDatabase("CuttingTool");
            _collection = _database.GetCollection<CuttingTool>(nameof(CuttingTool).ToLower());
            Console.WriteLine("Finish initializing the conneciton");
        }


        static void Insert()
        {
            var cuttingTool = new CuttingTool
            {
                Id = "12345",
                Name = "Milling tool",
                Price = (decimal)100.25,
                CuttingToolItems = new List<CuttingToolItem>
                {
                    new CuttingToolItem
                    {
                        Id = 6789,
                        Name = "Insert 1",
                        Count = 4
                    },
                    new CuttingToolItem
                    {
                        Id = 9876,
                        Name = "Insert 2",
                        Count = 4
                    }
                }
            };

            _collection.InsertOne(cuttingTool);
        }
    }
}
