using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;
using FaceitAPI.Types;

namespace FaceitAPI.Interfaces
{
    public interface IChampionship : IApiBase
    {
        ChampionshipDetails GetChampionship(string championship_id);
        
        Paging<Match> GetMatches(string championship_id, string type = "all", int offset = 0, int limit = 20);

        Paging<ChampionshipSubscription> GetSubscriptions(string championship_id, int offset = 0, int limit = 10);
    }
}
