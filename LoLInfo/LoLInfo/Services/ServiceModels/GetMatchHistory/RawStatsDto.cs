using System;
namespace LoLInfo.Services.ServiceModels
{
    public class RawStatsDto
    {
        public int Assists { get; set; }

        public int ChampionsKilled { get; set; }

        public int DoubleKills { get; set; }

        public int FirstBlood { get; set; }

        public int Gold { get; set; }

        public int GoldEarned { get; set; }

        public int GoldSpent { get; set; }

        public int KillingSprees { get; set; }

        public int LargestKillingSpree { get; set; }

        public int LargestMultiKill { get; set; }

        public int Level { get; set; }

        public int MinionsKilled { get; set; }

        public int NumDeaths { get; set; }

        public int PlayerPosition { get; set; }

        public int PlayerRole { get; set; }

        public int TimePlayed { get; set; }

        public int TotalDamageTaken { get; set; }

        public int WardPlaced { get; set; }

        public bool Win { get; set; }
    }
}
