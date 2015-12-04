using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Well_Played.Models
{
    public class League
    {
        public string queue { get; set; }
        public string name { get; set; }
        public List<Summoner> summoners { get; set; }
        public string tier { get; set; }
    }

    public class Summoner
    {
        public int leaguePoints { get; set; }
        public bool isFreshBlood { get; set; }
        public bool isHotStreak { get; set; }
        public string division { get; set; }
        public bool isInactive { get; set; }
        public bool isVeteran { get; set; }
        public int losses { get; set; }
        public string playerOrTeamName { get; set; }
        public string playerOrTeamId { get; set; }
        public int wins { get; set; }
        public string name { get; set; }
        public string tier { get; set; }
        public long id { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public long summonerLevel { get; set; }
    }
}
