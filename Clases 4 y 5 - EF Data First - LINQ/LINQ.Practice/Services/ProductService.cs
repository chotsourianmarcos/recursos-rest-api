using Data.Models;
using LINQ.Practice.IServices;

namespace LINQ.Practice.Services
{
    public class ProductService : IProductService
    {
        private readonly NorthwindContext _serviceContext;
        public ProductService(NorthwindContext serviceContext)
        {
            _serviceContext = serviceContext;
        }
        public List<Product> GetAllProducts()
        {
            return _serviceContext.Products.ToList();
        }
    }
}
