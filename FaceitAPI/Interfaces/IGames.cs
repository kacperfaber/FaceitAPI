using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IGames : IApiBase
    {
        Paging<GameDetails> GetGames(int offset = 0, int limit = 20);

        GameDetails GetGame(string game_id);

        GameDetails GetParent(string game_id);
    }
}
