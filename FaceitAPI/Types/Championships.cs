using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Championships : ApiBase, IChampionships
    {
        public Championships(IAuthorizable authorizable) : base(authorizable)
        {

        }

        public ChampionshipDetails GetChampionship(string championshipId)
        {
            return Get<ChampionshipDetails>($"https://open.faceit.com/data/v4/championships/{championshipId}?expanded=organizer,game");
        }

        public Paging<Match> GetMatches(string championshipId, string type = "all", int offset = 0, int limit = 20)
        {
            return Get<Paging<Match>>($"https://open.faceit.com/data/v4/championships/{championshipId}/matches?type={type}&offset={0}&limit={limit}");
        }

        public Paging<ChampionshipSubscription> GetSubscriptions(string championshipId, int offset = 0, int limit = 10)
        {
            return Get<Paging<ChampionshipSubscription>>($"https://open.faceit.com/data/v4/championships/{championshipId}/subscriptions?offset={offset}&limit={limit}");
        }
    }
}
