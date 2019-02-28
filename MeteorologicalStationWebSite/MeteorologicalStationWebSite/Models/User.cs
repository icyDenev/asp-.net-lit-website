using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeteorologicalStationWebSite.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string RealName { get; set; }

        public int AccessLevel { get; set; }
    }
}
