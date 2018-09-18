using System;
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
            Console.WriteLine("Hello World!");
        }

        static void InitializeConnection()
        {
            Console.WriteLine("Initializing the connection");
            _client = new MongoClient(new MongoUrl(_url));
            _database = _client.GetDatabase("CuttingTool");
            _collection = _database.GetCollection<CuttingTool>(nameof(CuttingTool));
            Console.WriteLine("Finish initializing the conneciton");
        }
    }
}
