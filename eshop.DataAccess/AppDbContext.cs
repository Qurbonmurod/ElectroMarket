using eshop.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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
        
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
