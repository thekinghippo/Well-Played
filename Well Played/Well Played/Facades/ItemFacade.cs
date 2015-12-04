using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Well_Played.Models;

namespace Well_Played.Facades
{
    class ItemFacade
    {
        private const string apikey = "b2d88c91-7e1f-4ffb-87b9-6052306595c4";

        //public static async Task<Dictionary<string, Well_Played.Models.Item>> GetItemList()
        public static async Task<Well_Played.Models.ItemList> GetItemList()
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/item?itemListData=all&api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();
            jsonMessage = jsonMessage.Replace(@"""base""", @"""baseGold""");

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(ItemList), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ItemList)serializer.ReadObject(ms);

            //var result = notquiteresult.data;

            return result;
        }

        //Populate the Items Page
        public async static Task PopulateLeagueItems(ObservableCollection<Models.Item> leagueItemsAsync, ObservableCollection<Models.Item> FullleagueItemsAsync, Models.ItemList ListOfItems, string Filter, Dictionary<string, bool> ChkBoxFilters)
        {
            //var itemDataWrapper = await GetItemList();
            var items = ListOfItems.data;
            var version = ListOfItems.version;

            List<KeyValuePair<string, Well_Played.Models.Item>> list = items.OrderBy(x => x.Value.name).ToList();

            foreach (KeyValuePair<string, Well_Played.Models.Item> item in list)
            {
                if (item.Value.name.Count() > 6)
                {
                    string EnchantCheck = item.Value.name.Substring(0, 7);
                    if (EnchantCheck != "Enchant")
                    {
                        item.Value.imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}", item.Value.image.full, version);
                        if (item.Value.name.Contains("("))
                        {
                            int startremovingfrom = item.Value.name.IndexOf("(");
                            int Stopremovinghere = item.Value.name.IndexOf(")", startremovingfrom + 1);
                            item.Value.name = item.Value.name.Remove(startremovingfrom, Stopremovinghere - startremovingfrom + 1);
                        }
                        leagueItemsAsync.Add(item.Value);
                        FullleagueItemsAsync.Add(item.Value);   
                    }
                }
            }
        }        

        public async static Task FilterLeagueItems(ObservableCollection<Models.Item> leagueItemsAsync, ObservableCollection<Models.Item> FullleagueItemsAsync, string Filter, Dictionary<string, bool> ChkBoxFilters)
        {
            //var itemDataWrapper = await GetItemList();
            var items = FullleagueItemsAsync;

            List<Models.Item> list = items.ToList();

            //string version = await LeagueFacade.GetVersion();

            foreach (Well_Played.Models.Item item in list)
            {
                leagueItemsAsync.Add(item);

                if (Filter == "SR" && item.maps["11"] == false)
                {
                    leagueItemsAsync.Remove(item);
                }
                else if (Filter == "TT" && item.maps["10"] == false)
                {
                    leagueItemsAsync.Remove(item);
                }
                else if (Filter == "HA" && item.maps["12"] == false)
                {
                    leagueItemsAsync.Remove(item);
                }
                else if (Filter == "CS" && item.maps["8"] == false)
                {
                    leagueItemsAsync.Remove(item);
                }
                
                //Runs through filters
                if (ChkBoxFilters["Damage"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Damage"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["CritStrike"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("CriticalStrike"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["AtkSpeed"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("AttackSpeed"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    {
                        leagueItemsAsync.Remove(item);
                    }
                }
                if (ChkBoxFilters["LifeSteal"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("LifeSteal"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["AbilityPower"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("SpellDamage"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["CDR"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("CooldownReduction"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["Mana"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Mana"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["ManaRegen"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("ManaRegen"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["Health"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Health"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["MagicResist"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("SpellBlock"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["HealthRegen"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("HealthRegen"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["Armor"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Armor"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["Movement"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Boots") || item.tags.Contains("NonbootsMovement"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["Consumables"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Consumable"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["GoldIncome"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("GoldPer"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
                if (ChkBoxFilters["Vision"] == true)
                {
                    if (item.tags != null)
                    {
                        if (item.tags.Contains("Vision"))
                        { }
                        else
                        { leagueItemsAsync.Remove(item); }
                    }
                    else
                    { leagueItemsAsync.Remove(item); }
                }
            }
        }
    }
}
