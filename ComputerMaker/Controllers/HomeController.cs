using System;
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
        static List<RAM> rams = new List<RAM>();

        static Computer computer = new Computer();

        Socet sc = new Socet();
        FormFactor ff = new FormFactor();
        MemoryType mt = new MemoryType();
        Interfaces If = new Interfaces();
        
        public static void LoadFromDB()
        {
            mbList = db.Motherboards.ToList();
            procList = db.Processors.ToList();
            rams = db.RAMs.ToList();
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
            ViewBag.Processors = db.Processors.Select(x => new SelectListItem { Value = x.Socet, Text = x.Name });
            ViewBag.Motherboards = db.Motherboards.Select(x => new SelectListItem { Value = x.Socet, Text = x.Name });

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

        public void CheckMem(params string[] Id)
        {
            computer.MemoryId = new List<int>();
            foreach (var item in Id)
            {
                computer.MemoryId.Add(Int32.Parse(item));
            }
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

        public ActionResult LoadMemory()
        {
            int MotherId = computer.MotherboardId;
            List<RAM> ram = new List<RAM>();
            if(computer.MemoryId.Count > 0)
            {
                ram = rams;
            }
            else if (MotherId == 0)
            {
                ram = rams;
                computer.MemoryId.Add(0);
            }
            else
            {
                if(String.Compare(mbList.Find(a => a.Id == MotherId).MemoryType, procList.Find(a => a.Id == computer.ProcessorId).MemoryType) > 0)
                {
                    computer.MemoryType = procList.Find(a => a.Id == computer.ProcessorId).MemoryType;
                }
                else
                {
                    computer.MemoryType = mbList.Find(a => a.Id == MotherId).MemoryType;
                }
                if (mbList.Find(a => a.Id == MotherId).MaxMemoryFrequency > procList.Find(a => a.Id == computer.ProcessorId).MaxMemoryFrequency)
                {
                    computer.MaxMemoryFrequency = procList.Find(a => a.Id == computer.ProcessorId).MaxMemoryFrequency;
                }
                else
                {
                    computer.MaxMemoryFrequency = mbList.Find(a => a.Id == MotherId).MaxMemoryFrequency;
                }
                computer.MaxMemoryCapacity = mbList.Find(a => a.Id == MotherId).MaxMemoryCapacity;
                computer.MaxMemoryCount = mbList.Find(a => a.Id == MotherId).MemorySlots;

                ram = rams.Where(a => a.Type == computer.MemoryType)
                    .Where(a => a.Frequency <= computer.MaxMemoryFrequency).ToList();
            }
            ViewBag.computer = computer;
            return PartialView(ram);
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
        [HttpGet]
        public ActionResult CreateNewRAM()
        {
            ViewBag.Type = MemoryType.memoryTypes;
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewRAM(RAM ram)
        {
            db.RAMs.Add(ram);
            db.SaveChanges();
            
            return View("Index");
        }

        [HttpGet]
        public ActionResult GetRAMList()
        {
            IEnumerable<RAM> ram = rams;
            return View(ram);
        }
        public ActionResult Maker(Processor pr, Motherboard mb)
        {
            return View();
        }
    }
}