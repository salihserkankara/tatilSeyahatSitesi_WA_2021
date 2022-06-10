using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult MesajGonder()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MesajGonder(Iletisim i)
        {
            c.Iletisims.Add(i);
            c.SaveChanges();
            return PartialView();
        }
    }
}