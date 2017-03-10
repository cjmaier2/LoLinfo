using System;
using System.Threading.Tasks;
using LoLInfo.Services;

namespace LoLInfo.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public string SummonerName { get; set; }

        public int RegionCodeIndex { get; set; }
        public string RegionCode
        {
            get
            {
                return Regions[RegionCodeIndex];
            }
        }

        public SettingsViewModel()
        {
            
        }

        public bool SaveSettings()
        {
            return true;
        }
    }
}
