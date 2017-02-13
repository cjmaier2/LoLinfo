using System;
namespace LolInfo.Services
{
    public class ServiceConstants
    {
        //Full Riot Games API Reference: https://developer.riotgames.com/api/methods
        //Static Data API Documentation: https://developer.riotgames.com/docs/static-data

        //Image URLs
        public const string ItemImageUrl = "http://ddragon.leagueoflegends.com/cdn/7.3.1/img/item/{0}"; //http://ddragon.leagueoflegends.com/cdn/7.3.1/img/item/3146.png
        public const string ChampionSquareImageUrl = "http://ddragon.leagueoflegends.com/cdn/7.3.1/img/champion/{0}"; //http://ddragon.leagueoflegends.com/cdn/7.3.1/img/champion/Thresh.png
        public const string ChampionLoadingImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/{0}"; //http://ddragon.leagueoflegends.com/cdn/img/champion/loading/Thresh_0.jpg
        public const string ChampionSplashImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{0}"; //http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Thresh_0.jpg
    }
}
