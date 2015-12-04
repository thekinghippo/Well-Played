using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Well_Played.Models
{
    public class SpellList
    {
        public Dictionary<string, Models.SummonerSpell> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class SummonerSpell
    {
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<object> effect { get; set; } //field is a List of List of Double
        public List<string> effectBurn { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string key { get; set; }
        public LevelTip leveltip { get; set; }
        public int maxrank { get; set; }
        public List<string> modes { get; set; }
        public string name { get; set; }
        public object range { get; set; } //field is either a List of Integer or the String 'self' for spells that target one's own champion
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public int summonerLevel { get; set; }
        public string tooltip { get; set; }
        public List<SpellVars> vars { get; set; }
    }

    //Image object appears elsewhere
    //SpellVars object appears elsewhere
}
