using Data.Models;
using LINQ.Practice.IServices;
using LINQ.Practice.Models;

namespace LINQ.Practice.Services
{
    public class EjercitacionService : IEjercitacionService
    {
        private readonly NorthwindContext _northwindContext;
        public EjercitacionService(NorthwindContext northwindContext) 
        {
            _northwindContext = northwindContext;
        }
        public List<Ejercicio1RowModel> GetSolucionEjercicio1()
        {
            var resultQuery = from od in _northwindContext.OrderDetails
                              join o in _northwindContext.Orders on od.OrderId equals o.OrderId
                              join c in _northwindContext.Customers on o.CustomerId equals c.CustomerId
                              select new Ejercicio1RowModel
                              {
                                  OrderId = o.OrderId,
                                  ContactName = c.ContactName,
                                  UnitPrice = od.UnitPrice,
                                  Quantity = od.Quantity,
                                  Discount = od.Discount,
                              };
            return resultQuery.ToList();
            //SELECT[o0].[OrderID] AS[OrderId], [c].[ContactName], [o].[UnitPrice], [o].[Quantity], [o].[Discount]
            //FROM[Order Details] AS[o]
            //INNER JOIN[Orders] AS[o0] ON[o].[OrderID] = [o0].[OrderID]
            //INNER JOIN[Customers] AS[c] ON[o0].[CustomerID] = [c].[CustomerID]


            //var resultQuery = _northwindContext.OrderDetails
            //                    .Join(_northwindContext.Orders,
            //                            od => od.OrderId,
            //                            o => o.OrderId,
            //                            (od, o) => new
            //                            {
            //                                OrderDetail = od,
            //                                Order = o
            //                            })
            //                    .Join(_northwindContext.Customers,
            //                            t => t.Order.CustomerId,
            //                            c => c.CustomerId,
            //                            (t, c) => new Ejercicio1RowModel
            //                            {
            //                                OrderId = t.OrderDetail.OrderId,
            //                                ContactName = c.ContactName,
            //                                UnitPrice = t.OrderDetail.UnitPrice,
            //                                Quantity = t.OrderDetail.Quantity,
            //                                Discount = t.OrderDetail.Discount,
            //                            });
            //return resultQuery.ToList();
            //SELECT[o].[OrderID] AS[OrderId], [c].[ContactName], [o].[UnitPrice], [o].[Quantity], [o].[Discount]
            //FROM[Order Details] AS[o]
            //INNER JOIN[Orders] AS[o0] ON[o].[OrderID] = [o0].[OrderID]
            //INNER JOIN[Customers] AS[c] ON[o0].[CustomerID] = [c].[CustomerID]
        }
    }
}
