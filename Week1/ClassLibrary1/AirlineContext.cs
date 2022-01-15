using Assing1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Week1.Models;

namespace ClassLibrary1
{
    public class AirlineContext:DbContext
    {
        public AirlineContext()
        {
        }

        public AirlineContext(DbContextOptions<AirlineContext> options) : base(options) { }

        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<Airplane_company> Airplane_companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AirlineBC; integrated security = true");
        }
        

    }
}
