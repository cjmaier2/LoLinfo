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
            set
            {
                RegionCodeIndex = Regions.IndexOf(value);
            }
        }

        public SettingsViewModel()
        {
            SummonerName = AppSettings.GetValueOrDefault<string>(Constants.SummonerNameSettingsKey, string.Empty);
            RegionCode = AppSettings.GetValueOrDefault<string>(Constants.RegionCodeSettingsKey, string.Empty);
        }

        public bool SaveSettings()
        {
            try
            {
                AppSettings.AddOrUpdateValue<string>(Constants.SummonerNameSettingsKey, SummonerName);
                AppSettings.AddOrUpdateValue<string>(Constants.RegionCodeSettingsKey, RegionCode);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
