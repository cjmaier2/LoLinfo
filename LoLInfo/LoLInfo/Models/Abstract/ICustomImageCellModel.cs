using System;
namespace LoLInfo.Models
{
    //properties bound to in CustomImageCell
    public interface ICustomImageCellModel
    {
        string SquareImageUrl { get; }

        string PrimaryText { get; }

        string SecondaryText { get; }
    }
}
