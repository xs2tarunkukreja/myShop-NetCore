
using Catalog.Entities;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace Catalog.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetValue<string>("DatabaseSettings:ConnectionString");
            var dbName = configuration.GetValue<string>("DatabaseSettings:DatabaseName");
            var collectionName = configuration.GetValue<string>("DatabaseSettings:CollectionName");
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            Products = database.GetCollection<Product>(collectionName);
            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }    
}