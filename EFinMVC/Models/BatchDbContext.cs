using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFinMVC.Models
{
    public class BatchDbContext : DbContext
    {
        public DbSet<Batch> Batches { get; set; }
        public DbSet<User> Users { get; set; }
    }
}