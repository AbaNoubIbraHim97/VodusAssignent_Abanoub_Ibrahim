using VodusAssignent_Abanoub_Ibrahim.Dtos;
using VodusAssignent_Abanoub_Ibrahim.Models;

namespace VodusAssignent_Abanoub_Ibrahim.Repositery
{
    public interface IProductRepository
    {
       Task <IEnumerable<ProductDto>> GetAllProducts();
        void AddProduct(Product product);

    }
}
