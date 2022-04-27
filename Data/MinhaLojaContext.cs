#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaLoja.Models;

namespace MinhaLoja.Data
{
    public class MinhaLojaContext : DbContext
    {
        public MinhaLojaContext (DbContextOptions<MinhaLojaContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
