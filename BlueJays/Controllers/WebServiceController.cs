using BlueJays.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BlueJays.Controllers
{
    public class WebServiceController : ApiController
    {

        public async Task<StatsTeamsClass> GetTeams()
        {
            HttpClient Http = new HttpClient();
            var json = await Http.GetStringAsync("https://statsapi.mlb.com/api/v1/teams?sportId=1");
            StatsTeamsClass teams = JsonConvert.DeserializeObject<StatsTeamsClass>(json);
            return teams;
        }

        public async Task<StatsRosterClass> GetRoster(int id)
        {

            HttpClient Http = new HttpClient();
            var json = await Http.GetStringAsync("https://statsapi.mlb.com/api/v1/teams/" + id + "/roster");
            StatsRosterClass roster = JsonConvert.DeserializeObject<StatsRosterClass>(json);

            return roster;
        }
         
        public async Task<StatsPlayerClass> GetPlayer(int id)
        {

            HttpClient Http = new HttpClient();
            var json = await Http.GetStringAsync("https://statsapi.mlb.com/api/v1/people/" + id + "?hydrate=stats(group=[hitting,pitching],type=[yearByYear])");
            StatsPlayerClass player = JsonConvert.DeserializeObject<StatsPlayerClass>(json);

            return player;
        }
    }
}
