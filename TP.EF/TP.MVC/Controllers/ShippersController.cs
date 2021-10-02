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

        public ActionResult Index()
        {
            List<Shippers> shippers = this.logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
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
                Shippers shipperEntity = new Shippers { CompanyName = shipperView.CompanyName, Phone = shipperView.Phone };

                logic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }


        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);

                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update(int id)
        {
            try
            {
                List<Shippers> shippers = this.logic.GetAll();

                List<ShippersView> shippersView = shippers.Select(s => new ShippersView
                {
                    Id = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone,
                }).ToList();

                var model = shippersView.Find(p => p.Id == id);

                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }

        }

        [HttpPost]
        public ActionResult Update(ShippersView shipperView)
        {
            try
            {
                logic.Update(shipperView.Id, 1, shipperView.CompanyName);
                logic.Update(shipperView.Id, 2, shipperView.Phone);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}
