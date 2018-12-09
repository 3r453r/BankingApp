using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAppEFCorePersistence
{
    public class BankingAppContext : DbContext
    {
        DbSet<Person> People;
        DbSet<Client> Clients;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Database.EnsureDeleted();
            Database.Migrate();
        }
    }
}
