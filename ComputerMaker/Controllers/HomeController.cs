using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComputerMaker.Models;

namespace ComputerMaker.Controllers
{
    public class HomeController : Controller
    {

        ComputerContext db = new ComputerContext();
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateNewMotherboard()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewMotherboard(Motherboard mb)
        {
            db.Motherboards.Add(mb);
            db.SaveChanges();
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetMotherboardList()
        {
            IEnumerable<Motherboard> mb = db.Motherboards;
            return View(mb);
        }

    }
}