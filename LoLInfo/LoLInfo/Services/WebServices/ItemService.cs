using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LoLInfo.Models;
using LoLInfo.Services.Extensions;
using LoLInfo.Services.ServiceModels;
using LoLInfo.Services.WebServices;
using Newtonsoft.Json;

namespace LoLInfo.Services
{
    public class ItemService : BaseService
    {
        //dictionary to get champion image in match history
        public static Dictionary<int, string> ItemImageDictionary = new Dictionary<int, string>();

        public async Task<List<Item>> GetItems()
        {
            using (var client = new HttpClient())
            {
                var coreUrl = string.Format(ServiceConstants.GetItemsUrl, ServiceConstants.CurrentRegionCode);
                var queries = new List<string>() { "itemListData=all" };
                var url = GetRequestUrl(coreUrl, queries);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                var itemsDto = JsonConvert.DeserializeObject<ItemListDto>(json);
                var items = itemsDto.ToItems();

                foreach (var item in items)
                {
                    if (!ItemImageDictionary.ContainsKey(item.Id))
                    {
                        ItemImageDictionary.Add(item.Id, item.SquareImageUrl);
                    }
                }

                return items;
            }
        }
    }
}
