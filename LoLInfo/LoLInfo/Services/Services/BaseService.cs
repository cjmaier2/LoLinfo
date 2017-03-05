using System;
using System.Collections.Generic;
using System.Text;

namespace LolInfo.Services.Services
{
    public class BaseService
    {
        public string GetRequestUrl(string coreUrl, List<string> queryStrings = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ServiceConstants.BaseApiUrl + coreUrl + "?");
            if (queryStrings != null && queryStrings.Count > 0)
            {
                foreach (var query in queryStrings)
                {
                    sb.Append(query);
                    sb.Append("&");
                }
            }
            sb.Append("api_key=" + ServiceConstants.MyAPIKey);
            return sb.ToString();
        }
    }
}
