using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeteorologicalStationWebSite.Models
{
    public class SensorsData
    {
        public int Id { get; set; }

        public double CO { get; set; }

        public double CO2 { get; set; }

        public double NO2 { get; set; }

        public double O3 { get; set; }

        public double PM25 { get; set; }
    }
}
