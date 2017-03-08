using System;
using System.Threading.Tasks;
using LoLInfo.Services.WebServices;

namespace LoLInfo.ViewModels
{
    public class SummonerSearchViewModel : BaseViewModel
    {
        SummonerService SummonerService { get; } = new SummonerService();

        public SummonerSearchViewModel()
        {
            
        }

        public async Task<long> GetMatchHistory(string searchText)
        {
            try
            {
                IsBusy = true;
                var matchHistory = await SummonerService.GetSummonerId(searchText);
                return matchHistory;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
