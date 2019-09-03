using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJays.Models
{
    public class StatsPlayerClass
    {
        public IEnumerable<Player> people { get; set; }
    }

    public class Player
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string primaryNumber { get; set; }
        public string birthDate { get; set; }
        public string currentAge { get; set; }
        public string birthCity { get; set; }
        public string birthStateProvince { get; set; }
        public string birthCountry { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public bool active { get; set; }
        public Position primaryPosition { get; set; }
        public string useName { get; set; }
        public string middleName { get; set; }
        public string boxscoreName { get; set; }
        public string gender { get; set; }
        public bool isPlayer { get; set; }
        public bool isVerified { get; set; }
        public int draftYear { get; set; }
        public BatClass batSide { get; set; }
        public PitchClass pitchHand { get; set; }
        public string nameFirstLast { get; set; }
        public string nameSlug { get; set; }
        public string firstLastName { get; set; }
        public string lastFirstName { get; set; }
        public string lastInitName { get; set; }
        public string initLastName { get; set; }
        public string fullFMLName { get; set; }
        public string fullLFMName { get; set; }
        public double strikeZoneTop { get; set; }
        public double strikeZoneBottom { get; set; }
        public string nickName { get; set; }
        public string mlbDebutDate { get; set; }
        public IEnumerable<Stats> stats { get; set; }


    }

    public class BatClass
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class PitchClass
    {
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Stats
    {
        public IEnumerable<Splits> splits { get; set; }
        public Group group { get; set; }

    }

    public class Group
    {
        public string displayName { get; set; }
    }

    public class Splits
    {
        public string season { get; set; }
        public Stat stat { get; set; }
        public Teams team { get; set; }
        public League league { get; set; }
    }

    public class Stat
    {
        public int gamesPlayed { get; set; }
        public int atBats { get; set; }
        public int runs { get; set; }
        public int hits { get; set; }
        public int totalBases { get; set; }
        public int doubles { get; set; }
        public int triples { get; set; }
        public int homeRuns { get; set; }
        public int rbi { get; set; }
        public int baseOnBalls { get; set; }
        public int intentionalWalks { get; set; }
        public int strikeOuts { get; set; }
        public int stolenBases { get; set; }
        public int caughtStealing { get; set; }
        public string avg { get; set; }
        public string obp { get; set; }
        public string slg { get; set; }
        public string ops { get; set; }
        public string groundOutsToAirouts { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public string era { get; set; }
        public int gamesStarted { get; set; }
        public int completeGames { get; set; }
        public int shutouts { get; set; }
        public int holds { get; set; }
        public int saves { get; set; }
        public int saveOpportunities { get; set; }
        public string inningsPitched { get; set; }
        public int earnedRuns { get; set; }
        public int numberOfPitches { get; set; }
        public int hitBatsmen { get; set; }
        public string whip { get; set; }
        public int sacFlies { get; set; }
        public int hitByPitch { get; set; }
        public int groundOuts { get; set; }
        public int airOuts { get; set; }

    }
}