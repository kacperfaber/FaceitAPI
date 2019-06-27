using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Search : ApiBase, ISearch
    {
        public Search(IAuthorizable authorizable) : base(authorizable)
        {

        }

        public Paging<SimpleChampionship> GetChampionship(string name, string game = "", string region = "", string type = "all", int offset = 0, int limit = 20)
        {
            return Get<Paging<SimpleChampionship>>($"https://open.faceit.com/data/v4/search/championships?name={name}&game={game}&region={region}&type={type}&offset={offset}&limit={limit}");
        }

        public Paging<SimpleHub> GetHubs(string name, string game = "", string region = "", int offset = 0, int limit = 20)
        {
            return Get<Paging<SimpleHub>>($"https://open.faceit.com/data/v4/search/hubs?name={name}&region={region}&game={game}&offset={offset}&limit={limit}");
        }

        public Paging<SimpleOrganizer> GetOrganizers(string name, int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }

        public Paging<SimplePlayer> GetPlayers(string nickname, string game = "", string country = "", int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }

        public Paging<SimpleTeam> GetTeams(string nickname, string game = "", int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }

        public Paging<SimpleTournament> GetTournaments(string name, string game = "", string region = "", string type = "all", int offset = 0, int limit = 20)
        {
            throw new NotImplementedException();
        }
    }
}
