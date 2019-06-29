using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Organizers : ApiBase, IOrganizers
    {
        public Organizers(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public Paging<ChampionshipDetails> GetChampionships(string organizer_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<ChampionshipDetails>>($"https://open.faceit.com/data/v4/organizers/{organizer_id}/championships?offset={offset}&limit={limit}");
        }

        public Paging<OrganizerGame> GetGames(string organizer_id)
        {
            return Get<Paging<OrganizerGame>>($"https://open.faceit.com/data/v4/organizers/{organizer_id}/games");
        }

        public Paging<HubDetails> GetHubs(string organizer_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<HubDetails>>($"https://open.faceit.com/data/v4/organizers/{organizer_id}/hubs?offset={offset}&limit={limit}");
        }

        public OrganizerDetails GetOrganizer(string organizer_id)
        {
            return Get<OrganizerDetails>($"https://open.faceit.com/data/v4/organizers/{organizer_id}");
        }

        public OrganizerDetails GetOrganizerByName(string name)
        {
            return Get<OrganizerDetails>($"https://open.faceit.com/data/v4/organizers?name={name}");
        }

        public Paging<Tournament> GetTournaments(string organizer_id, string type = "upcoming", int offset = 0, int limit = 20)
        {
            return Get<Paging<Tournament>>($"https://open.faceit.com/data/v4/organizers/{organizer_id}/tournaments?offset={offset}&limit={limit}&type={type}");
        }
    }
}
