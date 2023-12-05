using Data.Models;
using LINQ.Practice.IServices;
using Microsoft.AspNetCore.Mvc;

namespace API.Scheduler.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }
    }
}