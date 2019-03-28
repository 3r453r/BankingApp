using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAppEFCorePersistence
{
    internal class BankingAppContext : DbContext
    {
        internal static BankingAppContext Context { get; } = new BankingAppContext();

        public DbSet<Person> People { get; set; }
        public DbSet<Client> Clients { get; set; }

        private BankingAppContext() : base()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
    }
}
