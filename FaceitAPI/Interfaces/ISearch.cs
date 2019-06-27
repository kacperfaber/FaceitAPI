using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface ISearch
    {
        Paging<SimpleChampionship> GetChampionship(string name, string game = "", string region = "", string type = "all", int offset = 0, int limit = 20);

        Paging<SimpleHub> GetHubs(string name, string game = "", string region = "", int offset = 0, int limit = 20);

        Paging<SimpleOrganizer> GetOrganizers(string name, int offset = 0, int limit = 20);

        Paging<SimplePlayer> GetPlayers(string nickname, string game = "", string country = "", int offset = 0, int limit = 20);

        Paging<SimpleTeam> GetTeams(string nickname, string game = "", int offset = 0, int limit = 20);

        Paging<SimpleTournament> GetTournaments(string name, string game = "", string region = "", string type = "all", int offset = 0, int limit = 20);
    }
}
