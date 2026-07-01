using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10_MongoDbOrder.Entities
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] //Id leri object yapıyor
        public String OrderId { get; set; }
        public String CustomerName { get; set; }
        public String Distiric { get; set; }
        public String City { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
