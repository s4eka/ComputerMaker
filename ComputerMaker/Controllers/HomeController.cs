﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web;
using System.Web.Mvc;
using ComputerMaker.Enumerations;
using ComputerMaker.Models;
using Newtonsoft.Json;

namespace ComputerMaker.Controllers
{
    public class HomeController : Controller
    {

        static ComputerContext db = new ComputerContext();
        static List<Motherboard> mbList = new List<Motherboard>();
        static List<Processor> procList = new List<Processor>();

        static Computer computer = new Computer();

        Socet sc = new Socet();
        FormFactor ff = new FormFactor();
        MemoryType mt = new MemoryType();
        Interfaces If = new Interfaces();
        
        public static void LoadFromDB()
        {
            mbList = db.Motherboards.ToList();
            procList = db.Processors.ToList();
        }

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
            IEnumerable<Motherboard> mb = mbList;
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
            IEnumerable<Processor> pr = procList;
            return View(pr);
        }





        [HttpGet]
        public ActionResult Maker()
        {
            Reload();
            return View();
        }

        public ActionResult MakerPost()
        {

            ViewBag.JSONMotherboards = JsonConvert.SerializeObject(mbList);
            return View();
        }

        public void CheckMotherboard(string Id)
        {
            int id = Int32.Parse(Id);
            computer.MotherboardId = id;
        }

        public void CheckProcessor(string Id)
        {
            int id = Int32.Parse(Id);
            computer.ProcessorId = id;
        }

        public void CheckRAM(string Id)
        {
            int id = Int32.Parse(Id);
            computer.RAMId = id;
        }

        
        public ActionResult LoadProcessors()
        {
            int MotherId = computer.MotherboardId;
            List<Processor> proc = new List<Processor>();
            ViewBag.computer = computer;
            if (MotherId == 0)
            {
                proc = procList;
            }
            else
            {
                var socet = mbList.Find(a => a.Id == MotherId).Socet;
                proc = procList.Where(a => a.Socet == socet).ToList();
            }
            return PartialView(proc);
        }

        public ActionResult LoadMotherboard()
        {
            int ProcId = computer.ProcessorId;
            List<Motherboard> mother = new List<Motherboard>();
            ViewBag.computer = computer;
            if(ProcId == 0)
            {
                mother = mbList;
            }
            else
            {
                var socet = procList.Find(a => a.Id == ProcId).Socet;
                mother = mbList.Where(a => a.Socet == socet).ToList();
            }
            return PartialView(mother);
        }
        public void Reload()
        {
            LoadMotherboard();
            LoadProcessors();
        }

        public void Reload(string motherId, string procId)
        {
            CheckMotherboard(motherId);
            CheckProcessor(procId);
            Reload();
        }
    }
}