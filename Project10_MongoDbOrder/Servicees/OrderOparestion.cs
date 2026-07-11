using MongoDB.Bson;
using MongoDB.Driver;
using Project10_MongoDbOrder.Entities;
using Project10_MongoDbOrder.Servicees;
using System;
using System.Collections.Generic;

namespace Project10_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollection();

            var document = new BsonDocument
            {
                {"CustomerName",order.CustomerName },
                {"District", order.District},
                {"City",order.City },
                {"TotalPrice",order.TotalPrice }
            };
            orderCollection.InsertOne(document);
        }

        public List<Order> GetAllOrders()
        {
            var connection = new MongoDbConnection();
            var ordersCollection = connection.GetOrdersCollection();
            var orders = ordersCollection.Find(new BsonDocument()).ToList();

            List<Order> orderList = new List<Order>();
            foreach (var item in orders)
            {
                orderList.Add(new Order
                {
                    OrderId = item["_id"].ToString(),
                    CustomerName = item["CustomerName"].ToString(),
                    District = item["District"].ToString(),
                    City = item["City"].ToString(),
                    TotalPrice = decimal.Parse(item["TotalPrice"].ToString())
                });
            }

            return orderList;
        }

        public void DeleteOrder(String orderId)
        {
            var connection = new MongoDbConnection();
            var ordersCollection = connection.GetOrdersCollection();
            var filet = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            ordersCollection.DeleteOne(filet);
        }

        public void UpdateOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderConnection = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("customerName", order.CustomerName)
                .Set("City", order.City)
                .Set("TotalPrice", order.TotalPrice)
                .Set("District", order.District);
            orderConnection.UpdateOne(filter, updatedValue);
        }

        public Order GetOrderById(string orderId)
        {
            var Connection = new MongoDbConnection();
            var orderCollection = Connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var result = orderCollection.Find(filter).FirstOrDefault();
            if (result != null)
            {
                return new Order
                {
                    City = result["City"].ToString(),
                    CustomerName = result["CustomerName"].ToString(),
                    TotalPrice = decimal.Parse(result["TotalPrice"].ToString()),
                    District = result["District"].ToString(),
                    OrderId = orderId,

                };
            }
            else
            {
                return null;
            }




        }

    }
}
