using MongoDB.Bson;
using Project10_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10_MongoDbOrder.Servicees
{
    public class OrderOparestion
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();

            var document = new BsonDocument
            {
             
                {"CustomerName",order.CustomerName },
                {"Distiric", order.Distiric},
                {"City",order.City },
                {"TotalPrice",order.TotalPrice }
            };
            orderCollection.InsertOne(document);
        }
    }
}
