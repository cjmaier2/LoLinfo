using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using LolInfo.Models;
using LolInfo.Services.ServiceModels;

namespace LolInfo.Services.Extensions
{
    public static class ItemMappingExtensions
    {
        public static List<Item> ToItems(this ItemListDto itemListDto)
        {
            var items = new List<Item>();
            foreach (KeyValuePair<string, ItemDto> entry in itemListDto.Data)
            {
                var item = entry.Value;
                if (string.IsNullOrWhiteSpace(item.Name) || item.Gold.Total == 0)
                    continue;
                
                items.Add(new Item()
                {
                    Id = item.Id,
                    Name = item.Name,
                    SearchName = Regex.Replace(item.Name.ToUpper(), @"[^\w\.@-]", ""), //strip special characters
                    Gold = item.Gold.Total,
                    SquareImageUrl = string.Format(ServiceConstants.ItemImageUrl, item.Image.Full)
                });
            }
            return items.OrderBy(c => c.Name).ToList();
        }
    }
}
