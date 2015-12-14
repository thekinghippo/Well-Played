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
    class SpellFacade
    {
        private const string apikey = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";

        //Retrieves summoner spell id, description, name, image {w, full, sprite, group, h, y, x}, key, summonerLevel
        public static async Task<Well_Played.Models.SpellList> GetPartialSpellList()
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/summoner-spell?spellData=image&api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.SpellList), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (Well_Played.Models.SpellList)serializer.ReadObject(ms);

            //var result = notquiteresult.data;

            return result;
        }

        public static async Task<Well_Played.Models.SpellList> GetSpellList()
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/summoner-spell?spellData=all&api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.SpellList), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (Well_Played.Models.SpellList)serializer.ReadObject(ms);

            //var result = notquiteresult.data;

            return result;
        }

        //Populate the Items Page
        public async static Task PopulateSummonerSpells(ObservableCollection<Models.SummonerSpell> SummonerSpellsAsync, Models.SpellList ListOfSpells)
        {
            //var itemDataWrapper = await GetItemList();
            var spells = ListOfSpells.data;
            var version = ListOfSpells.version;

            List<KeyValuePair<string, Well_Played.Models.SummonerSpell>> list = spells.OrderBy(x => x.Value.name).ToList();

            foreach (KeyValuePair<string, Well_Played.Models.SummonerSpell> spell in list)
            {
                spell.Value.image.url = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", spell.Value.image.full, version);

                SummonerSpellsAsync.Add(spell.Value);
            }
        }

        public static async Task<Well_Played.Models.SummonerSpell> GetPartialSpell(int id)
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/summoner-spell/{1}?spellData=image&api_key={0}", apikey, id);

            //Call out to RIOT
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.SummonerSpell));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (Well_Played.Models.SummonerSpell)serializer.ReadObject(ms);

            //var result = notquiteresult.data;

            return result;
        }


    }
}
