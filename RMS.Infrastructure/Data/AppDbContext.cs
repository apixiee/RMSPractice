using Microsoft.EntityFrameworkCore;
using RMS.Domain.Entities;

namespace RMS.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CampusEquipementDB;Integrated " +
                "Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }

    }
}
