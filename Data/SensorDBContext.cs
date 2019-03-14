using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LitWebSite.Models;

namespace LitWebSite.Data
{
    public class SensorDBContext : DbContext
    {
        DbSet<Sensors> SensorsData { get; set; }

        public SensorDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SensorsDB;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
