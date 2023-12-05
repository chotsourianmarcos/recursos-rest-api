using Data.Models;
using LINQ.Practice.IServices;
using LINQ.Practice.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace API.Scheduler.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EjercitacionController : ControllerBase
    {
        private IEjercitacionService _ejercitacionService;

        public EjercitacionController(IEjercitacionService ejercitacionService)
        {
            _ejercitacionService = ejercitacionService;
        }

        //Create a report that shows the OrderID ContactName, UnitPrice, Quantity, Discount from the order details, orders and
        //customers table with discount given on every purchase.
        [HttpGet(Name = "GetSolucionEjercicio1")]
        public List<Ejercicio1RowModel> GetSolucionEjercicio1()
        {
            return _ejercitacionService.GetSolucionEjercicio1();
        }
    }
}