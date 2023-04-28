using Microsoft.EntityFrameworkCore;
using VodusAssignent_Abanoub_Ibrahim.Context;
using VodusAssignent_Abanoub_Ibrahim.Dtos;
using VodusAssignent_Abanoub_Ibrahim.Models;

namespace VodusAssignent_Abanoub_Ibrahim.Repositery
{
    public class ProductRepository :IProductRepository
    {
        private readonly ProductDbContext _dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products =await _dbContext.Product.Select( p=> new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price
            }).ToListAsync();
            return products;

        }
        public void AddProduct(Product product)
        {
            _dbContext.Product.Add(product);
            _dbContext.SaveChanges();
        }

    }
}
