using System;
namespace LolInfo.Services.Services
{
    public class BaseService
    {
        public string GetRequestUrl(string queryUrl)
        {
            return ServiceConstants.BaseApiUrl + queryUrl + "?api_key=" + ServiceConstants.MyAPIKey;
        }
    }
}
