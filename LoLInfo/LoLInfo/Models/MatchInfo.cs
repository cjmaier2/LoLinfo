using System;
namespace LoLInfo.Models
{
    public class MatchInfo
    {
        public string ChampionImage { get; set; }

        public string WinLossText { get; set; }

        public string GameMode { get; set; }

        public int Kills { get; set; }

        public int Deaths { get; set; }

        public int Assists { get; set; }

        public string KDAText
        {
            get
            {
                return $"{Kills} | {Deaths} | {Assists}";
            }
        }

        public string Item0Image { get; set; }

        public string Item1Image { get; set; }

        public string Item2Image { get; set; }

        public string Item3Image { get; set; }

        public string Item4Image { get; set; }

        public string Item5Image { get; set; }

        public string Item6Image { get; set; }
    }
}
