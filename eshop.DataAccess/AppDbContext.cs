using eshop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<ComputerDetail> ComputerDetails { get; set; }
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<Market> Market { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Printer> Printers { get; set; }
    }
}
