using MeteorologicalStationWebSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeteorologicalStationWebSite.Data
{
    public class MeteorologicalStationsDBContext : DbContext
    {
        DbSet<User> Users { get; set; }

        DbSet<SensorsData> Sensors { get; set; }

        public MeteorologicalStationsDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MeteorologicalStationsDB;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
