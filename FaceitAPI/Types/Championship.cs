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

        public ChampionshipMatches GetMatches(string championshipid, string type = "all", int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }

        public ChampionshipSubscription GetSubscription(string championshipid, int offset = 0, int limit = 10)
        {
            throw new NotImplementedException();
        }
    }
}
