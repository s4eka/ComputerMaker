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
        public int SATA1 { get; set; }
        public int SATA2 { get; set; }
        public int SATA3 { get; set; }
        public int PCIe1 { get; set; }
        public int PCIe2 { get; set; }
        public int PCIe3 { get; set; }
        public bool IntegratedGraphics { get; set; }

    }
}