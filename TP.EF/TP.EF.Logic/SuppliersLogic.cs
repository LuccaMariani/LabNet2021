using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.EF.Data;
using TP.EF.Entities;

namespace TP.EF.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public void Add(Suppliers supplier)
        {
            context.Suppliers.Add(supplier);

            context.SaveChanges();
        }

        public void Delete(int id)
        {

            var supplierToRemove = context.Suppliers.Find(id);

            context.Suppliers.Remove(supplierToRemove);
            context.SaveChanges();
        }

        /// <summary>
        /// Modifies the Companys Name, or Phone
        /// </summary>
        /// <param name="id"></param>
        /// <param name="option"> 1- to change the Companys Name, 2- to change the Phone</param>
        /// <param name="field">The new Companys Name or Phone</param>
        public void Update(int id, int option, string field)
        {
            var supplierUpdate = context.Suppliers.Find(id);

            switch (option)
            {
                case 1:
                    supplierUpdate.CompanyName = field;
                    break;
                case 2:
                    supplierUpdate.Phone = field;
                    break;
            }

            context.SaveChanges();
        }

    }
}
