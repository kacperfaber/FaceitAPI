using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface ITournaments : IApiBase
    {
        Paging<Tournament> GetTournaments(string game, string region, string type, int offset = 0, int limit = 20);

        Tournament GetTournament(string tournament_id);

        Brackets GetBrackets(string tournament_id);

        Paging<Match> GetMatches(string tournament_id, int offset = 0, int limit = 20);

        TournamentTeams GetTeams(string tournament_id, int offset = 0, int limit = 20);
    }
}