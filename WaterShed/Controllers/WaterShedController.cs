using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WaterBudget.Controllers
{
    public class WaterShedController : Controller
    {
        // GET: WaterShed
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddDetail()
        {
            return View();
        }
        public ActionResult ViewDetail()
        {
            return View();
        }
        public ActionResult ViewPolicy()
        {
            return View();
        }
        public ActionResult PolicyView()
        {
            return View();
        }


    }
}