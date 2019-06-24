using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Championship : ApiBase, IChampionship
    {
        public ChampionshipDetails GetChampionship(string championship_id)
        {
            return Get<ChampionshipDetails>($"https://open.faceit.com/data/v4/championships/{championship_id}?expanded=organizer,game");
        }

        public Paging<Match> GetMatches(string championship_id, string type = "all", int offset = 0, int limit = 20)
        {
            return Get<Paging<Match>>($"https://open.faceit.com/data/v4/championships/{championship_id}/matches?type={type}&offset={0}&limit={limit}");
        }
    }
}
