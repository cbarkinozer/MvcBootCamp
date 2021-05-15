using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootCamp.Controllers
{
    public class StatisticController : Controller
    {
        // GET: İstatistik
        public ActionResult Index()
        {
            return View();
        }
        
    }
}