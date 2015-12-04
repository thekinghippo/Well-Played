using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Well_Played.Models
{

    public class ItemList
    {
        public BasicData basic { get; set; }
        public Dictionary<string, Well_Played.Models.Item> data { get; set; }
        public List<Group> groups { get; set; }
        public List<ItemTree> tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }

    public class Item
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public Gold gold { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string imageURL { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaData rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStats stats { get; set; }
        public List<string> tags { get; set; }
    }

    public class MetaData
    {
        public bool isRune { get; set; }
        public string tier { get; set; }
        public string type { get; set; }
    }

    public class Gold
    {
        public int baseGold { get; set; }
        public bool purchasable { get; set; }
        public int sell { get; set; }
        public int total { get; set; }
    }

    public class BasicDataStats
    {
        public double FlatArmorMod { get; set; }
        public double FlatAttackSpeedMod { get; set; }
        public double FlatBlockMod { get; set; }
        public double FlatCritChanceMod { get; set; }
        public double FlatCritDamageMod { get; set; }
        public double FlatEXPBonus { get; set; }
        public double FlatEnergyPoolMod { get; set; }
        public double FlatEnergyRegenMod { get; set; }
        public double FlatHPPoolMod { get; set; }
        public double FlatHPRegenMod { get; set; }
        public double FlatMPPoolMod { get; set; }
        public double FlatMPRegenMod { get; set; }
        public double FlatMagicDamageMod { get; set; }
        public double FlatMovementSpeedMod { get; set; }
        public double FlatPhysicalDamageMod { get; set; }
        public double FlatSpellBlockMod { get; set; }
        public double PercentArmorMod { get; set; }
        public double PercentAttackSpeedMod { get; set; }
        public double PercentBlockMod { get; set; }
        public double PercentCritChanceMod { get; set; }
        public double PercentCritDamageMod { get; set; }
        public double PercentDodgeMod { get; set; }
        public double PercentEXPBonus { get; set; }
        public double PercentHPPoolMod { get; set; }
        public double PercentHpRegenMod { get; set; }
        public double PercentLifeStealMod { get; set; }
        public double PercentMPPool { get; set; }
        public double PercentMPRegen { get; set; }
        public double PercentMagicDamageMod { get; set; }
        public double PercentMovementSpeedMod { get; set; }
        public double PercentPhysicalDamageMod { get; set; }
        public double PercentSpellBlockMod { get; set; }
        public double PercentSpellVampMod { get; set; }
        public double rFlatArmorModPerLevel { get; set; }
        public double rFlatArmorPenetrationMod { get; set; }
        public double rFlatArmorPenetrationModPerLevel { get; set; }
        public double rFlatCritChanceModPerLevel { get; set; }
        public double rFlatCritDamageModPerLevel { get; set; }
        public double rFlatDodgeMod { get; set; }
        public double rFlatDodgeModPerLevel { get; set; }
        public double rFlatEnergyModPerLevel { get; set; }
        public double rFlatEnergyRegenModPerLevel { get; set; }
        public double rFlatGoldPer10Mod { get; set; }
        public double rFlatHPModPerLevel { get; set; }
        public double rFlatMPRegenModPerLevel { get; set; }
        public double rFlatMagicDamageModPerLevel { get; set; }
        public double rFlatMagicPenetrationMod { get; set; }
        public double rFlatMagicPenetrationModPerLevel { get; set; }
        public double rFlatMovementSpeedModPerLevel { get; set; }
        public double rFlatPhysicalDamageModPerLevel { get; set; }
        public double rFlatSpellBlockModPerLevel { get; set; }
        public double rFlatTimeDeadMod { get; set; }
        public double rFlatTimeDeadModPerLevel { get; set; }
        public double rPercentArmorPenetrationMod { get; set; }
        public double rPercentArmorPenetrationModPerLevel { get; set; }
        public double rPercentAttackSpeedModPerLevel { get; set; }
        public double rPercentCooldownMod { get; set; }
        public double rPercentCooldownModPerLevel { get; set; }
        public double rPercentMagicPenetrationMod { get; set; }
        public double rPercentMagicPenetrationModPerLevel { get; set; }
        public double rPercentMovementSpeedModPerLevel { get; set; }
        public double rPercentTimeDeadMod { get; set; }
        public double rPercentTimeDeadModPerLevel { get; set; }
    }

    public class ItemTree
    {
        public string header { get; set; }
        public List<string> tags { get; set; }
    }

    public class Group
    {
        public string maxGroupOwnable { get; set; }
        public string key { get; set; }
    }

    public class BasicData
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public Gold gold { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public bool inStore { get; set; }
        public List<string> info { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaData rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStats stats { get; set; }
        public List<string> tags { get; set; }
    }
}
