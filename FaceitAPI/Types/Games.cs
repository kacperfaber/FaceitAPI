using FaceitAPI.Interfaces;
using FaceitAPI.Models;
using System;

namespace FaceitAPI.Types
{
    public class Games : ApiBase, IGames
    {
        public Games(IAuthorizable authorizable) : base(authorizable)
        {

        }

        public GameDetails GetGame(string game_id)
        {
            throw new NotImplementedException();
        }

        public Paging<GameDetails> GetGames(int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }

        public GameDetails GetParent(string game_id)
        {
            throw new NotImplementedException();
        }
    }
}
