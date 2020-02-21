using FaceitAPI.Models;

namespace FaceitAPI.Interfaces
{
    public interface IHubs : IApiBase
    {
        HubDetails GetHub(string hubId);

        Paging<Match> GetMatches(string hubId, string type = "all", int offset = 0, int limit = 20);

        Paging<SimpleMember> GetMembers(string hubId, int offset = 0, int limit = 20);

        Paging<Role> GetRoles(string hubId, int offset = 0, int limit = 20);

        Rules GetRules(string hubId);

        HubStatistics GetStatistics(string hubId, int offset = 0, int limit = 20);
    }
}