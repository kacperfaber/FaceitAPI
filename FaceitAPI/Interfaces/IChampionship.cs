using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IChampionships : IApiBase
    {
        ChampionshipDetails GetChampionship(string championship_id);

        Paging<Match> GetMatches(string championship_id, string type = "all", int offset = 0, int limit = 20);

        Paging<ChampionshipSubscription> GetSubscriptions(string championship_id, int offset = 0, int limit = 10);
    }
}