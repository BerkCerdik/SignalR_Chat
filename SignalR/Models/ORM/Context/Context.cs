using Microsoft.EntityFrameworkCore;
using SignalR.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models.ORM.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=localhost\SQLEXPRESS;database=ChatDB;trusted_connection=true;");
        }

        public DbSet<User> Users{ get; set; }
    }
}
