using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Well_Played.Facades
{
    class LeagueFacade
    {
        private const string apikey = "b2d88c91-7e1f-4ffb-87b9-6052306595c4";
        //private static Champion result;


        //Get SUMMONER objects mapped by standardized summoner name for a given list of summoner names.
        //id, name, profileIconId, revisionDate, summonerLevel
        public async static Task<Well_Played.Models.Summoner> GetSummonerData(string SummonerName, string SummonerRegion)
        {
            //Assemble the URL
            string url = string.Format("https://{0}.api.pvp.net/api/lol/{0}/v1.4/summoner/by-name/{1}?api_key={2}", SummonerRegion, SummonerName, apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //If characters 2 through 8 = Status throw an error
            var prepSummonerName = SummonerName;
            prepSummonerName = prepSummonerName.Replace(" ", "");
            prepSummonerName = prepSummonerName.ToLower();

            string errorChecking = jsonMessage.Substring(2, prepSummonerName.Length);

            if (errorChecking == prepSummonerName)
            {
                //Converts RIOT's garbage json into a usable object                
                int startremovingfrom = jsonMessage.IndexOf("{");
                int Stopremovinghere = jsonMessage.IndexOf("{", startremovingfrom + 1);

                jsonMessage = jsonMessage.Remove(startremovingfrom, Stopremovinghere - startremovingfrom);
                jsonMessage = jsonMessage.TrimEnd('}');
            }
            else
            {
                //{ "id":23386714,"name":"NC KingHippo","profileIconId":774,"summonerLevel":30,"revisionDate":1444605638000}

                jsonMessage = @"{""id"":23386714,""name"":""ThisIsNotTheSummonerYoureLookingFor"",""profileIconId"":774,""summonerLevel"":30,""revisionDate"":1444605638000}";
            }

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Well_Played.Models.Summoner));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            //var result = (SummonerData)serializer.ReadObject(ms);
            var result = (Well_Played.Models.Summoner)serializer.ReadObject(ms);

            return result;
        }
        
        //Get most played CHAMPION from ranked stats
        public static async Task GetSummonerMostPlayedChamps(ObservableCollection<Well_Played.Models.Champion> MostPlayedChampionsAsync, string summonerID, string SummonerRegion, string version)
        {
            var championDataWrapper = await GetSummonerRankedStats(summonerID, SummonerRegion);

            if (championDataWrapper.format != "nothere")
            {
                var champions = championDataWrapper.champions; //POTENTIAL ERROR

                List<Well_Played.Models.Champion> list = champions.OrderByDescending(x => x.stats.totalSessionsPlayed).ThenByDescending(x => x.stats.totalSessionsWon).ToList();

                //List<Well_Played.Models.Champion> MostPlayed = new List<Well_Played.Models.Champion>();
                List<KeyValuePair<string, Models.Champion>> MostPlayed = new List<KeyValuePair<string, Models.Champion>>()
                {

                };
                switch (list.Count - 1)
                {

                    case 1:
                        MostPlayed.Insert(0, new KeyValuePair<string, Models.Champion>("Champ", list[0]));
                        break;
                    case 2:
                        MostPlayed.Insert(0, new KeyValuePair<string, Models.Champion>("Champ", list[1]));
                        MostPlayed.Insert(1, new KeyValuePair<string, Models.Champion>("RunnerUp", list[2]));
                        break;
                    case 3:
                        MostPlayed.Insert(0, new KeyValuePair<string, Models.Champion>("Champ", list[1]));
                        MostPlayed.Insert(1, new KeyValuePair<string, Models.Champion>("RunnerUp", list[2]));
                        MostPlayed.Insert(2, new KeyValuePair<string, Models.Champion>("Third", list[3]));
                        break;
                    case 4:
                        MostPlayed.Insert(0, new KeyValuePair<string, Models.Champion>("Champ", list[1]));
                        MostPlayed.Insert(1, new KeyValuePair<string, Models.Champion>("RunnerUp", list[2]));
                        MostPlayed.Insert(2, new KeyValuePair<string, Models.Champion>("Third", list[3]));
                        MostPlayed.Insert(3, new KeyValuePair<string, Models.Champion>("Forth", list[4]));
                        break;
                    default:
                        MostPlayed.Insert(0, new KeyValuePair<string, Models.Champion>("Champ", list[1]));
                        MostPlayed.Insert(1, new KeyValuePair<string, Models.Champion>("RunnerUp", list[2]));
                        MostPlayed.Insert(2, new KeyValuePair<string, Models.Champion>("Third", list[3]));
                        MostPlayed.Insert(3, new KeyValuePair<string, Models.Champion>("Forth", list[4]));
                        MostPlayed.Insert(4, new KeyValuePair<string, Models.Champion>("BoobyPrize", list[5]));
                        break;
                }



                /**                new KeyValuePair<string, Models.Champion>("RunnerUp", list[2]),
                    new KeyValuePair<string, Models.Champion>("Third", list[3]),
                    new KeyValuePair<string, Models.Champion>("Forth", list[4]),
                    new KeyValuePair<string, Models.Champion>("BoobyPrize", list[5]),**/

                foreach (KeyValuePair<string, Well_Played.Models.Champion> pair in MostPlayed)
                {
                    if (pair.Value != null)
                    {
                        //Get Champion name from ID number
                        Well_Played.Models.Champion myChampionData = await ChampionFacade.GetNameImage(pair.Value.id.ToString(), version);

                        pair.Value.name = myChampionData.name;
                        pair.Value.image = myChampionData.image;
                        MostPlayedChampionsAsync.Add(pair.Value);
                    }
                }
            }            

            //return MostPlayedChampionsAsync;
        }

        // Get ranked stats by summoner ID.
        public async static Task<Well_Played.Models.ChampionList> GetSummonerRankedStats(string SummonerID, string SummonerRegion)
        {
            //Assemble the URL
            string url = string.Format("https://{0}.api.pvp.net/api/lol/{0}/v1.3/stats/by-summoner/{1}/ranked?season=SEASON2015&api_key={2}", SummonerRegion, SummonerID, apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);

            Models.ChampionList result = null;
            string jsonMessage = string.Empty;
            if (response.IsSuccessStatusCode == true)
            {
                jsonMessage = await response.Content.ReadAsStringAsync();
                //Response -> string / json -> deserialize
                var serializer = new DataContractJsonSerializer(typeof(Models.ChampionList));
                var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

                //var result = (SummonerData)serializer.ReadObject(ms);
                result = (Models.ChampionList)serializer.ReadObject(ms);
            }
            else
            {
                result = new Models.ChampionList { format = "nothere" };
            }
            return result;
        }

        //Get most ranked average data from ranked stats
        public static async Task<Models.RankedStats> GetRankedStatTotals(string summonerID, string SummonerRegion)
        {
            Models.RankedStats result = null;

            var championDataWrapper = await GetSummonerRankedStats(summonerID, SummonerRegion);

            if (championDataWrapper.format != "nothere")
            {
                var champions = championDataWrapper.champions; //POTENTIAL ERROR

                foreach (var champion in champions)
                {
                    if (champion.id == 0)
                    {
                        Models.RankedStats myStats = champion.stats;

                        result = myStats;
                    }
                }
            }
            else
            {
                result = new Models.RankedStats { totalSessionsPlayed = 0 };
            }

            //result player stat totals in ranked
            return result;
        }

        //Get most played CHAMPION from ranked stats
        public static async Task<Well_Played.Models.Summoner> GetEntry(string summonerID, string SummonerRegion)
        {
            Well_Played.Models.Summoner result = null;

            var entryDataWrapper = await GetLeagueInfo(summonerID, SummonerRegion);
            var entries = entryDataWrapper.summoners;

            foreach (var entry in entries)
            {
                Well_Played.Models.Summoner myEntry = entry;
                result = myEntry;
            }

            result.name = entryDataWrapper.name;
            result.tier = entryDataWrapper.tier;

            return result;
        }

        //Get LEAGUE Information
        public async static Task<Models.League> GetLeagueInfo(string SummonerID, string SummonerRegion)
        {
            //Assemble the URL
            string url = string.Format("https://{0}.api.pvp.net/api/lol/{0}/v2.5/league/by-summoner/{1}/entry?api_key={2}", SummonerRegion, SummonerID, apikey);

            //Call out to RIOT
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            Models.League result = null;

            if (response.IsSuccessStatusCode == true)
            {
                int startremovingfrom = jsonMessage.IndexOf("{");
                int Stopremovinghere = jsonMessage.IndexOf("{", startremovingfrom + 1);

                jsonMessage = jsonMessage.Remove(startremovingfrom, Stopremovinghere - startremovingfrom);
                jsonMessage = jsonMessage.TrimEnd('}');
                jsonMessage = jsonMessage.Substring(0, jsonMessage.IndexOf("}]}"));
                jsonMessage = jsonMessage + "}]}}";
                jsonMessage = jsonMessage.Replace("entries", "summoners");
            }
            else
            {
                jsonMessage = @"{""name"":""UnRanked"",""tier"":""UNRANKED"",""queue"":""RANKED_SOLO_5x5"",""summoners"":[{""playerOrTeamId"":""23386714"",""playerOrTeamName"":""NC KingHippo"",""division"":""n/a"",""leaguePoints"":0,""wins"":324,""losses"":333,""isHotStreak"":true,""isVeteran"":true,""isFreshBlood"":false,""isInactive"":false}]}}";
            }

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Models.League));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            //var result = (SummonerData)serializer.ReadObject(ms);
            result = (Models.League)serializer.ReadObject(ms);

            result = result;
            return result;
        }
    }
}
