using System;
using System.Collections.Generic;
using System.Text;
using DBStructure.Data.DAL;
using Microsoft.EntityFrameworkCore;
using DBStructure.Data.Models;

namespace DBStructure.Data.DAL
{
    internal class StoreDbContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Comments> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WINDOWS-CP40MBP\SQLEXPRESS01;Database=Store2;Trusted_Connection=TRUE");
        }
    }
}
