using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10_MongoDbOrder.Servicees
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;

        public MongoDbConnection()
        {
            var client = new  MongoClient("mongodb://localhost:27017");//Baglantı Adresini Kurduk
            _database = client.GetDatabase("Db9ProjectsOrder");   //Veri Tabanı Adresi Yazdım
        }

        public IMongoCollection<BsonDocument> GetOrdersCollection()
        {
            return _database.GetCollection<BsonDocument>("Orders"); // MongoDb tarafında sütun ismi oluşturuyoz burda
        }
}
}
