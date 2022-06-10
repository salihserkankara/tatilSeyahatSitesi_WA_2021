using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        [Route("/Rehber")]
        public ActionResult Index()
        {
            return View();
        }
    }
}