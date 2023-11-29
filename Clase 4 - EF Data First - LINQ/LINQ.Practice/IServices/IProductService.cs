using Data.Models;

namespace LINQ.Practice.IServices
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}
