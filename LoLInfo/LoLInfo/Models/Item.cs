using System;
namespace LolInfo.Models
{
    public class Item : ICustomImageCellModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SearchName { get; set; }

        public int Gold { get; set; }

        #region CustomImageCell Properties
        public string SquareImageUrl { get; set; }

        public string PrimaryText { get { return Name; } }

        public string SecondaryText { get { return Gold.ToString() + " G"; } }
        #endregion
    }
}
