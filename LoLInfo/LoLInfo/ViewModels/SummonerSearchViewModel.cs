using System;
using System.Threading.Tasks;
using LoLInfo.Services.ServiceModels;
using LoLInfo.Services.WebServices;

namespace LoLInfo.ViewModels
{
    public class SummonerSearchViewModel : BaseViewModel
    {
        SummonerService SummonerService { get; } = new SummonerService();

        public SummonerSearchViewModel()
        {
            
        }

        public async Task<GameDto[]> GetMatchHistory(string summonerName)
        {
            try
            {
                IsBusy = true;
                var matchHistory = await SummonerService.GetMatchHistory(summonerName);
                return matchHistory;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
