using EZTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EZTest.Context
{
    public class EZTestDbContext : DbContext
    {
        public EZTestDbContext()
           : base("EZTestDbContext")
        {

        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Adress> Adresses { get; set; } // ToDo dodać reszte tabel

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<EZTest.Models.Test> Tests { get; set; }
    }
}