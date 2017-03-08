using System;
using System.Collections.Generic;

namespace LoLInfo.Models
{
    public class Champion : ICustomImageCellModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SearchName { get; set; }

        public string Title { get; set; }

        public List<Skin> Skins { get; set; }

        #region CustomImageCell Properties
        public string SquareImageUrl { get; set; }

        public string PrimaryText { get { return Name; } }

        public string SecondaryText { get { return Title; } }
        #endregion
    }
}
