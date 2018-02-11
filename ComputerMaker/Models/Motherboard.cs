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
        public int MaxMemoryFrequency { get; set; }
        public byte SATA1 { get; set; }
        public byte SATA2 { get; set; }
        public byte SATA3 { get; set; }
        public byte PCIe1 { get; set; }
        public byte PCIe2 { get; set; }
        public byte PCIe3 { get; set; }
        public bool IntegratedGraphics { get; set; }

    }
}