using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerMaker.Models
{
    public class Processor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Socet { get; set; }
        public string MemoryType { get; set; }
        public int MaxMemoryFrequency { get; set; }
        public bool IntegratedGraphics { get; set; }
        public byte Power { get; set; }
    }
}