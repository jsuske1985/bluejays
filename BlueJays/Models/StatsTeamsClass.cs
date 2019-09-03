using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJays.Models
{
    public class StatsTeamsClass
    {
        public IEnumerable<Teams> teams { get; set; }
        public string copyright { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }
    public class Division
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Teams
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public League league { get; set; }
        public Division division { get; set; }
    }
}