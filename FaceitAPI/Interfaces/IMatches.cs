using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IMatches : IApiBase
    {
        Match GetMatch(string match_id);

        MatchStatistics GetMatchStatistics(string match_id);
    }
}