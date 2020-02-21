using FaceitAPI.Interfaces;
using FaceitAPI.Models;

namespace FaceitAPI.Types
{
    public class Hubs : ApiBase, IHubs
    {
        public Hubs(IAuthorizable authorizable) : base(authorizable)
        {
        }

        public HubDetails GetHub(string hub_id)
        {
            return Get<HubDetails>($"https://open.faceit.com/data/v4/hubs/{hub_id}?expanded=organizer,game");
        }

        public Paging<Match> GetMatches(string hub_id, string type = "all", int offset = 0, int limit = 20)
        {
            return Get<Paging<Match>>($"https://open.faceit.com/data/v4/hubs/{hub_id}/matches?type={type}&offset={offset}&limit={limit}");
        }

        public Paging<SimpleMember> GetMembers(string hub_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<SimpleMember>>($"https://open.faceit.com/data/v4/hubs/{hub_id}/members?offset={offset}&limit={limit}");
        }

        public Paging<Role> GetRoles(string hub_id, int offset = 0, int limit = 20)
        {
            return Get<Paging<Role>>($"https://open.faceit.com/data/v4/hubs/{hub_id}/roles?offset={offset}&limit={limit}");
        }

        public Rules GetRules(string hub_id)
        {
            return Get<Rules>($"https://open.faceit.com/data/v4/hubs/{hub_id}/rules");
        }

        public HubStatistics GetStatistics(string hub_id, int offset = 0, int limit = 20)
        {
            return Get<HubStatistics>($"https://open.faceit.com/data/v4/hubs/{hub_id}/stats?offset={offset}&limit={limit}");
        }
    }
}