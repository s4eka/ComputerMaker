using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComputerMaker.Enumerations;
using ComputerMaker.Models;

namespace ComputerMaker.Controllers
{
    public class HomeController : Controller
    {

        ComputerContext db = new ComputerContext();
        Socet sc = new Socet();
        FormFactor ff = new FormFactor();
        MemoryType mt = new MemoryType();
        Interfaces If = new Interfaces();
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateNewMotherboard()
        {
            ViewBag.Socet = Socet.socets;
            ViewBag.FormFactor = FormFactor.formFactors;
            ViewBag.MemoryType = MemoryType.memoryTypes;
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

        [HttpGet]
        public ActionResult CreateNewProcessor()
        {
            ViewBag.Socet = Socet.socets;
            ViewBag.FormFactor = FormFactor.formFactors;
            ViewBag.MemoryType = MemoryType.memoryTypes;
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewProcessor(Processor pr)
        {
            db.Processors.Add(pr);
            db.SaveChanges();
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetProcessorList()
        {
            IEnumerable<Processor> pr = db.Processors;
            return View(pr);
        }
        [HttpGet]
        public ActionResult Maker()
        {
            ViewBag.Processors = db.Processors.Select(x => new SelectListItem { Value = x.Socet, Text = x.Name });
            ViewBag.Motherboards = db.Motherboards.Select(x => new SelectListItem { Value = x.Socet, Text = x.Name });
            return View();
        }
        [HttpPost]
        public ActionResult Maker(Processor pr, Motherboard mb)
        {
            return View();
        }
    }
}