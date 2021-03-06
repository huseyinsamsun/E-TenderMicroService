using ESourcing.Products.Entities;
using ESourcing.Products.Settings;
using MongoDB.Driver;

namespace ESourcing.Products.Data.Interfaces
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionStrings);
            var database = client.GetDatabase(settings.DatabaseName);
            Products = database.GetCollection<Product>(settings.CollectionName);
            ProductContextSeeed.SeedData(Products);
          
        }
        public IMongoCollection<Product> Products { get;}
    }
}
