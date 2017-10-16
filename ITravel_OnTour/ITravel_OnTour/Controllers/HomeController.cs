using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITravel_OnTour.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "pagina quienes somos.";

            return View();
        }
        public ActionResult Destinos()
        {
            ViewBag.Message = "pagina de destinos y paquetes.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "pagina de contacto.";

            return View();
        }
    }
}