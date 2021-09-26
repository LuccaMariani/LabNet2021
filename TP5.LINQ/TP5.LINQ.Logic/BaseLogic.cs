using System.Collections.Generic;
using System.Linq;
using TP5.LINQ.Data;
using TP5.LINQ.Entidades;

namespace TP5.LINQ.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;



        public BaseLogic()
        {
            context = new NorthwindContext();
        }

        public IEnumerable<Shippers> ObtenerShippers { get { return context.Shippers.ToList(); ; } }

        public IEnumerable<Customers> ObtenerCustomers { get { return context.Customers.ToList(); ; } }

        public IEnumerable<Products> ObtenerProducts { get { return context.Products.ToList(); ; } }

        public IEnumerable<Orders> ObtenerOrders { get { return context.Orders.ToList(); ; } }




    }
}
