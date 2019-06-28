using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface ITeams
    {
        ChampionshipTeam GetTeam(string team_id);

        TeamStatistics GetTeamStatistics(string team_id, string game_id);

        Paging<Tournament> GetTeamTournaments(string team_id, int offset = 0, int limit = 20);
    }
}
