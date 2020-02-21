using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Matches : ApiBase, IMatches
    {
        public Matches(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public Match GetMatch(string match_id)
        {
            return Get<Match>($"https://open.faceit.com/data/v4/matches/{match_id}");
        }

        public MatchStatistics GetMatchStatistics(string match_id)
        {
            return Get<MatchStatistics>($"https://open.faceit.com/data/v4/matches/{match_id}/stats");
        }
    }
}