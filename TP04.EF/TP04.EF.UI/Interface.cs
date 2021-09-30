using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TP.EF.Logic;
using TP.EF.Entidades;

namespace TP.EF.UI
{
    public class Interface
    {
        public void StartInterface()
        {

            bool continueProgram = true;
            string option;

            ShippersLogic shippersLogic = new ShippersLogic();
            SuppliersLogic suppliersLogic = new SuppliersLogic();

            

            while (continueProgram)
            {
                Console.WriteLine("=> NorthWind Shippers ABM <=\n");

                Console.WriteLine(" Options : \n\n" +
                    "1 - List ALL current Suppliers.\n" +
                    "2 - List ALL current Shippers.\n" +
                    "3 - ADD one Shipper.\n" +
                    "4 - MODIFY one Shipper.\n" +
                    "5 - DELETE one Shipper.\n" +
                    "6 - Exit\n");
                Console.WriteLine("- Enter the NUMBER of the option to execute.");
                Console.Write(">");
                option = Console.ReadLine();

                Int32.TryParse(option, out int parsedOption);

                Console.Clear();

                switch (parsedOption)
                {
                    case 1:
                        ListSuppliers(suppliersLogic);
                        break;
                    case 2:
                        ListShippers(shippersLogic);
                        
                        break;
                    case 3:
                        AddShipper(shippersLogic);
                        break;
                    case 4:
                        UpdateShipper(shippersLogic);  
                    break;
                    case 5:
                        DeleteShipper(shippersLogic);
                        break;
                    case 6:
                        continueProgram = false;
                    break;
                    default:
                        Console.WriteLine("- Error reading the option.");
                    break;
                }


                Console.WriteLine("\n > Press any key to continue. <");
                Console.ReadKey();
                Console.Clear();

            }

        }


        public void ListSuppliers(SuppliersLogic suppliersLogic)
        {
            try
            {
                foreach (Suppliers supplier in suppliersLogic.GetAll())
                {
                    Console.WriteLine($"{supplier.SupplierID}  -  {supplier.ContactTitle}  -  {supplier.ContactName}  -  {supplier.Phone}  -  {supplier.Region}");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error " + exc.Message);
            }
        }
        public void ListShippers(ShippersLogic shippersLogic)
        {
            try
            {

                foreach (Shippers shipper in shippersLogic.GetAll())
                {
                    Console.WriteLine($"{shipper.ShipperID} - {shipper.CompanyName} - {shipper.Phone}");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error " + exc.Message);
            }
        }

        public void AddShipper(ShippersLogic shippersLogic)
        {
            try
            {

                Console.Write("- Enter the Company Name of the new Shipper.");
                string newCompanyName = Console.ReadLine();

                Console.Write("- Enter the new Shipper's Phone Number.");
                string newPhoneNumber = Console.ReadLine();

                shippersLogic.Add(new Shippers { CompanyName = newCompanyName, Phone = newPhoneNumber });
            }
            catch (Exception exc)
            {
                Console.WriteLine("- Error " + exc.Message);
            }

        }
        public void UpdateShipper(ShippersLogic shippersLogic)
        {

            Console.Write(" Shippers List :\n\n");
            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shipper.ShipperID} - {shipper.CompanyName} - {shipper.Phone}");
            }

            Console.Write("\n- Enter the ID of the shipper that you whant to Update.");
            string idToUpdate = Console.ReadLine();
            int parsedIdupdate = 0;
            try
            {

                while (!Int32.TryParse(idToUpdate, out parsedIdupdate))
                {
                    Console.WriteLine("- Thats not a valid number, re enter the ID.\n>");

                    idToUpdate = Console.ReadLine();
                }

                if (shippersLogic.Contains(parsedIdupdate))
                {

                    foreach (Shippers shipper in shippersLogic.GetAll())
                    {
                        if (shipper.ShipperID == parsedIdupdate)
                        {
                            Console.WriteLine($" Shipper to Update: {shipper.ShipperID} - {shipper.CompanyName} - {shipper.Phone}");
                        }
                    }

                    Console.Write("\n- What do you whant to Update.\n1 - Companys Name\n2 - Phone Number.");

                    string updateOption = Console.ReadLine();
                    int parsedUpdateOption = 0;


                    while (!Int32.TryParse(updateOption, out parsedUpdateOption))
                    {
                        Console.WriteLine("- Thats not a valid number, re enter the option.\n>");

                        updateOption = Console.ReadLine();
                    }

                    if (parsedUpdateOption == 1)
                    {
                        Console.Write("- Enter the Company Name of the new Shipper.");
                        string newCompanyName = Console.ReadLine();

                        shippersLogic.Update(parsedIdupdate, parsedUpdateOption, newCompanyName);
                    }
                    else if (parsedUpdateOption == 2)
                    {
                        Console.Write("- Enter the Phone Numbber of the new Shipper.");
                        string newPhone = Console.ReadLine();
                        shippersLogic.Update(parsedIdupdate, parsedUpdateOption, newPhone);
                    }
                    else
                    {
                        Console.Write("- Error Invalid Option.");
                    }
                }
                else
                {
                    Console.WriteLine("- Error id provided dont exist");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("- Error " + exc.Message);
            }
        }

        public void DeleteShipper(ShippersLogic shippersLogic)
        {

            Console.Write(" Shippers List :\n\n");
            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shipper.ShipperID} - {shipper.CompanyName} - {shipper.Phone}");
            }
            Console.Write("\n\n- Enter the ID of the shipper to delete it.");
            string idToDelete = Console.ReadLine();
            int parsedId = 0;

            try
            {
                while (!Int32.TryParse(idToDelete, out parsedId))
                {
                    Console.WriteLine("- Thats not a valid number, re enter the ID.\n>");

                    idToDelete = Console.ReadLine();
                }
                if (shippersLogic.Contains(parsedId))
                {
                    shippersLogic.Delete(parsedId);

                }
                else
                {
                    Console.WriteLine("- Error id provided dont exist");
                }


            }
            catch (Exception exc)
            {
                Console.WriteLine("- Error " + exc.Message);
            }
        }
    }
}
