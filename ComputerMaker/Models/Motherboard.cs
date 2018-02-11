using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerMaker.Models
{
    public class Motherboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Socet { get; set; }
        public string Formfactor { get; set; }
        public string MemoryType { get; set; }
        public int MemorySlots { get; set; }
        public int MaxMemoryCapacity { get; set; }
        public int MaxFrequency { get; set; }
        public int SATA { get; set; }
        public int PCIe { get; set; }
        public bool IntegratedGraphics { get; set; }

    }
}