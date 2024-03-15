using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Inventory3.DB
{
    public class DataManager
    {
        private static MongoClient GetMongoClient()
        {
            string connectionString = "mongodb+srv://Robban:6H0k021mGrb2j72u@student.kxwhocu.mongodb.net/?retryWrites=true&w=majority&appName=student";
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };

            var mongoClient = new MongoClient(settings);

            return mongoClient;
        }

        public static IMongoCollection<Models.Product> ProductCollection()
        {
            var client =  GetMongoClient();

            var database = client.GetDatabase("InventoryDB");

            var productCollection = database.GetCollection<Models.Product>("myProducts");

            return productCollection;
        }
    }
}
