using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Games : ApiBase, IGames
    {
        public Games(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public GameDetails GetGame(string game_id)
        {
            return Get<GameDetails>($"https://open.faceit.com/data/v4/games/{game_id}");
        }

        public Paging<GameDetails> GetGames(int offset = 0, int limit = 20)
        {
            return Get<Paging<GameDetails>>($"https://open.faceit.com/data/v4/games?offset={offset}&limit={limit}");
        }

        public GameDetails GetParent(string game_id)
        {
            return Get<GameDetails>($"https://open.faceit.com/data/v4/games/{game_id}/parent");
        }
    }
}