using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ComputerMaker.Models
{
    public class ComputerContext : DbContext
    {
        DbSet<Motherboard> Motherboard { get; set; }
    }
}