using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.EF.Data;
using TP.EF.Entities;

namespace TP.EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shippers Get(int id)
        {
            return context.Shippers.Find(id);
        }

        public void Add(Shippers shipper)
        {
            try
            {

                context.Shippers.Add(shipper);
            }
            catch(Exception exc)
            {
                throw exc;
            }
            finally
            {
                context.SaveChanges();
            } 
        }

        public void Delete(int id)
        {

            try
            {
                var shipperToDelete = context.Shippers.Find(id);

                context.Shippers.Remove(shipperToDelete);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                context.SaveChanges();
            }

            
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
            finally
            {

                context.SaveChanges();
            }
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
