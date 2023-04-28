using VodusAssignent_Abanoub_Ibrahim.Dtos;
using VodusAssignent_Abanoub_Ibrahim.Models;

namespace VodusAssignent_Abanoub_Ibrahim.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
        void AddProduct(AddProductDto product);


    }
}
