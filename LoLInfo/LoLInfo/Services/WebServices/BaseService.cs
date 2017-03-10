using System;
using System.Collections.Generic;
using System.Text;

namespace LoLInfo.Services.WebServices
{
    public class BaseService
    {
        public string GetRequestUrl(string coreUrl, List<string> queryStrings = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ServiceConstants.BaseStaticDataApiUrl + coreUrl + "?");
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

        public string GetRegionRequestUrl(string coreUrl, string regionCode, List<string> queryStrings = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(ServiceConstants.BaseRegionDataApiUrl, regionCode) + coreUrl + "?");
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
