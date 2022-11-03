using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBCsharp.Models
{
    public class Ejmplo_CLimpio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("edad")]
        public string edad { get; set; }




    }
}
