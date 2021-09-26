using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TP5.LINQ.Entidades;

namespace TP5.LINQ.Logic
{
    public class Querys
    {

        protected BaseLogic logic;
        protected IEnumerable<Customers> customers;
        protected IEnumerable<Products> products;
        protected IEnumerable<Orders> orders;

        public Querys()
        {
            this.logic = new BaseLogic();
            this.customers = logic.ObtenerCustomers;
            this.products = logic.ObtenerProducts;
            this.orders = logic.ObtenerOrders;
        }

        public string Query1()
        {

            return customers.First().ContactName.ToString();

        }

        public string Query2()
        {

            var query2 = products.Where(p => p.UnitsInStock < 1);

            StringBuilder stringy = new StringBuilder();
            foreach (var item in query2)
            {
                stringy.AppendLine(item.ProductName.ToString());
            }

            return stringy.ToString();
        }

        public string Query3()
        {

            var query3 = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);


            StringBuilder stringy = new StringBuilder();
            foreach (var item in query3)
            {
                stringy.AppendLine(item.ProductName.ToString());
            }

            return stringy.ToString();
        }



        public string Query4()
        {

            var query4 = customers.Where(p => p.Region == "WA");


            StringBuilder stringy = new StringBuilder();
            foreach (var item in query4)
            {
                stringy.AppendLine(item.ContactName.ToString());
            }

            return stringy.ToString();
        }


        public string Query5()
        {

            var query5 = from product in products
                         where product.ProductID == 789
                         select product.ProductName;


            StringBuilder stringy = new StringBuilder();

            foreach (var item in query5)
            {
                stringy.AppendLine(item);
            }

            return stringy.ToString();

        }


        public string Query6()
        {

            var query6 = from customer in customers
                         orderby customer.ContactName
                         select customer.ContactName;


            StringBuilder stringy = new StringBuilder();
            foreach (var item in query6)
            {
                stringy.Append(item.ToUpper());
            }

            stringy.AppendLine();

            foreach (var item in query6)
            {
                stringy.Append(item.ToLower());
            }

            return stringy.ToString();
        }


        public string Query7()
        {

            var query7 = from order in orders
                         join customer in customers
                         on order.CustomerID equals customer.CustomerID
                         where customer.Region == "WA" && order.OrderDate > new DateTime(1997, 1, 1)
                         select new
                         {
                             customer.CustomerID,
                             customer.ContactName,
                             order.OrderDate
                         };


            StringBuilder stringy = new StringBuilder();

            foreach (var item in query7)
            {
                stringy.Append(item.CustomerID);
                stringy.Append(item.ContactName);
                stringy.AppendLine(item.OrderDate.ToString());
            }


            return stringy.ToString();
        }

        public string Query8()
        {


            var query8 = customers.Take(3).ToList();


            StringBuilder stringy = new StringBuilder();
            foreach (var item in query8)
            {
                stringy.AppendLine(item.ContactName.ToString());
            }

            return stringy.ToString();
        }

        public string Query9()
        {

            var query9 = from product in products
                         orderby product.ProductName ascending
                         select product.ProductName;


            StringBuilder stringy = new StringBuilder();

            foreach (var item in query9)
            {
                stringy.AppendLine(item);
            }

            return stringy.ToString();
        }

        public string Query10()
        {


            var query10 = from product in products
                          orderby product.UnitsInStock ascending
                          select product;


            StringBuilder stringy = new StringBuilder();

            foreach (var item in query10)
            {
                stringy.AppendLine(item.UnitsInStock.ToString() + " " + item.ProductName);
            }

            return stringy.ToString();
        }

    }
}
