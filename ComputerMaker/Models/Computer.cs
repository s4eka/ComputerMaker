using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerMaker.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public int MotherboardId { get; set; }
        public int ProcessorId { get; set; }
        public int RAMId { get; set; }
    }
}