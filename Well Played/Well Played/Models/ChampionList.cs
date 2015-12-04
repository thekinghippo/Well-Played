using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Well_Played.Models
{
    public class ChampionList
    {
        public Dictionary<string, Well_Played.Models.Champion> data { get; set; }
        public string format { get; set; }
        public Dictionary<string, string> keys { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public long modifyDate { get; set; }
        public List<Champion> champions { get; set; }
        public int summonerId { get; set; }
    }

    public class Champion
    {
        public List<string> allytips { get; set; }
        public string blurb { get; set; }
        public List<string> enemytips { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public Info info { get; set; }
        public string key { get; set; }
        public string lore { get; set; }
        public string name { get; set; }
        public string partype { get; set; }
        public Passive passive { get; set; }
        public List<Recommended> recommended { get; set; }
        public List<Skin> skins { get; set; }
        public List<ChampionSpell> spells { get; set; }
        public RankedStats stats { get; set; }
        public List<string> tags { get; set; }
        public string title { get; set; }

        public string thumbnail { get; set; }

    }

    public class BlockItem
    {
        public int count { get; set; }
        public int id { get; set; }
    }

    public class Block
    {
        public List<BlockItem> items { get; set; }
        public bool recMath { get; set; }
        public string type { get; set; }
    }

    public class LevelTip
    {
        public List<string> effect { get; set; }
        public List<string> label { get; set; }
    }

    public class SpellVars
    {
        public List<double> coeff { get; set; }
        public string dyn { get; set; }
        public string key { get; set; }
        public string link { get; set; }
        public string ranksWith { get; set; }
    }

    public class Image
    {
        public string full { get; set; }
        public string group { get; set; }
        public int h { get; set; }
        public string sprite { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public string url { get; set; }
    }

    public class Info
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int difficulty { get; set; }
        public int magic { get; set; }
    }

    public class Passive
    {
        public string description { get; set; }
        public Image image { get; set; }
        public string name { get; set; }
        public string sanitizedDescription { get; set; }
    }

    public class Recommended
    {
        public List<Block> blocks { get; set; }
        public string champion { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public bool priority { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }

    public class Skin
    {
        public int id { get; set; }
        public string name { get; set; }
        public int num { get; set; }
    }

    public class ChampionSpell
    {
        public List<Image> altimages { get; set; }
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<object> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public Image image { get; set; }
        public string key { get; set; }
        public LevelTip leveltip { get; set; }
        public int maxrank { get; set; }
        public string name { get; set; }
        public object range { get; set; }
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public string tooltip { get; set; }
        public List<SpellVars> vars { get; set; }
    }

    public class RankedStats
    {
        public int totalDeathsPerSession { get; set; }
        public int totalSessionsPlayed { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalQuadraKills { get; set; }
        public int totalTripleKills { get; set; }
        public int totalMinionKills { get; set; }
        public int maxChampionsKilled { get; set; }
        public int totalDoubleKills { get; set; }
        public int totalPhysicalDamageDealt { get; set; }
        public int totalChampionKills { get; set; }
        public int totalAssists { get; set; }
        public int mostChampionKillsPerSession { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalFirstBlood { get; set; }
        public int totalSessionsLost { get; set; }
        public int totalSessionsWon { get; set; }
        public int totalMagicDamageDealt { get; set; }
        public int totalGoldEarned { get; set; }
        public int totalPentaKills { get; set; }
        public int totalTurretsKilled { get; set; }
        public int mostSpellsCast { get; set; }
        public int maxNumDeaths { get; set; }
        public int totalUnrealKills { get; set; }
        public int? maxLargestCriticalStrike { get; set; }
        public int? rankedPremadeGamesPlayed { get; set; }
        int? totalNeutralMinionsKilled { get; set; }
        public int? maxLargestKillingSpree { get; set; }
        public int? maxTimeSpentLiving { get; set; }
        public int? maxTimePlayed { get; set; }
        public int? botGamesPlayed { get; set; }
        public int? killingSpree { get; set; }
        public int? rankedSoloGamesPlayed { get; set; }
        public int? totalHeal { get; set; }
        public int? normalGamesPlayed { get; set; }

        public double armor { get; set; }
        public double armorperlevel { get; set; }
        public double attackdamage { get; set; }
        public double attackdamageperlevel { get; set; }
        public double attackrange { get; set; }
        public double attackspeedoffset { get; set; }
        public double attackspeedperlevel { get; set; }
        public double crit { get; set; }
        public double critperlevel { get; set; }
        public double hp { get; set; }
        public double hpperlevel { get; set; }
        public double hpregen { get; set; }
        public double hpregenperlevel { get; set; }
        public double movespeed { get; set; }
        public double mp { get; set; }
        public double mpperlevel { get; set; }
        public double mpregen { get; set; }
        public double mpregenperlevel { get; set; }
        public double spellblock { get; set; }
        public double spellblockperlevel { get; set; }
    }
}
