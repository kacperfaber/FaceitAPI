using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IOrganizers : IApiBase
    {
        OrganizerDetails GetOrganizer(string organizer_id);

        OrganizerDetails GetOrganizerByName(string name);

        Paging<ChampionshipDetails> GetChampionships(string organizer_id, int offset = 0, int limit = 20);

        Paging<OrganizerGame> GetGames(string organizer_id);

        Paging<HubDetails> GetHubs(string organizer_id, int offset = 0, int limit = 20);

        Paging<Tournament> GetTournaments(string organizer_id, string type, int offset = 0, int limit = 20);
    }
}