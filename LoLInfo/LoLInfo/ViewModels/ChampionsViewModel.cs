using System;
using System.Threading.Tasks;
using LolInfo.Services.Services;
using Xamarin.Forms;

namespace LoLInfo.ViewModels
{
    public class ChampionsViewModel : BaseViewModel
    {
        ChampionService ChampService { get; } = new ChampionService();

        public ChampionsViewModel()
        {

        }

        public async Task<bool> LoadChampions()
        {
            var champs = await ChampService.GetChampions();
            return false;
        }
    }
}
