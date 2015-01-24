using System;
using MongoDB.Driver;
using System.Configuration;
using System.Web.Hosting;

namespace DIY_Propter.Infrastructure
{
    public class DataStore
    {
        public static MongoCollection<T> GetCollection<T>(string collection)
        {
            var mclient = new MongoClient(ConfigurationManager.ConnectionStrings["mongo"].ConnectionString);
            MongoServer srv = mclient.GetServer();
            var db = srv.GetDatabase("diypromtper");
            return db.GetCollection<T>(collection);
        }
    }
}