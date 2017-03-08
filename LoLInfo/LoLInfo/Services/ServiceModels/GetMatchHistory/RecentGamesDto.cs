using System;
namespace LoLInfo.Services.ServiceModels
{
    public class RecentGamesDto
    {
        public GameDto[] Games { get; set; }

        public long SummonerId { get; set; }
    }
}
