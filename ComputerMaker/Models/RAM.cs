using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerMaker.Models
{
    public class RAM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public int Frequency { get; set; }
    }
}