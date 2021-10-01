using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TP.EF.Logic;
using TP.EF.Entities;
using TP.MVC.Models;

namespace TP.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            List<Shippers> shippers = this.logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                Description = s.CompanyName,
            }).ToList();

            return View(shippersView);
        }



        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shipperView)
        {
            try
            {

                Shippers shipperEntity = new Shippers { CompanyName = shipperView.Description };

                logic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception exc)
            {
                return RedirectToAction("Index", "Error");
            }

        }










        // GET: Shippers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shippers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shippers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




        // GET: Shippers/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch(Exception exc)
            {
                return View();
            }

        }

        // POST: Shippers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Shippers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shippers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
