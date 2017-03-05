using System;
namespace LolInfo.Services
{
    public class ServiceConstants
    {
        //Full Riot Games API Reference: https://developer.riotgames.com/api/methods
        //Static Data API Documentation: https://developer.riotgames.com/docs/static-data

        public const string MyAPIKey = "Insert_API_Key_Here";

        //Region Constants
        public const string CurrentRegionCode = NorthAmerica;
        public const string Brazil = "BR";
        public const string EuropeNordicAndEast = "EUNE";
        public const string EuropeWest = "EUW";
        public const string Japan = "JP";
        public const string Korea = "KR";
        public const string LatinAmericaNorth = "LAN";
        public const string LatinAmericaSouth = "LAS";
        public const string NorthAmerica = "NA";
        public const string Oceania = "OCE";
        public const string PublicBetaEnvironment = "PBE";
        public const string Russia = "RU";
        public const string Turkey = "TR";

        //Service Call URLs
        public const string BaseApiUrl = "https://global.api.pvp.net";
        public const string GetChampionsUrl = "/api/lol/static-data/{0}/v1.2/champion"; //input: region
        public const string GetItemsUrl = "/api/lol/static-data/{0}/v1.2/item"; //input: region

        //Image URLs
        public const string ItemImageUrl = "http://ddragon.leagueoflegends.com/cdn/7.3.1/img/item/{0}"; //http://ddragon.leagueoflegends.com/cdn/7.3.1/img/item/3146.png
        public const string ChampionSquareImageUrl = "http://ddragon.leagueoflegends.com/cdn/7.3.1/img/champion/{0}"; //http://ddragon.leagueoflegends.com/cdn/7.3.1/img/champion/Thresh.png
        public const string ChampionLoadingImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/{0}"; //http://ddragon.leagueoflegends.com/cdn/img/champion/loading/Thresh_0.jpg //final number represents skin
        public const string ChampionSplashImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}"; //http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Thresh_0.jpg
    }
}
