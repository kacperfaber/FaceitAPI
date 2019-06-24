using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IChampionship
    {
        ChampionshipDetails GetChampionship(string championship_id);
        
        Paging<Match> GetMatches(string championship_id, string type = "all", int offset = 0, int limit = 20);
    }
}
