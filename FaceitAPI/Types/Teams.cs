using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Teams : ApiBase, ITeams
    {
        public Teams(IAuthorizable auth) : base(auth)
        {

        }
        
        public ChampionshipTeam GetTeam(string team_id)
        {
            return Get<ChampionshipTeam>($"https://open.faceit.com/data/v4/teams/{team_id}");
        }

        public TeamStatistics GetTeamStatistics(string team_id, string game_id)
        {
            return Get<TeamStatistics>($"https://open.faceit.com/data/v4/teams/{team_id}/stats/{game_id}");
        }

        public Paging<Tournament> GetTeamTournaments(string team_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<Tournament>>($"https://open.faceit.com/data/v4/teams/{team_id}/tournaments?offset={offset}&limit={limit}");
        }
    }
}
