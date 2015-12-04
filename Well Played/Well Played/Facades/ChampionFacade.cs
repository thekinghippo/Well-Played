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
    class ChampionFacade
    {
        private const string apikey = "b2d88c91-7e1f-4ffb-87b9-6052306595c4";

        public static async Task<ChampionList> GetChampionFullDataList()
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?champData=all&api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(ChampionList), new DataContractJsonSerializerSettings()
            {
                UseSimpleDictionaryFormat = true
            });
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ChampionList)serializer.ReadObject(ms);
            return result;
        }
        
        //Populate the Champions Page
        public static async Task PopulateLeagueChampionsAsync(ObservableCollection<Well_Played.Models.Champion> leagueChampionsAsync, ObservableCollection<Models.Champion> FullleagueChampionsAsync, Models.ChampionList ListOfChampions)
        {
            var champions = ListOfChampions.data;
            var version = ListOfChampions.version;

            List<KeyValuePair<string, Well_Played.Models.Champion>> list = champions.OrderBy(x => x.Value.name).ToList();

            foreach (KeyValuePair<string, Well_Played.Models.Champion> pair in list)
            {
                pair.Value.thumbnail = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/champion/{0}", pair.Value.image.full, version);
                leagueChampionsAsync.Add(pair.Value);
                FullleagueChampionsAsync.Add(pair.Value);
            }
        }

        public async static Task FilterLeagueChampions(ObservableCollection<Models.Champion> leagueChampionsAsync, ObservableCollection<Models.Champion> FullleagueChampionsAsync, string Filter)
        {
            var champions = FullleagueChampionsAsync;

            List<Models.Champion> list = champions.ToList();

            foreach (Models.Champion champion in list)
            {
                leagueChampionsAsync.Add(champion);

                if (Filter == "All" || champion.tags.Contains(Filter))
                { }
                else
                {
                    leagueChampionsAsync.Remove(champion);
                }
            }
        }


        //******************************************************************************************************************************
        //******************************************************************************************************************************
        //******************************************************************************************************************************


        public static async Task<ChampionList> GetFreeWeekChampionList()
        {
            //Assemble the URL
            string url = string.Format("https://na.api.pvp.net/api/lol/na/v1.2/champion?freeToPlay=true&api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(ChampionList));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ChampionList)serializer.ReadObject(ms);
            return result;
        }

        //Populate the Champions Page
        public static async Task PopulateFreeWeekChampionsList(ObservableCollection<Well_Played.Models.Champion> FreeWeekChampions, Models.ChampionList ListOfFreeWeekChampions)
        {
            var champions = ListOfFreeWeekChampions.champions;
            var version = await GetVersion();

            //List<KeyValuePair<string, Well_Played.Models.Champion>> list = champions.ToList();

            foreach (Models.Champion champion in champions)
            {
                Models.Champion result = await GetNameImage(champion.id.ToString(), version.ToString());
                FreeWeekChampions.Add(result);
            }
        }

        //Get some details + image
        public static async Task<Well_Played.Models.Champion> GetNameImage(string ChampID, string version)
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion/{0}?champData=image,tags&api_key={1}", ChampID, apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.Champion));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (Well_Played.Models.Champion)serializer.ReadObject(ms);

            result.thumbnail = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/champion/{0}", result.image.full, version);

            return result;
        }

        //Get CHAMPION's name from ID (string SummonerRegion unnessecary)
        public async static Task<Well_Played.Models.Champion> GetChampionData(string ChampID)
        {
            //Assemble the url
            var url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion/{0}?api_key={1}", ChampID, apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.Champion));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            //var result = (SummonerData)serializer.ReadObject(ms);
            var result = (Well_Played.Models.Champion)serializer.ReadObject(ms);

            return result;
        }

        public static async Task<ChampionList> GetChampionList()
        {
            //Assemble the URL
            string url = string.Format("https://na.api.pvp.net/api/lol/na/v1.2/champion?&api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(ChampionList));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ChampionList)serializer.ReadObject(ms);
            return result;
        }

        //Get the FULL ENCHILADA CHAMPION
        public static async Task<Well_Played.Models.Champion> GetChampion(string ChampID)
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion/{0}?champData=all&api_key={1}", ChampID, apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.Champion));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (Well_Played.Models.Champion)serializer.ReadObject(ms);
            return result;
        }

        //Get Version
        public static async Task<string> GetVersion()
        {
            //Assemble the URL
            string url = string.Format("https://global.api.pvp.net/api/lol/static-data/na/v1.2/versions?api_key={0}", apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            int startsubstringfrom = jsonMessage.IndexOf("[") + 2;
            int stopsubstringat = jsonMessage.IndexOf(",") - 1;
            string result = jsonMessage.Substring(startsubstringfrom, stopsubstringat - startsubstringfrom);

            return result;
        }
    }
}
