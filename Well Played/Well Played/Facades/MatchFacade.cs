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
    class MatchFacade
    {
        private const string apikey = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";

        public static async Task<Well_Played.Models.MatchList> GetMatchList( string SummonerID )
        {
            //Assemble the URL
            string url = string.Format("https://na.api.pvp.net/api/lol/na/v1.3/game/by-summoner/{1}/recent?api_key={0}", apikey, SummonerID);

            /**
            https://na.api.pvp.net/api/lol/na/v1.3/game/by-summoner/23386714/recent?api_key=b2d88c91-7e1f-4ffb-87b9-6052306595c4
            **/

            //Call out to RIOT
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            var jsonMessage = await response.Content.ReadAsStringAsync();

            //Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(Models.MatchList));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (Models.MatchList)serializer.ReadObject(ms);

            //var result = notquiteresult.data;

            return result;
        }

        //Populate the Match Page
        public async static Task PopulateSummonerMatches(ObservableCollection<Models.Game> SummonerMatchesAsync, Models.MatchList ListOfMatches, Models.ItemList ListOfItems, string version)
        {
            List<Models.Game> matchList = ListOfMatches.games;
            
            foreach (Models.Game game in matchList)
            {
                Models.Champion myChampion = await ChampionFacade.GetNameImage(game.championId.ToString(), version);
                game.thumbnail = myChampion.thumbnail;

                game.stats.gameTime = game.stats.timePlayed / 60;

                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                game.gameDate = epoch.AddSeconds(game.createDate/1000);
                game.gameDate = game.gameDate;

                if (game.stats.win == true)
                {
                    game.win = "Victory";
                    game.color = "Green";
                }
                else
                {
                    game.win = "Defeat";
                    game.color = "Red";
                }

                //consider revising for efficiency using list instead of individual calls
                Models.SummonerSpell spellimage = await GetPartialSpell(game.spell1);
                game.spell1img = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", spellimage.image.full, version);
                spellimage = await GetPartialSpell(game.spell2);
                game.spell2img = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/spell/{0}", spellimage.image.full, version);

                game.stats.item0imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item0, version);
                game.stats.item1imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item1, version);
                game.stats.item2imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item2, version);
                game.stats.item3imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item3, version);
                game.stats.item4imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item4, version);
                game.stats.item5imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item5, version);
                game.stats.item6imageURL = string.Format("http://ddragon.leagueoflegends.com/cdn/{1}/img/item/{0}.png", game.stats.item6, version);
                
                SummonerMatchesAsync.Add(game);
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
