using BlueJays.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlueJays.Controllers
{
    public class HomeController : Controller
    {

        WebServiceController webService = new WebServiceController();

        public async Task<ActionResult> Index()
        {
            var model = await webService.GetTeams();
            var teams = model.teams;

            List<IEnumerable<Teams>> mlb = new List<IEnumerable<Teams>>();

            var americanLeagueEast = teams.Where(m => m.league.name == "American League").Where(m => m.division.name == "American League East");

            var americanLeagueCentral = teams.Where(m => m.league.name == "American League").Where(m => m.division.name == "American League Central");

            var americanLeagueWest = teams.Where(m => m.league.name == "American League").Where(m => m.division.name == "American League West");

            var nationalLeagueEast = teams.Where(m => m.league.name == "National League").Where(m => m.division.name == "National League East");

            var nationalLeagueCentral = teams.Where(m => m.league.name == "National League").Where(m => m.division.name == "National League Central");

            var nationalLeagueWest = teams.Where(m => m.league.name == "National League").Where(m => m.division.name == "National League West");

            mlb.Add(americanLeagueEast);
            mlb.Add(americanLeagueCentral);
            mlb.Add(americanLeagueWest);
            mlb.Add(nationalLeagueEast);
            mlb.Add(nationalLeagueCentral);
            mlb.Add(nationalLeagueWest);

            return View(mlb);
        }

        public async Task<ActionResult> Roster(int id, string name)
        {
            var model = await webService.GetRoster(id);
            var roster = model.roster;
            ViewBag.name = name;

            List<IEnumerable<Roster>> positions = new List<IEnumerable<Roster>>();

            var firstBase = roster.Where(m => m.position.abbreviation == "1B");

            var secondBase = roster.Where(m => m.position.abbreviation == "2B");

            var shortStop = roster.Where(m => m.position.abbreviation == "SS");

            var thirdBase = roster.Where(m => m.position.abbreviation == "3B");

            var outFielder = roster.Where(m => m.position.name == "Outfielder");

            var pitcher = roster.Where(m => m.position.abbreviation == "P");

            positions.Add(firstBase);

            positions.Add(secondBase);

            positions.Add(shortStop);

            positions.Add(thirdBase);

            positions.Add(outFielder);

            positions.Add(pitcher);

            return View(positions);
        }

        public async Task<ActionResult> Player(int id)
        {
            var model = await webService.GetPlayer(id);
            var roster = model.people;
            return View(roster);
        }
    }
}