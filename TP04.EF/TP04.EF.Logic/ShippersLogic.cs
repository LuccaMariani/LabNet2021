using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP04.EF.Data;
using TP04.EF.Entidades;

namespace TP04.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers shipper)
        {
            context.Shippers.Add(shipper);

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            /*
            var shipperToDelete = context.Shippers.Single(r => r.ShipperID == id);
            Añadir excepciones para usar este.
            */

            var shipperToDelete = context.Shippers.Find(id);

            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
        }

        /// <summary>
        /// Modifies the Companys Name, or Phone
        /// </summary>
        /// <param name="shipper"></param>
        /// <param name="option"> 1- to change the Companys Name, 2- to change the Phone</param>
        /// <param name="field">The new Companys Name or Phone</param>
        public void Update(int id, int option, string field)
        {
            try
            {
                var shippersUpdate = context.Shippers.Find(id);

                switch (option)
                {
                    case 1:
                        shippersUpdate.CompanyName = field;
                        break;
                    case 2:
                        shippersUpdate.Phone = field;
                        break;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }

            context.SaveChanges();
        }

        public bool Contains(int id)
        {
            bool verify = false;

            if(context.Shippers.Find(id) != null)
            {
                verify = true;
            }

            return verify;
        }

    }
}
