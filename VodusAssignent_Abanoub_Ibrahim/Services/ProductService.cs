using VodusAssignent_Abanoub_Ibrahim.Dtos;
using VodusAssignent_Abanoub_Ibrahim.Models;
using VodusAssignent_Abanoub_Ibrahim.Repositery;

namespace VodusAssignent_Abanoub_Ibrahim.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {

            return await _productRepository.GetAllProducts();

        }

        public void AddProduct(AddProductDto productDto)
        {

            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price
            };
            _productRepository.AddProduct(product);
        }
    }
}
