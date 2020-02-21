using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IRankings : IApiBase
    {
        Paging<SimpleGamePlayer> GetGlobalRankingForGame(string game_id, string region, string country, int offset = 0, int limit = 20);

        RankingPaging<SimpleGamePlayer> GetGlobalPositionForPlayer(string game_id, string region, string player_id, string country, int limit = 20);
    }
}