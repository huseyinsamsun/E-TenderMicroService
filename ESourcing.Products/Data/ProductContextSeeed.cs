using ESourcing.Products.Entities;
using MongoDB.Driver;

namespace ESourcing.Products.Data
{
    public class ProductContextSeeed
    {
        public static void  SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any(); //any bool tipinde dönmesini sağlar
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetConfigureProducts())
            }


        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
           {
               new Product()
               {
                   Name ="Iphone x",
                   Summary="this phone is compny",
                   Description="lorem ipsum",
                   ImageFile="product-1-png",
                   Price=950.00M,
                   Category="Smart Phone"
               },
               new Product()
               {
                   Name="Samsun s10",
                   Summary="this phone",
                   Description="lorem",
                   ImageFile="product2",
                   Price=850.00M,
                   Category="Smart Phone"
               }
           };
        }
    }
}
