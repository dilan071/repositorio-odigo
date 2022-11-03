using MongoDB.Driver;
using MongoDBCsharp.Models;
using System;
using System.Collections.Generic;

namespace MongoDBCsharp
{
    class program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhots:27017");
            var database = client.GetDatabase("Ejmplo_CLimpio");

            
            var ejemplCodigoDB = database.GetCollection<Ejmplo_CLimpio>("Ejmplo_CLimpio");
            

            var Ejmplo_CLimpio = new Ejmplo_CLimpio() {Id ="123456", Nombre = "Henry", edad = "20" };
            ejemplCodigoDB.InsertOne(Ejmplo_CLimpio);


            //Para Obtener los datos

            //List<Ejmplo_CLimpio> 1st = Ejmplo_CLimpioDB.Find(d => true).ToList();
            //Ejmplo_CLimpioDB.ReplaceOne(d =>d.Id =="12345", Ejmplo_CLimpio);
            ejemplCodigoDB.DeleteOne(d=>d.Id == "12345");

        }
    }
}