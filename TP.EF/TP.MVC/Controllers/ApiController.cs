using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TP.MVC.Models;

namespace TP.MVC.Controllers
{
    public class ApiController : Controller
    {

        // GET: Api
        public ActionResult Index()
        {
            HttpClient cliente = new HttpClient();

            var respuesta = cliente.GetAsync("https://swapi.dev/api/people/1");

            respuesta.Wait();
            
            if (respuesta.IsCompleted)
            {
                var resultado = respuesta.Result;

                if (resultado.IsSuccessStatusCode)
                {
                    var mensaje = resultado.Content.ReadAsStringAsync();

                    ApiView apiView = JsonConvert.DeserializeObject<ApiView>(mensaje.Result);

                    return View(apiView);
                }
            }

            return RedirectToAction("Index", "Error");
        }

    }
}
