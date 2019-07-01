using System;
using System.Collections.Generic;
using System.Text;
using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Tournaments : ApiBase, ITournaments
    {
        public Tournaments(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public Brackets GetBrackets(string tournament_id)
        {
            return Get<Brackets>($"https://open.faceit.com/data/v4/tournaments/{tournament_id}/brackets");
        }

        public Paging<Match> GetMatches(string tournament_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<Match>>($"https://open.faceit.com/data/v4/tournaments/{tournament_id}/matches?offset={offset}&limit={limit}");
        }

        public TournamentTeams GetTeams(string tournament_id, int offset = 0, int limit = 20)
        {
            return Get<TournamentTeams>($"https://open.faceit.com/data/v4/tournaments/{tournament_id}/teams?offset={offset}&limit={limit}");
        }

        public Tournament GetTournament(string tournament_id)
        {
            return Get<Tournament>($"https://open.faceit.com/data/v4/tournaments/{tournament_id}?expanded=organizer,game");
        }

        public Paging<Tournament> GetTournaments(string game, string region, string type, int offset = 0, int limit = 20)
        {
            return Get<Paging<Tournament>>($"https://open.faceit.com/data/v4/tournaments?type={type}&game={game}&region={region}&offset={offset}&limit={limit}");
        }
    }
}
