

using EstruturaDDDCore.DomainT.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

public class ModeloContexto : DbContext

{


    public DbSet<Cliente> Clientes { get; set; }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {



        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));



    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>()
            .Property(e => e.Nome)
            .HasColumnType("varchar(150)")
            .IsRequired();

        modelBuilder.Entity<Cliente>()
            .ToTable("Cliente");

    }

}
