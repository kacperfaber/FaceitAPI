using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Championship : ApiBase, IChampionship
    {
        public Championship(IAuthorizable authorizable) : base(authorizable)
        {
            
        }

        public ChampionshipDetails GetChampionship(string id)
        {
            return Get<ChampionshipDetails>($"https://open.faceit.com/data/v4/championships/{id}");
        }

        public Paging<ChampionshipMatch> GetMatches(string id, string type = "all", int offset = 0, int limit = 20)
        {
            return Get<Paging<ChampionshipMatch>>($"https://open.faceit.com/data/v4/championships/{id}/matches?type={type}&offset={offset}&limit={limit}");
        }

        public Paging<ChampionshipSubscriptionItem> GetSubscription(string id, int offset = 0, int limit = 10)
        {
            return Get<Paging<ChampionshipSubscriptionItem>>($"https://open.faceit.com/data/v4/championships/{id}/subscriptions?offset={offset}&limit={limit}");
        }
    }
}
