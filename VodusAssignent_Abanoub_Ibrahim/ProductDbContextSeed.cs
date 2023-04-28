using VodusAssignent_Abanoub_Ibrahim.Context;
using VodusAssignent_Abanoub_Ibrahim.Models;

namespace VodusAssignent_Abanoub_Ibrahim
{
    public static class ProductDbContextSeed
    {
        public static void Seed(ProductDbContext context)
        {
            if (!context.Product.Any())
            {
                var products = new List<Product>
            {
                new Product { Name = "Product 1", Description = "Description 1", Price = 10.00m },
                new Product { Name = "Product 2", Description = "Description 2", Price = 20.00m },
                new Product { Name = "Product 3", Description = "Description 3", Price = 30.00m }
            };

                context.Product.AddRange(products);
                context.SaveChanges();
            }
        }
    }

}
