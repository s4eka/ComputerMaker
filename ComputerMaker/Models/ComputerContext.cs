using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ComputerMaker.Models
{
    public class ComputerContext : DbContext
    {
        public DbSet<Motherboard> Motherboards { get; set; }
        
    }
}