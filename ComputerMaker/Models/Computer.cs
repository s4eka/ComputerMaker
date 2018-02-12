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
        public List<int> MemoryId { get; set; }

        public string Socet { get; set; }
        public string MemoryType { get; set; }
        public int MemoryCount { get; set; }
        public int MemoryCapacity { get; set; }
        public int MaxMemoryCapacity { get; set; }
        public int MaxMemoryCount { get; set; }
        public int MaxMemoryFrequency { get; set; }
        public Computer():base()
        {
            MemoryId = new List<int>();
        }
        
    }
}