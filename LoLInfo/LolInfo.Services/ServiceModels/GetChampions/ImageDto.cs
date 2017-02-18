using System;
namespace LolInfo.Services.ServiceModels
{
    public class ImageDto
    {
        public string Full { get; set; } //append to ChampionSquareImageUrl to get image

        public string Group { get; set; }

        public string Sprite { get; set; }

        public string W { get; set; }

        public string H { get; set; }

        public string X { get; set; }

        public string Y { get; set; }
    }
}
